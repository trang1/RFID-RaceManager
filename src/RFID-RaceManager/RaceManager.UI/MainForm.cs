using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using RaceManager.Data;
using ApplicationContext = RaceManager.Data.ApplicationContext;
using Color = System.Drawing.Color;
using System.Data.SQLite;

namespace RaceManager.UI
{
    public partial class MainForm : Form
    {
        private Reader.ReaderMethod reader;

        private ReaderSetting m_curSetting = new ReaderSetting();
        private InventoryBuffer m_curInventoryBuffer = new InventoryBuffer();
        private OperateTagBuffer m_curOperateTagBuffer = new OperateTagBuffer();
        private OperateTagISO18000Buffer m_curOperateTagISO18000Buffer = new OperateTagISO18000Buffer();

        //Before inventory, you need to set working antenna to identify whether the inventory operation is executing.
        private bool m_bInventory = false;
        //Identify whether reckon the command execution time, and the current inventory command needs to reckon time.
        private bool m_bReckonTime = false;
        //Real time inventory locking operation.
        private bool m_bLockTab = false;
        //ISO18000 tag continuously inventory mark.
        private bool m_bContinue = false;
        //Whether display the serial monitoring data.
        private bool m_bDisplayLog = false;
        //Record the number of ISO18000 tag written loop time.
        private int m_nLoopTimes = 0;
        //Record the number of ISO18000 tag's written characters.
        private int m_nBytes = 0;
        //Record the number of ISO18000 tag have been written loop time.
        private int m_nLoopedTimes = 0;
        //Real time inventory times.
        private int m_nTotal = 0;
        //Frequency of list updating.
        private int m_nRealRate = 20;
        //Record quick poll antenna parameter.
        private byte[] m_btAryData = new byte[10];
        //Record the total number of quick poll times.
        private int m_nSwitchTotal = 0;
        private int m_nSwitchTime = 0;

        private int m_nReceiveFlag = 0;

        // Race times
        TimeSpan _raceTime;
        HighResolutionTimer _timer = new HighResolutionTimer();

        ApplicationContext _db;
        Race _race;

        public MainForm()
        {
            InitializeComponent();

            _timer.Elapsed += _timer_Elapsed;
            btnRaceExport.Click += BtnRaceExport_Click;

            _db = new ApplicationContext();
            _race = new Race();

            cmbRaceMode.SelectedIndex = 0;
        }

        private void BtnRaceExport_Click(object sender, EventArgs e)
        {
            if (_selectedRaceEvent == null) return;

            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = $"{_selectedRaceEvent.Group.Name}({_selectedRaceEvent.Round}).csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                int columnCount = gvRace.ColumnCount;
                string columnNames = "";
                string[] output = new string[gvRace.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += $"{gvRace.Columns[i].Name},";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < gvRace.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += $"{gvRace.Rows[i - 1].Cells[j].Value},";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Your file was generated and its ready for use.");

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //The real example of accessing reader initialization.
            reader = new Reader.ReaderMethod();

            //Callback function
            reader.AnalyCallback = AnalyData;
            reader.ReceiveCallback = ReceiveData;
            reader.SendCallback = SendData;

            //Set the validity of interface element.
            //gbRS232.Enabled = false;
            gbTcpIp.Enabled = false;

            if (!Debugger.IsAttached)
                SetFormEnable(false);
            //rdbRS232.Checked = true;

            //Initialization connect the default configuration of reader.
            //cmbComPort.SelectedIndex = 0;
            //cmbBaudrate.SelectedIndex = 1;
            ipIpServer.IpAddressStr = "192.168.1.200";
            txtTcpPort.Text = "4001";


            rdbInventoryRealTag_CheckedChanged(sender, e);
            cmbSession.SelectedIndex = 0;
            cmbTarget.SelectedIndex = 0;
            cmbReturnLossFreq.SelectedIndex = 33;
            if (cbUserDefineFreq.Checked)
            {
                groupBox21.Enabled = false;
                groupBox23.Enabled = true;
            }
            else
            {
                groupBox21.Enabled = true;
                groupBox23.Enabled = false;
            }

            rdbTcpIp_CheckedChanged(this, e);
            tabCtrMain.TabPages.Remove(PagTranDataLog);
            tabCtrMain.TabPages.Remove(PagISO18000);

            //  tabEpcTest.Controls.Remove(pageRealMode);
            tabEpcTest.Controls.Remove(pageBufferedMode);
            // tabEpcTest.Controls.Remove(pageFast4AntMode);

            btnRaceStop.Enabled = false;

            _db.Races.Load();
        }

        private void ReceiveData(byte[] btAryReceiveData)
        {
            if (m_bDisplayLog)
            {
                string strLog = CCommondMethod.ByteArrayToString(btAryReceiveData, 0, btAryReceiveData.Length);

                WriteLog(lrtxtDataTran, strLog, 1);
            }
        }

        private void SendData(byte[] btArySendData)
        {
            if (m_bDisplayLog)
            {
                string strLog = CCommondMethod.ByteArrayToString(btArySendData, 0, btArySendData.Length);

                WriteLog(lrtxtDataTran, strLog, 0);
            }
        }

        private void AnalyData(Reader.MessageTran msgTran)
        {
            m_nReceiveFlag = 0;
            if (msgTran.PacketType != 0xA0)
            {
                return;
            }
            switch (msgTran.Cmd)
            {
                case 0x69:
                    ProcessSetProfile(msgTran);
                    break;
                case 0x6A:
                    ProcessGetProfile(msgTran);
                    break;
                case 0x71:
                    ProcessSetUartBaudrate(msgTran);
                    break;
                case 0x72:
                    ProcessGetFirmwareVersion(msgTran);
                    break;
                case 0x73:
                    ProcessSetReadAddress(msgTran);
                    break;
                case 0x74:
                    ProcessSetWorkAntenna(msgTran);
                    break;
                case 0x75:
                    ProcessGetWorkAntenna(msgTran);
                    break;
                case 0x76:
                    ProcessSetOutputPower(msgTran);
                    break;
                case 0x77:
                    ProcessGetOutputPower(msgTran);
                    break;
                case 0x78:
                    ProcessSetFrequencyRegion(msgTran);
                    break;
                case 0x79:
                    ProcessGetFrequencyRegion(msgTran);
                    break;
                case 0x7A:
                    ProcessSetBeeperMode(msgTran);
                    break;
                case 0x7B:
                    ProcessGetReaderTemperature(msgTran);
                    break;
                case 0x7C:
                    ProcessSetDrmMode(msgTran);
                    break;
                case 0x7D:
                    ProcessGetDrmMode(msgTran);
                    break;
                case 0x7E:
                    ProcessGetImpedanceMatch(msgTran);
                    break;
                case 0x60:
                    ProcessReadGpioValue(msgTran);
                    break;
                case 0x61:
                    ProcessWriteGpioValue(msgTran);
                    break;
                case 0x62:
                    ProcessSetAntDetector(msgTran);
                    break;
                case 0x63:
                    ProcessGetAntDetector(msgTran);
                    break;
                case 0x67:
                    ProcessSetReaderIdentifier(msgTran);
                    break;
                case 0x68:
                    ProcessGetReaderIdentifier(msgTran);
                    break;

                case 0x80:
                    ProcessInventory(msgTran);
                    break;
                case 0x81:
                    ProcessReadTag(msgTran);
                    break;
                case 0x82:
                    ProcessWriteTag(msgTran);
                    break;
                case 0x83:
                    ProcessLockTag(msgTran);
                    break;
                case 0x84:
                    ProcessKillTag(msgTran);
                    break;
                case 0x85:
                    ProcessSetAccessEpcMatch(msgTran);
                    break;
                case 0x86:
                    ProcessGetAccessEpcMatch(msgTran);
                    break;

                case 0x89:
                case 0x8B:
                    ProcessInventoryReal(msgTran);
                    break;
                case 0x8A:
                    ProcessFastSwitch(msgTran);
                    break;
                case 0x8D:
                    ProcessSetMonzaStatus(msgTran);
                    break;
                case 0x8E:
                    ProcessGetMonzaStatus(msgTran);
                    break;
                case 0x90:
                    ProcessGetInventoryBuffer(msgTran);
                    break;
                case 0x91:
                    ProcessGetAndResetInventoryBuffer(msgTran);
                    break;
                case 0x92:
                    ProcessGetInventoryBufferTagCount(msgTran);
                    break;
                case 0x93:
                    ProcessResetInventoryBuffer(msgTran);
                    break;
                case 0xb0:
                    ProcessInventoryISO18000(msgTran);
                    break;
                case 0xb1:
                    ProcessReadTagISO18000(msgTran);
                    break;
                case 0xb2:
                    ProcessWriteTagISO18000(msgTran);
                    break;
                case 0xb3:
                    ProcessLockTagISO18000(msgTran);
                    break;
                case 0xb4:
                    ProcessQueryISO18000(msgTran);
                    break;
                default:
                    break;
            }
        }

        private delegate void WriteLogUnSafe(CustomControl.LogRichTextBox logRichTxt, string strLog, int nType);
        private void WriteLog(CustomControl.LogRichTextBox logRichTxt, string strLog, int nType)
        {
            if (this.InvokeRequired)
            {
                WriteLogUnSafe InvokeWriteLog = new WriteLogUnSafe(WriteLog);
                this.Invoke(InvokeWriteLog, new object[] { logRichTxt, strLog, nType });
            }
            else
            {
                if (nType == 0)
                {
                    logRichTxt.AppendTextEx(strLog, Color.Indigo);
                }
                else
                {
                    logRichTxt.AppendTextEx(strLog, Color.Red);
                }

                if (ckClearOperationRec.Checked)
                {
                    if (logRichTxt.Lines.Length > 50)
                    {
                        logRichTxt.Clear();
                    }
                }

                logRichTxt.Select(logRichTxt.TextLength, 0);
                logRichTxt.ScrollToCaret();
            }
        }

        private delegate void RefreshInventoryUnsafe(byte btCmd);
        private void RefreshInventory(byte btCmd)
        {
            if (this.InvokeRequired)
            {
                RefreshInventoryUnsafe InvokeRefresh = new RefreshInventoryUnsafe(RefreshInventory);
                this.Invoke(InvokeRefresh, new object[] { btCmd });
            }
            else
            {
                switch (btCmd)
                {
                    case 0x80:
                        {
                            ledBuffer1.Text = m_curInventoryBuffer.nTagCount.ToString();
                            ledBuffer2.Text = m_curInventoryBuffer.nReadRate.ToString();

                            TimeSpan ts = m_curInventoryBuffer.dtEndInventory - m_curInventoryBuffer.dtStartInventory;
                            ledBuffer5.Text = (ts.Minutes * 60 * 1000 + ts.Seconds * 1000 + ts.Milliseconds).ToString();
                            int nTotalRead = 0;
                            foreach (int nTemp in m_curInventoryBuffer.lTotalRead)
                            {
                                nTotalRead += nTemp;
                            }
                            ledBuffer4.Text = nTotalRead.ToString();
                            int commandDuration = 0;
                            if (m_curInventoryBuffer.nReadRate > 0)
                            {
                                commandDuration = m_curInventoryBuffer.nDataCount * 1000 / m_curInventoryBuffer.nReadRate;
                            }
                            ledBuffer3.Text = commandDuration.ToString();
                            int currentAntDisplay = 0;
                            currentAntDisplay = m_curInventoryBuffer.nCurrentAnt + 1;

                        }
                        break;
                    case 0x90:
                    case 0x91:
                        {
                            int nCount = lvBufferList.Items.Count;
                            int nLength = m_curInventoryBuffer.dtTagTable.Rows.Count;
                            DataRow row = m_curInventoryBuffer.dtTagTable.Rows[nLength - 1];

                            ListViewItem item = new ListViewItem();
                            item.Text = (nCount + 1).ToString();
                            item.SubItems.Add(row[0].ToString());
                            item.SubItems.Add(row[1].ToString());
                            item.SubItems.Add(row[2].ToString());
                            item.SubItems.Add(row[3].ToString());

                            string strTemp = (Convert.ToInt32(row[4].ToString()) - 129).ToString() + "dBm";
                            item.SubItems.Add(strTemp);
                            byte byTemp = Convert.ToByte(row[4]);
                            /*   if (byTemp > 0x50)
                               {
                                   item.BackColor = Color.PowderBlue;
                               }
                               else if (byTemp < 0x30)
                               {
                                   item.BackColor = Color.LemonChiffon;
                               } */

                            item.SubItems.Add(row[5].ToString());

                            lvBufferList.Items.Add(item);
                            lvBufferList.Items[nCount].EnsureVisible();

                            labelBufferTagCount.Text = "Tag List: " + m_curInventoryBuffer.nTagCount.ToString() + " ";

                        }
                        break;
                    case 0x92:
                        {

                        }
                        break;
                    case 0x93:
                        {

                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private delegate void RefreshOpTagUnsafe(byte btCmd);
        private void RefreshOpTag(byte btCmd)
        {
            if (this.InvokeRequired)
            {
                RefreshOpTagUnsafe InvokeRefresh = new RefreshOpTagUnsafe(RefreshOpTag);
                this.Invoke(InvokeRefresh, new object[] { btCmd });
            }
            else
            {
                switch (btCmd)
                {
                    case 0x81:
                    case 0x82:
                    case 0x83:
                    case 0x84:
                        {
                            int nCount = ltvOperate.Items.Count;
                            int nLength = m_curOperateTagBuffer.dtTagTable.Rows.Count;

                            DataRow row = m_curOperateTagBuffer.dtTagTable.Rows[nLength - 1];

                            ListViewItem item = new ListViewItem();
                            item.Text = (nCount + 1).ToString();
                            item.SubItems.Add(row[0].ToString());
                            item.SubItems.Add(row[1].ToString());
                            item.SubItems.Add(row[2].ToString());
                            item.SubItems.Add(row[3].ToString());
                            item.SubItems.Add(row[4].ToString());
                            item.SubItems.Add(row[5].ToString());
                            item.SubItems.Add(row[6].ToString());

                            ltvOperate.Items.Add(item);
                        }
                        break;
                    case 0x86:
                        {
                            txtAccessEpcMatch.Text = m_curOperateTagBuffer.strAccessEpcMatch;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private delegate void RefreshInventoryRealUnsafe(byte btCmd);
        private void RefreshInventoryReal(byte btCmd)
        {
            if (this.InvokeRequired)
            {
                RefreshInventoryRealUnsafe InvokeRefresh = new RefreshInventoryRealUnsafe(RefreshInventoryReal);
                this.Invoke(InvokeRefresh, new object[] { btCmd });
            }
            else
            {
                switch (btCmd)
                {
                    case 0x89:
                    case 0x8B:
                        {
                            int nTagCount = m_curInventoryBuffer.dtTagTable.Rows.Count;
                            int nTotalRead = m_nTotal;// m_curInventoryBuffer.dtTagDetailTable.Rows.Count;
                            TimeSpan ts = m_curInventoryBuffer.dtEndInventory - m_curInventoryBuffer.dtStartInventory;
                            int nTotalTime = ts.Minutes * 60 * 1000 + ts.Seconds * 1000 + ts.Milliseconds;
                            int nCaculatedReadRate = 0;
                            int nCommandDuation = 0;

                            if (m_curInventoryBuffer.nReadRate == 0) //Software measure the speed before reader return speed.
                            {
                                if (nTotalTime > 0)
                                {
                                    nCaculatedReadRate = (nTotalRead * 1000 / nTotalTime);
                                }
                            }
                            else
                            {
                                nCommandDuation = m_curInventoryBuffer.nDataCount * 1000 / m_curInventoryBuffer.nReadRate;
                                nCaculatedReadRate = m_curInventoryBuffer.nReadRate;
                            }

                            //Variable of list
                            int nEpcCount = 0;
                            int nEpcLength = m_curInventoryBuffer.dtTagTable.Rows.Count;

                            ledReal1.Text = nTagCount.ToString();
                            ledReal2.Text = nCaculatedReadRate.ToString();

                            ledReal5.Text = nTotalTime.ToString();
                            ledReal3.Text = nTotalRead.ToString();
                            ledReal4.Text = nCommandDuation.ToString();  //The actual command execution time.
                            tbRealMaxRssi.Text = (m_curInventoryBuffer.nMaxRSSI - 129).ToString() + "dBm";
                            tbRealMinRssi.Text = (m_curInventoryBuffer.nMinRSSI - 129).ToString() + "dBm";
                            lbRealTagCount.Text = "Tags' EPC list (no-repeat): " + nTagCount.ToString() + " ";

                            nEpcCount = lvRealList.Items.Count;


                            if (nEpcCount < nEpcLength)
                            {
                                DataRow row = m_curInventoryBuffer.dtTagTable.Rows[nEpcLength - 1];

                                ListViewItem item = new ListViewItem();
                                item.Text = (nEpcCount + 1).ToString();
                                item.SubItems.Add(row[2].ToString());
                                item.SubItems.Add(row[0].ToString());
                                item.SubItems.Add(row[5].ToString());
                                item.SubItems.Add((Convert.ToInt32(row[4]) - 129).ToString() + "dBm");
                                item.SubItems.Add(row[6].ToString());
                                lvRealList.Items.Add(item);
                                lvRealList.Items[nEpcCount].EnsureVisible();
                            }
                            //else
                            //{
                            //    int nIndex = 0;
                            //    foreach (DataRow row in m_curInventoryBuffer.dtTagTable.Rows)
                            //    {
                            //        ListViewItem item = ltvInventoryEpc.Items[nIndex];
                            //        item.SubItems[3].Text = row[5].ToString();
                            //        nIndex++;
                            //    }
                            //}

                            //Update the number of read time in list.
                            if (m_nTotal % m_nRealRate == 1)
                            {
                                int nIndex = 0;
                                foreach (DataRow row in m_curInventoryBuffer.dtTagTable.Rows)
                                {
                                    ListViewItem item;
                                    item = lvRealList.Items[nIndex];
                                    item.SubItems[3].Text = row[5].ToString();
                                    item.SubItems[4].Text = (Convert.ToInt32(row[4]) - 129).ToString() + "dBm";
                                    item.SubItems[5].Text = row[6].ToString();

                                    nIndex++;
                                }
                            }

                            if (_timer.IsRunning && cmbRaceMode.SelectedIndex == 0)
                            {
                                RegisterTag();
                            }
                            //if (ltvInventoryEpc.SelectedIndices.Count != 0)
                            //{
                            //    int nDetailCount = ltvInventoryTag.Items.Count;
                            //    int nDetailLength = m_curInventoryBuffer.dtTagDetailTable.Rows.Count;

                            //    foreach (int nIndex in ltvInventoryEpc.SelectedIndices)
                            //    {
                            //        ListViewItem itemEpc = ltvInventoryEpc.Items[nIndex];
                            //        DataRow row = m_curInventoryBuffer.dtTagDetailTable.Rows[nDetailLength - 1];
                            //        if (itemEpc.SubItems[1].Text == row[0].ToString())
                            //        {
                            //            ListViewItem item = new ListViewItem();
                            //            item.Text = (nDetailCount + 1).ToString();
                            //            item.SubItems.Add(row[0].ToString());

                            //            string strTemp = (Convert.ToInt32(row[1].ToString()) - 129).ToString() + "dBm";
                            //            item.SubItems.Add(strTemp);
                            //            byte byTemp = Convert.ToByte(row[1]);
                            //            if (byTemp > 0x50)
                            //            {
                            //                item.BackColor = Color.PowderBlue;
                            //            }
                            //            else if (byTemp < 0x30)
                            //            {
                            //                item.BackColor = Color.LemonChiffon;
                            //            }

                            //            item.SubItems.Add(row[2].ToString());
                            //            item.SubItems.Add(row[3].ToString());

                            //            ltvInventoryTag.Items.Add(item);
                            //            ltvInventoryTag.Items[nDetailCount].EnsureVisible();
                            //        }
                            //    }
                            //}
                            //else
                            //{
                            //    int nDetailCount = ltvInventoryTag.Items.Count;
                            //    int nDetailLength = m_curInventoryBuffer.dtTagDetailTable.Rows.Count;

                            //    DataRow row = m_curInventoryBuffer.dtTagDetailTable.Rows[nDetailLength - 1];
                            //    ListViewItem item = new ListViewItem();
                            //    item.Text = (nDetailCount + 1).ToString();
                            //    item.SubItems.Add(row[0].ToString());

                            //    string strTemp = (Convert.ToInt32(row[1].ToString()) - 129).ToString() + "dBm";
                            //    item.SubItems.Add(strTemp);
                            //    byte byTemp = Convert.ToByte(row[1]);
                            //    if (byTemp > 0x50)
                            //    {
                            //        item.BackColor = Color.PowderBlue;
                            //    }
                            //    else if (byTemp < 0x30)
                            //    {
                            //        item.BackColor = Color.LemonChiffon;
                            //    }

                            //    item.SubItems.Add(row[2].ToString());
                            //    item.SubItems.Add(row[3].ToString());

                            //    ltvInventoryTag.Items.Add(item);
                            //    ltvInventoryTag.Items[nDetailCount].EnsureVisible();
                            //}


                        }
                        break;


                    case 0x00:
                    case 0x01:
                        {
                            m_bLockTab = false;


                        }
                        break;
                    default:
                        break;
                }
            }
        }



        private delegate void RefreshFastSwitchUnsafe(byte btCmd);
        private void RefreshFastSwitch(byte btCmd)
        {
            if (this.InvokeRequired)
            {
                RefreshFastSwitchUnsafe InvokeRefreshFastSwitch = new RefreshFastSwitchUnsafe(RefreshFastSwitch);
                this.Invoke(InvokeRefreshFastSwitch, new object[] { btCmd });
            }
            else
            {
                switch (btCmd)
                {
                    case 0x00:
                        {
                            int nTagCount = m_curInventoryBuffer.dtTagTable.Rows.Count;
                            int nTotalRead = m_nTotal;// m_curInventoryBuffer.dtTagDetailTable.Rows.Count;
                            TimeSpan ts = m_curInventoryBuffer.dtEndInventory - m_curInventoryBuffer.dtStartInventory;
                            int nTotalTime = ts.Minutes * 60 * 1000 + ts.Seconds * 1000 + ts.Milliseconds;

                            ledFast1.Text = nTagCount.ToString(); //Total number of tags
                            if (m_curInventoryBuffer.nCommandDuration > 0)
                            {
                                ledFast2.Text = (m_curInventoryBuffer.nDataCount * 1000 / m_curInventoryBuffer.nCommandDuration).ToString(); //Read speed
                            }
                            else
                            {
                                ledFast2.Text = "";
                            }

                            ledFast3.Text = m_curInventoryBuffer.nCommandDuration.ToString(); //Command duration

                            ledFast5.Text = nTotalTime.ToString(); //Total inventory duration
                            ledFast4.Text = nTotalRead.ToString();

                            txtFastMaxRssi.Text = (m_curInventoryBuffer.nMaxRSSI - 129).ToString() + "dBm";
                            txtFastMinRssi.Text = (m_curInventoryBuffer.nMinRSSI - 129).ToString() + "dBm";
                            txtFastTagList.Text = "Tags' EPC list (no-repeat): " + nTagCount.ToString() + " ";

                            //Forming the list
                            int nEpcCount = lvFastList.Items.Count;
                            int nEpcLength = m_curInventoryBuffer.dtTagTable.Rows.Count;
                            if (nEpcCount < nEpcLength)
                            {
                                DataRow row = m_curInventoryBuffer.dtTagTable.Rows[nEpcLength - 1];

                                ListViewItem item = new ListViewItem();
                                item.Text = (nEpcCount + 1).ToString();
                                item.SubItems.Add(row[2].ToString());
                                item.SubItems.Add(row[0].ToString());
                                //item.SubItems.Add(row[5].ToString());
                                item.SubItems.Add(row[7].ToString() + "  /  " + row[8].ToString() + "  /  " + row[9].ToString() + "  /  " + row[10]);
                                item.SubItems.Add((Convert.ToInt32(row[4]) - 129).ToString() + "dBm");
                                item.SubItems.Add(row[6].ToString());

                                lvFastList.Items.Add(item);
                                lvFastList.Items[nEpcCount].EnsureVisible();
                            }

                            //Update read frequency of list
                            if (m_nTotal % m_nRealRate == 1)
                            {
                                int nIndex = 0;
                                foreach (DataRow row in m_curInventoryBuffer.dtTagTable.Rows)
                                {
                                    ListViewItem item = lvFastList.Items[nIndex];
                                    //item.SubItems[3].Text = row[5].ToString();
                                    item.SubItems[3].Text = (row[7].ToString() + "  /  " + row[8].ToString() + "  /  " + row[9].ToString() + "  /  " + row[10]);
                                    item.SubItems[4].Text = (Convert.ToInt32(row[4]) - 129).ToString() + "dBm";
                                    item.SubItems[5].Text = row[6].ToString();

                                    nIndex++;
                                }
                            }

                            if (_timer.IsRunning && cmbRaceMode.SelectedIndex == 1)
                            {
                                RegisterTag();
                            }
                        }
                        break;
                    case 0x01:
                        {

                        }
                        break;
                    case 0x02:
                        {

                            //ledFast1.Text.Text = m_nSwitchTime.ToString();
                            //ledFast1.Text.Text = m_nSwitchTotal.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private delegate void RefreshReadSettingUnsafe(byte btCmd);
        private void RefreshReadSetting(byte btCmd)
        {
            if (this.InvokeRequired)
            {
                RefreshReadSettingUnsafe InvokeRefresh = new RefreshReadSettingUnsafe(RefreshReadSetting);
                this.Invoke(InvokeRefresh, new object[] { btCmd });
            }
            else
            {
                //htxtReadId.Text = string.Format("{0:X2}", m_curSetting.btReadId);
                switch (btCmd)
                {
                    case 0x6A:
                        if (m_curSetting.btLinkProfile == 0xd0)
                        {
                            rdbProfile0.Checked = true;
                        }
                        else if (m_curSetting.btLinkProfile == 0xd1)
                        {
                            rdbProfile1.Checked = true;
                        }
                        else if (m_curSetting.btLinkProfile == 0xd2)
                        {
                            rdbProfile2.Checked = true;
                        }
                        else if (m_curSetting.btLinkProfile == 0xd3)
                        {
                            rdbProfile3.Checked = true;
                        }
                        else
                        {
                        }

                        break;
                    case 0x68:
                        htbGetIdentifier.Text = m_curSetting.btReaderIdentifier;

                        break;
                    case 0x72:
                        {
                            txtFirmwareVersion.Text = m_curSetting.btMajor.ToString() + "." + m_curSetting.btMinor.ToString();
                        }
                        break;
                    case 0x75:
                        {
                            cmbWorkAnt.SelectedIndex = m_curSetting.btWorkAntenna;
                        }
                        break;
                    case 0x77:
                        {
                            txtOutputPower.Text = m_curSetting.btOutputPower.ToString();
                        }
                        break;
                    case 0x79:
                        {
                            switch (m_curSetting.btRegion)
                            {
                                case 0x01:
                                    {
                                        cbUserDefineFreq.Checked = false;
                                        textStartFreq.Text = "";
                                        TextFreqInterval.Text = "";
                                        textFreqQuantity.Text = "";
                                        rdbRegionFcc.Checked = true;
                                        cmbFrequencyStart.SelectedIndex = Convert.ToInt32(m_curSetting.btFrequencyStart) - 7;
                                        cmbFrequencyEnd.SelectedIndex = Convert.ToInt32(m_curSetting.btFrequencyEnd) - 7;
                                    }
                                    break;
                                case 0x02:
                                    {
                                        cbUserDefineFreq.Checked = false;
                                        textStartFreq.Text = "";
                                        TextFreqInterval.Text = "";
                                        textFreqQuantity.Text = "";
                                        rdbRegionEtsi.Checked = true;
                                        cmbFrequencyStart.SelectedIndex = Convert.ToInt32(m_curSetting.btFrequencyStart);
                                        cmbFrequencyEnd.SelectedIndex = Convert.ToInt32(m_curSetting.btFrequencyEnd);
                                    }
                                    break;
                                case 0x03:
                                    {
                                        cbUserDefineFreq.Checked = false;
                                        textStartFreq.Text = "";
                                        TextFreqInterval.Text = "";
                                        textFreqQuantity.Text = "";
                                        rdbRegionChn.Checked = true;
                                        cmbFrequencyStart.SelectedIndex = Convert.ToInt32(m_curSetting.btFrequencyStart) - 43;
                                        cmbFrequencyEnd.SelectedIndex = Convert.ToInt32(m_curSetting.btFrequencyEnd) - 43;
                                    }
                                    break;
                                case 0x04:
                                    {
                                        cbUserDefineFreq.Checked = true;
                                        rdbRegionChn.Checked = false;
                                        rdbRegionEtsi.Checked = false;
                                        rdbRegionFcc.Checked = false;
                                        cmbFrequencyStart.SelectedIndex = -1;
                                        cmbFrequencyEnd.SelectedIndex = -1;
                                        textStartFreq.Text = m_curSetting.nUserDefineStartFrequency.ToString();
                                        TextFreqInterval.Text = Convert.ToString(m_curSetting.btUserDefineFrequencyInterval * 10);
                                        textFreqQuantity.Text = m_curSetting.btUserDefineChannelQuantity.ToString();
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 0x7B:
                        {
                            string strTemperature = string.Empty;
                            if (m_curSetting.btPlusMinus == 0x0)
                            {
                                strTemperature = "-" + m_curSetting.btTemperature.ToString() + "℃";
                            }
                            else
                            {
                                strTemperature = m_curSetting.btTemperature.ToString() + "℃";
                            }
                            txtReaderTemperature.Text = strTemperature;
                        }
                        break;
                    case 0x7D:
                        {
                            if (m_curSetting.btDrmMode == 0x00)
                            {
                                rdbDrmModeClose.Checked = true;
                            }
                            else
                            {
                                rdbDrmModeOpen.Checked = true;
                            }
                        }
                        break;
                    case 0x7E:
                        {
                            textReturnLoss.Text = m_curSetting.btAntImpedance.ToString() + " dB";
                        }
                        break;


                    case 0x8E:
                        {
                            if (m_curSetting.btMonzaStatus == 0x8D)
                            {
                                rdbMonzaOn.Checked = true;
                            }
                            else
                            {
                                rdbMonzaOff.Checked = true;
                            }
                        }
                        break;
                    case 0x60:
                        {
                            if (m_curSetting.btGpio1Value == 0x00)
                            {
                                rdbGpio1Low.Checked = true;
                            }
                            else
                            {
                                rdbGpio1High.Checked = true;
                            }

                            if (m_curSetting.btGpio2Value == 0x00)
                            {
                                rdbGpio2Low.Checked = true;
                            }
                            else
                            {
                                rdbGpio2High.Checked = true;
                            }
                        }
                        break;
                    case 0x63:
                        {
                            tbAntDectector.Text = m_curSetting.btAntDetector.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private delegate void RunLoopInventoryUnsafe();
        private void RunLoopInventroy()
        {
            if (this.InvokeRequired)
            {
                RunLoopInventoryUnsafe InvokeRunLoopInventory = new RunLoopInventoryUnsafe(RunLoopInventroy);
                this.Invoke(InvokeRunLoopInventory, new object[] { });
            }
            else
            {
                //Verify whether all antennas are completed inventory
                if (m_curInventoryBuffer.nIndexAntenna < m_curInventoryBuffer.lAntenna.Count - 1 || m_curInventoryBuffer.nCommond == 0)
                {
                    if (m_curInventoryBuffer.nCommond == 0)
                    {
                        m_curInventoryBuffer.nCommond = 1;

                        if (m_curInventoryBuffer.bLoopInventoryReal)
                        {
                            //m_bLockTab = true;
                            //btnInventory.Enabled = false;
                            if (m_curInventoryBuffer.bLoopCustomizedSession)//User define Session and Inventoried Flag. 
                            {
                                reader.CustomizedInventory(m_curSetting.btReadId, m_curInventoryBuffer.btSession, m_curInventoryBuffer.btTarget, m_curInventoryBuffer.btRepeat);
                            }
                            else //Inventory tags in real time mode
                            {
                                reader.InventoryReal(m_curSetting.btReadId, m_curInventoryBuffer.btRepeat);

                            }
                        }
                        else
                        {
                            if (m_curInventoryBuffer.bLoopInventory)
                                reader.Inventory(m_curSetting.btReadId, m_curInventoryBuffer.btRepeat);
                        }
                    }
                    else
                    {
                        m_curInventoryBuffer.nCommond = 0;
                        m_curInventoryBuffer.nIndexAntenna++;

                        byte btWorkAntenna = m_curInventoryBuffer.lAntenna[m_curInventoryBuffer.nIndexAntenna];
                        reader.SetWorkAntenna(m_curSetting.btReadId, btWorkAntenna);
                        m_curSetting.btWorkAntenna = btWorkAntenna;
                    }
                }
                //Verify whether cycle inventory
                else if (m_curInventoryBuffer.bLoopInventory)
                {
                    m_curInventoryBuffer.nIndexAntenna = 0;
                    m_curInventoryBuffer.nCommond = 0;

                    byte btWorkAntenna = m_curInventoryBuffer.lAntenna[m_curInventoryBuffer.nIndexAntenna];
                    reader.SetWorkAntenna(m_curSetting.btReadId, btWorkAntenna);
                    m_curSetting.btWorkAntenna = btWorkAntenna;
                }
            }
        }

        private delegate void RunLoopFastSwitchUnsafe();
        private void RunLoopFastSwitch()
        {
            if (this.InvokeRequired)
            {
                RunLoopFastSwitchUnsafe InvokeRunLoopFastSwitch = new RunLoopFastSwitchUnsafe(RunLoopFastSwitch);
                this.Invoke(InvokeRunLoopFastSwitch, new object[] { });
            }
            else
            {
                if (m_curInventoryBuffer.bLoopInventory)
                {
                    reader.FastSwitchInventory(m_curSetting.btReadId, m_btAryData);
                }
            }
        }

        private delegate void RefreshISO18000Unsafe(byte btCmd);
        private void RefreshISO18000(byte btCmd)
        {
            if (this.InvokeRequired)
            {
                RefreshISO18000Unsafe InvokeRefreshISO18000 = new RefreshISO18000Unsafe(RefreshISO18000);
                this.Invoke(InvokeRefreshISO18000, new object[] { btCmd });
            }
            else
            {
                switch (btCmd)
                {
                    case 0xb0:
                        {
                            ltvTagISO18000.Items.Clear();
                            int nLength = m_curOperateTagISO18000Buffer.dtTagTable.Rows.Count;
                            int nIndex = 1;
                            foreach (DataRow row in m_curOperateTagISO18000Buffer.dtTagTable.Rows)
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = nIndex.ToString();
                                item.SubItems.Add(row[1].ToString());
                                item.SubItems.Add(row[0].ToString());
                                item.SubItems.Add(row[2].ToString());
                                ltvTagISO18000.Items.Add(item);

                                nIndex++;
                            }

                            //txtTagCountISO18000.Text = m_curOperateTagISO18000Buffer.dtTagTable.Rows.Count.ToString();

                            if (m_bContinue)
                            {
                                reader.InventoryISO18000(m_curSetting.btReadId);
                            }
                            else
                            {
                                WriteLog(lrtxtLog, "Stop", 0);
                            }
                        }
                        break;
                    case 0xb1:
                        {
                            htxtReadData18000.Text = m_curOperateTagISO18000Buffer.strReadData;
                        }
                        break;
                    case 0xb2:
                        {
                            //txtWriteLength.Text = m_curOperateTagISO18000Buffer.btWriteLength.ToString();
                        }
                        break;
                    case 0xb3:
                        {
                            //switch(m_curOperateTagISO18000Buffer.btStatus)
                            //{
                            //    case 0x00:
                            //        MessageBox.Show("The byte successfully locked");
                            //        break;
                            //    case 0xFE:
                            //        MessageBox.Show("Status of the byte is locked");
                            //        break;
                            //    case 0xFF:
                            //        MessageBox.Show("The byte can not be locked");
                            //        break;
                            //    default:
                            //        break;
                            //}
                        }
                        break;
                    case 0xb4:
                        {
                            switch (m_curOperateTagISO18000Buffer.btStatus)
                            {
                                case 0x00:
                                    txtStatus.Text = "This byte is not locked";
                                    break;
                                case 0xFE:
                                    txtStatus.Text = "Status of the byte is locked";
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private delegate void RunLoopISO18000Unsafe(int nLength);
        private void RunLoopISO18000(int nLength)
        {
            if (this.InvokeRequired)
            {
                RunLoopISO18000Unsafe InvokeRunLoopISO18000 = new RunLoopISO18000Unsafe(RunLoopISO18000);
                this.Invoke(InvokeRunLoopISO18000, new object[] { nLength });
            }
            else
            {
                //Judge whether write correctly.
                if (nLength == m_nBytes)
                {
                    m_nLoopedTimes++;
                    txtLoopTimes.Text = m_nLoopedTimes.ToString();
                }
                //Judge whether cycle is ended.
                m_nLoopTimes--;
                if (m_nLoopTimes > 0)
                {
                    WriteTagISO18000();
                }
            }
        }

        /*   private void rdbRS232_CheckedChanged(object sender, EventArgs e)
           {
               if (rdbRS232.Checked)
               {
                   gbRS232.Enabled = true;
                   btnDisconnectRs232.Enabled = false;

                   //Set button font color
                   btnConnectRs232.ForeColor = Color.Indigo;
                   SetButtonBold(btnConnectRs232);
                   if (btnConnectTcp.Font.Bold)
                   {
                       SetButtonBold(btnConnectTcp);
                   }                

                   gbTcpIp.Enabled = false;
               }
           }*/

        private void rdbTcpIp_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbTcpIp.Checked)
            //{
            gbTcpIp.Enabled = true;
            btnDisconnectTcp.Enabled = false;

            //Set button font color
            btnConnectTcp.ForeColor = Color.Indigo;
            //  if (btnConnectRs232.Font.Bold)
            //  {
            //      SetButtonBold(btnConnectRs232);
            //  }                
            SetButtonBold(btnConnectTcp);

            //  gbRS232.Enabled = false;
            //}
        }

        private void SetButtonBold(Button btnBold)
        {
            Font oldFont = btnBold.Font;
            Font newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            btnBold.Font = newFont;
        }

        private void SetRadioButtonBold(CheckBox ckBold)
        {
            Font oldFont = ckBold.Font;
            Font newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            ckBold.Font = newFont;
        }

        private void SetFormEnable(bool bIsEnable)
        {
            //gbConnectType.Enabled = (!bIsEnable);
            //gbCmdReaderAddress.Enabled = bIsEnable;
            gbCmdVersion.Enabled = bIsEnable;
            gbCmdBaudrate.Enabled = bIsEnable;
            gbCmdTemperature.Enabled = bIsEnable;
            gbCmdOutputPower.Enabled = bIsEnable;
            gbCmdAntenna.Enabled = bIsEnable;
            gbCmdDrm.Enabled = bIsEnable;
            gbCmdRegion.Enabled = bIsEnable;
            gbCmdBeeper.Enabled = bIsEnable;
            gbCmdReadGpio.Enabled = bIsEnable;
            gbCmdAntDetector.Enabled = bIsEnable;
            gbReturnLoss.Enabled = bIsEnable;
            gbProfile.Enabled = bIsEnable;

            btnResetReader.Enabled = bIsEnable;


            gbCmdOperateTag.Enabled = bIsEnable;

            btnInventoryISO18000.Enabled = bIsEnable;
            btnClear.Enabled = bIsEnable;
            gbISO1800ReadWrite.Enabled = bIsEnable;
            gbISO1800LockQuery.Enabled = bIsEnable;

            gbCmdManual.Enabled = bIsEnable;

            tabEpcTest.Enabled = bIsEnable;

            gbMonza.Enabled = bIsEnable;
            //lbChangeBaudrate.Enabled = bIsEnable;
            //cmbSetBaudrate.Enabled = bIsEnable;
            //btnSetUartBaudrate.Enabled = bIsEnable;
            btReaderSetupRefresh.Enabled = bIsEnable;

            btRfSetup.Enabled = bIsEnable;
        }

        /*   private void btnConnectRs232_Click(object sender, EventArgs e)
           {
               //Processing serial port to connect reader.
               string strException = string.Empty;
               string strComPort = cmbComPort.Text;
               int nBaudrate=Convert.ToInt32(cmbBaudrate.Text);

               int nRet = reader.OpenCom(strComPort, nBaudrate, out strException);
               if (nRet != 0)
               {
                   string strLog = "Connection failed, failure cause: " + strException; 
                   WriteLog(lrtxtLog, strLog, 1);

                   return;
               }
               else
               {
                   string strLog = "Connect" + strComPort + "@" + nBaudrate.ToString();
                   WriteLog(lrtxtLog, strLog, 0);
               }

               //Whether processing interface element is valid.
               SetFormEnable(true);


               btnConnectRs232.Enabled = false;
               btnDisconnectRs232.Enabled = true;

               //Set button font color.
               btnConnectRs232.ForeColor = Color.Black;
               btnDisconnectRs232.ForeColor = Color.Indigo;
               SetButtonBold(btnConnectRs232);
               SetButtonBold(btnDisconnectRs232);
           }

           private void btnDisconnectRs232_Click(object sender, EventArgs e)
           {
               //Processing serial port to disconnect reader.
               reader.CloseCom();

               //Whether processing interface element is valid.
               SetFormEnable(false);
               btnConnectRs232.Enabled = true;
               btnDisconnectRs232.Enabled = false;

               //Set button font color.
               btnConnectRs232.ForeColor = Color.Indigo;
               btnDisconnectRs232.ForeColor = Color.Black;
               SetButtonBold(btnConnectRs232);
               SetButtonBold(btnDisconnectRs232);
           }*/

        private void btnConnectTcp_Click(object sender, EventArgs e)
        {
            try
            {
                //Processing Tcp to connect reader.
                string strException = string.Empty;
                IPAddress ipAddress = IPAddress.Parse(ipIpServer.IpAddressStr);
                int nPort = Convert.ToInt32(txtTcpPort.Text);

                int nRet = reader.ConnectServer(ipAddress, nPort, out strException);
                if (nRet != 0)
                {
                    string strLog = "Connection failed, failure cause: " + strException;
                    WriteLog(lrtxtLog, strLog, 1);

                    return;
                }
                else
                {
                    string strLog = "Connect" + ipIpServer.IpAddressStr + "@" + nPort.ToString();
                    WriteLog(lrtxtLog, strLog, 0);
                }

                //Whether processing interface element is valid.
                SetFormEnable(true);
                btnConnectTcp.Enabled = false;
                btnDisconnectTcp.Enabled = true;

                //Set button font color.
                btnConnectTcp.ForeColor = Color.Black;
                btnDisconnectTcp.ForeColor = Color.Indigo;
                SetButtonBold(btnConnectTcp);
                SetButtonBold(btnDisconnectTcp);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDisconnectTcp_Click(object sender, EventArgs e)
        {
            //Processing Tcp to disconnect reader.
            reader.SignOut();

            //Whether processing interface element is valid.
            SetFormEnable(false);
            btnConnectTcp.Enabled = true;
            btnDisconnectTcp.Enabled = false;

            //Set button font color.
            btnConnectTcp.ForeColor = Color.Indigo;
            btnDisconnectTcp.ForeColor = Color.Black;
            SetButtonBold(btnConnectTcp);
            SetButtonBold(btnDisconnectTcp);
        }

        private void btnResetReader_Click(object sender, EventArgs e)
        {
            int nRet = reader.Reset(m_curSetting.btReadId);
            if (nRet != 0)
            {
                string strLog = "Reset reader fails";
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Reset reader";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        /*    private void btnSetReadAddress_Click(object sender, EventArgs e)
            {
                try
                {
                    if (htxtReadId.Text.Length != 0)
                    {
                        string strTemp = htxtReadId.Text.Trim();
                        reader.SetReaderAddress(m_curSetting.btReadId, Convert.ToByte(strTemp, 16));
                        m_curSetting.btReadId = Convert.ToByte(strTemp, 16);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }*/

        private void ProcessSetReadAddress(Reader.MessageTran msgTran)
        {
            string strCmd = "Set reader's address";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnGetFirmwareVersion_Click(object sender, EventArgs e)
        {
            reader.GetFirmwareVersion(m_curSetting.btReadId);
        }

        private void ProcessGetFirmwareVersion(Reader.MessageTran msgTran)
        {
            string strCmd = "Get Reader's firmware version";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 2)
            {
                m_curSetting.btMajor = msgTran.AryData[0];
                m_curSetting.btMinor = msgTran.AryData[1];
                m_curSetting.btReadId = msgTran.ReadId;

                RefreshReadSetting(msgTran.Cmd);
                WriteLog(lrtxtLog, strCmd, 0);
                return;
            }
            else if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        /*     private void btnSetUartBaudrate_Click(object sender, EventArgs e)
             {
                 if (cmbSetBaudrate.SelectedIndex != -1)
                 {
                     reader.SetUartBaudrate(m_curSetting.btReadId, cmbSetBaudrate.SelectedIndex + 3);
                     m_curSetting.btIndexBaudrate = Convert.ToByte(cmbSetBaudrate.SelectedIndex);
                 }            
             }*/

        private void ProcessSetUartBaudrate(Reader.MessageTran msgTran)
        {
            string strCmd = "Set Baudrate";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnGetReaderTemperature_Click(object sender, EventArgs e)
        {
            reader.GetReaderTemperature(m_curSetting.btReadId);
        }

        private void ProcessGetReaderTemperature(Reader.MessageTran msgTran)
        {
            string strCmd = "Get reader internal temperature";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 2)
            {
                m_curSetting.btReadId = msgTran.ReadId;
                m_curSetting.btPlusMinus = msgTran.AryData[0];
                m_curSetting.btTemperature = msgTran.AryData[1];

                RefreshReadSetting(msgTran.Cmd);
                WriteLog(lrtxtLog, strCmd, 0);
                return;
            }
            else if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnGetOutputPower_Click(object sender, EventArgs e)
        {
            reader.GetOutputPower(m_curSetting.btReadId);
        }

        private void ProcessGetOutputPower(Reader.MessageTran msgTran)
        {
            string strCmd = "Get RF Output Power";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                m_curSetting.btReadId = msgTran.ReadId;
                m_curSetting.btOutputPower = msgTran.AryData[0];

                RefreshReadSetting(0x77);
                WriteLog(lrtxtLog, strCmd, 0);
                return;
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnSetOutputPower_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOutputPower.Text.Length != 0)
                {
                    reader.SetOutputPower(m_curSetting.btReadId, Convert.ToByte(txtOutputPower.Text));
                    m_curSetting.btOutputPower = Convert.ToByte(txtOutputPower.Text);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProcessSetOutputPower(Reader.MessageTran msgTran)
        {
            string strCmd = "Set RF Output Power";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnGetWorkAntenna_Click(object sender, EventArgs e)
        {
            reader.GetWorkAntenna(m_curSetting.btReadId);
        }

        private void ProcessGetWorkAntenna(Reader.MessageTran msgTran)
        {
            string strCmd = "Get working antenna";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x00 || msgTran.AryData[0] == 0x01 || msgTran.AryData[0] == 0x02 || msgTran.AryData[0] == 0x03)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    m_curSetting.btWorkAntenna = msgTran.AryData[0];

                    RefreshReadSetting(0x75);
                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnSetWorkAntenna_Click(object sender, EventArgs e)
        {
            m_bInventory = false;
            byte btWorkAntenna = 0xFF;
            if (cmbWorkAnt.SelectedIndex != -1)
            {
                btWorkAntenna = (byte)cmbWorkAnt.SelectedIndex;
                reader.SetWorkAntenna(m_curSetting.btReadId, btWorkAntenna);
                m_curSetting.btWorkAntenna = btWorkAntenna;
            }
        }

        private void ProcessSetWorkAntenna(Reader.MessageTran msgTran)
        {
            int intCurrentAnt = 0;
            intCurrentAnt = m_curSetting.btWorkAntenna + 1;
            string strCmd = "Set working antenna successfully, Current Ant: Ant" + intCurrentAnt.ToString();

            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    //Verify inventory operations
                    if (m_bInventory)
                    {
                        RunLoopInventroy();
                    }
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);

            if (m_bInventory)
            {
                m_curInventoryBuffer.nCommond = 1;
                m_curInventoryBuffer.dtEndInventory = DateTime.Now;
                RunLoopInventroy();
            }
        }

        private void btnGetDrmMode_Click(object sender, EventArgs e)
        {
            reader.GetDrmMode(m_curSetting.btReadId);
        }

        private void ProcessGetDrmMode(Reader.MessageTran msgTran)
        {
            string strCmd = "Get DRM Status";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x00 || msgTran.AryData[0] == 0x01)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    m_curSetting.btDrmMode = msgTran.AryData[0];

                    RefreshReadSetting(0x7D);
                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnSetDrmMode_Click(object sender, EventArgs e)
        {
            byte btDrmMode = 0xFF;

            if (rdbDrmModeClose.Checked)
            {
                btDrmMode = 0x00;
            }
            else if (rdbDrmModeOpen.Checked)
            {
                btDrmMode = 0x01;
            }
            else
            {
                return;
            }

            reader.SetDrmMode(m_curSetting.btReadId, btDrmMode);
            m_curSetting.btDrmMode = btDrmMode;
        }

        private void ProcessSetDrmMode(Reader.MessageTran msgTran)
        {
            string strCmd = "Set DRM Status";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void rdbRegionFcc_CheckedChanged(object sender, EventArgs e)
        {
            cmbFrequencyStart.SelectedIndex = -1;
            cmbFrequencyEnd.SelectedIndex = -1;
            cmbFrequencyStart.Items.Clear();
            cmbFrequencyEnd.Items.Clear();

            float nStart = 902.00f;
            for (int nloop = 0; nloop < 53; nloop++)
            {
                string strTemp = nStart.ToString("0.00");
                cmbFrequencyStart.Items.Add(strTemp);
                cmbFrequencyEnd.Items.Add(strTemp);

                nStart += 0.5f;
            }
        }

        private void rdbRegionEtsi_CheckedChanged(object sender, EventArgs e)
        {
            cmbFrequencyStart.SelectedIndex = -1;
            cmbFrequencyEnd.SelectedIndex = -1;
            cmbFrequencyStart.Items.Clear();
            cmbFrequencyEnd.Items.Clear();

            float nStart = 865.00f;
            for (int nloop = 0; nloop < 7; nloop++)
            {
                string strTemp = nStart.ToString("0.00");
                cmbFrequencyStart.Items.Add(strTemp);
                cmbFrequencyEnd.Items.Add(strTemp);

                nStart += 0.5f;
            }
        }

        private void rdbRegionChn_CheckedChanged(object sender, EventArgs e)
        {
            cmbFrequencyStart.SelectedIndex = -1;
            cmbFrequencyEnd.SelectedIndex = -1;
            cmbFrequencyStart.Items.Clear();
            cmbFrequencyEnd.Items.Clear();

            float nStart = 920.00f;
            for (int nloop = 0; nloop < 11; nloop++)
            {
                string strTemp = nStart.ToString("0.00");
                cmbFrequencyStart.Items.Add(strTemp);
                cmbFrequencyEnd.Items.Add(strTemp);

                nStart += 0.5f;
            }
        }

        private string GetFreqString(byte btFreq)
        {
            string strFreq = string.Empty;

            if (m_curSetting.btRegion == 4)
            {
                float nExtraFrequency = btFreq * m_curSetting.btUserDefineFrequencyInterval * 10;
                float nstartFrequency = ((float)m_curSetting.nUserDefineStartFrequency) / 1000;
                float nStart = nstartFrequency + nExtraFrequency / 1000;
                string strTemp = nStart.ToString("0.000");
                return strTemp;
            }
            else
            {
                if (btFreq < 0x07)
                {
                    float nStart = 865.00f + Convert.ToInt32(btFreq) * 0.5f;

                    string strTemp = nStart.ToString("0.00");

                    return strTemp;
                }
                else
                {
                    float nStart = 902.00f + (Convert.ToInt32(btFreq) - 7) * 0.5f;

                    string strTemp = nStart.ToString("0.00");

                    return strTemp;
                }
            }
        }

        private void btnGetFrequencyRegion_Click(object sender, EventArgs e)
        {
            reader.GetFrequencyRegion(m_curSetting.btReadId);
        }

        private void ProcessGetFrequencyRegion(Reader.MessageTran msgTran)
        {
            string strCmd = "Query RF frequency spectrum";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 3)
            {
                m_curSetting.btReadId = msgTran.ReadId;
                m_curSetting.btRegion = msgTran.AryData[0];
                m_curSetting.btFrequencyStart = msgTran.AryData[1];
                m_curSetting.btFrequencyEnd = msgTran.AryData[2];

                RefreshReadSetting(0x79);
                WriteLog(lrtxtLog, strCmd, 0);
                return;
            }
            else if (msgTran.AryData.Length == 6)
            {
                m_curSetting.btReadId = msgTran.ReadId;
                m_curSetting.btRegion = msgTran.AryData[0];
                m_curSetting.btUserDefineFrequencyInterval = msgTran.AryData[1];
                m_curSetting.btUserDefineChannelQuantity = msgTran.AryData[2];
                m_curSetting.nUserDefineStartFrequency = msgTran.AryData[3] * 256 * 256 + msgTran.AryData[4] * 256 + msgTran.AryData[5];
                RefreshReadSetting(0x79);
                WriteLog(lrtxtLog, strCmd, 0);
                return;


            }
            else if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnSetFrequencyRegion_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbUserDefineFreq.Checked == true)
                {
                    int nStartFrequency = Convert.ToInt32(textStartFreq.Text);
                    int nFrequencyInterval = Convert.ToInt32(TextFreqInterval.Text);
                    nFrequencyInterval = nFrequencyInterval / 10;
                    byte btChannelQuantity = Convert.ToByte(textFreqQuantity.Text);
                    reader.SetUserDefineFrequency(m_curSetting.btReadId, nStartFrequency, (byte)nFrequencyInterval, btChannelQuantity);
                    m_curSetting.btRegion = 4;
                    m_curSetting.nUserDefineStartFrequency = nStartFrequency;
                    m_curSetting.btUserDefineFrequencyInterval = (byte)nFrequencyInterval;
                    m_curSetting.btUserDefineChannelQuantity = btChannelQuantity;
                }
                else
                {
                    byte btRegion = 0x00;
                    byte btStartFreq = 0x00;
                    byte btEndFreq = 0x00;

                    int nStartIndex = cmbFrequencyStart.SelectedIndex;
                    int nEndIndex = cmbFrequencyEnd.SelectedIndex;
                    if (nEndIndex < nStartIndex)
                    {
                        MessageBox.Show("Spectral range that does not meet specifications, please refer to the Serial Protocol");
                        return;
                    }

                    if (rdbRegionFcc.Checked)
                    {
                        btRegion = 0x01;
                        btStartFreq = Convert.ToByte(nStartIndex + 7);
                        btEndFreq = Convert.ToByte(nEndIndex + 7);
                    }
                    else if (rdbRegionEtsi.Checked)
                    {
                        btRegion = 0x02;
                        btStartFreq = Convert.ToByte(nStartIndex);
                        btEndFreq = Convert.ToByte(nEndIndex);
                    }
                    else if (rdbRegionChn.Checked)
                    {
                        btRegion = 0x03;
                        btStartFreq = Convert.ToByte(nStartIndex + 43);
                        btEndFreq = Convert.ToByte(nEndIndex + 43);
                    }
                    else
                    {
                        return;
                    }

                    reader.SetFrequencyRegion(m_curSetting.btReadId, btRegion, btStartFreq, btEndFreq);
                    m_curSetting.btRegion = btRegion;
                    m_curSetting.btFrequencyStart = btStartFreq;
                    m_curSetting.btFrequencyEnd = btEndFreq;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessSetFrequencyRegion(Reader.MessageTran msgTran)
        {
            string strCmd = "Set RF frequency spectrum";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnSetBeeperMode_Click(object sender, EventArgs e)
        {
            byte btBeeperMode = 0xFF;

            if (rdbBeeperModeSlient.Checked)
            {
                btBeeperMode = 0x00;
            }
            else if (rdbBeeperModeInventory.Checked)
            {
                btBeeperMode = 0x01;
            }
            else if (rdbBeeperModeTag.Checked)
            {
                btBeeperMode = 0x02;
            }
            else
            {
                return;
            }

            reader.SetBeeperMode(m_curSetting.btReadId, btBeeperMode);
            m_curSetting.btBeeperMode = btBeeperMode;
        }

        private void ProcessSetBeeperMode(Reader.MessageTran msgTran)
        {
            string strCmd = "Set reader's buzzer hehavior";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnReadGpioValue_Click(object sender, EventArgs e)
        {
            reader.ReadGpioValue(m_curSetting.btReadId);
        }

        private void ProcessReadGpioValue(Reader.MessageTran msgTran)
        {
            string strCmd = "Get GPIO status";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 2)
            {
                m_curSetting.btReadId = msgTran.ReadId;
                m_curSetting.btGpio1Value = msgTran.AryData[0];
                m_curSetting.btGpio2Value = msgTran.AryData[1];

                RefreshReadSetting(0x60);
                WriteLog(lrtxtLog, strCmd, 0);
                return;
            }
            else if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnWriteGpio3Value_Click(object sender, EventArgs e)
        {
            byte btGpioValue = 0xFF;

            if (rdbGpio3Low.Checked)
            {
                btGpioValue = 0x00;
            }
            else if (rdbGpio3High.Checked)
            {
                btGpioValue = 0x01;
            }
            else
            {
                return;
            }

            reader.WriteGpioValue(m_curSetting.btReadId, 0x03, btGpioValue);
            m_curSetting.btGpio3Value = btGpioValue;
        }

        private void btnWriteGpio4Value_Click(object sender, EventArgs e)
        {
            byte btGpioValue = 0xFF;

            if (rdbGpio4Low.Checked)
            {
                btGpioValue = 0x00;
            }
            else if (rdbGpio4High.Checked)
            {
                btGpioValue = 0x01;
            }
            else
            {
                return;
            }

            reader.WriteGpioValue(m_curSetting.btReadId, 0x04, btGpioValue);
            m_curSetting.btGpio4Value = btGpioValue;
        }

        private void ProcessWriteGpioValue(Reader.MessageTran msgTran)
        {
            string strCmd = "Set GPIO status";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnGetAntDetector_Click(object sender, EventArgs e)
        {
            reader.GetAntDetector(m_curSetting.btReadId);
        }

        private void ProcessGetAntDetector(Reader.MessageTran msgTran)
        {
            string strCmd = "Get antenna detector threshold value";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                m_curSetting.btReadId = msgTran.ReadId;
                m_curSetting.btAntDetector = msgTran.AryData[0];

                RefreshReadSetting(0x63);
                WriteLog(lrtxtLog, strCmd, 0);
                return;
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void ProcessGetMonzaStatus(Reader.MessageTran msgTran)
        {
            string strCmd = "Get current Impinj FastTID setting";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x00 || msgTran.AryData[0] == 0x8D)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    m_curSetting.btAntDetector = msgTran.AryData[0];

                    RefreshReadSetting(0x8E);
                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void ProcessSetMonzaStatus(Reader.MessageTran msgTran)
        {
            string strCmd = "Set Impinj FastTID function";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    m_curSetting.btAntDetector = msgTran.AryData[0];

                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void ProcessSetProfile(Reader.MessageTran msgTran)
        {
            string strCmd = "Set RF link profile";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    m_curSetting.btLinkProfile = msgTran.AryData[0];

                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void ProcessGetProfile(Reader.MessageTran msgTran)
        {
            string strCmd = "Get RF link profile";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if ((msgTran.AryData[0] >= 0xd0) && (msgTran.AryData[0] <= 0xd3))
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    m_curSetting.btLinkProfile = msgTran.AryData[0];

                    RefreshReadSetting(0x6A);
                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }



        private void ProcessGetReaderIdentifier(Reader.MessageTran msgTran)
        {
            string strCmd = "Get Reader Identifier";
            string strErrorCode = string.Empty;
            short i;
            string readerIdentifier = "";

            if (msgTran.AryData.Length == 12)
            {
                m_curSetting.btReadId = msgTran.ReadId;
                for (i = 0; i < 12; i++)
                {
                    readerIdentifier = readerIdentifier + string.Format("{0:X2}", msgTran.AryData[i]) + " ";


                }
                m_curSetting.btReaderIdentifier = readerIdentifier;
                RefreshReadSetting(0x68);

                WriteLog(lrtxtLog, strCmd, 0);
                return;
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void ProcessGetImpedanceMatch(Reader.MessageTran msgTran)
        {
            string strCmd = "Measure Impedance of Antenna Port Match";
            string strErrorCode = string.Empty;


            if (msgTran.AryData.Length == 1)
            {
                m_curSetting.btReadId = msgTran.ReadId;

                m_curSetting.btAntImpedance = msgTran.AryData[0];
                RefreshReadSetting(0x7E);

                WriteLog(lrtxtLog, strCmd, 0);
                return;
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }



        private void ProcessSetReaderIdentifier(Reader.MessageTran msgTran)
        {
            string strCmd = "Set Reader Identifier";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }


        private void btnSetAntDetector_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAntDectector.Text.Length != 0)
                {
                    reader.SetAntDetector(m_curSetting.btReadId, Convert.ToByte(tbAntDectector.Text));
                    m_curSetting.btAntDetector = Convert.ToByte(tbAntDectector.Text);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProcessSetAntDetector(Reader.MessageTran msgTran)
        {
            string strCmd = "Set antenna detector threshold value";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);
        }

        private void rdbInventoryTag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbOperateTag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbInventoryRealTag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbdFastSwitchInventory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            /*try
            {                
                if (rbdFastSwitchInventory.Checked)
                {
                }
                else
                {
                    m_curInventoryBuffer.ClearInventoryPar();

                    if (txtChannel.Text.Length == 0)
                    {
                        MessageBox.Show("Please enter frequency hopping No.");
                        return;
                    }
                    m_curInventoryBuffer.btChannel = Convert.ToByte(txtChannel.Text);

                    if (ckWorkAntenna1.Checked)
                    {
                        m_curInventoryBuffer.lAntenna.Add(0x00);
                    }
                    if (ckWorkAntenna2.Checked)
                    {
                        m_curInventoryBuffer.lAntenna.Add(0x01);
                    }
                    if (ckWorkAntenna3.Checked)
                    {
                        m_curInventoryBuffer.lAntenna.Add(0x02);
                    }
                    if (ckWorkAntenna4.Checked)
                    {
                        m_curInventoryBuffer.lAntenna.Add(0x03);
                    }
                    if (m_curInventoryBuffer.lAntenna.Count == 0)
                    {
                        MessageBox.Show("One antenna must be selected");
                        return;
                    }
                }                

                //Default cycle to send commands.
                if (m_curInventoryBuffer.bLoopInventory)
                {
                    m_bInventory = false;
                    m_curInventoryBuffer.bLoopInventory = false;
                    btnInventory.BackColor = Color.WhiteSmoke;
                    btnInventory.ForeColor = Color.Indigo;
                    btnInventory.Text = "Inventory";
                    return;
                }
                else
                {
                    //Whether ISO 18000-6B Inventory is runing.
                    if (m_bContinue)
                    {
                        if (MessageBox.Show("ISO 18000-6B tag is inventoring, whether to stop?", "Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                        {
                            return;
                        }
                        else
                        {
                            btnInventoryISO18000_Click(sender, e);
                            return;
                        }
                    }

                    m_bInventory = true; 
                    m_curInventoryBuffer.bLoopInventory = true;
                    btnInventory.BackColor = Color.Indigo;
                    btnInventory.ForeColor = Color.White;
                    btnInventory.Text = "Stop";
                }

                if (rdbInventoryRealTag.Checked)
                {
                    m_curInventoryBuffer.bLoopInventoryReal = true;
                }

                m_curInventoryBuffer.ClearInventoryRealResult();
                ltvInventoryEpc.Items.Clear();
                ltvInventoryTag.Items.Clear();
                m_nTotal = 0;
                if (rbdFastSwitchInventory.Checked)
                {
                    if (cmbAntSelect1.SelectedIndex == -1)
                    {
                        m_btAryData[0] = 0xFF;
                    }
                    else
                    {
                        m_btAryData[0] = Convert.ToByte(cmbAntSelect1.SelectedIndex);
                    }
                    if (txtStayA.Text.Length == 0)
                    {
                        m_btAryData[1] = 0x00;
                    }
                    else
                    {
                        m_btAryData[1] = Convert.ToByte(txtStayA.Text);
                    }

                    if (cmbAntSelect2.SelectedIndex == -1)
                    {
                        m_btAryData[2] = 0xFF;
                    }
                    else
                    {
                        m_btAryData[2] = Convert.ToByte(cmbAntSelect2.SelectedIndex);
                    }
                    if (txtStayB.Text.Length == 0)
                    {
                        m_btAryData[3] = 0x00;
                    }
                    else
                    {
                        m_btAryData[3] = Convert.ToByte(txtStayB.Text);
                    }

                    if (cmbAntSelect3.SelectedIndex == -1)
                    {
                        m_btAryData[4] = 0xFF;
                    }
                    else
                    {
                        m_btAryData[4] = Convert.ToByte(cmbAntSelect3.SelectedIndex);
                    }
                    if (txtStayC.Text.Length == 0)
                    {
                        m_btAryData[5] = 0x00;
                    }
                    else
                    {
                        m_btAryData[5] = Convert.ToByte(txtStayC.Text);
                    }

                    if (cmbAntSelect4.SelectedIndex == -1)
                    {
                        m_btAryData[6] = 0xFF;
                    }
                    else
                    {
                        m_btAryData[6] = Convert.ToByte(cmbAntSelect4.SelectedIndex);
                    }
                    if (txtStayD.Text.Length == 0)
                    {
                        m_btAryData[7] = 0x00;
                    }
                    else
                    {
                        m_btAryData[7] = Convert.ToByte(txtStayD.Text);
                    }

                    if (txtInterval.Text.Length == 0)
                    {
                        m_btAryData[8] = 0x00;
                    }
                    else
                    {
                        m_btAryData[8] = Convert.ToByte(txtInterval.Text);
                    }

                    if (txtRepeat.Text.Length == 0)
                    {
                        m_btAryData[9] = 0x00;
                    }
                    else
                    {
                        m_btAryData[9] = Convert.ToByte(txtRepeat.Text);
                    }

                    m_nSwitchTotal = 0;
                    m_nSwitchTime = 0;
                    reader.FastSwitchInventory(m_curSetting.btReadId, m_btAryData);
                }
                else
                {
                    byte btWorkAntenna = m_curInventoryBuffer.lAntenna[m_curInventoryBuffer.nIndexAntenna];
                    reader.SetWorkAntenna(m_curSetting.btReadId, btWorkAntenna);
                }                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     */
        }

        private void ProcessFastSwitch(Reader.MessageTran msgTran)
        {
            string strCmd = "Real time inventory with fast ant switch";
            string strErrorCode = string.Empty;
            m_curInventoryBuffer.drLastTag = null;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
                RefreshFastSwitch(0x01);
                RunLoopFastSwitch();
            }
            else if (msgTran.AryData.Length == 2)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[1]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode + "--" + "Antenna" + (msgTran.AryData[0] + 1);

                WriteLog(lrtxtLog, strLog, 1);
            }

            else if (msgTran.AryData.Length == 7)
            {
                m_nSwitchTotal = Convert.ToInt32(msgTran.AryData[0]) * 255 * 255 + Convert.ToInt32(msgTran.AryData[1]) * 255 +
                                 Convert.ToInt32(msgTran.AryData[2]);
                m_nSwitchTime = Convert.ToInt32(msgTran.AryData[3]) * 255 * 255 * 255 +
                                Convert.ToInt32(msgTran.AryData[4]) * 255 * 255 + Convert.ToInt32(msgTran.AryData[5]) * 255 +
                                Convert.ToInt32(msgTran.AryData[6]);

                m_curInventoryBuffer.nDataCount = m_nSwitchTotal;
                m_curInventoryBuffer.nCommandDuration = m_nSwitchTime;
                WriteLog(lrtxtLog, strCmd, 0);
                RefreshFastSwitch(0x02);
                RunLoopFastSwitch();
            }

            /*else if (msgTran.AryData.Length == 8)
            {
                
                m_nSwitchTotal = Convert.ToInt32(msgTran.AryData[0]) * 255 * 255 * 255 + Convert.ToInt32(msgTran.AryData[1]) * 255 * 255 + Convert.ToInt32(msgTran.AryData[2]) * 255 + Convert.ToInt32(msgTran.AryData[3]);
                m_nSwitchTime = Convert.ToInt32(msgTran.AryData[4]) * 255 * 255 * 255 + Convert.ToInt32(msgTran.AryData[5]) * 255 * 255 + Convert.ToInt32(msgTran.AryData[6]) * 255 + Convert.ToInt32(msgTran.AryData[7]);

                m_curInventoryBuffer.nDataCount = m_nSwitchTotal;
                m_curInventoryBuffer.nCommandDuration = m_nSwitchTime;
                WriteLog(lrtxtLog, strCmd, 0);
                RefreshFastSwitch(0x02);
                RunLoopFastSwitch();
            }*/
            else
            {
                m_nTotal++;
                int nLength = msgTran.AryData.Length;
                int nEpcLength = nLength - 4;

                //Add inventory list
                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, nEpcLength);
                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, 2);
                string strRSSI = msgTran.AryData[nLength - 1].ToString();
                SetMaxMinRSSI(Convert.ToInt32(msgTran.AryData[nLength - 1]));
                byte btTemp = msgTran.AryData[0];
                byte btAntId = (byte)((btTemp & 0x03) + 1);
                m_curInventoryBuffer.nCurrentAnt = (int)btAntId;
                string strAntId = btAntId.ToString();
                byte btFreq = (byte)(btTemp >> 2);

                string strFreq = GetFreqString(btFreq);

                DataRow[] drs = m_curInventoryBuffer.dtTagTable.Select(string.Format("COLEPC = '{0}'", strEPC));
                if (drs.Length == 0)
                {
                    DataRow row1 = m_curInventoryBuffer.dtTagTable.NewRow();
                    row1[0] = strPC;
                    row1[2] = strEPC;
                    row1[4] = strRSSI;
                    row1[5] = "1";
                    row1[6] = strFreq;
                    row1[7] = "0";
                    row1[8] = "0";
                    row1[9] = "0";
                    row1[10] = "0";
                    switch (btAntId)
                    {
                        case 0x01:
                            {
                                row1[7] = "1";
                            }
                            break;
                        case 0x02:
                            {
                                row1[8] = "1";
                            }
                            break;
                        case 0x03:
                            {
                                row1[9] = "1";
                            }
                            break;
                        case 0x04:
                            {
                                row1[10] = "1";
                            }
                            break;
                        default:
                            break;
                    }

                    m_curInventoryBuffer.dtTagTable.Rows.Add(row1);
                    m_curInventoryBuffer.dtTagTable.AcceptChanges();


                }
                else
                {
                    foreach (DataRow dr in drs)
                    {
                        dr.BeginEdit();
                        int nTemp = 0;

                        dr[4] = strRSSI;
                        //dr[5] = (Convert.ToInt32(dr[5]) + 1).ToString();
                        nTemp = Convert.ToInt32(dr[5]);
                        dr[5] = (nTemp + 1).ToString();
                        dr[6] = strFreq;

                        switch (btAntId)
                        {
                            case 0x01:
                                {
                                    //dr[7] = (Convert.ToInt32(dr[7]) + 1).ToString();
                                    nTemp = Convert.ToInt32(dr[7]);
                                    dr[7] = (nTemp + 1).ToString();
                                }
                                break;
                            case 0x02:
                                {
                                    //dr[8] = (Convert.ToInt32(dr[8]) + 1).ToString();
                                    nTemp = Convert.ToInt32(dr[8]);
                                    dr[8] = (nTemp + 1).ToString();
                                }
                                break;
                            case 0x03:
                                {
                                    //dr[9] = (Convert.ToInt32(dr[9]) + 1).ToString();
                                    nTemp = Convert.ToInt32(dr[9]);
                                    dr[9] = (nTemp + 1).ToString();
                                }
                                break;
                            case 0x04:
                                {
                                    //dr[10] = (Convert.ToInt32(dr[10]) + 1).ToString();
                                    nTemp = Convert.ToInt32(dr[10]);
                                    dr[10] = (nTemp + 1).ToString();
                                }
                                break;
                            default:
                                break;
                        }

                        dr.EndEdit();
                    }
                    m_curInventoryBuffer.dtTagTable.AcceptChanges();
                }

                var row = m_curInventoryBuffer.dtTagDetailTable.NewRow();
                row[0] = strEPC;
                row[1] = strRSSI;
                row[2] = strAntId;
                row[3] = strFreq;
                Debug.WriteLine(row[0] + "\r\n" + row[1] + "\r\n" + row[2] + "\r\n" + row[3] + "\r\n");
                m_curInventoryBuffer.drLastTag = row;

                m_curInventoryBuffer.dtEndInventory = DateTime.Now;
                RefreshFastSwitch(0x00);
            }
        }

        private void ProcessInventoryReal(Reader.MessageTran msgTran)
        {
            string strCmd = "";
            m_curInventoryBuffer.drLastTag = null;

            if (msgTran.Cmd == 0x89)
            {
                strCmd = "Real time inventory";
            }
            if (msgTran.Cmd == 0x8B)
            {
                strCmd = "User define Session and Inventoried Flag inventory";
            }
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
                RefreshInventoryReal(0x00);
                RunLoopInventroy();
            }
            else if (msgTran.AryData.Length == 7)
            {
                m_curInventoryBuffer.nReadRate = Convert.ToInt32(msgTran.AryData[1]) * 256 + Convert.ToInt32(msgTran.AryData[2]);
                m_curInventoryBuffer.nDataCount = Convert.ToInt32(msgTran.AryData[3]) * 256 * 256 * 256 + Convert.ToInt32(msgTran.AryData[4]) * 256 * 256 + Convert.ToInt32(msgTran.AryData[5]) * 256 + Convert.ToInt32(msgTran.AryData[6]);

                WriteLog(lrtxtLog, strCmd, 0);
                RefreshInventoryReal(0x01);
                RunLoopInventroy();
            }
            else
            {
                m_nTotal++;
                int nLength = msgTran.AryData.Length;
                int nEpcLength = nLength - 4;

                //Add inventory list
                //if (msgTran.AryData[3] == 0x00)
                //{
                //    MessageBox.Show("");
                //}
                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, nEpcLength);
                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, 2);
                string strRSSI = msgTran.AryData[nLength - 1].ToString();
                SetMaxMinRSSI(Convert.ToInt32(msgTran.AryData[nLength - 1]));
                byte btTemp = msgTran.AryData[0];
                byte btAntId = (byte)((btTemp & 0x03) + 1);
                m_curInventoryBuffer.nCurrentAnt = btAntId;
                string strAntId = btAntId.ToString();

                byte btFreq = (byte)(btTemp >> 2);
                string strFreq = GetFreqString(btFreq);

                var row = m_curInventoryBuffer.dtTagDetailTable.NewRow();
                row[0] = strEPC;
                row[1] = strRSSI;
                row[2] = strAntId;
                row[3] = strFreq;
                Debug.WriteLine(row[0] + "\r\n" + row[1] + "\r\n");
                m_curInventoryBuffer.drLastTag = row;

                //m_curInventoryBuffer.dtTagDetailTable.Rows.Add(row);
                //m_curInventoryBuffer.dtTagDetailTable.AcceptChanges();

                ////Add tag list
                //DataRow[] drsDetail = m_curInventoryBuffer.dtTagDetailTable.Select(string.Format("COLEPC = '{0}'", strEPC));
                //int nDetailCount = drsDetail.Length;
                DataRow[] drs = m_curInventoryBuffer.dtTagTable.Select(string.Format("COLEPC = '{0}'", strEPC));
                if (drs.Length == 0)
                {
                    DataRow row1 = m_curInventoryBuffer.dtTagTable.NewRow();
                    row1[0] = strPC;
                    row1[2] = strEPC;
                    row1[4] = strRSSI;
                    row1[5] = "1";
                    row1[6] = strFreq;

                    m_curInventoryBuffer.dtTagTable.Rows.Add(row1);
                    m_curInventoryBuffer.dtTagTable.AcceptChanges();
                }
                else
                {
                    foreach (DataRow dr in drs)
                    {
                        dr.BeginEdit();

                        dr[4] = strRSSI;
                        dr[5] = (Convert.ToInt32(dr[5]) + 1).ToString();
                        dr[6] = strFreq;

                        dr.EndEdit();
                    }
                    m_curInventoryBuffer.dtTagTable.AcceptChanges();
                }

                m_curInventoryBuffer.dtEndInventory = DateTime.Now;
                RefreshInventoryReal(0x89);
            }
        }



        private void ProcessInventory(Reader.MessageTran msgTran)
        {
            string strCmd = "Inventory";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 9)
            {
                m_curInventoryBuffer.nCurrentAnt = msgTran.AryData[0];
                m_curInventoryBuffer.nTagCount = Convert.ToInt32(msgTran.AryData[1]) * 256 + Convert.ToInt32(msgTran.AryData[2]);
                m_curInventoryBuffer.nReadRate = Convert.ToInt32(msgTran.AryData[3]) * 256 + Convert.ToInt32(msgTran.AryData[4]);
                int nTotalRead = Convert.ToInt32(msgTran.AryData[5]) * 256 * 256 * 256
                    + Convert.ToInt32(msgTran.AryData[6]) * 256 * 256
                    + Convert.ToInt32(msgTran.AryData[7]) * 256
                    + Convert.ToInt32(msgTran.AryData[8]);
                m_curInventoryBuffer.nDataCount = nTotalRead;
                m_curInventoryBuffer.lTotalRead.Add(nTotalRead);
                m_curInventoryBuffer.dtEndInventory = DateTime.Now;

                RefreshInventory(0x80);
                WriteLog(lrtxtLog, strCmd, 0);

                RunLoopInventroy();

                return;
            }
            else if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;
            WriteLog(lrtxtLog, strLog, 1);

            RunLoopInventroy();
        }

        private void btnGetInventoryBuffer_Click(object sender, EventArgs e)
        {
            m_curInventoryBuffer.dtTagTable.Rows.Clear();

            reader.GetInventoryBuffer(m_curSetting.btReadId);
        }

        private void SetMaxMinRSSI(int nRSSI)
        {
            if (m_curInventoryBuffer.nMaxRSSI < nRSSI)
            {
                m_curInventoryBuffer.nMaxRSSI = nRSSI;
            }

            if (m_curInventoryBuffer.nMinRSSI == 0)
            {
                m_curInventoryBuffer.nMinRSSI = nRSSI;
            }
            else if (m_curInventoryBuffer.nMinRSSI > nRSSI)
            {
                m_curInventoryBuffer.nMinRSSI = nRSSI;
            }
        }

        private void ProcessGetInventoryBuffer(Reader.MessageTran msgTran)
        {
            string strCmd = "Get buffered data without clearing";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                int nDataLen = msgTran.AryData.Length;
                int nEpcLen = Convert.ToInt32(msgTran.AryData[2]) - 4;

                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, 2);
                string strEpc = CCommondMethod.ByteArrayToString(msgTran.AryData, 5, nEpcLen);
                string strCRC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5 + nEpcLen, 2);
                string strRSSI = msgTran.AryData[nDataLen - 3].ToString();
                SetMaxMinRSSI(Convert.ToInt32(msgTran.AryData[nDataLen - 3]));
                byte btTemp = msgTran.AryData[nDataLen - 2];
                byte btAntId = (byte)((btTemp & 0x03) + 1);
                string strAntId = btAntId.ToString();
                string strReadCnr = msgTran.AryData[nDataLen - 1].ToString();

                DataRow row = m_curInventoryBuffer.dtTagTable.NewRow();
                row[0] = strPC;
                row[1] = strCRC;
                row[2] = strEpc;
                row[3] = strAntId;
                row[4] = strRSSI;
                row[5] = strReadCnr;

                m_curInventoryBuffer.dtTagTable.Rows.Add(row);
                m_curInventoryBuffer.dtTagTable.AcceptChanges();

                RefreshInventory(0x90);
                WriteLog(lrtxtLog, strCmd, 0);
            }
        }

        private void btnGetAndResetInventoryBuffer_Click(object sender, EventArgs e)
        {
            m_curInventoryBuffer.dtTagTable.Rows.Clear();

            reader.GetAndResetInventoryBuffer(m_curSetting.btReadId);
        }

        private void ProcessGetAndResetInventoryBuffer(Reader.MessageTran msgTran)
        {
            string strCmd = "Get and clear buffered data";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                int nDataLen = msgTran.AryData.Length;
                int nEpcLen = Convert.ToInt32(msgTran.AryData[2]) - 4;

                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, 2);
                string strEpc = CCommondMethod.ByteArrayToString(msgTran.AryData, 5, nEpcLen);
                string strCRC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5 + nEpcLen, 2);
                string strRSSI = msgTran.AryData[nDataLen - 3].ToString();
                SetMaxMinRSSI(Convert.ToInt32(msgTran.AryData[nDataLen - 3]));
                byte btTemp = msgTran.AryData[nDataLen - 2];
                byte btAntId = (byte)((btTemp & 0x03) + 1);
                string strAntId = btAntId.ToString();
                string strReadCnr = msgTran.AryData[nDataLen - 1].ToString();

                DataRow row = m_curInventoryBuffer.dtTagTable.NewRow();
                row[0] = strPC;
                row[1] = strCRC;
                row[2] = strEpc;
                row[3] = strAntId;
                row[4] = strRSSI;
                row[5] = strReadCnr;

                m_curInventoryBuffer.dtTagTable.Rows.Add(row);
                m_curInventoryBuffer.dtTagTable.AcceptChanges();

                RefreshInventory(0x91);
                WriteLog(lrtxtLog, strCmd, 0);
            }
        }

        private void btnGetInventoryBufferTagCount_Click(object sender, EventArgs e)
        {
            reader.GetInventoryBufferTagCount(m_curSetting.btReadId);
        }

        private void ProcessGetInventoryBufferTagCount(Reader.MessageTran msgTran)
        {
            string strCmd = "Query how many tags are buffered";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 2)
            {
                m_curInventoryBuffer.nTagCount = Convert.ToInt32(msgTran.AryData[0]) * 256 + Convert.ToInt32(msgTran.AryData[1]);

                RefreshInventory(0x92);
                string strLog1 = strCmd + " " + m_curInventoryBuffer.nTagCount.ToString();
                WriteLog(lrtxtLog, strLog1, 0);
                return;
            }
            else if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnResetInventoryBuffer_Click(object sender, EventArgs e)
        {
            reader.ResetInventoryBuffer(m_curSetting.btReadId);
        }

        private void ProcessResetInventoryBuffer(Reader.MessageTran msgTran)
        {
            string strCmd = "Clear buffer";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    RefreshInventory(0x93);
                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

            WriteLog(lrtxtLog, strLog, 1);
        }

        private void cbAccessEpcMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAccessEpcMatch.Checked)
            {
                reader.GetAccessEpcMatch(m_curSetting.btReadId);
            }
            else
            {
                m_curOperateTagBuffer.strAccessEpcMatch = "";
                txtAccessEpcMatch.Text = "";
                reader.CancelAccessEpcMatch(m_curSetting.btReadId, 0x01);
            }
        }

        private void ProcessGetAccessEpcMatch(Reader.MessageTran msgTran)
        {
            string strCmd = "Get selected tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x01)
                {
                    WriteLog(lrtxtLog, "Unselected Tag", 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                if (msgTran.AryData[0] == 0x00)
                {
                    m_curOperateTagBuffer.strAccessEpcMatch = CCommondMethod.ByteArrayToString(msgTran.AryData, 2, Convert.ToInt32(msgTran.AryData[1]));

                    RefreshOpTag(0x86);
                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = "Unknown Error";
                }
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnSetAccessEpcMatch_Click(object sender, EventArgs e)
        {
            string[] reslut = CCommondMethod.StringToStringArray(cmbSetAccessEpcMatch.Text.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("Please select EPC number");
                return;
            }

            byte[] btAryEpc = CCommondMethod.StringArrayToByteArray(reslut, reslut.Length);

            m_curOperateTagBuffer.strAccessEpcMatch = cmbSetAccessEpcMatch.Text;
            txtAccessEpcMatch.Text = cmbSetAccessEpcMatch.Text;
            ckAccessEpcMatch.Checked = true;
            reader.SetAccessEpcMatch(m_curSetting.btReadId, 0x00, Convert.ToByte(btAryEpc.Length), btAryEpc);
        }

        private void ProcessSetAccessEpcMatch(Reader.MessageTran msgTran)
        {
            string strCmd = "Select/Deselect Tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    WriteLog(lrtxtLog, strCmd, 0);
                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown Error";
            }

            string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

            WriteLog(lrtxtLog, strLog, 1);
        }

        private void btnReadTag_Click(object sender, EventArgs e)
        {
            try
            {
                byte btMemBank = 0x00;
                byte btWordAdd = 0x00;
                byte btWordCnt = 0x00;

                if (rdbReserved.Checked)
                {
                    btMemBank = 0x00;
                }
                else if (rdbEpc.Checked)
                {
                    btMemBank = 0x01;
                }
                else if (rdbTid.Checked)
                {
                    btMemBank = 0x02;
                }
                else if (rdbUser.Checked)
                {
                    btMemBank = 0x03;
                }
                else
                {
                    MessageBox.Show("Please select the area of tag");
                    return;
                }

                if (txtWordAdd.Text.Length != 0)
                {
                    btWordAdd = Convert.ToByte(txtWordAdd.Text);
                }
                else
                {
                    MessageBox.Show("Please select the start Add of tag");
                    return;
                }

                if (txtWordCnt.Text.Length != 0)
                {
                    btWordCnt = Convert.ToByte(txtWordCnt.Text);
                }
                else
                {
                    MessageBox.Show("Please select the Length");
                    return;
                }

                m_curOperateTagBuffer.dtTagTable.Clear();
                ltvOperate.Items.Clear();
                reader.ReadTag(m_curSetting.btReadId, btMemBank, btWordAdd, btWordCnt);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProcessReadTag(Reader.MessageTran msgTran)
        {
            string strCmd = "Read Tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                int nLen = msgTran.AryData.Length;
                int nDataLen = Convert.ToInt32(msgTran.AryData[nLen - 3]);
                int nEpcLen = Convert.ToInt32(msgTran.AryData[2]) - nDataLen - 4;

                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, 2);
                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5, nEpcLen);
                string strCRC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5 + nEpcLen, 2);
                string strData = CCommondMethod.ByteArrayToString(msgTran.AryData, 7 + nEpcLen, nDataLen);

                byte byTemp = msgTran.AryData[nLen - 2];
                byte byAntId = (byte)((byTemp & 0x03) + 1);
                string strAntId = byAntId.ToString();

                string strReadCount = msgTran.AryData[nLen - 1].ToString();

                DataRow row = m_curOperateTagBuffer.dtTagTable.NewRow();
                row[0] = strPC;
                row[1] = strCRC;
                row[2] = strEPC;
                row[3] = strData;
                row[4] = nDataLen.ToString();
                row[5] = strAntId;
                row[6] = strReadCount;

                m_curOperateTagBuffer.dtTagTable.Rows.Add(row);
                m_curOperateTagBuffer.dtTagTable.AcceptChanges();

                RefreshOpTag(0x81);
                WriteLog(lrtxtLog, strCmd, 0);
            }
        }

        private void btnWriteTag_Click(object sender, EventArgs e)
        {
            try
            {
                byte btMemBank = 0x00;
                byte btWordAdd = 0x00;
                byte btWordCnt = 0x00;

                if (rdbReserved.Checked)
                {
                    btMemBank = 0x00;
                }
                else if (rdbEpc.Checked)
                {
                    btMemBank = 0x01;
                }
                else if (rdbTid.Checked)
                {
                    btMemBank = 0x02;
                }
                else if (rdbUser.Checked)
                {
                    btMemBank = 0x03;
                }
                else
                {
                    MessageBox.Show("Please select the area of tag");
                    return;
                }

                if (txtWordAdd.Text.Length != 0)
                {
                    btWordAdd = Convert.ToByte(txtWordAdd.Text);
                }
                else
                {
                    MessageBox.Show("Pleader select the start Add of tag");
                    return;
                }

                string[] reslut = CCommondMethod.StringToStringArray(htxtReadAndWritePwd.Text.ToUpper(), 2);

                if (reslut == null)
                {
                    MessageBox.Show("Invalid input characters");
                    return;
                }
                else if (reslut.GetLength(0) < 4)
                {
                    MessageBox.Show("Enter at least 4 bytes");
                    return;
                }
                byte[] btAryPwd = CCommondMethod.StringArrayToByteArray(reslut, 4);

                reslut = CCommondMethod.StringToStringArray(htxtWriteData.Text.ToUpper(), 2);

                if (reslut == null)
                {
                    MessageBox.Show("Invalid input characters");
                    return;
                }
                byte[] btAryWriteData = CCommondMethod.StringArrayToByteArray(reslut, reslut.Length);
                btWordCnt = Convert.ToByte(reslut.Length / 2 + reslut.Length % 2);

                txtWordCnt.Text = btWordCnt.ToString();

                m_curOperateTagBuffer.dtTagTable.Clear();
                ltvOperate.Items.Clear();
                reader.WriteTag(m_curSetting.btReadId, btAryPwd, btMemBank, btWordAdd, btWordCnt, btAryWriteData);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProcessWriteTag(Reader.MessageTran msgTran)
        {
            string strCmd = "Write Tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                int nLen = msgTran.AryData.Length;
                int nEpcLen = Convert.ToInt32(msgTran.AryData[2]) - 4;

                if (msgTran.AryData[nLen - 3] != 0x10)
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[nLen - 3]);
                    string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                    WriteLog(lrtxtLog, strLog, 1);
                    return;
                }

                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, 2);
                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5, nEpcLen);
                string strCRC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5 + nEpcLen, 2);
                string strData = string.Empty;

                byte byTemp = msgTran.AryData[nLen - 2];
                byte byAntId = (byte)((byTemp & 0x03) + 1);
                string strAntId = byAntId.ToString();

                string strReadCount = msgTran.AryData[nLen - 1].ToString();

                DataRow row = m_curOperateTagBuffer.dtTagTable.NewRow();
                row[0] = strPC;
                row[1] = strCRC;
                row[2] = strEPC;
                row[3] = strData;
                row[4] = string.Empty;
                row[5] = strAntId;
                row[6] = strReadCount;

                m_curOperateTagBuffer.dtTagTable.Rows.Add(row);
                m_curOperateTagBuffer.dtTagTable.AcceptChanges();

                RefreshOpTag(0x82);
                WriteLog(lrtxtLog, strCmd, 0);
            }
        }

        private void btnLockTag_Click(object sender, EventArgs e)
        {
            byte btMemBank = 0x00;
            byte btLockType = 0x00;

            if (rdbAccessPwd.Checked)
            {
                btMemBank = 0x04;
            }
            else if (rdbKillPwd.Checked)
            {
                btMemBank = 0x05;
            }
            else if (rdbEpcMermory.Checked)
            {
                btMemBank = 0x03;
            }
            else if (rdbTidMemory.Checked)
            {
                btMemBank = 0x02;
            }
            else if (rdbUserMemory.Checked)
            {
                btMemBank = 0x01;
            }
            else
            {
                MessageBox.Show("Please select the protected area");
                return;
            }

            if (rdbFree.Checked)
            {
                btLockType = 0x00;
            }
            else if (rdbFreeEver.Checked)
            {
                btLockType = 0x02;
            }
            else if (rdbLock.Checked)
            {
                btLockType = 0x01;
            }
            else if (rdbLockEver.Checked)
            {
                btLockType = 0x03;
            }
            else
            {
                MessageBox.Show("Please select the type of protection");
                return;
            }

            string[] reslut = CCommondMethod.StringToStringArray(htxtLockPwd.Text.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("Invalid input characters");
                return;
            }
            else if (reslut.GetLength(0) < 4)
            {
                MessageBox.Show("Enter at least 4 bytes");
                return;
            }

            byte[] btAryPwd = CCommondMethod.StringArrayToByteArray(reslut, 4);

            m_curOperateTagBuffer.dtTagTable.Clear();
            ltvOperate.Items.Clear();
            reader.LockTag(m_curSetting.btReadId, btAryPwd, btMemBank, btLockType);
        }

        private void ProcessLockTag(Reader.MessageTran msgTran)
        {
            string strCmd = "Lock Tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                int nLen = msgTran.AryData.Length;
                int nEpcLen = Convert.ToInt32(msgTran.AryData[2]) - 4;

                if (msgTran.AryData[nLen - 3] != 0x10)
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[nLen - 3]);
                    string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                    WriteLog(lrtxtLog, strLog, 1);
                    return;
                }

                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, 2);
                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5, nEpcLen);
                string strCRC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5 + nEpcLen, 2);
                string strData = string.Empty;

                byte byTemp = msgTran.AryData[nLen - 2];
                byte byAntId = (byte)((byTemp & 0x03) + 1);
                string strAntId = byAntId.ToString();

                string strReadCount = msgTran.AryData[nLen - 1].ToString();

                DataRow row = m_curOperateTagBuffer.dtTagTable.NewRow();
                row[0] = strPC;
                row[1] = strCRC;
                row[2] = strEPC;
                row[3] = strData;
                row[4] = string.Empty;
                row[5] = strAntId;
                row[6] = strReadCount;

                m_curOperateTagBuffer.dtTagTable.Rows.Add(row);
                m_curOperateTagBuffer.dtTagTable.AcceptChanges();

                RefreshOpTag(0x83);
                WriteLog(lrtxtLog, strCmd, 0);
            }
        }

        private void btnKillTag_Click(object sender, EventArgs e)
        {
            string[] reslut = CCommondMethod.StringToStringArray(htxtKillPwd.Text.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("Invalid input characters");
                return;
            }
            else if (reslut.GetLength(0) < 4)
            {
                MessageBox.Show("Enter at least 4 bytes");
                return;
            }

            byte[] btAryPwd = CCommondMethod.StringArrayToByteArray(reslut, 4);

            m_curOperateTagBuffer.dtTagTable.Clear();
            ltvOperate.Items.Clear();
            reader.KillTag(m_curSetting.btReadId, btAryPwd);
        }

        private void ProcessKillTag(Reader.MessageTran msgTran)
        {
            string strCmd = "Kill Tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                int nLen = msgTran.AryData.Length;
                int nEpcLen = Convert.ToInt32(msgTran.AryData[2]) - 4;

                if (msgTran.AryData[nLen - 3] != 0x10)
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[nLen - 3]);
                    string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                    WriteLog(lrtxtLog, strLog, 1);
                    return;
                }

                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, 2);
                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5, nEpcLen);
                string strCRC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5 + nEpcLen, 2);
                string strData = string.Empty;

                byte byTemp = msgTran.AryData[nLen - 2];
                byte byAntId = (byte)((byTemp & 0x03) + 1);
                string strAntId = byAntId.ToString();

                string strReadCount = msgTran.AryData[nLen - 1].ToString();

                DataRow row = m_curOperateTagBuffer.dtTagTable.NewRow();
                row[0] = strPC;
                row[1] = strCRC;
                row[2] = strEPC;
                row[3] = strData;
                row[4] = string.Empty;
                row[5] = strAntId;
                row[6] = strReadCount;

                m_curOperateTagBuffer.dtTagTable.Rows.Add(row);
                m_curOperateTagBuffer.dtTagTable.AcceptChanges();

                RefreshOpTag(0x84);
                WriteLog(lrtxtLog, strCmd, 0);
            }
        }

        private void btnInventoryISO18000_Click(object sender, EventArgs e)
        {
            if (m_bContinue)
            {
                m_bContinue = false;
                btnInventoryISO18000.BackColor = Color.WhiteSmoke;
                btnInventoryISO18000.ForeColor = Color.Indigo;
                btnInventoryISO18000.Text = "Inventory";
            }
            else
            {
                //Judge whether EPC inventory is runing.
                if (m_curInventoryBuffer.bLoopInventory)
                {
                    if (MessageBox.Show("EPC C1G2 tag is inventoring, whether to stop?", "Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        btnInventory_Click(sender, e);
                        return;
                    }
                }

                m_curOperateTagISO18000Buffer.ClearBuffer();
                ltvTagISO18000.Items.Clear();
                m_bContinue = true;
                btnInventoryISO18000.BackColor = Color.Indigo;
                btnInventoryISO18000.ForeColor = Color.White;
                btnInventoryISO18000.Text = "Stop";

                string strCmd = "Inventory";
                WriteLog(lrtxtLog, strCmd, 0);

                reader.InventoryISO18000(m_curSetting.btReadId);
            }
        }

        private void ProcessInventoryISO18000(Reader.MessageTran msgTran)
        {
            string strCmd = "Inventory";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] != 0xFF)
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                    string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                    WriteLog(lrtxtLog, strLog, 1);
                }
            }
            else if (msgTran.AryData.Length == 9)
            {
                string strAntID = CCommondMethod.ByteArrayToString(msgTran.AryData, 0, 1);
                string strUID = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, 8);

                //Add saved Tag List, no inventoried add recording, otherwise, the tag inventory number plus 1.
                DataRow[] drs = m_curOperateTagISO18000Buffer.dtTagTable.Select(string.Format("UID = '{0}'", strUID));
                if (drs.Length == 0)
                {
                    DataRow row = m_curOperateTagISO18000Buffer.dtTagTable.NewRow();
                    row[0] = strAntID;
                    row[1] = strUID;
                    row[2] = "1";
                    m_curOperateTagISO18000Buffer.dtTagTable.Rows.Add(row);
                    m_curOperateTagISO18000Buffer.dtTagTable.AcceptChanges();
                }
                else
                {
                    DataRow row = drs[0];
                    row.BeginEdit();
                    row[2] = (Convert.ToInt32(row[2]) + 1).ToString();
                    m_curOperateTagISO18000Buffer.dtTagTable.AcceptChanges();
                }

            }
            else if (msgTran.AryData.Length == 2)
            {
                m_curOperateTagISO18000Buffer.nTagCnt = Convert.ToInt32(msgTran.AryData[1]);
                RefreshISO18000(msgTran.Cmd);

                //WriteLog(lrtxtLog, strCmd, 0);
            }
            else
            {
                strErrorCode = "Unknown Error";
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
        }

        private void btnReadTagISO18000_Click(object sender, EventArgs e)
        {
            if (htxtReadUID.Text.Length == 0)
            {
                MessageBox.Show("Please enter UID");
                return;
            }
            if (htxtReadStartAdd.Text.Length == 0)
            {
                MessageBox.Show("Please enter Start Add");
                return;
            }
            if (txtReadLength.Text.Length == 0)
            {
                MessageBox.Show("Please enter Length");
                return;
            }

            string[] reslut = CCommondMethod.StringToStringArray(htxtReadUID.Text.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("Invalid input characters");
                return;
            }
            else if (reslut.GetLength(0) < 8)
            {
                MessageBox.Show("Enter at least 8 bytes");
                return;
            }
            byte[] btAryUID = CCommondMethod.StringArrayToByteArray(reslut, 8);

            reader.ReadTagISO18000(m_curSetting.btReadId, btAryUID, Convert.ToByte(htxtReadStartAdd.Text, 16), Convert.ToByte(txtReadLength.Text, 16));
        }

        private void ProcessReadTagISO18000(Reader.MessageTran msgTran)
        {
            string strCmd = "Read Tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strAntID = CCommondMethod.ByteArrayToString(msgTran.AryData, 0, 1);
                string strData = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, msgTran.AryData.Length - 1);

                m_curOperateTagISO18000Buffer.btAntId = Convert.ToByte(strAntID);
                m_curOperateTagISO18000Buffer.strReadData = strData;

                RefreshISO18000(msgTran.Cmd);

                WriteLog(lrtxtLog, strCmd, 0);
            }
        }

        private void btnWriteTagISO18000_Click(object sender, EventArgs e)
        {
            try
            {
                m_nLoopedTimes = 0;
                if (txtLoop.Text.Length == 0)
                    m_nLoopTimes = 0;
                else
                    m_nLoopTimes = Convert.ToInt32(txtLoop.Text);

                WriteTagISO18000();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteTagISO18000()
        {
            if (htxtReadUID.Text.Length == 0)
            {
                MessageBox.Show("Please enter UID");
                return;
            }
            if (htxtWriteStartAdd.Text.Length == 0)
            {
                MessageBox.Show("Please enter Start Add");
                return;
            }
            if (htxtWriteData18000.Text.Length == 0)
            {
                MessageBox.Show("Please enter Data to be written");
                return;
            }

            string[] reslut = CCommondMethod.StringToStringArray(htxtReadUID.Text.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("Invalid input characters");
                return;
            }
            else if (reslut.GetLength(0) < 8)
            {
                MessageBox.Show("Enter at least 8 bytes");
                return;
            }
            byte[] btAryUID = CCommondMethod.StringArrayToByteArray(reslut, 8);

            byte btStartAdd = Convert.ToByte(htxtWriteStartAdd.Text, 16);

            //string[] reslut = CCommondMethod.StringToStringArray(htxtWriteData18000.Text.ToUpper(), 2);
            string strTemp = cleanString(htxtWriteData18000.Text);
            reslut = CCommondMethod.StringToStringArray(strTemp.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("Invalid input characters");
                return;
            }

            byte[] btAryData = CCommondMethod.StringArrayToByteArray(reslut, reslut.Length);

            //byte btLength = Convert.ToByte(txtWriteLength.Text, 16);
            byte btLength = Convert.ToByte(reslut.Length);
            txtWriteLength.Text = String.Format("{0:X}", btLength);
            m_nBytes = reslut.Length;

            reader.WriteTagISO18000(m_curSetting.btReadId, btAryUID, btStartAdd, btLength, btAryData);
        }

        private string cleanString(string newStr)
        {
            string tempStr = newStr.Replace('\r', ' ');
            return tempStr.Replace('\n', ' ');
        }

        #region ISO18000
        private void ProcessWriteTagISO18000(Reader.MessageTran msgTran)
        {
            string strCmd = "Write Tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                //string strAntID = CCommondMethod.ByteArrayToString(msgTran.AryData, 0, 1);
                //string strCnt = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, 1);

                m_curOperateTagISO18000Buffer.btAntId = msgTran.AryData[0];
                m_curOperateTagISO18000Buffer.btWriteLength = msgTran.AryData[1];

                //RefreshISO18000(msgTran.Cmd);
                string strLength = msgTran.AryData[1].ToString();
                string strLog = strCmd + ": " + "Successfully written" + strLength + "byte";
                WriteLog(lrtxtLog, strLog, 0);
                RunLoopISO18000(Convert.ToInt32(msgTran.AryData[1]));
            }
        }

        private void btnLockTagISO18000_Click(object sender, EventArgs e)
        {
            if (htxtReadUID.Text.Length == 0)
            {
                MessageBox.Show("Please enter UID");
                return;
            }
            if (htxtLockAdd.Text.Length == 0)
            {
                MessageBox.Show("Please enter write-protected Add");
                return;
            }

            //Confirm the write protection prompt
            if (MessageBox.Show("Are you sure to write protect this address permanently?", "Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                return;
            }

            string[] reslut = CCommondMethod.StringToStringArray(htxtReadUID.Text.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("Invalid input characters");
                return;
            }
            else if (reslut.GetLength(0) < 8)
            {
                MessageBox.Show("Enter at least 8 bytes");
                return;
            }
            byte[] btAryUID = CCommondMethod.StringArrayToByteArray(reslut, 8);

            byte btStartAdd = Convert.ToByte(htxtLockAdd.Text, 16);

            reader.LockTagISO18000(m_curSetting.btReadId, btAryUID, btStartAdd);
        }

        private void ProcessLockTagISO18000(Reader.MessageTran msgTran)
        {
            string strCmd = "Permanent write protection";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                //string strAntID = CCommondMethod.ByteArrayToString(msgTran.AryData, 0, 1);
                //string strStatus = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, 1);

                m_curOperateTagISO18000Buffer.btAntId = msgTran.AryData[0];
                m_curOperateTagISO18000Buffer.btStatus = msgTran.AryData[1];

                //RefreshISO18000(msgTran.Cmd);
                string strLog = string.Empty;
                switch (msgTran.AryData[1])
                {
                    case 0x00:
                        strLog = strCmd + ": " + "Successfully locked";
                        break;
                    case 0xFE:
                        strLog = strCmd + ": " + "It is already locked state";
                        break;
                    case 0xFF:
                        strLog = strCmd + ": " + "Unable to lock";
                        break;
                    default:
                        break;
                }

                WriteLog(lrtxtLog, strLog, 0);

            }
        }

        private void btnQueryTagISO18000_Click(object sender, EventArgs e)
        {
            if (htxtReadUID.Text.Length == 0)
            {
                MessageBox.Show("Please enter UID");
                return;
            }
            if (htxtQueryAdd.Text.Length == 0)
            {
                MessageBox.Show("Please enter the query address");
                return;
            }

            string[] reslut = CCommondMethod.StringToStringArray(htxtReadUID.Text.ToUpper(), 2);

            if (reslut == null)
            {
                MessageBox.Show("Invalid input characters");
                return;
            }
            else if (reslut.GetLength(0) < 8)
            {
                MessageBox.Show("Enter at least 8 bytes");
                return;
            }
            byte[] btAryUID = CCommondMethod.StringArrayToByteArray(reslut, 8);

            byte btStartAdd = Convert.ToByte(htxtQueryAdd.Text, 16);

            reader.QueryTagISO18000(m_curSetting.btReadId, btAryUID, btStartAdd);
        }

        private void ProcessQueryISO18000(Reader.MessageTran msgTran)
        {
            string strCmd = "Query Tag";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure cause: " + strErrorCode;

                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                //string strAntID = CCommondMethod.ByteArrayToString(msgTran.AryData, 0, 1);
                //string strStatus = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, 1);

                m_curOperateTagISO18000Buffer.btAntId = msgTran.AryData[0];
                m_curOperateTagISO18000Buffer.btStatus = msgTran.AryData[1];

                RefreshISO18000(msgTran.Cmd);

                WriteLog(lrtxtLog, strCmd, 0);
            }
        }

        #endregion

        private void htxtSendData_Leave(object sender, EventArgs e)
        {
            if (htxtSendData.TextLength == 0)
            {
                return;
            }

            string[] reslut = CCommondMethod.StringToStringArray(htxtSendData.Text.ToUpper(), 2);
            byte[] btArySendData = CCommondMethod.StringArrayToByteArray(reslut, reslut.Length);

            byte btCheckData = reader.CheckValue(btArySendData);
            htxtCheckData.Text = string.Format(" {0:X2}", btCheckData);
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (htxtSendData.TextLength == 0)
            {
                return;
            }

            string strData = htxtSendData.Text + htxtCheckData.Text;

            string[] reslut = CCommondMethod.StringToStringArray(strData.ToUpper(), 2);
            byte[] btArySendData = CCommondMethod.StringArrayToByteArray(reslut, reslut.Length);

            reader.SendMessage(btArySendData);
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            htxtSendData.Text = "";
            htxtCheckData.Text = "";
        }

        private void lrtxtDataTran_DoubleClick(object sender, EventArgs e)
        {
            lrtxtDataTran.Text = "";
        }

        private void lrtxtLog_DoubleClick(object sender, EventArgs e)
        {
            lrtxtLog.Text = "";
        }

        private void tabCtrMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_bLockTab)
            {
                tabCtrMain.SelectTab(1);
            }
            int nIndex = tabCtrMain.SelectedIndex;

            if (nIndex == 2)
            {
                lrtxtDataTran.Select(lrtxtDataTran.TextLength, 0);
                lrtxtDataTran.ScrollToCaret();
            }
        }

        #region Serial
        private void txtTcpPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)ConsoleKey.Backspace)
            {
                e.Handled = false;
            }
        }

        private void txtOutputPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)ConsoleKey.Backspace)
            {
                e.Handled = false;
            }
        }

        private void txtChannel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)ConsoleKey.Backspace)
            {
                e.Handled = false;
            }
        }

        private void txtWordAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)ConsoleKey.Backspace)
            {
                e.Handled = false;
            }
        }

        private void txtWordCnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)ConsoleKey.Backspace)
            {
                e.Handled = false;
            }
        }
        #endregion  

        private void cmbSetAccessEpcMatch_DropDown(object sender, EventArgs e)
        {
            cmbSetAccessEpcMatch.Items.Clear();
            DataRow[] drs = m_curInventoryBuffer.dtTagTable.Select();
            foreach (DataRow row in drs)
            {
                cmbSetAccessEpcMatch.Items.Add(row[2].ToString());
            }
        }


        private void btnClearInventoryRealResult_Click(object sender, EventArgs e)
        {
            m_curInventoryBuffer.ClearInventoryRealResult();



            lvRealList.Items.Clear();
            //ltvInventoryTag.Items.Clear();
        }

        private void ltvInventoryEpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ltvInventoryTag.Items.Clear();
            DataRow[] drs;

            if (lvRealList.SelectedItems.Count == 0)
            {
                drs = m_curInventoryBuffer.dtTagDetailTable.Select();
                //ShowListView(ltvInventoryTag, drs);
            }
            else
            {
                foreach (ListViewItem itemEpc in lvRealList.SelectedItems)
                {
                    //ListViewItem itemEpc = ltvInventoryEpc.Items[nIndex];
                    string strEpc = itemEpc.SubItems[1].Text;

                    drs = m_curInventoryBuffer.dtTagDetailTable.Select(string.Format("COLEPC = '{0}'", strEpc));
                    //ShowListView(ltvInventoryTag, drs);
                }
            }
        }

        private void ShowListView(ListView ltvListView, DataRow[] drSelect)
        {
            //ltvListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            int nItemCount = ltvListView.Items.Count;
            int nIndex = 1;

            foreach (DataRow row in drSelect)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (nItemCount + nIndex).ToString();
                item.SubItems.Add(row[0].ToString());

                string strTemp = (Convert.ToInt32(row[1].ToString()) - 129).ToString() + "dBm";
                item.SubItems.Add(strTemp);
                byte byTemp = Convert.ToByte(row[1]);
                if (byTemp > 0x50)
                {
                    item.BackColor = Color.PowderBlue;
                }
                else if (byTemp < 0x30)
                {
                    item.BackColor = Color.LemonChiffon;
                }

                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());

                ltvListView.Items.Add(item);
                ltvListView.Items[nIndex - 1].EnsureVisible();
                nIndex++;
            }
        }

        private void ltvTagISO18000_DoubleClick(object sender, EventArgs e)
        {
            //if (ltvTagISO18000.SelectedItems.Count == 1)
            //{
            //    ListViewItem item = ltvTagISO18000.SelectedItems[0];
            //    string strUID = item.SubItems[1].Text;
            //    htxtReadUID.Text = strUID;
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            htxtReadUID.Text = "";
            htxtReadStartAdd.Text = "";
            txtReadLength.Text = "";
            htxtReadData18000.Text = "";
            htxtWriteStartAdd.Text = "";
            txtWriteLength.Text = "";
            htxtWriteData18000.Text = "";
            htxtLockAdd.Text = "";
            htxtQueryAdd.Text = "";
            txtStatus.Text = "";
            txtLoop.Text = "1";
            ltvTagISO18000.Items.Clear();
        }

        private void ltvTagISO18000_Click(object sender, EventArgs e)
        {
            if (ltvTagISO18000.SelectedItems.Count == 1)
            {
                ListViewItem item = ltvTagISO18000.SelectedItems[0];
                string strUID = item.SubItems[1].Text;
                htxtReadUID.Text = strUID;
            }
        }

        private void ckDisplayLog_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDisplayLog.Checked)
            {
                m_bDisplayLog = true;
            }
            else
            {
                m_bDisplayLog = false;
            }
        }


        private void btRealTimeInventory_Click(object sender, EventArgs e)
        {
            try
            {
                m_curInventoryBuffer.ClearInventoryPar();

                if (textRealRound.Text.Length == 0)
                {
                    MessageBox.Show("Please enter the number of cycles");
                    return;
                }
                m_curInventoryBuffer.btRepeat = Convert.ToByte(textRealRound.Text);

                if (cbRealSession.Checked == true)
                {
                    if (cmbSession.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please enter Session ID");
                        return;
                    }
                    if (cmbTarget.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please enter Inventoried Flag");
                        return;
                    }
                    m_curInventoryBuffer.bLoopCustomizedSession = true;
                    m_curInventoryBuffer.btSession = (byte)cmbSession.SelectedIndex;
                    m_curInventoryBuffer.btTarget = (byte)cmbTarget.SelectedIndex;
                }
                else
                {
                    m_curInventoryBuffer.bLoopCustomizedSession = false;
                }

                if (cbRealWorkant1.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x00);
                }
                if (cbRealWorkant2.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x01);
                }
                if (cbRealWorkant3.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x02);
                }
                if (cbRealWorkant4.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x03);
                }
                if (m_curInventoryBuffer.lAntenna.Count == 0)
                {
                    MessageBox.Show("One antenna must be selected");
                    return;
                }
                //Default cycle to send commands
                if (m_curInventoryBuffer.bLoopInventory)
                {
                    m_bInventory = false;
                    m_curInventoryBuffer.bLoopInventory = false;
                    btRealTimeInventory.BackColor = Color.WhiteSmoke;
                    btRealTimeInventory.ForeColor = Color.DarkBlue;
                    btRealTimeInventory.Text = "Inventory";
                    timerInventory.Enabled = false;
                    return;
                }
                else
                {
                    //Whether ISO 18000-6B Inventory is runing.
                    if (m_bContinue)
                    {
                        if (MessageBox.Show("ISO 18000-6B tag is inventoring, whether to stop?", "Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                        {
                            return;
                        }
                        else
                        {
                            btnInventoryISO18000_Click(sender, e);
                            return;
                        }
                    }

                    m_bInventory = true;
                    m_curInventoryBuffer.bLoopInventory = true;
                    btRealTimeInventory.BackColor = Color.DarkBlue;
                    btRealTimeInventory.ForeColor = Color.White;
                    btRealTimeInventory.Text = "Stop";
                }

                m_curInventoryBuffer.bLoopInventoryReal = true;

                m_curInventoryBuffer.ClearInventoryRealResult();
                lvRealList.Items.Clear();
                lvRealList.Items.Clear();
                tbRealMaxRssi.Text = "0";
                tbRealMinRssi.Text = "0";
                m_nTotal = 0;


                byte btWorkAntenna = m_curInventoryBuffer.lAntenna[m_curInventoryBuffer.nIndexAntenna];
                reader.SetWorkAntenna(m_curSetting.btReadId, btWorkAntenna);
                m_curSetting.btWorkAntenna = btWorkAntenna;

                timerInventory.Enabled = true;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRealFresh_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            m_curInventoryBuffer.ClearInventoryRealResult();

            lvRealList.Items.Clear();
            lvRealList.Items.Clear();
            ledReal1.Text = "0";
            ledReal2.Text = "0";
            ledReal3.Text = "0";
            ledReal4.Text = "0";
            ledReal5.Text = "0";
            tbRealMaxRssi.Text = "0";
            tbRealMinRssi.Text = "0";
            textRealRound.Text = "1";
            cbRealWorkant1.Checked = true;
            cbRealWorkant2.Checked = false;
            cbRealWorkant3.Checked = false;
            cbRealWorkant4.Checked = false;
            lbRealTagCount.Text = "Tag List:";


        }

        private void btBufferInventory_Click(object sender, EventArgs e)
        {
            try
            {
                m_curInventoryBuffer.ClearInventoryPar();

                if (textReadRoundBuffer.Text.Length == 0)
                {
                    MessageBox.Show("Please enter the number of cycles");
                    return;
                }
                m_curInventoryBuffer.btRepeat = Convert.ToByte(textReadRoundBuffer.Text);

                if (cbBufferWorkant1.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x00);
                }
                if (cbBufferWorkant2.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x01);
                }
                if (cbBufferWorkant3.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x02);
                }
                if (cbBufferWorkant4.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x03);
                }
                if (m_curInventoryBuffer.lAntenna.Count == 0)
                {
                    MessageBox.Show("One antenna must be selected");
                    return;
                }


                //Default cycle to send commands
                if (m_curInventoryBuffer.bLoopInventory)
                {
                    m_bInventory = false;
                    m_curInventoryBuffer.bLoopInventory = false;
                    btBufferInventory.BackColor = Color.WhiteSmoke;
                    btBufferInventory.ForeColor = Color.DarkBlue;
                    btBufferInventory.Text = "Inventory";
                    return;
                }
                else
                {
                    //Whether ISO 18000-6B Inventory is runing.
                    if (m_bContinue)
                    {
                        if (MessageBox.Show("ISO 18000-6B tag is inventoring, whether to stop?", "Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                        {
                            return;
                        }
                        else
                        {
                            btnInventoryISO18000_Click(sender, e);
                            return;
                        }
                    }

                    m_bInventory = true;
                    m_curInventoryBuffer.bLoopInventory = true;
                    btBufferInventory.BackColor = Color.DarkBlue;
                    btBufferInventory.ForeColor = Color.White;
                    btBufferInventory.Text = "Stop";
                }


                m_curInventoryBuffer.ClearInventoryRealResult();
                lvBufferList.Items.Clear();
                lvBufferList.Items.Clear();
                m_nTotal = 0;

                byte btWorkAntenna = m_curInventoryBuffer.lAntenna[m_curInventoryBuffer.nIndexAntenna];
                reader.SetWorkAntenna(m_curSetting.btReadId, btWorkAntenna);
                m_curSetting.btWorkAntenna = btWorkAntenna;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGetBuffer_Click(object sender, EventArgs e)
        {
            m_curInventoryBuffer.dtTagTable.Rows.Clear();
            lvBufferList.Items.Clear();
            reader.GetInventoryBuffer(m_curSetting.btReadId);
        }

        private void btGetClearBuffer_Click(object sender, EventArgs e)
        {
            m_curInventoryBuffer.dtTagTable.Rows.Clear();
            lvBufferList.Items.Clear();
            reader.GetAndResetInventoryBuffer(m_curSetting.btReadId);
        }

        private void btClearBuffer_Click(object sender, EventArgs e)
        {
            reader.ResetInventoryBuffer(m_curSetting.btReadId);
            btBufferFresh_Click(sender, e);

        }

        private void btQueryBuffer_Click(object sender, EventArgs e)
        {
            reader.GetInventoryBufferTagCount(m_curSetting.btReadId);
        }

        private void btBufferFresh_Click(object sender, EventArgs e)
        {
            m_curInventoryBuffer.ClearInventoryRealResult();
            lvBufferList.Items.Clear();
            lvBufferList.Items.Clear();
            ledBuffer1.Text = "0";
            ledBuffer2.Text = "0";
            ledBuffer3.Text = "0";
            ledBuffer4.Text = "0";
            ledBuffer5.Text = "0";

            textReadRoundBuffer.Text = "1";
            cbBufferWorkant1.Checked = true;
            cbBufferWorkant2.Checked = false;
            cbBufferWorkant3.Checked = false;
            cbBufferWorkant4.Checked = false;
            labelBufferTagCount.Text = "Tag List:";
        }

        private void btFastInventory_Click(object sender, EventArgs e)
        {
            short antASelection = 1;
            short antBSelection = 1;
            short antCSelection = 1;
            short antDSelection = 1;
            //Default cycle to send commands
            if (m_curInventoryBuffer.bLoopInventory)
            {
                m_bInventory = false;
                m_curInventoryBuffer.bLoopInventory = false;
                btFastInventory.BackColor = Color.WhiteSmoke;
                btFastInventory.ForeColor = Color.DarkBlue;
                btFastInventory.Text = "Inventory";
                return;
            }
            else
            {
                //Whether ISO 18000-6B Inventory is runing.
                if (m_bContinue)
                {
                    if (MessageBox.Show("ISO 18000-6B tag is inventoring, whether to stop?", "Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        btnInventoryISO18000_Click(sender, e);
                        return;
                    }
                }

                m_bInventory = true;
                m_curInventoryBuffer.bLoopInventory = true;
                btFastInventory.BackColor = Color.DarkBlue;
                btFastInventory.ForeColor = Color.White;
                btFastInventory.Text = "Stop";
            }
            try
            {
                m_curInventoryBuffer.bLoopInventoryReal = true;

                m_curInventoryBuffer.ClearInventoryRealResult();
                lvFastList.Items.Clear();

                m_nTotal = 0;
                if ((cmbAntSelect1.SelectedIndex < 0) || (cmbAntSelect1.SelectedIndex > 3))
                {
                    m_btAryData[0] = 0xFF;
                }
                else
                {
                    m_btAryData[0] = Convert.ToByte(cmbAntSelect1.SelectedIndex);
                }
                if (txtAStay.Text.Length == 0)
                {
                    m_btAryData[1] = 0x00;
                }
                else
                {
                    m_btAryData[1] = Convert.ToByte(txtAStay.Text);
                }

                if ((cmbAntSelect2.SelectedIndex < 0) || (cmbAntSelect2.SelectedIndex > 3))
                {
                    m_btAryData[2] = 0xFF;
                }
                else
                {
                    m_btAryData[2] = Convert.ToByte(cmbAntSelect2.SelectedIndex);
                }
                if (txtBStay.Text.Length == 0)
                {
                    m_btAryData[3] = 0x00;
                }
                else
                {
                    m_btAryData[3] = Convert.ToByte(txtBStay.Text);
                }

                if ((cmbAntSelect3.SelectedIndex < 0) || (cmbAntSelect3.SelectedIndex > 3))
                {
                    m_btAryData[4] = 0xFF;
                }
                else
                {
                    m_btAryData[4] = Convert.ToByte(cmbAntSelect3.SelectedIndex);
                }
                if (txtCStay.Text.Length == 0)
                {
                    m_btAryData[5] = 0x00;
                }
                else
                {
                    m_btAryData[5] = Convert.ToByte(txtCStay.Text);
                }

                if ((cmbAntSelect4.SelectedIndex < 0) || (cmbAntSelect4.SelectedIndex > 3))
                {
                    m_btAryData[6] = 0xFF;
                }
                else
                {
                    m_btAryData[6] = Convert.ToByte(cmbAntSelect4.SelectedIndex);
                }
                if (txtDStay.Text.Length == 0)
                {
                    m_btAryData[7] = 0x00;
                }
                else
                {
                    m_btAryData[7] = Convert.ToByte(txtDStay.Text);
                }

                if (txtInterval.Text.Length == 0)
                {
                    m_btAryData[8] = 0x00;
                }
                else
                {
                    m_btAryData[8] = Convert.ToByte(txtInterval.Text);
                }

                if (txtRepeat.Text.Length == 0)
                {
                    m_btAryData[9] = 0x00;
                }
                else
                {
                    m_btAryData[9] = Convert.ToByte(txtRepeat.Text);
                }

                if (m_btAryData[0] > 3)
                {
                    antASelection = 0;
                }

                if (m_btAryData[2] > 3)
                {
                    antBSelection = 0;
                }

                if (m_btAryData[4] > 3)
                {
                    antCSelection = 0;
                }

                if (m_btAryData[6] > 3)
                {
                    antDSelection = 0;
                }

                if ((antASelection * m_btAryData[1] + antBSelection * m_btAryData[3] + antCSelection * m_btAryData[5] + antDSelection * m_btAryData[7]) * m_btAryData[9] == 0)
                {
                    MessageBox.Show("One antenna must be selected, polling at least once,repeat per command at least once.");
                    m_bInventory = false;
                    m_curInventoryBuffer.bLoopInventory = false;
                    btFastInventory.BackColor = Color.WhiteSmoke;
                    btFastInventory.ForeColor = Color.DarkBlue;
                    btFastInventory.Text = "Inventory";
                    return;
                }

                m_nSwitchTotal = 0;
                m_nSwitchTime = 0;
                reader.FastSwitchInventory(m_curSetting.btReadId, m_btAryData);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFastFresh_Click(object sender, EventArgs e)
        {
            m_curInventoryBuffer.ClearInventoryRealResult();
            lvFastList.Items.Clear();
            ledFast1.Text = "0";
            ledFast2.Text = "0";
            ledFast3.Text = "0";
            ledFast4.Text = "0";
            ledFast5.Text = "0";
            txtFastMinRssi.Text = "";
            txtFastMaxRssi.Text = "";
            txtFastTagList.Text = "Tag List:";

            cmbAntSelect1.SelectedIndex = 0;
            cmbAntSelect2.SelectedIndex = 1;
            cmbAntSelect3.SelectedIndex = 2;
            cmbAntSelect4.SelectedIndex = 3;

            txtAStay.Text = "1";
            txtBStay.Text = "1";
            txtCStay.Text = "1";
            txtDStay.Text = "1";

            txtInterval.Text = "0";
            txtRepeat.Text = "10";

        }

        private void pageFast4AntMode_Enter(object sender, EventArgs e)
        {
            // buttonFastFresh_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtFirmwareVersion.Text = "";
            //htxtReadId.Text = "";
            htbSetIdentifier.Text = "";
            txtReaderTemperature.Text = "";
            txtOutputPower.Text = "";
            htbGetIdentifier.Text = "";
        }

        private void btGetMonzaStatus_Click(object sender, EventArgs e)
        {
            reader.GetMonzaStatus(m_curSetting.btReadId);
        }

        private void btSetMonzaStatus_Click(object sender, EventArgs e)
        {
            byte btMonzaStatus = 0xFF;

            if (rdbMonzaOn.Checked)
            {
                btMonzaStatus = 0x8D;
            }
            else if (rdbMonzaOff.Checked)
            {
                btMonzaStatus = 0x00;
            }
            else
            {
                return;
            }

            reader.SetMonzaStatus(m_curSetting.btReadId, btMonzaStatus);
            m_curSetting.btMonzaStatus = btMonzaStatus;
        }

        private void btGetIdentifier_Click(object sender, EventArgs e)
        {
            reader.GetReaderIdentifier(m_curSetting.btReadId);
        }

        private void btSetIdentifier_Click(object sender, EventArgs e)
        {
            try
            {
                string strTemp = htbSetIdentifier.Text.Trim();


                string[] result = CCommondMethod.StringToStringArray(strTemp.ToUpper(), 2);

                if (result == null)
                {
                    MessageBox.Show("Invalid input characters");
                    return;
                }
                else if (result.GetLength(0) != 12)
                {
                    MessageBox.Show("Please enter 12 bytes");
                    return;
                }
                byte[] readerIdentifier = CCommondMethod.StringArrayToByteArray(result, 12);


                reader.SetReaderIdentifier(m_curSetting.btReadId, readerIdentifier);
                //m_curSetting.btReadId = Convert.ToByte(strTemp, 16);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReaderSetupRefresh_Click(object sender, EventArgs e)
        {
            // htxtReadId.Text = "";
            htbGetIdentifier.Text = "";
            htbSetIdentifier.Text = "";
            txtFirmwareVersion.Text = "";
            txtReaderTemperature.Text = "";
            rdbGpio1High.Checked = false;
            rdbGpio1Low.Checked = false;
            rdbGpio2High.Checked = false;
            rdbGpio2Low.Checked = false;
            rdbGpio3High.Checked = false;
            rdbGpio3Low.Checked = false;
            rdbGpio4High.Checked = false;
            rdbGpio4Low.Checked = false;

            rdbBeeperModeSlient.Checked = false;
            rdbBeeperModeInventory.Checked = false;
            rdbBeeperModeTag.Checked = false;

            //  cmbSetBaudrate.SelectedIndex = -1;
        }

        private void btRfSetup_Click(object sender, EventArgs e)
        {
            txtOutputPower.Text = "";
            cmbFrequencyStart.SelectedIndex = -1;
            cmbFrequencyEnd.SelectedIndex = -1;
            tbAntDectector.Text = "";

            rdbDrmModeOpen.Checked = false;
            rdbDrmModeClose.Checked = false;

            rdbMonzaOn.Checked = false;
            rdbMonzaOff.Checked = false;
            rdbRegionFcc.Checked = false;
            rdbRegionEtsi.Checked = false;
            rdbRegionChn.Checked = false;

            textReturnLoss.Text = "";
            cmbWorkAnt.SelectedIndex = -1;
            textStartFreq.Text = "";
            TextFreqInterval.Text = "";
            textFreqQuantity.Text = "";

            rdbProfile0.Checked = false;
            rdbProfile1.Checked = false;
            rdbProfile2.Checked = false;
            rdbProfile3.Checked = false;
        }
        private void cbRealSession_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRealSession.Checked)
            {
                label97.Enabled = true;
                label98.Enabled = true;
                cmbSession.Enabled = true;
                cmbTarget.Enabled = true;
            }
            else
            {
                label97.Enabled = false;
                label98.Enabled = false;
                cmbSession.Enabled = false;
                cmbTarget.Enabled = false;
            }
        }

        private void btReturnLoss_Click(object sender, EventArgs e)
        {
            if (cmbReturnLossFreq.SelectedIndex != -1)
            {
                reader.MeasureReturnLoss(m_curSetting.btReadId, Convert.ToByte(cmbReturnLossFreq.SelectedIndex));
            }
        }

        private void cbUserDefineFreq_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUserDefineFreq.Checked)
            {
                groupBox21.Enabled = false;
                groupBox23.Enabled = true;

            }
            else
            {
                groupBox21.Enabled = true;
                groupBox23.Enabled = false;
            }
        }

        private void btSetProfile_Click(object sender, EventArgs e)
        {
            byte btSelectedProfile = 0xFF;

            if (rdbProfile0.Checked)
            {
                btSelectedProfile = 0xD0;
            }
            else if (rdbProfile1.Checked)
            {
                btSelectedProfile = 0xD1;
            }
            else if (rdbProfile2.Checked)
            {
                btSelectedProfile = 0xD2;
            }
            else if (rdbProfile3.Checked)
            {
                btSelectedProfile = 0xD3;
            }
            else
            {
                return;
            }

            reader.SetRadioProfile(m_curSetting.btReadId, btSelectedProfile);
        }

        private void btGetProfile_Click(object sender, EventArgs e)
        {
            reader.GetRadioProfile(m_curSetting.btReadId);
        }

        private void tabCtrMain_Click(object sender, EventArgs e)
        {
            if ((m_curSetting.btRegion < 1) || (m_curSetting.btRegion > 4)) //If it is user defined frequencies, defined frequencies information need to be extracted firstly.
            {
                reader.GetFrequencyRegion(m_curSetting.btReadId);
                Thread.Sleep(5);

            }
        }

        private void timerInventory_Tick(object sender, EventArgs e)
        {
            m_nReceiveFlag++;
            if (m_nReceiveFlag >= 5)
            {
                RunLoopInventroy();
                m_nReceiveFlag = 0;
            }
        }

        private void rdbGpio4Low_CheckedChanged(object sender, EventArgs e)
        {

        }


        #region Race !!!

        RaceEvent _selectedRaceEvent;

        private void btnRaceStart_Click(object sender, EventArgs e)
        {
            if (!RaceValidation())
            {
                MessageBox.Show("Some fields are not filled or filled unproperly.");
                return;
            }

            if (_raceTime.TotalMilliseconds > 1)
            {
                MessageBox.Show("You should reset the timer before starting new race.");
                return;
            }

            if (_selectedRaceEvent == null || _selectedRaceEvent.Finished)
            {
                MessageBox.Show("Event is not selected or has finished yet.");
                return;
            }
            FillRaceInfo(_race);
            _timer.Start();

            var file = ConfigurationManager.AppSettings["StartSoundFile"];
            var path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), file);
            if (File.Exists(path))
            {
                var player = new SoundPlayer();
                player.SoundLocation = file;
                player.Play();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }

            EnableDisableRaceControls(false);

            if (cmbRaceMode.SelectedIndex == 0)
                StartStopInventoryReal();

            if (cmbRaceMode.SelectedIndex == 1)
                StartStopInventoryFastSwitch();
        }

        private void StartStopInventoryFastSwitch()
        {
            short antASelection = 1;
            short antBSelection = 1;
            short antCSelection = 1;
            short antDSelection = 1;

            //Default cycle to send commands
            if (m_curInventoryBuffer.bLoopInventory)
            {
                m_bInventory = false;
                m_curInventoryBuffer.bLoopInventory = false;
                return;
            }

            m_bInventory = true;
            m_curInventoryBuffer.bLoopInventory = true;

            try
            {
                m_curInventoryBuffer.bLoopInventoryReal = true;

                m_curInventoryBuffer.ClearInventoryRealResult();
                lvFastList.Items.Clear();

                m_nTotal = 0;

                if (!cbRaceAnt1.Checked)
                {
                    m_btAryData[0] = 0xFF;
                }
                else
                {
                    m_btAryData[0] = 0;
                }

                m_btAryData[1] = 1;

                if (!cbRaceAnt2.Checked)
                {
                    m_btAryData[2] = 0xFF;
                }
                else
                {
                    m_btAryData[2] = 1;
                }
                m_btAryData[3] = 1;

                if (!cbRaceAnt3.Checked)
                {
                    m_btAryData[4] = 0xFF;
                }
                else
                {
                    m_btAryData[4] = 2;
                }
                m_btAryData[5] = 1;

                if (!cbRaceAnt4.Checked)
                {
                    m_btAryData[6] = 0xFF;
                }
                else
                {
                    m_btAryData[6] = 3;
                }
                m_btAryData[7] = 1;

                m_btAryData[8] = Convert.ToByte
                    (ConfigurationManager.AppSettings["InteralBetweenAnts"]); // Interval
                m_btAryData[9] = Convert.ToByte
                    (ConfigurationManager.AppSettings["NumberOfRepeats"]); // Number of repeats

                if (m_btAryData[0] > 3)
                {
                    antASelection = 0;
                }
                if (m_btAryData[2] > 3)
                {
                    antBSelection = 0;
                }
                if (m_btAryData[4] > 3)
                {
                    antCSelection = 0;
                }
                if (m_btAryData[6] > 3)
                {
                    antDSelection = 0;
                }

                if ((antASelection * m_btAryData[1] + antBSelection * m_btAryData[3] + antCSelection * m_btAryData[5] + antDSelection * m_btAryData[7]) * m_btAryData[9] == 0)
                {
                    MessageBox.Show("One antenna must be selected.");
                    m_bInventory = false;
                    m_curInventoryBuffer.bLoopInventory = false;
                    return;
                }

                m_nSwitchTotal = 0;
                m_nSwitchTime = 0;
                reader.FastSwitchInventory(m_curSetting.btReadId, m_btAryData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartStopInventoryReal()
        {
            try
            {
                //Default cycle to send commands
                if (m_curInventoryBuffer.bLoopInventory)
                {
                    m_bInventory = false;
                    m_curInventoryBuffer.bLoopInventory = false;
                    timerInventory.Enabled = false;
                    return;
                }

                m_curInventoryBuffer.ClearInventoryPar();
                m_curInventoryBuffer.btRepeat = 1;
                m_curInventoryBuffer.bLoopCustomizedSession = false;

                if (cbRaceAnt1.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x00);
                }
                if (cbRaceAnt2.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x01);
                }
                if (cbRaceAnt3.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x02);
                }
                if (cbRaceAnt4.Checked)
                {
                    m_curInventoryBuffer.lAntenna.Add(0x03);
                }
                if (m_curInventoryBuffer.lAntenna.Count == 0)
                {
                    MessageBox.Show("One antenna must be selected");
                    return;
                }

                m_bInventory = true;
                m_curInventoryBuffer.bLoopInventory = true;
                m_curInventoryBuffer.bLoopInventoryReal = true;

                m_curInventoryBuffer.ClearInventoryRealResult();
                lvRealList.Items.Clear();
                tbRaceMaxRssi.Text = "0";
                tbRaceMinRssi.Text = "0";
                m_nTotal = 0;

                byte btWorkAntenna = m_curInventoryBuffer.lAntenna[m_curInventoryBuffer.nIndexAntenna];
                reader.SetWorkAntenna(m_curSetting.btReadId, btWorkAntenna);
                m_curSetting.btWorkAntenna = btWorkAntenna;

                timerInventory.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterTag()
        {
            tbRaceMaxRssi.Text = $"{m_curInventoryBuffer.nMaxRSSI - 129} dBm";
            tbRaceMinRssi.Text = $"{m_curInventoryBuffer.nMinRSSI - 129} dBm";

            var row = m_curInventoryBuffer.drLastTag;
            if (row == null) return;

            var tag = row[0].ToString().Trim();
            tag = CleanTag(tag);
            var lap = _selectedRaceEvent.Laps.FirstOrDefault(l => l.Epc == tag);

            if (lap == null || lap.LapsCount >= nudNumOfLaps.Value) return;
            Debug.WriteLine("tag = " + tag + ", lap = " + lap.OrderNumber + ", time = " + _raceTime);

            var success = lap.RegisterLapTime(_raceTime, (double)nudMinFirstLapTime.Value, (double)nudMinLapTime.Value);
            bindingSourceRace.ResetBindings(false);

            if (!success) return;

            var file = ConfigurationManager.AppSettings["TagReadSoundFile"];
            var path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), file);
            if (File.Exists(path))
            {
                var player = new SoundPlayer();
                player.SoundLocation = file;
                player.Play();
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }

            UpdateRanking();
            bindingSourceRanking.ResetBindings(false);
        }

        private string CleanTag(string tag)
        {
            return new string(tag.Skip(tag.Length - 2).ToArray());

            //int i;
            //if (int.TryParse(tag.Replace(" ", ""), out i))
            //    return i.ToString();
            //return tag;
        }

        private void _timer_Elapsed(object sender, HighResolutionTimerElapsedEventArgs e)
        {
            _raceTime = _raceTime.Add(TimeSpan.FromMilliseconds(1));

            // Improving perfomance
            if (_raceTime.Milliseconds % 5 == 0 && !Disposing)
            {
                BeginInvoke(new Action(ShowRaceTime));
            }
        }

        private void ShowRaceTime()
        {
            lblRaceMilliSeconds.Text = _raceTime.Milliseconds.ToString("D3");
            lblRaceSeconds.Text = _raceTime.Seconds.ToString("D2");
            lblRaceMinutes.Text = _raceTime.Minutes.ToString("D2");
        }

        private void btnRaceStop_Click(object sender, EventArgs e)
        {
            _timer.Stop();

            ShowRaceTime();
            EnableDisableRaceControls(true);

            if (cmbRaceMode.SelectedIndex == 0)
                StartStopInventoryReal();

            if (cmbRaceMode.SelectedIndex == 1)
                StartStopInventoryFastSwitch();
        }

        private void btnRaceReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to reset time?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _raceTime = TimeSpan.Zero;
                ShowRaceTime();
            }
        }
        private void FillRaceInfo(Race race)
        {
            race.Name = tbRaceName.Text;
            race.Date = dtpRaceDate.Value;
            race.Location = tbRaceLocation.Text;
            //  race.MinLapTime = Convert.ToInt32(tbRaceMinLapTime.Text);

        }

        private bool RaceValidation()
        {
            return !string.IsNullOrEmpty(tbRaceName.Text) &&
                           !string.IsNullOrEmpty(tbRaceLocation.Text) && !string.IsNullOrEmpty(dtpRaceDate.Text) &&
                           !string.IsNullOrEmpty(tbCurEvGroup.Text) && !string.IsNullOrEmpty(tbCurEvRound.Text);
        }

        private void EnableDisableRaceControls(bool enable)
        {
            btnRaceStart.Enabled = enable;
            btnRaceStop.Enabled = !enable;

            groupBox9.Enabled = enable;
            groupBox12.Enabled = enable;
            groupBox26.Enabled = enable;
        }

        private void cmbRaceRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCurEvRound.Text = cmbRaceRound.SelectedItem?.ToString();
            ShowPilots();
        }

        private void ShowPilots()
        {
            _selectedRaceEvent = null;
            if (cmbRaceGroup.SelectedItem == null || cmbRaceRound.SelectedItem == null) return;

            var group = _race.Groups.FirstOrDefault(g => g.Name == cmbRaceGroup.SelectedItem.ToString());
            var round = cmbRaceRound.SelectedItem.ToString();
            if (group != null)
            {
                //find existing race event
                var raceEvent = _race.RaceEvents.FirstOrDefault(r => r.Group.Name == group.Name && r.Round == round);
                if (raceEvent == null)
                {
                    raceEvent = new RaceEvent();
                    raceEvent.RaceId = _race.Id;
                    raceEvent.Group = group;
                    raceEvent.Round = round;
                    _race.RaceEvents.Add(raceEvent);
                }

                if (raceEvent.Laps.Count == 0)
                {
                    foreach (var pilot in group.Pilots)
                    {
                        if (pilot == null) continue;
                        var lapsInfo = new LapsInfo
                        {
                            PilotId = pilot.Id,
                            Epc = pilot.Tag,
                            RaceEventId = raceEvent.Id,
                            PilotName = pilot.Name,
                            OrderNumber = pilot.OrderNumber
                        };
                        raceEvent.Laps.Add(lapsInfo);
                    }
                }
                bindingSourceRace.DataSource = raceEvent.Laps;
                bindingSourceRace.ResetBindings(false);
                _selectedRaceEvent = raceEvent;

                // hide laps columns if not needed
                var numOfLaps = nudNumOfLaps.Value;
                if (numOfLaps < 6)
                    Lap6.Visible = false;
                if (numOfLaps < 5)
                    Lap5.Visible = false;
                if (numOfLaps < 4)
                    Lap4.Visible = false;
            }
        }

        private void cmbRaceGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCurEvGroup.Text = cmbRaceGroup.SelectedItem?.ToString();
            ShowPilots();
        }
        #endregion

        #region Pilots Management

        List<Pilot> Pilots = new List<Pilot>();

        private void btnAddPilot_Click(object sender, EventArgs e) // Add Pilot
        {
            var pilot = new Pilot();
            pilot.Tag = tbPilotTag.Text;
            pilot.Name = tbPilotName.Text;
            pilot.Nickname = tbPilotNickname.Text;
            pilot.Team = tbPilotTeam.Text;
            pilot.Email = tbPilotEmail.Text;
            pilot.isChecked = Convert.ToInt32(cbPilotConfirmation.Checked);
            pilot.Confirmation = cbPilotConfirmation.Checked;
            Pilots.Add(pilot);
            pilot.OrderNumber = Pilots.IndexOf(pilot) + 1;

            database objDatabase = new database();
            string sqlQuery = "insert into Pilots (Name, NickName, Team, Email, Confirmation, TagID) values ('" + pilot.Name + "','" + pilot.Nickname + "','" + pilot.Team + "','" + pilot.Email + "','" + pilot.isChecked + "', '" + pilot.Tag + "' )";
            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
            cmd.ExecuteNonQuery();
            pilot.Id = Convert.ToInt32(getLastInsertedId(cmd));

            bindingSourcePilots1.DataSource = Pilots;
            bindingSourcePilots1.ResetBindings(false);
        }

        private void btnAddPilotFromDb_Click(object sender, EventArgs e) // Add From DB
        {
            bindingSourcePilots1.Clear();
            database objDatabase = new database();
            string sqlQuery = "select * from Pilots";
            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
            SQLiteDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var pilot = new Pilot();
                pilot.Id = Convert.ToInt32(dataReader["Id"]);
                pilot.Tag = Convert.ToString(dataReader["TagID"]);
                pilot.Name = Convert.ToString(dataReader["Name"]);
                pilot.Nickname = Convert.ToString(dataReader["Nickname"]);
                pilot.Team = Convert.ToString(dataReader["Team"]);
                pilot.Email = Convert.ToString(dataReader["Email"]);
                pilot.Confirmation = Convert.ToBoolean(dataReader["Confirmation"]);
                Pilots.Add(pilot);
                pilot.OrderNumber = Pilots.IndexOf(pilot) + 1;
            }
            bindingSourcePilots1.DataSource = Pilots;
            bindingSourcePilots1.ResetBindings(false);
        }

        private void btnClearDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear all DB?", "Pilots", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                database objDatabase = new database();
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("Delete from Pilots", objDatabase.get_SQLiteConnection());
                cmd.ExecuteNonQuery();

                cmd = new SQLiteCommand("Delete from LapsInfos", objDatabase.get_SQLiteConnection());
                cmd.ExecuteNonQuery();

                cmd = new SQLiteCommand("Delete from RaceEvents", objDatabase.get_SQLiteConnection());
                cmd.ExecuteNonQuery();

                cmd = new SQLiteCommand("Delete from Groups", objDatabase.get_SQLiteConnection());
                cmd.ExecuteNonQuery();

                cmd = new SQLiteCommand("Delete from Races", objDatabase.get_SQLiteConnection());
                cmd.ExecuteNonQuery();

                cmd = new SQLiteCommand("Delete from Pilot_Groups", objDatabase.get_SQLiteConnection());
                cmd.ExecuteNonQuery();

                bindingSourcePilots1.Clear();
                clearFormText();
                MessageBox.Show("DB has been cleared successfully", "Pilots", MessageBoxButtons.OK);
            }
        }

        public void clearFormText()
        {
            tbPilotTag.Text = string.Empty;
            tbPilotName.Text = string.Empty;
            tbPilotNickname.Text = string.Empty;
            tbPilotTeam.Text = string.Empty;
            tbPilotEmail.Text = string.Empty;
            cbPilotConfirmation.Checked = false;
        }

        private void gvPilots_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id, Conf;
                string Name, Nickname, Team, Email, TagID;
                Id = Convert.ToInt32(gvPilots.Rows[e.RowIndex].Cells[1].Value);
                Name = Convert.ToString(gvPilots.Rows[e.RowIndex].Cells[2].Value);
                Nickname = Convert.ToString(gvPilots.Rows[e.RowIndex].Cells[3].Value);
                Team = Convert.ToString(gvPilots.Rows[e.RowIndex].Cells[4].Value);
                TagID = Convert.ToString(gvPilots.Rows[e.RowIndex].Cells[5].Value);
                Email = Convert.ToString(gvPilots.Rows[e.RowIndex].Cells[6].Value);
                Conf = Convert.ToString(gvPilots.Rows[e.RowIndex].Cells[7].Value) == "Yes" ? 1 : 0;
                database objDatabase = new database();
                string sqlQuery = "Update Pilots set Name = @Name, Nickname = @Nickname, Team = @Team, TagID = @TagID, Email = @Email, Confirmation = @Confirmation where Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Nickname", Nickname);
                cmd.Parameters.AddWithValue("@Team", Team);
                cmd.Parameters.AddWithValue("@TagID", TagID);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Confirmation", Conf);
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Round Management

        private void btnAddPilotsToGroups_Click(object sender, EventArgs e)
        {
            _race.Groups = new List<Group>();

            // shuffle pilots
            //Pilots = Pilots.OrderBy(a => Guid.NewGuid()).ToList(); 
            // 20.09.2018 - do NOT shuffle pilots


            // get "pilots per group" value
            var ppg = (int)nudPilotsPerGroup.Value;
            var group = new Group
            {
                Name = "Group A",
                Pilots = Pilots.Take(ppg).ToList()
            };
            gvGroupA.DataSource = group.Pilots;
            _race.Groups.Add(group);

            if (Pilots.Count > ppg)
            {
                var gr = new Group
                {
                    Name = "Group B",
                    Pilots = Pilots.GetRange(ppg, 2 * ppg > Pilots.Count ? Pilots.Count - ppg : ppg)
                };
                gvGroupB.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 2)
            {
                var gr = new Group
                {
                    Name = "Group C",
                    Pilots = Pilots.GetRange(2 * ppg, 3 * ppg > Pilots.Count ? Pilots.Count - 2 * ppg : ppg)
                };
                gvGroupC.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 3)
            {
                var gr = new Group
                {
                    Name = "Group D",
                    Pilots = Pilots.GetRange(3 * ppg, 4 * ppg > Pilots.Count ? Pilots.Count - 3 * ppg : ppg)
                };
                gvGroupD.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 4)
            {
                var gr = new Group
                {
                    Name = "Group E",
                    Pilots = Pilots.GetRange(4 * ppg, 5 * ppg > Pilots.Count ? Pilots.Count - 4 * ppg : ppg)
                };
                gvGroupE.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 5)
            {
                var gr = new Group
                {
                    Name = "Group F",
                    Pilots = Pilots.GetRange(5 * ppg, 6 * ppg > Pilots.Count ? Pilots.Count - 5 * ppg : ppg)
                };
                gvGroupF.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 6)
            {
                var gr = new Group
                {
                    Name = "Group G",
                    Pilots = Pilots.GetRange(6 * ppg, 7 * ppg > Pilots.Count ? Pilots.Count - 6 * ppg : ppg)
                };
                gvGroupG.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 7)
            {
                var gr = new Group
                {
                    Name = "Group H",
                    Pilots = Pilots.GetRange(7 * ppg, 8 * ppg > Pilots.Count ? Pilots.Count - 7 * ppg : ppg)
                };
                gvGroupH.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 8)
            {
                var gr = new Group
                {
                    Name = "Group I",
                    Pilots = Pilots.GetRange(8 * ppg, 9 * ppg > Pilots.Count ? Pilots.Count - 8 * ppg : ppg)
                };
                gvGroupI.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 9)
            {
                var gr = new Group
                {
                    Name = "Group J",
                    Pilots = Pilots.GetRange(9 * ppg, 10 * ppg > Pilots.Count ? Pilots.Count - 9 * ppg : ppg)
                };
                gvGroupJ.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 10)
            {
                var gr = new Group
                {
                    Name = "Group K",
                    Pilots = Pilots.GetRange(10 * ppg, 11 * ppg > Pilots.Count ? Pilots.Count - 10 * ppg : ppg)
                };
                gvGroupK.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 11)
            {
                var gr = new Group
                {
                    Name = "Group L",
                    Pilots = Pilots.GetRange(11 * ppg, 12 * ppg > Pilots.Count ? Pilots.Count - 11 * ppg : ppg)
                };
                gvGroupL.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 12)
            {
                var gr = new Group
                {
                    Name = "Group M",
                    Pilots = Pilots.GetRange(12 * ppg, 13 * ppg > Pilots.Count ? Pilots.Count - 12 * ppg : ppg)
                };
                gvGroupM.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 13)
            {
                var gr = new Group
                {
                    Name = "Group N",
                    Pilots = Pilots.GetRange(13 * ppg, 14 * ppg > Pilots.Count ? Pilots.Count - 13 * ppg : ppg)
                };
                gvGroupN.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            if (Pilots.Count > ppg * 14)
            {
                var gr = new Group
                {
                    Name = "Group O",
                    Pilots = Pilots.GetRange(14 * ppg, 15 * ppg > Pilots.Count ? Pilots.Count - 14 * ppg : ppg)
                };
                gvGroupO.DataSource = gr.Pilots;
                _race.Groups.Add(gr);
            }

            #region Groups Insertion

            database objDatabase = new database();
            string sqlQuery;
            SQLiteCommand cmd;

            foreach (var item in _race.Groups)
            {
                if (item.Id == 0)
                {
                    sqlQuery = "insert into Groups (Name) values ('" + Convert.ToString(item.Name) + "')";
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                    item.Id = Convert.ToInt32(getLastInsertedId(cmd));

                    sqlQuery = "delete from Pilot_Groups where GroupId =" + Convert.ToInt32(item.Id);
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                }

                foreach (var pilot in item.Pilots)
                {
                    if (pilot != null)
                    {
                        sqlQuery = "delete from Pilot_Groups where PilotId =" + pilot.Id + " and GroupId =" + Convert.ToInt32(item.Id);
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();

                        sqlQuery = "insert into Pilot_Groups (PilotId, GroupId) values ('" + Convert.ToInt32(pilot.Id) + "', '" + Convert.ToInt32(item.Id) + "')";
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();
                        //pilot.Id = Convert.ToInt32(getLastInsertedId(cmd));
                    }
                }
            }
            #endregion

            cmbRaceGroup.Items.Clear();
            _race.Groups.ForEach(i => cmbRaceGroup.Items.Add(i.Name));

            cmbRaceRound.Items.Clear();
            var numberOfQual = (int)nudNumberOfQualRounds.Value;
            for (int i = 1; i <= numberOfQual; i++)
            {
                cmbRaceRound.Items.Add("Q" + i);
            }
        }

        private void btnAddPilotsToQF_Click(object sender, EventArgs e)
        {
            // 1/4 finals
            var group = new Group
            {
                Name = "Group A (R)",
                Pilots = new List<Pilot>
                {
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(0)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(4)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(8)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(12)?.Epc),
                }
            };
            gvGroupAQ.DataSource = group.Pilots;
            _race.Groups.Add(group);

            group = new Group
            {
                Name = "Group B (R)",
                Pilots = new List<Pilot>
                {
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(3)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(7)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(11)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(15)?.Epc),
                }
            };
            gvGroupBQ.DataSource = group.Pilots;
            _race.Groups.Add(group);

            group = new Group
            {
                Name = "Group C (R)",
                Pilots = new List<Pilot>
                {
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(2)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(6)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(10)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(14)?.Epc),
                }
            };
            gvGroupCQ.DataSource = group.Pilots;
            _race.Groups.Add(group);

            group = new Group
            {
                Name = "Group D (R)",
                Pilots = new List<Pilot>
                {
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(1)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(5)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(9)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == _bestQualificationResuls.ElementAtOrDefault(13)?.Epc),
                }
            };
            gvGroupDQ.DataSource = group.Pilots;
            _race.Groups.Add(group);

            #region Groups Insertion

            database objDatabase = new database();
            string sqlQuery;
            SQLiteCommand cmd;

            foreach (var item in _race.Groups)
            {
                if (item.Id == 0)
                {
                    sqlQuery = "insert into Groups (Name) values ('" + Convert.ToString(item.Name) + "')";
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                    item.Id = Convert.ToInt32(getLastInsertedId(cmd));

                    sqlQuery = "delete from Pilot_Groups where GroupId =" + Convert.ToInt32(item.Id);
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                }

                foreach (var pilot in item.Pilots)
                {
                    if (pilot != null)
                    {
                        sqlQuery = "delete from Pilot_Groups where PilotId =" + pilot.Id + " and GroupId =" + Convert.ToInt32(item.Id);
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();

                        sqlQuery = "insert into Pilot_Groups (PilotId, GroupId) values ('" + Convert.ToInt32(pilot.Id) + "', '" + Convert.ToInt32(item.Id) + "')";
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();
                        //pilot.Id = Convert.ToInt32(getLastInsertedId(cmd));
                    }
                }
            }
            #endregion

            cmbRaceGroup.Items.Clear();
            _race.Groups.ForEach(i => cmbRaceGroup.Items.Add(i.Name));

            cmbRaceRound.Items.Add("R");
        }

        private void btnAddPilotsToGroupsSF_Click(object sender, EventArgs e)
        {
            var race1 = _race.RaceEvents.FirstOrDefault(re => re.Group.Name == "Group A (R)");
            if (race1 == null) return;

            var race1Results = race1.Laps.Where(s => s.AvgLapTime.HasValue).OrderBy(s => s.AvgLapTime).ToList();
            race1Results.AddRange(race1.Laps.Where(s => !s.AvgLapTime.HasValue).ToList());

            var race2 = _race.RaceEvents.FirstOrDefault(re => re.Group.Name == "Group B (R)");
            if (race2 == null) return;
            var race2Results = race2.Laps.Where(s => s.AvgLapTime.HasValue).OrderBy(s => s.AvgLapTime).ToList();
            race2Results.AddRange(race2.Laps.Where(s => !s.AvgLapTime.HasValue).ToList());

            var race3 = _race.RaceEvents.FirstOrDefault(re => re.Group.Name == "Group C (R)");
            if (race3 == null) return;
            var race3Results = race3.Laps.Where(s => s.AvgLapTime.HasValue).OrderBy(s => s.AvgLapTime).ToList();
            race3Results.AddRange(race3.Laps.Where(s => !s.AvgLapTime.HasValue).ToList());

            var race4 = _race.RaceEvents.FirstOrDefault(re => re.Group.Name == "Group D (R)");
            if (race4 == null) return;
            var race4Results = race4.Laps.Where(s => s.AvgLapTime.HasValue).OrderBy(s => s.AvgLapTime).ToList();
            race4Results.AddRange(race4.Laps.Where(s => !s.AvgLapTime.HasValue).ToList());

            var group = new Group
            {
                Name = "Group A (S)",
                Pilots = new List<Pilot>
                {
                    Pilots.FirstOrDefault(p=>p.Tag == race1Results.ElementAtOrDefault(1)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race1Results.ElementAtOrDefault(0)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race2Results.ElementAtOrDefault(0)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race2Results.ElementAtOrDefault(1)?.Epc)
                }
            };
            gvGroupAS.DataSource = group.Pilots;
            _race.Groups.Add(group);

            group = new Group
            {
                Name = "Group B (S)",
                Pilots = new List<Pilot>
                {
                    Pilots.FirstOrDefault(p=>p.Tag == race3Results.ElementAtOrDefault(1)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race3Results.ElementAtOrDefault(0)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race4Results.ElementAtOrDefault(0)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race4Results.ElementAtOrDefault(1)?.Epc)
                }
            };
            gvGroupBS.DataSource = group.Pilots;
            _race.Groups.Add(group);

            #region Groups Insertion

            database objDatabase = new database();
            string sqlQuery;
            SQLiteCommand cmd;

            foreach (var item in _race.Groups)
            {
                if (item.Id == 0)
                {
                    sqlQuery = "insert into Groups (Name) values ('" + Convert.ToString(item.Name) + "')";
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                    item.Id = Convert.ToInt32(getLastInsertedId(cmd));

                    sqlQuery = "delete from Pilot_Groups where GroupId =" + Convert.ToInt32(item.Id);
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                }

                foreach (var pilot in item.Pilots)
                {
                    if (pilot != null)
                    {
                        sqlQuery = "delete from Pilot_Groups where PilotId =" + pilot.Id + " and GroupId =" + Convert.ToInt32(item.Id);
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();

                        sqlQuery = "insert into Pilot_Groups (PilotId, GroupId) values ('" + Convert.ToInt32(pilot.Id) + "', '" + Convert.ToInt32(item.Id) + "')";
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();
                        //pilot.Id = Convert.ToInt32(getLastInsertedId(cmd));
                    }
                }
            }
            #endregion

            cmbRaceGroup.Items.Clear();
            _race.Groups.ForEach(i => cmbRaceGroup.Items.Add(i.Name));

            // Semi final round
            cmbRaceRound.Items.Add("S");
        }

        private void btnAddPilotsToGroupsF_Click(object sender, EventArgs e)
        {
            // Final rounds
            var race1 = _race.RaceEvents.FirstOrDefault(re => re.Group.Name == "Group A (S)");
            if (race1 == null) return;

            var race1Results = race1.Laps.Where(s => s.AvgLapTime.HasValue).OrderBy(s => s.AvgLapTime).ToList();
            race1Results.AddRange(race1.Laps.Where(s => !s.AvgLapTime.HasValue).ToList());

            var race2 = _race.RaceEvents.FirstOrDefault(re => re.Group.Name == "Group B (S)");
            if (race2 == null) return;

            var race2Results = race2.Laps.Where(s => s.AvgLapTime.HasValue).OrderBy(s => s.AvgLapTime).ToList();
            race2Results.AddRange(race2.Laps.Where(s => !s.AvgLapTime.HasValue).ToList());

            var group = new Group
            {
                Name = "Group A (F)",
                Pilots = new List<Pilot>
                {
                    Pilots.FirstOrDefault(p=>p.Tag == race1Results.ElementAtOrDefault(0)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race1Results.ElementAtOrDefault(1)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race2Results.ElementAtOrDefault(0)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race2Results.ElementAtOrDefault(1)?.Epc)
                }
            };
            gvGroupAF.DataSource = group.Pilots;
            _race.Groups.Add(group);

            group = new Group
            {
                Name = "Group B (F)",
                Pilots = new List<Pilot>
                {
                    Pilots.FirstOrDefault(p=>p.Tag == race1Results.ElementAtOrDefault(2)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race1Results.ElementAtOrDefault(3)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race2Results.ElementAtOrDefault(2)?.Epc),
                    Pilots.FirstOrDefault(p=>p.Tag == race2Results.ElementAtOrDefault(3)?.Epc)
                }
            };
            gvGroupBF.DataSource = group.Pilots;
            _race.Groups.Add(group);

            #region Groups Insertion

            database objDatabase = new database();
            string sqlQuery;
            SQLiteCommand cmd;

            foreach (var item in _race.Groups)
            {
                if (item.Id == 0)
                {
                    sqlQuery = "insert into Groups (Name) values ('" + Convert.ToString(item.Name) + "')";
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                    item.Id = Convert.ToInt32(getLastInsertedId(cmd));

                    sqlQuery = "delete from Pilot_Groups where GroupId =" + Convert.ToInt32(item.Id);
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                }

                foreach (var pilot in item.Pilots)
                {
                    if (pilot != null)
                    {
                        sqlQuery = "delete from Pilot_Groups where PilotId =" + pilot.Id + " and GroupId =" + Convert.ToInt32(item.Id);
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();

                        sqlQuery = "insert into Pilot_Groups (PilotId, GroupId) values ('" + Convert.ToInt32(pilot.Id) + "', '" + Convert.ToInt32(item.Id) + "')";
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();
                        //pilot.Id = Convert.ToInt32(getLastInsertedId(cmd));
                    }
                }
            }
            #endregion

            cmbRaceGroup.Items.Clear();
            _race.Groups.ForEach(i => cmbRaceGroup.Items.Add(i.Name));

            cmbRaceRound.Items.Add("F");
        }

        #endregion

        #region Ranking
        private void cmbDisplayRanking_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRanking();
        }

        private List<LapsInfo> _bestQualificationResuls;
        private void UpdateRanking()
        {
            var avgSource = new List<LapsInfo>();
            var bestSource = new List<LapsInfo>();

            foreach (var raceEvent in _race.RaceEvents)
            {
                //Only qualification rounds
                if (!raceEvent.Round.StartsWith("Q")) continue;

                foreach (var lap in raceEvent.Laps)
                {
                    var existingLap = avgSource.FirstOrDefault(s => s.Epc == lap.Epc);
                    if (existingLap == null)
                        avgSource.Add(lap);
                    else
                    {
                        if (existingLap.AvgLapTime > lap.AvgLapTime)
                            avgSource[avgSource.IndexOf(existingLap)] = lap;
                    }

                    existingLap = bestSource.FirstOrDefault(s => s.Epc == lap.Epc);
                    if (existingLap == null)
                        bestSource.Add(lap);
                    else
                    {
                        if (existingLap.BestLapTime > lap.BestLapTime)
                            bestSource[bestSource.IndexOf(existingLap)] = lap;
                    }
                }
            }

            var bestOrderedList = bestSource.Where(s => s.BestLapTime.HasValue).OrderBy(s => s.BestLapTime).ToList();
            bestOrderedList.AddRange(bestSource.Where(s => !s.BestLapTime.HasValue).ToList());

            var avgOrderedList = avgSource.Where(s => s.AvgLapTime.HasValue).OrderBy(s => s.AvgLapTime).ToList();
            avgOrderedList.AddRange(avgSource.Where(s => !s.AvgLapTime.HasValue).ToList());
            _bestQualificationResuls = avgOrderedList;

            // Best lap ranking
            if (cmbDisplayRanking.SelectedIndex == 0)
            {
                bestOrderedList.ForEach(l => l.RankNumber = bestOrderedList.IndexOf(l) + 1);
                bindingSourceRanking.DataSource = bestOrderedList;

                avgLapTimeStringDataGridViewTextBoxColumn.Visible = false;
                bestLapTimeStringDataGridViewTextBoxColumn.Visible = true;
            }

            // Average lap ranking
            if (cmbDisplayRanking.SelectedIndex == 1)
            {
                avgOrderedList.ForEach(l => l.RankNumber = avgOrderedList.IndexOf(l) + 1);
                bindingSourceRanking.DataSource = avgOrderedList;

                avgLapTimeStringDataGridViewTextBoxColumn.Visible = true;
                bestLapTimeStringDataGridViewTextBoxColumn.Visible = false;
            }
        }
        #endregion

        private void btnRaceSave_Click(object sender, EventArgs e) // Confirm And Save Button
        {
            database objDatabase = new database();
            string sqlQuery;
            SQLiteCommand cmd;

            // Insert into RACES table
            if (_race.Id == 0)
            {
                sqlQuery = "insert into Races (Name, Location, Date, NumberOfLaps, NumberOfQualRounds) values ('" + Convert.ToString(_race.Name) + "' , '" + Convert.ToString(_race.Location) + "' , '" + Convert.ToString(_race.Date) + "', '" + nudNumOfLaps.Value + "', '" + nudNumberOfQualRounds.Value + "')";
                cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                cmd.ExecuteNonQuery();
                _race.Id = Convert.ToInt32(getLastInsertedId(cmd));
            }

            foreach (var raceEvent in _race.RaceEvents)
            {
                // Insert into RaceEvents table
                if (raceEvent.Id == 0)
                {
                    sqlQuery = "insert into RaceEvents (RaceId, Name, Group_Id) values (" + Convert.ToInt32(_race.Id) + ", '" + Convert.ToString(raceEvent.Round) + "', " + raceEvent.Group.Id + "  )";
                    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                    cmd.ExecuteNonQuery();
                    raceEvent.Id = Convert.ToInt32(getLastInsertedId(cmd));
                }

                foreach (var laps in raceEvent.Laps)
                {
                    // Insert into LapsInfos table
                    if (laps.Id == 0 && Convert.ToString(laps.Lap1) != null)
                    {
                        sqlQuery = "insert into LapsInfos (PilotId, PilotName, RaceEventId, OrderNumber, RankNumber, Epc, Pc, IdCount, Rssi, CarrFrequency, Lap1, Lap2, Lap3," +
                        "Lap4, Lap5, Lap6, AvgLapTime, BestLapTime, GroupId)" +
                    " values (" + Convert.ToInt32(laps.PilotId) + ", '" + Convert.ToString(laps.PilotName) + "', " + Convert.ToInt32(raceEvent.Id) + ", " +
                    " " + laps.OrderNumber + ", " + laps.RankNumber + ", '" + laps.Epc + "', '" + laps.Pc + "', " + laps.IdCount + ", '" + laps.Rssi + "'" +
                    ", " + Convert.ToDecimal(laps.CarrFrequency) + ", '" + Convert.ToString(laps.Lap1) + "', '" + Convert.ToString(laps.Lap2) + "', '" + Convert.ToString(laps.Lap3) + "'" +
                    ", '" + Convert.ToString(laps.Lap4) + "', '" + Convert.ToString(laps.Lap5) + "', '" + Convert.ToString(laps.Lap6) + "'" +
                    ",'" + Convert.ToString(laps.AvgLapTimeString) + "', '" + Convert.ToString(laps.BestLapTimeString) + "', '" + raceEvent.Group.Id + "' )";
                        cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
                        cmd.ExecuteNonQuery();
                        laps.Id = Convert.ToInt32(getLastInsertedId(cmd));
                    }
                }
            }

            //foreach (var group in _race.Groups)
            //{
            //    // Insert into GROUP table and Update GroupId into RaceEvents Collection
            //    sqlQuery = "insert into Groups (RaceId, Name) values (" + Convert.ToInt32(_race.Id) + ", '" + Convert.ToString(group.Name) + "')";
            //    cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
            //    cmd.ExecuteNonQuery();
            //    group.Id = Convert.ToInt32(getLastInsertedId(cmd));

            //    foreach (var raceEvent in _race.RaceEvents)
            //    {
            //        // Insert into RACEEVENTS table
            //        if (group.Name == raceEvent.Group.Name)
            //        {
            //            sqlQuery = "insert into RaceEvents (RaceId, Name, Group_Id) values (" + Convert.ToInt32(_race.Id) + ", '" + Convert.ToString(raceEvent.Round) + "', " + group.Id + "  )";
            //            cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
            //            cmd.ExecuteNonQuery();
            //            raceEvent.Id = Convert.ToInt32(getLastInsertedId(cmd));

            //            foreach (var laps in raceEvent.Laps)
            //            {
            //                // Insert into LAPSINFOS table
            //                sqlQuery = "insert into LapsInfos (PilotId, PilotName, RaceEventId, OrderNumber, RankNumber, Epc, Pc, IdCount, Rssi, CarrFrequency, Lap1, Lap2, Lap3," +
            //                    "Lap4, Lap5, Lap6, AvgLapTime, BestLapTime)" +
            //                " values (" + Convert.ToInt32(laps.PilotId) + ", '" + Convert.ToString(laps.PilotName) + "', " + Convert.ToInt32(raceEvent.Id) + ", " +
            //                " " + laps.OrderNumber + ", " + laps.RankNumber + ", '" + laps.Epc + "', '" + laps.Pc + "', " + laps.IdCount + ", '" + laps.Rssi + "'" +
            //                ", " + Convert.ToDecimal(laps.CarrFrequency) + ", '" + Convert.ToString(laps.Lap1) + "', '" + Convert.ToString(laps.Lap2) + "', '" + Convert.ToString(laps.Lap3) + "'" +
            //                ", '" + Convert.ToString(laps.Lap4) + "', '" + Convert.ToString(laps.Lap5) + "', '" + Convert.ToString(laps.Lap6) + "'" +
            //                ",'" + Convert.ToString(laps.AvgLapTimeString) + "', '" + Convert.ToString(laps.BestLapTimeString) + "' )";
            //                cmd = new SQLiteCommand(sqlQuery, objDatabase.get_SQLiteConnection());
            //                cmd.ExecuteNonQuery();
            //            }
            //        }
            //    }
            //}
        }

        public int getLastInsertedId(SQLiteCommand cmd)
        {
            //database objDatabase = new database();
            //SQLiteCommand cmd;
            string lastRowIdQuery;
            lastRowIdQuery = @"select last_insert_rowid()";
            //cmd = new SQLiteCommand(objDatabase.get_SQLiteConnection());
            cmd.CommandText = lastRowIdQuery;
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void gvRace_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateRanking();
        }

        private void groupBox35_Enter(object sender, EventArgs e)
        {

        }
    }
}

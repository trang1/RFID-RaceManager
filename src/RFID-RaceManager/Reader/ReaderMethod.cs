using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;
using System.Threading;

namespace Reader
{
    public delegate void ReciveDataCallback(byte[] btAryReceiveData);
    public delegate void SendDataCallback(byte[] btArySendData);
    public delegate void AnalyDataCallback(MessageTran msgTran);

    public class ReaderMethod
    {
        private readonly IConnector _connector;
        private readonly SerialPort _serialPort;
        private int m_nType = -1; 

        public ReciveDataCallback ReceiveCallback;
        public SendDataCallback SendCallback;
        public AnalyDataCallback AnalyCallback;

        //Record untreated received data, the main consideration to accept the section of received data
        byte[] m_btAryBuffer = new byte[4096];
        //Record the effective length of untreated data
        int m_nLenth = 0;

        public ReaderMethod()
        {
            this._connector = new TcpConnector();

            _connector.MessageReceived += new MessageReceivedEventHandler(ReceivedTcpData);

            _serialPort = new SerialPort();

            _serialPort.DataReceived+=new SerialDataReceivedEventHandler(ReceivedComData);
        }

        public int OpenCom(string strPort, int nBaudrate, out string strException)
        {
            strException = string.Empty;

            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            try
            {
                _serialPort.PortName = strPort;
                _serialPort.BaudRate = nBaudrate;
                _serialPort.ReadTimeout = 200;
                _serialPort.Open();
            }
            catch (System.Exception ex)
            {
                strException = ex.Message;
                return -1;
            }

            m_nType = 0;
            return 0;
        }

        public void CloseCom()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            m_nType = -1;
        }

        public int ConnectServer(IPAddress ipAddress, int nPort, out string strException)
        {
            strException = string.Empty;

            if (!_connector.Connect(ipAddress, nPort, out strException))
            {
                return -1;
            }

            m_nType = 1;
            return 0;
        }

        public void SignOut()
        {
            _connector.SignOut();
            m_nType = -1;
        }

        private void ReceivedTcpData(byte[] btAryBuffer)
        {
            RunReceiveDataCallback(btAryBuffer);
        }

        private void ReceivedComData(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int nCount = _serialPort.BytesToRead;
                if (nCount == 0)
                {
                    return;
                }

                byte[] btAryBuffer = new byte[nCount];
                _serialPort.Read(btAryBuffer, 0, nCount);

                RunReceiveDataCallback(btAryBuffer);
            }
            catch (System.Exception ex)
            {
            	
            }
        }

        private void RunReceiveDataCallback(byte[] btAryReceiveData)
        {
            try
            {
                if (ReceiveCallback != null)
                {
                    ReceiveCallback(btAryReceiveData);
                }
                
                int nCount = btAryReceiveData.Length;
                byte[] btAryBuffer = new byte[nCount + m_nLenth];
                Array.Copy(m_btAryBuffer, btAryBuffer, m_nLenth);
                Array.Copy(btAryReceiveData, 0, btAryBuffer, m_nLenth, btAryReceiveData.Length);

                //Analyze received data, with 0xA0 as starting point，with data length in protocol as end point
                int nIndex = 0;//Record data end point when there is AO
                int nMarkIndex = 0;//When there is not AO, nMarkIndex equals to data sets maximum index
                for (int nLoop = 0; nLoop < btAryBuffer.Length; nLoop++)
                {
                    if (btAryBuffer.Length > nLoop + 1)
                    {
                        if (btAryBuffer[nLoop] == 0xA0)
                        {
                            int nLen = Convert.ToInt32(btAryBuffer[nLoop + 1]);
                            if (nLoop + 1 + nLen < btAryBuffer.Length)
                            {
                                byte[] btAryAnaly = new byte[nLen + 2];
                                Array.Copy(btAryBuffer, nLoop, btAryAnaly, 0, nLen + 2);

                                MessageTran msgTran = new MessageTran(btAryAnaly);
                                if (AnalyCallback != null)
                                {
                                    AnalyCallback(msgTran);
                                } 

                                nLoop += 1 + nLen;
                                nIndex = nLoop + 1;
                            }
                            else
                            {
                                nLoop += 1 + nLen;
                            }
                        }
                        else
                        {
                            nMarkIndex = nLoop;
                        }
                    }
                }

                if (nIndex < nMarkIndex)
                {
                    nIndex = nMarkIndex + 1;
                }

                if (nIndex < btAryBuffer.Length)
                {
                    m_nLenth = btAryBuffer.Length - nIndex;
                    Array.Clear(m_btAryBuffer, 0, 4096);
                    Array.Copy(btAryBuffer, nIndex, m_btAryBuffer, 0, btAryBuffer.Length - nIndex);
                }
                else
                {
                    m_nLenth = 0;
                }
            }
            catch (System.Exception ex)
            {
            	
            }            
        }

        public int SendMessage(byte[] btArySenderData)
        {
            //Serial Connection
            if (m_nType == 0)
            {
                if (!_serialPort.IsOpen)
                {
                    return -1;
                }

                _serialPort.Write(btArySenderData, 0, btArySenderData.Length);

                if (SendCallback != null)
                {
                    SendCallback(btArySenderData);
                }

                return 0;
            }
            //Tcp Connection
            else if (m_nType == 1)
            {
                if (!_connector.IsConnect())
                {
                    return -1;
                }

                if (_connector.SendMessage(btArySenderData))
                {
                    if (SendCallback != null)
                    {
                        SendCallback(btArySenderData);
                    }

                    return 0;
                }
            }

            return -1;
        }

        private int SendMessage(byte btReadId, byte btCmd)
        {
            MessageTran msgTran = new MessageTran(btReadId, btCmd);

            return SendMessage(msgTran.AryTranData);
        }

        private int SendMessage(byte btReadId, byte btCmd, byte[] btAryData)
        {
            MessageTran msgTran = new MessageTran(btReadId, btCmd, btAryData);

            return SendMessage(msgTran.AryTranData);
        }

        public byte CheckValue(byte[] btAryData)
        {
            MessageTran msgTran = new MessageTran();

            return msgTran.CheckSum(btAryData, 0, btAryData.Length);
        }

        public int Reset(byte btReadId)
        {
            byte btCmd = 0x70;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int SetUartBaudrate(byte btReadId, int nIndexBaudrate)
        {
            byte btCmd = 0x71;
            byte[] btAryData = new byte[1];
            btAryData[0] = Convert.ToByte(nIndexBaudrate);

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetFirmwareVersion(byte btReadId)
        {
            byte btCmd = 0x72;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int SetReaderAddress(byte btReadId, byte btNewReadId)
        {
            byte btCmd = 0x73;
            byte[] btAryData = new byte[1];
            btAryData[0] = btNewReadId;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int SetWorkAntenna(byte btReadId, byte btWorkAntenna)
        {
            byte btCmd = 0x74;
            byte[] btAryData = new byte[1];
            btAryData[0] = btWorkAntenna;
            int nResult = SendMessage(btReadId, btCmd, btAryData);
            return nResult;
        }

        public int GetWorkAntenna(byte btReadId)
        {
            byte btCmd = 0x75;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int SetOutputPower(byte btReadId, byte btOutputPower)
        {
            byte btCmd = 0x76;
            byte[] btAryData = new byte[1];
            btAryData[0] = btOutputPower;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetOutputPower(byte btReadId)
        {
            byte btCmd = 0x77;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int MeasureReturnLoss(byte btReadId, byte btFrequency)
        {
            byte btCmd = 0x7E;
            byte[] btAryData = new byte[1];
            btAryData[0] = btFrequency;
            int nResult = SendMessage(btReadId, btCmd, btAryData);
            return nResult;
        }

        public int SetFrequencyRegion(byte btReadId, byte btRegion, byte btStartRegion, byte btEndRegion)
        {
            byte btCmd = 0x78;
            byte[] btAryData = new byte[3];
            btAryData[0] = btRegion;
            btAryData[1] = btStartRegion;
            btAryData[2] = btEndRegion;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }
        public int SetUserDefineFrequency(byte btReadId, int nStartFreq, byte btFreqInterval, byte btChannelQuantity)
        {
            byte btCmd = 0x78;
            byte[] btAryFreq = new byte[3];
            byte[] btAryData = new byte[6];
            btAryFreq = BitConverter.GetBytes(nStartFreq);

            btAryData[0] = 4;
            btAryData[1] = btFreqInterval;
            btAryData[2] = btChannelQuantity;
            btAryData[3] = btAryFreq[2];
            btAryData[4] = btAryFreq[1];
            btAryData[5] = btAryFreq[0];
            
            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetFrequencyRegion(byte btReadId)
        {
            byte btCmd = 0x79;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int SetBeeperMode(byte btReadId, byte btMode)
        {
            byte btCmd = 0x7A;
            byte[] btAryData = new byte[1];
            btAryData[0] = btMode;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetReaderTemperature(byte btReadId)
        {
            byte btCmd = 0x7B;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int GetAntImpedanceMatch(byte btReadId, byte btFrequency)
        {
            byte btCmd = 0x7E;
            byte[] btAryData = new byte[1];
            btAryData[0] = btFrequency;
            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int SetDrmMode(byte btReadId, byte btDrmMode)
        {
            byte btCmd = 0x7C;
            byte[] btAryData = new byte[1];
            btAryData[0] = btDrmMode;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetDrmMode(byte btReadId)
        {
            byte btCmd = 0x7D;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int ReadGpioValue(byte btReadId)
        {
            byte btCmd = 0x60;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int WriteGpioValue(byte btReadId, byte btChooseGpio, byte btGpioValue)
        {
            byte btCmd = 0x61;
            byte[] btAryData = new byte[2];
            btAryData[0] = btChooseGpio;
            btAryData[1] = btGpioValue;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int SetAntDetector(byte btReadId, byte btDetectorStatus)
        {
            byte btCmd = 0x62;
            byte[] btAryData = new byte[1];
            btAryData[0] = btDetectorStatus;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetAntDetector(byte btReadId)
        {
            byte btCmd = 0x63;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int GetMonzaStatus(byte btReadId)
        {
            byte btCmd = 0x8e;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int SetMonzaStatus(byte btReadId, byte btMonzaStatus)
        {
            byte btCmd = 0x8D;
            byte[] btAryData = new byte[1];
            btAryData[0] = btMonzaStatus;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int SetRadioProfile(byte btReadId, byte btProfile)
        {
            byte btCmd = 0x69;
            byte[] btAryData = new byte[1];
            btAryData[0] = btProfile;
            int nResult = SendMessage(btReadId, btCmd, btAryData);
            return nResult;
        }
        public int GetRadioProfile(byte btReadId)
        {
            byte btCmd = 0x6A;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int GetReaderIdentifier(byte btReadId)
        {
            byte btCmd = 0x68;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int SetReaderIdentifier(byte btReadId, byte[] identifier)
        {
            byte btCmd = 0x67;

            int nResult = SendMessage(btReadId, btCmd, identifier);

            return nResult;
        }


        public int Inventory(byte btReadId, byte byRound)
        {
            byte btCmd = 0x80;
            byte[] btAryData = new byte[1];
            btAryData[0] = byRound;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int CustomizedInventory(byte btReadId, byte session, byte target,byte byRound)
        {
            byte btCmd = 0x8B;
            byte[] btAryData = new byte[3];
            btAryData[0] = session;
            btAryData[1] = target;
            btAryData[2] = byRound;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int ReadTag(byte btReadId, byte btMemBank, byte btWordAdd, byte btWordCnt)
        {
            byte btCmd = 0x81;
            byte[] btAryData = new byte[3];
            btAryData[0] = btMemBank;
            btAryData[1] = btWordAdd;
            btAryData[2] = btWordCnt;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int WriteTag(byte btReadId, byte[] btAryPassWord, byte btMemBank, byte btWordAdd, byte btWordCnt, byte[] btAryData)
        {
            byte btCmd = 0x82;
            byte[] btAryBuffer = new byte[btAryData.Length + 7];
            btAryPassWord.CopyTo(btAryBuffer, 0);
            btAryBuffer[4] = btMemBank;
            btAryBuffer[5] = btWordAdd;
            btAryBuffer[6] = btWordCnt;
            btAryData.CopyTo(btAryBuffer, 7);

            int nResult = SendMessage(btReadId, btCmd, btAryBuffer);

            return nResult;
        }

        public int LockTag(byte btReadId, byte[] btAryPassWord, byte btMembank, byte btLockType)
        {
            byte btCmd = 0x83;
            byte[] btAryData = new byte[6];
            btAryPassWord.CopyTo(btAryData, 0);
            btAryData[4] = btMembank;
            btAryData[5] = btLockType;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int KillTag(byte btReadId, byte[] btAryPassWord)
        {
            byte btCmd = 0x84;
            byte[] btAryData = new byte[4];
            btAryPassWord.CopyTo(btAryData, 0);

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int SetAccessEpcMatch(byte btReadId, byte btMode, byte btEpcLen, byte[] btAryEpc)
        {
            byte btCmd = 0x85;
            int nLen = Convert.ToInt32(btEpcLen) + 2;
            byte[] btAryData = new byte[nLen];
            btAryData[0] = btMode;
            btAryData[1] = btEpcLen;
            btAryEpc.CopyTo(btAryData, 2);

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int CancelAccessEpcMatch(byte btReadId, byte btMode)
        {
            byte btCmd = 0x85;
            byte[] btAryData = new byte[1];
            btAryData[0] = btMode;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetAccessEpcMatch(byte btReadId)
        {
            byte btCmd = 0x86;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int InventoryReal(byte btReadId, byte byRound)
        {
            byte btCmd = 0x89;
            byte[] btAryData = new byte[1];
            btAryData[0] = byRound;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int FastSwitchInventory(byte btReadId, byte[] btAryData)
        {
            byte btCmd = 0x8A;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetInventoryBuffer(byte btReadId)
        {
            byte btCmd = 0x90;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int GetAndResetInventoryBuffer(byte btReadId)
        {
            byte btCmd = 0x91;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int GetInventoryBufferTagCount(byte btReadId)
        {
            byte btCmd = 0x92;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int ResetInventoryBuffer(byte btReadId)
        {
            byte btCmd = 0x93;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int SetBufferDataFrameInterval(byte btReadId, byte btInterval)
        {
            byte btCmd = 0x94;
            byte[] btAryData = new byte[1];
            btAryData[0] = btInterval;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int GetBufferDataFrameInterval(byte btReadId)
        {
            byte btCmd = 0x95;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int InventoryISO18000(byte btReadId)
        {
            byte btCmd = 0xb0;

            int nResult = SendMessage(btReadId, btCmd);

            return nResult;
        }

        public int ReadTagISO18000(byte btReadId, byte[] btAryUID, byte btWordAdd, byte btWordCnt)
        {
            byte btCmd = 0xb1;
            int nLen = btAryUID.Length + 2;
            byte[] btAryData = new byte[nLen];
            btAryUID.CopyTo(btAryData, 0);
            btAryData[nLen - 2] = btWordAdd;
            btAryData[nLen - 1] = btWordCnt;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int WriteTagISO18000(byte btReadId, byte[] btAryUID, byte btWordAdd, byte btWordCnt, byte[] btAryBuffer)
        {
            byte btCmd = 0xb2;
            int nLen = btAryUID.Length + 2 + btAryBuffer.Length;
            byte[] btAryData = new byte[nLen];
            btAryUID.CopyTo(btAryData, 0);
            btAryData[btAryUID.Length] = btWordAdd;
            btAryData[btAryUID.Length + 1] = btWordCnt;
            btAryBuffer.CopyTo(btAryData, btAryUID.Length + 2);

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int LockTagISO18000(byte btReadId, byte[] btAryUID, byte btWordAdd)
        {
            byte btCmd=0xb3;
            int nLen = btAryUID.Length + 1;
            byte[] btAryData = new byte[nLen];
            btAryUID.CopyTo(btAryData, 0);
            btAryData[nLen - 1] = btWordAdd;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }

        public int QueryTagISO18000(byte btReadId, byte[] btAryUID, byte btWordAdd)
        {
            byte btCmd = 0xb4;
            int nLen = btAryUID.Length + 1;
            byte[] btAryData = new byte[nLen];
            btAryUID.CopyTo(btAryData, 0);
            btAryData[nLen - 1] = btWordAdd;

            int nResult = SendMessage(btReadId, btCmd, btAryData);

            return nResult;
        }
    }
}

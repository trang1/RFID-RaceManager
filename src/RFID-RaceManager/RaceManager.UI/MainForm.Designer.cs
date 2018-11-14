namespace RaceManager.UI
{
    partial class MainForm
    {
        /// <summary>
        /// The necessary designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean all using resources.
        /// </summary>
        /// <param name="disposing">If hosting resources should be released,is true,or is false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// The designer support the required method - No
        /// Use the core editor to modify contents of this method.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabCtrMain = new System.Windows.Forms.TabControl();
            this.PagReaderSetting = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ckClearOperationRec = new System.Windows.Forms.CheckBox();
            this.ckDisplayLog = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.btReaderSetupRefresh = new System.Windows.Forms.Button();
            this.gbCmdReadGpio = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.rdbGpio3High = new System.Windows.Forms.RadioButton();
            this.rdbGpio3Low = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.rdbGpio4High = new System.Windows.Forms.RadioButton();
            this.rdbGpio4Low = new System.Windows.Forms.RadioButton();
            this.btnWriteGpio4Value = new System.Windows.Forms.Button();
            this.btnWriteGpio3Value = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.rdbGpio1High = new System.Windows.Forms.RadioButton();
            this.rdbGpio1Low = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.rdbGpio2High = new System.Windows.Forms.RadioButton();
            this.rdbGpio2Low = new System.Windows.Forms.RadioButton();
            this.btnReadGpioValue = new System.Windows.Forms.Button();
            this.gbCmdBeeper = new System.Windows.Forms.GroupBox();
            this.btnSetBeeperMode = new System.Windows.Forms.Button();
            this.rdbBeeperModeTag = new System.Windows.Forms.RadioButton();
            this.rdbBeeperModeInventory = new System.Windows.Forms.RadioButton();
            this.rdbBeeperModeSlient = new System.Windows.Forms.RadioButton();
            this.gbCmdTemperature = new System.Windows.Forms.GroupBox();
            this.btnGetReaderTemperature = new System.Windows.Forms.Button();
            this.txtReaderTemperature = new System.Windows.Forms.TextBox();
            this.gbCmdVersion = new System.Windows.Forms.GroupBox();
            this.btnGetFirmwareVersion = new System.Windows.Forms.Button();
            this.txtFirmwareVersion = new System.Windows.Forms.TextBox();
            this.btnResetReader = new System.Windows.Forms.Button();
            this.gbCmdBaudrate = new System.Windows.Forms.GroupBox();
            this.htbGetIdentifier = new CustomControl.HexTextBox();
            this.htbSetIdentifier = new CustomControl.HexTextBox();
            this.btSetIdentifier = new System.Windows.Forms.Button();
            this.btGetIdentifier = new System.Windows.Forms.Button();
            this.gbTcpIp = new System.Windows.Forms.GroupBox();
            this.btnDisconnectTcp = new System.Windows.Forms.Button();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.btnConnectTcp = new System.Windows.Forms.Button();
            this.ipIpServer = new CustomControl.IpAddressTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbReturnLoss = new System.Windows.Forms.GroupBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.cmbReturnLossFreq = new System.Windows.Forms.ComboBox();
            this.label108 = new System.Windows.Forms.Label();
            this.textReturnLoss = new System.Windows.Forms.TextBox();
            this.btReturnLoss = new System.Windows.Forms.Button();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.btGetProfile = new System.Windows.Forms.Button();
            this.btSetProfile = new System.Windows.Forms.Button();
            this.rdbProfile3 = new System.Windows.Forms.RadioButton();
            this.rdbProfile2 = new System.Windows.Forms.RadioButton();
            this.rdbProfile1 = new System.Windows.Forms.RadioButton();
            this.rdbProfile0 = new System.Windows.Forms.RadioButton();
            this.btRfSetup = new System.Windows.Forms.Button();
            this.gbMonza = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbMonzaOff = new System.Windows.Forms.RadioButton();
            this.btSetMonzaStatus = new System.Windows.Forms.Button();
            this.btGetMonzaStatus = new System.Windows.Forms.Button();
            this.rdbMonzaOn = new System.Windows.Forms.RadioButton();
            this.gbCmdAntDetector = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAntDectector = new System.Windows.Forms.TextBox();
            this.btnGetAntDetector = new System.Windows.Forms.Button();
            this.btnSetAntDetector = new System.Windows.Forms.Button();
            this.gbCmdDrm = new System.Windows.Forms.GroupBox();
            this.btnGetDrmMode = new System.Windows.Forms.Button();
            this.btnSetDrmMode = new System.Windows.Forms.Button();
            this.rdbDrmModeClose = new System.Windows.Forms.RadioButton();
            this.rdbDrmModeOpen = new System.Windows.Forms.RadioButton();
            this.gbCmdAntenna = new System.Windows.Forms.GroupBox();
            this.label107 = new System.Windows.Forms.Label();
            this.cmbWorkAnt = new System.Windows.Forms.ComboBox();
            this.btnGetWorkAntenna = new System.Windows.Forms.Button();
            this.btnSetWorkAntenna = new System.Windows.Forms.Button();
            this.gbCmdRegion = new System.Windows.Forms.GroupBox();
            this.cbUserDefineFreq = new System.Windows.Forms.CheckBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label106 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.textFreqQuantity = new System.Windows.Forms.TextBox();
            this.TextFreqInterval = new System.Windows.Forms.TextBox();
            this.textStartFreq = new System.Windows.Forms.TextBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbFrequencyEnd = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbFrequencyStart = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbRegionChn = new System.Windows.Forms.RadioButton();
            this.rdbRegionEtsi = new System.Windows.Forms.RadioButton();
            this.rdbRegionFcc = new System.Windows.Forms.RadioButton();
            this.btnGetFrequencyRegion = new System.Windows.Forms.Button();
            this.btnSetFrequencyRegion = new System.Windows.Forms.Button();
            this.gbCmdOutputPower = new System.Windows.Forms.GroupBox();
            this.btnGetOutputPower = new System.Windows.Forms.Button();
            this.btnSetOutputPower = new System.Windows.Forms.Button();
            this.txtOutputPower = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pageEpcTest = new System.Windows.Forms.TabPage();
            this.tabEpcTest = new System.Windows.Forms.TabControl();
            this.tabTrack = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.label123 = new System.Windows.Forms.Label();
            this.cmbRoundType = new System.Windows.Forms.ComboBox();
            this.cbSecondChance = new System.Windows.Forms.CheckBox();
            this.label122 = new System.Windows.Forms.Label();
            this.btTrack = new System.Windows.Forms.Button();
            this.nudPilotsPerGroup = new System.Windows.Forms.NumericUpDown();
            this.label112 = new System.Windows.Forms.Label();
            this.tbRaceLength = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.nudMinLapTime = new System.Windows.Forms.NumericUpDown();
            this.label117 = new System.Windows.Forms.Label();
            this.nudMinFirstLapTime = new System.Windows.Forms.NumericUpDown();
            this.dtpRaceDate = new System.Windows.Forms.DateTimePicker();
            this.label111 = new System.Windows.Forms.Label();
            this.nudNumOfLaps = new System.Windows.Forms.NumericUpDown();
            this.label102 = new System.Windows.Forms.Label();
            this.nudNumberOfQualRounds = new System.Windows.Forms.NumericUpDown();
            this.tbRaceLocation = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.tbRaceName = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.tabPilots = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.btnClearDB = new System.Windows.Forms.Button();
            this.btnAddPilotFromDb = new System.Windows.Forms.Button();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.gvPilots = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePilots1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabRounds = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage22 = new System.Windows.Forms.TabPage();
            this.gvRace1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn215 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn216 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn217 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelRace1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSourcePilots = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage23 = new System.Windows.Forms.TabPage();
            this.gvRace2 = new System.Windows.Forms.DataGridView();
            this.tabPage24 = new System.Windows.Forms.TabPage();
            this.gvRace3 = new System.Windows.Forms.DataGridView();
            this.tabPage25 = new System.Windows.Forms.TabPage();
            this.gvRace4 = new System.Windows.Forms.DataGridView();
            this.tabPage26 = new System.Windows.Forms.TabPage();
            this.gvRace5 = new System.Windows.Forms.DataGridView();
            this.tabPage27 = new System.Windows.Forms.TabPage();
            this.gvRace6 = new System.Windows.Forms.DataGridView();
            this.tabPage28 = new System.Windows.Forms.TabPage();
            this.gvRace7 = new System.Windows.Forms.DataGridView();
            this.tabPage29 = new System.Windows.Forms.TabPage();
            this.gvRace8 = new System.Windows.Forms.DataGridView();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.btnManAddPilotsTo18F = new System.Windows.Forms.Button();
            this.btnAddPilotsTo18F = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.btnAddPilotsToQR = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.pageGroupA = new System.Windows.Forms.TabPage();
            this.gvGroupA = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupB = new System.Windows.Forms.TabPage();
            this.gvGroupB = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupC = new System.Windows.Forms.TabPage();
            this.gvGroupC = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupD = new System.Windows.Forms.TabPage();
            this.gvGroupD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupE = new System.Windows.Forms.TabPage();
            this.gvGroupE = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupF = new System.Windows.Forms.TabPage();
            this.gvGroupF = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupG = new System.Windows.Forms.TabPage();
            this.gvGroupG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupH = new System.Windows.Forms.TabPage();
            this.gvGroupH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupI = new System.Windows.Forms.TabPage();
            this.gvGroupI = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupJ = new System.Windows.Forms.TabPage();
            this.gvGroupJ = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupK = new System.Windows.Forms.TabPage();
            this.gvGroupK = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupL = new System.Windows.Forms.TabPage();
            this.gvGroupL = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupM = new System.Windows.Forms.TabPage();
            this.gvGroupM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupN = new System.Windows.Forms.TabPage();
            this.gvGroupN = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn87 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn88 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageGroupO = new System.Windows.Forms.TabPage();
            this.gvGroupO = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn93 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn95 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn96 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn97 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.gvGroupP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn158 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn159 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn160 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn161 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn162 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.gvGroupQ = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn163 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn164 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn165 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn166 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn167 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.gvGroupR = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn168 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn169 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn170 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn171 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn172 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.gvGroupS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn173 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn174 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn175 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn176 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn177 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.gvGroupT = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn178 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn179 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn180 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn181 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn182 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.gvGroupU = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn183 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn184 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn185 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn186 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn187 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.gvGroupV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn188 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn189 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn190 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn191 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn192 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.gvGroupW = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn193 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn194 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn195 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn196 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn197 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.gvGroupX = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn198 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn199 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn200 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn201 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn202 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.gvGroupY = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn203 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn204 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn205 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn206 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn207 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.gvGroupZ = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn208 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn209 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.btnManAddPilotsToF = new System.Windows.Forms.Button();
            this.btnAddPilotsToF = new System.Windows.Forms.Button();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.gvSmallFinal = new System.Windows.Forms.DataGridView();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.gvFinal = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.btnManAddPilotsToQF = new System.Windows.Forms.Button();
            this.btnAddPilotsToQF = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gvRace13 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gvRace14 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gvRace15 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.gvRace16 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.btnManAddPilotsToSF = new System.Windows.Forms.Button();
            this.btnAddPilotsToSF = new System.Windows.Forms.Button();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.gvSemi1 = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.gvSemi2 = new System.Windows.Forms.DataGridView();
            this.tabRace = new System.Windows.Forms.TabPage();
            this.gvRace = new System.Windows.Forms.DataGridView();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PilotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Epc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn155 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn156 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lap1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lap2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lap3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lap4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lap5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lap6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDifferential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestLapTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgLapTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisteredLapsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn253 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceRace = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.gvRanking = new System.Windows.Forms.DataGridView();
            this.RankNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilotNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestLapTimeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgLapTimeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn157 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceRanking = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDisplayRanking = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.btnReflight = new System.Windows.Forms.Button();
            this.btnRaceSave = new System.Windows.Forms.Button();
            this.tbCurEvGroup = new System.Windows.Forms.TextBox();
            this.tbCurEvRound = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRaceExport = new System.Windows.Forms.Button();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.btnRaceReset = new System.Windows.Forms.Button();
            this.btnRaceStop = new System.Windows.Forms.Button();
            this.btnRaceStart = new System.Windows.Forms.Button();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblRaceMilliSeconds = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblRaceSeconds = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblRaceMinutes = new System.Windows.Forms.Label();
            this.gbMimicRace = new System.Windows.Forms.GroupBox();
            this.label121 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.tbMimicName = new System.Windows.Forms.TextBox();
            this.tbMimicLocation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label118 = new System.Windows.Forms.Label();
            this.cmbRaceMode = new System.Windows.Forms.ComboBox();
            this.tbRaceMaxRssi = new System.Windows.Forms.TextBox();
            this.tbRaceMinRssi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRaceAnt1 = new System.Windows.Forms.CheckBox();
            this.cbRaceAnt4 = new System.Windows.Forms.CheckBox();
            this.cbRaceAnt2 = new System.Windows.Forms.CheckBox();
            this.cbRaceAnt3 = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbRaceGroup = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbRaceRound = new System.Windows.Forms.ComboBox();
            this.pageRealMode = new System.Windows.Forms.TabPage();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.cbRealWorkant1 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant4 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant3 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant2 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textRealRound = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.btRealTimeInventory = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbRealSession = new System.Windows.Forms.CheckBox();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.tbRealMinRssi = new System.Windows.Forms.TextBox();
            this.tbRealMaxRssi = new System.Windows.Forms.TextBox();
            this.btRealFresh = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.lbRealTagCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledReal3 = new LxControl.LxLedControl();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.ledReal5 = new LxControl.LxLedControl();
            this.ledReal2 = new LxControl.LxLedControl();
            this.ledReal4 = new LxControl.LxLedControl();
            this.label53 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.ledReal1 = new LxControl.LxLedControl();
            this.lvRealList = new System.Windows.Forms.ListView();
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageBufferedMode = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btClearBuffer = new System.Windows.Forms.Button();
            this.btQueryBuffer = new System.Windows.Forms.Button();
            this.btGetClearBuffer = new System.Windows.Forms.Button();
            this.btGetBuffer = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btBufferInventory = new System.Windows.Forms.Button();
            this.label85 = new System.Windows.Forms.Label();
            this.textReadRoundBuffer = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbBufferWorkant1 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant4 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant2 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant3 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ledBuffer4 = new LxControl.LxLedControl();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.ledBuffer5 = new LxControl.LxLedControl();
            this.ledBuffer2 = new LxControl.LxLedControl();
            this.ledBuffer3 = new LxControl.LxLedControl();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.ledBuffer1 = new LxControl.LxLedControl();
            this.btBufferFresh = new System.Windows.Forms.Button();
            this.labelBufferTagCount = new System.Windows.Forms.Label();
            this.lvBufferList = new System.Windows.Forms.ListView();
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageFast4AntMode = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ledFast4 = new LxControl.LxLedControl();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.ledFast5 = new LxControl.LxLedControl();
            this.ledFast2 = new LxControl.LxLedControl();
            this.ledFast3 = new LxControl.LxLedControl();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.ledFast1 = new LxControl.LxLedControl();
            this.txtFastMaxRssi = new System.Windows.Forms.TextBox();
            this.txtFastMinRssi = new System.Windows.Forms.TextBox();
            this.buttonFastFresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDStay = new System.Windows.Forms.TextBox();
            this.txtCStay = new System.Windows.Forms.TextBox();
            this.txtBStay = new System.Windows.Forms.TextBox();
            this.txtAStay = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.cmbAntSelect1 = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.cmbAntSelect2 = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.cmbAntSelect3 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.cmbAntSelect4 = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btFastInventory = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lvFastList = new System.Windows.Forms.ListView();
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label49 = new System.Windows.Forms.Label();
            this.txtFastTagList = new System.Windows.Forms.Label();
            this.pageAcessTag = new System.Windows.Forms.TabPage();
            this.ltvOperate = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbCmdOperateTag = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btnKillTag = new System.Windows.Forms.Button();
            this.htxtKillPwd = new CustomControl.HexTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.htxtLockPwd = new CustomControl.HexTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.rdbUserMemory = new System.Windows.Forms.RadioButton();
            this.rdbTidMemory = new System.Windows.Forms.RadioButton();
            this.rdbEpcMermory = new System.Windows.Forms.RadioButton();
            this.rdbKillPwd = new System.Windows.Forms.RadioButton();
            this.rdbAccessPwd = new System.Windows.Forms.RadioButton();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.rdbLockEver = new System.Windows.Forms.RadioButton();
            this.rdbFreeEver = new System.Windows.Forms.RadioButton();
            this.rdbLock = new System.Windows.Forms.RadioButton();
            this.rdbFree = new System.Windows.Forms.RadioButton();
            this.btnLockTag = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.htxtWriteData = new CustomControl.HexTextBox();
            this.txtWordCnt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnWriteTag = new System.Windows.Forms.Button();
            this.btnReadTag = new System.Windows.Forms.Button();
            this.txtWordAdd = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.htxtReadAndWritePwd = new CustomControl.HexTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.rdbTid = new System.Windows.Forms.RadioButton();
            this.rdbEpc = new System.Windows.Forms.RadioButton();
            this.rdbReserved = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSetAccessEpcMatch = new System.Windows.Forms.Button();
            this.cmbSetAccessEpcMatch = new System.Windows.Forms.ComboBox();
            this.txtAccessEpcMatch = new System.Windows.Forms.TextBox();
            this.ckAccessEpcMatch = new System.Windows.Forms.CheckBox();
            this.PagISO18000 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInventoryISO18000 = new System.Windows.Forms.Button();
            this.ltvTagISO18000 = new System.Windows.Forms.ListView();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbISO1800LockQuery = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.htxtQueryAdd = new CustomControl.HexTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.htxtLockAdd = new CustomControl.HexTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.btnQueryTagISO18000 = new System.Windows.Forms.Button();
            this.btnLockTagISO18000 = new System.Windows.Forms.Button();
            this.gbISO1800ReadWrite = new System.Windows.Forms.GroupBox();
            this.txtLoopTimes = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.htxtWriteData18000 = new CustomControl.HexTextBox();
            this.txtWriteLength = new System.Windows.Forms.TextBox();
            this.htxtReadData18000 = new CustomControl.HexTextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.btnWriteTagISO18000 = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtReadLength = new System.Windows.Forms.TextBox();
            this.htxtWriteStartAdd = new CustomControl.HexTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.htxtReadStartAdd = new CustomControl.HexTextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btnReadTagISO18000 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.htxtReadUID = new CustomControl.HexTextBox();
            this.PagTranDataLog = new System.Windows.Forms.TabPage();
            this.gbCmdManual = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.htxtSendData = new CustomControl.HexTextBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.htxtCheckData = new CustomControl.HexTextBox();
            this.lrtxtDataTran = new CustomControl.LogRichTextBox();
            this.Pc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rssi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarrFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.lxLedControl9 = new LxControl.LxLedControl();
            this.lxLedControl10 = new LxControl.LxLedControl();
            this.lxLedControl11 = new LxControl.LxLedControl();
            this.lxLedControl12 = new LxControl.LxLedControl();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.lxLedControl13 = new LxControl.LxLedControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.timerInventory = new System.Windows.Forms.Timer(this.components);
            this.lxLedControl14 = new LxControl.LxLedControl();
            this.lxLedControl15 = new LxControl.LxLedControl();
            this.lxLedControl16 = new LxControl.LxLedControl();
            this.lxLedControl17 = new LxControl.LxLedControl();
            this.lxLedControl18 = new LxControl.LxLedControl();
            this.dataGridViewTextBoxColumn233 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn234 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn235 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn236 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn237 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn228 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn229 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn230 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn231 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn232 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn223 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn224 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn225 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn226 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn227 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn218 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn219 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn220 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn221 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn222 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn238 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn239 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn240 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn241 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn242 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn243 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn244 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn245 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn246 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn247 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn248 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn249 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn250 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn251 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn252 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn101 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn102 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn103 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn104 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race13 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn107 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn108 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn109 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn115 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn116 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn117 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn118 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn121 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn122 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn124 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Race16 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn128 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn129 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn130 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn131 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn132 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Semi1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn135 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn136 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn137 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn138 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn139 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Semi2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn142 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn143 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn144 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn145 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn146 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_SFinal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn149 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn150 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn151 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn152 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn153 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel_Final = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCtrMain.SuspendLayout();
            this.PagReaderSetting.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCmdReadGpio.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbCmdBeeper.SuspendLayout();
            this.gbCmdTemperature.SuspendLayout();
            this.gbCmdVersion.SuspendLayout();
            this.gbCmdBaudrate.SuspendLayout();
            this.gbTcpIp.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbReturnLoss.SuspendLayout();
            this.gbProfile.SuspendLayout();
            this.gbMonza.SuspendLayout();
            this.gbCmdAntDetector.SuspendLayout();
            this.gbCmdDrm.SuspendLayout();
            this.gbCmdAntenna.SuspendLayout();
            this.gbCmdRegion.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.gbCmdOutputPower.SuspendLayout();
            this.pageEpcTest.SuspendLayout();
            this.tabEpcTest.SuspendLayout();
            this.tabTrack.SuspendLayout();
            this.groupBox26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPilotsPerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLapTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFirstLapTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQualRounds)).BeginInit();
            this.tabPilots.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPilots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePilots1)).BeginInit();
            this.tabRounds.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePilots)).BeginInit();
            this.tabPage23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace2)).BeginInit();
            this.tabPage24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace3)).BeginInit();
            this.tabPage25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace4)).BeginInit();
            this.tabPage26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace5)).BeginInit();
            this.tabPage27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace6)).BeginInit();
            this.tabPage28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace7)).BeginInit();
            this.tabPage29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace8)).BeginInit();
            this.groupBox30.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.pageGroupA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupA)).BeginInit();
            this.pageGroupB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupB)).BeginInit();
            this.pageGroupC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupC)).BeginInit();
            this.pageGroupD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupD)).BeginInit();
            this.pageGroupE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupE)).BeginInit();
            this.pageGroupF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupF)).BeginInit();
            this.pageGroupG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupG)).BeginInit();
            this.pageGroupH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupH)).BeginInit();
            this.pageGroupI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupI)).BeginInit();
            this.pageGroupJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupJ)).BeginInit();
            this.pageGroupK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupK)).BeginInit();
            this.pageGroupL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupL)).BeginInit();
            this.pageGroupM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupM)).BeginInit();
            this.pageGroupN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupN)).BeginInit();
            this.pageGroupO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupO)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupP)).BeginInit();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupQ)).BeginInit();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupR)).BeginInit();
            this.tabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupS)).BeginInit();
            this.tabPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupT)).BeginInit();
            this.tabPage16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupU)).BeginInit();
            this.tabPage17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupV)).BeginInit();
            this.tabPage18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupW)).BeginInit();
            this.tabPage19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupX)).BeginInit();
            this.tabPage20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupY)).BeginInit();
            this.tabPage21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupZ)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSmallFinal)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFinal)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace13)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace14)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace15)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace16)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSemi1)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSemi2)).BeginInit();
            this.tabRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRace)).BeginInit();
            this.groupBox35.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRanking)).BeginInit();
            this.groupBox31.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.gbMimicRace.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.pageRealMode.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal1)).BeginInit();
            this.pageBufferedMode.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer1)).BeginInit();
            this.pageFast4AntMode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pageAcessTag.SuspendLayout();
            this.gbCmdOperateTag.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.PagISO18000.SuspendLayout();
            this.gbISO1800LockQuery.SuspendLayout();
            this.gbISO1800ReadWrite.SuspendLayout();
            this.PagTranDataLog.SuspendLayout();
            this.gbCmdManual.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl18)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrMain
            // 
            this.tabCtrMain.Controls.Add(this.PagReaderSetting);
            this.tabCtrMain.Controls.Add(this.pageEpcTest);
            this.tabCtrMain.Controls.Add(this.PagISO18000);
            this.tabCtrMain.Controls.Add(this.PagTranDataLog);
            this.tabCtrMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabCtrMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrMain.Name = "tabCtrMain";
            this.tabCtrMain.SelectedIndex = 0;
            this.tabCtrMain.Size = new System.Drawing.Size(1349, 681);
            this.tabCtrMain.TabIndex = 0;
            this.tabCtrMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrMain_SelectedIndexChanged);
            this.tabCtrMain.Click += new System.EventHandler(this.tabCtrMain_Click);
            // 
            // PagReaderSetting
            // 
            this.PagReaderSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagReaderSetting.Controls.Add(this.tabControl1);
            this.PagReaderSetting.Location = new System.Drawing.Point(4, 22);
            this.PagReaderSetting.Name = "PagReaderSetting";
            this.PagReaderSetting.Padding = new System.Windows.Forms.Padding(3);
            this.PagReaderSetting.Size = new System.Drawing.Size(1341, 655);
            this.PagReaderSetting.TabIndex = 0;
            this.PagReaderSetting.Text = "Reader Setup";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1335, 649);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.ckClearOperationRec);
            this.tabPage1.Controls.Add(this.ckDisplayLog);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.lrtxtLog);
            this.tabPage1.Controls.Add(this.btReaderSetupRefresh);
            this.tabPage1.Controls.Add(this.gbCmdReadGpio);
            this.tabPage1.Controls.Add(this.gbCmdBeeper);
            this.tabPage1.Controls.Add(this.gbCmdTemperature);
            this.tabPage1.Controls.Add(this.gbCmdVersion);
            this.tabPage1.Controls.Add(this.btnResetReader);
            this.tabPage1.Controls.Add(this.gbCmdBaudrate);
            this.tabPage1.Controls.Add(this.gbTcpIp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1327, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Setup";
            // 
            // ckClearOperationRec
            // 
            this.ckClearOperationRec.AutoSize = true;
            this.ckClearOperationRec.Checked = true;
            this.ckClearOperationRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearOperationRec.Location = new System.Drawing.Point(152, 453);
            this.ckClearOperationRec.Name = "ckClearOperationRec";
            this.ckClearOperationRec.Size = new System.Drawing.Size(75, 17);
            this.ckClearOperationRec.TabIndex = 21;
            this.ckClearOperationRec.Text = "Auto Clear";
            this.ckClearOperationRec.UseVisualStyleBackColor = true;
            // 
            // ckDisplayLog
            // 
            this.ckDisplayLog.AutoSize = true;
            this.ckDisplayLog.ForeColor = System.Drawing.Color.Indigo;
            this.ckDisplayLog.Location = new System.Drawing.Point(817, 453);
            this.ckDisplayLog.Name = "ckDisplayLog";
            this.ckDisplayLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckDisplayLog.Size = new System.Drawing.Size(154, 17);
            this.ckDisplayLog.TabIndex = 20;
            this.ckDisplayLog.Text = "Activate Serial Port Monitor";
            this.ckDisplayLog.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(14, 453);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 13);
            this.label35.TabIndex = 19;
            this.label35.Text = "Operation History:";
            // 
            // lrtxtLog
            // 
            this.lrtxtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lrtxtLog.Location = new System.Drawing.Point(3, 476);
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.Size = new System.Drawing.Size(1321, 144);
            this.lrtxtLog.TabIndex = 18;
            this.lrtxtLog.Text = "";
            // 
            // btReaderSetupRefresh
            // 
            this.btReaderSetupRefresh.Location = new System.Drawing.Point(524, 388);
            this.btReaderSetupRefresh.Name = "btReaderSetupRefresh";
            this.btReaderSetupRefresh.Size = new System.Drawing.Size(375, 45);
            this.btReaderSetupRefresh.TabIndex = 15;
            this.btReaderSetupRefresh.Text = "Refresh";
            this.btReaderSetupRefresh.UseVisualStyleBackColor = true;
            this.btReaderSetupRefresh.Click += new System.EventHandler(this.btReaderSetupRefresh_Click);
            // 
            // gbCmdReadGpio
            // 
            this.gbCmdReadGpio.Controls.Add(this.groupBox11);
            this.gbCmdReadGpio.Controls.Add(this.groupBox10);
            this.gbCmdReadGpio.ForeColor = System.Drawing.Color.Black;
            this.gbCmdReadGpio.Location = new System.Drawing.Point(470, 129);
            this.gbCmdReadGpio.Name = "gbCmdReadGpio";
            this.gbCmdReadGpio.Size = new System.Drawing.Size(519, 253);
            this.gbCmdReadGpio.TabIndex = 12;
            this.gbCmdReadGpio.TabStop = false;
            this.gbCmdReadGpio.Text = "Read/Write GPIO";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Transparent;
            this.groupBox11.Controls.Add(this.groupBox6);
            this.groupBox11.Controls.Add(this.groupBox7);
            this.groupBox11.Controls.Add(this.btnWriteGpio4Value);
            this.groupBox11.Controls.Add(this.btnWriteGpio3Value);
            this.groupBox11.ForeColor = System.Drawing.Color.Black;
            this.groupBox11.Location = new System.Drawing.Point(16, 131);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(485, 106);
            this.groupBox11.TabIndex = 13;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Write GPIO";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.rdbGpio3High);
            this.groupBox6.Controls.Add(this.rdbGpio3Low);
            this.groupBox6.Location = new System.Drawing.Point(56, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 32);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(31, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "GPIO3:";
            // 
            // rdbGpio3High
            // 
            this.rdbGpio3High.AutoSize = true;
            this.rdbGpio3High.Location = new System.Drawing.Point(78, 11);
            this.rdbGpio3High.Name = "rdbGpio3High";
            this.rdbGpio3High.Size = new System.Drawing.Size(47, 17);
            this.rdbGpio3High.TabIndex = 6;
            this.rdbGpio3High.TabStop = true;
            this.rdbGpio3High.Text = "High";
            this.rdbGpio3High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio3Low
            // 
            this.rdbGpio3Low.AutoSize = true;
            this.rdbGpio3Low.Location = new System.Drawing.Point(161, 11);
            this.rdbGpio3Low.Name = "rdbGpio3Low";
            this.rdbGpio3Low.Size = new System.Drawing.Size(45, 17);
            this.rdbGpio3Low.TabIndex = 0;
            this.rdbGpio3Low.TabStop = true;
            this.rdbGpio3Low.Text = "Low";
            this.rdbGpio3Low.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.rdbGpio4High);
            this.groupBox7.Controls.Add(this.rdbGpio4Low);
            this.groupBox7.Location = new System.Drawing.Point(56, 58);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(245, 32);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(30, 13);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "GPIO4:";
            // 
            // rdbGpio4High
            // 
            this.rdbGpio4High.AutoSize = true;
            this.rdbGpio4High.Location = new System.Drawing.Point(77, 11);
            this.rdbGpio4High.Name = "rdbGpio4High";
            this.rdbGpio4High.Size = new System.Drawing.Size(47, 17);
            this.rdbGpio4High.TabIndex = 1;
            this.rdbGpio4High.TabStop = true;
            this.rdbGpio4High.Text = "High";
            this.rdbGpio4High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio4Low
            // 
            this.rdbGpio4Low.AutoSize = true;
            this.rdbGpio4Low.Location = new System.Drawing.Point(161, 11);
            this.rdbGpio4Low.Name = "rdbGpio4Low";
            this.rdbGpio4Low.Size = new System.Drawing.Size(45, 17);
            this.rdbGpio4Low.TabIndex = 2;
            this.rdbGpio4Low.TabStop = true;
            this.rdbGpio4Low.Text = "Low";
            this.rdbGpio4Low.UseVisualStyleBackColor = true;
            // 
            // btnWriteGpio4Value
            // 
            this.btnWriteGpio4Value.Location = new System.Drawing.Point(378, 66);
            this.btnWriteGpio4Value.Name = "btnWriteGpio4Value";
            this.btnWriteGpio4Value.Size = new System.Drawing.Size(90, 25);
            this.btnWriteGpio4Value.TabIndex = 5;
            this.btnWriteGpio4Value.Text = "Write GPIO4";
            this.btnWriteGpio4Value.UseVisualStyleBackColor = true;
            this.btnWriteGpio4Value.Click += new System.EventHandler(this.btnWriteGpio4Value_Click);
            // 
            // btnWriteGpio3Value
            // 
            this.btnWriteGpio3Value.Location = new System.Drawing.Point(378, 26);
            this.btnWriteGpio3Value.Name = "btnWriteGpio3Value";
            this.btnWriteGpio3Value.Size = new System.Drawing.Size(90, 25);
            this.btnWriteGpio3Value.TabIndex = 10;
            this.btnWriteGpio3Value.Text = "Write GPIO3";
            this.btnWriteGpio3Value.UseVisualStyleBackColor = true;
            this.btnWriteGpio3Value.Click += new System.EventHandler(this.btnWriteGpio3Value_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox4);
            this.groupBox10.Controls.Add(this.groupBox5);
            this.groupBox10.Controls.Add(this.btnReadGpioValue);
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            this.groupBox10.Location = new System.Drawing.Point(17, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(485, 106);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Read GPIO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.rdbGpio1High);
            this.groupBox4.Controls.Add(this.rdbGpio1Low);
            this.groupBox4.Location = new System.Drawing.Point(53, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 32);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "GPIO1:";
            // 
            // rdbGpio1High
            // 
            this.rdbGpio1High.AutoSize = true;
            this.rdbGpio1High.Location = new System.Drawing.Point(78, 13);
            this.rdbGpio1High.Name = "rdbGpio1High";
            this.rdbGpio1High.Size = new System.Drawing.Size(47, 17);
            this.rdbGpio1High.TabIndex = 1;
            this.rdbGpio1High.TabStop = true;
            this.rdbGpio1High.Text = "High";
            this.rdbGpio1High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio1Low
            // 
            this.rdbGpio1Low.AutoSize = true;
            this.rdbGpio1Low.Location = new System.Drawing.Point(163, 13);
            this.rdbGpio1Low.Name = "rdbGpio1Low";
            this.rdbGpio1Low.Size = new System.Drawing.Size(45, 17);
            this.rdbGpio1Low.TabIndex = 2;
            this.rdbGpio1Low.TabStop = true;
            this.rdbGpio1Low.Text = "Low";
            this.rdbGpio1Low.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.rdbGpio2High);
            this.groupBox5.Controls.Add(this.rdbGpio2Low);
            this.groupBox5.Location = new System.Drawing.Point(53, 59);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(247, 32);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(30, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 13);
            this.label31.TabIndex = 3;
            this.label31.Text = "GPIO2:";
            // 
            // rdbGpio2High
            // 
            this.rdbGpio2High.AutoSize = true;
            this.rdbGpio2High.Location = new System.Drawing.Point(77, 13);
            this.rdbGpio2High.Name = "rdbGpio2High";
            this.rdbGpio2High.Size = new System.Drawing.Size(47, 17);
            this.rdbGpio2High.TabIndex = 4;
            this.rdbGpio2High.TabStop = true;
            this.rdbGpio2High.Text = "High";
            this.rdbGpio2High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio2Low
            // 
            this.rdbGpio2Low.AutoSize = true;
            this.rdbGpio2Low.Location = new System.Drawing.Point(163, 13);
            this.rdbGpio2Low.Name = "rdbGpio2Low";
            this.rdbGpio2Low.Size = new System.Drawing.Size(45, 17);
            this.rdbGpio2Low.TabIndex = 5;
            this.rdbGpio2Low.TabStop = true;
            this.rdbGpio2Low.Text = "Low";
            this.rdbGpio2Low.UseVisualStyleBackColor = true;
            // 
            // btnReadGpioValue
            // 
            this.btnReadGpioValue.Location = new System.Drawing.Point(377, 67);
            this.btnReadGpioValue.Name = "btnReadGpioValue";
            this.btnReadGpioValue.Size = new System.Drawing.Size(90, 25);
            this.btnReadGpioValue.TabIndex = 0;
            this.btnReadGpioValue.Text = "Read";
            this.btnReadGpioValue.UseVisualStyleBackColor = true;
            this.btnReadGpioValue.Click += new System.EventHandler(this.btnReadGpioValue_Click);
            // 
            // gbCmdBeeper
            // 
            this.gbCmdBeeper.Controls.Add(this.btnSetBeeperMode);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeTag);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeInventory);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeSlient);
            this.gbCmdBeeper.ForeColor = System.Drawing.Color.Black;
            this.gbCmdBeeper.Location = new System.Drawing.Point(15, 241);
            this.gbCmdBeeper.Name = "gbCmdBeeper";
            this.gbCmdBeeper.Size = new System.Drawing.Size(440, 104);
            this.gbCmdBeeper.TabIndex = 11;
            this.gbCmdBeeper.TabStop = false;
            this.gbCmdBeeper.Text = "Buzzer Behavior";
            // 
            // btnSetBeeperMode
            // 
            this.btnSetBeeperMode.Location = new System.Drawing.Point(316, 45);
            this.btnSetBeeperMode.Name = "btnSetBeeperMode";
            this.btnSetBeeperMode.Size = new System.Drawing.Size(90, 25);
            this.btnSetBeeperMode.TabIndex = 3;
            this.btnSetBeeperMode.Text = "Set";
            this.btnSetBeeperMode.UseVisualStyleBackColor = true;
            this.btnSetBeeperMode.Click += new System.EventHandler(this.btnSetBeeperMode_Click);
            // 
            // rdbBeeperModeTag
            // 
            this.rdbBeeperModeTag.AutoSize = true;
            this.rdbBeeperModeTag.Location = new System.Drawing.Point(71, 74);
            this.rdbBeeperModeTag.Name = "rdbBeeperModeTag";
            this.rdbBeeperModeTag.Size = new System.Drawing.Size(222, 17);
            this.rdbBeeperModeTag.TabIndex = 2;
            this.rdbBeeperModeTag.TabStop = true;
            this.rdbBeeperModeTag.Text = "Beep after a tag is identified.(For test only)";
            this.rdbBeeperModeTag.UseVisualStyleBackColor = true;
            // 
            // rdbBeeperModeInventory
            // 
            this.rdbBeeperModeInventory.AutoSize = true;
            this.rdbBeeperModeInventory.Location = new System.Drawing.Point(71, 48);
            this.rdbBeeperModeInventory.Name = "rdbBeeperModeInventory";
            this.rdbBeeperModeInventory.Size = new System.Drawing.Size(165, 17);
            this.rdbBeeperModeInventory.TabIndex = 1;
            this.rdbBeeperModeInventory.TabStop = true;
            this.rdbBeeperModeInventory.Text = "Beep after an inventory round";
            this.rdbBeeperModeInventory.UseVisualStyleBackColor = true;
            // 
            // rdbBeeperModeSlient
            // 
            this.rdbBeeperModeSlient.AutoSize = true;
            this.rdbBeeperModeSlient.Location = new System.Drawing.Point(71, 22);
            this.rdbBeeperModeSlient.Name = "rdbBeeperModeSlient";
            this.rdbBeeperModeSlient.Size = new System.Drawing.Size(50, 17);
            this.rdbBeeperModeSlient.TabIndex = 0;
            this.rdbBeeperModeSlient.TabStop = true;
            this.rdbBeeperModeSlient.Text = "Quiet";
            this.rdbBeeperModeSlient.UseVisualStyleBackColor = true;
            // 
            // gbCmdTemperature
            // 
            this.gbCmdTemperature.Controls.Add(this.btnGetReaderTemperature);
            this.gbCmdTemperature.Controls.Add(this.txtReaderTemperature);
            this.gbCmdTemperature.ForeColor = System.Drawing.Color.Black;
            this.gbCmdTemperature.Location = new System.Drawing.Point(470, 70);
            this.gbCmdTemperature.Name = "gbCmdTemperature";
            this.gbCmdTemperature.Size = new System.Drawing.Size(519, 53);
            this.gbCmdTemperature.TabIndex = 10;
            this.gbCmdTemperature.TabStop = false;
            this.gbCmdTemperature.Text = "Internal Temperature";
            // 
            // btnGetReaderTemperature
            // 
            this.btnGetReaderTemperature.Location = new System.Drawing.Point(393, 19);
            this.btnGetReaderTemperature.Name = "btnGetReaderTemperature";
            this.btnGetReaderTemperature.Size = new System.Drawing.Size(90, 25);
            this.btnGetReaderTemperature.TabIndex = 0;
            this.btnGetReaderTemperature.Text = "Get";
            this.btnGetReaderTemperature.UseVisualStyleBackColor = true;
            this.btnGetReaderTemperature.Click += new System.EventHandler(this.btnGetReaderTemperature_Click);
            // 
            // txtReaderTemperature
            // 
            this.txtReaderTemperature.Location = new System.Drawing.Point(106, 19);
            this.txtReaderTemperature.Name = "txtReaderTemperature";
            this.txtReaderTemperature.ReadOnly = true;
            this.txtReaderTemperature.Size = new System.Drawing.Size(120, 20);
            this.txtReaderTemperature.TabIndex = 1;
            this.txtReaderTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbCmdVersion
            // 
            this.gbCmdVersion.Controls.Add(this.btnGetFirmwareVersion);
            this.gbCmdVersion.Controls.Add(this.txtFirmwareVersion);
            this.gbCmdVersion.ForeColor = System.Drawing.Color.Black;
            this.gbCmdVersion.Location = new System.Drawing.Point(470, 14);
            this.gbCmdVersion.Name = "gbCmdVersion";
            this.gbCmdVersion.Size = new System.Drawing.Size(519, 48);
            this.gbCmdVersion.TabIndex = 9;
            this.gbCmdVersion.TabStop = false;
            this.gbCmdVersion.Text = "Firmware Version";
            // 
            // btnGetFirmwareVersion
            // 
            this.btnGetFirmwareVersion.Location = new System.Drawing.Point(394, 15);
            this.btnGetFirmwareVersion.Name = "btnGetFirmwareVersion";
            this.btnGetFirmwareVersion.Size = new System.Drawing.Size(90, 25);
            this.btnGetFirmwareVersion.TabIndex = 0;
            this.btnGetFirmwareVersion.Text = "Get";
            this.btnGetFirmwareVersion.UseVisualStyleBackColor = true;
            this.btnGetFirmwareVersion.Click += new System.EventHandler(this.btnGetFirmwareVersion_Click);
            // 
            // txtFirmwareVersion
            // 
            this.txtFirmwareVersion.Location = new System.Drawing.Point(105, 17);
            this.txtFirmwareVersion.Name = "txtFirmwareVersion";
            this.txtFirmwareVersion.ReadOnly = true;
            this.txtFirmwareVersion.Size = new System.Drawing.Size(121, 20);
            this.txtFirmwareVersion.TabIndex = 1;
            this.txtFirmwareVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResetReader
            // 
            this.btnResetReader.Location = new System.Drawing.Point(41, 388);
            this.btnResetReader.Name = "btnResetReader";
            this.btnResetReader.Size = new System.Drawing.Size(375, 45);
            this.btnResetReader.TabIndex = 8;
            this.btnResetReader.Text = "Reset Reader";
            this.btnResetReader.UseVisualStyleBackColor = true;
            this.btnResetReader.Click += new System.EventHandler(this.btnResetReader_Click);
            // 
            // gbCmdBaudrate
            // 
            this.gbCmdBaudrate.Controls.Add(this.htbGetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.htbSetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.btSetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.btGetIdentifier);
            this.gbCmdBaudrate.ForeColor = System.Drawing.Color.Black;
            this.gbCmdBaudrate.Location = new System.Drawing.Point(17, 126);
            this.gbCmdBaudrate.Name = "gbCmdBaudrate";
            this.gbCmdBaudrate.Size = new System.Drawing.Size(434, 104);
            this.gbCmdBaudrate.TabIndex = 7;
            this.gbCmdBaudrate.TabStop = false;
            this.gbCmdBaudrate.Text = "Reader Identifier(12 Bytes)";
            // 
            // htbGetIdentifier
            // 
            this.htbGetIdentifier.Location = new System.Drawing.Point(34, 24);
            this.htbGetIdentifier.Name = "htbGetIdentifier";
            this.htbGetIdentifier.ReadOnly = true;
            this.htbGetIdentifier.Size = new System.Drawing.Size(228, 20);
            this.htbGetIdentifier.TabIndex = 13;
            this.htbGetIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htbSetIdentifier
            // 
            this.htbSetIdentifier.Location = new System.Drawing.Point(34, 66);
            this.htbSetIdentifier.Name = "htbSetIdentifier";
            this.htbSetIdentifier.Size = new System.Drawing.Size(228, 20);
            this.htbSetIdentifier.TabIndex = 12;
            this.htbSetIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSetIdentifier
            // 
            this.btSetIdentifier.Location = new System.Drawing.Point(314, 65);
            this.btSetIdentifier.Name = "btSetIdentifier";
            this.btSetIdentifier.Size = new System.Drawing.Size(90, 25);
            this.btSetIdentifier.TabIndex = 1;
            this.btSetIdentifier.Text = "Set";
            this.btSetIdentifier.UseVisualStyleBackColor = true;
            this.btSetIdentifier.Click += new System.EventHandler(this.btSetIdentifier_Click);
            // 
            // btGetIdentifier
            // 
            this.btGetIdentifier.Location = new System.Drawing.Point(314, 23);
            this.btGetIdentifier.Name = "btGetIdentifier";
            this.btGetIdentifier.Size = new System.Drawing.Size(90, 25);
            this.btGetIdentifier.TabIndex = 0;
            this.btGetIdentifier.Text = "Get";
            this.btGetIdentifier.UseVisualStyleBackColor = true;
            this.btGetIdentifier.Click += new System.EventHandler(this.btGetIdentifier_Click);
            // 
            // gbTcpIp
            // 
            this.gbTcpIp.Controls.Add(this.btnDisconnectTcp);
            this.gbTcpIp.Controls.Add(this.txtTcpPort);
            this.gbTcpIp.Controls.Add(this.btnConnectTcp);
            this.gbTcpIp.Controls.Add(this.ipIpServer);
            this.gbTcpIp.Controls.Add(this.label4);
            this.gbTcpIp.Controls.Add(this.label3);
            this.gbTcpIp.Location = new System.Drawing.Point(17, 23);
            this.gbTcpIp.Name = "gbTcpIp";
            this.gbTcpIp.Size = new System.Drawing.Size(434, 91);
            this.gbTcpIp.TabIndex = 3;
            this.gbTcpIp.TabStop = false;
            this.gbTcpIp.Text = "TCP/IP";
            // 
            // btnDisconnectTcp
            // 
            this.btnDisconnectTcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectTcp.Location = new System.Drawing.Point(314, 55);
            this.btnDisconnectTcp.Name = "btnDisconnectTcp";
            this.btnDisconnectTcp.Size = new System.Drawing.Size(90, 25);
            this.btnDisconnectTcp.TabIndex = 3;
            this.btnDisconnectTcp.Text = "Disconnect";
            this.btnDisconnectTcp.UseVisualStyleBackColor = true;
            this.btnDisconnectTcp.Click += new System.EventHandler(this.btnDisconnectTcp_Click);
            // 
            // txtTcpPort
            // 
            this.txtTcpPort.Location = new System.Drawing.Point(114, 56);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(120, 20);
            this.txtTcpPort.TabIndex = 1;
            this.txtTcpPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnectTcp
            // 
            this.btnConnectTcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectTcp.Location = new System.Drawing.Point(314, 20);
            this.btnConnectTcp.Name = "btnConnectTcp";
            this.btnConnectTcp.Size = new System.Drawing.Size(90, 25);
            this.btnConnectTcp.TabIndex = 2;
            this.btnConnectTcp.Text = "Connect";
            this.btnConnectTcp.UseVisualStyleBackColor = true;
            this.btnConnectTcp.Click += new System.EventHandler(this.btnConnectTcp_Click);
            // 
            // ipIpServer
            // 
            this.ipIpServer.IpAddressStr = "";
            this.ipIpServer.Location = new System.Drawing.Point(114, 22);
            this.ipIpServer.Margin = new System.Windows.Forms.Padding(4);
            this.ipIpServer.Name = "ipIpServer";
            this.ipIpServer.Size = new System.Drawing.Size(120, 23);
            this.ipIpServer.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reader IP Add:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.gbReturnLoss);
            this.tabPage2.Controls.Add(this.gbProfile);
            this.tabPage2.Controls.Add(this.btRfSetup);
            this.tabPage2.Controls.Add(this.gbMonza);
            this.tabPage2.Controls.Add(this.gbCmdAntDetector);
            this.tabPage2.Controls.Add(this.gbCmdDrm);
            this.tabPage2.Controls.Add(this.gbCmdAntenna);
            this.tabPage2.Controls.Add(this.gbCmdRegion);
            this.tabPage2.Controls.Add(this.gbCmdOutputPower);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1327, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RF Setup";
            // 
            // gbReturnLoss
            // 
            this.gbReturnLoss.BackColor = System.Drawing.Color.Transparent;
            this.gbReturnLoss.Controls.Add(this.label110);
            this.gbReturnLoss.Controls.Add(this.label109);
            this.gbReturnLoss.Controls.Add(this.cmbReturnLossFreq);
            this.gbReturnLoss.Controls.Add(this.label108);
            this.gbReturnLoss.Controls.Add(this.textReturnLoss);
            this.gbReturnLoss.Controls.Add(this.btReturnLoss);
            this.gbReturnLoss.ForeColor = System.Drawing.Color.Black;
            this.gbReturnLoss.Location = new System.Drawing.Point(505, 72);
            this.gbReturnLoss.Name = "gbReturnLoss";
            this.gbReturnLoss.Size = new System.Drawing.Size(477, 50);
            this.gbReturnLoss.TabIndex = 19;
            this.gbReturnLoss.TabStop = false;
            this.gbReturnLoss.Text = "Measure RF Port Return Loss";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(156, 24);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(18, 13);
            this.label110.TabIndex = 15;
            this.label110.Text = "@";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(250, 24);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(29, 13);
            this.label109.TabIndex = 14;
            this.label109.Text = "MHz";
            // 
            // cmbReturnLossFreq
            // 
            this.cmbReturnLossFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnLossFreq.FormattingEnabled = true;
            this.cmbReturnLossFreq.Items.AddRange(new object[] {
            "865.00",
            "865.50",
            "866.00",
            "866.50",
            "867.00",
            "867.50",
            "868.00",
            "902.00",
            "902.50",
            "903.00",
            "903.50",
            "904.00",
            "904.50",
            "905.00",
            "905.50",
            "906.00",
            "906.50",
            "907.00",
            "907.50",
            "908.00",
            "908.50",
            "909.00",
            "909.50",
            "910.00",
            "910.50",
            "911.00",
            "911.50",
            "912.00",
            "912.50",
            "913.00",
            "913.50",
            "914.00",
            "914.50",
            "915.00",
            "915.50",
            "916.00",
            "916.50",
            "917.00",
            "917.50",
            "918.00",
            "918.50",
            "919.00",
            "919.50",
            "920.00",
            "920.50",
            "921.00",
            "921.50",
            "922.00",
            "922.50",
            "923.00",
            "923.50",
            "924.00",
            "924.50",
            "925.00",
            "925.50",
            "926.00",
            "926.50",
            "927.00",
            "927.50",
            "928.00"});
            this.cmbReturnLossFreq.Location = new System.Drawing.Point(173, 20);
            this.cmbReturnLossFreq.Name = "cmbReturnLossFreq";
            this.cmbReturnLossFreq.Size = new System.Drawing.Size(71, 21);
            this.cmbReturnLossFreq.TabIndex = 13;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(50, 24);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(24, 13);
            this.label108.TabIndex = 12;
            this.label108.Text = "RL:";
            // 
            // textReturnLoss
            // 
            this.textReturnLoss.Location = new System.Drawing.Point(79, 20);
            this.textReturnLoss.Name = "textReturnLoss";
            this.textReturnLoss.ReadOnly = true;
            this.textReturnLoss.Size = new System.Drawing.Size(71, 20);
            this.textReturnLoss.TabIndex = 11;
            this.textReturnLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btReturnLoss
            // 
            this.btReturnLoss.Location = new System.Drawing.Point(369, 19);
            this.btReturnLoss.Name = "btReturnLoss";
            this.btReturnLoss.Size = new System.Drawing.Size(90, 25);
            this.btReturnLoss.TabIndex = 10;
            this.btReturnLoss.Text = "Measure";
            this.btReturnLoss.UseVisualStyleBackColor = true;
            this.btReturnLoss.Click += new System.EventHandler(this.btReturnLoss_Click);
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.btGetProfile);
            this.gbProfile.Controls.Add(this.btSetProfile);
            this.gbProfile.Controls.Add(this.rdbProfile3);
            this.gbProfile.Controls.Add(this.rdbProfile2);
            this.gbProfile.Controls.Add(this.rdbProfile1);
            this.gbProfile.Controls.Add(this.rdbProfile0);
            this.gbProfile.ForeColor = System.Drawing.Color.Black;
            this.gbProfile.Location = new System.Drawing.Point(1001, 14);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(320, 192);
            this.gbProfile.TabIndex = 18;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "RF Link Setup";
            // 
            // btGetProfile
            // 
            this.btGetProfile.Location = new System.Drawing.Point(734, 32);
            this.btGetProfile.Name = "btGetProfile";
            this.btGetProfile.Size = new System.Drawing.Size(90, 25);
            this.btGetProfile.TabIndex = 9;
            this.btGetProfile.Text = "Get";
            this.btGetProfile.UseVisualStyleBackColor = true;
            this.btGetProfile.Click += new System.EventHandler(this.btGetProfile_Click);
            // 
            // btSetProfile
            // 
            this.btSetProfile.Location = new System.Drawing.Point(859, 32);
            this.btSetProfile.Name = "btSetProfile";
            this.btSetProfile.Size = new System.Drawing.Size(90, 25);
            this.btSetProfile.TabIndex = 8;
            this.btSetProfile.Text = "Set";
            this.btSetProfile.UseVisualStyleBackColor = true;
            this.btSetProfile.Click += new System.EventHandler(this.btSetProfile_Click);
            // 
            // rdbProfile3
            // 
            this.rdbProfile3.AutoSize = true;
            this.rdbProfile3.Location = new System.Drawing.Point(14, 114);
            this.rdbProfile3.Name = "rdbProfile3";
            this.rdbProfile3.Size = new System.Drawing.Size(195, 17);
            this.rdbProfile3.TabIndex = 3;
            this.rdbProfile3.TabStop = true;
            this.rdbProfile3.Text = "Profile 3  Tari 6.25uS; FM0 400KHz;";
            this.rdbProfile3.UseVisualStyleBackColor = true;
            // 
            // rdbProfile2
            // 
            this.rdbProfile2.AutoSize = true;
            this.rdbProfile2.Location = new System.Drawing.Point(14, 82);
            this.rdbProfile2.Name = "rdbProfile2";
            this.rdbProfile2.Size = new System.Drawing.Size(198, 17);
            this.rdbProfile2.TabIndex = 2;
            this.rdbProfile2.TabStop = true;
            this.rdbProfile2.Text = "Profile 2  Tari 25uS; Miller 4 300KHz;";
            this.rdbProfile2.UseVisualStyleBackColor = true;
            // 
            // rdbProfile1
            // 
            this.rdbProfile1.AutoSize = true;
            this.rdbProfile1.ForeColor = System.Drawing.Color.Black;
            this.rdbProfile1.Location = new System.Drawing.Point(14, 45);
            this.rdbProfile1.Name = "rdbProfile1";
            this.rdbProfile1.Size = new System.Drawing.Size(205, 30);
            this.rdbProfile1.TabIndex = 1;
            this.rdbProfile1.TabStop = true;
            this.rdbProfile1.Text = "Profile 1(Recommended and Default)  \r\nTari 25uS; Miller 4 250KHz";
            this.rdbProfile1.UseVisualStyleBackColor = true;
            // 
            // rdbProfile0
            // 
            this.rdbProfile0.AutoSize = true;
            this.rdbProfile0.Location = new System.Drawing.Point(14, 22);
            this.rdbProfile0.Name = "rdbProfile0";
            this.rdbProfile0.Size = new System.Drawing.Size(177, 17);
            this.rdbProfile0.TabIndex = 0;
            this.rdbProfile0.TabStop = true;
            this.rdbProfile0.Text = "Profile 0  Tari 25uS; FM0 40KHz";
            this.rdbProfile0.UseVisualStyleBackColor = true;
            // 
            // btRfSetup
            // 
            this.btRfSetup.Location = new System.Drawing.Point(988, 394);
            this.btRfSetup.Name = "btRfSetup";
            this.btRfSetup.Size = new System.Drawing.Size(333, 45);
            this.btRfSetup.TabIndex = 17;
            this.btRfSetup.Text = "Refresh";
            this.btRfSetup.UseVisualStyleBackColor = true;
            this.btRfSetup.Click += new System.EventHandler(this.btRfSetup_Click);
            // 
            // gbMonza
            // 
            this.gbMonza.Controls.Add(this.label14);
            this.gbMonza.Controls.Add(this.label11);
            this.gbMonza.Controls.Add(this.rdbMonzaOff);
            this.gbMonza.Controls.Add(this.btSetMonzaStatus);
            this.gbMonza.Controls.Add(this.btGetMonzaStatus);
            this.gbMonza.Controls.Add(this.rdbMonzaOn);
            this.gbMonza.ForeColor = System.Drawing.Color.Black;
            this.gbMonza.Location = new System.Drawing.Point(15, 212);
            this.gbMonza.Name = "gbMonza";
            this.gbMonza.Size = new System.Drawing.Size(967, 67);
            this.gbMonza.TabIndex = 15;
            this.gbMonza.TabStop = false;
            this.gbMonza.Text = "Impinj Monza FastTID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Location = new System.Drawing.Point(48, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(284, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "2.If this function is not supported by tags, please turn it off. ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(12, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(375, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Note: 1.Only a certain number of  Impinj Monza tag types support this function.";
            // 
            // rdbMonzaOff
            // 
            this.rdbMonzaOff.AutoSize = true;
            this.rdbMonzaOff.Location = new System.Drawing.Point(622, 33);
            this.rdbMonzaOff.Name = "rdbMonzaOff";
            this.rdbMonzaOff.Size = new System.Drawing.Size(39, 17);
            this.rdbMonzaOff.TabIndex = 3;
            this.rdbMonzaOff.TabStop = true;
            this.rdbMonzaOff.Text = "Off";
            this.rdbMonzaOff.UseVisualStyleBackColor = true;
            // 
            // btSetMonzaStatus
            // 
            this.btSetMonzaStatus.Location = new System.Drawing.Point(859, 26);
            this.btSetMonzaStatus.Name = "btSetMonzaStatus";
            this.btSetMonzaStatus.Size = new System.Drawing.Size(90, 25);
            this.btSetMonzaStatus.TabIndex = 2;
            this.btSetMonzaStatus.Text = "Set";
            this.btSetMonzaStatus.UseVisualStyleBackColor = true;
            this.btSetMonzaStatus.Click += new System.EventHandler(this.btSetMonzaStatus_Click);
            // 
            // btGetMonzaStatus
            // 
            this.btGetMonzaStatus.Location = new System.Drawing.Point(734, 26);
            this.btGetMonzaStatus.Name = "btGetMonzaStatus";
            this.btGetMonzaStatus.Size = new System.Drawing.Size(90, 25);
            this.btGetMonzaStatus.TabIndex = 1;
            this.btGetMonzaStatus.Text = "Get";
            this.btGetMonzaStatus.UseVisualStyleBackColor = true;
            this.btGetMonzaStatus.Click += new System.EventHandler(this.btGetMonzaStatus_Click);
            // 
            // rdbMonzaOn
            // 
            this.rdbMonzaOn.AutoSize = true;
            this.rdbMonzaOn.Location = new System.Drawing.Point(521, 33);
            this.rdbMonzaOn.Name = "rdbMonzaOn";
            this.rdbMonzaOn.Size = new System.Drawing.Size(39, 17);
            this.rdbMonzaOn.TabIndex = 0;
            this.rdbMonzaOn.TabStop = true;
            this.rdbMonzaOn.Text = "On";
            this.rdbMonzaOn.UseVisualStyleBackColor = true;
            // 
            // gbCmdAntDetector
            // 
            this.gbCmdAntDetector.Controls.Add(this.label7);
            this.gbCmdAntDetector.Controls.Add(this.label6);
            this.gbCmdAntDetector.Controls.Add(this.label5);
            this.gbCmdAntDetector.Controls.Add(this.label10);
            this.gbCmdAntDetector.Controls.Add(this.label8);
            this.gbCmdAntDetector.Controls.Add(this.tbAntDectector);
            this.gbCmdAntDetector.Controls.Add(this.btnGetAntDetector);
            this.gbCmdAntDetector.Controls.Add(this.btnSetAntDetector);
            this.gbCmdAntDetector.ForeColor = System.Drawing.Color.Black;
            this.gbCmdAntDetector.Location = new System.Drawing.Point(15, 128);
            this.gbCmdAntDetector.Name = "gbCmdAntDetector";
            this.gbCmdAntDetector.Size = new System.Drawing.Size(967, 78);
            this.gbCmdAntDetector.TabIndex = 13;
            this.gbCmdAntDetector.TabStop = false;
            this.gbCmdAntDetector.Text = "Antenna Connection Detector";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(48, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "2.Reader stops tag operation if return loss is above the threshold.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(48, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "3.User can turn it off by setting the threshold to 0.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(413, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Note: 1.Reader detects antenna connections by measuring the return loss of RF por" +
    "ts.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "RL Threshold:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "dB";
            // 
            // tbAntDectector
            // 
            this.tbAntDectector.Location = new System.Drawing.Point(569, 35);
            this.tbAntDectector.Name = "tbAntDectector";
            this.tbAntDectector.Size = new System.Drawing.Size(71, 20);
            this.tbAntDectector.TabIndex = 4;
            this.tbAntDectector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetAntDetector
            // 
            this.btnGetAntDetector.Location = new System.Drawing.Point(734, 33);
            this.btnGetAntDetector.Name = "btnGetAntDetector";
            this.btnGetAntDetector.Size = new System.Drawing.Size(90, 25);
            this.btnGetAntDetector.TabIndex = 3;
            this.btnGetAntDetector.Text = "Get";
            this.btnGetAntDetector.UseVisualStyleBackColor = true;
            this.btnGetAntDetector.Click += new System.EventHandler(this.btnGetAntDetector_Click);
            // 
            // btnSetAntDetector
            // 
            this.btnSetAntDetector.Location = new System.Drawing.Point(859, 33);
            this.btnSetAntDetector.Name = "btnSetAntDetector";
            this.btnSetAntDetector.Size = new System.Drawing.Size(90, 25);
            this.btnSetAntDetector.TabIndex = 2;
            this.btnSetAntDetector.Text = "Set";
            this.btnSetAntDetector.UseVisualStyleBackColor = true;
            this.btnSetAntDetector.Click += new System.EventHandler(this.btnSetAntDetector_Click);
            // 
            // gbCmdDrm
            // 
            this.gbCmdDrm.Controls.Add(this.btnGetDrmMode);
            this.gbCmdDrm.Controls.Add(this.btnSetDrmMode);
            this.gbCmdDrm.Controls.Add(this.rdbDrmModeClose);
            this.gbCmdDrm.Controls.Add(this.rdbDrmModeOpen);
            this.gbCmdDrm.ForeColor = System.Drawing.Color.Black;
            this.gbCmdDrm.Location = new System.Drawing.Point(15, 9);
            this.gbCmdDrm.Name = "gbCmdDrm";
            this.gbCmdDrm.Size = new System.Drawing.Size(472, 53);
            this.gbCmdDrm.TabIndex = 10;
            this.gbCmdDrm.TabStop = false;
            this.gbCmdDrm.Text = "DRM Status";
            // 
            // btnGetDrmMode
            // 
            this.btnGetDrmMode.Location = new System.Drawing.Point(235, 17);
            this.btnGetDrmMode.Name = "btnGetDrmMode";
            this.btnGetDrmMode.Size = new System.Drawing.Size(90, 25);
            this.btnGetDrmMode.TabIndex = 3;
            this.btnGetDrmMode.Text = "Get";
            this.btnGetDrmMode.UseVisualStyleBackColor = true;
            this.btnGetDrmMode.Click += new System.EventHandler(this.btnGetDrmMode_Click);
            // 
            // btnSetDrmMode
            // 
            this.btnSetDrmMode.Location = new System.Drawing.Point(344, 17);
            this.btnSetDrmMode.Name = "btnSetDrmMode";
            this.btnSetDrmMode.Size = new System.Drawing.Size(90, 25);
            this.btnSetDrmMode.TabIndex = 2;
            this.btnSetDrmMode.Text = "Set";
            this.btnSetDrmMode.UseVisualStyleBackColor = true;
            this.btnSetDrmMode.Click += new System.EventHandler(this.btnSetDrmMode_Click);
            // 
            // rdbDrmModeClose
            // 
            this.rdbDrmModeClose.AutoSize = true;
            this.rdbDrmModeClose.Location = new System.Drawing.Point(149, 20);
            this.rdbDrmModeClose.Name = "rdbDrmModeClose";
            this.rdbDrmModeClose.Size = new System.Drawing.Size(39, 17);
            this.rdbDrmModeClose.TabIndex = 1;
            this.rdbDrmModeClose.TabStop = true;
            this.rdbDrmModeClose.Text = "Off";
            this.rdbDrmModeClose.UseVisualStyleBackColor = true;
            // 
            // rdbDrmModeOpen
            // 
            this.rdbDrmModeOpen.AutoSize = true;
            this.rdbDrmModeOpen.Location = new System.Drawing.Point(38, 20);
            this.rdbDrmModeOpen.Name = "rdbDrmModeOpen";
            this.rdbDrmModeOpen.Size = new System.Drawing.Size(39, 17);
            this.rdbDrmModeOpen.TabIndex = 0;
            this.rdbDrmModeOpen.TabStop = true;
            this.rdbDrmModeOpen.Text = "On";
            this.rdbDrmModeOpen.UseVisualStyleBackColor = true;
            // 
            // gbCmdAntenna
            // 
            this.gbCmdAntenna.Controls.Add(this.label107);
            this.gbCmdAntenna.Controls.Add(this.cmbWorkAnt);
            this.gbCmdAntenna.Controls.Add(this.btnGetWorkAntenna);
            this.gbCmdAntenna.Controls.Add(this.btnSetWorkAntenna);
            this.gbCmdAntenna.ForeColor = System.Drawing.Color.Black;
            this.gbCmdAntenna.Location = new System.Drawing.Point(15, 72);
            this.gbCmdAntenna.Name = "gbCmdAntenna";
            this.gbCmdAntenna.Size = new System.Drawing.Size(472, 50);
            this.gbCmdAntenna.TabIndex = 14;
            this.gbCmdAntenna.TabStop = false;
            this.gbCmdAntenna.Text = "Manual Switch Antenna";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(29, 24);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(63, 13);
            this.label107.TabIndex = 7;
            this.label107.Text = "Current Ant:";
            // 
            // cmbWorkAnt
            // 
            this.cmbWorkAnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkAnt.FormattingEnabled = true;
            this.cmbWorkAnt.Items.AddRange(new object[] {
            "天线 1",
            "天线 2",
            "天线 3",
            "天线 4"});
            this.cmbWorkAnt.Location = new System.Drawing.Point(112, 20);
            this.cmbWorkAnt.Name = "cmbWorkAnt";
            this.cmbWorkAnt.Size = new System.Drawing.Size(84, 21);
            this.cmbWorkAnt.TabIndex = 6;
            // 
            // btnGetWorkAntenna
            // 
            this.btnGetWorkAntenna.Location = new System.Drawing.Point(234, 17);
            this.btnGetWorkAntenna.Name = "btnGetWorkAntenna";
            this.btnGetWorkAntenna.Size = new System.Drawing.Size(90, 25);
            this.btnGetWorkAntenna.TabIndex = 5;
            this.btnGetWorkAntenna.Text = "Get";
            this.btnGetWorkAntenna.UseVisualStyleBackColor = true;
            this.btnGetWorkAntenna.Click += new System.EventHandler(this.btnGetWorkAntenna_Click);
            // 
            // btnSetWorkAntenna
            // 
            this.btnSetWorkAntenna.Location = new System.Drawing.Point(343, 17);
            this.btnSetWorkAntenna.Name = "btnSetWorkAntenna";
            this.btnSetWorkAntenna.Size = new System.Drawing.Size(90, 25);
            this.btnSetWorkAntenna.TabIndex = 4;
            this.btnSetWorkAntenna.Text = "Set";
            this.btnSetWorkAntenna.UseVisualStyleBackColor = true;
            this.btnSetWorkAntenna.Click += new System.EventHandler(this.btnSetWorkAntenna_Click);
            // 
            // gbCmdRegion
            // 
            this.gbCmdRegion.Controls.Add(this.cbUserDefineFreq);
            this.gbCmdRegion.Controls.Add(this.groupBox23);
            this.gbCmdRegion.Controls.Add(this.groupBox21);
            this.gbCmdRegion.Controls.Add(this.btnGetFrequencyRegion);
            this.gbCmdRegion.Controls.Add(this.btnSetFrequencyRegion);
            this.gbCmdRegion.ForeColor = System.Drawing.Color.Black;
            this.gbCmdRegion.Location = new System.Drawing.Point(15, 286);
            this.gbCmdRegion.Name = "gbCmdRegion";
            this.gbCmdRegion.Size = new System.Drawing.Size(967, 156);
            this.gbCmdRegion.TabIndex = 9;
            this.gbCmdRegion.TabStop = false;
            this.gbCmdRegion.Text = "RF Spectrum Setup";
            // 
            // cbUserDefineFreq
            // 
            this.cbUserDefineFreq.AutoSize = true;
            this.cbUserDefineFreq.Location = new System.Drawing.Point(9, 108);
            this.cbUserDefineFreq.Name = "cbUserDefineFreq";
            this.cbUserDefineFreq.Size = new System.Drawing.Size(82, 17);
            this.cbUserDefineFreq.TabIndex = 11;
            this.cbUserDefineFreq.Text = "User Define";
            this.cbUserDefineFreq.UseVisualStyleBackColor = true;
            this.cbUserDefineFreq.CheckedChanged += new System.EventHandler(this.cbUserDefineFreq_CheckedChanged);
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label106);
            this.groupBox23.Controls.Add(this.label105);
            this.groupBox23.Controls.Add(this.label104);
            this.groupBox23.Controls.Add(this.label103);
            this.groupBox23.Controls.Add(this.label86);
            this.groupBox23.Controls.Add(this.label75);
            this.groupBox23.Controls.Add(this.textFreqQuantity);
            this.groupBox23.Controls.Add(this.TextFreqInterval);
            this.groupBox23.Controls.Add(this.textStartFreq);
            this.groupBox23.ForeColor = System.Drawing.Color.Black;
            this.groupBox23.Location = new System.Drawing.Point(103, 84);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(609, 59);
            this.groupBox23.TabIndex = 10;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "User Defined Frequencies";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(571, 26);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(0, 13);
            this.label106.TabIndex = 8;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(400, 26);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(27, 13);
            this.label105.TabIndex = 7;
            this.label105.Text = "KHz";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(213, 26);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(27, 13);
            this.label104.TabIndex = 6;
            this.label104.Text = "KHz";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(429, 26);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(49, 13);
            this.label103.TabIndex = 5;
            this.label103.Text = "Quantity:";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(260, 26);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(65, 13);
            this.label86.TabIndex = 4;
            this.label86.Text = "Freq Space:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(34, 26);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(85, 13);
            this.label75.TabIndex = 3;
            this.label75.Text = "Start Frequency:";
            // 
            // textFreqQuantity
            // 
            this.textFreqQuantity.Location = new System.Drawing.Point(494, 22);
            this.textFreqQuantity.Name = "textFreqQuantity";
            this.textFreqQuantity.Size = new System.Drawing.Size(71, 20);
            this.textFreqQuantity.TabIndex = 2;
            this.textFreqQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextFreqInterval
            // 
            this.TextFreqInterval.Location = new System.Drawing.Point(325, 22);
            this.TextFreqInterval.Name = "TextFreqInterval";
            this.TextFreqInterval.Size = new System.Drawing.Size(71, 20);
            this.TextFreqInterval.TabIndex = 1;
            this.TextFreqInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textStartFreq
            // 
            this.textStartFreq.Location = new System.Drawing.Point(141, 22);
            this.textStartFreq.Name = "textStartFreq";
            this.textStartFreq.Size = new System.Drawing.Size(66, 20);
            this.textStartFreq.TabIndex = 0;
            this.textStartFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label37);
            this.groupBox21.Controls.Add(this.label36);
            this.groupBox21.Controls.Add(this.cmbFrequencyEnd);
            this.groupBox21.Controls.Add(this.label13);
            this.groupBox21.Controls.Add(this.cmbFrequencyStart);
            this.groupBox21.Controls.Add(this.label12);
            this.groupBox21.Controls.Add(this.rdbRegionChn);
            this.groupBox21.Controls.Add(this.rdbRegionEtsi);
            this.groupBox21.Controls.Add(this.rdbRegionFcc);
            this.groupBox21.ForeColor = System.Drawing.Color.Black;
            this.groupBox21.Location = new System.Drawing.Point(103, 17);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(609, 59);
            this.groupBox21.TabIndex = 9;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "System Default Frequencies";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(570, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 13);
            this.label37.TabIndex = 17;
            this.label37.Text = "MHz";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(403, 26);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(29, 13);
            this.label36.TabIndex = 16;
            this.label36.Text = "MHz";
            // 
            // cmbFrequencyEnd
            // 
            this.cmbFrequencyEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequencyEnd.FormattingEnabled = true;
            this.cmbFrequencyEnd.Location = new System.Drawing.Point(494, 20);
            this.cmbFrequencyEnd.Name = "cmbFrequencyEnd";
            this.cmbFrequencyEnd.Size = new System.Drawing.Size(71, 21);
            this.cmbFrequencyEnd.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(454, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "—";
            // 
            // cmbFrequencyStart
            // 
            this.cmbFrequencyStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequencyStart.FormattingEnabled = true;
            this.cmbFrequencyStart.Location = new System.Drawing.Point(325, 20);
            this.cmbFrequencyStart.Name = "cmbFrequencyStart";
            this.cmbFrequencyStart.Size = new System.Drawing.Size(71, 21);
            this.cmbFrequencyStart.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Freq Range:";
            // 
            // rdbRegionChn
            // 
            this.rdbRegionChn.AutoSize = true;
            this.rdbRegionChn.Location = new System.Drawing.Point(195, 24);
            this.rdbRegionChn.Name = "rdbRegionChn";
            this.rdbRegionChn.Size = new System.Drawing.Size(48, 17);
            this.rdbRegionChn.TabIndex = 11;
            this.rdbRegionChn.TabStop = true;
            this.rdbRegionChn.Text = "CHN";
            this.rdbRegionChn.UseVisualStyleBackColor = true;
            this.rdbRegionChn.CheckedChanged += new System.EventHandler(this.rdbRegionChn_CheckedChanged);
            // 
            // rdbRegionEtsi
            // 
            this.rdbRegionEtsi.AutoSize = true;
            this.rdbRegionEtsi.Location = new System.Drawing.Point(116, 24);
            this.rdbRegionEtsi.Name = "rdbRegionEtsi";
            this.rdbRegionEtsi.Size = new System.Drawing.Size(49, 17);
            this.rdbRegionEtsi.TabIndex = 10;
            this.rdbRegionEtsi.TabStop = true;
            this.rdbRegionEtsi.Text = "ETSI";
            this.rdbRegionEtsi.UseVisualStyleBackColor = true;
            this.rdbRegionEtsi.CheckedChanged += new System.EventHandler(this.rdbRegionEtsi_CheckedChanged);
            // 
            // rdbRegionFcc
            // 
            this.rdbRegionFcc.AutoSize = true;
            this.rdbRegionFcc.Location = new System.Drawing.Point(43, 24);
            this.rdbRegionFcc.Name = "rdbRegionFcc";
            this.rdbRegionFcc.Size = new System.Drawing.Size(45, 17);
            this.rdbRegionFcc.TabIndex = 9;
            this.rdbRegionFcc.TabStop = true;
            this.rdbRegionFcc.Text = "FCC";
            this.rdbRegionFcc.UseVisualStyleBackColor = true;
            this.rdbRegionFcc.CheckedChanged += new System.EventHandler(this.rdbRegionFcc_CheckedChanged);
            // 
            // btnGetFrequencyRegion
            // 
            this.btnGetFrequencyRegion.Location = new System.Drawing.Point(734, 72);
            this.btnGetFrequencyRegion.Name = "btnGetFrequencyRegion";
            this.btnGetFrequencyRegion.Size = new System.Drawing.Size(90, 25);
            this.btnGetFrequencyRegion.TabIndex = 6;
            this.btnGetFrequencyRegion.Text = "Get";
            this.btnGetFrequencyRegion.UseVisualStyleBackColor = true;
            this.btnGetFrequencyRegion.Click += new System.EventHandler(this.btnGetFrequencyRegion_Click);
            // 
            // btnSetFrequencyRegion
            // 
            this.btnSetFrequencyRegion.Location = new System.Drawing.Point(859, 72);
            this.btnSetFrequencyRegion.Name = "btnSetFrequencyRegion";
            this.btnSetFrequencyRegion.Size = new System.Drawing.Size(90, 25);
            this.btnSetFrequencyRegion.TabIndex = 5;
            this.btnSetFrequencyRegion.Text = "Set";
            this.btnSetFrequencyRegion.UseVisualStyleBackColor = true;
            this.btnSetFrequencyRegion.Click += new System.EventHandler(this.btnSetFrequencyRegion_Click);
            // 
            // gbCmdOutputPower
            // 
            this.gbCmdOutputPower.Controls.Add(this.btnGetOutputPower);
            this.gbCmdOutputPower.Controls.Add(this.btnSetOutputPower);
            this.gbCmdOutputPower.Controls.Add(this.txtOutputPower);
            this.gbCmdOutputPower.Controls.Add(this.label9);
            this.gbCmdOutputPower.ForeColor = System.Drawing.Color.Black;
            this.gbCmdOutputPower.Location = new System.Drawing.Point(505, 9);
            this.gbCmdOutputPower.Name = "gbCmdOutputPower";
            this.gbCmdOutputPower.Size = new System.Drawing.Size(477, 53);
            this.gbCmdOutputPower.TabIndex = 8;
            this.gbCmdOutputPower.TabStop = false;
            this.gbCmdOutputPower.Text = "RF Output Power";
            // 
            // btnGetOutputPower
            // 
            this.btnGetOutputPower.Location = new System.Drawing.Point(244, 17);
            this.btnGetOutputPower.Name = "btnGetOutputPower";
            this.btnGetOutputPower.Size = new System.Drawing.Size(90, 25);
            this.btnGetOutputPower.TabIndex = 2;
            this.btnGetOutputPower.Text = "Get";
            this.btnGetOutputPower.UseVisualStyleBackColor = true;
            this.btnGetOutputPower.Click += new System.EventHandler(this.btnGetOutputPower_Click);
            // 
            // btnSetOutputPower
            // 
            this.btnSetOutputPower.Location = new System.Drawing.Point(369, 17);
            this.btnSetOutputPower.Name = "btnSetOutputPower";
            this.btnSetOutputPower.Size = new System.Drawing.Size(90, 25);
            this.btnSetOutputPower.TabIndex = 1;
            this.btnSetOutputPower.Text = "Set";
            this.btnSetOutputPower.UseVisualStyleBackColor = true;
            this.btnSetOutputPower.Click += new System.EventHandler(this.btnSetOutputPower_Click);
            // 
            // txtOutputPower
            // 
            this.txtOutputPower.Location = new System.Drawing.Point(79, 19);
            this.txtOutputPower.Name = "txtOutputPower";
            this.txtOutputPower.Size = new System.Drawing.Size(71, 20);
            this.txtOutputPower.TabIndex = 0;
            this.txtOutputPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "dBm";
            // 
            // pageEpcTest
            // 
            this.pageEpcTest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageEpcTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageEpcTest.Controls.Add(this.tabEpcTest);
            this.pageEpcTest.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pageEpcTest.Location = new System.Drawing.Point(4, 22);
            this.pageEpcTest.Name = "pageEpcTest";
            this.pageEpcTest.Size = new System.Drawing.Size(1341, 655);
            this.pageEpcTest.TabIndex = 5;
            this.pageEpcTest.Text = "Race Management";
            // 
            // tabEpcTest
            // 
            this.tabEpcTest.Controls.Add(this.tabTrack);
            this.tabEpcTest.Controls.Add(this.tabPilots);
            this.tabEpcTest.Controls.Add(this.tabRounds);
            this.tabEpcTest.Controls.Add(this.tabRace);
            this.tabEpcTest.Controls.Add(this.pageRealMode);
            this.tabEpcTest.Controls.Add(this.pageBufferedMode);
            this.tabEpcTest.Controls.Add(this.pageFast4AntMode);
            this.tabEpcTest.Controls.Add(this.pageAcessTag);
            this.tabEpcTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEpcTest.Location = new System.Drawing.Point(0, 0);
            this.tabEpcTest.Name = "tabEpcTest";
            this.tabEpcTest.SelectedIndex = 0;
            this.tabEpcTest.Size = new System.Drawing.Size(1339, 653);
            this.tabEpcTest.TabIndex = 0;
            // 
            // tabTrack
            // 
            this.tabTrack.Controls.Add(this.groupBox26);
            this.tabTrack.Location = new System.Drawing.Point(4, 22);
            this.tabTrack.Name = "tabTrack";
            this.tabTrack.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrack.Size = new System.Drawing.Size(1331, 627);
            this.tabTrack.TabIndex = 7;
            this.tabTrack.Text = "Track Management";
            this.tabTrack.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox26.Controls.Add(this.label123);
            this.groupBox26.Controls.Add(this.cmbRoundType);
            this.groupBox26.Controls.Add(this.cbSecondChance);
            this.groupBox26.Controls.Add(this.label122);
            this.groupBox26.Controls.Add(this.btTrack);
            this.groupBox26.Controls.Add(this.nudPilotsPerGroup);
            this.groupBox26.Controls.Add(this.label112);
            this.groupBox26.Controls.Add(this.tbRaceLength);
            this.groupBox26.Controls.Add(this.label113);
            this.groupBox26.Controls.Add(this.label119);
            this.groupBox26.Controls.Add(this.nudMinLapTime);
            this.groupBox26.Controls.Add(this.label117);
            this.groupBox26.Controls.Add(this.nudMinFirstLapTime);
            this.groupBox26.Controls.Add(this.dtpRaceDate);
            this.groupBox26.Controls.Add(this.label111);
            this.groupBox26.Controls.Add(this.nudNumOfLaps);
            this.groupBox26.Controls.Add(this.label102);
            this.groupBox26.Controls.Add(this.nudNumberOfQualRounds);
            this.groupBox26.Controls.Add(this.tbRaceLocation);
            this.groupBox26.Controls.Add(this.label101);
            this.groupBox26.Controls.Add(this.tbRaceName);
            this.groupBox26.Controls.Add(this.label100);
            this.groupBox26.Controls.Add(this.label99);
            this.groupBox26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox26.Location = new System.Drawing.Point(3, 3);
            this.groupBox26.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox26.Size = new System.Drawing.Size(1325, 621);
            this.groupBox26.TabIndex = 3;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Race Properties";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(91, 390);
            this.label123.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(65, 13);
            this.label123.TabIndex = 24;
            this.label123.Text = "Round type:";
            // 
            // cmbRoundType
            // 
            this.cmbRoundType.FormattingEnabled = true;
            this.cmbRoundType.Items.AddRange(new object[] {
            "1/4",
            "1/8"});
            this.cmbRoundType.Location = new System.Drawing.Point(168, 385);
            this.cmbRoundType.Name = "cmbRoundType";
            this.cmbRoundType.Size = new System.Drawing.Size(53, 21);
            this.cmbRoundType.TabIndex = 23;
            this.cmbRoundType.SelectedIndexChanged += new System.EventHandler(this.cmbRoundType_SelectedIndexChanged);
            // 
            // cbSecondChance
            // 
            this.cbSecondChance.AutoSize = true;
            this.cbSecondChance.Location = new System.Drawing.Point(168, 357);
            this.cbSecondChance.Name = "cbSecondChance";
            this.cbSecondChance.Size = new System.Drawing.Size(15, 14);
            this.cbSecondChance.TabIndex = 22;
            this.cbSecondChance.UseVisualStyleBackColor = true;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(49, 357);
            this.label122.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(107, 13);
            this.label122.TabIndex = 21;
            this.label122.Text = "Use second Change:";
            // 
            // btTrack
            // 
            this.btTrack.Location = new System.Drawing.Point(108, 437);
            this.btTrack.Name = "btTrack";
            this.btTrack.Size = new System.Drawing.Size(75, 23);
            this.btTrack.TabIndex = 20;
            this.btTrack.Text = "Save";
            this.btTrack.UseVisualStyleBackColor = true;
            this.btTrack.Click += new System.EventHandler(this.btTrack_Click);
            // 
            // nudPilotsPerGroup
            // 
            this.nudPilotsPerGroup.Location = new System.Drawing.Point(168, 248);
            this.nudPilotsPerGroup.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudPilotsPerGroup.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPilotsPerGroup.Name = "nudPilotsPerGroup";
            this.nudPilotsPerGroup.Size = new System.Drawing.Size(51, 20);
            this.nudPilotsPerGroup.TabIndex = 18;
            this.nudPilotsPerGroup.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(72, 182);
            this.label112.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(85, 13);
            this.label112.TabIndex = 15;
            this.label112.Text = "Number of Laps:";
            // 
            // tbRaceLength
            // 
            this.tbRaceLength.Location = new System.Drawing.Point(96, 98);
            this.tbRaceLength.Name = "tbRaceLength";
            this.tbRaceLength.Size = new System.Drawing.Size(211, 20);
            this.tbRaceLength.TabIndex = 13;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(1, 215);
            this.label113.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(160, 13);
            this.label113.TabIndex = 16;
            this.label113.Text = "Number of Qualification Rounds:";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(18, 97);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(74, 26);
            this.label119.TabIndex = 12;
            this.label119.Text = "Track Length:\r\n(meters)";
            // 
            // nudMinLapTime
            // 
            this.nudMinLapTime.Location = new System.Drawing.Point(168, 319);
            this.nudMinLapTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinLapTime.Name = "nudMinLapTime";
            this.nudMinLapTime.Size = new System.Drawing.Size(51, 20);
            this.nudMinLapTime.TabIndex = 11;
            this.nudMinLapTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(34, 322);
            this.label117.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(124, 13);
            this.label117.TabIndex = 10;
            this.label117.Text = "Minimum Lap Time (sec):";
            // 
            // nudMinFirstLapTime
            // 
            this.nudMinFirstLapTime.Location = new System.Drawing.Point(168, 284);
            this.nudMinFirstLapTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinFirstLapTime.Name = "nudMinFirstLapTime";
            this.nudMinFirstLapTime.Size = new System.Drawing.Size(51, 20);
            this.nudMinFirstLapTime.TabIndex = 9;
            this.nudMinFirstLapTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dtpRaceDate
            // 
            this.dtpRaceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRaceDate.Location = new System.Drawing.Point(97, 141);
            this.dtpRaceDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRaceDate.Name = "dtpRaceDate";
            this.dtpRaceDate.Size = new System.Drawing.Size(210, 20);
            this.dtpRaceDate.TabIndex = 8;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(24, 250);
            this.label111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(137, 13);
            this.label111.TabIndex = 19;
            this.label111.Text = "Number of Pilots per Group:";
            // 
            // nudNumOfLaps
            // 
            this.nudNumOfLaps.Location = new System.Drawing.Point(168, 178);
            this.nudNumOfLaps.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudNumOfLaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumOfLaps.Name = "nudNumOfLaps";
            this.nudNumOfLaps.Size = new System.Drawing.Size(51, 20);
            this.nudNumOfLaps.TabIndex = 14;
            this.nudNumOfLaps.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(56, 144);
            this.label102.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(33, 13);
            this.label102.TabIndex = 6;
            this.label102.Text = "Date:";
            // 
            // nudNumberOfQualRounds
            // 
            this.nudNumberOfQualRounds.Location = new System.Drawing.Point(168, 212);
            this.nudNumberOfQualRounds.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNumberOfQualRounds.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumberOfQualRounds.Name = "nudNumberOfQualRounds";
            this.nudNumberOfQualRounds.Size = new System.Drawing.Size(51, 20);
            this.nudNumberOfQualRounds.TabIndex = 17;
            this.nudNumberOfQualRounds.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // tbRaceLocation
            // 
            this.tbRaceLocation.Location = new System.Drawing.Point(96, 63);
            this.tbRaceLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbRaceLocation.Name = "tbRaceLocation";
            this.tbRaceLocation.Size = new System.Drawing.Size(211, 20);
            this.tbRaceLocation.TabIndex = 5;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(38, 65);
            this.label101.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(51, 13);
            this.label101.TabIndex = 4;
            this.label101.Text = "Location:";
            // 
            // tbRaceName
            // 
            this.tbRaceName.Location = new System.Drawing.Point(96, 31);
            this.tbRaceName.Margin = new System.Windows.Forms.Padding(2);
            this.tbRaceName.Name = "tbRaceName";
            this.tbRaceName.Size = new System.Drawing.Size(211, 20);
            this.tbRaceName.TabIndex = 3;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(21, 34);
            this.label100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(69, 13);
            this.label100.TabIndex = 2;
            this.label100.Text = "Event Name:";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(16, 288);
            this.label99.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(146, 13);
            this.label99.TabIndex = 0;
            this.label99.Text = "Minimum First Lap Time (sec):";
            // 
            // tabPilots
            // 
            this.tabPilots.Controls.Add(this.tableLayoutPanel8);
            this.tabPilots.Location = new System.Drawing.Point(4, 22);
            this.tabPilots.Margin = new System.Windows.Forms.Padding(2);
            this.tabPilots.Name = "tabPilots";
            this.tabPilots.Padding = new System.Windows.Forms.Padding(2);
            this.tabPilots.Size = new System.Drawing.Size(1331, 627);
            this.tabPilots.TabIndex = 5;
            this.tabPilots.Text = "Pilot Management";
            this.tabPilots.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.79245F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.20755F));
            this.tableLayoutPanel8.Controls.Add(this.groupBox27, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBox28, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 621F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1326, 622);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.btnClearDB);
            this.groupBox27.Controls.Add(this.btnAddPilotFromDb);
            this.groupBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox27.Location = new System.Drawing.Point(3, 3);
            this.groupBox27.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox27.Size = new System.Drawing.Size(350, 616);
            this.groupBox27.TabIndex = 0;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Pilot Registration";
            // 
            // btnClearDB
            // 
            this.btnClearDB.Location = new System.Drawing.Point(122, 564);
            this.btnClearDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearDB.Name = "btnClearDB";
            this.btnClearDB.Size = new System.Drawing.Size(94, 37);
            this.btnClearDB.TabIndex = 13;
            this.btnClearDB.Text = "Clear all from DB";
            this.btnClearDB.UseVisualStyleBackColor = true;
            this.btnClearDB.Click += new System.EventHandler(this.btnClearDB_Click);
            // 
            // btnAddPilotFromDb
            // 
            this.btnAddPilotFromDb.Location = new System.Drawing.Point(31, 30);
            this.btnAddPilotFromDb.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPilotFromDb.Name = "btnAddPilotFromDb";
            this.btnAddPilotFromDb.Size = new System.Drawing.Size(253, 37);
            this.btnAddPilotFromDb.TabIndex = 12;
            this.btnAddPilotFromDb.Text = "Load from DB";
            this.btnAddPilotFromDb.UseVisualStyleBackColor = true;
            this.btnAddPilotFromDb.Click += new System.EventHandler(this.btnAddPilotFromDb_Click);
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.gvPilots);
            this.groupBox28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox28.Location = new System.Drawing.Point(358, 3);
            this.groupBox28.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox28.Size = new System.Drawing.Size(965, 616);
            this.groupBox28.TabIndex = 1;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Pilot List for  Race";
            // 
            // gvPilots
            // 
            this.gvPilots.AllowUserToAddRows = false;
            this.gvPilots.AllowUserToOrderColumns = true;
            this.gvPilots.AutoGenerateColumns = false;
            this.gvPilots.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvPilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPilots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Email,
            this.Column1});
            this.gvPilots.DataSource = this.bindingSourcePilots1;
            this.gvPilots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPilots.GridColor = System.Drawing.SystemColors.Control;
            this.gvPilots.Location = new System.Drawing.Point(2, 15);
            this.gvPilots.Margin = new System.Windows.Forms.Padding(2);
            this.gvPilots.Name = "gvPilots";
            this.gvPilots.RowTemplate.Height = 24;
            this.gvPilots.Size = new System.Drawing.Size(961, 599);
            this.gvPilots.TabIndex = 0;
            this.gvPilots.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPilots_CellValueChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "TAG ID";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "ConfirmationString";
            this.Email.HeaderText = "Confirmation";
            this.Email.Name = "Email";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderNumber";
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // bindingSourcePilots1
            // 
            this.bindingSourcePilots1.DataSource = typeof(RaceManager.Data.Pilot);
            // 
            // tabRounds
            // 
            this.tabRounds.Controls.Add(this.panel11);
            this.tabRounds.Location = new System.Drawing.Point(4, 22);
            this.tabRounds.Name = "tabRounds";
            this.tabRounds.Padding = new System.Windows.Forms.Padding(3);
            this.tabRounds.Size = new System.Drawing.Size(1331, 627);
            this.tabRounds.TabIndex = 6;
            this.tabRounds.Text = "Round Management";
            this.tabRounds.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.AutoScroll = true;
            this.panel11.Controls.Add(this.tableLayoutPanel12);
            this.panel11.Controls.Add(this.tableLayoutPanel7);
            this.panel11.Controls.Add(this.tableLayoutPanel11);
            this.panel11.Controls.Add(this.tableLayoutPanel9);
            this.panel11.Controls.Add(this.tableLayoutPanel10);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1325, 621);
            this.panel11.TabIndex = 6;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24711F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.75288F));
            this.tableLayoutPanel12.Controls.Add(this.tabControl6, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.groupBox30, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(2, 158);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1300, 156);
            this.tableLayoutPanel12.TabIndex = 6;
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage22);
            this.tabControl6.Controls.Add(this.tabPage23);
            this.tabControl6.Controls.Add(this.tabPage24);
            this.tabControl6.Controls.Add(this.tabPage25);
            this.tabControl6.Controls.Add(this.tabPage26);
            this.tabControl6.Controls.Add(this.tabPage27);
            this.tabControl6.Controls.Add(this.tabPage28);
            this.tabControl6.Controls.Add(this.tabPage29);
            this.tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl6.Location = new System.Drawing.Point(279, 3);
            this.tabControl6.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(1018, 150);
            this.tabControl6.TabIndex = 2;
            // 
            // tabPage22
            // 
            this.tabPage22.Controls.Add(this.gvRace1);
            this.tabPage22.Location = new System.Drawing.Point(4, 22);
            this.tabPage22.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage22.Name = "tabPage22";
            this.tabPage22.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage22.Size = new System.Drawing.Size(1010, 124);
            this.tabPage22.TabIndex = 0;
            this.tabPage22.Text = "Race 1";
            this.tabPage22.UseVisualStyleBackColor = true;
            // 
            // gvRace1
            // 
            this.gvRace1.AllowUserToAddRows = false;
            this.gvRace1.AllowUserToOrderColumns = true;
            this.gvRace1.AutoGenerateColumns = false;
            this.gvRace1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn213,
            this.dataGridViewTextBoxColumn214,
            this.dataGridViewTextBoxColumn215,
            this.dataGridViewTextBoxColumn216,
            this.dataGridViewTextBoxColumn217,
            this.colDelRace1});
            this.gvRace1.DataSource = this.bindingSourcePilots;
            this.gvRace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace1.Location = new System.Drawing.Point(2, 2);
            this.gvRace1.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace1.Name = "gvRace1";
            this.gvRace1.RowTemplate.Height = 24;
            this.gvRace1.Size = new System.Drawing.Size(1006, 120);
            this.gvRace1.TabIndex = 0;
            this.gvRace1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // dataGridViewTextBoxColumn213
            // 
            this.dataGridViewTextBoxColumn213.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn213.HeaderText = "Name";
            this.dataGridViewTextBoxColumn213.Name = "dataGridViewTextBoxColumn213";
            this.dataGridViewTextBoxColumn213.Width = 200;
            // 
            // dataGridViewTextBoxColumn214
            // 
            this.dataGridViewTextBoxColumn214.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn214.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn214.Name = "dataGridViewTextBoxColumn214";
            // 
            // dataGridViewTextBoxColumn215
            // 
            this.dataGridViewTextBoxColumn215.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn215.HeaderText = "Team";
            this.dataGridViewTextBoxColumn215.Name = "dataGridViewTextBoxColumn215";
            // 
            // dataGridViewTextBoxColumn216
            // 
            this.dataGridViewTextBoxColumn216.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn216.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn216.Name = "dataGridViewTextBoxColumn216";
            this.dataGridViewTextBoxColumn216.Width = 250;
            // 
            // dataGridViewTextBoxColumn217
            // 
            this.dataGridViewTextBoxColumn217.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn217.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn217.Name = "dataGridViewTextBoxColumn217";
            this.dataGridViewTextBoxColumn217.Width = 250;
            // 
            // colDelRace1
            // 
            this.colDelRace1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDelRace1.HeaderText = "Delete";
            this.colDelRace1.Name = "colDelRace1";
            this.colDelRace1.Text = "X";
            this.colDelRace1.UseColumnTextForButtonValue = true;
            this.colDelRace1.Width = 45;
            // 
            // bindingSourcePilots
            // 
            this.bindingSourcePilots.DataSource = typeof(RaceManager.Data.Pilot);
            // 
            // tabPage23
            // 
            this.tabPage23.Controls.Add(this.gvRace2);
            this.tabPage23.Location = new System.Drawing.Point(4, 22);
            this.tabPage23.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage23.Name = "tabPage23";
            this.tabPage23.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage23.Size = new System.Drawing.Size(1010, 124);
            this.tabPage23.TabIndex = 1;
            this.tabPage23.Text = "Race 2";
            this.tabPage23.UseVisualStyleBackColor = true;
            // 
            // gvRace2
            // 
            this.gvRace2.AllowUserToAddRows = false;
            this.gvRace2.AllowUserToOrderColumns = true;
            this.gvRace2.AutoGenerateColumns = false;
            this.gvRace2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn218,
            this.dataGridViewTextBoxColumn219,
            this.dataGridViewTextBoxColumn220,
            this.dataGridViewTextBoxColumn221,
            this.dataGridViewTextBoxColumn222,
            this.colDel_Race2});
            this.gvRace2.DataSource = this.bindingSourcePilots;
            this.gvRace2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace2.Location = new System.Drawing.Point(2, 2);
            this.gvRace2.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace2.Name = "gvRace2";
            this.gvRace2.RowTemplate.Height = 24;
            this.gvRace2.Size = new System.Drawing.Size(1006, 120);
            this.gvRace2.TabIndex = 1;
            this.gvRace2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage24
            // 
            this.tabPage24.Controls.Add(this.gvRace3);
            this.tabPage24.Location = new System.Drawing.Point(4, 22);
            this.tabPage24.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage24.Name = "tabPage24";
            this.tabPage24.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage24.Size = new System.Drawing.Size(1010, 124);
            this.tabPage24.TabIndex = 2;
            this.tabPage24.Text = "Race 3";
            this.tabPage24.UseVisualStyleBackColor = true;
            // 
            // gvRace3
            // 
            this.gvRace3.AllowUserToAddRows = false;
            this.gvRace3.AutoGenerateColumns = false;
            this.gvRace3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn223,
            this.dataGridViewTextBoxColumn224,
            this.dataGridViewTextBoxColumn225,
            this.dataGridViewTextBoxColumn226,
            this.dataGridViewTextBoxColumn227,
            this.colDel_Race3});
            this.gvRace3.DataSource = this.bindingSourcePilots;
            this.gvRace3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace3.Location = new System.Drawing.Point(2, 2);
            this.gvRace3.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace3.Name = "gvRace3";
            this.gvRace3.RowTemplate.Height = 24;
            this.gvRace3.Size = new System.Drawing.Size(1006, 120);
            this.gvRace3.TabIndex = 1;
            this.gvRace3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage25
            // 
            this.tabPage25.Controls.Add(this.gvRace4);
            this.tabPage25.Location = new System.Drawing.Point(4, 22);
            this.tabPage25.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage25.Name = "tabPage25";
            this.tabPage25.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage25.Size = new System.Drawing.Size(1010, 124);
            this.tabPage25.TabIndex = 3;
            this.tabPage25.Text = "Race 4";
            this.tabPage25.UseVisualStyleBackColor = true;
            // 
            // gvRace4
            // 
            this.gvRace4.AllowUserToAddRows = false;
            this.gvRace4.AutoGenerateColumns = false;
            this.gvRace4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn228,
            this.dataGridViewTextBoxColumn229,
            this.dataGridViewTextBoxColumn230,
            this.dataGridViewTextBoxColumn231,
            this.dataGridViewTextBoxColumn232,
            this.colDel_Race4});
            this.gvRace4.DataSource = this.bindingSourcePilots;
            this.gvRace4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace4.Location = new System.Drawing.Point(2, 2);
            this.gvRace4.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace4.Name = "gvRace4";
            this.gvRace4.RowTemplate.Height = 24;
            this.gvRace4.Size = new System.Drawing.Size(1006, 120);
            this.gvRace4.TabIndex = 1;
            this.gvRace4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage26
            // 
            this.tabPage26.Controls.Add(this.gvRace5);
            this.tabPage26.Location = new System.Drawing.Point(4, 22);
            this.tabPage26.Name = "tabPage26";
            this.tabPage26.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage26.Size = new System.Drawing.Size(1010, 124);
            this.tabPage26.TabIndex = 4;
            this.tabPage26.Text = "Race 5";
            this.tabPage26.UseVisualStyleBackColor = true;
            // 
            // gvRace5
            // 
            this.gvRace5.AllowUserToAddRows = false;
            this.gvRace5.AutoGenerateColumns = false;
            this.gvRace5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn233,
            this.dataGridViewTextBoxColumn234,
            this.dataGridViewTextBoxColumn235,
            this.dataGridViewTextBoxColumn236,
            this.dataGridViewTextBoxColumn237,
            this.colDel_Race5});
            this.gvRace5.DataSource = this.bindingSourcePilots;
            this.gvRace5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace5.Location = new System.Drawing.Point(3, 3);
            this.gvRace5.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace5.Name = "gvRace5";
            this.gvRace5.RowTemplate.Height = 24;
            this.gvRace5.Size = new System.Drawing.Size(1004, 118);
            this.gvRace5.TabIndex = 2;
            this.gvRace5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage27
            // 
            this.tabPage27.Controls.Add(this.gvRace6);
            this.tabPage27.Location = new System.Drawing.Point(4, 22);
            this.tabPage27.Name = "tabPage27";
            this.tabPage27.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage27.Size = new System.Drawing.Size(1010, 124);
            this.tabPage27.TabIndex = 5;
            this.tabPage27.Text = "Race 6";
            this.tabPage27.UseVisualStyleBackColor = true;
            // 
            // gvRace6
            // 
            this.gvRace6.AllowUserToAddRows = false;
            this.gvRace6.AutoGenerateColumns = false;
            this.gvRace6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn238,
            this.dataGridViewTextBoxColumn239,
            this.dataGridViewTextBoxColumn240,
            this.dataGridViewTextBoxColumn241,
            this.dataGridViewTextBoxColumn242,
            this.colDel_Race6});
            this.gvRace6.DataSource = this.bindingSourcePilots;
            this.gvRace6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace6.Location = new System.Drawing.Point(3, 3);
            this.gvRace6.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace6.Name = "gvRace6";
            this.gvRace6.ReadOnly = true;
            this.gvRace6.RowTemplate.Height = 24;
            this.gvRace6.Size = new System.Drawing.Size(1004, 118);
            this.gvRace6.TabIndex = 2;
            this.gvRace6.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage28
            // 
            this.tabPage28.Controls.Add(this.gvRace7);
            this.tabPage28.Location = new System.Drawing.Point(4, 22);
            this.tabPage28.Name = "tabPage28";
            this.tabPage28.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage28.Size = new System.Drawing.Size(1010, 124);
            this.tabPage28.TabIndex = 6;
            this.tabPage28.Text = "Race 7";
            this.tabPage28.UseVisualStyleBackColor = true;
            // 
            // gvRace7
            // 
            this.gvRace7.AllowUserToAddRows = false;
            this.gvRace7.AutoGenerateColumns = false;
            this.gvRace7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn243,
            this.dataGridViewTextBoxColumn244,
            this.dataGridViewTextBoxColumn245,
            this.dataGridViewTextBoxColumn246,
            this.dataGridViewTextBoxColumn247,
            this.colDel_Race7});
            this.gvRace7.DataSource = this.bindingSourcePilots;
            this.gvRace7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace7.Location = new System.Drawing.Point(3, 3);
            this.gvRace7.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace7.Name = "gvRace7";
            this.gvRace7.RowTemplate.Height = 24;
            this.gvRace7.Size = new System.Drawing.Size(1004, 118);
            this.gvRace7.TabIndex = 2;
            this.gvRace7.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage29
            // 
            this.tabPage29.Controls.Add(this.gvRace8);
            this.tabPage29.Location = new System.Drawing.Point(4, 22);
            this.tabPage29.Name = "tabPage29";
            this.tabPage29.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage29.Size = new System.Drawing.Size(1010, 124);
            this.tabPage29.TabIndex = 7;
            this.tabPage29.Text = "Race 8";
            this.tabPage29.UseVisualStyleBackColor = true;
            // 
            // gvRace8
            // 
            this.gvRace8.AllowUserToAddRows = false;
            this.gvRace8.AutoGenerateColumns = false;
            this.gvRace8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn248,
            this.dataGridViewTextBoxColumn249,
            this.dataGridViewTextBoxColumn250,
            this.dataGridViewTextBoxColumn251,
            this.dataGridViewTextBoxColumn252,
            this.colDel_Race8});
            this.gvRace8.DataSource = this.bindingSourcePilots;
            this.gvRace8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace8.Location = new System.Drawing.Point(3, 3);
            this.gvRace8.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace8.Name = "gvRace8";
            this.gvRace8.RowTemplate.Height = 24;
            this.gvRace8.Size = new System.Drawing.Size(1004, 118);
            this.gvRace8.TabIndex = 2;
            this.gvRace8.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.btnManAddPilotsTo18F);
            this.groupBox30.Controls.Add(this.btnAddPilotsTo18F);
            this.groupBox30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox30.Location = new System.Drawing.Point(4, 4);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(269, 148);
            this.groupBox30.TabIndex = 0;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "1 / 8   ROUND";
            // 
            // btnManAddPilotsTo18F
            // 
            this.btnManAddPilotsTo18F.Location = new System.Drawing.Point(25, 86);
            this.btnManAddPilotsTo18F.Name = "btnManAddPilotsTo18F";
            this.btnManAddPilotsTo18F.Size = new System.Drawing.Size(208, 36);
            this.btnManAddPilotsTo18F.TabIndex = 3;
            this.btnManAddPilotsTo18F.Text = "Manually Add Pilots";
            this.btnManAddPilotsTo18F.UseVisualStyleBackColor = true;
            this.btnManAddPilotsTo18F.Click += new System.EventHandler(this.btnManAddPilotsTo18F_Click);
            // 
            // btnAddPilotsTo18F
            // 
            this.btnAddPilotsTo18F.Location = new System.Drawing.Point(25, 35);
            this.btnAddPilotsTo18F.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPilotsTo18F.Name = "btnAddPilotsTo18F";
            this.btnAddPilotsTo18F.Size = new System.Drawing.Size(208, 36);
            this.btnAddPilotsTo18F.TabIndex = 3;
            this.btnAddPilotsTo18F.Text = "Add Pilots to 1/8 round";
            this.btnAddPilotsTo18F.UseVisualStyleBackColor = true;
            this.btnAddPilotsTo18F.Click += new System.EventHandler(this.btnAddPilotsTo18F_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24711F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.75288F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox29, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tabControl2, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1300, 156);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.btnAddPilotsToQR);
            this.groupBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox29.Location = new System.Drawing.Point(3, 3);
            this.groupBox29.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox29.Size = new System.Drawing.Size(271, 150);
            this.groupBox29.TabIndex = 0;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "QUALIFICATION ROUND";
            // 
            // btnAddPilotsToQR
            // 
            this.btnAddPilotsToQR.Location = new System.Drawing.Point(26, 62);
            this.btnAddPilotsToQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPilotsToQR.Name = "btnAddPilotsToQR";
            this.btnAddPilotsToQR.Size = new System.Drawing.Size(208, 36);
            this.btnAddPilotsToQR.TabIndex = 2;
            this.btnAddPilotsToQR.Text = "Add Pilots to Qualification Round";
            this.btnAddPilotsToQR.UseVisualStyleBackColor = true;
            this.btnAddPilotsToQR.Click += new System.EventHandler(this.btnAddPilotsToGroups_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.pageGroupA);
            this.tabControl2.Controls.Add(this.pageGroupB);
            this.tabControl2.Controls.Add(this.pageGroupC);
            this.tabControl2.Controls.Add(this.pageGroupD);
            this.tabControl2.Controls.Add(this.pageGroupE);
            this.tabControl2.Controls.Add(this.pageGroupF);
            this.tabControl2.Controls.Add(this.pageGroupG);
            this.tabControl2.Controls.Add(this.pageGroupH);
            this.tabControl2.Controls.Add(this.pageGroupI);
            this.tabControl2.Controls.Add(this.pageGroupJ);
            this.tabControl2.Controls.Add(this.pageGroupK);
            this.tabControl2.Controls.Add(this.pageGroupL);
            this.tabControl2.Controls.Add(this.pageGroupM);
            this.tabControl2.Controls.Add(this.pageGroupN);
            this.tabControl2.Controls.Add(this.pageGroupO);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Controls.Add(this.tabPage12);
            this.tabControl2.Controls.Add(this.tabPage13);
            this.tabControl2.Controls.Add(this.tabPage14);
            this.tabControl2.Controls.Add(this.tabPage15);
            this.tabControl2.Controls.Add(this.tabPage16);
            this.tabControl2.Controls.Add(this.tabPage17);
            this.tabControl2.Controls.Add(this.tabPage18);
            this.tabControl2.Controls.Add(this.tabPage19);
            this.tabControl2.Controls.Add(this.tabPage20);
            this.tabControl2.Controls.Add(this.tabPage21);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(279, 3);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1018, 150);
            this.tabControl2.TabIndex = 1;
            // 
            // pageGroupA
            // 
            this.pageGroupA.Controls.Add(this.gvGroupA);
            this.pageGroupA.Location = new System.Drawing.Point(4, 22);
            this.pageGroupA.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupA.Name = "pageGroupA";
            this.pageGroupA.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupA.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupA.TabIndex = 0;
            this.pageGroupA.Text = "Group A";
            this.pageGroupA.UseVisualStyleBackColor = true;
            // 
            // gvGroupA
            // 
            this.gvGroupA.AllowUserToAddRows = false;
            this.gvGroupA.AllowUserToDeleteRows = false;
            this.gvGroupA.AutoGenerateColumns = false;
            this.gvGroupA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.nicknameDataGridViewTextBoxColumn1,
            this.teamDataGridViewTextBoxColumn1,
            this.tagDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.gvGroupA.DataSource = this.bindingSourcePilots;
            this.gvGroupA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupA.Location = new System.Drawing.Point(2, 2);
            this.gvGroupA.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupA.Name = "gvGroupA";
            this.gvGroupA.ReadOnly = true;
            this.gvGroupA.RowTemplate.Height = 24;
            this.gvGroupA.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupA.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // nicknameDataGridViewTextBoxColumn1
            // 
            this.nicknameDataGridViewTextBoxColumn1.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn1.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn1.Name = "nicknameDataGridViewTextBoxColumn1";
            this.nicknameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teamDataGridViewTextBoxColumn1
            // 
            this.teamDataGridViewTextBoxColumn1.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn1.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn1.Name = "teamDataGridViewTextBoxColumn1";
            this.teamDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tagDataGridViewTextBoxColumn1
            // 
            this.tagDataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn1.HeaderText = "TAG ID";
            this.tagDataGridViewTextBoxColumn1.Name = "tagDataGridViewTextBoxColumn1";
            this.tagDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tagDataGridViewTextBoxColumn1.Width = 290;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn1.Width = 250;
            // 
            // pageGroupB
            // 
            this.pageGroupB.Controls.Add(this.gvGroupB);
            this.pageGroupB.Location = new System.Drawing.Point(4, 22);
            this.pageGroupB.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupB.Name = "pageGroupB";
            this.pageGroupB.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupB.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupB.TabIndex = 1;
            this.pageGroupB.Text = "Group B";
            this.pageGroupB.UseVisualStyleBackColor = true;
            // 
            // gvGroupB
            // 
            this.gvGroupB.AllowUserToAddRows = false;
            this.gvGroupB.AllowUserToDeleteRows = false;
            this.gvGroupB.AutoGenerateColumns = false;
            this.gvGroupB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gvGroupB.DataSource = this.bindingSourcePilots;
            this.gvGroupB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupB.Location = new System.Drawing.Point(2, 2);
            this.gvGroupB.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupB.Name = "gvGroupB";
            this.gvGroupB.ReadOnly = true;
            this.gvGroupB.RowTemplate.Height = 24;
            this.gvGroupB.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupB.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn4.HeaderText = "Team";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn5.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // pageGroupC
            // 
            this.pageGroupC.Controls.Add(this.gvGroupC);
            this.pageGroupC.Location = new System.Drawing.Point(4, 22);
            this.pageGroupC.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupC.Name = "pageGroupC";
            this.pageGroupC.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupC.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupC.TabIndex = 2;
            this.pageGroupC.Text = "Group C";
            this.pageGroupC.UseVisualStyleBackColor = true;
            // 
            // gvGroupC
            // 
            this.gvGroupC.AllowUserToAddRows = false;
            this.gvGroupC.AllowUserToDeleteRows = false;
            this.gvGroupC.AutoGenerateColumns = false;
            this.gvGroupC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.gvGroupC.DataSource = this.bindingSourcePilots;
            this.gvGroupC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupC.Location = new System.Drawing.Point(2, 2);
            this.gvGroupC.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupC.Name = "gvGroupC";
            this.gvGroupC.ReadOnly = true;
            this.gvGroupC.RowTemplate.Height = 24;
            this.gvGroupC.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupC.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn11.HeaderText = "Team";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn12.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 300;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn13.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 250;
            // 
            // pageGroupD
            // 
            this.pageGroupD.Controls.Add(this.gvGroupD);
            this.pageGroupD.Location = new System.Drawing.Point(4, 22);
            this.pageGroupD.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupD.Name = "pageGroupD";
            this.pageGroupD.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupD.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupD.TabIndex = 3;
            this.pageGroupD.Text = "Group D";
            this.pageGroupD.UseVisualStyleBackColor = true;
            // 
            // gvGroupD
            // 
            this.gvGroupD.AllowUserToAddRows = false;
            this.gvGroupD.AllowUserToDeleteRows = false;
            this.gvGroupD.AutoGenerateColumns = false;
            this.gvGroupD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.gvGroupD.DataSource = this.bindingSourcePilots;
            this.gvGroupD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupD.Location = new System.Drawing.Point(2, 2);
            this.gvGroupD.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupD.Name = "gvGroupD";
            this.gvGroupD.ReadOnly = true;
            this.gvGroupD.RowTemplate.Height = 24;
            this.gvGroupD.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupD.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn16.HeaderText = "Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 200;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn17.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn18.HeaderText = "Team";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn19.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 300;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn20.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 250;
            // 
            // pageGroupE
            // 
            this.pageGroupE.Controls.Add(this.gvGroupE);
            this.pageGroupE.Location = new System.Drawing.Point(4, 22);
            this.pageGroupE.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupE.Name = "pageGroupE";
            this.pageGroupE.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupE.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupE.TabIndex = 4;
            this.pageGroupE.Text = "Group E";
            this.pageGroupE.UseVisualStyleBackColor = true;
            // 
            // gvGroupE
            // 
            this.gvGroupE.AllowUserToAddRows = false;
            this.gvGroupE.AllowUserToDeleteRows = false;
            this.gvGroupE.AutoGenerateColumns = false;
            this.gvGroupE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27});
            this.gvGroupE.DataSource = this.bindingSourcePilots;
            this.gvGroupE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupE.Location = new System.Drawing.Point(2, 2);
            this.gvGroupE.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupE.Name = "gvGroupE";
            this.gvGroupE.ReadOnly = true;
            this.gvGroupE.RowTemplate.Height = 24;
            this.gvGroupE.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupE.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn23.HeaderText = "Name";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 200;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn24.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn25.HeaderText = "Team";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn26.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 300;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn27.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 250;
            // 
            // pageGroupF
            // 
            this.pageGroupF.Controls.Add(this.gvGroupF);
            this.pageGroupF.Location = new System.Drawing.Point(4, 22);
            this.pageGroupF.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupF.Name = "pageGroupF";
            this.pageGroupF.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupF.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupF.TabIndex = 5;
            this.pageGroupF.Text = "GroupF";
            this.pageGroupF.UseVisualStyleBackColor = true;
            // 
            // gvGroupF
            // 
            this.gvGroupF.AllowUserToAddRows = false;
            this.gvGroupF.AllowUserToDeleteRows = false;
            this.gvGroupF.AutoGenerateColumns = false;
            this.gvGroupF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34});
            this.gvGroupF.DataSource = this.bindingSourcePilots;
            this.gvGroupF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupF.Location = new System.Drawing.Point(2, 2);
            this.gvGroupF.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupF.Name = "gvGroupF";
            this.gvGroupF.ReadOnly = true;
            this.gvGroupF.RowTemplate.Height = 24;
            this.gvGroupF.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupF.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn30.HeaderText = "Name";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 200;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn31.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn32.HeaderText = "Team";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn33.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 300;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn34.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Width = 250;
            // 
            // pageGroupG
            // 
            this.pageGroupG.Controls.Add(this.gvGroupG);
            this.pageGroupG.Location = new System.Drawing.Point(4, 22);
            this.pageGroupG.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupG.Name = "pageGroupG";
            this.pageGroupG.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupG.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupG.TabIndex = 6;
            this.pageGroupG.Text = "Group G";
            this.pageGroupG.UseVisualStyleBackColor = true;
            // 
            // gvGroupG
            // 
            this.gvGroupG.AllowUserToAddRows = false;
            this.gvGroupG.AllowUserToDeleteRows = false;
            this.gvGroupG.AutoGenerateColumns = false;
            this.gvGroupG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41});
            this.gvGroupG.DataSource = this.bindingSourcePilots;
            this.gvGroupG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupG.Location = new System.Drawing.Point(2, 2);
            this.gvGroupG.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupG.Name = "gvGroupG";
            this.gvGroupG.ReadOnly = true;
            this.gvGroupG.RowTemplate.Height = 24;
            this.gvGroupG.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupG.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn37.HeaderText = "Name";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Width = 200;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn38.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn39.HeaderText = "Team";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn40.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 300;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn41.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 250;
            // 
            // pageGroupH
            // 
            this.pageGroupH.Controls.Add(this.gvGroupH);
            this.pageGroupH.Location = new System.Drawing.Point(4, 22);
            this.pageGroupH.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupH.Name = "pageGroupH";
            this.pageGroupH.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupH.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupH.TabIndex = 7;
            this.pageGroupH.Text = "Group H";
            this.pageGroupH.UseVisualStyleBackColor = true;
            // 
            // gvGroupH
            // 
            this.gvGroupH.AllowUserToAddRows = false;
            this.gvGroupH.AllowUserToDeleteRows = false;
            this.gvGroupH.AutoGenerateColumns = false;
            this.gvGroupH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48});
            this.gvGroupH.DataSource = this.bindingSourcePilots;
            this.gvGroupH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupH.Location = new System.Drawing.Point(2, 2);
            this.gvGroupH.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupH.Name = "gvGroupH";
            this.gvGroupH.ReadOnly = true;
            this.gvGroupH.RowTemplate.Height = 24;
            this.gvGroupH.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupH.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn44.HeaderText = "Name";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Width = 200;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn45.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn46.HeaderText = "Team";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn47.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Width = 300;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn48.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Width = 250;
            // 
            // pageGroupI
            // 
            this.pageGroupI.Controls.Add(this.gvGroupI);
            this.pageGroupI.Location = new System.Drawing.Point(4, 22);
            this.pageGroupI.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupI.Name = "pageGroupI";
            this.pageGroupI.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupI.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupI.TabIndex = 8;
            this.pageGroupI.Text = "Group I";
            this.pageGroupI.UseVisualStyleBackColor = true;
            // 
            // gvGroupI
            // 
            this.gvGroupI.AllowUserToAddRows = false;
            this.gvGroupI.AllowUserToDeleteRows = false;
            this.gvGroupI.AutoGenerateColumns = false;
            this.gvGroupI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55});
            this.gvGroupI.DataSource = this.bindingSourcePilots;
            this.gvGroupI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupI.Location = new System.Drawing.Point(2, 2);
            this.gvGroupI.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupI.Name = "gvGroupI";
            this.gvGroupI.ReadOnly = true;
            this.gvGroupI.RowTemplate.Height = 24;
            this.gvGroupI.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupI.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn51.HeaderText = "Name";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Width = 200;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn52.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn53.HeaderText = "Team";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn54.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Width = 300;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn55.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Width = 250;
            // 
            // pageGroupJ
            // 
            this.pageGroupJ.Controls.Add(this.gvGroupJ);
            this.pageGroupJ.Location = new System.Drawing.Point(4, 22);
            this.pageGroupJ.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupJ.Name = "pageGroupJ";
            this.pageGroupJ.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupJ.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupJ.TabIndex = 9;
            this.pageGroupJ.Text = "Group J";
            this.pageGroupJ.UseVisualStyleBackColor = true;
            // 
            // gvGroupJ
            // 
            this.gvGroupJ.AllowUserToAddRows = false;
            this.gvGroupJ.AllowUserToDeleteRows = false;
            this.gvGroupJ.AutoGenerateColumns = false;
            this.gvGroupJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62});
            this.gvGroupJ.DataSource = this.bindingSourcePilots;
            this.gvGroupJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupJ.Location = new System.Drawing.Point(2, 2);
            this.gvGroupJ.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupJ.Name = "gvGroupJ";
            this.gvGroupJ.ReadOnly = true;
            this.gvGroupJ.RowTemplate.Height = 24;
            this.gvGroupJ.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupJ.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn58.HeaderText = "Name";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            this.dataGridViewTextBoxColumn58.Width = 200;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn59.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn60.HeaderText = "Team";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn61.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Width = 300;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn62.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            this.dataGridViewTextBoxColumn62.Width = 250;
            // 
            // pageGroupK
            // 
            this.pageGroupK.Controls.Add(this.gvGroupK);
            this.pageGroupK.Location = new System.Drawing.Point(4, 22);
            this.pageGroupK.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupK.Name = "pageGroupK";
            this.pageGroupK.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupK.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupK.TabIndex = 10;
            this.pageGroupK.Text = "Group K";
            this.pageGroupK.UseVisualStyleBackColor = true;
            // 
            // gvGroupK
            // 
            this.gvGroupK.AllowUserToAddRows = false;
            this.gvGroupK.AllowUserToDeleteRows = false;
            this.gvGroupK.AutoGenerateColumns = false;
            this.gvGroupK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69});
            this.gvGroupK.DataSource = this.bindingSourcePilots;
            this.gvGroupK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupK.Location = new System.Drawing.Point(2, 2);
            this.gvGroupK.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupK.Name = "gvGroupK";
            this.gvGroupK.ReadOnly = true;
            this.gvGroupK.RowTemplate.Height = 24;
            this.gvGroupK.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupK.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn65.HeaderText = "Name";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            this.dataGridViewTextBoxColumn65.Width = 200;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn66.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn67.HeaderText = "Team";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn68.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            this.dataGridViewTextBoxColumn68.Width = 300;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn69.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            this.dataGridViewTextBoxColumn69.Width = 250;
            // 
            // pageGroupL
            // 
            this.pageGroupL.Controls.Add(this.gvGroupL);
            this.pageGroupL.Location = new System.Drawing.Point(4, 22);
            this.pageGroupL.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupL.Name = "pageGroupL";
            this.pageGroupL.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupL.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupL.TabIndex = 11;
            this.pageGroupL.Text = "Group L";
            this.pageGroupL.UseVisualStyleBackColor = true;
            // 
            // gvGroupL
            // 
            this.gvGroupL.AllowUserToAddRows = false;
            this.gvGroupL.AllowUserToDeleteRows = false;
            this.gvGroupL.AutoGenerateColumns = false;
            this.gvGroupL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn72,
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74,
            this.dataGridViewTextBoxColumn75,
            this.dataGridViewTextBoxColumn76});
            this.gvGroupL.DataSource = this.bindingSourcePilots;
            this.gvGroupL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupL.Location = new System.Drawing.Point(2, 2);
            this.gvGroupL.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupL.Name = "gvGroupL";
            this.gvGroupL.ReadOnly = true;
            this.gvGroupL.RowTemplate.Height = 24;
            this.gvGroupL.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupL.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn72.HeaderText = "Name";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            this.dataGridViewTextBoxColumn72.Width = 200;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn73.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn74.HeaderText = "Team";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn75.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.ReadOnly = true;
            this.dataGridViewTextBoxColumn75.Width = 300;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn76.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            this.dataGridViewTextBoxColumn76.Width = 250;
            // 
            // pageGroupM
            // 
            this.pageGroupM.Controls.Add(this.gvGroupM);
            this.pageGroupM.Location = new System.Drawing.Point(4, 22);
            this.pageGroupM.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupM.Name = "pageGroupM";
            this.pageGroupM.Padding = new System.Windows.Forms.Padding(2);
            this.pageGroupM.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupM.TabIndex = 12;
            this.pageGroupM.Text = "Group M";
            this.pageGroupM.UseVisualStyleBackColor = true;
            // 
            // gvGroupM
            // 
            this.gvGroupM.AllowUserToAddRows = false;
            this.gvGroupM.AllowUserToDeleteRows = false;
            this.gvGroupM.AutoGenerateColumns = false;
            this.gvGroupM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn79,
            this.dataGridViewTextBoxColumn80,
            this.dataGridViewTextBoxColumn81,
            this.dataGridViewTextBoxColumn82,
            this.dataGridViewTextBoxColumn83});
            this.gvGroupM.DataSource = this.bindingSourcePilots;
            this.gvGroupM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupM.Location = new System.Drawing.Point(2, 2);
            this.gvGroupM.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupM.Name = "gvGroupM";
            this.gvGroupM.ReadOnly = true;
            this.gvGroupM.RowTemplate.Height = 24;
            this.gvGroupM.Size = new System.Drawing.Size(1006, 120);
            this.gvGroupM.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn79.HeaderText = "Name";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            this.dataGridViewTextBoxColumn79.Width = 200;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn80.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn81.HeaderText = "Team";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            this.dataGridViewTextBoxColumn81.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn82.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            this.dataGridViewTextBoxColumn82.ReadOnly = true;
            this.dataGridViewTextBoxColumn82.Width = 300;
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn83.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            this.dataGridViewTextBoxColumn83.ReadOnly = true;
            this.dataGridViewTextBoxColumn83.Width = 250;
            // 
            // pageGroupN
            // 
            this.pageGroupN.Controls.Add(this.gvGroupN);
            this.pageGroupN.Location = new System.Drawing.Point(4, 22);
            this.pageGroupN.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupN.Name = "pageGroupN";
            this.pageGroupN.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupN.TabIndex = 13;
            this.pageGroupN.Text = "Group N";
            this.pageGroupN.UseVisualStyleBackColor = true;
            // 
            // gvGroupN
            // 
            this.gvGroupN.AllowUserToAddRows = false;
            this.gvGroupN.AllowUserToDeleteRows = false;
            this.gvGroupN.AutoGenerateColumns = false;
            this.gvGroupN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn86,
            this.dataGridViewTextBoxColumn87,
            this.dataGridViewTextBoxColumn88,
            this.dataGridViewTextBoxColumn89,
            this.dataGridViewTextBoxColumn90});
            this.gvGroupN.DataSource = this.bindingSourcePilots;
            this.gvGroupN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupN.Location = new System.Drawing.Point(0, 0);
            this.gvGroupN.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupN.Name = "gvGroupN";
            this.gvGroupN.ReadOnly = true;
            this.gvGroupN.RowTemplate.Height = 24;
            this.gvGroupN.Size = new System.Drawing.Size(1010, 124);
            this.gvGroupN.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn86.HeaderText = "Name";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            this.dataGridViewTextBoxColumn86.ReadOnly = true;
            this.dataGridViewTextBoxColumn86.Width = 200;
            // 
            // dataGridViewTextBoxColumn87
            // 
            this.dataGridViewTextBoxColumn87.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn87.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
            this.dataGridViewTextBoxColumn87.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn88
            // 
            this.dataGridViewTextBoxColumn88.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn88.HeaderText = "Team";
            this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
            this.dataGridViewTextBoxColumn88.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn89.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            this.dataGridViewTextBoxColumn89.ReadOnly = true;
            this.dataGridViewTextBoxColumn89.Width = 300;
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn90.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            this.dataGridViewTextBoxColumn90.ReadOnly = true;
            this.dataGridViewTextBoxColumn90.Width = 250;
            // 
            // pageGroupO
            // 
            this.pageGroupO.Controls.Add(this.gvGroupO);
            this.pageGroupO.Location = new System.Drawing.Point(4, 22);
            this.pageGroupO.Margin = new System.Windows.Forms.Padding(2);
            this.pageGroupO.Name = "pageGroupO";
            this.pageGroupO.Size = new System.Drawing.Size(1010, 124);
            this.pageGroupO.TabIndex = 14;
            this.pageGroupO.Text = "Group O";
            this.pageGroupO.UseVisualStyleBackColor = true;
            // 
            // gvGroupO
            // 
            this.gvGroupO.AllowUserToAddRows = false;
            this.gvGroupO.AllowUserToDeleteRows = false;
            this.gvGroupO.AutoGenerateColumns = false;
            this.gvGroupO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn93,
            this.dataGridViewTextBoxColumn94,
            this.dataGridViewTextBoxColumn95,
            this.dataGridViewTextBoxColumn96,
            this.dataGridViewTextBoxColumn97});
            this.gvGroupO.DataSource = this.bindingSourcePilots;
            this.gvGroupO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupO.Location = new System.Drawing.Point(0, 0);
            this.gvGroupO.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupO.Name = "gvGroupO";
            this.gvGroupO.ReadOnly = true;
            this.gvGroupO.RowTemplate.Height = 24;
            this.gvGroupO.Size = new System.Drawing.Size(1010, 124);
            this.gvGroupO.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn93
            // 
            this.dataGridViewTextBoxColumn93.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn93.HeaderText = "Name";
            this.dataGridViewTextBoxColumn93.Name = "dataGridViewTextBoxColumn93";
            this.dataGridViewTextBoxColumn93.ReadOnly = true;
            this.dataGridViewTextBoxColumn93.Width = 200;
            // 
            // dataGridViewTextBoxColumn94
            // 
            this.dataGridViewTextBoxColumn94.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn94.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn94.Name = "dataGridViewTextBoxColumn94";
            this.dataGridViewTextBoxColumn94.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn95
            // 
            this.dataGridViewTextBoxColumn95.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn95.HeaderText = "Team";
            this.dataGridViewTextBoxColumn95.Name = "dataGridViewTextBoxColumn95";
            this.dataGridViewTextBoxColumn95.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn96
            // 
            this.dataGridViewTextBoxColumn96.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn96.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn96.Name = "dataGridViewTextBoxColumn96";
            this.dataGridViewTextBoxColumn96.ReadOnly = true;
            this.dataGridViewTextBoxColumn96.Width = 300;
            // 
            // dataGridViewTextBoxColumn97
            // 
            this.dataGridViewTextBoxColumn97.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn97.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn97.Name = "dataGridViewTextBoxColumn97";
            this.dataGridViewTextBoxColumn97.ReadOnly = true;
            this.dataGridViewTextBoxColumn97.Width = 250;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.gvGroupP);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1010, 124);
            this.tabPage11.TabIndex = 15;
            this.tabPage11.Text = "Group P";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // gvGroupP
            // 
            this.gvGroupP.AllowUserToAddRows = false;
            this.gvGroupP.AllowUserToDeleteRows = false;
            this.gvGroupP.AutoGenerateColumns = false;
            this.gvGroupP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn158,
            this.dataGridViewTextBoxColumn159,
            this.dataGridViewTextBoxColumn160,
            this.dataGridViewTextBoxColumn161,
            this.dataGridViewTextBoxColumn162});
            this.gvGroupP.DataSource = this.bindingSourcePilots;
            this.gvGroupP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupP.Location = new System.Drawing.Point(3, 3);
            this.gvGroupP.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupP.Name = "gvGroupP";
            this.gvGroupP.ReadOnly = true;
            this.gvGroupP.RowTemplate.Height = 24;
            this.gvGroupP.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupP.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn158
            // 
            this.dataGridViewTextBoxColumn158.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn158.HeaderText = "Name";
            this.dataGridViewTextBoxColumn158.Name = "dataGridViewTextBoxColumn158";
            this.dataGridViewTextBoxColumn158.ReadOnly = true;
            this.dataGridViewTextBoxColumn158.Width = 200;
            // 
            // dataGridViewTextBoxColumn159
            // 
            this.dataGridViewTextBoxColumn159.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn159.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn159.Name = "dataGridViewTextBoxColumn159";
            this.dataGridViewTextBoxColumn159.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn160
            // 
            this.dataGridViewTextBoxColumn160.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn160.HeaderText = "Team";
            this.dataGridViewTextBoxColumn160.Name = "dataGridViewTextBoxColumn160";
            this.dataGridViewTextBoxColumn160.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn161
            // 
            this.dataGridViewTextBoxColumn161.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn161.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn161.Name = "dataGridViewTextBoxColumn161";
            this.dataGridViewTextBoxColumn161.ReadOnly = true;
            this.dataGridViewTextBoxColumn161.Width = 300;
            // 
            // dataGridViewTextBoxColumn162
            // 
            this.dataGridViewTextBoxColumn162.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn162.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn162.Name = "dataGridViewTextBoxColumn162";
            this.dataGridViewTextBoxColumn162.ReadOnly = true;
            this.dataGridViewTextBoxColumn162.Width = 250;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.gvGroupQ);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1010, 124);
            this.tabPage12.TabIndex = 16;
            this.tabPage12.Text = "Group Q";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // gvGroupQ
            // 
            this.gvGroupQ.AllowUserToAddRows = false;
            this.gvGroupQ.AllowUserToDeleteRows = false;
            this.gvGroupQ.AutoGenerateColumns = false;
            this.gvGroupQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn163,
            this.dataGridViewTextBoxColumn164,
            this.dataGridViewTextBoxColumn165,
            this.dataGridViewTextBoxColumn166,
            this.dataGridViewTextBoxColumn167});
            this.gvGroupQ.DataSource = this.bindingSourcePilots;
            this.gvGroupQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupQ.Location = new System.Drawing.Point(3, 3);
            this.gvGroupQ.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupQ.Name = "gvGroupQ";
            this.gvGroupQ.ReadOnly = true;
            this.gvGroupQ.RowTemplate.Height = 24;
            this.gvGroupQ.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupQ.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn163
            // 
            this.dataGridViewTextBoxColumn163.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn163.HeaderText = "Name";
            this.dataGridViewTextBoxColumn163.Name = "dataGridViewTextBoxColumn163";
            this.dataGridViewTextBoxColumn163.ReadOnly = true;
            this.dataGridViewTextBoxColumn163.Width = 200;
            // 
            // dataGridViewTextBoxColumn164
            // 
            this.dataGridViewTextBoxColumn164.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn164.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn164.Name = "dataGridViewTextBoxColumn164";
            this.dataGridViewTextBoxColumn164.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn165
            // 
            this.dataGridViewTextBoxColumn165.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn165.HeaderText = "Team";
            this.dataGridViewTextBoxColumn165.Name = "dataGridViewTextBoxColumn165";
            this.dataGridViewTextBoxColumn165.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn166
            // 
            this.dataGridViewTextBoxColumn166.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn166.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn166.Name = "dataGridViewTextBoxColumn166";
            this.dataGridViewTextBoxColumn166.ReadOnly = true;
            this.dataGridViewTextBoxColumn166.Width = 300;
            // 
            // dataGridViewTextBoxColumn167
            // 
            this.dataGridViewTextBoxColumn167.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn167.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn167.Name = "dataGridViewTextBoxColumn167";
            this.dataGridViewTextBoxColumn167.ReadOnly = true;
            this.dataGridViewTextBoxColumn167.Width = 250;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.gvGroupR);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(1010, 124);
            this.tabPage13.TabIndex = 17;
            this.tabPage13.Text = "Group R";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // gvGroupR
            // 
            this.gvGroupR.AllowUserToAddRows = false;
            this.gvGroupR.AllowUserToDeleteRows = false;
            this.gvGroupR.AutoGenerateColumns = false;
            this.gvGroupR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn168,
            this.dataGridViewTextBoxColumn169,
            this.dataGridViewTextBoxColumn170,
            this.dataGridViewTextBoxColumn171,
            this.dataGridViewTextBoxColumn172});
            this.gvGroupR.DataSource = this.bindingSourcePilots;
            this.gvGroupR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupR.Location = new System.Drawing.Point(3, 3);
            this.gvGroupR.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupR.Name = "gvGroupR";
            this.gvGroupR.ReadOnly = true;
            this.gvGroupR.RowTemplate.Height = 24;
            this.gvGroupR.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupR.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn168
            // 
            this.dataGridViewTextBoxColumn168.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn168.HeaderText = "Name";
            this.dataGridViewTextBoxColumn168.Name = "dataGridViewTextBoxColumn168";
            this.dataGridViewTextBoxColumn168.ReadOnly = true;
            this.dataGridViewTextBoxColumn168.Width = 200;
            // 
            // dataGridViewTextBoxColumn169
            // 
            this.dataGridViewTextBoxColumn169.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn169.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn169.Name = "dataGridViewTextBoxColumn169";
            this.dataGridViewTextBoxColumn169.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn170
            // 
            this.dataGridViewTextBoxColumn170.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn170.HeaderText = "Team";
            this.dataGridViewTextBoxColumn170.Name = "dataGridViewTextBoxColumn170";
            this.dataGridViewTextBoxColumn170.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn171
            // 
            this.dataGridViewTextBoxColumn171.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn171.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn171.Name = "dataGridViewTextBoxColumn171";
            this.dataGridViewTextBoxColumn171.ReadOnly = true;
            this.dataGridViewTextBoxColumn171.Width = 300;
            // 
            // dataGridViewTextBoxColumn172
            // 
            this.dataGridViewTextBoxColumn172.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn172.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn172.Name = "dataGridViewTextBoxColumn172";
            this.dataGridViewTextBoxColumn172.ReadOnly = true;
            this.dataGridViewTextBoxColumn172.Width = 250;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.gvGroupS);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(1010, 124);
            this.tabPage14.TabIndex = 18;
            this.tabPage14.Text = "Group S";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // gvGroupS
            // 
            this.gvGroupS.AllowUserToAddRows = false;
            this.gvGroupS.AllowUserToDeleteRows = false;
            this.gvGroupS.AutoGenerateColumns = false;
            this.gvGroupS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn173,
            this.dataGridViewTextBoxColumn174,
            this.dataGridViewTextBoxColumn175,
            this.dataGridViewTextBoxColumn176,
            this.dataGridViewTextBoxColumn177});
            this.gvGroupS.DataSource = this.bindingSourcePilots;
            this.gvGroupS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupS.Location = new System.Drawing.Point(3, 3);
            this.gvGroupS.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupS.Name = "gvGroupS";
            this.gvGroupS.ReadOnly = true;
            this.gvGroupS.RowTemplate.Height = 24;
            this.gvGroupS.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupS.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn173
            // 
            this.dataGridViewTextBoxColumn173.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn173.HeaderText = "Name";
            this.dataGridViewTextBoxColumn173.Name = "dataGridViewTextBoxColumn173";
            this.dataGridViewTextBoxColumn173.ReadOnly = true;
            this.dataGridViewTextBoxColumn173.Width = 200;
            // 
            // dataGridViewTextBoxColumn174
            // 
            this.dataGridViewTextBoxColumn174.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn174.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn174.Name = "dataGridViewTextBoxColumn174";
            this.dataGridViewTextBoxColumn174.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn175
            // 
            this.dataGridViewTextBoxColumn175.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn175.HeaderText = "Team";
            this.dataGridViewTextBoxColumn175.Name = "dataGridViewTextBoxColumn175";
            this.dataGridViewTextBoxColumn175.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn176
            // 
            this.dataGridViewTextBoxColumn176.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn176.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn176.Name = "dataGridViewTextBoxColumn176";
            this.dataGridViewTextBoxColumn176.ReadOnly = true;
            this.dataGridViewTextBoxColumn176.Width = 300;
            // 
            // dataGridViewTextBoxColumn177
            // 
            this.dataGridViewTextBoxColumn177.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn177.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn177.Name = "dataGridViewTextBoxColumn177";
            this.dataGridViewTextBoxColumn177.ReadOnly = true;
            this.dataGridViewTextBoxColumn177.Width = 250;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.gvGroupT);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(1010, 124);
            this.tabPage15.TabIndex = 19;
            this.tabPage15.Text = "Group T";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // gvGroupT
            // 
            this.gvGroupT.AllowUserToAddRows = false;
            this.gvGroupT.AllowUserToDeleteRows = false;
            this.gvGroupT.AutoGenerateColumns = false;
            this.gvGroupT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn178,
            this.dataGridViewTextBoxColumn179,
            this.dataGridViewTextBoxColumn180,
            this.dataGridViewTextBoxColumn181,
            this.dataGridViewTextBoxColumn182});
            this.gvGroupT.DataSource = this.bindingSourcePilots;
            this.gvGroupT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupT.Location = new System.Drawing.Point(3, 3);
            this.gvGroupT.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupT.Name = "gvGroupT";
            this.gvGroupT.ReadOnly = true;
            this.gvGroupT.RowTemplate.Height = 24;
            this.gvGroupT.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupT.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn178
            // 
            this.dataGridViewTextBoxColumn178.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn178.HeaderText = "Name";
            this.dataGridViewTextBoxColumn178.Name = "dataGridViewTextBoxColumn178";
            this.dataGridViewTextBoxColumn178.ReadOnly = true;
            this.dataGridViewTextBoxColumn178.Width = 200;
            // 
            // dataGridViewTextBoxColumn179
            // 
            this.dataGridViewTextBoxColumn179.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn179.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn179.Name = "dataGridViewTextBoxColumn179";
            this.dataGridViewTextBoxColumn179.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn180
            // 
            this.dataGridViewTextBoxColumn180.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn180.HeaderText = "Team";
            this.dataGridViewTextBoxColumn180.Name = "dataGridViewTextBoxColumn180";
            this.dataGridViewTextBoxColumn180.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn181
            // 
            this.dataGridViewTextBoxColumn181.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn181.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn181.Name = "dataGridViewTextBoxColumn181";
            this.dataGridViewTextBoxColumn181.ReadOnly = true;
            this.dataGridViewTextBoxColumn181.Width = 300;
            // 
            // dataGridViewTextBoxColumn182
            // 
            this.dataGridViewTextBoxColumn182.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn182.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn182.Name = "dataGridViewTextBoxColumn182";
            this.dataGridViewTextBoxColumn182.ReadOnly = true;
            this.dataGridViewTextBoxColumn182.Width = 250;
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.gvGroupU);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(1010, 124);
            this.tabPage16.TabIndex = 20;
            this.tabPage16.Text = "Group U";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // gvGroupU
            // 
            this.gvGroupU.AllowUserToAddRows = false;
            this.gvGroupU.AllowUserToDeleteRows = false;
            this.gvGroupU.AutoGenerateColumns = false;
            this.gvGroupU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn183,
            this.dataGridViewTextBoxColumn184,
            this.dataGridViewTextBoxColumn185,
            this.dataGridViewTextBoxColumn186,
            this.dataGridViewTextBoxColumn187});
            this.gvGroupU.DataSource = this.bindingSourcePilots;
            this.gvGroupU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupU.Location = new System.Drawing.Point(3, 3);
            this.gvGroupU.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupU.Name = "gvGroupU";
            this.gvGroupU.ReadOnly = true;
            this.gvGroupU.RowTemplate.Height = 24;
            this.gvGroupU.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupU.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn183
            // 
            this.dataGridViewTextBoxColumn183.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn183.HeaderText = "Name";
            this.dataGridViewTextBoxColumn183.Name = "dataGridViewTextBoxColumn183";
            this.dataGridViewTextBoxColumn183.ReadOnly = true;
            this.dataGridViewTextBoxColumn183.Width = 200;
            // 
            // dataGridViewTextBoxColumn184
            // 
            this.dataGridViewTextBoxColumn184.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn184.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn184.Name = "dataGridViewTextBoxColumn184";
            this.dataGridViewTextBoxColumn184.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn185
            // 
            this.dataGridViewTextBoxColumn185.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn185.HeaderText = "Team";
            this.dataGridViewTextBoxColumn185.Name = "dataGridViewTextBoxColumn185";
            this.dataGridViewTextBoxColumn185.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn186
            // 
            this.dataGridViewTextBoxColumn186.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn186.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn186.Name = "dataGridViewTextBoxColumn186";
            this.dataGridViewTextBoxColumn186.ReadOnly = true;
            this.dataGridViewTextBoxColumn186.Width = 300;
            // 
            // dataGridViewTextBoxColumn187
            // 
            this.dataGridViewTextBoxColumn187.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn187.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn187.Name = "dataGridViewTextBoxColumn187";
            this.dataGridViewTextBoxColumn187.ReadOnly = true;
            this.dataGridViewTextBoxColumn187.Width = 250;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.gvGroupV);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(1010, 124);
            this.tabPage17.TabIndex = 21;
            this.tabPage17.Text = "Group V";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // gvGroupV
            // 
            this.gvGroupV.AllowUserToAddRows = false;
            this.gvGroupV.AllowUserToDeleteRows = false;
            this.gvGroupV.AutoGenerateColumns = false;
            this.gvGroupV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn188,
            this.dataGridViewTextBoxColumn189,
            this.dataGridViewTextBoxColumn190,
            this.dataGridViewTextBoxColumn191,
            this.dataGridViewTextBoxColumn192});
            this.gvGroupV.DataSource = this.bindingSourcePilots;
            this.gvGroupV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupV.Location = new System.Drawing.Point(3, 3);
            this.gvGroupV.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupV.Name = "gvGroupV";
            this.gvGroupV.ReadOnly = true;
            this.gvGroupV.RowTemplate.Height = 24;
            this.gvGroupV.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn188
            // 
            this.dataGridViewTextBoxColumn188.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn188.HeaderText = "Name";
            this.dataGridViewTextBoxColumn188.Name = "dataGridViewTextBoxColumn188";
            this.dataGridViewTextBoxColumn188.ReadOnly = true;
            this.dataGridViewTextBoxColumn188.Width = 200;
            // 
            // dataGridViewTextBoxColumn189
            // 
            this.dataGridViewTextBoxColumn189.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn189.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn189.Name = "dataGridViewTextBoxColumn189";
            this.dataGridViewTextBoxColumn189.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn190
            // 
            this.dataGridViewTextBoxColumn190.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn190.HeaderText = "Team";
            this.dataGridViewTextBoxColumn190.Name = "dataGridViewTextBoxColumn190";
            this.dataGridViewTextBoxColumn190.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn191
            // 
            this.dataGridViewTextBoxColumn191.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn191.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn191.Name = "dataGridViewTextBoxColumn191";
            this.dataGridViewTextBoxColumn191.ReadOnly = true;
            this.dataGridViewTextBoxColumn191.Width = 300;
            // 
            // dataGridViewTextBoxColumn192
            // 
            this.dataGridViewTextBoxColumn192.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn192.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn192.Name = "dataGridViewTextBoxColumn192";
            this.dataGridViewTextBoxColumn192.ReadOnly = true;
            this.dataGridViewTextBoxColumn192.Width = 250;
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.gvGroupW);
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(1010, 124);
            this.tabPage18.TabIndex = 22;
            this.tabPage18.Text = "Group W";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // gvGroupW
            // 
            this.gvGroupW.AllowUserToAddRows = false;
            this.gvGroupW.AllowUserToDeleteRows = false;
            this.gvGroupW.AutoGenerateColumns = false;
            this.gvGroupW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn193,
            this.dataGridViewTextBoxColumn194,
            this.dataGridViewTextBoxColumn195,
            this.dataGridViewTextBoxColumn196,
            this.dataGridViewTextBoxColumn197});
            this.gvGroupW.DataSource = this.bindingSourcePilots;
            this.gvGroupW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupW.Location = new System.Drawing.Point(3, 3);
            this.gvGroupW.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupW.Name = "gvGroupW";
            this.gvGroupW.ReadOnly = true;
            this.gvGroupW.RowTemplate.Height = 24;
            this.gvGroupW.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupW.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn193
            // 
            this.dataGridViewTextBoxColumn193.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn193.HeaderText = "Name";
            this.dataGridViewTextBoxColumn193.Name = "dataGridViewTextBoxColumn193";
            this.dataGridViewTextBoxColumn193.ReadOnly = true;
            this.dataGridViewTextBoxColumn193.Width = 200;
            // 
            // dataGridViewTextBoxColumn194
            // 
            this.dataGridViewTextBoxColumn194.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn194.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn194.Name = "dataGridViewTextBoxColumn194";
            this.dataGridViewTextBoxColumn194.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn195
            // 
            this.dataGridViewTextBoxColumn195.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn195.HeaderText = "Team";
            this.dataGridViewTextBoxColumn195.Name = "dataGridViewTextBoxColumn195";
            this.dataGridViewTextBoxColumn195.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn196
            // 
            this.dataGridViewTextBoxColumn196.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn196.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn196.Name = "dataGridViewTextBoxColumn196";
            this.dataGridViewTextBoxColumn196.ReadOnly = true;
            this.dataGridViewTextBoxColumn196.Width = 300;
            // 
            // dataGridViewTextBoxColumn197
            // 
            this.dataGridViewTextBoxColumn197.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn197.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn197.Name = "dataGridViewTextBoxColumn197";
            this.dataGridViewTextBoxColumn197.ReadOnly = true;
            this.dataGridViewTextBoxColumn197.Width = 250;
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.gvGroupX);
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage19.Size = new System.Drawing.Size(1010, 124);
            this.tabPage19.TabIndex = 23;
            this.tabPage19.Text = "Group X";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // gvGroupX
            // 
            this.gvGroupX.AllowUserToAddRows = false;
            this.gvGroupX.AllowUserToDeleteRows = false;
            this.gvGroupX.AutoGenerateColumns = false;
            this.gvGroupX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn198,
            this.dataGridViewTextBoxColumn199,
            this.dataGridViewTextBoxColumn200,
            this.dataGridViewTextBoxColumn201,
            this.dataGridViewTextBoxColumn202});
            this.gvGroupX.DataSource = this.bindingSourcePilots;
            this.gvGroupX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupX.Location = new System.Drawing.Point(3, 3);
            this.gvGroupX.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupX.Name = "gvGroupX";
            this.gvGroupX.ReadOnly = true;
            this.gvGroupX.RowTemplate.Height = 24;
            this.gvGroupX.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupX.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn198
            // 
            this.dataGridViewTextBoxColumn198.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn198.HeaderText = "Name";
            this.dataGridViewTextBoxColumn198.Name = "dataGridViewTextBoxColumn198";
            this.dataGridViewTextBoxColumn198.ReadOnly = true;
            this.dataGridViewTextBoxColumn198.Width = 200;
            // 
            // dataGridViewTextBoxColumn199
            // 
            this.dataGridViewTextBoxColumn199.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn199.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn199.Name = "dataGridViewTextBoxColumn199";
            this.dataGridViewTextBoxColumn199.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn200
            // 
            this.dataGridViewTextBoxColumn200.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn200.HeaderText = "Team";
            this.dataGridViewTextBoxColumn200.Name = "dataGridViewTextBoxColumn200";
            this.dataGridViewTextBoxColumn200.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn201
            // 
            this.dataGridViewTextBoxColumn201.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn201.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn201.Name = "dataGridViewTextBoxColumn201";
            this.dataGridViewTextBoxColumn201.ReadOnly = true;
            this.dataGridViewTextBoxColumn201.Width = 300;
            // 
            // dataGridViewTextBoxColumn202
            // 
            this.dataGridViewTextBoxColumn202.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn202.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn202.Name = "dataGridViewTextBoxColumn202";
            this.dataGridViewTextBoxColumn202.ReadOnly = true;
            this.dataGridViewTextBoxColumn202.Width = 250;
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.gvGroupY);
            this.tabPage20.Location = new System.Drawing.Point(4, 22);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage20.Size = new System.Drawing.Size(1010, 124);
            this.tabPage20.TabIndex = 24;
            this.tabPage20.Text = "Group Y";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // gvGroupY
            // 
            this.gvGroupY.AllowUserToAddRows = false;
            this.gvGroupY.AllowUserToDeleteRows = false;
            this.gvGroupY.AutoGenerateColumns = false;
            this.gvGroupY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn203,
            this.dataGridViewTextBoxColumn204,
            this.dataGridViewTextBoxColumn205,
            this.dataGridViewTextBoxColumn206,
            this.dataGridViewTextBoxColumn207});
            this.gvGroupY.DataSource = this.bindingSourcePilots;
            this.gvGroupY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupY.Location = new System.Drawing.Point(3, 3);
            this.gvGroupY.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupY.Name = "gvGroupY";
            this.gvGroupY.ReadOnly = true;
            this.gvGroupY.RowTemplate.Height = 24;
            this.gvGroupY.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupY.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn203
            // 
            this.dataGridViewTextBoxColumn203.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn203.HeaderText = "Name";
            this.dataGridViewTextBoxColumn203.Name = "dataGridViewTextBoxColumn203";
            this.dataGridViewTextBoxColumn203.ReadOnly = true;
            this.dataGridViewTextBoxColumn203.Width = 200;
            // 
            // dataGridViewTextBoxColumn204
            // 
            this.dataGridViewTextBoxColumn204.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn204.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn204.Name = "dataGridViewTextBoxColumn204";
            this.dataGridViewTextBoxColumn204.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn205
            // 
            this.dataGridViewTextBoxColumn205.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn205.HeaderText = "Team";
            this.dataGridViewTextBoxColumn205.Name = "dataGridViewTextBoxColumn205";
            this.dataGridViewTextBoxColumn205.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn206
            // 
            this.dataGridViewTextBoxColumn206.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn206.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn206.Name = "dataGridViewTextBoxColumn206";
            this.dataGridViewTextBoxColumn206.ReadOnly = true;
            this.dataGridViewTextBoxColumn206.Width = 300;
            // 
            // dataGridViewTextBoxColumn207
            // 
            this.dataGridViewTextBoxColumn207.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn207.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn207.Name = "dataGridViewTextBoxColumn207";
            this.dataGridViewTextBoxColumn207.ReadOnly = true;
            this.dataGridViewTextBoxColumn207.Width = 250;
            // 
            // tabPage21
            // 
            this.tabPage21.Controls.Add(this.gvGroupZ);
            this.tabPage21.Location = new System.Drawing.Point(4, 22);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage21.Size = new System.Drawing.Size(1010, 124);
            this.tabPage21.TabIndex = 25;
            this.tabPage21.Text = "Group Z";
            this.tabPage21.UseVisualStyleBackColor = true;
            // 
            // gvGroupZ
            // 
            this.gvGroupZ.AllowUserToAddRows = false;
            this.gvGroupZ.AllowUserToDeleteRows = false;
            this.gvGroupZ.AutoGenerateColumns = false;
            this.gvGroupZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGroupZ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn208,
            this.dataGridViewTextBoxColumn209,
            this.dataGridViewTextBoxColumn210,
            this.dataGridViewTextBoxColumn211,
            this.dataGridViewTextBoxColumn212});
            this.gvGroupZ.DataSource = this.bindingSourcePilots;
            this.gvGroupZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGroupZ.Location = new System.Drawing.Point(3, 3);
            this.gvGroupZ.Margin = new System.Windows.Forms.Padding(2);
            this.gvGroupZ.Name = "gvGroupZ";
            this.gvGroupZ.ReadOnly = true;
            this.gvGroupZ.RowTemplate.Height = 24;
            this.gvGroupZ.Size = new System.Drawing.Size(1004, 118);
            this.gvGroupZ.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn208
            // 
            this.dataGridViewTextBoxColumn208.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn208.HeaderText = "Name";
            this.dataGridViewTextBoxColumn208.Name = "dataGridViewTextBoxColumn208";
            this.dataGridViewTextBoxColumn208.ReadOnly = true;
            this.dataGridViewTextBoxColumn208.Width = 200;
            // 
            // dataGridViewTextBoxColumn209
            // 
            this.dataGridViewTextBoxColumn209.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn209.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn209.Name = "dataGridViewTextBoxColumn209";
            this.dataGridViewTextBoxColumn209.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn210
            // 
            this.dataGridViewTextBoxColumn210.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn210.HeaderText = "Team";
            this.dataGridViewTextBoxColumn210.Name = "dataGridViewTextBoxColumn210";
            this.dataGridViewTextBoxColumn210.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn211
            // 
            this.dataGridViewTextBoxColumn211.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn211.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn211.Name = "dataGridViewTextBoxColumn211";
            this.dataGridViewTextBoxColumn211.ReadOnly = true;
            this.dataGridViewTextBoxColumn211.Width = 300;
            // 
            // dataGridViewTextBoxColumn212
            // 
            this.dataGridViewTextBoxColumn212.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn212.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn212.Name = "dataGridViewTextBoxColumn212";
            this.dataGridViewTextBoxColumn212.ReadOnly = true;
            this.dataGridViewTextBoxColumn212.Width = 250;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24711F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.75288F));
            this.tableLayoutPanel11.Controls.Add(this.groupBox38, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tabControl5, 1, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(2, 626);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1300, 156);
            this.tableLayoutPanel11.TabIndex = 5;
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.btnManAddPilotsToF);
            this.groupBox38.Controls.Add(this.btnAddPilotsToF);
            this.groupBox38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox38.Location = new System.Drawing.Point(3, 3);
            this.groupBox38.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox38.Size = new System.Drawing.Size(271, 150);
            this.groupBox38.TabIndex = 0;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "FINAL";
            // 
            // btnManAddPilotsToF
            // 
            this.btnManAddPilotsToF.Location = new System.Drawing.Point(23, 96);
            this.btnManAddPilotsToF.Name = "btnManAddPilotsToF";
            this.btnManAddPilotsToF.Size = new System.Drawing.Size(208, 36);
            this.btnManAddPilotsToF.TabIndex = 5;
            this.btnManAddPilotsToF.Text = "Manually Add Pilots";
            this.btnManAddPilotsToF.UseVisualStyleBackColor = true;
            this.btnManAddPilotsToF.Click += new System.EventHandler(this.btnManAddPilotsToF_Click);
            // 
            // btnAddPilotsToF
            // 
            this.btnAddPilotsToF.Location = new System.Drawing.Point(26, 38);
            this.btnAddPilotsToF.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPilotsToF.Name = "btnAddPilotsToF";
            this.btnAddPilotsToF.Size = new System.Drawing.Size(205, 36);
            this.btnAddPilotsToF.TabIndex = 2;
            this.btnAddPilotsToF.Text = "Add Pilots to Final Round";
            this.btnAddPilotsToF.UseVisualStyleBackColor = true;
            this.btnAddPilotsToF.Click += new System.EventHandler(this.btnAddPilotsToGroupsF_Click);
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage9);
            this.tabControl5.Controls.Add(this.tabPage10);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(279, 3);
            this.tabControl5.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(1018, 150);
            this.tabControl5.TabIndex = 1;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.gvSmallFinal);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage9.Size = new System.Drawing.Size(1010, 124);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Small Final";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // gvSmallFinal
            // 
            this.gvSmallFinal.AllowUserToAddRows = false;
            this.gvSmallFinal.AutoGenerateColumns = false;
            this.gvSmallFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSmallFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn142,
            this.dataGridViewTextBoxColumn143,
            this.dataGridViewTextBoxColumn144,
            this.dataGridViewTextBoxColumn145,
            this.dataGridViewTextBoxColumn146,
            this.colDel_SFinal});
            this.gvSmallFinal.DataSource = this.bindingSourcePilots;
            this.gvSmallFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSmallFinal.Location = new System.Drawing.Point(2, 2);
            this.gvSmallFinal.Margin = new System.Windows.Forms.Padding(2);
            this.gvSmallFinal.Name = "gvSmallFinal";
            this.gvSmallFinal.RowTemplate.Height = 24;
            this.gvSmallFinal.Size = new System.Drawing.Size(1006, 120);
            this.gvSmallFinal.TabIndex = 0;
            this.gvSmallFinal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvSmallFinal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.gvFinal);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage10.Size = new System.Drawing.Size(1010, 124);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Final";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // gvFinal
            // 
            this.gvFinal.AllowUserToAddRows = false;
            this.gvFinal.AutoGenerateColumns = false;
            this.gvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn149,
            this.dataGridViewTextBoxColumn150,
            this.dataGridViewTextBoxColumn151,
            this.dataGridViewTextBoxColumn152,
            this.dataGridViewTextBoxColumn153,
            this.colDel_Final});
            this.gvFinal.DataSource = this.bindingSourcePilots;
            this.gvFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFinal.Location = new System.Drawing.Point(2, 2);
            this.gvFinal.Margin = new System.Windows.Forms.Padding(2);
            this.gvFinal.Name = "gvFinal";
            this.gvFinal.RowTemplate.Height = 24;
            this.gvFinal.Size = new System.Drawing.Size(1006, 120);
            this.gvFinal.TabIndex = 1;
            this.gvFinal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvFinal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24711F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.75288F));
            this.tableLayoutPanel9.Controls.Add(this.groupBox36, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tabControl3, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 314);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1300, 156);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.btnManAddPilotsToQF);
            this.groupBox36.Controls.Add(this.btnAddPilotsToQF);
            this.groupBox36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox36.Location = new System.Drawing.Point(3, 3);
            this.groupBox36.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox36.Size = new System.Drawing.Size(271, 150);
            this.groupBox36.TabIndex = 0;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "1 / 4   ROUND";
            // 
            // btnManAddPilotsToQF
            // 
            this.btnManAddPilotsToQF.Location = new System.Drawing.Point(23, 88);
            this.btnManAddPilotsToQF.Name = "btnManAddPilotsToQF";
            this.btnManAddPilotsToQF.Size = new System.Drawing.Size(208, 36);
            this.btnManAddPilotsToQF.TabIndex = 4;
            this.btnManAddPilotsToQF.Text = "Manually Add Pilots";
            this.btnManAddPilotsToQF.UseVisualStyleBackColor = true;
            this.btnManAddPilotsToQF.Click += new System.EventHandler(this.btnManAddPilotsToQF_Click);
            // 
            // btnAddPilotsToQF
            // 
            this.btnAddPilotsToQF.Location = new System.Drawing.Point(23, 36);
            this.btnAddPilotsToQF.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPilotsToQF.Name = "btnAddPilotsToQF";
            this.btnAddPilotsToQF.Size = new System.Drawing.Size(208, 36);
            this.btnAddPilotsToQF.TabIndex = 2;
            this.btnAddPilotsToQF.Text = "Add Pilots to 1/4 round";
            this.btnAddPilotsToQF.UseVisualStyleBackColor = true;
            this.btnAddPilotsToQF.Click += new System.EventHandler(this.btnAddPilotsToQF_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(279, 3);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1018, 150);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gvRace13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1010, 124);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Race 13";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gvRace13
            // 
            this.gvRace13.AllowUserToAddRows = false;
            this.gvRace13.AutoGenerateColumns = false;
            this.gvRace13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace13.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn100,
            this.dataGridViewTextBoxColumn101,
            this.dataGridViewTextBoxColumn102,
            this.dataGridViewTextBoxColumn103,
            this.dataGridViewTextBoxColumn104,
            this.colDel_Race13});
            this.gvRace13.DataSource = this.bindingSourcePilots;
            this.gvRace13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace13.Location = new System.Drawing.Point(2, 2);
            this.gvRace13.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace13.Name = "gvRace13";
            this.gvRace13.RowTemplate.Height = 24;
            this.gvRace13.Size = new System.Drawing.Size(1006, 120);
            this.gvRace13.TabIndex = 0;
            this.gvRace13.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gvRace14);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1010, 124);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Race 14";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gvRace14
            // 
            this.gvRace14.AllowUserToAddRows = false;
            this.gvRace14.AutoGenerateColumns = false;
            this.gvRace14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace14.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn107,
            this.dataGridViewTextBoxColumn108,
            this.dataGridViewTextBoxColumn109,
            this.dataGridViewTextBoxColumn110,
            this.dataGridViewTextBoxColumn111,
            this.colDel_Race14});
            this.gvRace14.DataSource = this.bindingSourcePilots;
            this.gvRace14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace14.Location = new System.Drawing.Point(2, 2);
            this.gvRace14.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace14.Name = "gvRace14";
            this.gvRace14.RowTemplate.Height = 24;
            this.gvRace14.Size = new System.Drawing.Size(1006, 120);
            this.gvRace14.TabIndex = 1;
            this.gvRace14.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gvRace15);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1010, 124);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Race 15";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gvRace15
            // 
            this.gvRace15.AllowUserToAddRows = false;
            this.gvRace15.AutoGenerateColumns = false;
            this.gvRace15.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace15.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn114,
            this.dataGridViewTextBoxColumn115,
            this.dataGridViewTextBoxColumn116,
            this.dataGridViewTextBoxColumn117,
            this.dataGridViewTextBoxColumn118,
            this.colDel_Race15});
            this.gvRace15.DataSource = this.bindingSourcePilots;
            this.gvRace15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace15.Location = new System.Drawing.Point(2, 2);
            this.gvRace15.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace15.Name = "gvRace15";
            this.gvRace15.RowTemplate.Height = 24;
            this.gvRace15.Size = new System.Drawing.Size(1006, 120);
            this.gvRace15.TabIndex = 1;
            this.gvRace15.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.gvRace16);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(1010, 124);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Race 16";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // gvRace16
            // 
            this.gvRace16.AllowUserToAddRows = false;
            this.gvRace16.AutoGenerateColumns = false;
            this.gvRace16.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace16.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn121,
            this.dataGridViewTextBoxColumn122,
            this.dataGridViewTextBoxColumn123,
            this.dataGridViewTextBoxColumn124,
            this.dataGridViewTextBoxColumn125,
            this.colDel_Race16});
            this.gvRace16.DataSource = this.bindingSourcePilots;
            this.gvRace16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRace16.Location = new System.Drawing.Point(2, 2);
            this.gvRace16.Margin = new System.Windows.Forms.Padding(2);
            this.gvRace16.Name = "gvRace16";
            this.gvRace16.RowTemplate.Height = 24;
            this.gvRace16.Size = new System.Drawing.Size(1006, 120);
            this.gvRace16.TabIndex = 1;
            this.gvRace16.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvRace16.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24711F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.75288F));
            this.tableLayoutPanel10.Controls.Add(this.groupBox37, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tabControl4, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(2, 470);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1300, 156);
            this.tableLayoutPanel10.TabIndex = 4;
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.btnManAddPilotsToSF);
            this.groupBox37.Controls.Add(this.btnAddPilotsToSF);
            this.groupBox37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox37.Location = new System.Drawing.Point(3, 3);
            this.groupBox37.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox37.Size = new System.Drawing.Size(271, 150);
            this.groupBox37.TabIndex = 0;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "SEMI FINAL";
            // 
            // btnManAddPilotsToSF
            // 
            this.btnManAddPilotsToSF.Location = new System.Drawing.Point(23, 93);
            this.btnManAddPilotsToSF.Name = "btnManAddPilotsToSF";
            this.btnManAddPilotsToSF.Size = new System.Drawing.Size(208, 36);
            this.btnManAddPilotsToSF.TabIndex = 4;
            this.btnManAddPilotsToSF.Text = "Manually Add Pilots";
            this.btnManAddPilotsToSF.UseVisualStyleBackColor = true;
            this.btnManAddPilotsToSF.Click += new System.EventHandler(this.btnManAddPilotsToSF_Click);
            // 
            // btnAddPilotsToSF
            // 
            this.btnAddPilotsToSF.Location = new System.Drawing.Point(23, 40);
            this.btnAddPilotsToSF.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPilotsToSF.Name = "btnAddPilotsToSF";
            this.btnAddPilotsToSF.Size = new System.Drawing.Size(208, 36);
            this.btnAddPilotsToSF.TabIndex = 2;
            this.btnAddPilotsToSF.Text = "Add Pilots to Semi Final";
            this.btnAddPilotsToSF.UseVisualStyleBackColor = true;
            this.btnAddPilotsToSF.Click += new System.EventHandler(this.btnAddPilotsToGroupsSF_Click);
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage7);
            this.tabControl4.Controls.Add(this.tabPage8);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(279, 3);
            this.tabControl4.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1018, 150);
            this.tabControl4.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.gvSemi1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage7.Size = new System.Drawing.Size(1010, 124);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Semi 1";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // gvSemi1
            // 
            this.gvSemi1.AllowUserToAddRows = false;
            this.gvSemi1.AutoGenerateColumns = false;
            this.gvSemi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSemi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn128,
            this.dataGridViewTextBoxColumn129,
            this.dataGridViewTextBoxColumn130,
            this.dataGridViewTextBoxColumn131,
            this.dataGridViewTextBoxColumn132,
            this.colDel_Semi1});
            this.gvSemi1.DataSource = this.bindingSourcePilots;
            this.gvSemi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSemi1.Location = new System.Drawing.Point(2, 2);
            this.gvSemi1.Margin = new System.Windows.Forms.Padding(2);
            this.gvSemi1.Name = "gvSemi1";
            this.gvSemi1.RowTemplate.Height = 24;
            this.gvSemi1.Size = new System.Drawing.Size(1006, 120);
            this.gvSemi1.TabIndex = 0;
            this.gvSemi1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvSemi1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.gvSemi2);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage8.Size = new System.Drawing.Size(1010, 124);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Semi 2";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // gvSemi2
            // 
            this.gvSemi2.AllowUserToAddRows = false;
            this.gvSemi2.AutoGenerateColumns = false;
            this.gvSemi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSemi2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn135,
            this.dataGridViewTextBoxColumn136,
            this.dataGridViewTextBoxColumn137,
            this.dataGridViewTextBoxColumn138,
            this.dataGridViewTextBoxColumn139,
            this.colDel_Semi2});
            this.gvSemi2.DataSource = this.bindingSourcePilots;
            this.gvSemi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSemi2.Location = new System.Drawing.Point(2, 2);
            this.gvSemi2.Margin = new System.Windows.Forms.Padding(2);
            this.gvSemi2.Name = "gvSemi2";
            this.gvSemi2.RowTemplate.Height = 24;
            this.gvSemi2.Size = new System.Drawing.Size(1006, 120);
            this.gvSemi2.TabIndex = 1;
            this.gvSemi2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellClick);
            this.gvSemi2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRace_KeyUp);
            // 
            // tabRace
            // 
            this.tabRace.Controls.Add(this.gvRace);
            this.tabRace.Controls.Add(this.groupBox35);
            this.tabRace.Controls.Add(this.groupBox34);
            this.tabRace.Controls.Add(this.groupBox33);
            this.tabRace.Controls.Add(this.groupBox32);
            this.tabRace.Controls.Add(this.groupBox31);
            this.tabRace.Controls.Add(this.tableLayoutPanel6);
            this.tabRace.Controls.Add(this.tableLayoutPanel5);
            this.tabRace.Location = new System.Drawing.Point(4, 22);
            this.tabRace.Margin = new System.Windows.Forms.Padding(2);
            this.tabRace.Name = "tabRace";
            this.tabRace.Padding = new System.Windows.Forms.Padding(2);
            this.tabRace.Size = new System.Drawing.Size(1331, 627);
            this.tabRace.TabIndex = 4;
            this.tabRace.Text = "Race Management";
            this.tabRace.UseVisualStyleBackColor = true;
            // 
            // gvRace
            // 
            this.gvRace.AllowUserToAddRows = false;
            this.gvRace.AllowUserToDeleteRows = false;
            this.gvRace.AutoGenerateColumns = false;
            this.gvRace.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvRace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.PilotName,
            this.Epc,
            this.IdentCount,
            this.dataGridViewTextBoxColumn155,
            this.dataGridViewTextBoxColumn156,
            this.Lap1,
            this.Lap2,
            this.Lap3,
            this.Lap4,
            this.Lap5,
            this.Lap6,
            this.TimeDifferential,
            this.BestLapTime,
            this.AvgLapTime,
            this.AverageSpeed,
            this.RegisteredLapsCount,
            this.dataGridViewTextBoxColumn253,
            this.Distance,
            this.Penalty});
            this.gvRace.DataSource = this.bindingSourceRace;
            this.gvRace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvRace.Location = new System.Drawing.Point(2, 305);
            this.gvRace.Name = "gvRace";
            this.gvRace.Size = new System.Drawing.Size(1002, 320);
            this.gvRace.TabIndex = 7;
            this.gvRace.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRace_CellEndEdit);
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "#";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Width = 40;
            // 
            // PilotName
            // 
            this.PilotName.DataPropertyName = "PilotName";
            this.PilotName.HeaderText = "Name";
            this.PilotName.Name = "PilotName";
            this.PilotName.Width = 130;
            // 
            // Epc
            // 
            this.Epc.DataPropertyName = "Epc";
            this.Epc.HeaderText = "TAG ID";
            this.Epc.Name = "Epc";
            this.Epc.Width = 75;
            // 
            // IdentCount
            // 
            this.IdentCount.DataPropertyName = "IdCount";
            this.IdentCount.HeaderText = "ID Count";
            this.IdentCount.Name = "IdentCount";
            this.IdentCount.Width = 75;
            // 
            // dataGridViewTextBoxColumn155
            // 
            this.dataGridViewTextBoxColumn155.DataPropertyName = "Rssi";
            this.dataGridViewTextBoxColumn155.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn155.Name = "dataGridViewTextBoxColumn155";
            this.dataGridViewTextBoxColumn155.Width = 70;
            // 
            // dataGridViewTextBoxColumn156
            // 
            this.dataGridViewTextBoxColumn156.DataPropertyName = "CarrFrequency";
            this.dataGridViewTextBoxColumn156.HeaderText = "Freq";
            this.dataGridViewTextBoxColumn156.Name = "dataGridViewTextBoxColumn156";
            this.dataGridViewTextBoxColumn156.Width = 50;
            // 
            // Lap1
            // 
            this.Lap1.DataPropertyName = "Lap1";
            this.Lap1.HeaderText = "LAP1";
            this.Lap1.Name = "Lap1";
            this.Lap1.Width = 80;
            // 
            // Lap2
            // 
            this.Lap2.DataPropertyName = "Lap2";
            this.Lap2.HeaderText = "LAP2";
            this.Lap2.Name = "Lap2";
            this.Lap2.Width = 80;
            // 
            // Lap3
            // 
            this.Lap3.DataPropertyName = "Lap3";
            this.Lap3.HeaderText = "LAP3";
            this.Lap3.Name = "Lap3";
            this.Lap3.Width = 80;
            // 
            // Lap4
            // 
            this.Lap4.DataPropertyName = "Lap4";
            this.Lap4.HeaderText = "LAP4";
            this.Lap4.Name = "Lap4";
            this.Lap4.Width = 80;
            // 
            // Lap5
            // 
            this.Lap5.DataPropertyName = "Lap5";
            this.Lap5.HeaderText = "LAP5";
            this.Lap5.Name = "Lap5";
            this.Lap5.Width = 80;
            // 
            // Lap6
            // 
            this.Lap6.DataPropertyName = "Lap6";
            this.Lap6.HeaderText = "LAP6";
            this.Lap6.Name = "Lap6";
            this.Lap6.Width = 80;
            // 
            // TimeDifferential
            // 
            this.TimeDifferential.DataPropertyName = "TimeDifferential";
            this.TimeDifferential.HeaderText = "Time Diff";
            this.TimeDifferential.Name = "TimeDifferential";
            // 
            // BestLapTime
            // 
            this.BestLapTime.DataPropertyName = "BestLapTimeString";
            this.BestLapTime.HeaderText = "Best Lap";
            this.BestLapTime.Name = "BestLapTime";
            this.BestLapTime.ReadOnly = true;
            this.BestLapTime.Width = 80;
            // 
            // AvgLapTime
            // 
            this.AvgLapTime.DataPropertyName = "AvgLapTimeString";
            this.AvgLapTime.HeaderText = "Average";
            this.AvgLapTime.Name = "AvgLapTime";
            this.AvgLapTime.ReadOnly = true;
            this.AvgLapTime.Width = 80;
            // 
            // AverageSpeed
            // 
            this.AverageSpeed.DataPropertyName = "AvgSpeedString";
            this.AverageSpeed.HeaderText = "Avg Speed, km/h";
            this.AverageSpeed.Name = "AverageSpeed";
            this.AverageSpeed.ReadOnly = true;
            // 
            // RegisteredLapsCount
            // 
            this.RegisteredLapsCount.DataPropertyName = "RegisteredLapsCount";
            this.RegisteredLapsCount.HeaderText = "Laps";
            this.RegisteredLapsCount.Name = "RegisteredLapsCount";
            this.RegisteredLapsCount.ReadOnly = true;
            this.RegisteredLapsCount.Width = 50;
            // 
            // dataGridViewTextBoxColumn253
            // 
            this.dataGridViewTextBoxColumn253.DataPropertyName = "CurrentPosition";
            this.dataGridViewTextBoxColumn253.HeaderText = "Position";
            this.dataGridViewTextBoxColumn253.Name = "dataGridViewTextBoxColumn253";
            this.dataGridViewTextBoxColumn253.Width = 60;
            // 
            // Distance
            // 
            this.Distance.DataPropertyName = "Distance";
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            this.Distance.Width = 80;
            // 
            // Penalty
            // 
            this.Penalty.DataPropertyName = "Penalty";
            this.Penalty.HeaderText = "Penalty";
            this.Penalty.Name = "Penalty";
            this.Penalty.Width = 70;
            // 
            // bindingSourceRace
            // 
            this.bindingSourceRace.DataSource = typeof(RaceManager.Data.LapsInfo);
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.gvRanking);
            this.groupBox35.Controls.Add(this.cmbDisplayRanking);
            this.groupBox35.Controls.Add(this.label20);
            this.groupBox35.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox35.Location = new System.Drawing.Point(1004, 2);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(325, 623);
            this.groupBox35.TabIndex = 6;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Race Ranking (Qualification rounds)";
            // 
            // gvRanking
            // 
            this.gvRanking.AllowUserToAddRows = false;
            this.gvRanking.AllowUserToDeleteRows = false;
            this.gvRanking.AutoGenerateColumns = false;
            this.gvRanking.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankNumber,
            this.pilotNameDataGridViewTextBoxColumn,
            this.bestLapTimeStringDataGridViewTextBoxColumn,
            this.avgLapTimeStringDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn157});
            this.gvRanking.DataSource = this.bindingSourceRanking;
            this.gvRanking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvRanking.Location = new System.Drawing.Point(3, 60);
            this.gvRanking.Name = "gvRanking";
            this.gvRanking.ReadOnly = true;
            this.gvRanking.Size = new System.Drawing.Size(319, 560);
            this.gvRanking.TabIndex = 7;
            // 
            // RankNumber
            // 
            this.RankNumber.DataPropertyName = "RankNumber";
            this.RankNumber.HeaderText = "#";
            this.RankNumber.Name = "RankNumber";
            this.RankNumber.ReadOnly = true;
            this.RankNumber.Width = 40;
            // 
            // pilotNameDataGridViewTextBoxColumn
            // 
            this.pilotNameDataGridViewTextBoxColumn.DataPropertyName = "PilotName";
            this.pilotNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pilotNameDataGridViewTextBoxColumn.Name = "pilotNameDataGridViewTextBoxColumn";
            this.pilotNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pilotNameDataGridViewTextBoxColumn.Width = 105;
            // 
            // bestLapTimeStringDataGridViewTextBoxColumn
            // 
            this.bestLapTimeStringDataGridViewTextBoxColumn.DataPropertyName = "BestLapTimeString";
            this.bestLapTimeStringDataGridViewTextBoxColumn.HeaderText = "Best Lap";
            this.bestLapTimeStringDataGridViewTextBoxColumn.Name = "bestLapTimeStringDataGridViewTextBoxColumn";
            this.bestLapTimeStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.bestLapTimeStringDataGridViewTextBoxColumn.Width = 90;
            // 
            // avgLapTimeStringDataGridViewTextBoxColumn
            // 
            this.avgLapTimeStringDataGridViewTextBoxColumn.DataPropertyName = "AvgLapTimeString";
            this.avgLapTimeStringDataGridViewTextBoxColumn.HeaderText = "Average Top 3";
            this.avgLapTimeStringDataGridViewTextBoxColumn.Name = "avgLapTimeStringDataGridViewTextBoxColumn";
            this.avgLapTimeStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.avgLapTimeStringDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn157
            // 
            this.dataGridViewTextBoxColumn157.DataPropertyName = "RegisteredLapsCount";
            this.dataGridViewTextBoxColumn157.HeaderText = "Laps";
            this.dataGridViewTextBoxColumn157.Name = "dataGridViewTextBoxColumn157";
            this.dataGridViewTextBoxColumn157.ReadOnly = true;
            this.dataGridViewTextBoxColumn157.Width = 50;
            // 
            // bindingSourceRanking
            // 
            this.bindingSourceRanking.DataSource = typeof(RaceManager.Data.LapsInfo);
            // 
            // cmbDisplayRanking
            // 
            this.cmbDisplayRanking.FormattingEnabled = true;
            this.cmbDisplayRanking.Items.AddRange(new object[] {
            "Best Lap Times",
            "Average Time Top 3"});
            this.cmbDisplayRanking.Location = new System.Drawing.Point(110, 33);
            this.cmbDisplayRanking.Name = "cmbDisplayRanking";
            this.cmbDisplayRanking.Size = new System.Drawing.Size(209, 21);
            this.cmbDisplayRanking.TabIndex = 7;
            this.cmbDisplayRanking.SelectedIndexChanged += new System.EventHandler(this.cmbDisplayRanking_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Display Ranking by";
            // 
            // groupBox34
            // 
            this.groupBox34.Location = new System.Drawing.Point(-32, -98);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(200, 100);
            this.groupBox34.TabIndex = 5;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "groupBox34";
            // 
            // groupBox33
            // 
            this.groupBox33.Location = new System.Drawing.Point(-32, -98);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(200, 100);
            this.groupBox33.TabIndex = 4;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "groupBox33";
            // 
            // groupBox32
            // 
            this.groupBox32.Location = new System.Drawing.Point(-32, -98);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(200, 100);
            this.groupBox32.TabIndex = 3;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "groupBox32";
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.btnReflight);
            this.groupBox31.Controls.Add(this.btnRaceSave);
            this.groupBox31.Controls.Add(this.tbCurEvGroup);
            this.groupBox31.Controls.Add(this.tbCurEvRound);
            this.groupBox31.Location = new System.Drawing.Point(2, 199);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(1000, 100);
            this.groupBox31.TabIndex = 2;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Current Event";
            // 
            // btnReflight
            // 
            this.btnReflight.Enabled = false;
            this.btnReflight.Location = new System.Drawing.Point(709, 38);
            this.btnReflight.Margin = new System.Windows.Forms.Padding(2);
            this.btnReflight.Name = "btnReflight";
            this.btnReflight.Size = new System.Drawing.Size(187, 35);
            this.btnReflight.TabIndex = 3;
            this.btnReflight.Text = "Re-flight";
            this.btnReflight.UseVisualStyleBackColor = true;
            this.btnReflight.Click += new System.EventHandler(this.btnReflight_Click);
            // 
            // btnRaceSave
            // 
            this.btnRaceSave.Enabled = false;
            this.btnRaceSave.Location = new System.Drawing.Point(483, 38);
            this.btnRaceSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaceSave.Name = "btnRaceSave";
            this.btnRaceSave.Size = new System.Drawing.Size(187, 35);
            this.btnRaceSave.TabIndex = 2;
            this.btnRaceSave.Text = "Confirm and Save to DB";
            this.btnRaceSave.UseVisualStyleBackColor = true;
            this.btnRaceSave.Click += new System.EventHandler(this.btnRaceSave_Click);
            // 
            // tbCurEvGroup
            // 
            this.tbCurEvGroup.Enabled = false;
            this.tbCurEvGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbCurEvGroup.Location = new System.Drawing.Point(253, 38);
            this.tbCurEvGroup.Name = "tbCurEvGroup";
            this.tbCurEvGroup.Size = new System.Drawing.Size(176, 35);
            this.tbCurEvGroup.TabIndex = 1;
            this.tbCurEvGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCurEvRound
            // 
            this.tbCurEvRound.Enabled = false;
            this.tbCurEvRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbCurEvRound.Location = new System.Drawing.Point(26, 38);
            this.tbCurEvRound.Name = "tbCurEvRound";
            this.tbCurEvRound.Size = new System.Drawing.Size(176, 35);
            this.tbCurEvRound.TabIndex = 0;
            this.tbCurEvRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.24351F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9481F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.21522F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.83083F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox22, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox24, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox25, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.gbMimicRace, 3, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 89);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1000, 104);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.button2);
            this.groupBox22.Controls.Add(this.button1);
            this.groupBox22.Controls.Add(this.btnRaceExport);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox22.Location = new System.Drawing.Point(542, 3);
            this.groupBox22.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox22.Size = new System.Drawing.Size(147, 98);
            this.groupBox22.TabIndex = 3;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Export Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "CloudLink";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export to PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRaceExport
            // 
            this.btnRaceExport.Location = new System.Drawing.Point(26, 18);
            this.btnRaceExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaceExport.Name = "btnRaceExport";
            this.btnRaceExport.Size = new System.Drawing.Size(96, 20);
            this.btnRaceExport.TabIndex = 3;
            this.btnRaceExport.Text = "Export to CSV";
            this.btnRaceExport.UseVisualStyleBackColor = true;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.btnRaceReset);
            this.groupBox24.Controls.Add(this.btnRaceStop);
            this.groupBox24.Controls.Add(this.btnRaceStart);
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox24.Location = new System.Drawing.Point(3, 3);
            this.groupBox24.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox24.Size = new System.Drawing.Size(276, 98);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Race Control";
            // 
            // btnRaceReset
            // 
            this.btnRaceReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRaceReset.Location = new System.Drawing.Point(174, 58);
            this.btnRaceReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaceReset.Name = "btnRaceReset";
            this.btnRaceReset.Size = new System.Drawing.Size(88, 29);
            this.btnRaceReset.TabIndex = 2;
            this.btnRaceReset.Text = "RESET";
            this.btnRaceReset.UseVisualStyleBackColor = true;
            this.btnRaceReset.Click += new System.EventHandler(this.btnRaceReset_Click);
            // 
            // btnRaceStop
            // 
            this.btnRaceStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRaceStop.Location = new System.Drawing.Point(174, 18);
            this.btnRaceStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaceStop.Name = "btnRaceStop";
            this.btnRaceStop.Size = new System.Drawing.Size(88, 29);
            this.btnRaceStop.TabIndex = 1;
            this.btnRaceStop.Text = "STOP";
            this.btnRaceStop.UseVisualStyleBackColor = true;
            this.btnRaceStop.Click += new System.EventHandler(this.btnRaceStop_Click);
            // 
            // btnRaceStart
            // 
            this.btnRaceStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRaceStart.Location = new System.Drawing.Point(10, 18);
            this.btnRaceStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaceStart.Name = "btnRaceStart";
            this.btnRaceStart.Size = new System.Drawing.Size(146, 70);
            this.btnRaceStart.TabIndex = 0;
            this.btnRaceStart.Text = "START";
            this.btnRaceStart.UseVisualStyleBackColor = true;
            this.btnRaceStart.Click += new System.EventHandler(this.btnRaceStart_Click);
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.label71);
            this.groupBox25.Controls.Add(this.label38);
            this.groupBox25.Controls.Add(this.label21);
            this.groupBox25.Controls.Add(this.lblRaceMilliSeconds);
            this.groupBox25.Controls.Add(this.label39);
            this.groupBox25.Controls.Add(this.lblRaceSeconds);
            this.groupBox25.Controls.Add(this.label34);
            this.groupBox25.Controls.Add(this.lblRaceMinutes);
            this.groupBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox25.Location = new System.Drawing.Point(284, 3);
            this.groupBox25.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox25.Size = new System.Drawing.Size(253, 98);
            this.groupBox25.TabIndex = 1;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Race Time";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label71.Location = new System.Drawing.Point(175, 72);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(48, 9);
            this.label71.TabIndex = 7;
            this.label71.Text = "milliseconds";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label38.Location = new System.Drawing.Point(100, 72);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(33, 9);
            this.label38.TabIndex = 6;
            this.label38.Text = "seconds";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label21.Location = new System.Drawing.Point(35, 72);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 9);
            this.label21.TabIndex = 5;
            this.label21.Text = "minutes";
            // 
            // lblRaceMilliSeconds
            // 
            this.lblRaceMilliSeconds.AutoSize = true;
            this.lblRaceMilliSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceMilliSeconds.Location = new System.Drawing.Point(161, 32);
            this.lblRaceMilliSeconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaceMilliSeconds.Name = "lblRaceMilliSeconds";
            this.lblRaceMilliSeconds.Size = new System.Drawing.Size(71, 37);
            this.lblRaceMilliSeconds.TabIndex = 4;
            this.lblRaceMilliSeconds.Text = "000";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label39.Location = new System.Drawing.Point(138, 32);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(19, 29);
            this.label39.TabIndex = 3;
            this.label39.Text = ":";
            // 
            // lblRaceSeconds
            // 
            this.lblRaceSeconds.AutoSize = true;
            this.lblRaceSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceSeconds.Location = new System.Drawing.Point(90, 32);
            this.lblRaceSeconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaceSeconds.Name = "lblRaceSeconds";
            this.lblRaceSeconds.Size = new System.Drawing.Size(53, 37);
            this.lblRaceSeconds.TabIndex = 2;
            this.lblRaceSeconds.Text = "00";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label34.Location = new System.Drawing.Point(70, 32);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 29);
            this.label34.TabIndex = 1;
            this.label34.Text = ":";
            // 
            // lblRaceMinutes
            // 
            this.lblRaceMinutes.AutoSize = true;
            this.lblRaceMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceMinutes.Location = new System.Drawing.Point(23, 32);
            this.lblRaceMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaceMinutes.Name = "lblRaceMinutes";
            this.lblRaceMinutes.Size = new System.Drawing.Size(53, 37);
            this.lblRaceMinutes.TabIndex = 0;
            this.lblRaceMinutes.Text = "00";
            // 
            // gbMimicRace
            // 
            this.gbMimicRace.Controls.Add(this.label121);
            this.gbMimicRace.Controls.Add(this.label120);
            this.gbMimicRace.Controls.Add(this.tbMimicName);
            this.gbMimicRace.Controls.Add(this.tbMimicLocation);
            this.gbMimicRace.Location = new System.Drawing.Point(695, 4);
            this.gbMimicRace.Name = "gbMimicRace";
            this.gbMimicRace.Size = new System.Drawing.Size(301, 96);
            this.gbMimicRace.TabIndex = 4;
            this.gbMimicRace.TabStop = false;
            this.gbMimicRace.Text = "Race Information";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(28, 62);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(51, 13);
            this.label121.TabIndex = 3;
            this.label121.Text = "Location:";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(11, 33);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(69, 13);
            this.label120.TabIndex = 2;
            this.label120.Text = "Event Name:";
            // 
            // tbMimicName
            // 
            this.tbMimicName.Enabled = false;
            this.tbMimicName.Location = new System.Drawing.Point(85, 55);
            this.tbMimicName.Name = "tbMimicName";
            this.tbMimicName.Size = new System.Drawing.Size(196, 20);
            this.tbMimicName.TabIndex = 1;
            // 
            // tbMimicLocation
            // 
            this.tbMimicLocation.Enabled = false;
            this.tbMimicLocation.Location = new System.Drawing.Point(84, 30);
            this.tbMimicLocation.Name = "tbMimicLocation";
            this.tbMimicLocation.Size = new System.Drawing.Size(197, 20);
            this.tbMimicLocation.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.98119F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.0188F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox12, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1003, 84);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label118);
            this.groupBox9.Controls.Add(this.cmbRaceMode);
            this.groupBox9.Controls.Add(this.tbRaceMaxRssi);
            this.groupBox9.Controls.Add(this.tbRaceMinRssi);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.cbRaceAnt1);
            this.groupBox9.Controls.Add(this.cbRaceAnt4);
            this.groupBox9.Controls.Add(this.cbRaceAnt2);
            this.groupBox9.Controls.Add(this.cbRaceAnt3);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(685, 78);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Antenna Selection";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(496, 34);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(34, 13);
            this.label118.TabIndex = 47;
            this.label118.Text = "Mode";
            // 
            // cmbRaceMode
            // 
            this.cmbRaceMode.FormattingEnabled = true;
            this.cmbRaceMode.Items.AddRange(new object[] {
            "Real Time",
            "Fast Switch Antenna"});
            this.cmbRaceMode.Location = new System.Drawing.Point(534, 31);
            this.cmbRaceMode.Name = "cmbRaceMode";
            this.cmbRaceMode.Size = new System.Drawing.Size(121, 21);
            this.cmbRaceMode.TabIndex = 46;
            // 
            // tbRaceMaxRssi
            // 
            this.tbRaceMaxRssi.Location = new System.Drawing.Point(409, 32);
            this.tbRaceMaxRssi.Name = "tbRaceMaxRssi";
            this.tbRaceMaxRssi.ReadOnly = true;
            this.tbRaceMaxRssi.Size = new System.Drawing.Size(62, 20);
            this.tbRaceMaxRssi.TabIndex = 44;
            this.tbRaceMaxRssi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRaceMinRssi
            // 
            this.tbRaceMinRssi.Location = new System.Drawing.Point(276, 31);
            this.tbRaceMinRssi.Name = "tbRaceMinRssi";
            this.tbRaceMinRssi.ReadOnly = true;
            this.tbRaceMinRssi.Size = new System.Drawing.Size(62, 20);
            this.tbRaceMinRssi.TabIndex = 45;
            this.tbRaceMinRssi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(351, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Max RSSI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(219, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Min RSSI:";
            // 
            // cbRaceAnt1
            // 
            this.cbRaceAnt1.AutoSize = true;
            this.cbRaceAnt1.Checked = true;
            this.cbRaceAnt1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRaceAnt1.Location = new System.Drawing.Point(5, 32);
            this.cbRaceAnt1.Name = "cbRaceAnt1";
            this.cbRaceAnt1.Size = new System.Drawing.Size(48, 17);
            this.cbRaceAnt1.TabIndex = 15;
            this.cbRaceAnt1.Text = "Ant1";
            this.cbRaceAnt1.UseVisualStyleBackColor = true;
            // 
            // cbRaceAnt4
            // 
            this.cbRaceAnt4.AutoSize = true;
            this.cbRaceAnt4.Location = new System.Drawing.Point(160, 32);
            this.cbRaceAnt4.Name = "cbRaceAnt4";
            this.cbRaceAnt4.Size = new System.Drawing.Size(48, 17);
            this.cbRaceAnt4.TabIndex = 14;
            this.cbRaceAnt4.Text = "Ant4";
            this.cbRaceAnt4.UseVisualStyleBackColor = true;
            // 
            // cbRaceAnt2
            // 
            this.cbRaceAnt2.AutoSize = true;
            this.cbRaceAnt2.Location = new System.Drawing.Point(57, 32);
            this.cbRaceAnt2.Name = "cbRaceAnt2";
            this.cbRaceAnt2.Size = new System.Drawing.Size(48, 17);
            this.cbRaceAnt2.TabIndex = 12;
            this.cbRaceAnt2.Text = "Ant2";
            this.cbRaceAnt2.UseVisualStyleBackColor = true;
            // 
            // cbRaceAnt3
            // 
            this.cbRaceAnt3.AutoSize = true;
            this.cbRaceAnt3.Location = new System.Drawing.Point(109, 32);
            this.cbRaceAnt3.Name = "cbRaceAnt3";
            this.cbRaceAnt3.Size = new System.Drawing.Size(48, 17);
            this.cbRaceAnt3.TabIndex = 13;
            this.cbRaceAnt3.Text = "Ant3";
            this.cbRaceAnt3.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label18);
            this.groupBox12.Controls.Add(this.cmbRaceGroup);
            this.groupBox12.Controls.Add(this.label15);
            this.groupBox12.Controls.Add(this.cmbRaceRound);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(693, 3);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox12.Size = new System.Drawing.Size(305, 78);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Event Round";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(151, 37);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Group";
            // 
            // cmbRaceGroup
            // 
            this.cmbRaceGroup.FormattingEnabled = true;
            this.cmbRaceGroup.Location = new System.Drawing.Point(191, 36);
            this.cmbRaceGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRaceGroup.Name = "cmbRaceGroup";
            this.cmbRaceGroup.Size = new System.Drawing.Size(92, 21);
            this.cmbRaceGroup.TabIndex = 3;
            this.cmbRaceGroup.SelectedIndexChanged += new System.EventHandler(this.cmbRaceGroup_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Round";
            // 
            // cmbRaceRound
            // 
            this.cmbRaceRound.FormattingEnabled = true;
            this.cmbRaceRound.Location = new System.Drawing.Point(49, 34);
            this.cmbRaceRound.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRaceRound.Name = "cmbRaceRound";
            this.cmbRaceRound.Size = new System.Drawing.Size(92, 21);
            this.cmbRaceRound.TabIndex = 1;
            this.cmbRaceRound.SelectedIndexChanged += new System.EventHandler(this.cmbRaceRound_SelectedIndexChanged);
            // 
            // pageRealMode
            // 
            this.pageRealMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageRealMode.Controls.Add(this.groupBox20);
            this.pageRealMode.Controls.Add(this.tableLayoutPanel1);
            this.pageRealMode.Controls.Add(this.tbRealMinRssi);
            this.pageRealMode.Controls.Add(this.tbRealMaxRssi);
            this.pageRealMode.Controls.Add(this.btRealFresh);
            this.pageRealMode.Controls.Add(this.label70);
            this.pageRealMode.Controls.Add(this.label74);
            this.pageRealMode.Controls.Add(this.lbRealTagCount);
            this.pageRealMode.Controls.Add(this.groupBox1);
            this.pageRealMode.Controls.Add(this.lvRealList);
            this.pageRealMode.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageRealMode.Location = new System.Drawing.Point(4, 22);
            this.pageRealMode.Name = "pageRealMode";
            this.pageRealMode.Padding = new System.Windows.Forms.Padding(3);
            this.pageRealMode.Size = new System.Drawing.Size(1331, 627);
            this.pageRealMode.TabIndex = 1;
            this.pageRealMode.Text = "RTM Debug";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.cbRealWorkant1);
            this.groupBox20.Controls.Add(this.cbRealWorkant4);
            this.groupBox20.Controls.Add(this.cbRealWorkant3);
            this.groupBox20.Controls.Add(this.cbRealWorkant2);
            this.groupBox20.Controls.Add(this.label19);
            this.groupBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox20.ForeColor = System.Drawing.Color.Black;
            this.groupBox20.Location = new System.Drawing.Point(1005, 64);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(134, 176);
            this.groupBox20.TabIndex = 49;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Antenna Selection";
            // 
            // cbRealWorkant1
            // 
            this.cbRealWorkant1.AutoSize = true;
            this.cbRealWorkant1.Checked = true;
            this.cbRealWorkant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRealWorkant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRealWorkant1.Location = new System.Drawing.Point(32, 24);
            this.cbRealWorkant1.Name = "cbRealWorkant1";
            this.cbRealWorkant1.Size = new System.Drawing.Size(50, 19);
            this.cbRealWorkant1.TabIndex = 68;
            this.cbRealWorkant1.Text = "Ant1";
            this.cbRealWorkant1.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant4
            // 
            this.cbRealWorkant4.AutoSize = true;
            this.cbRealWorkant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRealWorkant4.Location = new System.Drawing.Point(31, 90);
            this.cbRealWorkant4.Name = "cbRealWorkant4";
            this.cbRealWorkant4.Size = new System.Drawing.Size(50, 19);
            this.cbRealWorkant4.TabIndex = 67;
            this.cbRealWorkant4.Text = "Ant4";
            this.cbRealWorkant4.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant3
            // 
            this.cbRealWorkant3.AutoSize = true;
            this.cbRealWorkant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRealWorkant3.Location = new System.Drawing.Point(32, 68);
            this.cbRealWorkant3.Name = "cbRealWorkant3";
            this.cbRealWorkant3.Size = new System.Drawing.Size(50, 19);
            this.cbRealWorkant3.TabIndex = 66;
            this.cbRealWorkant3.Text = "Ant3";
            this.cbRealWorkant3.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant2
            // 
            this.cbRealWorkant2.AutoSize = true;
            this.cbRealWorkant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRealWorkant2.Location = new System.Drawing.Point(32, 46);
            this.cbRealWorkant2.Name = "cbRealWorkant2";
            this.cbRealWorkant2.Size = new System.Drawing.Size(50, 19);
            this.cbRealWorkant2.TabIndex = 65;
            this.cbRealWorkant2.Text = "Ant2";
            this.cbRealWorkant2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 15);
            this.label19.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.7996F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.2004F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1325, 59);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textRealRound);
            this.panel1.Controls.Add(this.label84);
            this.panel1.Controls.Add(this.btRealTimeInventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 51);
            this.panel1.TabIndex = 0;
            // 
            // textRealRound
            // 
            this.textRealRound.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textRealRound.Location = new System.Drawing.Point(364, 16);
            this.textRealRound.Name = "textRealRound";
            this.textRealRound.Size = new System.Drawing.Size(28, 21);
            this.textRealRound.TabIndex = 48;
            this.textRealRound.Text = "1";
            this.textRealRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(231, 20);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(133, 15);
            this.label84.TabIndex = 2;
            this.label84.Text = "Repeat Per Command:";
            // 
            // btRealTimeInventory
            // 
            this.btRealTimeInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRealTimeInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btRealTimeInventory.Location = new System.Drawing.Point(75, 6);
            this.btRealTimeInventory.Name = "btRealTimeInventory";
            this.btRealTimeInventory.Size = new System.Drawing.Size(144, 41);
            this.btRealTimeInventory.TabIndex = 1;
            this.btRealTimeInventory.Text = "Inventory";
            this.btRealTimeInventory.UseVisualStyleBackColor = true;
            this.btRealTimeInventory.Click += new System.EventHandler(this.btRealTimeInventory_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbRealSession);
            this.panel5.Controls.Add(this.cmbTarget);
            this.panel5.Controls.Add(this.label98);
            this.panel5.Controls.Add(this.cmbSession);
            this.panel5.Controls.Add(this.label97);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(570, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(751, 51);
            this.panel5.TabIndex = 1;
            // 
            // cbRealSession
            // 
            this.cbRealSession.AutoSize = true;
            this.cbRealSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRealSession.Location = new System.Drawing.Point(29, 19);
            this.cbRealSession.Name = "cbRealSession";
            this.cbRealSession.Size = new System.Drawing.Size(138, 19);
            this.cbRealSession.TabIndex = 55;
            this.cbRealSession.Text = "User Define Session";
            this.cbRealSession.UseVisualStyleBackColor = true;
            this.cbRealSession.CheckedChanged += new System.EventHandler(this.cbRealSession_CheckedChanged);
            // 
            // cmbTarget
            // 
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.Enabled = false;
            this.cmbTarget.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbTarget.Location = new System.Drawing.Point(472, 16);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(62, 20);
            this.cmbTarget.TabIndex = 54;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Enabled = false;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(359, 20);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(97, 15);
            this.label98.TabIndex = 53;
            this.label98.Text = "Inventoried Flag:";
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.Enabled = false;
            this.cmbSession.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3"});
            this.cmbSession.Location = new System.Drawing.Point(273, 16);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(62, 20);
            this.cmbSession.TabIndex = 52;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Enabled = false;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(196, 20);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(69, 15);
            this.label97.TabIndex = 51;
            this.label97.Text = "Session ID:";
            // 
            // tbRealMinRssi
            // 
            this.tbRealMinRssi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRealMinRssi.Location = new System.Drawing.Point(482, 240);
            this.tbRealMinRssi.Name = "tbRealMinRssi";
            this.tbRealMinRssi.ReadOnly = true;
            this.tbRealMinRssi.Size = new System.Drawing.Size(62, 21);
            this.tbRealMinRssi.TabIndex = 46;
            this.tbRealMinRssi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRealMaxRssi
            // 
            this.tbRealMaxRssi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRealMaxRssi.Location = new System.Drawing.Point(667, 240);
            this.tbRealMaxRssi.Name = "tbRealMaxRssi";
            this.tbRealMaxRssi.ReadOnly = true;
            this.tbRealMaxRssi.Size = new System.Drawing.Size(62, 21);
            this.tbRealMaxRssi.TabIndex = 47;
            this.tbRealMaxRssi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btRealFresh
            // 
            this.btRealFresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRealFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btRealFresh.Location = new System.Drawing.Point(771, 240);
            this.btRealFresh.Name = "btRealFresh";
            this.btRealFresh.Size = new System.Drawing.Size(89, 25);
            this.btRealFresh.TabIndex = 45;
            this.btRealFresh.Text = "Refresh";
            this.btRealFresh.UseVisualStyleBackColor = true;
            this.btRealFresh.Click += new System.EventHandler(this.btRealFresh_Click);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label70.Location = new System.Drawing.Point(602, 243);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(65, 15);
            this.label70.TabIndex = 43;
            this.label70.Text = "Max RSSI:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label74.Location = new System.Drawing.Point(417, 243);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(62, 15);
            this.label74.TabIndex = 44;
            this.label74.Text = "Min RSSI:";
            // 
            // lbRealTagCount
            // 
            this.lbRealTagCount.AutoSize = true;
            this.lbRealTagCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealTagCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbRealTagCount.Location = new System.Drawing.Point(6, 243);
            this.lbRealTagCount.Name = "lbRealTagCount";
            this.lbRealTagCount.Size = new System.Drawing.Size(53, 15);
            this.lbRealTagCount.TabIndex = 42;
            this.lbRealTagCount.Text = "Tag List:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledReal3);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.ledReal5);
            this.groupBox1.Controls.Add(this.ledReal2);
            this.groupBox1.Controls.Add(this.ledReal4);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Controls.Add(this.label66);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.label68);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.ledReal1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 176);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Data";
            // 
            // ledReal3
            // 
            this.ledReal3.BackColor = System.Drawing.Color.Transparent;
            this.ledReal3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal3.BevelRate = 0.1F;
            this.ledReal3.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal3.HighlightOpaque = ((byte)(20));
            this.ledReal3.Location = new System.Drawing.Point(702, 54);
            this.ledReal3.Name = "ledReal3";
            this.ledReal3.RoundCorner = true;
            this.ledReal3.SegmentIntervalRatio = 50;
            this.ledReal3.ShowHighlight = true;
            this.ledReal3.Size = new System.Drawing.Size(210, 38);
            this.ledReal3.TabIndex = 40;
            this.ledReal3.Text = "0";
            this.ledReal3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal3.TotalCharCount = 10;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox6.Location = new System.Drawing.Point(-165, 120);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(55, 23);
            this.comboBox6.TabIndex = 39;
            // 
            // ledReal5
            // 
            this.ledReal5.BackColor = System.Drawing.Color.Transparent;
            this.ledReal5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal5.BevelRate = 0.1F;
            this.ledReal5.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal5.HighlightOpaque = ((byte)(20));
            this.ledReal5.Location = new System.Drawing.Point(702, 128);
            this.ledReal5.Name = "ledReal5";
            this.ledReal5.RoundCorner = true;
            this.ledReal5.SegmentIntervalRatio = 50;
            this.ledReal5.ShowHighlight = true;
            this.ledReal5.Size = new System.Drawing.Size(210, 38);
            this.ledReal5.TabIndex = 35;
            this.ledReal5.Text = "0";
            this.ledReal5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal5.TotalCharCount = 10;
            // 
            // ledReal2
            // 
            this.ledReal2.BackColor = System.Drawing.Color.Transparent;
            this.ledReal2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal2.BevelRate = 0.1F;
            this.ledReal2.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal2.ForeColor = System.Drawing.Color.Purple;
            this.ledReal2.HighlightOpaque = ((byte)(20));
            this.ledReal2.Location = new System.Drawing.Point(496, 38);
            this.ledReal2.Name = "ledReal2";
            this.ledReal2.RoundCorner = true;
            this.ledReal2.SegmentIntervalRatio = 50;
            this.ledReal2.ShowHighlight = true;
            this.ledReal2.Size = new System.Drawing.Size(180, 54);
            this.ledReal2.TabIndex = 34;
            this.ledReal2.Text = "0";
            this.ledReal2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal2.TotalCharCount = 6;
            // 
            // ledReal4
            // 
            this.ledReal4.BackColor = System.Drawing.Color.Transparent;
            this.ledReal4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal4.BevelRate = 0.1F;
            this.ledReal4.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal4.ForeColor = System.Drawing.Color.Purple;
            this.ledReal4.HighlightOpaque = ((byte)(20));
            this.ledReal4.Location = new System.Drawing.Point(497, 111);
            this.ledReal4.Name = "ledReal4";
            this.ledReal4.RoundCorner = true;
            this.ledReal4.SegmentIntervalRatio = 50;
            this.ledReal4.ShowHighlight = true;
            this.ledReal4.Size = new System.Drawing.Size(179, 54);
            this.ledReal4.TabIndex = 33;
            this.ledReal4.Text = "0";
            this.ledReal4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal4.TotalCharCount = 6;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label53.Location = new System.Drawing.Point(700, 111);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(165, 15);
            this.label53.TabIndex = 30;
            this.label53.Text = "Total Inventory Duration(mS):";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label66.Location = new System.Drawing.Point(495, 19);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(99, 15);
            this.label66.TabIndex = 29;
            this.label66.Text = "Speed(Tag/Sec):";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label67.Location = new System.Drawing.Point(498, 95);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(145, 15);
            this.label67.TabIndex = 28;
            this.label67.Text = "Command Duration(mS):";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label68.Location = new System.Drawing.Point(700, 38);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(151, 15);
            this.label68.TabIndex = 27;
            this.label68.Text = "Total Tag Communication:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label69.Location = new System.Drawing.Point(104, 19);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(117, 15);
            this.label69.TabIndex = 26;
            this.label69.Text = "Inventoried Quantity:";
            // 
            // ledReal1
            // 
            this.ledReal1.BackColor = System.Drawing.Color.Transparent;
            this.ledReal1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal1.BevelRate = 0.1F;
            this.ledReal1.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal1.BorderWidth = 3;
            this.ledReal1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal1.HighlightOpaque = ((byte)(20));
            this.ledReal1.Location = new System.Drawing.Point(106, 38);
            this.ledReal1.Name = "ledReal1";
            this.ledReal1.RoundCorner = true;
            this.ledReal1.SegmentIntervalRatio = 50;
            this.ledReal1.ShowHighlight = true;
            this.ledReal1.Size = new System.Drawing.Size(327, 128);
            this.ledReal1.TabIndex = 21;
            this.ledReal1.Text = "0";
            this.ledReal1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lvRealList
            // 
            this.lvRealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40,
            this.columnHeader41,
            this.columnHeader42});
            this.lvRealList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvRealList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRealList.GridLines = true;
            this.lvRealList.Location = new System.Drawing.Point(3, 267);
            this.lvRealList.Name = "lvRealList";
            this.lvRealList.Size = new System.Drawing.Size(1325, 357);
            this.lvRealList.TabIndex = 23;
            this.lvRealList.UseCompatibleStateImageBehavior = false;
            this.lvRealList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "ID";
            this.columnHeader37.Width = 56;
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "EPC";
            this.columnHeader38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader38.Width = 486;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "PC";
            this.columnHeader39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader39.Width = 83;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "Identification Count";
            this.columnHeader40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader40.Width = 149;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "RSSI";
            this.columnHeader41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader41.Width = 95;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "Carrier Frequency";
            this.columnHeader42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader42.Width = 114;
            // 
            // pageBufferedMode
            // 
            this.pageBufferedMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageBufferedMode.Controls.Add(this.tableLayoutPanel4);
            this.pageBufferedMode.Controls.Add(this.groupBox3);
            this.pageBufferedMode.Controls.Add(this.btBufferFresh);
            this.pageBufferedMode.Controls.Add(this.labelBufferTagCount);
            this.pageBufferedMode.Controls.Add(this.lvBufferList);
            this.pageBufferedMode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pageBufferedMode.Location = new System.Drawing.Point(4, 22);
            this.pageBufferedMode.Name = "pageBufferedMode";
            this.pageBufferedMode.Size = new System.Drawing.Size(1331, 627);
            this.pageBufferedMode.TabIndex = 2;
            this.pageBufferedMode.Text = "Tag Inventory(Buffer Mode)";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.22422F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.77578F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tableLayoutPanel4.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1331, 89);
            this.tableLayoutPanel4.TabIndex = 58;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btClearBuffer);
            this.panel9.Controls.Add(this.btQueryBuffer);
            this.panel9.Controls.Add(this.btGetClearBuffer);
            this.panel9.Controls.Add(this.btGetBuffer);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(794, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(533, 81);
            this.panel9.TabIndex = 1;
            // 
            // btClearBuffer
            // 
            this.btClearBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClearBuffer.Location = new System.Drawing.Point(15, 45);
            this.btClearBuffer.Name = "btClearBuffer";
            this.btClearBuffer.Size = new System.Drawing.Size(135, 27);
            this.btClearBuffer.TabIndex = 8;
            this.btClearBuffer.Text = "Clear Buffer";
            this.btClearBuffer.UseVisualStyleBackColor = true;
            this.btClearBuffer.Click += new System.EventHandler(this.btClearBuffer_Click);
            // 
            // btQueryBuffer
            // 
            this.btQueryBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQueryBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btQueryBuffer.Location = new System.Drawing.Point(167, 45);
            this.btQueryBuffer.Name = "btQueryBuffer";
            this.btQueryBuffer.Size = new System.Drawing.Size(135, 27);
            this.btQueryBuffer.TabIndex = 7;
            this.btQueryBuffer.Text = "Query Tag Quantity";
            this.btQueryBuffer.UseVisualStyleBackColor = true;
            this.btQueryBuffer.Click += new System.EventHandler(this.btQueryBuffer_Click);
            // 
            // btGetClearBuffer
            // 
            this.btGetClearBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGetClearBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGetClearBuffer.Location = new System.Drawing.Point(167, 11);
            this.btGetClearBuffer.Name = "btGetClearBuffer";
            this.btGetClearBuffer.Size = new System.Drawing.Size(135, 27);
            this.btGetClearBuffer.TabIndex = 6;
            this.btGetClearBuffer.Text = "Get and Clear Buffer";
            this.btGetClearBuffer.UseVisualStyleBackColor = true;
            this.btGetClearBuffer.Click += new System.EventHandler(this.btGetClearBuffer_Click);
            // 
            // btGetBuffer
            // 
            this.btGetBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGetBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGetBuffer.Location = new System.Drawing.Point(15, 11);
            this.btGetBuffer.Name = "btGetBuffer";
            this.btGetBuffer.Size = new System.Drawing.Size(135, 27);
            this.btGetBuffer.TabIndex = 5;
            this.btGetBuffer.Text = "Get Buffer";
            this.btGetBuffer.UseVisualStyleBackColor = true;
            this.btGetBuffer.Click += new System.EventHandler(this.btGetBuffer_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btBufferInventory);
            this.panel10.Controls.Add(this.label85);
            this.panel10.Controls.Add(this.textReadRoundBuffer);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(390, 81);
            this.panel10.TabIndex = 0;
            // 
            // btBufferInventory
            // 
            this.btBufferInventory.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBufferInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btBufferInventory.Location = new System.Drawing.Point(7, 15);
            this.btBufferInventory.Name = "btBufferInventory";
            this.btBufferInventory.Size = new System.Drawing.Size(144, 41);
            this.btBufferInventory.TabIndex = 51;
            this.btBufferInventory.Text = "Inventory";
            this.btBufferInventory.UseVisualStyleBackColor = true;
            this.btBufferInventory.Click += new System.EventHandler(this.btBufferInventory_Click);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label85.Location = new System.Drawing.Point(163, 32);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(119, 12);
            this.label85.TabIndex = 49;
            this.label85.Text = "Repeat Per Command:";
            // 
            // textReadRoundBuffer
            // 
            this.textReadRoundBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textReadRoundBuffer.Location = new System.Drawing.Point(288, 28);
            this.textReadRoundBuffer.Name = "textReadRoundBuffer";
            this.textReadRoundBuffer.Size = new System.Drawing.Size(28, 21);
            this.textReadRoundBuffer.TabIndex = 50;
            this.textReadRoundBuffer.Text = "1";
            this.textReadRoundBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbBufferWorkant1);
            this.panel8.Controls.Add(this.cbBufferWorkant4);
            this.panel8.Controls.Add(this.cbBufferWorkant2);
            this.panel8.Controls.Add(this.cbBufferWorkant3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(401, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(386, 81);
            this.panel8.TabIndex = 0;
            // 
            // cbBufferWorkant1
            // 
            this.cbBufferWorkant1.AutoSize = true;
            this.cbBufferWorkant1.Checked = true;
            this.cbBufferWorkant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBufferWorkant1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBufferWorkant1.Location = new System.Drawing.Point(28, 30);
            this.cbBufferWorkant1.Name = "cbBufferWorkant1";
            this.cbBufferWorkant1.Size = new System.Drawing.Size(48, 16);
            this.cbBufferWorkant1.TabIndex = 11;
            this.cbBufferWorkant1.Text = "Ant1";
            this.cbBufferWorkant1.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant4
            // 
            this.cbBufferWorkant4.AutoSize = true;
            this.cbBufferWorkant4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBufferWorkant4.Location = new System.Drawing.Point(253, 32);
            this.cbBufferWorkant4.Name = "cbBufferWorkant4";
            this.cbBufferWorkant4.Size = new System.Drawing.Size(48, 16);
            this.cbBufferWorkant4.TabIndex = 10;
            this.cbBufferWorkant4.Text = "Ant4";
            this.cbBufferWorkant4.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant2
            // 
            this.cbBufferWorkant2.AutoSize = true;
            this.cbBufferWorkant2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBufferWorkant2.Location = new System.Drawing.Point(103, 32);
            this.cbBufferWorkant2.Name = "cbBufferWorkant2";
            this.cbBufferWorkant2.Size = new System.Drawing.Size(48, 16);
            this.cbBufferWorkant2.TabIndex = 8;
            this.cbBufferWorkant2.Text = "Ant2";
            this.cbBufferWorkant2.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant3
            // 
            this.cbBufferWorkant3.AutoSize = true;
            this.cbBufferWorkant3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBufferWorkant3.Location = new System.Drawing.Point(178, 32);
            this.cbBufferWorkant3.Name = "cbBufferWorkant3";
            this.cbBufferWorkant3.Size = new System.Drawing.Size(48, 16);
            this.cbBufferWorkant3.TabIndex = 9;
            this.cbBufferWorkant3.Text = "Ant3";
            this.cbBufferWorkant3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ledBuffer4);
            this.groupBox3.Controls.Add(this.comboBox11);
            this.groupBox3.Controls.Add(this.ledBuffer5);
            this.groupBox3.Controls.Add(this.ledBuffer2);
            this.groupBox3.Controls.Add(this.ledBuffer3);
            this.groupBox3.Controls.Add(this.label92);
            this.groupBox3.Controls.Add(this.label93);
            this.groupBox3.Controls.Add(this.label94);
            this.groupBox3.Controls.Add(this.label95);
            this.groupBox3.Controls.Add(this.label96);
            this.groupBox3.Controls.Add(this.ledBuffer1);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(0, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(996, 176);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tag Data";
            // 
            // ledBuffer4
            // 
            this.ledBuffer4.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer4.BevelRate = 0.1F;
            this.ledBuffer4.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer4.HighlightOpaque = ((byte)(20));
            this.ledBuffer4.Location = new System.Drawing.Point(702, 54);
            this.ledBuffer4.Name = "ledBuffer4";
            this.ledBuffer4.RoundCorner = true;
            this.ledBuffer4.SegmentIntervalRatio = 50;
            this.ledBuffer4.ShowHighlight = true;
            this.ledBuffer4.Size = new System.Drawing.Size(183, 38);
            this.ledBuffer4.TabIndex = 40;
            this.ledBuffer4.Text = "0";
            this.ledBuffer4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer4.TotalCharCount = 10;
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox11.Location = new System.Drawing.Point(-165, 120);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(55, 20);
            this.comboBox11.TabIndex = 39;
            // 
            // ledBuffer5
            // 
            this.ledBuffer5.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer5.BevelRate = 0.1F;
            this.ledBuffer5.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer5.HighlightOpaque = ((byte)(20));
            this.ledBuffer5.Location = new System.Drawing.Point(702, 128);
            this.ledBuffer5.Name = "ledBuffer5";
            this.ledBuffer5.RoundCorner = true;
            this.ledBuffer5.SegmentIntervalRatio = 50;
            this.ledBuffer5.ShowHighlight = true;
            this.ledBuffer5.Size = new System.Drawing.Size(183, 38);
            this.ledBuffer5.TabIndex = 35;
            this.ledBuffer5.Text = "0";
            this.ledBuffer5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer5.TotalCharCount = 10;
            // 
            // ledBuffer2
            // 
            this.ledBuffer2.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer2.BevelRate = 0.1F;
            this.ledBuffer2.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer2.ForeColor = System.Drawing.Color.Purple;
            this.ledBuffer2.HighlightOpaque = ((byte)(20));
            this.ledBuffer2.Location = new System.Drawing.Point(496, 38);
            this.ledBuffer2.Name = "ledBuffer2";
            this.ledBuffer2.RoundCorner = true;
            this.ledBuffer2.SegmentIntervalRatio = 50;
            this.ledBuffer2.ShowHighlight = true;
            this.ledBuffer2.Size = new System.Drawing.Size(162, 54);
            this.ledBuffer2.TabIndex = 34;
            this.ledBuffer2.Text = "0";
            this.ledBuffer2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer2.TotalCharCount = 6;
            // 
            // ledBuffer3
            // 
            this.ledBuffer3.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer3.BevelRate = 0.1F;
            this.ledBuffer3.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer3.ForeColor = System.Drawing.Color.Purple;
            this.ledBuffer3.HighlightOpaque = ((byte)(20));
            this.ledBuffer3.Location = new System.Drawing.Point(497, 111);
            this.ledBuffer3.Name = "ledBuffer3";
            this.ledBuffer3.RoundCorner = true;
            this.ledBuffer3.SegmentIntervalRatio = 50;
            this.ledBuffer3.ShowHighlight = true;
            this.ledBuffer3.Size = new System.Drawing.Size(161, 54);
            this.ledBuffer3.TabIndex = 33;
            this.ledBuffer3.Text = "0";
            this.ledBuffer3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer3.TotalCharCount = 6;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label92.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label92.Location = new System.Drawing.Point(700, 111);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(179, 12);
            this.label92.TabIndex = 30;
            this.label92.Text = "Total Inventory Duration(mS):";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label93.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label93.Location = new System.Drawing.Point(495, 19);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(95, 12);
            this.label93.TabIndex = 29;
            this.label93.Text = "Speed(Tag/Sec):";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label94.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label94.Location = new System.Drawing.Point(498, 95);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(131, 12);
            this.label94.TabIndex = 28;
            this.label94.Text = "Command Duration(mS):";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label95.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label95.Location = new System.Drawing.Point(700, 38);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(149, 12);
            this.label95.TabIndex = 27;
            this.label95.Text = "Total Tag Communication:";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label96.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label96.Location = new System.Drawing.Point(104, 19);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(131, 12);
            this.label96.TabIndex = 26;
            this.label96.Text = "Inventoried Quantity:";
            // 
            // ledBuffer1
            // 
            this.ledBuffer1.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer1.BevelRate = 0.1F;
            this.ledBuffer1.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer1.BorderWidth = 3;
            this.ledBuffer1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer1.HighlightOpaque = ((byte)(20));
            this.ledBuffer1.Location = new System.Drawing.Point(106, 38);
            this.ledBuffer1.Name = "ledBuffer1";
            this.ledBuffer1.RoundCorner = true;
            this.ledBuffer1.SegmentIntervalRatio = 50;
            this.ledBuffer1.ShowHighlight = true;
            this.ledBuffer1.Size = new System.Drawing.Size(310, 128);
            this.ledBuffer1.TabIndex = 21;
            this.ledBuffer1.Text = "0";
            this.ledBuffer1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // btBufferFresh
            // 
            this.btBufferFresh.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBufferFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btBufferFresh.Location = new System.Drawing.Point(907, 277);
            this.btBufferFresh.Name = "btBufferFresh";
            this.btBufferFresh.Size = new System.Drawing.Size(89, 25);
            this.btBufferFresh.TabIndex = 52;
            this.btBufferFresh.Text = "Refresh";
            this.btBufferFresh.UseVisualStyleBackColor = true;
            this.btBufferFresh.Click += new System.EventHandler(this.btBufferFresh_Click);
            // 
            // labelBufferTagCount
            // 
            this.labelBufferTagCount.AutoSize = true;
            this.labelBufferTagCount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBufferTagCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelBufferTagCount.Location = new System.Drawing.Point(6, 283);
            this.labelBufferTagCount.Name = "labelBufferTagCount";
            this.labelBufferTagCount.Size = new System.Drawing.Size(59, 12);
            this.labelBufferTagCount.TabIndex = 49;
            this.labelBufferTagCount.Text = "Tag List:";
            // 
            // lvBufferList
            // 
            this.lvBufferList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader49,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader52,
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader16});
            this.lvBufferList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvBufferList.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvBufferList.GridLines = true;
            this.lvBufferList.Location = new System.Drawing.Point(0, 369);
            this.lvBufferList.Name = "lvBufferList";
            this.lvBufferList.Size = new System.Drawing.Size(1331, 258);
            this.lvBufferList.TabIndex = 48;
            this.lvBufferList.UseCompatibleStateImageBehavior = false;
            this.lvBufferList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader49
            // 
            this.columnHeader49.Text = "ID";
            this.columnHeader49.Width = 56;
            // 
            // columnHeader50
            // 
            this.columnHeader50.Text = "PC";
            this.columnHeader50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader50.Width = 64;
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "CRC";
            this.columnHeader51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader51.Width = 74;
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "EPC";
            this.columnHeader52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader52.Width = 492;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "Ant ID";
            this.columnHeader53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader53.Width = 95;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "RSSI";
            this.columnHeader54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader54.Width = 71;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Identification Count";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 135;
            // 
            // pageFast4AntMode
            // 
            this.pageFast4AntMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageFast4AntMode.Controls.Add(this.groupBox2);
            this.pageFast4AntMode.Controls.Add(this.txtFastMaxRssi);
            this.pageFast4AntMode.Controls.Add(this.txtFastMinRssi);
            this.pageFast4AntMode.Controls.Add(this.buttonFastFresh);
            this.pageFast4AntMode.Controls.Add(this.tableLayoutPanel2);
            this.pageFast4AntMode.Controls.Add(this.label22);
            this.pageFast4AntMode.Controls.Add(this.lvFastList);
            this.pageFast4AntMode.Controls.Add(this.label49);
            this.pageFast4AntMode.Controls.Add(this.txtFastTagList);
            this.pageFast4AntMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageFast4AntMode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pageFast4AntMode.Location = new System.Drawing.Point(4, 22);
            this.pageFast4AntMode.Name = "pageFast4AntMode";
            this.pageFast4AntMode.Padding = new System.Windows.Forms.Padding(3);
            this.pageFast4AntMode.Size = new System.Drawing.Size(1331, 627);
            this.pageFast4AntMode.TabIndex = 0;
            this.pageFast4AntMode.Text = "FSA Debug";
            this.pageFast4AntMode.Enter += new System.EventHandler(this.pageFast4AntMode_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ledFast4);
            this.groupBox2.Controls.Add(this.comboBox7);
            this.groupBox2.Controls.Add(this.ledFast5);
            this.groupBox2.Controls.Add(this.ledFast2);
            this.groupBox2.Controls.Add(this.ledFast3);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Controls.Add(this.label57);
            this.groupBox2.Controls.Add(this.label58);
            this.groupBox2.Controls.Add(this.ledFast1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1325, 176);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tag Data";
            // 
            // ledFast4
            // 
            this.ledFast4.BackColor = System.Drawing.Color.Transparent;
            this.ledFast4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast4.BevelRate = 0.1F;
            this.ledFast4.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast4.HighlightOpaque = ((byte)(20));
            this.ledFast4.Location = new System.Drawing.Point(702, 54);
            this.ledFast4.Name = "ledFast4";
            this.ledFast4.RoundCorner = true;
            this.ledFast4.SegmentIntervalRatio = 50;
            this.ledFast4.ShowHighlight = true;
            this.ledFast4.Size = new System.Drawing.Size(199, 38);
            this.ledFast4.TabIndex = 40;
            this.ledFast4.Text = "0";
            this.ledFast4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast4.TotalCharCount = 10;
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox7.Location = new System.Drawing.Point(-165, 120);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(55, 23);
            this.comboBox7.TabIndex = 39;
            // 
            // ledFast5
            // 
            this.ledFast5.BackColor = System.Drawing.Color.Transparent;
            this.ledFast5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast5.BevelRate = 0.1F;
            this.ledFast5.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast5.HighlightOpaque = ((byte)(20));
            this.ledFast5.Location = new System.Drawing.Point(702, 128);
            this.ledFast5.Name = "ledFast5";
            this.ledFast5.RoundCorner = true;
            this.ledFast5.SegmentIntervalRatio = 50;
            this.ledFast5.ShowHighlight = true;
            this.ledFast5.Size = new System.Drawing.Size(199, 38);
            this.ledFast5.TabIndex = 35;
            this.ledFast5.Text = "0";
            this.ledFast5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast5.TotalCharCount = 10;
            // 
            // ledFast2
            // 
            this.ledFast2.BackColor = System.Drawing.Color.Transparent;
            this.ledFast2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast2.BevelRate = 0.1F;
            this.ledFast2.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast2.ForeColor = System.Drawing.Color.Purple;
            this.ledFast2.HighlightOpaque = ((byte)(20));
            this.ledFast2.Location = new System.Drawing.Point(496, 38);
            this.ledFast2.Name = "ledFast2";
            this.ledFast2.RoundCorner = true;
            this.ledFast2.SegmentIntervalRatio = 50;
            this.ledFast2.ShowHighlight = true;
            this.ledFast2.Size = new System.Drawing.Size(173, 54);
            this.ledFast2.TabIndex = 34;
            this.ledFast2.Text = "0";
            this.ledFast2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast2.TotalCharCount = 6;
            // 
            // ledFast3
            // 
            this.ledFast3.BackColor = System.Drawing.Color.Transparent;
            this.ledFast3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast3.BevelRate = 0.1F;
            this.ledFast3.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast3.ForeColor = System.Drawing.Color.Purple;
            this.ledFast3.HighlightOpaque = ((byte)(20));
            this.ledFast3.Location = new System.Drawing.Point(497, 111);
            this.ledFast3.Name = "ledFast3";
            this.ledFast3.RoundCorner = true;
            this.ledFast3.SegmentIntervalRatio = 50;
            this.ledFast3.ShowHighlight = true;
            this.ledFast3.Size = new System.Drawing.Size(172, 54);
            this.ledFast3.TabIndex = 33;
            this.ledFast3.Text = "0";
            this.ledFast3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast3.TotalCharCount = 6;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label54.Location = new System.Drawing.Point(700, 111);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(165, 15);
            this.label54.TabIndex = 30;
            this.label54.Text = "Total Inventory Duration(mS):";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label55.Location = new System.Drawing.Point(495, 19);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(99, 15);
            this.label55.TabIndex = 29;
            this.label55.Text = "Speed(Tag/Sec):";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label56.Location = new System.Drawing.Point(498, 95);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(145, 15);
            this.label56.TabIndex = 28;
            this.label56.Text = "Command Duration(mS):";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label57.Location = new System.Drawing.Point(717, 19);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(151, 15);
            this.label57.TabIndex = 27;
            this.label57.Text = "Total Tag Communication:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label58.Location = new System.Drawing.Point(104, 19);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(114, 15);
            this.label58.TabIndex = 26;
            this.label58.Text = "Inventoried Quantity";
            // 
            // ledFast1
            // 
            this.ledFast1.BackColor = System.Drawing.Color.Transparent;
            this.ledFast1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast1.BevelRate = 0.1F;
            this.ledFast1.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast1.BorderWidth = 3;
            this.ledFast1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast1.HighlightOpaque = ((byte)(20));
            this.ledFast1.Location = new System.Drawing.Point(106, 38);
            this.ledFast1.Name = "ledFast1";
            this.ledFast1.RoundCorner = true;
            this.ledFast1.SegmentIntervalRatio = 50;
            this.ledFast1.ShowHighlight = true;
            this.ledFast1.Size = new System.Drawing.Size(328, 128);
            this.ledFast1.TabIndex = 21;
            this.ledFast1.Text = "0";
            this.ledFast1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // txtFastMaxRssi
            // 
            this.txtFastMaxRssi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFastMaxRssi.Location = new System.Drawing.Point(705, 271);
            this.txtFastMaxRssi.Name = "txtFastMaxRssi";
            this.txtFastMaxRssi.Size = new System.Drawing.Size(62, 21);
            this.txtFastMaxRssi.TabIndex = 40;
            // 
            // txtFastMinRssi
            // 
            this.txtFastMinRssi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFastMinRssi.Location = new System.Drawing.Point(499, 271);
            this.txtFastMinRssi.Name = "txtFastMinRssi";
            this.txtFastMinRssi.Size = new System.Drawing.Size(62, 21);
            this.txtFastMinRssi.TabIndex = 41;
            // 
            // buttonFastFresh
            // 
            this.buttonFastFresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFastFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonFastFresh.Location = new System.Drawing.Point(905, 271);
            this.buttonFastFresh.Name = "buttonFastFresh";
            this.buttonFastFresh.Size = new System.Drawing.Size(89, 25);
            this.buttonFastFresh.TabIndex = 28;
            this.buttonFastFresh.Text = "Refresh";
            this.buttonFastFresh.UseVisualStyleBackColor = true;
            this.buttonFastFresh.Click += new System.EventHandler(this.buttonFastFresh_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.20588F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.79412F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 570F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1325, 85);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDStay);
            this.panel2.Controls.Add(this.txtCStay);
            this.panel2.Controls.Add(this.txtBStay);
            this.panel2.Controls.Add(this.txtAStay);
            this.panel2.Controls.Add(this.label64);
            this.panel2.Controls.Add(this.label65);
            this.panel2.Controls.Add(this.cmbAntSelect1);
            this.panel2.Controls.Add(this.label62);
            this.panel2.Controls.Add(this.cmbAntSelect2);
            this.panel2.Controls.Add(this.label63);
            this.panel2.Controls.Add(this.cmbAntSelect3);
            this.panel2.Controls.Add(this.label60);
            this.panel2.Controls.Add(this.cmbAntSelect4);
            this.panel2.Controls.Add(this.label61);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.label48);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 75);
            this.panel2.TabIndex = 0;
            // 
            // txtDStay
            // 
            this.txtDStay.AcceptsReturn = true;
            this.txtDStay.Location = new System.Drawing.Point(469, 29);
            this.txtDStay.Name = "txtDStay";
            this.txtDStay.Size = new System.Drawing.Size(42, 21);
            this.txtDStay.TabIndex = 59;
            this.txtDStay.Text = "1";
            this.txtDStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCStay
            // 
            this.txtCStay.Location = new System.Drawing.Point(336, 29);
            this.txtCStay.Name = "txtCStay";
            this.txtCStay.Size = new System.Drawing.Size(42, 21);
            this.txtCStay.TabIndex = 58;
            this.txtCStay.Text = "1";
            this.txtCStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBStay
            // 
            this.txtBStay.Location = new System.Drawing.Point(203, 29);
            this.txtBStay.Name = "txtBStay";
            this.txtBStay.Size = new System.Drawing.Size(42, 21);
            this.txtBStay.TabIndex = 57;
            this.txtBStay.Text = "1";
            this.txtBStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAStay
            // 
            this.txtAStay.Location = new System.Drawing.Point(69, 29);
            this.txtAStay.Name = "txtAStay";
            this.txtAStay.Size = new System.Drawing.Size(42, 21);
            this.txtAStay.TabIndex = 56;
            this.txtAStay.Text = "1";
            this.txtAStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label64.Location = new System.Drawing.Point(467, 13);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(44, 15);
            this.label64.TabIndex = 39;
            this.label64.Text = "Round";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label65.Location = new System.Drawing.Point(431, 13);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(16, 15);
            this.label65.TabIndex = 38;
            this.label65.Text = "D";
            // 
            // cmbAntSelect1
            // 
            this.cmbAntSelect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntSelect1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAntSelect1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect1.FormattingEnabled = true;
            this.cmbAntSelect1.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.cmbAntSelect1.Location = new System.Drawing.Point(8, 29);
            this.cmbAntSelect1.Name = "cmbAntSelect1";
            this.cmbAntSelect1.Size = new System.Drawing.Size(55, 20);
            this.cmbAntSelect1.TabIndex = 13;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label62.Location = new System.Drawing.Point(334, 13);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(44, 15);
            this.label62.TabIndex = 37;
            this.label62.Text = "Round";
            // 
            // cmbAntSelect2
            // 
            this.cmbAntSelect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntSelect2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAntSelect2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect2.FormattingEnabled = true;
            this.cmbAntSelect2.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.cmbAntSelect2.Location = new System.Drawing.Point(140, 29);
            this.cmbAntSelect2.Name = "cmbAntSelect2";
            this.cmbAntSelect2.Size = new System.Drawing.Size(55, 20);
            this.cmbAntSelect2.TabIndex = 14;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label63.Location = new System.Drawing.Point(297, 13);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(15, 15);
            this.label63.TabIndex = 36;
            this.label63.Text = "C";
            // 
            // cmbAntSelect3
            // 
            this.cmbAntSelect3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntSelect3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAntSelect3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect3.FormattingEnabled = true;
            this.cmbAntSelect3.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.cmbAntSelect3.Location = new System.Drawing.Point(275, 29);
            this.cmbAntSelect3.Name = "cmbAntSelect3";
            this.cmbAntSelect3.Size = new System.Drawing.Size(55, 20);
            this.cmbAntSelect3.TabIndex = 15;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label60.Location = new System.Drawing.Point(201, 13);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(44, 15);
            this.label60.TabIndex = 35;
            this.label60.Text = "Round";
            // 
            // cmbAntSelect4
            // 
            this.cmbAntSelect4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntSelect4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAntSelect4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect4.FormattingEnabled = true;
            this.cmbAntSelect4.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.cmbAntSelect4.Location = new System.Drawing.Point(408, 29);
            this.cmbAntSelect4.Name = "cmbAntSelect4";
            this.cmbAntSelect4.Size = new System.Drawing.Size(55, 20);
            this.cmbAntSelect4.TabIndex = 16;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label61.Location = new System.Drawing.Point(161, 13);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(15, 15);
            this.label61.TabIndex = 34;
            this.label61.Text = "B";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label59.Location = new System.Drawing.Point(67, 13);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(44, 15);
            this.label59.TabIndex = 33;
            this.label59.Text = "Round";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label48.Location = new System.Drawing.Point(27, 13);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(14, 15);
            this.label48.TabIndex = 32;
            this.label48.Text = "A";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btFastInventory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 75);
            this.panel3.TabIndex = 1;
            // 
            // btFastInventory
            // 
            this.btFastInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFastInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btFastInventory.Location = new System.Drawing.Point(28, 17);
            this.btFastInventory.Name = "btFastInventory";
            this.btFastInventory.Size = new System.Drawing.Size(144, 41);
            this.btFastInventory.TabIndex = 52;
            this.btFastInventory.Text = "Inventory";
            this.btFastInventory.UseVisualStyleBackColor = true;
            this.btFastInventory.Click += new System.EventHandler(this.btFastInventory_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtRepeat);
            this.panel4.Controls.Add(this.txtInterval);
            this.panel4.Controls.Add(this.label73);
            this.panel4.Controls.Add(this.label72);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(755, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 75);
            this.panel4.TabIndex = 2;
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(286, 28);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(42, 21);
            this.txtRepeat.TabIndex = 58;
            this.txtRepeat.Text = "10";
            this.txtRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(156, 26);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(42, 21);
            this.txtInterval.TabIndex = 57;
            this.txtInterval.Text = "0";
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label73.Location = new System.Drawing.Point(6, 29);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(144, 15);
            this.label73.TabIndex = 36;
            this.label73.Text = "Interval Between Ant(mS)";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label72.Location = new System.Drawing.Point(224, 31);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(47, 15);
            this.label72.TabIndex = 37;
            this.label72.Text = "Repeat";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(634, 276);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 15);
            this.label22.TabIndex = 26;
            this.label22.Text = "Max RSSI:";
            // 
            // lvFastList
            // 
            this.lvFastList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36});
            this.lvFastList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvFastList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFastList.GridLines = true;
            this.lvFastList.Location = new System.Drawing.Point(3, 298);
            this.lvFastList.Name = "lvFastList";
            this.lvFastList.Size = new System.Drawing.Size(1325, 326);
            this.lvFastList.TabIndex = 24;
            this.lvFastList.UseCompatibleStateImageBehavior = false;
            this.lvFastList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "ID";
            this.columnHeader31.Width = 52;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "EPC";
            this.columnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader32.Width = 428;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "PC";
            this.columnHeader33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader33.Width = 65;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Identification Count(ANT1/ANT2/ANT3/ANT4)";
            this.columnHeader34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader34.Width = 261;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "RSSI";
            this.columnHeader35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader35.Width = 86;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Carrier Freq";
            this.columnHeader36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader36.Width = 92;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label49.Location = new System.Drawing.Point(428, 276);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(62, 15);
            this.label49.TabIndex = 27;
            this.label49.Text = "Min RSSI:";
            // 
            // txtFastTagList
            // 
            this.txtFastTagList.AutoSize = true;
            this.txtFastTagList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFastTagList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtFastTagList.Location = new System.Drawing.Point(6, 276);
            this.txtFastTagList.Name = "txtFastTagList";
            this.txtFastTagList.Size = new System.Drawing.Size(53, 15);
            this.txtFastTagList.TabIndex = 23;
            this.txtFastTagList.Text = "Tag List:";
            // 
            // pageAcessTag
            // 
            this.pageAcessTag.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageAcessTag.Controls.Add(this.ltvOperate);
            this.pageAcessTag.Controls.Add(this.gbCmdOperateTag);
            this.pageAcessTag.Location = new System.Drawing.Point(4, 22);
            this.pageAcessTag.Name = "pageAcessTag";
            this.pageAcessTag.Size = new System.Drawing.Size(1331, 627);
            this.pageAcessTag.TabIndex = 3;
            this.pageAcessTag.Text = "Tag R/W";
            this.pageAcessTag.UseVisualStyleBackColor = true;
            // 
            // ltvOperate
            // 
            this.ltvOperate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.ltvOperate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvOperate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvOperate.GridLines = true;
            this.ltvOperate.Location = new System.Drawing.Point(0, 348);
            this.ltvOperate.Name = "ltvOperate";
            this.ltvOperate.Size = new System.Drawing.Size(1331, 279);
            this.ltvOperate.TabIndex = 10;
            this.ltvOperate.UseCompatibleStateImageBehavior = false;
            this.ltvOperate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PC";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "CRC";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "EPC";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 260;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Data";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 334;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Data Len";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 73;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ant ID";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 49;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Operated Count";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 98;
            // 
            // gbCmdOperateTag
            // 
            this.gbCmdOperateTag.Controls.Add(this.groupBox16);
            this.gbCmdOperateTag.Controls.Add(this.groupBox15);
            this.gbCmdOperateTag.Controls.Add(this.groupBox14);
            this.gbCmdOperateTag.Controls.Add(this.groupBox13);
            this.gbCmdOperateTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCmdOperateTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCmdOperateTag.Location = new System.Drawing.Point(0, 0);
            this.gbCmdOperateTag.Name = "gbCmdOperateTag";
            this.gbCmdOperateTag.Size = new System.Drawing.Size(1331, 348);
            this.gbCmdOperateTag.TabIndex = 8;
            this.gbCmdOperateTag.TabStop = false;
            this.gbCmdOperateTag.Text = "Tag Access";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.btnKillTag);
            this.groupBox16.Controls.Add(this.htxtKillPwd);
            this.groupBox16.Controls.Add(this.label29);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox16.Location = new System.Drawing.Point(3, 277);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(1325, 54);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Kill Tag";
            // 
            // btnKillTag
            // 
            this.btnKillTag.Location = new System.Drawing.Point(888, 20);
            this.btnKillTag.Name = "btnKillTag";
            this.btnKillTag.Size = new System.Drawing.Size(90, 25);
            this.btnKillTag.TabIndex = 14;
            this.btnKillTag.Text = "Kill";
            this.btnKillTag.UseVisualStyleBackColor = true;
            this.btnKillTag.Click += new System.EventHandler(this.btnKillTag_Click);
            // 
            // htxtKillPwd
            // 
            this.htxtKillPwd.Location = new System.Drawing.Point(402, 23);
            this.htxtKillPwd.Name = "htxtKillPwd";
            this.htxtKillPwd.Size = new System.Drawing.Size(120, 21);
            this.htxtKillPwd.TabIndex = 13;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(284, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(117, 15);
            this.label29.TabIndex = 13;
            this.label29.Text = "Kill Password(HEX):";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.htxtLockPwd);
            this.groupBox15.Controls.Add(this.label28);
            this.groupBox15.Controls.Add(this.groupBox19);
            this.groupBox15.Controls.Add(this.groupBox18);
            this.groupBox15.Controls.Add(this.btnLockTag);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Location = new System.Drawing.Point(3, 174);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1325, 103);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Lock Tag";
            // 
            // htxtLockPwd
            // 
            this.htxtLockPwd.Location = new System.Drawing.Point(742, 49);
            this.htxtLockPwd.Name = "htxtLockPwd";
            this.htxtLockPwd.Size = new System.Drawing.Size(114, 21);
            this.htxtLockPwd.TabIndex = 12;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(606, 53);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(138, 15);
            this.label28.TabIndex = 12;
            this.label28.Text = "Access Password(HEX):";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.rdbUserMemory);
            this.groupBox19.Controls.Add(this.rdbTidMemory);
            this.groupBox19.Controls.Add(this.rdbEpcMermory);
            this.groupBox19.Controls.Add(this.rdbKillPwd);
            this.groupBox19.Controls.Add(this.rdbAccessPwd);
            this.groupBox19.Location = new System.Drawing.Point(16, 15);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(578, 43);
            this.groupBox19.TabIndex = 2;
            this.groupBox19.TabStop = false;
            // 
            // rdbUserMemory
            // 
            this.rdbUserMemory.AutoSize = true;
            this.rdbUserMemory.Location = new System.Drawing.Point(464, 16);
            this.rdbUserMemory.Name = "rdbUserMemory";
            this.rdbUserMemory.Size = new System.Drawing.Size(59, 19);
            this.rdbUserMemory.TabIndex = 4;
            this.rdbUserMemory.TabStop = true;
            this.rdbUserMemory.Text = "USER";
            this.rdbUserMemory.UseVisualStyleBackColor = true;
            // 
            // rdbTidMemory
            // 
            this.rdbTidMemory.AutoSize = true;
            this.rdbTidMemory.Location = new System.Drawing.Point(375, 16);
            this.rdbTidMemory.Name = "rdbTidMemory";
            this.rdbTidMemory.Size = new System.Drawing.Size(44, 19);
            this.rdbTidMemory.TabIndex = 3;
            this.rdbTidMemory.TabStop = true;
            this.rdbTidMemory.Text = "TID";
            this.rdbTidMemory.UseVisualStyleBackColor = true;
            // 
            // rdbEpcMermory
            // 
            this.rdbEpcMermory.AutoSize = true;
            this.rdbEpcMermory.Location = new System.Drawing.Point(269, 16);
            this.rdbEpcMermory.Name = "rdbEpcMermory";
            this.rdbEpcMermory.Size = new System.Drawing.Size(49, 19);
            this.rdbEpcMermory.TabIndex = 2;
            this.rdbEpcMermory.TabStop = true;
            this.rdbEpcMermory.Text = "EPC";
            this.rdbEpcMermory.UseVisualStyleBackColor = true;
            // 
            // rdbKillPwd
            // 
            this.rdbKillPwd.AutoSize = true;
            this.rdbKillPwd.Location = new System.Drawing.Point(142, 16);
            this.rdbKillPwd.Name = "rdbKillPwd";
            this.rdbKillPwd.Size = new System.Drawing.Size(99, 19);
            this.rdbKillPwd.TabIndex = 1;
            this.rdbKillPwd.TabStop = true;
            this.rdbKillPwd.Text = "Kill Password";
            this.rdbKillPwd.UseVisualStyleBackColor = true;
            // 
            // rdbAccessPwd
            // 
            this.rdbAccessPwd.AutoSize = true;
            this.rdbAccessPwd.Location = new System.Drawing.Point(9, 16);
            this.rdbAccessPwd.Name = "rdbAccessPwd";
            this.rdbAccessPwd.Size = new System.Drawing.Size(120, 19);
            this.rdbAccessPwd.TabIndex = 0;
            this.rdbAccessPwd.TabStop = true;
            this.rdbAccessPwd.Text = "Access Password";
            this.rdbAccessPwd.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.rdbLockEver);
            this.groupBox18.Controls.Add(this.rdbFreeEver);
            this.groupBox18.Controls.Add(this.rdbLock);
            this.groupBox18.Controls.Add(this.rdbFree);
            this.groupBox18.Location = new System.Drawing.Point(16, 55);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(578, 43);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            // 
            // rdbLockEver
            // 
            this.rdbLockEver.AutoSize = true;
            this.rdbLockEver.Location = new System.Drawing.Point(453, 15);
            this.rdbLockEver.Name = "rdbLockEver";
            this.rdbLockEver.Size = new System.Drawing.Size(115, 19);
            this.rdbLockEver.TabIndex = 3;
            this.rdbLockEver.TabStop = true;
            this.rdbLockEver.Text = "Permanent Lock";
            this.rdbLockEver.UseVisualStyleBackColor = true;
            // 
            // rdbFreeEver
            // 
            this.rdbFreeEver.AutoSize = true;
            this.rdbFreeEver.Location = new System.Drawing.Point(293, 15);
            this.rdbFreeEver.Name = "rdbFreeEver";
            this.rdbFreeEver.Size = new System.Drawing.Size(119, 19);
            this.rdbFreeEver.TabIndex = 2;
            this.rdbFreeEver.TabStop = true;
            this.rdbFreeEver.Text = "Permanent Open";
            this.rdbFreeEver.UseVisualStyleBackColor = true;
            // 
            // rdbLock
            // 
            this.rdbLock.AutoSize = true;
            this.rdbLock.Location = new System.Drawing.Point(144, 15);
            this.rdbLock.Name = "rdbLock";
            this.rdbLock.Size = new System.Drawing.Size(51, 19);
            this.rdbLock.TabIndex = 1;
            this.rdbLock.TabStop = true;
            this.rdbLock.Text = "Lock";
            this.rdbLock.UseVisualStyleBackColor = true;
            // 
            // rdbFree
            // 
            this.rdbFree.AutoSize = true;
            this.rdbFree.Location = new System.Drawing.Point(9, 15);
            this.rdbFree.Name = "rdbFree";
            this.rdbFree.Size = new System.Drawing.Size(55, 19);
            this.rdbFree.TabIndex = 0;
            this.rdbFree.TabStop = true;
            this.rdbFree.Text = "Open";
            this.rdbFree.UseVisualStyleBackColor = true;
            // 
            // btnLockTag
            // 
            this.btnLockTag.Location = new System.Drawing.Point(888, 48);
            this.btnLockTag.Name = "btnLockTag";
            this.btnLockTag.Size = new System.Drawing.Size(90, 25);
            this.btnLockTag.TabIndex = 0;
            this.btnLockTag.Text = "Lock";
            this.btnLockTag.UseVisualStyleBackColor = true;
            this.btnLockTag.Click += new System.EventHandler(this.btnLockTag_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.htxtWriteData);
            this.groupBox14.Controls.Add(this.txtWordCnt);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Controls.Add(this.btnWriteTag);
            this.groupBox14.Controls.Add(this.btnReadTag);
            this.groupBox14.Controls.Add(this.txtWordAdd);
            this.groupBox14.Controls.Add(this.label26);
            this.groupBox14.Controls.Add(this.htxtReadAndWritePwd);
            this.groupBox14.Controls.Add(this.label25);
            this.groupBox14.Controls.Add(this.groupBox17);
            this.groupBox14.Controls.Add(this.label24);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox14.Location = new System.Drawing.Point(3, 71);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1325, 103);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Read/Write Tag";
            // 
            // htxtWriteData
            // 
            this.htxtWriteData.Location = new System.Drawing.Point(171, 74);
            this.htxtWriteData.Name = "htxtWriteData";
            this.htxtWriteData.Size = new System.Drawing.Size(685, 21);
            this.htxtWriteData.TabIndex = 10;
            // 
            // txtWordCnt
            // 
            this.txtWordCnt.Location = new System.Drawing.Point(808, 25);
            this.txtWordCnt.Name = "txtWordCnt";
            this.txtWordCnt.Size = new System.Drawing.Size(48, 21);
            this.txtWordCnt.TabIndex = 9;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(719, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(94, 15);
            this.label27.TabIndex = 8;
            this.label27.Text = "Length(WORD):";
            // 
            // btnWriteTag
            // 
            this.btnWriteTag.Location = new System.Drawing.Point(888, 72);
            this.btnWriteTag.Name = "btnWriteTag";
            this.btnWriteTag.Size = new System.Drawing.Size(90, 25);
            this.btnWriteTag.TabIndex = 7;
            this.btnWriteTag.Text = "Write";
            this.btnWriteTag.UseVisualStyleBackColor = true;
            this.btnWriteTag.Click += new System.EventHandler(this.btnWriteTag_Click);
            // 
            // btnReadTag
            // 
            this.btnReadTag.Location = new System.Drawing.Point(888, 24);
            this.btnReadTag.Name = "btnReadTag";
            this.btnReadTag.Size = new System.Drawing.Size(90, 25);
            this.btnReadTag.TabIndex = 6;
            this.btnReadTag.Text = "Read";
            this.btnReadTag.UseVisualStyleBackColor = true;
            this.btnReadTag.Click += new System.EventHandler(this.btnReadTag_Click);
            // 
            // txtWordAdd
            // 
            this.txtWordAdd.Location = new System.Drawing.Point(655, 25);
            this.txtWordAdd.Name = "txtWordAdd";
            this.txtWordAdd.Size = new System.Drawing.Size(48, 21);
            this.txtWordAdd.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(548, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 15);
            this.label26.TabIndex = 4;
            this.label26.Text = "Start Add(WORD):";
            // 
            // htxtReadAndWritePwd
            // 
            this.htxtReadAndWritePwd.Location = new System.Drawing.Point(410, 25);
            this.htxtReadAndWritePwd.Name = "htxtReadAndWritePwd";
            this.htxtReadAndWritePwd.Size = new System.Drawing.Size(120, 21);
            this.htxtReadAndWritePwd.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(273, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(138, 15);
            this.label25.TabIndex = 2;
            this.label25.Text = "Access Password(HEX):";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.rdbUser);
            this.groupBox17.Controls.Add(this.rdbTid);
            this.groupBox17.Controls.Add(this.rdbEpc);
            this.groupBox17.Controls.Add(this.rdbReserved);
            this.groupBox17.Location = new System.Drawing.Point(18, 13);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(242, 43);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Location = new System.Drawing.Point(179, 14);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(59, 19);
            this.rdbUser.TabIndex = 3;
            this.rdbUser.TabStop = true;
            this.rdbUser.Text = "USER";
            this.rdbUser.UseVisualStyleBackColor = true;
            // 
            // rdbTid
            // 
            this.rdbTid.AutoSize = true;
            this.rdbTid.Location = new System.Drawing.Point(130, 14);
            this.rdbTid.Name = "rdbTid";
            this.rdbTid.Size = new System.Drawing.Size(44, 19);
            this.rdbTid.TabIndex = 2;
            this.rdbTid.TabStop = true;
            this.rdbTid.Text = "TID";
            this.rdbTid.UseVisualStyleBackColor = true;
            // 
            // rdbEpc
            // 
            this.rdbEpc.AutoSize = true;
            this.rdbEpc.Location = new System.Drawing.Point(83, 14);
            this.rdbEpc.Name = "rdbEpc";
            this.rdbEpc.Size = new System.Drawing.Size(49, 19);
            this.rdbEpc.TabIndex = 1;
            this.rdbEpc.TabStop = true;
            this.rdbEpc.Text = "EPC";
            this.rdbEpc.UseVisualStyleBackColor = true;
            // 
            // rdbReserved
            // 
            this.rdbReserved.AutoSize = true;
            this.rdbReserved.Location = new System.Drawing.Point(5, 14);
            this.rdbReserved.Name = "rdbReserved";
            this.rdbReserved.Size = new System.Drawing.Size(79, 19);
            this.rdbReserved.TabIndex = 0;
            this.rdbReserved.TabStop = true;
            this.rdbReserved.Text = "Password";
            this.rdbReserved.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(138, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "Data to be written(HEX):";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Controls.Add(this.btnSetAccessEpcMatch);
            this.groupBox13.Controls.Add(this.cmbSetAccessEpcMatch);
            this.groupBox13.Controls.Add(this.txtAccessEpcMatch);
            this.groupBox13.Controls.Add(this.ckAccessEpcMatch);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Location = new System.Drawing.Point(3, 17);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1325, 54);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Tag Selection";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(468, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 15);
            this.label23.TabIndex = 4;
            this.label23.Text = "Tag List:";
            // 
            // btnSetAccessEpcMatch
            // 
            this.btnSetAccessEpcMatch.Location = new System.Drawing.Point(888, 19);
            this.btnSetAccessEpcMatch.Name = "btnSetAccessEpcMatch";
            this.btnSetAccessEpcMatch.Size = new System.Drawing.Size(90, 25);
            this.btnSetAccessEpcMatch.TabIndex = 3;
            this.btnSetAccessEpcMatch.Text = "Select";
            this.btnSetAccessEpcMatch.UseVisualStyleBackColor = true;
            this.btnSetAccessEpcMatch.Click += new System.EventHandler(this.btnSetAccessEpcMatch_Click);
            // 
            // cmbSetAccessEpcMatch
            // 
            this.cmbSetAccessEpcMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetAccessEpcMatch.FormattingEnabled = true;
            this.cmbSetAccessEpcMatch.Location = new System.Drawing.Point(533, 20);
            this.cmbSetAccessEpcMatch.Name = "cmbSetAccessEpcMatch";
            this.cmbSetAccessEpcMatch.Size = new System.Drawing.Size(323, 23);
            this.cmbSetAccessEpcMatch.TabIndex = 2;
            this.cmbSetAccessEpcMatch.DropDown += new System.EventHandler(this.cmbSetAccessEpcMatch_DropDown);
            // 
            // txtAccessEpcMatch
            // 
            this.txtAccessEpcMatch.Location = new System.Drawing.Point(123, 19);
            this.txtAccessEpcMatch.Name = "txtAccessEpcMatch";
            this.txtAccessEpcMatch.ReadOnly = true;
            this.txtAccessEpcMatch.Size = new System.Drawing.Size(320, 21);
            this.txtAccessEpcMatch.TabIndex = 1;
            // 
            // ckAccessEpcMatch
            // 
            this.ckAccessEpcMatch.AutoSize = true;
            this.ckAccessEpcMatch.Location = new System.Drawing.Point(16, 22);
            this.ckAccessEpcMatch.Name = "ckAccessEpcMatch";
            this.ckAccessEpcMatch.Size = new System.Drawing.Size(101, 19);
            this.ckAccessEpcMatch.TabIndex = 0;
            this.ckAccessEpcMatch.Text = "Selected Tag:";
            this.ckAccessEpcMatch.UseVisualStyleBackColor = true;
            this.ckAccessEpcMatch.CheckedChanged += new System.EventHandler(this.cbAccessEpcMatch_CheckedChanged);
            // 
            // PagISO18000
            // 
            this.PagISO18000.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PagISO18000.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagISO18000.Controls.Add(this.btnClear);
            this.PagISO18000.Controls.Add(this.btnInventoryISO18000);
            this.PagISO18000.Controls.Add(this.ltvTagISO18000);
            this.PagISO18000.Controls.Add(this.gbISO1800LockQuery);
            this.PagISO18000.Controls.Add(this.gbISO1800ReadWrite);
            this.PagISO18000.Controls.Add(this.label41);
            this.PagISO18000.Controls.Add(this.htxtReadUID);
            this.PagISO18000.Location = new System.Drawing.Point(4, 22);
            this.PagISO18000.Name = "PagISO18000";
            this.PagISO18000.Size = new System.Drawing.Size(1341, 655);
            this.PagISO18000.TabIndex = 4;
            this.PagISO18000.Text = "ISO 18000-6B Tag Test";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(887, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Refresh";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInventoryISO18000
            // 
            this.btnInventoryISO18000.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInventoryISO18000.ForeColor = System.Drawing.Color.Indigo;
            this.btnInventoryISO18000.Location = new System.Drawing.Point(8, 11);
            this.btnInventoryISO18000.Name = "btnInventoryISO18000";
            this.btnInventoryISO18000.Size = new System.Drawing.Size(120, 38);
            this.btnInventoryISO18000.TabIndex = 3;
            this.btnInventoryISO18000.Text = "Inventory";
            this.btnInventoryISO18000.UseVisualStyleBackColor = true;
            this.btnInventoryISO18000.Click += new System.EventHandler(this.btnInventoryISO18000_Click);
            // 
            // ltvTagISO18000
            // 
            this.ltvTagISO18000.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader28});
            this.ltvTagISO18000.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ltvTagISO18000.FullRowSelect = true;
            this.ltvTagISO18000.GridLines = true;
            this.ltvTagISO18000.Location = new System.Drawing.Point(3, 55);
            this.ltvTagISO18000.Name = "ltvTagISO18000";
            this.ltvTagISO18000.Size = new System.Drawing.Size(458, 544);
            this.ltvTagISO18000.TabIndex = 9;
            this.ltvTagISO18000.UseCompatibleStateImageBehavior = false;
            this.ltvTagISO18000.View = System.Windows.Forms.View.Details;
            this.ltvTagISO18000.Click += new System.EventHandler(this.ltvTagISO18000_Click);
            this.ltvTagISO18000.DoubleClick += new System.EventHandler(this.ltvTagISO18000_DoubleClick);
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "ID";
            this.columnHeader27.Width = 38;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "UID";
            this.columnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader25.Width = 201;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Ant ID";
            this.columnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader26.Width = 58;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Identification Count";
            this.columnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader28.Width = 153;
            // 
            // gbISO1800LockQuery
            // 
            this.gbISO1800LockQuery.Controls.Add(this.txtStatus);
            this.gbISO1800LockQuery.Controls.Add(this.htxtQueryAdd);
            this.gbISO1800LockQuery.Controls.Add(this.label46);
            this.gbISO1800LockQuery.Controls.Add(this.htxtLockAdd);
            this.gbISO1800LockQuery.Controls.Add(this.label47);
            this.gbISO1800LockQuery.Controls.Add(this.btnQueryTagISO18000);
            this.gbISO1800LockQuery.Controls.Add(this.btnLockTagISO18000);
            this.gbISO1800LockQuery.Location = new System.Drawing.Point(487, 506);
            this.gbISO1800LockQuery.Name = "gbISO1800LockQuery";
            this.gbISO1800LockQuery.Size = new System.Drawing.Size(515, 93);
            this.gbISO1800LockQuery.TabIndex = 7;
            this.gbISO1800LockQuery.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(263, 63);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(128, 20);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htxtQueryAdd
            // 
            this.htxtQueryAdd.Location = new System.Drawing.Point(210, 63);
            this.htxtQueryAdd.MaxLength = 2;
            this.htxtQueryAdd.Name = "htxtQueryAdd";
            this.htxtQueryAdd.Size = new System.Drawing.Size(39, 20);
            this.htxtQueryAdd.TabIndex = 8;
            this.htxtQueryAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(13, 67);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(167, 13);
            this.label46.TabIndex = 5;
            this.label46.Text = "Query Lock Status Address(HEX):";
            // 
            // htxtLockAdd
            // 
            this.htxtLockAdd.Location = new System.Drawing.Point(210, 27);
            this.htxtLockAdd.MaxLength = 2;
            this.htxtLockAdd.Name = "htxtLockAdd";
            this.htxtLockAdd.Size = new System.Drawing.Size(39, 20);
            this.htxtLockAdd.TabIndex = 8;
            this.htxtLockAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(31, 32);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(157, 13);
            this.label47.TabIndex = 5;
            this.label47.Text = "Permanent Lock Address(HEX):";
            // 
            // btnQueryTagISO18000
            // 
            this.btnQueryTagISO18000.Location = new System.Drawing.Point(400, 58);
            this.btnQueryTagISO18000.Name = "btnQueryTagISO18000";
            this.btnQueryTagISO18000.Size = new System.Drawing.Size(100, 30);
            this.btnQueryTagISO18000.TabIndex = 3;
            this.btnQueryTagISO18000.Text = "Query";
            this.btnQueryTagISO18000.UseVisualStyleBackColor = true;
            this.btnQueryTagISO18000.Click += new System.EventHandler(this.btnQueryTagISO18000_Click);
            // 
            // btnLockTagISO18000
            // 
            this.btnLockTagISO18000.Location = new System.Drawing.Point(400, 23);
            this.btnLockTagISO18000.Name = "btnLockTagISO18000";
            this.btnLockTagISO18000.Size = new System.Drawing.Size(100, 30);
            this.btnLockTagISO18000.TabIndex = 3;
            this.btnLockTagISO18000.Text = "Lock";
            this.btnLockTagISO18000.UseVisualStyleBackColor = true;
            this.btnLockTagISO18000.Click += new System.EventHandler(this.btnLockTagISO18000_Click);
            // 
            // gbISO1800ReadWrite
            // 
            this.gbISO1800ReadWrite.Controls.Add(this.txtLoopTimes);
            this.gbISO1800ReadWrite.Controls.Add(this.label44);
            this.gbISO1800ReadWrite.Controls.Add(this.txtLoop);
            this.gbISO1800ReadWrite.Controls.Add(this.label40);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtWriteData18000);
            this.gbISO1800ReadWrite.Controls.Add(this.txtWriteLength);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtReadData18000);
            this.gbISO1800ReadWrite.Controls.Add(this.label45);
            this.gbISO1800ReadWrite.Controls.Add(this.btnWriteTagISO18000);
            this.gbISO1800ReadWrite.Controls.Add(this.label51);
            this.gbISO1800ReadWrite.Controls.Add(this.label52);
            this.gbISO1800ReadWrite.Controls.Add(this.txtReadLength);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtWriteStartAdd);
            this.gbISO1800ReadWrite.Controls.Add(this.label50);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtReadStartAdd);
            this.gbISO1800ReadWrite.Controls.Add(this.label42);
            this.gbISO1800ReadWrite.Controls.Add(this.label43);
            this.gbISO1800ReadWrite.Controls.Add(this.btnReadTagISO18000);
            this.gbISO1800ReadWrite.Location = new System.Drawing.Point(487, 61);
            this.gbISO1800ReadWrite.Name = "gbISO1800ReadWrite";
            this.gbISO1800ReadWrite.Size = new System.Drawing.Size(515, 445);
            this.gbISO1800ReadWrite.TabIndex = 4;
            this.gbISO1800ReadWrite.TabStop = false;
            this.gbISO1800ReadWrite.Text = "Read/Write Tag with Unlimited Length";
            // 
            // txtLoopTimes
            // 
            this.txtLoopTimes.Location = new System.Drawing.Point(274, 237);
            this.txtLoopTimes.Name = "txtLoopTimes";
            this.txtLoopTimes.ReadOnly = true;
            this.txtLoopTimes.Size = new System.Drawing.Size(41, 20);
            this.txtLoopTimes.TabIndex = 15;
            this.txtLoopTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(203, 241);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(65, 13);
            this.label44.TabIndex = 14;
            this.label44.Text = "Succeeded:";
            // 
            // txtLoop
            // 
            this.txtLoop.Location = new System.Drawing.Point(117, 237);
            this.txtLoop.Name = "txtLoop";
            this.txtLoop.Size = new System.Drawing.Size(39, 20);
            this.txtLoop.TabIndex = 13;
            this.txtLoop.Text = "1";
            this.txtLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 241);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(98, 13);
            this.label40.TabIndex = 12;
            this.label40.Text = "Command Repead:";
            // 
            // htxtWriteData18000
            // 
            this.htxtWriteData18000.Location = new System.Drawing.Point(117, 267);
            this.htxtWriteData18000.Multiline = true;
            this.htxtWriteData18000.Name = "htxtWriteData18000";
            this.htxtWriteData18000.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htxtWriteData18000.Size = new System.Drawing.Size(383, 171);
            this.htxtWriteData18000.TabIndex = 9;
            // 
            // txtWriteLength
            // 
            this.txtWriteLength.Location = new System.Drawing.Point(274, 208);
            this.txtWriteLength.MaxLength = 2;
            this.txtWriteLength.Name = "txtWriteLength";
            this.txtWriteLength.ReadOnly = true;
            this.txtWriteLength.Size = new System.Drawing.Size(41, 20);
            this.txtWriteLength.TabIndex = 11;
            this.txtWriteLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htxtReadData18000
            // 
            this.htxtReadData18000.Location = new System.Drawing.Point(117, 53);
            this.htxtReadData18000.Multiline = true;
            this.htxtReadData18000.Name = "htxtReadData18000";
            this.htxtReadData18000.ReadOnly = true;
            this.htxtReadData18000.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htxtReadData18000.Size = new System.Drawing.Size(383, 144);
            this.htxtReadData18000.TabIndex = 11;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(46, 271);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 13);
            this.label45.TabIndex = 6;
            this.label45.Text = "Data(HEX):";
            // 
            // btnWriteTagISO18000
            // 
            this.btnWriteTagISO18000.Location = new System.Drawing.Point(400, 233);
            this.btnWriteTagISO18000.Name = "btnWriteTagISO18000";
            this.btnWriteTagISO18000.Size = new System.Drawing.Size(100, 30);
            this.btnWriteTagISO18000.TabIndex = 3;
            this.btnWriteTagISO18000.Text = "Write";
            this.btnWriteTagISO18000.UseVisualStyleBackColor = true;
            this.btnWriteTagISO18000.Click += new System.EventHandler(this.btnWriteTagISO18000_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(191, 212);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(71, 13);
            this.label51.TabIndex = 10;
            this.label51.Text = "Length(HEX):";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(46, 56);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(61, 13);
            this.label52.TabIndex = 10;
            this.label52.Text = "Data(HEX):";
            // 
            // txtReadLength
            // 
            this.txtReadLength.Location = new System.Drawing.Point(274, 20);
            this.txtReadLength.MaxLength = 2;
            this.txtReadLength.Name = "txtReadLength";
            this.txtReadLength.Size = new System.Drawing.Size(41, 20);
            this.txtReadLength.TabIndex = 9;
            this.txtReadLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htxtWriteStartAdd
            // 
            this.htxtWriteStartAdd.Location = new System.Drawing.Point(117, 208);
            this.htxtWriteStartAdd.MaxLength = 2;
            this.htxtWriteStartAdd.Name = "htxtWriteStartAdd";
            this.htxtWriteStartAdd.Size = new System.Drawing.Size(39, 20);
            this.htxtWriteStartAdd.TabIndex = 8;
            this.htxtWriteStartAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(191, 25);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(71, 13);
            this.label50.TabIndex = 8;
            this.label50.Text = "Length(HEX):";
            // 
            // htxtReadStartAdd
            // 
            this.htxtReadStartAdd.Location = new System.Drawing.Point(117, 20);
            this.htxtReadStartAdd.MaxLength = 2;
            this.htxtReadStartAdd.Name = "htxtReadStartAdd";
            this.htxtReadStartAdd.Size = new System.Drawing.Size(39, 20);
            this.htxtReadStartAdd.TabIndex = 7;
            this.htxtReadStartAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(16, 25);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 13);
            this.label42.TabIndex = 5;
            this.label42.Text = "Start Add(HEX):";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(16, 212);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 13);
            this.label43.TabIndex = 5;
            this.label43.Text = "Start Add(HEX):";
            // 
            // btnReadTagISO18000
            // 
            this.btnReadTagISO18000.Location = new System.Drawing.Point(400, 16);
            this.btnReadTagISO18000.Name = "btnReadTagISO18000";
            this.btnReadTagISO18000.Size = new System.Drawing.Size(100, 30);
            this.btnReadTagISO18000.TabIndex = 3;
            this.btnReadTagISO18000.Text = "Read";
            this.btnReadTagISO18000.UseVisualStyleBackColor = true;
            this.btnReadTagISO18000.Click += new System.EventHandler(this.btnReadTagISO18000_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(503, 32);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(74, 13);
            this.label41.TabIndex = 4;
            this.label41.Text = "Selected UID:";
            // 
            // htxtReadUID
            // 
            this.htxtReadUID.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.htxtReadUID.Location = new System.Drawing.Point(604, 29);
            this.htxtReadUID.Name = "htxtReadUID";
            this.htxtReadUID.ReadOnly = true;
            this.htxtReadUID.Size = new System.Drawing.Size(195, 21);
            this.htxtReadUID.TabIndex = 6;
            this.htxtReadUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PagTranDataLog
            // 
            this.PagTranDataLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagTranDataLog.Controls.Add(this.gbCmdManual);
            this.PagTranDataLog.Controls.Add(this.lrtxtDataTran);
            this.PagTranDataLog.Location = new System.Drawing.Point(4, 22);
            this.PagTranDataLog.Name = "PagTranDataLog";
            this.PagTranDataLog.Size = new System.Drawing.Size(1341, 655);
            this.PagTranDataLog.TabIndex = 2;
            this.PagTranDataLog.Text = "Serial Port Monitor";
            this.PagTranDataLog.UseVisualStyleBackColor = true;
            // 
            // gbCmdManual
            // 
            this.gbCmdManual.Controls.Add(this.label16);
            this.gbCmdManual.Controls.Add(this.htxtSendData);
            this.gbCmdManual.Controls.Add(this.btnClearData);
            this.gbCmdManual.Controls.Add(this.label17);
            this.gbCmdManual.Controls.Add(this.btnSendData);
            this.gbCmdManual.Controls.Add(this.htxtCheckData);
            this.gbCmdManual.Location = new System.Drawing.Point(2, 516);
            this.gbCmdManual.Name = "gbCmdManual";
            this.gbCmdManual.Size = new System.Drawing.Size(1002, 55);
            this.gbCmdManual.TabIndex = 8;
            this.gbCmdManual.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Input Command:";
            // 
            // htxtSendData
            // 
            this.htxtSendData.Location = new System.Drawing.Point(95, 17);
            this.htxtSendData.Name = "htxtSendData";
            this.htxtSendData.Size = new System.Drawing.Size(515, 20);
            this.htxtSendData.TabIndex = 2;
            this.htxtSendData.Leave += new System.EventHandler(this.htxtSendData_Leave);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(906, 15);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(90, 25);
            this.btnClearData.TabIndex = 6;
            this.btnClearData.Text = "Clear";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(629, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Check Sum:";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(810, 15);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(90, 25);
            this.btnSendData.TabIndex = 5;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // htxtCheckData
            // 
            this.htxtCheckData.Location = new System.Drawing.Point(700, 17);
            this.htxtCheckData.Name = "htxtCheckData";
            this.htxtCheckData.ReadOnly = true;
            this.htxtCheckData.Size = new System.Drawing.Size(47, 20);
            this.htxtCheckData.TabIndex = 4;
            // 
            // lrtxtDataTran
            // 
            this.lrtxtDataTran.Dock = System.Windows.Forms.DockStyle.Top;
            this.lrtxtDataTran.Location = new System.Drawing.Point(0, 0);
            this.lrtxtDataTran.Name = "lrtxtDataTran";
            this.lrtxtDataTran.Size = new System.Drawing.Size(1341, 510);
            this.lrtxtDataTran.TabIndex = 0;
            this.lrtxtDataTran.Text = "";
            this.lrtxtDataTran.DoubleClick += new System.EventHandler(this.lrtxtDataTran_DoubleClick);
            // 
            // Pc
            // 
            this.Pc.Name = "Pc";
            // 
            // Rssi
            // 
            this.Rssi.Name = "Rssi";
            // 
            // CarrFrequency
            // 
            this.CarrFrequency.Name = "CarrFrequency";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label114);
            this.panel12.Controls.Add(this.label115);
            this.panel12.Controls.Add(this.label116);
            this.panel12.Controls.Add(this.dataGridView1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1245, 107);
            this.panel12.TabIndex = 7;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(481, 11);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(63, 13);
            this.label114.TabIndex = 4;
            this.label114.Text = "NICKNAME";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(247, 11);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(38, 13);
            this.label115.TabIndex = 2;
            this.label115.Text = "NAME";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(9, 11);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(79, 13);
            this.label116.TabIndex = 0;
            this.label116.Text = "PILOT #1 TAG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 63);
            this.dataGridView1.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.66265F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.33735F));
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(996, 55);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 47);
            this.panel6.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(126, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "开始盘存";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.checkBox5);
            this.panel7.Controls.Add(this.checkBox6);
            this.panel7.Controls.Add(this.checkBox7);
            this.panel7.Controls.Add(this.checkBox8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(408, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 47);
            this.panel7.TabIndex = 1;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox5.Location = new System.Drawing.Point(64, 17);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(57, 16);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "天线1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox6.Location = new System.Drawing.Point(436, 17);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(57, 16);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "天线4";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox7.Location = new System.Drawing.Point(312, 17);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(57, 16);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.Text = "天线3";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox8.Location = new System.Drawing.Point(188, 17);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(57, 16);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "天线2";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(704, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(89, 20);
            this.textBox5.TabIndex = 46;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(502, 234);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(89, 20);
            this.textBox6.TabIndex = 47;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(907, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "刷新界面";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label76.Location = new System.Drawing.Point(633, 237);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(65, 12);
            this.label76.TabIndex = 43;
            this.label76.Text = "Max RSSI：";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label77.Location = new System.Drawing.Point(431, 238);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(65, 12);
            this.label77.TabIndex = 44;
            this.label77.Text = "Min RSSI：";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label78.Location = new System.Drawing.Point(6, 237);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(71, 12);
            this.label78.TabIndex = 42;
            this.label78.Text = "标签列表： ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox9);
            this.groupBox8.Controls.Add(this.lxLedControl9);
            this.groupBox8.Controls.Add(this.lxLedControl10);
            this.groupBox8.Controls.Add(this.lxLedControl11);
            this.groupBox8.Controls.Add(this.lxLedControl12);
            this.groupBox8.Controls.Add(this.label79);
            this.groupBox8.Controls.Add(this.label80);
            this.groupBox8.Controls.Add(this.label81);
            this.groupBox8.Controls.Add(this.label82);
            this.groupBox8.Controls.Add(this.label83);
            this.groupBox8.Controls.Add(this.lxLedControl13);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox8.Location = new System.Drawing.Point(2, 64);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(996, 162);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "数据";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox9.Location = new System.Drawing.Point(-165, 111);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(55, 21);
            this.comboBox9.TabIndex = 39;
            // 
            // lxLedControl9
            // 
            this.lxLedControl9.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl9.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl9.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl9.BevelRate = 0.1F;
            this.lxLedControl9.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl9.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl9.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl9.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl9.HighlightOpaque = ((byte)(20));
            this.lxLedControl9.Location = new System.Drawing.Point(702, 118);
            this.lxLedControl9.Name = "lxLedControl9";
            this.lxLedControl9.RoundCorner = true;
            this.lxLedControl9.SegmentIntervalRatio = 50;
            this.lxLedControl9.ShowHighlight = true;
            this.lxLedControl9.Size = new System.Drawing.Size(183, 35);
            this.lxLedControl9.TabIndex = 35;
            this.lxLedControl9.Text = "0";
            this.lxLedControl9.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl9.TotalCharCount = 10;
            // 
            // lxLedControl10
            // 
            this.lxLedControl10.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl10.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl10.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl10.BevelRate = 0.1F;
            this.lxLedControl10.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl10.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl10.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl10.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl10.HighlightOpaque = ((byte)(20));
            this.lxLedControl10.Location = new System.Drawing.Point(496, 35);
            this.lxLedControl10.Name = "lxLedControl10";
            this.lxLedControl10.RoundCorner = true;
            this.lxLedControl10.SegmentIntervalRatio = 50;
            this.lxLedControl10.ShowHighlight = true;
            this.lxLedControl10.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl10.TabIndex = 34;
            this.lxLedControl10.Text = "0";
            this.lxLedControl10.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl11
            // 
            this.lxLedControl11.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl11.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl11.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl11.BevelRate = 0.1F;
            this.lxLedControl11.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl11.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl11.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl11.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl11.HighlightOpaque = ((byte)(20));
            this.lxLedControl11.Location = new System.Drawing.Point(497, 103);
            this.lxLedControl11.Name = "lxLedControl11";
            this.lxLedControl11.RoundCorner = true;
            this.lxLedControl11.SegmentIntervalRatio = 50;
            this.lxLedControl11.ShowHighlight = true;
            this.lxLedControl11.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl11.TabIndex = 33;
            this.lxLedControl11.Text = "0";
            this.lxLedControl11.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl12
            // 
            this.lxLedControl12.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl12.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl12.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl12.BevelRate = 0.1F;
            this.lxLedControl12.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl12.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl12.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl12.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl12.HighlightOpaque = ((byte)(20));
            this.lxLedControl12.Location = new System.Drawing.Point(702, 35);
            this.lxLedControl12.Name = "lxLedControl12";
            this.lxLedControl12.RoundCorner = true;
            this.lxLedControl12.SegmentIntervalRatio = 50;
            this.lxLedControl12.ShowHighlight = true;
            this.lxLedControl12.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl12.TabIndex = 32;
            this.lxLedControl12.Text = "0";
            this.lxLedControl12.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label79.Location = new System.Drawing.Point(700, 103);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(127, 13);
            this.label79.TabIndex = 30;
            this.label79.Text = "累计运行的时间(毫秒)：";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label80.Location = new System.Drawing.Point(495, 17);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(120, 13);
            this.label80.TabIndex = 29;
            this.label80.Text = "命令识别速度(个/秒)：";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label81.Location = new System.Drawing.Point(498, 88);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(115, 13);
            this.label81.TabIndex = 28;
            this.label81.Text = "命令执行时间(毫秒)：";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label82.Location = new System.Drawing.Point(700, 17);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(103, 13);
            this.label82.TabIndex = 27;
            this.label82.Text = "命令返回数据(条)：";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label83.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label83.Location = new System.Drawing.Point(104, 17);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(149, 12);
            this.label83.TabIndex = 26;
            this.label83.Text = "已盘存的标签总数量(个)：";
            // 
            // lxLedControl13
            // 
            this.lxLedControl13.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl13.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl13.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl13.BevelRate = 0.1F;
            this.lxLedControl13.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl13.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl13.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl13.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl13.HighlightOpaque = ((byte)(20));
            this.lxLedControl13.Location = new System.Drawing.Point(106, 35);
            this.lxLedControl13.Name = "lxLedControl13";
            this.lxLedControl13.RoundCorner = true;
            this.lxLedControl13.SegmentIntervalRatio = 50;
            this.lxLedControl13.ShowHighlight = true;
            this.lxLedControl13.Size = new System.Drawing.Size(310, 118);
            this.lxLedControl13.TabIndex = 21;
            this.lxLedControl13.Text = "0";
            this.lxLedControl13.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader43,
            this.columnHeader44,
            this.columnHeader45,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(3, 261);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(996, 267);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "ID";
            this.columnHeader43.Width = 56;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "EPC";
            this.columnHeader44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader44.Width = 486;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "PC";
            this.columnHeader45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader45.Width = 83;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "识别次数";
            this.columnHeader46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader46.Width = 129;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "RSSI";
            this.columnHeader47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader47.Width = 95;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "载波频率";
            this.columnHeader48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader48.Width = 92;
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox10.Location = new System.Drawing.Point(-165, 111);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(55, 21);
            this.comboBox10.TabIndex = 39;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label87.Location = new System.Drawing.Point(700, 103);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(137, 12);
            this.label87.TabIndex = 30;
            this.label87.Text = "累计运行的时间(毫秒)：";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label88.Location = new System.Drawing.Point(495, 17);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(131, 12);
            this.label88.TabIndex = 29;
            this.label88.Text = "命令识别速度(个/秒)：";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label89.Location = new System.Drawing.Point(498, 88);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(125, 12);
            this.label89.TabIndex = 28;
            this.label89.Text = "命令执行时间(毫秒)：";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label90.Location = new System.Drawing.Point(700, 17);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(113, 12);
            this.label90.TabIndex = 27;
            this.label90.Text = "命令返回数据(条)：";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label91.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label91.Location = new System.Drawing.Point(104, 17);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(149, 12);
            this.label91.TabIndex = 26;
            this.label91.Text = "已盘存的标签总数量(个)：";
            // 
            // timerInventory
            // 
            this.timerInventory.Interval = 500;
            this.timerInventory.Tick += new System.EventHandler(this.timerInventory_Tick);
            // 
            // lxLedControl14
            // 
            this.lxLedControl14.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl14.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl14.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl14.BevelRate = 0.1F;
            this.lxLedControl14.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl14.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl14.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl14.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl14.HighlightOpaque = ((byte)(20));
            this.lxLedControl14.Location = new System.Drawing.Point(702, 118);
            this.lxLedControl14.Name = "lxLedControl14";
            this.lxLedControl14.RoundCorner = true;
            this.lxLedControl14.SegmentIntervalRatio = 50;
            this.lxLedControl14.ShowHighlight = true;
            this.lxLedControl14.Size = new System.Drawing.Size(183, 35);
            this.lxLedControl14.TabIndex = 35;
            this.lxLedControl14.Text = "0";
            this.lxLedControl14.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl14.TotalCharCount = 10;
            // 
            // lxLedControl15
            // 
            this.lxLedControl15.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl15.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl15.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl15.BevelRate = 0.1F;
            this.lxLedControl15.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl15.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl15.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl15.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl15.HighlightOpaque = ((byte)(20));
            this.lxLedControl15.Location = new System.Drawing.Point(496, 35);
            this.lxLedControl15.Name = "lxLedControl15";
            this.lxLedControl15.RoundCorner = true;
            this.lxLedControl15.SegmentIntervalRatio = 50;
            this.lxLedControl15.ShowHighlight = true;
            this.lxLedControl15.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl15.TabIndex = 34;
            this.lxLedControl15.Text = "0";
            this.lxLedControl15.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl16
            // 
            this.lxLedControl16.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl16.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl16.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl16.BevelRate = 0.1F;
            this.lxLedControl16.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl16.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl16.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl16.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl16.HighlightOpaque = ((byte)(20));
            this.lxLedControl16.Location = new System.Drawing.Point(497, 103);
            this.lxLedControl16.Name = "lxLedControl16";
            this.lxLedControl16.RoundCorner = true;
            this.lxLedControl16.SegmentIntervalRatio = 50;
            this.lxLedControl16.ShowHighlight = true;
            this.lxLedControl16.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl16.TabIndex = 33;
            this.lxLedControl16.Text = "0";
            this.lxLedControl16.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl17
            // 
            this.lxLedControl17.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl17.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl17.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl17.BevelRate = 0.1F;
            this.lxLedControl17.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl17.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl17.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl17.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl17.HighlightOpaque = ((byte)(20));
            this.lxLedControl17.Location = new System.Drawing.Point(702, 35);
            this.lxLedControl17.Name = "lxLedControl17";
            this.lxLedControl17.RoundCorner = true;
            this.lxLedControl17.SegmentIntervalRatio = 50;
            this.lxLedControl17.ShowHighlight = true;
            this.lxLedControl17.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl17.TabIndex = 32;
            this.lxLedControl17.Text = "0";
            this.lxLedControl17.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl18
            // 
            this.lxLedControl18.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl18.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl18.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl18.BevelRate = 0.1F;
            this.lxLedControl18.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl18.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl18.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl18.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl18.HighlightOpaque = ((byte)(20));
            this.lxLedControl18.Location = new System.Drawing.Point(106, 35);
            this.lxLedControl18.Name = "lxLedControl18";
            this.lxLedControl18.RoundCorner = true;
            this.lxLedControl18.SegmentIntervalRatio = 50;
            this.lxLedControl18.ShowHighlight = true;
            this.lxLedControl18.Size = new System.Drawing.Size(310, 118);
            this.lxLedControl18.TabIndex = 21;
            this.lxLedControl18.Text = "0";
            this.lxLedControl18.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // dataGridViewTextBoxColumn233
            // 
            this.dataGridViewTextBoxColumn233.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn233.HeaderText = "Name";
            this.dataGridViewTextBoxColumn233.Name = "dataGridViewTextBoxColumn233";
            this.dataGridViewTextBoxColumn233.ReadOnly = true;
            this.dataGridViewTextBoxColumn233.Width = 200;
            // 
            // dataGridViewTextBoxColumn234
            // 
            this.dataGridViewTextBoxColumn234.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn234.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn234.Name = "dataGridViewTextBoxColumn234";
            this.dataGridViewTextBoxColumn234.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn235
            // 
            this.dataGridViewTextBoxColumn235.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn235.HeaderText = "Team";
            this.dataGridViewTextBoxColumn235.Name = "dataGridViewTextBoxColumn235";
            this.dataGridViewTextBoxColumn235.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn236
            // 
            this.dataGridViewTextBoxColumn236.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn236.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn236.Name = "dataGridViewTextBoxColumn236";
            this.dataGridViewTextBoxColumn236.ReadOnly = true;
            this.dataGridViewTextBoxColumn236.Width = 250;
            // 
            // dataGridViewTextBoxColumn237
            // 
            this.dataGridViewTextBoxColumn237.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn237.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn237.Name = "dataGridViewTextBoxColumn237";
            this.dataGridViewTextBoxColumn237.ReadOnly = true;
            this.dataGridViewTextBoxColumn237.Width = 250;
            // 
            // colDel_Race5
            // 
            this.colDel_Race5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race5.HeaderText = "Delete";
            this.colDel_Race5.Name = "colDel_Race5";
            this.colDel_Race5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel_Race5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDel_Race5.Text = "X";
            this.colDel_Race5.UseColumnTextForButtonValue = true;
            this.colDel_Race5.Width = 45;
            // 
            // dataGridViewTextBoxColumn228
            // 
            this.dataGridViewTextBoxColumn228.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn228.HeaderText = "Name";
            this.dataGridViewTextBoxColumn228.Name = "dataGridViewTextBoxColumn228";
            this.dataGridViewTextBoxColumn228.ReadOnly = true;
            this.dataGridViewTextBoxColumn228.Width = 200;
            // 
            // dataGridViewTextBoxColumn229
            // 
            this.dataGridViewTextBoxColumn229.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn229.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn229.Name = "dataGridViewTextBoxColumn229";
            this.dataGridViewTextBoxColumn229.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn230
            // 
            this.dataGridViewTextBoxColumn230.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn230.HeaderText = "Team";
            this.dataGridViewTextBoxColumn230.Name = "dataGridViewTextBoxColumn230";
            this.dataGridViewTextBoxColumn230.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn231
            // 
            this.dataGridViewTextBoxColumn231.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn231.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn231.Name = "dataGridViewTextBoxColumn231";
            this.dataGridViewTextBoxColumn231.ReadOnly = true;
            this.dataGridViewTextBoxColumn231.Width = 250;
            // 
            // dataGridViewTextBoxColumn232
            // 
            this.dataGridViewTextBoxColumn232.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn232.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn232.Name = "dataGridViewTextBoxColumn232";
            this.dataGridViewTextBoxColumn232.ReadOnly = true;
            this.dataGridViewTextBoxColumn232.Width = 250;
            // 
            // colDel_Race4
            // 
            this.colDel_Race4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race4.HeaderText = "Delete";
            this.colDel_Race4.Name = "colDel_Race4";
            this.colDel_Race4.Text = "X";
            this.colDel_Race4.UseColumnTextForButtonValue = true;
            this.colDel_Race4.Width = 45;
            // 
            // dataGridViewTextBoxColumn223
            // 
            this.dataGridViewTextBoxColumn223.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn223.HeaderText = "Name";
            this.dataGridViewTextBoxColumn223.Name = "dataGridViewTextBoxColumn223";
            this.dataGridViewTextBoxColumn223.ReadOnly = true;
            this.dataGridViewTextBoxColumn223.Width = 200;
            // 
            // dataGridViewTextBoxColumn224
            // 
            this.dataGridViewTextBoxColumn224.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn224.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn224.Name = "dataGridViewTextBoxColumn224";
            this.dataGridViewTextBoxColumn224.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn225
            // 
            this.dataGridViewTextBoxColumn225.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn225.HeaderText = "Team";
            this.dataGridViewTextBoxColumn225.Name = "dataGridViewTextBoxColumn225";
            this.dataGridViewTextBoxColumn225.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn226
            // 
            this.dataGridViewTextBoxColumn226.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn226.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn226.Name = "dataGridViewTextBoxColumn226";
            this.dataGridViewTextBoxColumn226.ReadOnly = true;
            this.dataGridViewTextBoxColumn226.Width = 250;
            // 
            // dataGridViewTextBoxColumn227
            // 
            this.dataGridViewTextBoxColumn227.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn227.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn227.Name = "dataGridViewTextBoxColumn227";
            this.dataGridViewTextBoxColumn227.ReadOnly = true;
            this.dataGridViewTextBoxColumn227.Width = 250;
            // 
            // colDel_Race3
            // 
            this.colDel_Race3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race3.HeaderText = "Delete";
            this.colDel_Race3.Name = "colDel_Race3";
            this.colDel_Race3.Text = "X";
            this.colDel_Race3.UseColumnTextForButtonValue = true;
            this.colDel_Race3.Width = 45;
            // 
            // dataGridViewTextBoxColumn218
            // 
            this.dataGridViewTextBoxColumn218.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn218.HeaderText = "Name";
            this.dataGridViewTextBoxColumn218.Name = "dataGridViewTextBoxColumn218";
            this.dataGridViewTextBoxColumn218.Width = 200;
            // 
            // dataGridViewTextBoxColumn219
            // 
            this.dataGridViewTextBoxColumn219.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn219.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn219.Name = "dataGridViewTextBoxColumn219";
            // 
            // dataGridViewTextBoxColumn220
            // 
            this.dataGridViewTextBoxColumn220.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn220.HeaderText = "Team";
            this.dataGridViewTextBoxColumn220.Name = "dataGridViewTextBoxColumn220";
            // 
            // dataGridViewTextBoxColumn221
            // 
            this.dataGridViewTextBoxColumn221.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn221.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn221.Name = "dataGridViewTextBoxColumn221";
            this.dataGridViewTextBoxColumn221.Width = 250;
            // 
            // dataGridViewTextBoxColumn222
            // 
            this.dataGridViewTextBoxColumn222.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn222.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn222.Name = "dataGridViewTextBoxColumn222";
            this.dataGridViewTextBoxColumn222.Width = 250;
            // 
            // colDel_Race2
            // 
            this.colDel_Race2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race2.HeaderText = "Delete";
            this.colDel_Race2.Name = "colDel_Race2";
            this.colDel_Race2.Text = "X";
            this.colDel_Race2.UseColumnTextForButtonValue = true;
            this.colDel_Race2.Width = 45;
            // 
            // dataGridViewTextBoxColumn238
            // 
            this.dataGridViewTextBoxColumn238.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn238.HeaderText = "Name";
            this.dataGridViewTextBoxColumn238.Name = "dataGridViewTextBoxColumn238";
            this.dataGridViewTextBoxColumn238.ReadOnly = true;
            this.dataGridViewTextBoxColumn238.Width = 200;
            // 
            // dataGridViewTextBoxColumn239
            // 
            this.dataGridViewTextBoxColumn239.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn239.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn239.Name = "dataGridViewTextBoxColumn239";
            this.dataGridViewTextBoxColumn239.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn240
            // 
            this.dataGridViewTextBoxColumn240.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn240.HeaderText = "Team";
            this.dataGridViewTextBoxColumn240.Name = "dataGridViewTextBoxColumn240";
            this.dataGridViewTextBoxColumn240.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn241
            // 
            this.dataGridViewTextBoxColumn241.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn241.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn241.Name = "dataGridViewTextBoxColumn241";
            this.dataGridViewTextBoxColumn241.ReadOnly = true;
            this.dataGridViewTextBoxColumn241.Width = 250;
            // 
            // dataGridViewTextBoxColumn242
            // 
            this.dataGridViewTextBoxColumn242.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn242.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn242.Name = "dataGridViewTextBoxColumn242";
            this.dataGridViewTextBoxColumn242.ReadOnly = true;
            this.dataGridViewTextBoxColumn242.Width = 250;
            // 
            // colDel_Race6
            // 
            this.colDel_Race6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race6.HeaderText = "Delete";
            this.colDel_Race6.Name = "colDel_Race6";
            this.colDel_Race6.ReadOnly = true;
            this.colDel_Race6.Text = "X";
            this.colDel_Race6.UseColumnTextForButtonValue = true;
            this.colDel_Race6.Width = 45;
            // 
            // dataGridViewTextBoxColumn243
            // 
            this.dataGridViewTextBoxColumn243.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn243.HeaderText = "Name";
            this.dataGridViewTextBoxColumn243.Name = "dataGridViewTextBoxColumn243";
            this.dataGridViewTextBoxColumn243.ReadOnly = true;
            this.dataGridViewTextBoxColumn243.Width = 200;
            // 
            // dataGridViewTextBoxColumn244
            // 
            this.dataGridViewTextBoxColumn244.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn244.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn244.Name = "dataGridViewTextBoxColumn244";
            this.dataGridViewTextBoxColumn244.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn245
            // 
            this.dataGridViewTextBoxColumn245.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn245.HeaderText = "Team";
            this.dataGridViewTextBoxColumn245.Name = "dataGridViewTextBoxColumn245";
            this.dataGridViewTextBoxColumn245.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn246
            // 
            this.dataGridViewTextBoxColumn246.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn246.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn246.Name = "dataGridViewTextBoxColumn246";
            this.dataGridViewTextBoxColumn246.ReadOnly = true;
            this.dataGridViewTextBoxColumn246.Width = 250;
            // 
            // dataGridViewTextBoxColumn247
            // 
            this.dataGridViewTextBoxColumn247.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn247.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn247.Name = "dataGridViewTextBoxColumn247";
            this.dataGridViewTextBoxColumn247.ReadOnly = true;
            this.dataGridViewTextBoxColumn247.Width = 250;
            // 
            // colDel_Race7
            // 
            this.colDel_Race7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race7.HeaderText = "Delete";
            this.colDel_Race7.Name = "colDel_Race7";
            this.colDel_Race7.Text = "X";
            this.colDel_Race7.UseColumnTextForButtonValue = true;
            this.colDel_Race7.Width = 45;
            // 
            // dataGridViewTextBoxColumn248
            // 
            this.dataGridViewTextBoxColumn248.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn248.HeaderText = "Name";
            this.dataGridViewTextBoxColumn248.Name = "dataGridViewTextBoxColumn248";
            this.dataGridViewTextBoxColumn248.ReadOnly = true;
            this.dataGridViewTextBoxColumn248.Width = 200;
            // 
            // dataGridViewTextBoxColumn249
            // 
            this.dataGridViewTextBoxColumn249.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn249.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn249.Name = "dataGridViewTextBoxColumn249";
            this.dataGridViewTextBoxColumn249.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn250
            // 
            this.dataGridViewTextBoxColumn250.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn250.HeaderText = "Team";
            this.dataGridViewTextBoxColumn250.Name = "dataGridViewTextBoxColumn250";
            this.dataGridViewTextBoxColumn250.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn251
            // 
            this.dataGridViewTextBoxColumn251.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn251.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn251.Name = "dataGridViewTextBoxColumn251";
            this.dataGridViewTextBoxColumn251.ReadOnly = true;
            this.dataGridViewTextBoxColumn251.Width = 250;
            // 
            // dataGridViewTextBoxColumn252
            // 
            this.dataGridViewTextBoxColumn252.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn252.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn252.Name = "dataGridViewTextBoxColumn252";
            this.dataGridViewTextBoxColumn252.ReadOnly = true;
            this.dataGridViewTextBoxColumn252.Width = 250;
            // 
            // colDel_Race8
            // 
            this.colDel_Race8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race8.HeaderText = "Delete";
            this.colDel_Race8.Name = "colDel_Race8";
            this.colDel_Race8.Text = "X";
            this.colDel_Race8.UseColumnTextForButtonValue = true;
            this.colDel_Race8.Width = 45;
            // 
            // dataGridViewTextBoxColumn100
            // 
            this.dataGridViewTextBoxColumn100.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn100.HeaderText = "Name";
            this.dataGridViewTextBoxColumn100.Name = "dataGridViewTextBoxColumn100";
            this.dataGridViewTextBoxColumn100.ReadOnly = true;
            this.dataGridViewTextBoxColumn100.Width = 200;
            // 
            // dataGridViewTextBoxColumn101
            // 
            this.dataGridViewTextBoxColumn101.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn101.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn101.Name = "dataGridViewTextBoxColumn101";
            this.dataGridViewTextBoxColumn101.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn102
            // 
            this.dataGridViewTextBoxColumn102.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn102.HeaderText = "Team";
            this.dataGridViewTextBoxColumn102.Name = "dataGridViewTextBoxColumn102";
            this.dataGridViewTextBoxColumn102.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn103
            // 
            this.dataGridViewTextBoxColumn103.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn103.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn103.Name = "dataGridViewTextBoxColumn103";
            this.dataGridViewTextBoxColumn103.ReadOnly = true;
            this.dataGridViewTextBoxColumn103.Width = 250;
            // 
            // dataGridViewTextBoxColumn104
            // 
            this.dataGridViewTextBoxColumn104.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn104.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn104.Name = "dataGridViewTextBoxColumn104";
            this.dataGridViewTextBoxColumn104.ReadOnly = true;
            this.dataGridViewTextBoxColumn104.Width = 250;
            // 
            // colDel_Race13
            // 
            this.colDel_Race13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race13.HeaderText = "Delete";
            this.colDel_Race13.Name = "colDel_Race13";
            this.colDel_Race13.Text = "X";
            this.colDel_Race13.UseColumnTextForButtonValue = true;
            this.colDel_Race13.Width = 45;
            // 
            // dataGridViewTextBoxColumn107
            // 
            this.dataGridViewTextBoxColumn107.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn107.HeaderText = "Name";
            this.dataGridViewTextBoxColumn107.Name = "dataGridViewTextBoxColumn107";
            this.dataGridViewTextBoxColumn107.ReadOnly = true;
            this.dataGridViewTextBoxColumn107.Width = 200;
            // 
            // dataGridViewTextBoxColumn108
            // 
            this.dataGridViewTextBoxColumn108.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn108.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn108.Name = "dataGridViewTextBoxColumn108";
            this.dataGridViewTextBoxColumn108.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn109
            // 
            this.dataGridViewTextBoxColumn109.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn109.HeaderText = "Team";
            this.dataGridViewTextBoxColumn109.Name = "dataGridViewTextBoxColumn109";
            this.dataGridViewTextBoxColumn109.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn110
            // 
            this.dataGridViewTextBoxColumn110.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn110.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn110.Name = "dataGridViewTextBoxColumn110";
            this.dataGridViewTextBoxColumn110.ReadOnly = true;
            this.dataGridViewTextBoxColumn110.Width = 250;
            // 
            // dataGridViewTextBoxColumn111
            // 
            this.dataGridViewTextBoxColumn111.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn111.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn111.Name = "dataGridViewTextBoxColumn111";
            this.dataGridViewTextBoxColumn111.ReadOnly = true;
            this.dataGridViewTextBoxColumn111.Width = 250;
            // 
            // colDel_Race14
            // 
            this.colDel_Race14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race14.HeaderText = "Delete";
            this.colDel_Race14.Name = "colDel_Race14";
            this.colDel_Race14.Text = "X";
            this.colDel_Race14.UseColumnTextForButtonValue = true;
            this.colDel_Race14.Width = 45;
            // 
            // dataGridViewTextBoxColumn114
            // 
            this.dataGridViewTextBoxColumn114.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn114.HeaderText = "Name";
            this.dataGridViewTextBoxColumn114.Name = "dataGridViewTextBoxColumn114";
            this.dataGridViewTextBoxColumn114.ReadOnly = true;
            this.dataGridViewTextBoxColumn114.Width = 200;
            // 
            // dataGridViewTextBoxColumn115
            // 
            this.dataGridViewTextBoxColumn115.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn115.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn115.Name = "dataGridViewTextBoxColumn115";
            this.dataGridViewTextBoxColumn115.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn116
            // 
            this.dataGridViewTextBoxColumn116.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn116.HeaderText = "Team";
            this.dataGridViewTextBoxColumn116.Name = "dataGridViewTextBoxColumn116";
            this.dataGridViewTextBoxColumn116.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn117
            // 
            this.dataGridViewTextBoxColumn117.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn117.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn117.Name = "dataGridViewTextBoxColumn117";
            this.dataGridViewTextBoxColumn117.ReadOnly = true;
            this.dataGridViewTextBoxColumn117.Width = 250;
            // 
            // dataGridViewTextBoxColumn118
            // 
            this.dataGridViewTextBoxColumn118.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn118.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn118.Name = "dataGridViewTextBoxColumn118";
            this.dataGridViewTextBoxColumn118.ReadOnly = true;
            this.dataGridViewTextBoxColumn118.Width = 250;
            // 
            // colDel_Race15
            // 
            this.colDel_Race15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race15.HeaderText = "Delete";
            this.colDel_Race15.Name = "colDel_Race15";
            this.colDel_Race15.Text = "X";
            this.colDel_Race15.UseColumnTextForButtonValue = true;
            this.colDel_Race15.Width = 45;
            // 
            // dataGridViewTextBoxColumn121
            // 
            this.dataGridViewTextBoxColumn121.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn121.HeaderText = "Name";
            this.dataGridViewTextBoxColumn121.Name = "dataGridViewTextBoxColumn121";
            this.dataGridViewTextBoxColumn121.ReadOnly = true;
            this.dataGridViewTextBoxColumn121.Width = 200;
            // 
            // dataGridViewTextBoxColumn122
            // 
            this.dataGridViewTextBoxColumn122.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn122.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn122.Name = "dataGridViewTextBoxColumn122";
            this.dataGridViewTextBoxColumn122.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn123
            // 
            this.dataGridViewTextBoxColumn123.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn123.HeaderText = "Team";
            this.dataGridViewTextBoxColumn123.Name = "dataGridViewTextBoxColumn123";
            this.dataGridViewTextBoxColumn123.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn124
            // 
            this.dataGridViewTextBoxColumn124.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn124.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn124.Name = "dataGridViewTextBoxColumn124";
            this.dataGridViewTextBoxColumn124.ReadOnly = true;
            this.dataGridViewTextBoxColumn124.Width = 250;
            // 
            // dataGridViewTextBoxColumn125
            // 
            this.dataGridViewTextBoxColumn125.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn125.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn125.Name = "dataGridViewTextBoxColumn125";
            this.dataGridViewTextBoxColumn125.ReadOnly = true;
            this.dataGridViewTextBoxColumn125.Width = 250;
            // 
            // colDel_Race16
            // 
            this.colDel_Race16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Race16.HeaderText = "Delete";
            this.colDel_Race16.Name = "colDel_Race16";
            this.colDel_Race16.Text = "X";
            this.colDel_Race16.UseColumnTextForButtonValue = true;
            this.colDel_Race16.Width = 45;
            // 
            // dataGridViewTextBoxColumn128
            // 
            this.dataGridViewTextBoxColumn128.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn128.HeaderText = "Name";
            this.dataGridViewTextBoxColumn128.Name = "dataGridViewTextBoxColumn128";
            this.dataGridViewTextBoxColumn128.ReadOnly = true;
            this.dataGridViewTextBoxColumn128.Width = 200;
            // 
            // dataGridViewTextBoxColumn129
            // 
            this.dataGridViewTextBoxColumn129.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn129.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn129.Name = "dataGridViewTextBoxColumn129";
            this.dataGridViewTextBoxColumn129.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn130
            // 
            this.dataGridViewTextBoxColumn130.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn130.HeaderText = "Team";
            this.dataGridViewTextBoxColumn130.Name = "dataGridViewTextBoxColumn130";
            this.dataGridViewTextBoxColumn130.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn131
            // 
            this.dataGridViewTextBoxColumn131.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn131.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn131.Name = "dataGridViewTextBoxColumn131";
            this.dataGridViewTextBoxColumn131.ReadOnly = true;
            this.dataGridViewTextBoxColumn131.Width = 250;
            // 
            // dataGridViewTextBoxColumn132
            // 
            this.dataGridViewTextBoxColumn132.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn132.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn132.Name = "dataGridViewTextBoxColumn132";
            this.dataGridViewTextBoxColumn132.ReadOnly = true;
            this.dataGridViewTextBoxColumn132.Width = 250;
            // 
            // colDel_Semi1
            // 
            this.colDel_Semi1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Semi1.HeaderText = "Delete";
            this.colDel_Semi1.Name = "colDel_Semi1";
            this.colDel_Semi1.Text = "X";
            this.colDel_Semi1.UseColumnTextForButtonValue = true;
            this.colDel_Semi1.Width = 45;
            // 
            // dataGridViewTextBoxColumn135
            // 
            this.dataGridViewTextBoxColumn135.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn135.HeaderText = "Name";
            this.dataGridViewTextBoxColumn135.Name = "dataGridViewTextBoxColumn135";
            this.dataGridViewTextBoxColumn135.ReadOnly = true;
            this.dataGridViewTextBoxColumn135.Width = 200;
            // 
            // dataGridViewTextBoxColumn136
            // 
            this.dataGridViewTextBoxColumn136.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn136.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn136.Name = "dataGridViewTextBoxColumn136";
            this.dataGridViewTextBoxColumn136.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn137
            // 
            this.dataGridViewTextBoxColumn137.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn137.HeaderText = "Team";
            this.dataGridViewTextBoxColumn137.Name = "dataGridViewTextBoxColumn137";
            this.dataGridViewTextBoxColumn137.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn138
            // 
            this.dataGridViewTextBoxColumn138.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn138.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn138.Name = "dataGridViewTextBoxColumn138";
            this.dataGridViewTextBoxColumn138.ReadOnly = true;
            this.dataGridViewTextBoxColumn138.Width = 250;
            // 
            // dataGridViewTextBoxColumn139
            // 
            this.dataGridViewTextBoxColumn139.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn139.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn139.Name = "dataGridViewTextBoxColumn139";
            this.dataGridViewTextBoxColumn139.ReadOnly = true;
            this.dataGridViewTextBoxColumn139.Width = 250;
            // 
            // colDel_Semi2
            // 
            this.colDel_Semi2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Semi2.HeaderText = "Delete";
            this.colDel_Semi2.Name = "colDel_Semi2";
            this.colDel_Semi2.Text = "X";
            this.colDel_Semi2.UseColumnTextForButtonValue = true;
            this.colDel_Semi2.Width = 45;
            // 
            // dataGridViewTextBoxColumn142
            // 
            this.dataGridViewTextBoxColumn142.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn142.HeaderText = "Name";
            this.dataGridViewTextBoxColumn142.Name = "dataGridViewTextBoxColumn142";
            this.dataGridViewTextBoxColumn142.ReadOnly = true;
            this.dataGridViewTextBoxColumn142.Width = 200;
            // 
            // dataGridViewTextBoxColumn143
            // 
            this.dataGridViewTextBoxColumn143.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn143.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn143.Name = "dataGridViewTextBoxColumn143";
            this.dataGridViewTextBoxColumn143.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn144
            // 
            this.dataGridViewTextBoxColumn144.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn144.HeaderText = "Team";
            this.dataGridViewTextBoxColumn144.Name = "dataGridViewTextBoxColumn144";
            this.dataGridViewTextBoxColumn144.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn145
            // 
            this.dataGridViewTextBoxColumn145.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn145.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn145.Name = "dataGridViewTextBoxColumn145";
            this.dataGridViewTextBoxColumn145.ReadOnly = true;
            this.dataGridViewTextBoxColumn145.Width = 250;
            // 
            // dataGridViewTextBoxColumn146
            // 
            this.dataGridViewTextBoxColumn146.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn146.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn146.Name = "dataGridViewTextBoxColumn146";
            this.dataGridViewTextBoxColumn146.ReadOnly = true;
            this.dataGridViewTextBoxColumn146.Width = 250;
            // 
            // colDel_SFinal
            // 
            this.colDel_SFinal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_SFinal.HeaderText = "Delete";
            this.colDel_SFinal.Name = "colDel_SFinal";
            this.colDel_SFinal.Text = "X";
            this.colDel_SFinal.UseColumnTextForButtonValue = true;
            this.colDel_SFinal.Width = 45;
            // 
            // dataGridViewTextBoxColumn149
            // 
            this.dataGridViewTextBoxColumn149.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn149.HeaderText = "Name";
            this.dataGridViewTextBoxColumn149.Name = "dataGridViewTextBoxColumn149";
            this.dataGridViewTextBoxColumn149.ReadOnly = true;
            this.dataGridViewTextBoxColumn149.Width = 200;
            // 
            // dataGridViewTextBoxColumn150
            // 
            this.dataGridViewTextBoxColumn150.DataPropertyName = "Nickname";
            this.dataGridViewTextBoxColumn150.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn150.Name = "dataGridViewTextBoxColumn150";
            this.dataGridViewTextBoxColumn150.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn151
            // 
            this.dataGridViewTextBoxColumn151.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn151.HeaderText = "Team";
            this.dataGridViewTextBoxColumn151.Name = "dataGridViewTextBoxColumn151";
            this.dataGridViewTextBoxColumn151.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn152
            // 
            this.dataGridViewTextBoxColumn152.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn152.HeaderText = "TAG ID";
            this.dataGridViewTextBoxColumn152.Name = "dataGridViewTextBoxColumn152";
            this.dataGridViewTextBoxColumn152.ReadOnly = true;
            this.dataGridViewTextBoxColumn152.Width = 250;
            // 
            // dataGridViewTextBoxColumn153
            // 
            this.dataGridViewTextBoxColumn153.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn153.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn153.Name = "dataGridViewTextBoxColumn153";
            this.dataGridViewTextBoxColumn153.ReadOnly = true;
            this.dataGridViewTextBoxColumn153.Width = 250;
            // 
            // colDel_Final
            // 
            this.colDel_Final.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colDel_Final.HeaderText = "Delete";
            this.colDel_Final.Name = "colDel_Final";
            this.colDel_Final.Text = "X";
            this.colDel_Final.UseColumnTextForButtonValue = true;
            this.colDel_Final.Width = 45;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1349, 682);
            this.Controls.Add(this.tabCtrMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID Chrono Timing System v1.0 by RC-WORKS | 3D-WORKS | CHRONOSYSTEM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabCtrMain.ResumeLayout(false);
            this.PagReaderSetting.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbCmdReadGpio.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbCmdBeeper.ResumeLayout(false);
            this.gbCmdBeeper.PerformLayout();
            this.gbCmdTemperature.ResumeLayout(false);
            this.gbCmdTemperature.PerformLayout();
            this.gbCmdVersion.ResumeLayout(false);
            this.gbCmdVersion.PerformLayout();
            this.gbCmdBaudrate.ResumeLayout(false);
            this.gbCmdBaudrate.PerformLayout();
            this.gbTcpIp.ResumeLayout(false);
            this.gbTcpIp.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbReturnLoss.ResumeLayout(false);
            this.gbReturnLoss.PerformLayout();
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            this.gbMonza.ResumeLayout(false);
            this.gbMonza.PerformLayout();
            this.gbCmdAntDetector.ResumeLayout(false);
            this.gbCmdAntDetector.PerformLayout();
            this.gbCmdDrm.ResumeLayout(false);
            this.gbCmdDrm.PerformLayout();
            this.gbCmdAntenna.ResumeLayout(false);
            this.gbCmdAntenna.PerformLayout();
            this.gbCmdRegion.ResumeLayout(false);
            this.gbCmdRegion.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.gbCmdOutputPower.ResumeLayout(false);
            this.gbCmdOutputPower.PerformLayout();
            this.pageEpcTest.ResumeLayout(false);
            this.tabEpcTest.ResumeLayout(false);
            this.tabTrack.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPilotsPerGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLapTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFirstLapTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQualRounds)).EndInit();
            this.tabPilots.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPilots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePilots1)).EndInit();
            this.tabRounds.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPage22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePilots)).EndInit();
            this.tabPage23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace2)).EndInit();
            this.tabPage24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace3)).EndInit();
            this.tabPage25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace4)).EndInit();
            this.tabPage26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace5)).EndInit();
            this.tabPage27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace6)).EndInit();
            this.tabPage28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace7)).EndInit();
            this.tabPage29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace8)).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.pageGroupA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupA)).EndInit();
            this.pageGroupB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupB)).EndInit();
            this.pageGroupC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupC)).EndInit();
            this.pageGroupD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupD)).EndInit();
            this.pageGroupE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupE)).EndInit();
            this.pageGroupF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupF)).EndInit();
            this.pageGroupG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupG)).EndInit();
            this.pageGroupH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupH)).EndInit();
            this.pageGroupI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupI)).EndInit();
            this.pageGroupJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupJ)).EndInit();
            this.pageGroupK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupK)).EndInit();
            this.pageGroupL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupL)).EndInit();
            this.pageGroupM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupM)).EndInit();
            this.pageGroupN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupN)).EndInit();
            this.pageGroupO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupO)).EndInit();
            this.tabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupP)).EndInit();
            this.tabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupQ)).EndInit();
            this.tabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupR)).EndInit();
            this.tabPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupS)).EndInit();
            this.tabPage15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupT)).EndInit();
            this.tabPage16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupU)).EndInit();
            this.tabPage17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupV)).EndInit();
            this.tabPage18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupW)).EndInit();
            this.tabPage19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupX)).EndInit();
            this.tabPage20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupY)).EndInit();
            this.tabPage21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupZ)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.groupBox38.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSmallFinal)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFinal)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.groupBox36.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace13)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace14)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace15)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace16)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.groupBox37.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSemi1)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSemi2)).EndInit();
            this.tabRace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRace)).EndInit();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRanking)).EndInit();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.gbMimicRace.ResumeLayout(false);
            this.gbMimicRace.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.pageRealMode.ResumeLayout(false);
            this.pageRealMode.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal1)).EndInit();
            this.pageBufferedMode.ResumeLayout(false);
            this.pageBufferedMode.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer1)).EndInit();
            this.pageFast4AntMode.ResumeLayout(false);
            this.pageFast4AntMode.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pageAcessTag.ResumeLayout(false);
            this.gbCmdOperateTag.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.PagISO18000.ResumeLayout(false);
            this.PagISO18000.PerformLayout();
            this.gbISO1800LockQuery.ResumeLayout(false);
            this.gbISO1800LockQuery.PerformLayout();
            this.gbISO1800ReadWrite.ResumeLayout(false);
            this.gbISO1800ReadWrite.PerformLayout();
            this.PagTranDataLog.ResumeLayout(false);
            this.gbCmdManual.ResumeLayout(false);
            this.gbCmdManual.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl18)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrMain;
        private System.Windows.Forms.TabPage PagReaderSetting;
        private System.Windows.Forms.TabPage PagTranDataLog;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label17;
        private CustomControl.HexTextBox htxtSendData;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbCmdManual;
        private CustomControl.LogRichTextBox lrtxtDataTran;
        private CustomControl.HexTextBox htxtCheckData;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.TabPage PagISO18000;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnWriteTagISO18000;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private CustomControl.HexTextBox htxtReadUID;
        private CustomControl.HexTextBox htxtQueryAdd;
        private CustomControl.HexTextBox htxtWriteStartAdd;
        private System.Windows.Forms.Button btnInventoryISO18000;
        private System.Windows.Forms.Button btnReadTagISO18000;
        private System.Windows.Forms.Button btnLockTagISO18000;
        private System.Windows.Forms.Button btnQueryTagISO18000;
        private System.Windows.Forms.Label label50;
        private CustomControl.HexTextBox htxtReadStartAdd;
        private CustomControl.HexTextBox htxtWriteData18000;
        private CustomControl.HexTextBox htxtLockAdd;
        private System.Windows.Forms.ListView ltvTagISO18000;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtReadLength;
        private System.Windows.Forms.TextBox txtWriteLength;
        private CustomControl.HexTextBox htxtReadData18000;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox gbISO1800ReadWrite;
        private System.Windows.Forms.GroupBox gbISO1800LockQuery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLoopTimes;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtLoop;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TabPage pageEpcTest;
        private System.Windows.Forms.TabControl tabEpcTest;
        private System.Windows.Forms.TabPage pageFast4AntMode;
        private System.Windows.Forms.TabPage pageRealMode;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.ComboBox cmbAntSelect4;
        private System.Windows.Forms.ComboBox cmbAntSelect3;
        private System.Windows.Forms.ComboBox cmbAntSelect2;
        private System.Windows.Forms.ComboBox cmbAntSelect1;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TabPage pageBufferedMode;
        private System.Windows.Forms.TabPage pageAcessTag;
        private System.Windows.Forms.Label txtFastTagList;
        private System.Windows.Forms.ListView lvFastList;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonFastFresh;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFastMinRssi;
        private System.Windows.Forms.TextBox txtFastMaxRssi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbRealMinRssi;
        private System.Windows.Forms.TextBox tbRealMaxRssi;
        private System.Windows.Forms.Button btRealFresh;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label lbRealTagCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private LxControl.LxLedControl ledReal5;
        private LxControl.LxLedControl ledReal2;
        private LxControl.LxLedControl ledReal4;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private LxControl.LxLedControl ledReal1;
        private System.Windows.Forms.Button btRealTimeInventory;
        private System.Windows.Forms.Button btGetBuffer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btBufferFresh;
        private System.Windows.Forms.Label labelBufferTagCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private LxControl.LxLedControl lxLedControl9;
        private LxControl.LxLedControl lxLedControl10;
        private LxControl.LxLedControl lxLedControl11;
        private LxControl.LxLedControl lxLedControl12;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private LxControl.LxLedControl lxLedControl13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ComboBox comboBox10;
        private LxControl.LxLedControl lxLedControl14;
        private LxControl.LxLedControl lxLedControl15;
        private LxControl.LxLedControl lxLedControl16;
        private LxControl.LxLedControl lxLedControl17;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private LxControl.LxLedControl lxLedControl18;
        private System.Windows.Forms.Button btQueryBuffer;
        private System.Windows.Forms.Button btGetClearBuffer;
        private System.Windows.Forms.Button btClearBuffer;
        private System.Windows.Forms.ListView lvBufferList;
        private System.Windows.Forms.ColumnHeader columnHeader49;
        private System.Windows.Forms.ColumnHeader columnHeader50;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.GroupBox gbCmdOperateTag;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button btnKillTag;
        private CustomControl.HexTextBox htxtKillPwd;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox15;
        private CustomControl.HexTextBox htxtLockPwd;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton rdbUserMemory;
        private System.Windows.Forms.RadioButton rdbTidMemory;
        private System.Windows.Forms.RadioButton rdbEpcMermory;
        private System.Windows.Forms.RadioButton rdbKillPwd;
        private System.Windows.Forms.RadioButton rdbAccessPwd;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.RadioButton rdbLockEver;
        private System.Windows.Forms.RadioButton rdbFreeEver;
        private System.Windows.Forms.RadioButton rdbLock;
        private System.Windows.Forms.RadioButton rdbFree;
        private System.Windows.Forms.Button btnLockTag;
        private System.Windows.Forms.GroupBox groupBox14;
        private CustomControl.HexTextBox htxtWriteData;
        private System.Windows.Forms.TextBox txtWordCnt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnWriteTag;
        private System.Windows.Forms.Button btnReadTag;
        private System.Windows.Forms.TextBox txtWordAdd;
        private System.Windows.Forms.Label label26;
        private CustomControl.HexTextBox htxtReadAndWritePwd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.RadioButton rdbTid;
        private System.Windows.Forms.RadioButton rdbEpc;
        private System.Windows.Forms.RadioButton rdbReserved;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnSetAccessEpcMatch;
        private System.Windows.Forms.ComboBox cmbSetAccessEpcMatch;
        private System.Windows.Forms.TextBox txtAccessEpcMatch;
        private System.Windows.Forms.CheckBox ckAccessEpcMatch;
        private System.Windows.Forms.TextBox textRealRound;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox textReadRoundBuffer;
        private System.Windows.Forms.ListView ltvOperate;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView lvRealList;
        private LxControl.LxLedControl ledReal3;
        private System.Windows.Forms.GroupBox groupBox3;
        private LxControl.LxLedControl ledBuffer4;
        private System.Windows.Forms.ComboBox comboBox11;
        private LxControl.LxLedControl ledBuffer5;
        private LxControl.LxLedControl ledBuffer2;
        private LxControl.LxLedControl ledBuffer3;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private LxControl.LxLedControl ledBuffer1;
        private System.Windows.Forms.Button btBufferInventory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btFastInventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private LxControl.LxLedControl ledFast4;
        private System.Windows.Forms.ComboBox comboBox7;
        private LxControl.LxLedControl ledFast5;
        private LxControl.LxLedControl ledFast2;
        private LxControl.LxLedControl ledFast3;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private LxControl.LxLedControl ledFast1;
        private System.Windows.Forms.TextBox txtDStay;
        private System.Windows.Forms.TextBox txtCStay;
        private System.Windows.Forms.TextBox txtBStay;
        private System.Windows.Forms.TextBox txtAStay;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbCmdReadGpio;
        private System.Windows.Forms.Button btnWriteGpio4Value;
        private System.Windows.Forms.Button btnWriteGpio3Value;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RadioButton rdbGpio4High;
        private System.Windows.Forms.RadioButton rdbGpio4Low;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton rdbGpio3High;
        private System.Windows.Forms.RadioButton rdbGpio3Low;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.RadioButton rdbGpio2High;
        private System.Windows.Forms.RadioButton rdbGpio2Low;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RadioButton rdbGpio1High;
        private System.Windows.Forms.RadioButton rdbGpio1Low;
        private System.Windows.Forms.Button btnReadGpioValue;
        private System.Windows.Forms.GroupBox gbCmdBeeper;
        private System.Windows.Forms.Button btnSetBeeperMode;
        private System.Windows.Forms.RadioButton rdbBeeperModeTag;
        private System.Windows.Forms.RadioButton rdbBeeperModeInventory;
        private System.Windows.Forms.RadioButton rdbBeeperModeSlient;
        private System.Windows.Forms.GroupBox gbCmdTemperature;
        private System.Windows.Forms.Button btnGetReaderTemperature;
        private System.Windows.Forms.TextBox txtReaderTemperature;
        private System.Windows.Forms.GroupBox gbCmdVersion;
        private System.Windows.Forms.Button btnGetFirmwareVersion;
        private System.Windows.Forms.TextBox txtFirmwareVersion;
        private System.Windows.Forms.Button btnResetReader;
        public System.Windows.Forms.GroupBox gbCmdBaudrate;
        private CustomControl.HexTextBox htbGetIdentifier;
        private CustomControl.HexTextBox htbSetIdentifier;
        private System.Windows.Forms.Button btSetIdentifier;
        private System.Windows.Forms.Button btGetIdentifier;
        private System.Windows.Forms.GroupBox gbTcpIp;
        private System.Windows.Forms.Button btnDisconnectTcp;
        private System.Windows.Forms.TextBox txtTcpPort;
        private System.Windows.Forms.Button btnConnectTcp;
        private CustomControl.IpAddressTextBox ipIpServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbMonza;
        private System.Windows.Forms.RadioButton rdbMonzaOff;
        private System.Windows.Forms.Button btSetMonzaStatus;
        private System.Windows.Forms.Button btGetMonzaStatus;
        private System.Windows.Forms.RadioButton rdbMonzaOn;
        private System.Windows.Forms.GroupBox gbCmdAntenna;
        private System.Windows.Forms.Button btnGetWorkAntenna;
        private System.Windows.Forms.Button btnSetWorkAntenna;
        private System.Windows.Forms.GroupBox gbCmdAntDetector;
        private System.Windows.Forms.Button btnGetAntDetector;
        private System.Windows.Forms.Button btnSetAntDetector;
        private System.Windows.Forms.GroupBox gbCmdDrm;
        private System.Windows.Forms.Button btnGetDrmMode;
        private System.Windows.Forms.Button btnSetDrmMode;
        private System.Windows.Forms.RadioButton rdbDrmModeClose;
        private System.Windows.Forms.RadioButton rdbDrmModeOpen;
        private System.Windows.Forms.GroupBox gbCmdRegion;
        private System.Windows.Forms.Button btnGetFrequencyRegion;
        private System.Windows.Forms.Button btnSetFrequencyRegion;
        private System.Windows.Forms.GroupBox gbCmdOutputPower;
        private System.Windows.Forms.Button btnGetOutputPower;
        private System.Windows.Forms.Button btnSetOutputPower;
        private System.Windows.Forms.TextBox txtOutputPower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btReaderSetupRefresh;
        private System.Windows.Forms.Button btRfSetup;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox tbAntDectector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.CheckBox cbRealWorkant1;
        private System.Windows.Forms.CheckBox cbRealWorkant4;
        private System.Windows.Forms.CheckBox cbRealWorkant3;
        private System.Windows.Forms.CheckBox cbRealWorkant2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbRealSession;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.Button btGetProfile;
        private System.Windows.Forms.Button btSetProfile;
        private System.Windows.Forms.RadioButton rdbProfile3;
        private System.Windows.Forms.RadioButton rdbProfile2;
        private System.Windows.Forms.RadioButton rdbProfile1;
        private System.Windows.Forms.RadioButton rdbProfile0;
        private System.Windows.Forms.CheckBox cbBufferWorkant1;
        private System.Windows.Forms.CheckBox cbBufferWorkant4;
        private System.Windows.Forms.CheckBox cbBufferWorkant2;
        private System.Windows.Forms.CheckBox cbBufferWorkant3;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox textFreqQuantity;
        private System.Windows.Forms.TextBox TextFreqInterval;
        private System.Windows.Forms.TextBox textStartFreq;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbFrequencyEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbFrequencyStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbRegionChn;
        private System.Windows.Forms.RadioButton rdbRegionEtsi;
        private System.Windows.Forms.RadioButton rdbRegionFcc;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.GroupBox gbReturnLoss;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TextBox textReturnLoss;
        private System.Windows.Forms.Button btReturnLoss;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.ComboBox cmbWorkAnt;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.ComboBox cmbReturnLossFreq;
        private System.Windows.Forms.CheckBox cbUserDefineFreq;
        private System.Windows.Forms.Timer timerInventory;
        private System.Windows.Forms.TabPage tabRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRaceAnt3;
        private System.Windows.Forms.CheckBox cbRaceAnt2;
        private System.Windows.Forms.CheckBox cbRaceAnt4;
        private System.Windows.Forms.CheckBox cbRaceAnt1;
        private System.Windows.Forms.TextBox tbRaceMinRssi;
        private System.Windows.Forms.TextBox tbRaceMaxRssi;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbRaceGroup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbRaceRound;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Button btnRaceReset;
        private System.Windows.Forms.Button btnRaceStop;
        private System.Windows.Forms.Button btnRaceStart;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblRaceMilliSeconds;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lblRaceSeconds;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblRaceMinutes;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TabPage tabPilots;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.DataGridView gvPilots;
        private System.Windows.Forms.BindingSource bindingSourcePilots;
        private System.Windows.Forms.BindingSource bindingSourcePilots1;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.TextBox tbCurEvGroup;
        private System.Windows.Forms.TextBox tbCurEvRound;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.DataGridView gvRanking;
        private System.Windows.Forms.ComboBox cmbDisplayRanking;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.BindingSource bindingSourceRanking;
        private System.Windows.Forms.DataGridView gvRace;
        private System.Windows.Forms.BindingSource bindingSourceRace;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.ComboBox cmbRaceMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rssi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrFrequency;
        private System.Windows.Forms.TabPage tabRounds;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.Button btnAddPilotsToQF;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gvRace13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn99;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn105;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView gvRace14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView gvRace15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView gvRace16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn120;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn126;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.Button btnAddPilotsToQR;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage pageGroupA;
        private System.Windows.Forms.DataGridView gvGroupA;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmationStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage pageGroupB;
        private System.Windows.Forms.DataGridView gvGroupB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TabPage pageGroupC;
        private System.Windows.Forms.DataGridView gvGroupC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TabPage pageGroupD;
        private System.Windows.Forms.DataGridView gvGroupD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.TabPage pageGroupE;
        private System.Windows.Forms.DataGridView gvGroupE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.TabPage pageGroupF;
        private System.Windows.Forms.DataGridView gvGroupF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.TabPage pageGroupG;
        private System.Windows.Forms.DataGridView gvGroupG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.TabPage pageGroupH;
        private System.Windows.Forms.DataGridView gvGroupH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.TabPage pageGroupI;
        private System.Windows.Forms.DataGridView gvGroupI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.TabPage pageGroupJ;
        private System.Windows.Forms.DataGridView gvGroupJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.TabPage pageGroupK;
        private System.Windows.Forms.DataGridView gvGroupK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.TabPage pageGroupL;
        private System.Windows.Forms.DataGridView gvGroupL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.TabPage pageGroupM;
        private System.Windows.Forms.DataGridView gvGroupM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private System.Windows.Forms.TabPage pageGroupN;
        private System.Windows.Forms.DataGridView gvGroupN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private System.Windows.Forms.TabPage pageGroupO;
        private System.Windows.Forms.DataGridView gvGroupO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn98;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.Button btnAddPilotsToSF;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView gvSemi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn127;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn133;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView gvSemi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn134;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn140;
        private System.Windows.Forms.CheckBox ckClearOperationRec;
        private System.Windows.Forms.CheckBox ckDisplayLog;
        private System.Windows.Forms.Label label35;
        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.Button btnAddPilotsToF;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView gvSmallFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn141;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn147;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataGridView gvFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn148;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn154;
        private System.Windows.Forms.Button btnRaceSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn pilotNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestLapTimeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgLapTimeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn157;
        private System.Windows.Forms.TabPage tabTrack;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.TextBox tbRaceLength;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.NumericUpDown nudMinLapTime;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.NumericUpDown nudMinFirstLapTime;
        private System.Windows.Forms.DateTimePicker dtpRaceDate;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TextBox tbRaceLocation;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox tbRaceName;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.NumericUpDown nudNumOfLaps;
        private System.Windows.Forms.NumericUpDown nudNumberOfQualRounds;
        private System.Windows.Forms.NumericUpDown nudPilotsPerGroup;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Button btnRaceExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button btnClearDB;
        private System.Windows.Forms.Button btnAddPilotFromDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox gbMimicRace;
        private System.Windows.Forms.TextBox tbMimicName;
        private System.Windows.Forms.TextBox tbMimicLocation;
        private System.Windows.Forms.Button btTrack;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.CheckBox cbSecondChance;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.ComboBox cmbRoundType;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.DataGridView gvGroupP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn158;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn159;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn160;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn161;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn162;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.DataGridView gvGroupQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn163;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn164;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn165;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn166;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn167;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.DataGridView gvGroupR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn168;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn169;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn170;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn171;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn172;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.DataGridView gvGroupS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn173;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn174;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn175;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn176;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn177;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.DataGridView gvGroupT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn178;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn179;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn180;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn181;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn182;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.DataGridView gvGroupU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn183;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn184;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn185;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn186;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn187;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.DataGridView gvGroupV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn188;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn189;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn190;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn191;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn192;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TabPage tabPage20;
        private System.Windows.Forms.TabPage tabPage21;
        private System.Windows.Forms.DataGridView gvGroupW;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn193;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn194;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn195;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn196;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn197;
        private System.Windows.Forms.DataGridView gvGroupX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn198;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn199;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn200;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn201;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn202;
        private System.Windows.Forms.DataGridView gvGroupY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn203;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn204;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn205;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn206;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn207;
        private System.Windows.Forms.DataGridView gvGroupZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn208;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn209;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn210;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn211;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn212;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage22;
        private System.Windows.Forms.DataGridView gvRace1;
        private System.Windows.Forms.TabPage tabPage23;
        private System.Windows.Forms.DataGridView gvRace2;
        private System.Windows.Forms.TabPage tabPage24;
        private System.Windows.Forms.DataGridView gvRace3;
        private System.Windows.Forms.TabPage tabPage25;
        private System.Windows.Forms.DataGridView gvRace4;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Button btnAddPilotsTo18F;
        private System.Windows.Forms.TabPage tabPage26;
        private System.Windows.Forms.DataGridView gvRace5;
        private System.Windows.Forms.TabPage tabPage27;
        private System.Windows.Forms.DataGridView gvRace6;
        private System.Windows.Forms.TabPage tabPage28;
        private System.Windows.Forms.DataGridView gvRace7;
        private System.Windows.Forms.TabPage tabPage29;
        private System.Windows.Forms.DataGridView gvRace8;
        private System.Windows.Forms.Button btnManAddPilotsTo18F;
        private System.Windows.Forms.Button btnManAddPilotsToF;
        private System.Windows.Forms.Button btnManAddPilotsToQF;
        private System.Windows.Forms.Button btnManAddPilotsToSF;
        private System.Windows.Forms.Button btnReflight;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Epc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn155;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn156;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lap1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lap2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lap3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lap4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lap5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lap6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDifferential;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestLapTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgLapTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisteredLapsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn253;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn213;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn214;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn215;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn216;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn217;
        private System.Windows.Forms.DataGridViewButtonColumn colDelRace1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn218;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn219;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn220;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn221;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn222;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn223;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn224;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn225;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn226;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn227;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn228;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn229;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn230;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn231;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn232;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn233;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn234;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn235;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn236;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn237;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn238;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn239;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn240;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn241;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn242;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn243;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn244;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn245;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn246;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn247;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn248;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn249;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn250;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn251;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn252;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn142;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn143;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn144;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn145;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn146;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_SFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn149;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn150;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn151;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn152;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn153;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn107;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn108;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn109;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn110;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn115;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn116;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn117;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn121;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn122;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn123;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn124;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn125;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Race16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn128;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn129;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn130;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn131;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn132;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Semi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn135;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn136;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn137;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn138;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn139;
        private System.Windows.Forms.DataGridViewButtonColumn colDel_Semi2;
    }
}


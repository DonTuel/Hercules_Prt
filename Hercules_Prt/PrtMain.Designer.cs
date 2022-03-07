namespace Hercules_Prt
{
    partial class PrtMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrtMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenPrinterDefintionFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSavePrinterDefinitionFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSavePrinterDefinitionFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDebugTestLogic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.slConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.slInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tcMainTabs = new System.Windows.Forms.TabControl();
            this.tpConnection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDeviceConnection = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHostID = new System.Windows.Forms.TextBox();
            this.ckbConnectOnStart = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.MaskedTextBox();
            this.txtBufferSize = new System.Windows.Forms.MaskedTextBox();
            this.ckbAutoReconnect = new System.Windows.Forms.CheckBox();
            this.txtAutoReconnectInterval = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rbRawProtocol = new System.Windows.Forms.RadioButton();
            this.rbLPDProtocol = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.ckbHTMLOutput = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLinesPerPage = new System.Windows.Forms.MaskedTextBox();
            this.ckbTXTOutput = new System.Windows.Forms.CheckBox();
            this.ckbRTFOutput = new System.Windows.Forms.CheckBox();
            this.ckbPDFOutput = new System.Windows.Forms.CheckBox();
            this.gbxTestLogic = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTestPacketsFile = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.cbxTestPacketsFile = new System.Windows.Forms.ComboBox();
            this.tpLPDLPRInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.cbxLPDLPRWorkDir = new System.Windows.Forms.ComboBox();
            this.btnLPDLPRWorkDir = new System.Windows.Forms.Button();
            this.tpBOJInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTrailingBOJSeparatorPages = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBOJSeparatorPages = new System.Windows.Forms.MaskedTextBox();
            this.ckbPrintBOJSeparators = new System.Windows.Forms.CheckBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvBOJQualificationInformation = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvBOJFields = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpEOJInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTrailingEOJSeparatorPages = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEOJSeparatorPages = new System.Windows.Forms.MaskedTextBox();
            this.ckbPrintEOJSeparators = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpEOJQualifications = new System.Windows.Forms.TabPage();
            this.dgvEOJQualificationInformation = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpEOJFields = new System.Windows.Forms.TabPage();
            this.dgvEOJFields = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpTXTOutput = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTXTLinesPerPage = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxTXTFileTemplate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTXTOutputDir = new System.Windows.Forms.ComboBox();
            this.btnTXTOutputDir = new System.Windows.Forms.Button();
            this.tpRTFOutput = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxRTFFileTemplate = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxRTFOutputDir = new System.Windows.Forms.ComboBox();
            this.btnRTFOutputDir = new System.Windows.Forms.Button();
            this.tpPDFOutput = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxPDFPaperSize = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPaperDimensions = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxPDFFileTemplate = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxPDFOutputDir = new System.Windows.Forms.ComboBox();
            this.btnPDFOutputDir = new System.Windows.Forms.Button();
            this.tpHTMLOutput = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.ckbHTMLHeader = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxHTMLFileTemplate = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxHTMLOutputDir = new System.Windows.Forms.ComboBox();
            this.btnHTMLOutputDir = new System.Windows.Forms.Button();
            this.tpDiagnostics = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDumpPacketsFile = new System.Windows.Forms.ComboBox();
            this.btnDumpPacketsFile = new System.Windows.Forms.Button();
            this.ckbDumpPackets = new System.Windows.Forms.CheckBox();
            this.ckbVerboseLogging = new System.Windows.Forms.CheckBox();
            this.ckbDisplayInput = new System.Windows.Forms.CheckBox();
            this.ckbDisplayStatistics = new System.Windows.Forms.CheckBox();
            this.ckbProtocolLogging = new System.Windows.Forms.CheckBox();
            this.rtbDiagnosticOutput = new System.Windows.Forms.RichTextBox();
            this.btnSaveDiagnostics = new System.Windows.Forms.Button();
            this.btnClearDiagnostics = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmsReplacement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrinterDefinitionFile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxPrinterDefinitionFile = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tcMainTabs.SuspendLayout();
            this.tpConnection.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbxDeviceConnection.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.gbxTestLogic.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tpLPDLPRInfo.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tpBOJInfo.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBOJQualificationInformation)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBOJFields)).BeginInit();
            this.tpEOJInfo.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpEOJQualifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEOJQualificationInformation)).BeginInit();
            this.tpEOJFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEOJFields)).BeginInit();
            this.tpTXTOutput.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tpRTFOutput.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tpPDFOutput.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tpHTMLOutput.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tpDiagnostics.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDebug,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenPrinterDefintionFile,
            this.mnuSavePrinterDefinitionFile,
            this.mnuSavePrinterDefinitionFileAs,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpenPrinterDefintionFile
            // 
            this.mnuOpenPrinterDefintionFile.Name = "mnuOpenPrinterDefintionFile";
            this.mnuOpenPrinterDefintionFile.Size = new System.Drawing.Size(240, 22);
            this.mnuOpenPrinterDefintionFile.Text = "Open Printer  Defintion File ...";
            this.mnuOpenPrinterDefintionFile.Click += new System.EventHandler(this.mnuOpenPrinterDefintionFile_Click);
            // 
            // mnuSavePrinterDefinitionFile
            // 
            this.mnuSavePrinterDefinitionFile.Name = "mnuSavePrinterDefinitionFile";
            this.mnuSavePrinterDefinitionFile.Size = new System.Drawing.Size(240, 22);
            this.mnuSavePrinterDefinitionFile.Text = "Save Printer Definition File ...";
            this.mnuSavePrinterDefinitionFile.Click += new System.EventHandler(this.mnuSavePrinterDefinitionFile_Click);
            // 
            // mnuSavePrinterDefinitionFileAs
            // 
            this.mnuSavePrinterDefinitionFileAs.Name = "mnuSavePrinterDefinitionFileAs";
            this.mnuSavePrinterDefinitionFileAs.Size = new System.Drawing.Size(240, 22);
            this.mnuSavePrinterDefinitionFileAs.Text = "Save Printer Definition File As ...";
            this.mnuSavePrinterDefinitionFileAs.Click += new System.EventHandler(this.mnuSavePrinterDefinitionFileAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(240, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuDebug
            // 
            this.mnuDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDebugTestLogic});
            this.mnuDebug.Name = "mnuDebug";
            this.mnuDebug.Size = new System.Drawing.Size(54, 20);
            this.mnuDebug.Text = "Debug";
            // 
            // mnuDebugTestLogic
            // 
            this.mnuDebugTestLogic.Name = "mnuDebugTestLogic";
            this.mnuDebugTestLogic.Size = new System.Drawing.Size(135, 22);
            this.mnuDebugTestLogic.Text = "Test logic ...";
            this.mnuDebugTestLogic.Click += new System.EventHandler(this.mnuDebugTestLogic_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slTime,
            this.slConnectionStatus,
            this.slInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(714, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slTime
            // 
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(13, 17);
            this.slTime.Text = "a";
            // 
            // slConnectionStatus
            // 
            this.slConnectionStatus.Name = "slConnectionStatus";
            this.slConnectionStatus.Size = new System.Drawing.Size(14, 17);
            this.slConnectionStatus.Text = "b";
            // 
            // slInfo
            // 
            this.slInfo.Name = "slInfo";
            this.slInfo.Size = new System.Drawing.Size(13, 17);
            this.slInfo.Text = "c";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel13.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Controls.Add(this.tcMainTabs, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 437);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tcMainTabs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tcMainTabs, 2);
            this.tcMainTabs.Controls.Add(this.tpConnection);
            this.tcMainTabs.Controls.Add(this.tpLPDLPRInfo);
            this.tcMainTabs.Controls.Add(this.tpBOJInfo);
            this.tcMainTabs.Controls.Add(this.tpEOJInfo);
            this.tcMainTabs.Controls.Add(this.tpTXTOutput);
            this.tcMainTabs.Controls.Add(this.tpRTFOutput);
            this.tcMainTabs.Controls.Add(this.tpPDFOutput);
            this.tcMainTabs.Controls.Add(this.tpHTMLOutput);
            this.tcMainTabs.Controls.Add(this.tpDiagnostics);
            this.tcMainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMainTabs.Location = new System.Drawing.Point(3, 3);
            this.tcMainTabs.Name = "tcMainTabs";
            this.tableLayoutPanel1.SetRowSpan(this.tcMainTabs, 3);
            this.tcMainTabs.SelectedIndex = 0;
            this.tcMainTabs.Size = new System.Drawing.Size(702, 431);
            this.tcMainTabs.TabIndex = 0;
            // 
            // tpConnection
            // 
            this.tpConnection.Controls.Add(this.tableLayoutPanel2);
            this.tpConnection.Location = new System.Drawing.Point(4, 24);
            this.tpConnection.Name = "tpConnection";
            this.tpConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tpConnection.Size = new System.Drawing.Size(694, 403);
            this.tpConnection.TabIndex = 0;
            this.tpConnection.Text = "Connection";
            this.tpConnection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.Controls.Add(this.gbxDeviceConnection, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnConnect, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gbxTestLogic, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(688, 397);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gbxDeviceConnection
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.gbxDeviceConnection, 4);
            this.gbxDeviceConnection.Controls.Add(this.tableLayoutPanel3);
            this.gbxDeviceConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDeviceConnection.Location = new System.Drawing.Point(3, 3);
            this.gbxDeviceConnection.Name = "gbxDeviceConnection";
            this.gbxDeviceConnection.Size = new System.Drawing.Size(682, 106);
            this.gbxDeviceConnection.TabIndex = 0;
            this.gbxDeviceConnection.TabStop = false;
            this.gbxDeviceConnection.Text = "Hercules Device Connection Info";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 322F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtHostID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ckbConnectOnStart, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtPort, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtBufferSize, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.ckbAutoReconnect, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtAutoReconnectInterval, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label20, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(676, 86);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHostID
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtHostID, 2);
            this.txtHostID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHostID.Location = new System.Drawing.Point(91, 3);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.Size = new System.Drawing.Size(372, 21);
            this.txtHostID.TabIndex = 1;
            this.txtHostID.TextChanged += new System.EventHandler(this.txtHostID_TextChanged);
            // 
            // ckbConnectOnStart
            // 
            this.ckbConnectOnStart.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.ckbConnectOnStart, 3);
            this.ckbConnectOnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbConnectOnStart.Location = new System.Drawing.Point(469, 3);
            this.ckbConnectOnStart.Name = "ckbConnectOnStart";
            this.ckbConnectOnStart.Size = new System.Drawing.Size(204, 22);
            this.ckbConnectOnStart.TabIndex = 7;
            this.ckbConnectOnStart.Text = "Connect on Start";
            this.ckbConnectOnStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buffer Size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPort
            // 
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.Location = new System.Drawing.Point(91, 31);
            this.txtPort.Mask = "00000";
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 21);
            this.txtPort.TabIndex = 5;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtBufferSize
            // 
            this.txtBufferSize.Location = new System.Drawing.Point(91, 59);
            this.txtBufferSize.Mask = "000000";
            this.txtBufferSize.Name = "txtBufferSize";
            this.txtBufferSize.Size = new System.Drawing.Size(50, 21);
            this.txtBufferSize.TabIndex = 6;
            this.txtBufferSize.TextChanged += new System.EventHandler(this.txtBufferSize_TextChanged);
            // 
            // ckbAutoReconnect
            // 
            this.ckbAutoReconnect.AutoSize = true;
            this.ckbAutoReconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbAutoReconnect.Enabled = false;
            this.ckbAutoReconnect.Location = new System.Drawing.Point(147, 31);
            this.ckbAutoReconnect.Name = "ckbAutoReconnect";
            this.ckbAutoReconnect.Size = new System.Drawing.Size(316, 22);
            this.ckbAutoReconnect.TabIndex = 8;
            this.ckbAutoReconnect.Text = "Try to reconnect after connection loss or failure, every:";
            this.ckbAutoReconnect.UseVisualStyleBackColor = true;
            // 
            // txtAutoReconnectInterval
            // 
            this.txtAutoReconnectInterval.Enabled = false;
            this.txtAutoReconnectInterval.Location = new System.Drawing.Point(469, 31);
            this.txtAutoReconnectInterval.Mask = "000";
            this.txtAutoReconnectInterval.Name = "txtAutoReconnectInterval";
            this.txtAutoReconnectInterval.Size = new System.Drawing.Size(30, 21);
            this.txtAutoReconnectInterval.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Enabled = false;
            this.label20.Location = new System.Drawing.Point(505, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 28);
            this.label20.TabIndex = 10;
            this.label20.Text = "seconds";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox3, 4);
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device Output Protocol";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.rbRawProtocol, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rbLPDProtocol, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(676, 30);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // rbRawProtocol
            // 
            this.rbRawProtocol.AutoSize = true;
            this.rbRawProtocol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbRawProtocol.Location = new System.Drawing.Point(3, 3);
            this.rbRawProtocol.Name = "rbRawProtocol";
            this.rbRawProtocol.Size = new System.Drawing.Size(69, 22);
            this.rbRawProtocol.TabIndex = 0;
            this.rbRawProtocol.Text = "RAW";
            this.rbRawProtocol.UseVisualStyleBackColor = true;
            this.rbRawProtocol.CheckedChanged += new System.EventHandler(this.rbRawProtocol_CheckedChanged);
            // 
            // rbLPDProtocol
            // 
            this.rbLPDProtocol.AutoSize = true;
            this.rbLPDProtocol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbLPDProtocol.Enabled = false;
            this.rbLPDProtocol.Location = new System.Drawing.Point(78, 3);
            this.rbLPDProtocol.Name = "rbLPDProtocol";
            this.rbLPDProtocol.Size = new System.Drawing.Size(83, 22);
            this.rbLPDProtocol.TabIndex = 1;
            this.rbLPDProtocol.Text = "LPD/LPR";
            this.rbLPDProtocol.UseVisualStyleBackColor = true;
            this.rbLPDProtocol.CheckedChanged += new System.EventHandler(this.rbLPDProtocol_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(515, 368);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(82, 26);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(603, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 26);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox7
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox7, 4);
            this.groupBox7.Controls.Add(this.tableLayoutPanel14);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 171);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(682, 78);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Print I/O Characteristics";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 7;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel14.Controls.Add(this.ckbHTMLOutput, 4, 1);
            this.tableLayoutPanel14.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.txtLinesPerPage, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.ckbTXTOutput, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.ckbRTFOutput, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.ckbPDFOutput, 3, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 3;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(676, 58);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // ckbHTMLOutput
            // 
            this.ckbHTMLOutput.AutoSize = true;
            this.ckbHTMLOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbHTMLOutput.Location = new System.Drawing.Point(405, 31);
            this.ckbHTMLOutput.Name = "ckbHTMLOutput";
            this.ckbHTMLOutput.Size = new System.Drawing.Size(130, 22);
            this.ckbHTMLOutput.TabIndex = 5;
            this.ckbHTMLOutput.Text = "Output to HTML";
            this.ckbHTMLOutput.UseVisualStyleBackColor = true;
            this.ckbHTMLOutput.CheckedChanged += new System.EventHandler(this.ckbHTMLOutput_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Input Lines Per Page:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLinesPerPage
            // 
            this.txtLinesPerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLinesPerPage.Location = new System.Drawing.Point(139, 3);
            this.txtLinesPerPage.Mask = "000";
            this.txtLinesPerPage.Name = "txtLinesPerPage";
            this.txtLinesPerPage.Size = new System.Drawing.Size(30, 21);
            this.txtLinesPerPage.TabIndex = 1;
            // 
            // ckbTXTOutput
            // 
            this.ckbTXTOutput.AutoSize = true;
            this.ckbTXTOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbTXTOutput.Location = new System.Drawing.Point(3, 31);
            this.ckbTXTOutput.Name = "ckbTXTOutput";
            this.ckbTXTOutput.Size = new System.Drawing.Size(130, 22);
            this.ckbTXTOutput.TabIndex = 2;
            this.ckbTXTOutput.Text = "Output to TXT";
            this.ckbTXTOutput.UseVisualStyleBackColor = true;
            this.ckbTXTOutput.CheckedChanged += new System.EventHandler(this.ckbTXTOutput_CheckedChanged);
            // 
            // ckbRTFOutput
            // 
            this.ckbRTFOutput.AutoSize = true;
            this.tableLayoutPanel14.SetColumnSpan(this.ckbRTFOutput, 2);
            this.ckbRTFOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbRTFOutput.Location = new System.Drawing.Point(139, 31);
            this.ckbRTFOutput.Name = "ckbRTFOutput";
            this.ckbRTFOutput.Size = new System.Drawing.Size(124, 22);
            this.ckbRTFOutput.TabIndex = 3;
            this.ckbRTFOutput.Text = "Output to RTF";
            this.ckbRTFOutput.UseVisualStyleBackColor = true;
            this.ckbRTFOutput.CheckedChanged += new System.EventHandler(this.ckbRTFOutput_CheckedChanged);
            // 
            // ckbPDFOutput
            // 
            this.ckbPDFOutput.AutoSize = true;
            this.ckbPDFOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbPDFOutput.Location = new System.Drawing.Point(269, 31);
            this.ckbPDFOutput.Name = "ckbPDFOutput";
            this.ckbPDFOutput.Size = new System.Drawing.Size(130, 22);
            this.ckbPDFOutput.TabIndex = 4;
            this.ckbPDFOutput.Text = "Output to PDF";
            this.ckbPDFOutput.UseVisualStyleBackColor = true;
            this.ckbPDFOutput.CheckedChanged += new System.EventHandler(this.ckbPDFOutput_CheckedChanged);
            // 
            // gbxTestLogic
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.gbxTestLogic, 4);
            this.gbxTestLogic.Controls.Add(this.tableLayoutPanel22);
            this.gbxTestLogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxTestLogic.Location = new System.Drawing.Point(3, 255);
            this.gbxTestLogic.Name = "gbxTestLogic";
            this.gbxTestLogic.Size = new System.Drawing.Size(682, 54);
            this.gbxTestLogic.TabIndex = 11;
            this.gbxTestLogic.TabStop = false;
            this.gbxTestLogic.Text = "Test Logic";
            this.gbxTestLogic.Visible = false;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 3;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel22.Controls.Add(this.btnTestPacketsFile, 2, 0);
            this.tableLayoutPanel22.Controls.Add(this.btnTest, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.cbxTestPacketsFile, 1, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 2;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(676, 34);
            this.tableLayoutPanel22.TabIndex = 0;
            // 
            // btnTestPacketsFile
            // 
            this.btnTestPacketsFile.BackColor = System.Drawing.Color.Transparent;
            this.btnTestPacketsFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestPacketsFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestPacketsFile.Location = new System.Drawing.Point(643, 3);
            this.btnTestPacketsFile.Name = "btnTestPacketsFile";
            this.btnTestPacketsFile.Size = new System.Drawing.Size(30, 26);
            this.btnTestPacketsFile.TabIndex = 9;
            this.btnTestPacketsFile.Text = "...";
            this.btnTestPacketsFile.UseVisualStyleBackColor = false;
            this.btnTestPacketsFile.Click += new System.EventHandler(this.btnTestPacketsFile_Click);
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTest.Location = new System.Drawing.Point(3, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(74, 26);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cbxTestPacketsFile
            // 
            this.cbxTestPacketsFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTestPacketsFile.FormattingEnabled = true;
            this.cbxTestPacketsFile.Location = new System.Drawing.Point(83, 3);
            this.cbxTestPacketsFile.Name = "cbxTestPacketsFile";
            this.cbxTestPacketsFile.Size = new System.Drawing.Size(554, 23);
            this.cbxTestPacketsFile.TabIndex = 10;
            // 
            // tpLPDLPRInfo
            // 
            this.tpLPDLPRInfo.Controls.Add(this.tableLayoutPanel25);
            this.tpLPDLPRInfo.Location = new System.Drawing.Point(4, 24);
            this.tpLPDLPRInfo.Name = "tpLPDLPRInfo";
            this.tpLPDLPRInfo.Size = new System.Drawing.Size(694, 403);
            this.tpLPDLPRInfo.TabIndex = 8;
            this.tpLPDLPRInfo.Text = "LPD/LPR Processing";
            this.tpLPDLPRInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 3;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel25.Controls.Add(this.groupBox12, 0, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 6;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(694, 403);
            this.tableLayoutPanel25.TabIndex = 2;
            // 
            // groupBox12
            // 
            this.tableLayoutPanel25.SetColumnSpan(this.groupBox12, 3);
            this.groupBox12.Controls.Add(this.tableLayoutPanel27);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(3, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(688, 50);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "LPD Information";
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 5;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel27.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.cbxLPDLPRWorkDir, 1, 0);
            this.tableLayoutPanel27.Controls.Add(this.btnLPDLPRWorkDir, 4, 0);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 2;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(682, 30);
            this.tableLayoutPanel27.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(122, 28);
            this.label22.TabIndex = 0;
            this.label22.Text = "Work Dir:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxLPDLPRWorkDir
            // 
            this.tableLayoutPanel27.SetColumnSpan(this.cbxLPDLPRWorkDir, 3);
            this.cbxLPDLPRWorkDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxLPDLPRWorkDir.FormattingEnabled = true;
            this.cbxLPDLPRWorkDir.Location = new System.Drawing.Point(131, 3);
            this.cbxLPDLPRWorkDir.Name = "cbxLPDLPRWorkDir";
            this.cbxLPDLPRWorkDir.Size = new System.Drawing.Size(512, 23);
            this.cbxLPDLPRWorkDir.TabIndex = 3;
            this.cbxLPDLPRWorkDir.TextChanged += new System.EventHandler(this.cbxLPDLPRWorkDir_TextChanged);
            this.cbxLPDLPRWorkDir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxLPDLPRWorkDir_KeyUp);
            // 
            // btnLPDLPRWorkDir
            // 
            this.btnLPDLPRWorkDir.BackColor = System.Drawing.Color.Transparent;
            this.btnLPDLPRWorkDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLPDLPRWorkDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPDLPRWorkDir.Location = new System.Drawing.Point(649, 3);
            this.btnLPDLPRWorkDir.Name = "btnLPDLPRWorkDir";
            this.btnLPDLPRWorkDir.Size = new System.Drawing.Size(30, 22);
            this.btnLPDLPRWorkDir.TabIndex = 5;
            this.btnLPDLPRWorkDir.Text = "...";
            this.btnLPDLPRWorkDir.UseVisualStyleBackColor = false;
            this.btnLPDLPRWorkDir.Click += new System.EventHandler(this.btnLPDLPRWorkDir_Click);
            // 
            // tpBOJInfo
            // 
            this.tpBOJInfo.Controls.Add(this.tableLayoutPanel11);
            this.tpBOJInfo.Location = new System.Drawing.Point(4, 24);
            this.tpBOJInfo.Name = "tpBOJInfo";
            this.tpBOJInfo.Size = new System.Drawing.Size(694, 403);
            this.tpBOJInfo.TabIndex = 4;
            this.tpBOJInfo.Text = "BOJ Processing";
            this.tpBOJInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel11.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tabControl3, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 4;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(694, 403);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.tableLayoutPanel11.SetColumnSpan(this.groupBox6, 3);
            this.groupBox6.Controls.Add(this.tableLayoutPanel12);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(688, 51);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Beginning of Job Separator Information";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 6;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.txtTrailingBOJSeparatorPages, 3, 0);
            this.tableLayoutPanel12.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.txtBOJSeparatorPages, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.ckbPrintBOJSeparators, 4, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(682, 31);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // txtTrailingBOJSeparatorPages
            // 
            this.txtTrailingBOJSeparatorPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTrailingBOJSeparatorPages.Location = new System.Drawing.Point(378, 3);
            this.txtTrailingBOJSeparatorPages.Mask = "00";
            this.txtTrailingBOJSeparatorPages.Name = "txtTrailingBOJSeparatorPages";
            this.txtTrailingBOJSeparatorPages.Size = new System.Drawing.Size(29, 21);
            this.txtTrailingBOJSeparatorPages.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(206, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Extra Trailing Banner Pages:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Consecutive Banner Pages:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBOJSeparatorPages
            // 
            this.txtBOJSeparatorPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBOJSeparatorPages.Location = new System.Drawing.Point(171, 3);
            this.txtBOJSeparatorPages.Mask = "00";
            this.txtBOJSeparatorPages.Name = "txtBOJSeparatorPages";
            this.txtBOJSeparatorPages.Size = new System.Drawing.Size(29, 21);
            this.txtBOJSeparatorPages.TabIndex = 6;
            // 
            // ckbPrintBOJSeparators
            // 
            this.ckbPrintBOJSeparators.AutoSize = true;
            this.ckbPrintBOJSeparators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbPrintBOJSeparators.Location = new System.Drawing.Point(413, 3);
            this.ckbPrintBOJSeparators.Name = "ckbPrintBOJSeparators";
            this.ckbPrintBOJSeparators.Size = new System.Drawing.Size(130, 22);
            this.ckbPrintBOJSeparators.TabIndex = 9;
            this.ckbPrintBOJSeparators.Text = "Print BOJ Banners";
            this.ckbPrintBOJSeparators.UseVisualStyleBackColor = true;
            this.ckbPrintBOJSeparators.CheckedChanged += new System.EventHandler(this.ckbPrintBOJSeparators_CheckedChanged);
            // 
            // tabControl3
            // 
            this.tableLayoutPanel11.SetColumnSpan(this.tabControl3, 3);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 60);
            this.tabControl3.Name = "tabControl3";
            this.tableLayoutPanel11.SetRowSpan(this.tabControl3, 2);
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(688, 310);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvBOJQualificationInformation);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(680, 282);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Qualification Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvBOJQualificationInformation
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBOJQualificationInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBOJQualificationInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBOJQualificationInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvBOJQualificationInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBOJQualificationInformation.Location = new System.Drawing.Point(3, 3);
            this.dgvBOJQualificationInformation.Name = "dgvBOJQualificationInformation";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBOJQualificationInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBOJQualificationInformation.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBOJQualificationInformation.Size = new System.Drawing.Size(674, 276);
            this.dgvBOJQualificationInformation.TabIndex = 1;
            this.dgvBOJQualificationInformation.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellValueChanged);
            this.dgvBOJQualificationInformation.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRowChanged);
            this.dgvBOJQualificationInformation.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRowChanged);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Must be true";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Line";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Column";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Value";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvBOJFields);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(680, 282);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Fields";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvBOJFields
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBOJFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBOJFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBOJFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvBOJFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBOJFields.Location = new System.Drawing.Point(3, 3);
            this.dgvBOJFields.Name = "dgvBOJFields";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBOJFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBOJFields.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBOJFields.Size = new System.Drawing.Size(674, 276);
            this.dgvBOJFields.TabIndex = 2;
            this.dgvBOJFields.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellValueChanged);
            this.dgvBOJFields.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRowChanged);
            this.dgvBOJFields.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRowChanged);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Field Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Line";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Column";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Width";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Default if blank";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // tpEOJInfo
            // 
            this.tpEOJInfo.Controls.Add(this.tableLayoutPanel9);
            this.tpEOJInfo.Location = new System.Drawing.Point(4, 24);
            this.tpEOJInfo.Name = "tpEOJInfo";
            this.tpEOJInfo.Size = new System.Drawing.Size(694, 403);
            this.tpEOJInfo.TabIndex = 2;
            this.tpEOJInfo.Text = "EOJ Processing";
            this.tpEOJInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel9.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tabControl2, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(694, 403);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.groupBox5, 3);
            this.groupBox5.Controls.Add(this.tableLayoutPanel10);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(688, 51);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "End of Job Separator Information";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 6;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.txtTrailingEOJSeparatorPages, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.txtEOJSeparatorPages, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.ckbPrintEOJSeparators, 4, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(682, 31);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // txtTrailingEOJSeparatorPages
            // 
            this.txtTrailingEOJSeparatorPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTrailingEOJSeparatorPages.Location = new System.Drawing.Point(378, 3);
            this.txtTrailingEOJSeparatorPages.Mask = "00";
            this.txtTrailingEOJSeparatorPages.Name = "txtTrailingEOJSeparatorPages";
            this.txtTrailingEOJSeparatorPages.Size = new System.Drawing.Size(29, 21);
            this.txtTrailingEOJSeparatorPages.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(206, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Extra Trailing Banner Pages:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Consecutive Banner Pages:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEOJSeparatorPages
            // 
            this.txtEOJSeparatorPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEOJSeparatorPages.Location = new System.Drawing.Point(171, 3);
            this.txtEOJSeparatorPages.Mask = "00";
            this.txtEOJSeparatorPages.Name = "txtEOJSeparatorPages";
            this.txtEOJSeparatorPages.Size = new System.Drawing.Size(29, 21);
            this.txtEOJSeparatorPages.TabIndex = 6;
            // 
            // ckbPrintEOJSeparators
            // 
            this.ckbPrintEOJSeparators.AutoSize = true;
            this.ckbPrintEOJSeparators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbPrintEOJSeparators.Location = new System.Drawing.Point(413, 3);
            this.ckbPrintEOJSeparators.Name = "ckbPrintEOJSeparators";
            this.ckbPrintEOJSeparators.Size = new System.Drawing.Size(130, 22);
            this.ckbPrintEOJSeparators.TabIndex = 9;
            this.ckbPrintEOJSeparators.Text = "Print EOJ Banners";
            this.ckbPrintEOJSeparators.UseVisualStyleBackColor = true;
            this.ckbPrintEOJSeparators.CheckedChanged += new System.EventHandler(this.ckbPrintEOJSeparators_CheckedChanged);
            // 
            // tabControl2
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.tabControl2, 3);
            this.tabControl2.Controls.Add(this.tpEOJQualifications);
            this.tabControl2.Controls.Add(this.tpEOJFields);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 60);
            this.tabControl2.Name = "tabControl2";
            this.tableLayoutPanel9.SetRowSpan(this.tabControl2, 2);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(688, 310);
            this.tabControl2.TabIndex = 2;
            // 
            // tpEOJQualifications
            // 
            this.tpEOJQualifications.Controls.Add(this.dgvEOJQualificationInformation);
            this.tpEOJQualifications.Location = new System.Drawing.Point(4, 24);
            this.tpEOJQualifications.Name = "tpEOJQualifications";
            this.tpEOJQualifications.Padding = new System.Windows.Forms.Padding(3);
            this.tpEOJQualifications.Size = new System.Drawing.Size(680, 282);
            this.tpEOJQualifications.TabIndex = 0;
            this.tpEOJQualifications.Text = "Qualification Information";
            this.tpEOJQualifications.UseVisualStyleBackColor = true;
            // 
            // dgvEOJQualificationInformation
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEOJQualificationInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEOJQualificationInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEOJQualificationInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvEOJQualificationInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEOJQualificationInformation.Location = new System.Drawing.Point(3, 3);
            this.dgvEOJQualificationInformation.Name = "dgvEOJQualificationInformation";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEOJQualificationInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEOJQualificationInformation.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEOJQualificationInformation.Size = new System.Drawing.Size(674, 276);
            this.dgvEOJQualificationInformation.TabIndex = 1;
            this.dgvEOJQualificationInformation.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellValueChanged);
            this.dgvEOJQualificationInformation.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRowChanged);
            this.dgvEOJQualificationInformation.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRowChanged);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Must be true";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Line";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tpEOJFields
            // 
            this.tpEOJFields.Controls.Add(this.dgvEOJFields);
            this.tpEOJFields.Location = new System.Drawing.Point(4, 24);
            this.tpEOJFields.Name = "tpEOJFields";
            this.tpEOJFields.Padding = new System.Windows.Forms.Padding(3);
            this.tpEOJFields.Size = new System.Drawing.Size(680, 282);
            this.tpEOJFields.TabIndex = 1;
            this.tpEOJFields.Text = "Fields";
            this.tpEOJFields.UseVisualStyleBackColor = true;
            // 
            // dgvEOJFields
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEOJFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEOJFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEOJFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvEOJFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEOJFields.Location = new System.Drawing.Point(3, 3);
            this.dgvEOJFields.Name = "dgvEOJFields";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEOJFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEOJFields.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEOJFields.Size = new System.Drawing.Size(674, 276);
            this.dgvEOJFields.TabIndex = 2;
            this.dgvEOJFields.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellValueChanged);
            this.dgvEOJFields.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRowChanged);
            this.dgvEOJFields.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRowChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Field Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Line";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Width";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Default if blank";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // tpTXTOutput
            // 
            this.tpTXTOutput.Controls.Add(this.tableLayoutPanel4);
            this.tpTXTOutput.Location = new System.Drawing.Point(4, 24);
            this.tpTXTOutput.Name = "tpTXTOutput";
            this.tpTXTOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tpTXTOutput.Size = new System.Drawing.Size(694, 403);
            this.tpTXTOutput.TabIndex = 1;
            this.tpTXTOutput.Text = "TXT Output";
            this.tpTXTOutput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(688, 397);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox11, 4);
            this.groupBox11.Controls.Add(this.tableLayoutPanel21);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 89);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(682, 52);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Page Output Characteristics";
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 7;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel21.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.txtTXTLinesPerPage, 1, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 2;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(676, 32);
            this.tableLayoutPanel21.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 28);
            this.label18.TabIndex = 0;
            this.label18.Text = "Output Lines Per Page:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTXTLinesPerPage
            // 
            this.txtTXTLinesPerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTXTLinesPerPage.Location = new System.Drawing.Point(147, 3);
            this.txtTXTLinesPerPage.Mask = "000";
            this.txtTXTLinesPerPage.Name = "txtTXTLinesPerPage";
            this.txtTXTLinesPerPage.Size = new System.Drawing.Size(36, 21);
            this.txtTXTLinesPerPage.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox2, 3);
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Destination Information";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.Controls.Add(this.cbxTXTFileTemplate, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.cbxTXTOutputDir, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnTXTOutputDir, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(676, 60);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // cbxTXTFileTemplate
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.cbxTXTFileTemplate, 3);
            this.cbxTXTFileTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTXTFileTemplate.FormattingEnabled = true;
            this.cbxTXTFileTemplate.Location = new System.Drawing.Point(131, 31);
            this.cbxTXTFileTemplate.Name = "cbxTXTFileTemplate";
            this.cbxTXTFileTemplate.Size = new System.Drawing.Size(506, 23);
            this.cbxTXTFileTemplate.TabIndex = 4;
            this.cbxTXTFileTemplate.TextChanged += new System.EventHandler(this.cbxFileTemplate_TextChanged);
            this.cbxTXTFileTemplate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxFileTemplate_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Output Dir:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "File Name Template:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxTXTOutputDir
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.cbxTXTOutputDir, 3);
            this.cbxTXTOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTXTOutputDir.FormattingEnabled = true;
            this.cbxTXTOutputDir.Location = new System.Drawing.Point(131, 3);
            this.cbxTXTOutputDir.Name = "cbxTXTOutputDir";
            this.cbxTXTOutputDir.Size = new System.Drawing.Size(506, 23);
            this.cbxTXTOutputDir.TabIndex = 3;
            this.cbxTXTOutputDir.TextChanged += new System.EventHandler(this.cbxOutputDir_TextChanged);
            this.cbxTXTOutputDir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxOutputDir_KeyUp);
            // 
            // btnTXTOutputDir
            // 
            this.btnTXTOutputDir.BackColor = System.Drawing.Color.Transparent;
            this.btnTXTOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTXTOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTXTOutputDir.Location = new System.Drawing.Point(643, 3);
            this.btnTXTOutputDir.Name = "btnTXTOutputDir";
            this.btnTXTOutputDir.Size = new System.Drawing.Size(30, 22);
            this.btnTXTOutputDir.TabIndex = 5;
            this.btnTXTOutputDir.Text = "...";
            this.btnTXTOutputDir.UseVisualStyleBackColor = false;
            this.btnTXTOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // tpRTFOutput
            // 
            this.tpRTFOutput.Controls.Add(this.tableLayoutPanel15);
            this.tpRTFOutput.Location = new System.Drawing.Point(4, 24);
            this.tpRTFOutput.Name = "tpRTFOutput";
            this.tpRTFOutput.Size = new System.Drawing.Size(694, 403);
            this.tpRTFOutput.TabIndex = 5;
            this.tpRTFOutput.Text = "RTF Output";
            this.tpRTFOutput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel15.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 6;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(694, 403);
            this.tableLayoutPanel15.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.tableLayoutPanel15.SetColumnSpan(this.groupBox8, 3);
            this.groupBox8.Controls.Add(this.tableLayoutPanel16);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(688, 80);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Output Destination Information";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 5;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel16.Controls.Add(this.cbxRTFFileTemplate, 1, 1);
            this.tableLayoutPanel16.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.cbxRTFOutputDir, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.btnRTFOutputDir, 4, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 3;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(682, 60);
            this.tableLayoutPanel16.TabIndex = 2;
            // 
            // cbxRTFFileTemplate
            // 
            this.tableLayoutPanel16.SetColumnSpan(this.cbxRTFFileTemplate, 3);
            this.cbxRTFFileTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRTFFileTemplate.FormattingEnabled = true;
            this.cbxRTFFileTemplate.Location = new System.Drawing.Point(131, 31);
            this.cbxRTFFileTemplate.Name = "cbxRTFFileTemplate";
            this.cbxRTFFileTemplate.Size = new System.Drawing.Size(512, 23);
            this.cbxRTFFileTemplate.TabIndex = 4;
            this.cbxRTFFileTemplate.TextChanged += new System.EventHandler(this.cbxFileTemplate_TextChanged);
            this.cbxRTFFileTemplate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxFileTemplate_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Output Dir:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 28);
            this.label13.TabIndex = 2;
            this.label13.Text = "File Name Template:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRTFOutputDir
            // 
            this.tableLayoutPanel16.SetColumnSpan(this.cbxRTFOutputDir, 3);
            this.cbxRTFOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRTFOutputDir.FormattingEnabled = true;
            this.cbxRTFOutputDir.Location = new System.Drawing.Point(131, 3);
            this.cbxRTFOutputDir.Name = "cbxRTFOutputDir";
            this.cbxRTFOutputDir.Size = new System.Drawing.Size(512, 23);
            this.cbxRTFOutputDir.TabIndex = 3;
            this.cbxRTFOutputDir.TextChanged += new System.EventHandler(this.cbxOutputDir_TextChanged);
            this.cbxRTFOutputDir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxOutputDir_KeyUp);
            // 
            // btnRTFOutputDir
            // 
            this.btnRTFOutputDir.BackColor = System.Drawing.Color.Transparent;
            this.btnRTFOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRTFOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTFOutputDir.Location = new System.Drawing.Point(649, 3);
            this.btnRTFOutputDir.Name = "btnRTFOutputDir";
            this.btnRTFOutputDir.Size = new System.Drawing.Size(30, 22);
            this.btnRTFOutputDir.TabIndex = 5;
            this.btnRTFOutputDir.Text = "...";
            this.btnRTFOutputDir.UseVisualStyleBackColor = false;
            this.btnRTFOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // tpPDFOutput
            // 
            this.tpPDFOutput.Controls.Add(this.tableLayoutPanel17);
            this.tpPDFOutput.Location = new System.Drawing.Point(4, 24);
            this.tpPDFOutput.Name = "tpPDFOutput";
            this.tpPDFOutput.Size = new System.Drawing.Size(694, 403);
            this.tpPDFOutput.TabIndex = 6;
            this.tpPDFOutput.Text = "PDF Output";
            this.tpPDFOutput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 3;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel24, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 6;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(694, 403);
            this.tableLayoutPanel17.TabIndex = 2;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 6;
            this.tableLayoutPanel17.SetColumnSpan(this.tableLayoutPanel24, 3);
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Controls.Add(this.cbxPDFPaperSize, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.lblPaperDimensions, 2, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 2;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(688, 36);
            this.tableLayoutPanel24.TabIndex = 4;
            // 
            // cbxPDFPaperSize
            // 
            this.cbxPDFPaperSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPDFPaperSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPDFPaperSize.Items.AddRange(new object[] {
            "Fanfold",
            "Letter"});
            this.cbxPDFPaperSize.Location = new System.Drawing.Point(99, 3);
            this.cbxPDFPaperSize.Name = "cbxPDFPaperSize";
            this.cbxPDFPaperSize.Size = new System.Drawing.Size(90, 23);
            this.cbxPDFPaperSize.TabIndex = 0;
            this.cbxPDFPaperSize.SelectedValueChanged += new System.EventHandler(this.cbxPDFPaperSize_SelectedValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 28);
            this.label19.TabIndex = 1;
            this.label19.Text = "Paper size:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaperDimensions
            // 
            this.lblPaperDimensions.AutoSize = true;
            this.lblPaperDimensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaperDimensions.Location = new System.Drawing.Point(195, 0);
            this.lblPaperDimensions.Name = "lblPaperDimensions";
            this.lblPaperDimensions.Size = new System.Drawing.Size(122, 28);
            this.lblPaperDimensions.TabIndex = 2;
            this.lblPaperDimensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox9
            // 
            this.tableLayoutPanel17.SetColumnSpan(this.groupBox9, 3);
            this.groupBox9.Controls.Add(this.tableLayoutPanel18);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(688, 80);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Output Destination Information";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 5;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel18.Controls.Add(this.cbxPDFFileTemplate, 1, 1);
            this.tableLayoutPanel18.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.cbxPDFOutputDir, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.btnPDFOutputDir, 4, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 3;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(682, 60);
            this.tableLayoutPanel18.TabIndex = 2;
            // 
            // cbxPDFFileTemplate
            // 
            this.tableLayoutPanel18.SetColumnSpan(this.cbxPDFFileTemplate, 3);
            this.cbxPDFFileTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPDFFileTemplate.FormattingEnabled = true;
            this.cbxPDFFileTemplate.Location = new System.Drawing.Point(131, 31);
            this.cbxPDFFileTemplate.Name = "cbxPDFFileTemplate";
            this.cbxPDFFileTemplate.Size = new System.Drawing.Size(512, 23);
            this.cbxPDFFileTemplate.TabIndex = 4;
            this.cbxPDFFileTemplate.TextChanged += new System.EventHandler(this.cbxFileTemplate_TextChanged);
            this.cbxPDFFileTemplate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxFileTemplate_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "Output Dir:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 28);
            this.label15.TabIndex = 2;
            this.label15.Text = "File Name Template:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPDFOutputDir
            // 
            this.tableLayoutPanel18.SetColumnSpan(this.cbxPDFOutputDir, 3);
            this.cbxPDFOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPDFOutputDir.FormattingEnabled = true;
            this.cbxPDFOutputDir.Location = new System.Drawing.Point(131, 3);
            this.cbxPDFOutputDir.Name = "cbxPDFOutputDir";
            this.cbxPDFOutputDir.Size = new System.Drawing.Size(512, 23);
            this.cbxPDFOutputDir.TabIndex = 3;
            this.cbxPDFOutputDir.TextChanged += new System.EventHandler(this.cbxOutputDir_TextChanged);
            this.cbxPDFOutputDir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxOutputDir_KeyUp);
            // 
            // btnPDFOutputDir
            // 
            this.btnPDFOutputDir.BackColor = System.Drawing.Color.Transparent;
            this.btnPDFOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPDFOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFOutputDir.Location = new System.Drawing.Point(649, 3);
            this.btnPDFOutputDir.Name = "btnPDFOutputDir";
            this.btnPDFOutputDir.Size = new System.Drawing.Size(30, 22);
            this.btnPDFOutputDir.TabIndex = 5;
            this.btnPDFOutputDir.Text = "...";
            this.btnPDFOutputDir.UseVisualStyleBackColor = false;
            this.btnPDFOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // tpHTMLOutput
            // 
            this.tpHTMLOutput.Controls.Add(this.tableLayoutPanel19);
            this.tpHTMLOutput.Location = new System.Drawing.Point(4, 24);
            this.tpHTMLOutput.Name = "tpHTMLOutput";
            this.tpHTMLOutput.Size = new System.Drawing.Size(694, 403);
            this.tpHTMLOutput.TabIndex = 7;
            this.tpHTMLOutput.Text = "HTML Output";
            this.tpHTMLOutput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 3;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel19.Controls.Add(this.tableLayoutPanel23, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.groupBox10, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 6;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(694, 403);
            this.tableLayoutPanel19.TabIndex = 3;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 6;
            this.tableLayoutPanel19.SetColumnSpan(this.tableLayoutPanel23, 3);
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Controls.Add(this.ckbHTMLHeader, 0, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 2;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(688, 32);
            this.tableLayoutPanel23.TabIndex = 3;
            // 
            // ckbHTMLHeader
            // 
            this.ckbHTMLHeader.AutoSize = true;
            this.ckbHTMLHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbHTMLHeader.Location = new System.Drawing.Point(3, 3);
            this.ckbHTMLHeader.Name = "ckbHTMLHeader";
            this.ckbHTMLHeader.Size = new System.Drawing.Size(218, 22);
            this.ckbHTMLHeader.TabIndex = 4;
            this.ckbHTMLHeader.Text = "Use File Name for HTML Header";
            this.ckbHTMLHeader.UseVisualStyleBackColor = true;
            this.ckbHTMLHeader.CheckedChanged += new System.EventHandler(this.ckbHTMLHeader_CheckedChanged);
            // 
            // groupBox10
            // 
            this.tableLayoutPanel19.SetColumnSpan(this.groupBox10, 3);
            this.groupBox10.Controls.Add(this.tableLayoutPanel20);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(688, 80);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Output Destination Information";
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 5;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel20.Controls.Add(this.cbxHTMLFileTemplate, 1, 1);
            this.tableLayoutPanel20.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.cbxHTMLOutputDir, 1, 0);
            this.tableLayoutPanel20.Controls.Add(this.btnHTMLOutputDir, 4, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 3;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(682, 60);
            this.tableLayoutPanel20.TabIndex = 2;
            // 
            // cbxHTMLFileTemplate
            // 
            this.tableLayoutPanel20.SetColumnSpan(this.cbxHTMLFileTemplate, 3);
            this.cbxHTMLFileTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxHTMLFileTemplate.FormattingEnabled = true;
            this.cbxHTMLFileTemplate.Location = new System.Drawing.Point(131, 31);
            this.cbxHTMLFileTemplate.Name = "cbxHTMLFileTemplate";
            this.cbxHTMLFileTemplate.Size = new System.Drawing.Size(512, 23);
            this.cbxHTMLFileTemplate.TabIndex = 4;
            this.cbxHTMLFileTemplate.TextChanged += new System.EventHandler(this.cbxFileTemplate_TextChanged);
            this.cbxHTMLFileTemplate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxFileTemplate_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "Output Dir:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 28);
            this.label17.TabIndex = 2;
            this.label17.Text = "File Name Template:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxHTMLOutputDir
            // 
            this.tableLayoutPanel20.SetColumnSpan(this.cbxHTMLOutputDir, 3);
            this.cbxHTMLOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxHTMLOutputDir.FormattingEnabled = true;
            this.cbxHTMLOutputDir.Location = new System.Drawing.Point(131, 3);
            this.cbxHTMLOutputDir.Name = "cbxHTMLOutputDir";
            this.cbxHTMLOutputDir.Size = new System.Drawing.Size(512, 23);
            this.cbxHTMLOutputDir.TabIndex = 3;
            this.cbxHTMLOutputDir.TextChanged += new System.EventHandler(this.cbxOutputDir_TextChanged);
            this.cbxHTMLOutputDir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxOutputDir_KeyUp);
            // 
            // btnHTMLOutputDir
            // 
            this.btnHTMLOutputDir.BackColor = System.Drawing.Color.Transparent;
            this.btnHTMLOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHTMLOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTMLOutputDir.Location = new System.Drawing.Point(649, 3);
            this.btnHTMLOutputDir.Name = "btnHTMLOutputDir";
            this.btnHTMLOutputDir.Size = new System.Drawing.Size(30, 22);
            this.btnHTMLOutputDir.TabIndex = 5;
            this.btnHTMLOutputDir.Text = "...";
            this.btnHTMLOutputDir.UseVisualStyleBackColor = false;
            this.btnHTMLOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // tpDiagnostics
            // 
            this.tpDiagnostics.Controls.Add(this.tableLayoutPanel7);
            this.tpDiagnostics.Location = new System.Drawing.Point(4, 24);
            this.tpDiagnostics.Name = "tpDiagnostics";
            this.tpDiagnostics.Size = new System.Drawing.Size(694, 403);
            this.tpDiagnostics.TabIndex = 3;
            this.tpDiagnostics.Text = "Diagnostics";
            this.tpDiagnostics.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.rtbDiagnosticOutput, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnSaveDiagnostics, 3, 3);
            this.tableLayoutPanel7.Controls.Add(this.btnClearDiagnostics, 2, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(694, 403);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.groupBox4, 4);
            this.groupBox4.Controls.Add(this.tableLayoutPanel8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(688, 76);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Diagnostics";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 6;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.cbDumpPacketsFile, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnDumpPacketsFile, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.ckbDumpPackets, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.ckbVerboseLogging, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.ckbDisplayInput, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.ckbDisplayStatistics, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.ckbProtocolLogging, 3, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(682, 56);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // cbDumpPacketsFile
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.cbDumpPacketsFile, 3);
            this.cbDumpPacketsFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDumpPacketsFile.Enabled = false;
            this.cbDumpPacketsFile.FormattingEnabled = true;
            this.cbDumpPacketsFile.Location = new System.Drawing.Point(131, 3);
            this.cbDumpPacketsFile.Name = "cbDumpPacketsFile";
            this.cbDumpPacketsFile.Size = new System.Drawing.Size(378, 23);
            this.cbDumpPacketsFile.TabIndex = 9;
            // 
            // btnDumpPacketsFile
            // 
            this.btnDumpPacketsFile.BackColor = System.Drawing.Color.Transparent;
            this.btnDumpPacketsFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDumpPacketsFile.Enabled = false;
            this.btnDumpPacketsFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDumpPacketsFile.Location = new System.Drawing.Point(515, 3);
            this.btnDumpPacketsFile.Name = "btnDumpPacketsFile";
            this.btnDumpPacketsFile.Size = new System.Drawing.Size(30, 22);
            this.btnDumpPacketsFile.TabIndex = 8;
            this.btnDumpPacketsFile.Text = "...";
            this.btnDumpPacketsFile.UseVisualStyleBackColor = false;
            this.btnDumpPacketsFile.Click += new System.EventHandler(this.btnDumpPacketsFile_Click);
            // 
            // ckbDumpPackets
            // 
            this.ckbDumpPackets.AutoSize = true;
            this.ckbDumpPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbDumpPackets.Location = new System.Drawing.Point(3, 3);
            this.ckbDumpPackets.Name = "ckbDumpPackets";
            this.ckbDumpPackets.Size = new System.Drawing.Size(122, 22);
            this.ckbDumpPackets.TabIndex = 4;
            this.ckbDumpPackets.Text = "Dump Packets";
            this.ckbDumpPackets.UseVisualStyleBackColor = true;
            this.ckbDumpPackets.CheckedChanged += new System.EventHandler(this.ckbDumpPackets_CheckedChanged);
            // 
            // ckbVerboseLogging
            // 
            this.ckbVerboseLogging.AutoSize = true;
            this.ckbVerboseLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbVerboseLogging.Location = new System.Drawing.Point(3, 31);
            this.ckbVerboseLogging.Name = "ckbVerboseLogging";
            this.ckbVerboseLogging.Size = new System.Drawing.Size(122, 22);
            this.ckbVerboseLogging.TabIndex = 3;
            this.ckbVerboseLogging.Text = "Verbose Logging";
            this.ckbVerboseLogging.UseVisualStyleBackColor = true;
            this.ckbVerboseLogging.CheckedChanged += new System.EventHandler(this.ckbDisplayPackets_CheckedChanged);
            // 
            // ckbDisplayInput
            // 
            this.ckbDisplayInput.AutoSize = true;
            this.ckbDisplayInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbDisplayInput.Location = new System.Drawing.Point(131, 31);
            this.ckbDisplayInput.Name = "ckbDisplayInput";
            this.ckbDisplayInput.Size = new System.Drawing.Size(122, 22);
            this.ckbDisplayInput.TabIndex = 7;
            this.ckbDisplayInput.Text = "Display Input";
            this.ckbDisplayInput.UseVisualStyleBackColor = true;
            this.ckbDisplayInput.CheckedChanged += new System.EventHandler(this.ckbDisplayInput_CheckedChanged);
            // 
            // ckbDisplayStatistics
            // 
            this.ckbDisplayStatistics.AutoSize = true;
            this.ckbDisplayStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbDisplayStatistics.Location = new System.Drawing.Point(259, 31);
            this.ckbDisplayStatistics.Name = "ckbDisplayStatistics";
            this.ckbDisplayStatistics.Size = new System.Drawing.Size(122, 22);
            this.ckbDisplayStatistics.TabIndex = 5;
            this.ckbDisplayStatistics.Text = "Display Statistics";
            this.ckbDisplayStatistics.UseVisualStyleBackColor = true;
            this.ckbDisplayStatistics.CheckedChanged += new System.EventHandler(this.ckbDisplayStatistics_CheckedChanged);
            // 
            // ckbProtocolLogging
            // 
            this.ckbProtocolLogging.AutoSize = true;
            this.ckbProtocolLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbProtocolLogging.Enabled = false;
            this.ckbProtocolLogging.Location = new System.Drawing.Point(387, 31);
            this.ckbProtocolLogging.Name = "ckbProtocolLogging";
            this.ckbProtocolLogging.Size = new System.Drawing.Size(122, 22);
            this.ckbProtocolLogging.TabIndex = 6;
            this.ckbProtocolLogging.Text = "Protocol Logging";
            this.ckbProtocolLogging.UseVisualStyleBackColor = true;
            this.ckbProtocolLogging.CheckedChanged += new System.EventHandler(this.ckbProtocolLogging_CheckedChanged);
            // 
            // rtbDiagnosticOutput
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.rtbDiagnosticOutput, 4);
            this.rtbDiagnosticOutput.Font = new System.Drawing.Font("Liberation Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDiagnosticOutput.Location = new System.Drawing.Point(3, 85);
            this.rtbDiagnosticOutput.Name = "rtbDiagnosticOutput";
            this.tableLayoutPanel7.SetRowSpan(this.rtbDiagnosticOutput, 2);
            this.rtbDiagnosticOutput.Size = new System.Drawing.Size(548, 201);
            this.rtbDiagnosticOutput.TabIndex = 1;
            this.rtbDiagnosticOutput.Text = "";
            // 
            // btnSaveDiagnostics
            // 
            this.btnSaveDiagnostics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveDiagnostics.Location = new System.Drawing.Point(621, 376);
            this.btnSaveDiagnostics.Name = "btnSaveDiagnostics";
            this.btnSaveDiagnostics.Size = new System.Drawing.Size(70, 24);
            this.btnSaveDiagnostics.TabIndex = 3;
            this.btnSaveDiagnostics.Text = "Save";
            this.btnSaveDiagnostics.UseVisualStyleBackColor = true;
            // 
            // btnClearDiagnostics
            // 
            this.btnClearDiagnostics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearDiagnostics.Location = new System.Drawing.Point(544, 376);
            this.btnClearDiagnostics.Name = "btnClearDiagnostics";
            this.btnClearDiagnostics.Size = new System.Drawing.Size(71, 24);
            this.btnClearDiagnostics.TabIndex = 4;
            this.btnClearDiagnostics.Text = "Clear";
            this.btnClearDiagnostics.UseVisualStyleBackColor = true;
            // 
            // cmsReplacement
            // 
            this.cmsReplacement.Name = "cmsReplacement";
            this.cmsReplacement.Size = new System.Drawing.Size(61, 4);
            // 
            // tTimer
            // 
            this.tTimer.Interval = 200;
            this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel13.Controls.Add(this.btnPrinterDefinitionFile, 2, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.cbxPrinterDefinitionFile, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(714, 475);
            this.tableLayoutPanel13.TabIndex = 5;
            // 
            // btnPrinterDefinitionFile
            // 
            this.btnPrinterDefinitionFile.BackColor = System.Drawing.Color.Transparent;
            this.btnPrinterDefinitionFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrinterDefinitionFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinterDefinitionFile.Location = new System.Drawing.Point(681, 3);
            this.btnPrinterDefinitionFile.Name = "btnPrinterDefinitionFile";
            this.btnPrinterDefinitionFile.Size = new System.Drawing.Size(30, 26);
            this.btnPrinterDefinitionFile.TabIndex = 6;
            this.btnPrinterDefinitionFile.Text = "...";
            this.btnPrinterDefinitionFile.UseVisualStyleBackColor = false;
            this.btnPrinterDefinitionFile.Click += new System.EventHandler(this.btnPrinterDefinitionFile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 32);
            this.label10.TabIndex = 5;
            this.label10.Text = "Printer Definition File:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPrinterDefinitionFile
            // 
            this.cbxPrinterDefinitionFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPrinterDefinitionFile.FormattingEnabled = true;
            this.cbxPrinterDefinitionFile.Location = new System.Drawing.Point(139, 3);
            this.cbxPrinterDefinitionFile.Name = "cbxPrinterDefinitionFile";
            this.cbxPrinterDefinitionFile.Size = new System.Drawing.Size(536, 23);
            this.cbxPrinterDefinitionFile.TabIndex = 7;
            this.cbxPrinterDefinitionFile.TextChanged += new System.EventHandler(this.cbxPrinterDefinitionFile_TextChanged);
            this.cbxPrinterDefinitionFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxPrinterDefinitionFile_KeyUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hercules Print Spooler";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // PrtMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 521);
            this.Controls.Add(this.tableLayoutPanel13);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(730, 560);
            this.Name = "PrtMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hercules Print Spooler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrtMain_FormClosing);
            this.Resize += new System.EventHandler(this.PrtMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tcMainTabs.ResumeLayout(false);
            this.tpConnection.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbxDeviceConnection.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.gbxTestLogic.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tpLPDLPRInfo.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.tpBOJInfo.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBOJQualificationInformation)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBOJFields)).EndInit();
            this.tpEOJInfo.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tpEOJQualifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEOJQualificationInformation)).EndInit();
            this.tpEOJFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEOJFields)).EndInit();
            this.tpTXTOutput.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tpRTFOutput.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tpPDFOutput.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tpHTMLOutput.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tpDiagnostics.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tcMainTabs;
        private System.Windows.Forms.TabPage tpConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbxDeviceConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHostID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPort;
        private System.Windows.Forms.MaskedTextBox txtBufferSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rbRawProtocol;
        private System.Windows.Forms.RadioButton rbLPDProtocol;
        private System.Windows.Forms.TabPage tpTXTOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpEOJInfo;
        private System.Windows.Forms.TabPage tpDiagnostics;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.CheckBox ckbVerboseLogging;
        private System.Windows.Forms.CheckBox ckbDumpPackets;
        private System.Windows.Forms.CheckBox ckbDisplayStatistics;
        private System.Windows.Forms.CheckBox ckbProtocolLogging;
        private System.Windows.Forms.RichTextBox rtbDiagnosticOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ContextMenuStrip cmsReplacement;
        private System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.CheckBox ckbDisplayInput;
        private System.Windows.Forms.DataGridView dgvEOJQualificationInformation;
        private System.Windows.Forms.TabPage tpBOJInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.MaskedTextBox txtTrailingEOJSeparatorPages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtEOJSeparatorPages;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpEOJQualifications;
        private System.Windows.Forms.TabPage tpEOJFields;
        private System.Windows.Forms.DataGridView dgvEOJFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.MaskedTextBox txtTrailingBOJSeparatorPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtBOJSeparatorPages;
        private System.Windows.Forms.CheckBox ckbPrintBOJSeparators;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvBOJQualificationInformation;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvBOJFields;
        private System.Windows.Forms.CheckBox ckbPrintEOJSeparators;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.CheckBox ckbConnectOnStart;
        private System.Windows.Forms.Button btnSaveDiagnostics;
        private System.Windows.Forms.Button btnClearDiagnostics;
        private System.Windows.Forms.ComboBox cbxTXTFileTemplate;
        private System.Windows.Forms.ComboBox cbxTXTOutputDir;
        private System.Windows.Forms.Button btnTXTOutputDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenPrinterDefintionFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSavePrinterDefinitionFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSavePrinterDefinitionFileAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnPrinterDefinitionFile;
        private System.Windows.Forms.ComboBox cbxPrinterDefinitionFile;
        private System.Windows.Forms.ToolStripStatusLabel slTime;
        private System.Windows.Forms.ToolStripStatusLabel slConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel slInfo;
        private System.Windows.Forms.TabPage tpRTFOutput;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtLinesPerPage;
        private System.Windows.Forms.CheckBox ckbTXTOutput;
        private System.Windows.Forms.CheckBox ckbRTFOutput;
        private System.Windows.Forms.CheckBox ckbPDFOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.ComboBox cbxRTFFileTemplate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxRTFOutputDir;
        private System.Windows.Forms.Button btnRTFOutputDir;
        private System.Windows.Forms.TabPage tpPDFOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.ComboBox cbxPDFFileTemplate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxPDFOutputDir;
        private System.Windows.Forms.Button btnPDFOutputDir;
        private System.Windows.Forms.CheckBox ckbHTMLOutput;
        private System.Windows.Forms.TabPage tpHTMLOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.ComboBox cbxHTMLFileTemplate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxHTMLOutputDir;
        private System.Windows.Forms.Button btnHTMLOutputDir;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtTXTLinesPerPage;
        private System.Windows.Forms.ComboBox cbDumpPacketsFile;
        private System.Windows.Forms.Button btnDumpPacketsFile;
        private System.Windows.Forms.GroupBox gbxTestLogic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.Button btnTestPacketsFile;
        private System.Windows.Forms.ComboBox cbxTestPacketsFile;
        private System.Windows.Forms.ToolStripMenuItem mnuDebug;
        private System.Windows.Forms.ToolStripMenuItem mnuDebugTestLogic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.CheckBox ckbHTMLHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPaperDimensions;
        private System.Windows.Forms.ComboBox cbxPDFPaperSize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tpLPDLPRInfo;
        private System.Windows.Forms.CheckBox ckbAutoReconnect;
        private System.Windows.Forms.MaskedTextBox txtAutoReconnectInterval;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbxLPDLPRWorkDir;
        private System.Windows.Forms.Button btnLPDLPRWorkDir;
    }
}


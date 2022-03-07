using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

using CustomExtensions;
using CustomStructures;

namespace Hercules_Prt
{
    public partial class PrtMain : Form
    {
        private XMLConfiguration xmlConfiguration;
        private XMLHerculesPrt xmlHerculesPrt = new XMLHerculesPrt();

        private FileStream packetFile;

        private PrtTXT txtOut;
        private PrtRTF rtfOut;
        private PrtPDF pdfOut;
        private PrtHTML htmlOut;

        private bool formLoading = true;
        private bool dgvChanged = false;

        private HerculesConnection _herculesConnection;
        private Action<String> _invokeAction;
        private Globals gbl = new Globals();

        //private List<CustomFieldData> BOJFieldData;
        //private List<CustomFieldData> EOJFieldData;
        private List<CustomQualificationData> BOJQualifications;
        private List<CustomQualificationData> EOJQualifications;
        private List<CustomFieldValue> BOJFieldValues;
        private List<CustomFieldValue> EOJFieldValues;

        private List<TabPage> hiddenPages = new List<TabPage>();

        public PrtMain()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        #region Initialization and Configuration
        private void MyInitializeComponent()
        {
            slTime.Text = "";
            slConnectionStatus.Text = "";
            slInfo.Text = "";

            LoadConfiguration();
            txtOut = new PrtTXT(xmlHerculesPrt);
            rtfOut = new PrtRTF(xmlHerculesPrt);
            pdfOut = new PrtPDF(xmlHerculesPrt);
            htmlOut = new PrtHTML(xmlHerculesPrt);

            _herculesConnection = new HerculesConnection();
            _invokeAction = s => AppendOutput(s);

            if (rbRawProtocol.Checked)
            {
                hiddenPages.Add(tpLPDLPRInfo);
                tcMainTabs.TabPages.Remove(tpLPDLPRInfo);
            }
            if (rbLPDProtocol.Checked)
            {
                hiddenPages.Add(tpBOJInfo);
                hiddenPages.Add(tpEOJInfo);
                tcMainTabs.TabPages.Remove(tpBOJInfo);
                tcMainTabs.TabPages.Remove(tpEOJInfo);
            }
            if (!(ckbTXTOutput.Checked))
            {
                hiddenPages.Add(tpTXTOutput);
                tcMainTabs.TabPages.Remove(tpTXTOutput);
            }
            if (!(ckbRTFOutput.Checked))
            {
                hiddenPages.Add(tpRTFOutput);
                tcMainTabs.TabPages.Remove(tpRTFOutput);
            }
            if (!(ckbPDFOutput.Checked))
            {
                hiddenPages.Add(tpPDFOutput);
                tcMainTabs.TabPages.Remove(tpPDFOutput);
            }
            if (!(ckbHTMLOutput.Checked))
            {
                hiddenPages.Add(tpHTMLOutput);
                tcMainTabs.TabPages.Remove(tpHTMLOutput);
            }

            if (xmlHerculesPrt.Connection.ConnectAtStartChecked.ToBool())
            {
                ConnectToHercules();
            }

            formLoading = false;
        }

        private void LoadConfiguration()
        {
            string configName = XMLConfiguration.GetSaveFileName();
            //configName = configName.Replace(".xml", "_new.xml");
            xmlConfiguration = XMLConfiguration.Load(configName);

            Left = xmlConfiguration.window.main.Left;
            Top = xmlConfiguration.window.main.Top;
            Height = xmlConfiguration.window.main.Height;
            Width = xmlConfiguration.window.main.Width;

            switch (xmlConfiguration.window.main.State)
            {
                case "Minimized":
                    WindowState = FormWindowState.Minimized;
                    break;
                case "Maximized":
                    WindowState = FormWindowState.Maximized;
                    break;
                default:
                    WindowState = FormWindowState.Normal;
                    break;
            }

            cbxPrinterDefinitionFile.Items.Clear();
            if (xmlConfiguration.definitionFiles.selectedFile.Text != "")
            {
                foreach (var pick in xmlConfiguration.definitionFiles.filePicks)
                {
                    cbxPrinterDefinitionFile.Items.Add(pick.Text);
                }
                cbxPrinterDefinitionFile.Text = xmlConfiguration.definitionFiles.selectedFile.Text;
            }

            //LoadPrinterDefinition();

            xmlHerculesPrt.IsDirty = false;
        }

        private void LoadPrinterDefinition()
        {
            xmlHerculesPrt = XMLHerculesPrt.Load(cbxPrinterDefinitionFile.Text);

            txtHostID.Text = xmlHerculesPrt.Connection.HerculesIP;
            txtBufferSize.Text = xmlHerculesPrt.Connection.BufferSize.ToString();

            ckbTXTOutput.Checked = xmlHerculesPrt.CustomizationData.OutputToTXT.ToBool();
            ckbRTFOutput.Checked = xmlHerculesPrt.CustomizationData.OutputToRTF.ToBool();
            ckbPDFOutput.Checked = xmlHerculesPrt.CustomizationData.OutputToPDF.ToBool();
            ckbHTMLOutput.Checked = xmlHerculesPrt.CustomizationData.OutputToHTML.ToBool();

            if (xmlHerculesPrt.Connection.Protocol == "RAW")
            {
                rbLPDProtocol.Checked = false;
                rbRawProtocol.Checked = true;
                txtPort.Text = xmlHerculesPrt.Connection.RAWHostPort.ToString();
            }
            else
            {
                rbRawProtocol.Checked = false;
                rbLPDProtocol.Checked = true;
                txtPort.Text = xmlHerculesPrt.Connection.LPDLPRHostPort.ToString();
            }

            txtLinesPerPage.Text = xmlHerculesPrt.Connection.InputLinesPerPage.ToString();

            cbxLPDLPRWorkDir.Items.Clear();
            cbxLPDLPRWorkDir.Text = xmlHerculesPrt.LPDLPRProcessing.WorkDir;
            ReplaceComboBoxItems(cbxLPDLPRWorkDir, xmlHerculesPrt.LPDLPRProcessing.WorkDirPicks.ToList());

            cbxTXTOutputDir.Items.Clear();
            cbxTXTOutputDir.Text = xmlHerculesPrt.TXTOutput.OutputDir;
            ReplaceComboBoxItems(cbxTXTOutputDir, xmlHerculesPrt.TXTOutput.OutputDirPicks.ToList());

            cbxTXTFileTemplate.Items.Clear();
            cbxTXTFileTemplate.Text = xmlHerculesPrt.TXTOutput.OutputFileTemplate;
            ReplaceComboBoxItems(cbxTXTFileTemplate, xmlHerculesPrt.TXTOutput.OutputFileTemplatePicks.ToList());

            cbxRTFOutputDir.Items.Clear();
            cbxRTFOutputDir.Text = xmlHerculesPrt.RTFOutput.OutputDir;
            ReplaceComboBoxItems(cbxRTFOutputDir, xmlHerculesPrt.RTFOutput.OutputDirPicks.ToList());

            cbxRTFFileTemplate.Items.Clear();
            cbxRTFFileTemplate.Text = xmlHerculesPrt.RTFOutput.OutputFileTemplate;
            ReplaceComboBoxItems(cbxRTFFileTemplate, xmlHerculesPrt.RTFOutput.OutputFileTemplatePicks.ToList());

            ReplaceComboBoxItems(cbxPDFOutputDir, xmlHerculesPrt.PDFOutput.OutputDirPicks.ToList());
            cbxPDFOutputDir.Text = xmlHerculesPrt.PDFOutput.OutputDir;
            cbxPDFPaperSize.Text = xmlHerculesPrt.PDFOutput.PageSize;

            ReplaceComboBoxItems(cbxPDFFileTemplate, xmlHerculesPrt.PDFOutput.OutputFileTemplatePicks.ToList());
            cbxPDFFileTemplate.Text = xmlHerculesPrt.PDFOutput.OutputFileTemplate;

            ReplaceComboBoxItems(cbxHTMLOutputDir, xmlHerculesPrt.HTMLOutput.OutputDirPicks.ToList());
            cbxHTMLOutputDir.Text = xmlHerculesPrt.HTMLOutput.OutputDir;

            ReplaceComboBoxItems(cbxHTMLFileTemplate, xmlHerculesPrt.HTMLOutput.OutputFileTemplatePicks.ToList());
            cbxHTMLFileTemplate.Text = xmlHerculesPrt.HTMLOutput.OutputFileTemplate;

            dgvBOJQualificationInformation.Rows.Clear();
            UpdateQualificationsDataGridView(dgvBOJQualificationInformation, xmlHerculesPrt.CustomizationData.BOJCustomization.BOJQualifications.Qualifications);
            dgvBOJFields.Rows.Clear();
            UpdateFieldDataGridView(dgvBOJFields, xmlHerculesPrt.CustomizationData.BOJCustomization.BOJFields.Fields);

            dgvEOJQualificationInformation.Rows.Clear();
            UpdateQualificationsDataGridView(dgvEOJQualificationInformation, xmlHerculesPrt.CustomizationData.EOJCustomization.EOJQualifications.Qualifications);
            dgvEOJFields.Rows.Clear();
            UpdateFieldDataGridView(dgvEOJFields, xmlHerculesPrt.CustomizationData.EOJCustomization.EOJFields.Fields);

            GetBOJQualifications();
            GetEOJQualifications();

            xmlHerculesPrt.IsDirty = false;
            dgvChanged = false;
        }

        private void SaveConfiguration()
        {
            xmlConfiguration.window.main.State = WindowState.ToString();
            switch (WindowState)
            {
                case FormWindowState.Minimized:
                    break;
                case FormWindowState.Maximized:
                    break;
                default:
                    xmlConfiguration.window.main.Left = Left;
                    xmlConfiguration.window.main.Top = Top;
                    xmlConfiguration.window.main.Width = Width;
                    xmlConfiguration.window.main.Height = Height;
                    break;
            }

            if (xmlHerculesPrt.IsDirty)
            {
                xmlHerculesPrt.Save(cbxPrinterDefinitionFile.Text);
            }

            xmlConfiguration.Save(XMLConfiguration.GetSaveFileName());
        }

        private void UpdatePrinterDefinitions()
        {
            UpdateCfgBOJQualificationData();
            UpdateCfgBOJFieldData();
            UpdateCfgEOJQualificationData();
            UpdateCfgEOJFieldData();
        }

        private void UpdateCfgBOJQualificationData()
        {
            List<Qualification> qualifications = new List<Qualification>();

            foreach (DataGridViewRow item in dgvBOJQualificationInformation.Rows)
            {
                Qualification qual = new Qualification();
                if (item.Cells[0].Value != null)
                {
                    qual.MustExist = item.Cells[0].Value.ToString();
                    if (item.Cells[1].Value != null)
                    {
                        qual.Line = Convert.ToInt32(item.Cells[1].Value.ToString());
                    }
                    else
                    {
                        qual.Line = 0;
                    }
                    if (item.Cells[2].Value != null)
                    {
                        qual.Column = Convert.ToInt32(item.Cells[2].Value.ToString());
                    }
                    else
                    {
                        qual.Column = 0;
                    }
                    if (item.Cells[3].Value != null)
                    {
                        qual.Value = item.Cells[3].Value.ToString();
                    }
                    else
                    {
                        qual.Value = "";
                    }
                    qualifications.Add(qual);
                }
            }
            xmlHerculesPrt.CustomizationData.BOJCustomization.BOJQualifications.Qualifications = qualifications;
        }

        private void UpdateCfgBOJFieldData()
        {
            List<Field> fields = new List<Field>();

            foreach (DataGridViewRow item in dgvBOJFields.Rows)
            {
                Field field = new Field();
                if (item.Cells[0].Value != null && (string)item.Cells[0].Value != "")
                {
                    field.Name = item.Cells[0].Value.ToString();
                    if (item.Cells[1].Value != null)
                    {
                        field.Line = Convert.ToInt32(item.Cells[1].Value.ToString());
                    }
                    else
                    {
                        field.Line = 0;
                    }
                    if (item.Cells[2].Value != null)
                    {
                        field.Column = Convert.ToInt32(item.Cells[2].Value.ToString());
                    }
                    else
                    {
                        field.Column = 0;
                    }
                    if (item.Cells[3].Value != null)
                    {
                        field.Width = Convert.ToInt32(item.Cells[3].Value.ToString());
                    }
                    else
                    {
                        field.Width = 0;
                    }
                    if (item.Cells[4].Value != null)
                    {
                        field.DefaultValue = item.Cells[4].Value.ToString();
                    }
                    else
                    {
                        field.DefaultValue = "";
                    }
                    fields.Add(field);
                }
            }
            xmlHerculesPrt.CustomizationData.BOJCustomization.BOJFields.Fields = fields;
        }

        private void UpdateCfgEOJQualificationData()
        {
            List<Qualification> qualifications = new List<Qualification>();

            foreach (DataGridViewRow item in dgvEOJQualificationInformation.Rows)
            {
                Qualification qual = new Qualification();
                if (item.Cells[0].Value != null)
                {
                    qual.MustExist = item.Cells[0].Value.ToString();
                    if (item.Cells[1].Value != null)
                    {
                        qual.Line = Convert.ToInt32(item.Cells[1].Value.ToString());
                    }
                    else
                    {
                        qual.Line = 0;
                    }
                    if (item.Cells[2].Value != null)
                    {
                        qual.Column = Convert.ToInt32(item.Cells[2].Value.ToString());
                    }
                    else
                    {
                        qual.Column = 0;
                    }
                    if (item.Cells[3].Value != null)
                    {
                        qual.Value = item.Cells[3].Value.ToString();
                    }
                    else
                    {
                        qual.Value = "";
                    }
                    qualifications.Add(qual);
                }
            }
            xmlHerculesPrt.CustomizationData.EOJCustomization.EOJQualifications.Qualifications = qualifications;
        }

        private void UpdateCfgEOJFieldData()
        {
            List<Field> fields = new List<Field>();

            foreach (DataGridViewRow item in dgvEOJFields.Rows)
            {
                Field field = new Field();
                if (item.Cells[0].Value != null && (string)item.Cells[0].Value != "")
                {
                    field.Name = item.Cells[0].Value.ToString();
                    if (item.Cells[1].Value != null)
                    {
                        field.Line = Convert.ToInt32(item.Cells[1].Value.ToString());
                    }
                    else
                    {
                        field.Line = 0;
                    }
                    if (item.Cells[2].Value != null)
                    {
                        field.Column = Convert.ToInt32(item.Cells[2].Value.ToString());
                    }
                    else
                    {
                        field.Column = 0;
                    }
                    if (item.Cells[3].Value != null)
                    {
                        field.Width = Convert.ToInt32(item.Cells[3].Value.ToString());
                    }
                    else
                    {
                        field.Width = 0;
                    }
                    if (item.Cells[4].Value != null)
                    {
                        field.DefaultValue = item.Cells[4].Value.ToString();
                    }
                    else
                    {
                        field.DefaultValue = "";
                    }
                    fields.Add(field);
                }
            }
            xmlHerculesPrt.CustomizationData.EOJCustomization.EOJFields.Fields = fields;
        }
        #endregion

        private void UpdateQualificationsDataGridView(DataGridView dgv, List<Qualification> quals)
       {
            foreach (var data in quals)
            {
                if (data.Line != 0)
                {
                    Object[] cells = new Object[4];
                    cells[0] = data.MustExist;
                    cells[1] = data.Line;
                    cells[2] = data.Column;
                    cells[3] = data.Value;
                    dgv.Rows.Add(cells);
                }
            }
        }
        private void UpdateFieldDataGridView(DataGridView dgv, List<Field> datas)
        {
            foreach (var data in datas)
            {
                if (data.Name != "")
                {
                    Object[] cells = new Object[5];
                    cells[0] = data.Name;
                    cells[1] = data.Line;
                    cells[2] = data.Column;
                    cells[3] = data.Width;
                    cells[4] = data.DefaultValue;
                    dgv.Rows.Add(cells);
                }
            }
        }

        private void ReplaceComboBoxItems(ComboBox cBox, List<string> items)
        {
            foreach (var item in items)
            {
                cBox.Items.Add(item);
            }
        }
        private List<Pick> GetComboBoxItems(ComboBox cBox)
        {
            List<Pick> temp = new List<Pick>();

            if (cBox.Items.Count > 0)
            {
                for (int i = 0; i < cBox.Items.Count; i++)
                {
                    temp.Add(new Pick(cBox.Items[i].ToString()));
                }
            }
            else
            {
                if (!(cBox.Text == ""))
                {
                    temp.Add(new Pick(cBox.Text));
                }
            }

            return temp;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Disconnect")
            {
                if (!(packetFile == null))
                {
                    packetFile.Flush();
                    packetFile.Close();
                    packetFile.Dispose();
                    packetFile = null;
                }

                _herculesConnection.Disconnect();
                slConnectionStatus.Text = "Disconnected from " + txtHostID.Text;
                btnConnect.Text = "Connect";
                return;
            }

            if (ckbDumpPackets.Checked)
            {
                if (cbDumpPacketsFile.Text == "")
                {
                    MessageBox.Show("You must select a Dump Packets File before connecting to device.");
                    return;
                }

                packetFile = new FileStream(cbDumpPacketsFile.Text, FileMode.OpenOrCreate, FileAccess.Write);
            }

            if (txtHostID.Text.Trim() == "")
            {
                String errMsg = "Please enter a Host ID.";
                DialogResult dr = MessageBox.Show(errMsg, "Invalid Host ID", MessageBoxButtons.OK);
                return;
            }

            if (txtPort.Text.Trim() == "")
            {
                String errMsg = "Please enter a port number.";
                DialogResult dr = MessageBox.Show(errMsg, "Invalid port number", MessageBoxButtons.OK);
                return;
            }

            if (!_herculesConnection.Connected)
            {
                if (ConnectToHercules())
                {
                    slConnectionStatus.Text = "Connected to " + txtHostID.Text + ":" + txtPort.Text;
                    btnConnect.Text = "Disconnect";
                }
            }
        }

        private Boolean ConnectToHercules()
        {
            if (!_herculesConnection.Connect(txtHostID.Text, Convert.ToInt32(txtPort.Text), _invokeAction))
            {
                String errMsg = "Connection failed: " + _herculesConnection.ErrorMessage + "\n\nDo you wish to continue?";
                DialogResult dr = MessageBox.Show(errMsg, "Connection failure", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }
            return _herculesConnection.Connected;
        }

        private void AppendOutput(String message)
        {
            if (rtbDiagnosticOutput.Text.Length > 0)
            {
                rtbDiagnosticOutput.AppendText(Environment.NewLine);
            }

            rtbDiagnosticOutput.AppendText(message);
            rtbDiagnosticOutput.ScrollToCaret();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrtMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xmlHerculesPrt.IsDirty || xmlConfiguration.IsDirty || dgvChanged)
            {
                DialogResult dr = DialogResult.Yes;
                String errMsg = "Settings have changed." + Environment.NewLine + Environment.NewLine + "Do you wish to save them?";
                dr = MessageBox.Show(errMsg, "Closing cleanup", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (dgvChanged)
                    {
                        UpdatePrinterDefinitions();
                    }
                    SaveConfiguration();
                }
            }
            e.Cancel = false;
        }

        private void tTimer_Tick(object sender, EventArgs e)
        {
            slTime.Text = DateTime.Now.ToString();
            if (_herculesConnection.Connected)
            {
                if (_herculesConnection.Stream.DataAvailable)
                {
                    if (rbRawProtocol.Checked)
                    {
                        ProcessRAWInput();
                    }
                    else
                    {
                        ProcessLPRInput();
                    }
                }
                else
                {
                    if (_pageBuff.Count > 0)
                    {
                        ProcessPageBuffer();
                    }
                }
            }
        }

        private Byte[] _lineBuf = new byte[256];
        private int _lineLen = 0;
        private int _lineCount = 1;
        private int _pageCount = 1;
        private List<List<string>> _document = new List<List<string>>();
        private List<string> _pageBuff = new List<string>();
        private bool _endOfReport = false;

        private void ProcessLPRInput()
        {
            if (!_herculesConnection.Stream.CanWrite)
            {
                AppendOutput("Cannot write to network stream, LPD/LPR processing terminated.");
                _herculesConnection.Disconnect();
                return;
            }

            byte[] b = new byte[1];
            _herculesConnection.Stream.Read(b, 0, 1);
            switch (b[0])
            {
                case 0:     // Positive ack (shouldn't happen)
                    AppendOutput("Positive ACK received, LPD/LPR processing terminated.");
                    _herculesConnection.Disconnect();
                    return;

                case 1:     // Start printing any waiting jobs
                    LPRStartPrinting(_herculesConnection.Stream);
                    break;
                case 2:     // Recieve a print job
                    LPRReceiveJob(_herculesConnection.Stream);
                    break;
                case 3:     // Send queue state, short
                    LPRQueueStateShort(_herculesConnection.Stream);
                    break;
                case 4:     // Send queue state, long
                    LPRQueueStateLong(_herculesConnection.Stream);
                    break;
                case 5:     // Remove jobs
                    LPRRemoveJobs(_herculesConnection.Stream);
                    break;
                default:
                    break;
            }
        }

        private void LPRStartPrinting(NetworkStream nws)
        { }

        private void LPRReceiveJob(NetworkStream nws)
        {
            byte[] b = new byte[1];
            byte[] ack = { 0, 0, 0, 0 };
            int bufSize = 0; // cfg.BufferSize;

            if (bufSize <= 0)
            {
                bufSize = 1024;
            }

            byte[] buffer = new byte[bufSize];

            #region Receive Job

            AppendOutput("Receive Job");
            string queueName = "";

            nws.Read(b, 0, 1);
            while (b[0] != (byte)'\n')
            {
                queueName += b[0];
                nws.Read(b, 0, 1);
            }

            nws.Write(ack, 0, 4);
            nws.Flush();

            // name of queue 
            AppendOutput("Queue: " + queueName);

            // TODO: create back-end behavior

            #endregion

            #region Receive Job subcommand
            // TODO: support multiple datafiles  
            // For now receive control (subcommand 2)
            // and data (subcommand 3) files
            for (int f = 0; f < 2; f++)
            {
                nws.Read(b, 0, 1);
                switch (b[0])
                {
                    case 2:
                        #region control file

                        string ctlCnt = "";
                        nws.Read(b, 0, 1);
                        while (b[0] != (byte)' ')
                        {
                            ctlCnt += (char)b[0];
                            nws.Read(b, 0, 1);
                        }
                        // contains number of bytes in control file
                        AppendOutput("Size: " + ctlCnt);
                        int ctlSize = Int32.Parse(ctlCnt);

                        string ctlFileName = "";
                        nws.Read(b, 0, 1);
                        while (b[0] != (byte)'\n')
                        {
                            ctlFileName += (char)b[0];
                            nws.Read(b, 0, 1);
                        }

                        nws.Write(ack, 0, 4);

                        AppendOutput("Name: " + ctlFileName);

                        // receive the file
                        //string ctlFileDir = cfg.LPDLPRWorkDir;
                        //if (!ctlFileDir.EndsWith("/"))
                        //{
                        //    ctlFileDir += "/";
                        //}
                        //StreamWriter ctlSW = new StreamWriter(ctlFileDir + ctlFileName);
                        //while (ctlSize > 0)
                        //{
                        //    int cnt = nws.Read(buffer, 0, bufSize);
                        //    ctlSize -= cnt;
                        //    if (ctlSize < 0) cnt--;  // strip last \0
                        //    ctlSW.Write(Encoding.ASCII.GetString(buffer).Substring(0, cnt));
                        //}
                        //ctlSW.Close();

                        nws.Write(ack, 0, 4);
                        nws.Flush();

                        #endregion control file
                        break;
                    case 3:
                        #region data file

                        string datCnt = "";
                        nws.Read(b, 0, 1);
                        while (b[0] != (byte)' ')
                        {
                            datCnt += (char)b[0];
                            nws.Read(b, 0, 1);
                        }
                        // contains number of bytes in data file
                        AppendOutput("Size: " + datCnt);
                        int datSize = Int32.Parse(datCnt);

                        string datFileName = "";
                        nws.Read(b, 0, 1);
                        while (b[0] != (byte)'\n')
                        {
                            datFileName += (char)b[0];
                            nws.Read(b, 0, 1);
                        }
                        nws.Write(ack, 0, 4);

                        AppendOutput("Name: " + datFileName);

                        // TODO: support 'no size specified'

                        // receive the file
                        //string datFileDir = cfg.LPDLPRWorkDir;
                        //if (!datFileDir.EndsWith("/"))
                        //{
                        //    datFileDir += "/";
                        //}
                        //StreamWriter sw = new StreamWriter(datFileDir + datFileName);
                        //while (datSize > 0)
                        //{
                        //    int cnt = nws.Read(buffer, 0, bufSize);
                        //    datSize -= cnt;
                        //    if (datSize < 0) cnt--;  // strip last \0
                        //    sw.Write(System.Text.Encoding.ASCII.GetString(buffer).Substring(0, cnt));
                        //}
                        //sw.Close();

                        nws.Write(ack, 0, 4);
                        nws.Flush();

                        #endregion data file
                        break;
                    default:
                        // TODO: handle other subcommands/error !
                        break;
                }
            }

            // TODO: backend process
            // TODO: Check for errors 
            #endregion
        }

        private void LPRQueueStateShort(NetworkStream nws)
        { }

        private void LPRQueueStateLong(NetworkStream nws)
        { }

        private void LPRRemoveJobs(NetworkStream nws)
        { }

        private void ProcessRAWInput()
        {
            int bufSize = 0; // cfg.BufferSize;

            if (bufSize <= 0)
            {
                bufSize = 1024;
            }
            Byte[] buffer = new byte[bufSize];
            int dataRead = _herculesConnection.Stream.Read(buffer, 0, bufSize);
            ProcessRAWInputBuffer(buffer, dataRead);
        }

        private void ProcessRAWInputBuffer(Byte[] buf, Int32 size)
        {
            string strOut;
            string line;

            if (ckbDumpPackets.Checked)
            {
                packetFile.Write(buf, 0, size);
            }

            if (ckbVerboseLogging.Checked)
            {
                strOut = gbl.Hex_Dump_Asis(buf, size, 32);
                AppendOutput(strOut);
            }
            
            if (!(ckbTXTOutput.Checked || ckbRTFOutput.Checked || ckbPDFOutput.Checked || ckbHTMLOutput.Checked))
            {
                return;
            }

            for (int i = 0; i < size; i++)
            {
                switch (buf[i])
                {
                    case 0x0a:
                        if (_lineLen == 0)
                        {
                            if (_lineCount == 0)
                            { }
                        }
                        line = gbl.ByteBufferToString(_lineBuf, _lineLen);
                        _pageBuff.Add(line);
                        if (ckbDisplayInput.Checked)
                        {
                            strOut = String.Format(" Line {0,3} Page {1,4}: ", _lineCount, _pageCount);
                            strOut = strOut + line;
                            AppendOutput(strOut);
                        }
                        _lineBuf = new byte[256];
                        _lineLen = 0;
                        _lineCount++;
                        break;

                    case 0x0c:
                        line = gbl.ByteBufferToString(_lineBuf, _lineLen);
                        _pageBuff.Add(line);
                        if (ckbDisplayInput.Checked)
                        {
                            strOut = String.Format(" Line {0,3} Page {1,4}: ", _lineCount, _pageCount);
                            strOut = strOut + line;
                            AppendOutput(strOut);
                        }
                        ProcessPageBuffer();
                        _lineBuf = new byte[256];
                        _lineLen = 0;
                        _lineCount = 1;
                        _pageCount++;
                        break;

                    default:
                        if ((buf[i] > 0x1f) && (buf[i] < 0x7f))
                        {
                            _lineBuf[_lineLen++] = buf[i];
                        }
                        break;
                }
            }
        }

        private void ProcessPageBuffer()
        {
            if (BOJSeparator(_pageBuff))
            {
                GetBOJSeparatorFields(_pageBuff);
            }
            if (EOJSeparator(_pageBuff))
            {
                GetEOJSeparatorFields(_pageBuff);
            }

            SavePageBuffer(_pageBuff);

            if (_endOfReport)
            {
                if (ckbTXTOutput.Checked)
                {
                    txtOut.ProcessReport(_document, BOJFieldValues, EOJFieldValues);
                }

                if (ckbRTFOutput.Checked)
                {
                    rtfOut.ProcessReport(_document, BOJFieldValues, EOJFieldValues);
                }

                if (ckbPDFOutput.Checked)
                {
                    pdfOut.ProcessReport(_document, BOJFieldValues, EOJFieldValues);
                }

                if (ckbHTMLOutput.Checked)
                {
                    htmlOut.ProcessReport(_document, BOJFieldValues, EOJFieldValues);
                }

                _endOfReport = false;
                _document = new List<List<string>>();
            }
            _pageBuff = new List<string>();
        }

        private bool BOJSeparator(List<string> pageBuff)
        {
            if (BOJQualifications.Count > 0)
            {
                foreach (var qual in BOJQualifications)
                {
                    if (qual.mustExist)
                    {
                        int curLine = Convert.ToInt32(qual.line);
                        if (curLine < pageBuff.Count)
                        {
                            int col = Convert.ToInt32(qual.column);
                            int count = qual.values.Count;
                            foreach (string item in qual.values)
                            {
                                int len = item.Length;
                                if (pageBuff[curLine - 1].PadRight(col + len).Substring(col - 1, len) == item)
                                {
                                    return true;
                                }
                            }
                            return false;
                        }
                        else { return false; }
                    }
                }
                return true;
            }
            return false;
        }

        private void GetBOJSeparatorFields(List<string> pageBuff)
        {
            BOJFieldValues = new List<CustomFieldValue>();

            foreach (DataGridViewRow item in dgvBOJFields.Rows)
            {
                CustomFieldValue field = new CustomFieldValue();
                if (item.Cells[0].Value != null && (string)item.Cells[0].Value != "")
                {
                    int curLine = Convert.ToInt32(item.Cells[1].Value.ToString());
                    if (curLine < pageBuff.Count)
                    {
                        field.fieldName = item.Cells[0].Value.ToString();
                        int col = Convert.ToInt32(item.Cells[2].Value.ToString());
                        int len = Convert.ToInt32(item.Cells[3].Value.ToString());
                        string defaultValue = item.Cells[4].Value.ToString();
                        string value = pageBuff[curLine - 1].Substring(col - 1, len).Trim();
                        if (value == "")
                        {
                            value = defaultValue;
                        }
                        field.fieldValue = value;
                        BOJFieldValues.Add(field);
                    }
                }
            }
        }

        private void GetBOJQualifications()
        {
            BOJQualifications = new List<CustomQualificationData>();

            foreach (DataGridViewRow item in dgvBOJQualificationInformation.Rows)
            {
                if (item.Cells[0].Value != null && item.Cells[1].Value != null &&
                    item.Cells[2].Value != null && item.Cells[3].Value != null)
                {
                    bool mustExist = item.Cells[0].Value.ToString().ToBool();
                    int line = Convert.ToInt32(item.Cells[1].Value.ToString());
                    int col = Convert.ToInt32(item.Cells[2].Value.ToString());
                    string value = item.Cells[3].Value.ToString();
                    int i = BOJQualifications.FindIndex(x => x.line == line && x.column == col);
                    if (i > -1)
                    {
                        BOJQualifications[i].values.Add(value);
                    }
                    else
                    {
                        CustomQualificationData data = new CustomQualificationData();
                        data.mustExist = mustExist;
                        data.column = col;
                        data.line = line;
                        data.values = new List<string>();
                        data.values.Add(value);
                        BOJQualifications.Add(data);
                    }
                }
            }
        }

        private bool EOJSeparator(List<string> pageBuff)
        {
            if (EOJQualifications.Count > 0)
            {
                foreach (var qual in EOJQualifications)
                {
                    if (qual.mustExist)
                    {
                        int curLine = Convert.ToInt32(qual.line);
                        if (curLine < pageBuff.Count)
                        {
                            int col = Convert.ToInt32(qual.column);
                            int count = qual.values.Count;
                            int found = 0;
                            foreach (string item in qual.values)
                            {
                                int len = item.Length;
                                if (pageBuff[curLine - 1].PadRight(col + len).Substring(col - 1, len) == item)
                                {
                                    found++;
                                }
                            }
                            if (found == 0) { return false; }
                        }
                        else { return false; }
                    }
                }
                _endOfReport = true;
                return true;
            }
            return false;
        }

        private void GetEOJSeparatorFields(List<string> pageBuff)
        {
            EOJFieldValues = new List<CustomFieldValue>();

            foreach (DataGridViewRow item in dgvEOJFields.Rows)
            {
                CustomFieldValue field = new CustomFieldValue();
                if (item.Cells[0].Value != null && (string)item.Cells[0].Value != "")
                {
                    int curLine = Convert.ToInt32(item.Cells[1].Value.ToString());
                    if (curLine < pageBuff.Count)
                    {
                        field.fieldName = item.Cells[0].Value.ToString();
                        int col = Convert.ToInt32(item.Cells[2].Value.ToString());
                        int len = Convert.ToInt32(item.Cells[3].Value.ToString());
                        string defaultValue = item.Cells[4].Value.ToString();
                        string value = pageBuff[curLine - 1].Substring(col - 1, len).Trim();
                        if (value == "")
                        {
                            value = defaultValue;
                        }
                        field.fieldValue = value;
                        EOJFieldValues.Add(field);
                    }
                }
            }
        }

        private void GetEOJQualifications()
        {
            EOJQualifications = new List<CustomQualificationData>();

            foreach (DataGridViewRow item in dgvEOJQualificationInformation.Rows)
            {
                if (item.Cells[0].Value != null && item.Cells[1].Value != null &&
                    item.Cells[2].Value != null && item.Cells[3].Value != null)
                {
                    bool mustExist = item.Cells[0].Value.ToString().ToBool();
                    int line = Convert.ToInt32(item.Cells[1].Value.ToString());
                    int col = Convert.ToInt32(item.Cells[2].Value.ToString());
                    string value = item.Cells[3].Value.ToString();
                    int i = EOJQualifications.FindIndex(x => x.line == line && x.column == col);
                    if (i > -1)
                    {
                        EOJQualifications[i].values.Add(value);
                    }
                    else
                    {
                        CustomQualificationData data = new CustomQualificationData();
                        data.mustExist = mustExist;
                        data.column = col;
                        data.line = line;
                        data.values = new List<string>();
                        data.values.Add(value);
                        EOJQualifications.Add(data);
                    }
                }
            }
        }

        private void SavePageBuffer(List<string> pageBuff)
        {
            _document.Add(pageBuff);
        }

        private void ckbDumpPackets_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDumpPackets.Checked)
            {
                cbDumpPacketsFile.Enabled = true;
                btnDumpPacketsFile.Enabled = true;
            }
            else
            {
                cbDumpPacketsFile.Enabled = false;
                btnDumpPacketsFile.Enabled = false;
            }
        }

        private void txtHostID_TextChanged(object sender, EventArgs e)
        {
            if (xmlHerculesPrt.Connection.HerculesIP != txtHostID.Text)
            {
                xmlHerculesPrt.Connection.HerculesIP = txtHostID.Text;
            }
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            if (rbRawProtocol.Checked)
            {
                if (xmlHerculesPrt.Connection.RAWHostPort != Convert.ToInt32(txtPort.Text))
                {
                    xmlHerculesPrt.Connection.RAWHostPort = Convert.ToInt32(txtPort.Text);
                }
            }
            if (rbLPDProtocol.Checked)
            {
                if (xmlHerculesPrt.Connection.LPDLPRHostPort != Convert.ToInt32(txtPort.Text))
                {
                    xmlHerculesPrt.Connection.LPDLPRHostPort = Convert.ToInt32(txtPort.Text);
                }
            }
        }

        private void txtBufferSize_TextChanged(object sender, EventArgs e)
        {
            if (xmlHerculesPrt.Connection.BufferSize != Convert.ToInt32(txtBufferSize.Text))
            {
                xmlHerculesPrt.Connection.BufferSize = Convert.ToInt32(txtBufferSize.Text);
            }
        }

        private void dgvRowChanged(object sender, DataGridViewRowEventArgs e)
        {
            dgvChanged = true;

            GetBOJQualifications();
            GetEOJQualifications();
        }

        private void dgvCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgvChanged = true;

            GetBOJQualifications();
            GetEOJQualifications();
        }
 
        private void cbxFileTemplate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboBox cBox = (ComboBox)sender;
                string temp = cBox.Name.Substring(3);
                temp = temp.Replace("FileTemplate", "");

                switch (temp)
                {
                    case "TXT":
                        if (!Find(cbxTXTFileTemplate.Items, cbxTXTFileTemplate.Text))
                        {
                            cbxTXTFileTemplate.Items.Add(cbxTXTFileTemplate.Text); // Add
                        }
                        break;
                    case "RTF":
                        if (!Find(cbxRTFFileTemplate.Items, cbxRTFFileTemplate.Text))
                        {
                            cbxRTFFileTemplate.Items.Add(cbxRTFFileTemplate.Text); // Add
                        }
                        break;
                    case "PDF":
                        if (!Find(cbxPDFFileTemplate.Items, cbxPDFFileTemplate.Text))
                        {
                            cbxPDFFileTemplate.Items.Add(cbxPDFFileTemplate.Text); // Add
                        }
                        break;
                    case "HTML":
                        if (!Find(cbxHTMLFileTemplate.Items, cbxHTMLFileTemplate.Text))
                        {
                            cbxHTMLFileTemplate.Items.Add(cbxHTMLFileTemplate.Text); // Add
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void cbxOutputDir_KeyUp(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                ComboBox cBox = (ComboBox)sender;
                string temp = cBox.Name.Substring(3);
                temp = temp.Replace("OutputDir", "");

                switch (temp)
                {
                    case "TXT":
                        if (!Find(cbxTXTOutputDir.Items, cbxTXTOutputDir.Text))
                        {
                            cbxTXTOutputDir.Items.Add(cbxTXTOutputDir.Text); // Add
                        }
                        break;
                    case "RTF":
                        if (!Find(cbxRTFOutputDir.Items, cbxRTFOutputDir.Text))
                        {
                            cbxRTFOutputDir.Items.Add(cbxRTFOutputDir.Text); // Add
                        }
                        break;
                    case "PDF":
                        if (!Find(cbxPDFOutputDir.Items, cbxPDFOutputDir.Text))
                        {
                            cbxPDFOutputDir.Items.Add(cbxPDFOutputDir.Text); // Add
                        }
                        break;
                    case "HTML":
                        if (!Find(cbxHTMLOutputDir.Items, cbxHTMLOutputDir.Text))
                        {
                            cbxHTMLOutputDir.Items.Add(cbxHTMLOutputDir.Text); // Add
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private bool Find(ComboBox.ObjectCollection items, string text)
        {
            foreach (var item in items)
            {
                if (item.ToString() == text)
                {
                    return true;
                }
            }
            return false;
        }

        private void OpenPrinterDefinitionFile()
        {
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FileName = cbxPrinterDefinitionFile.Text;
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                cbxPrinterDefinitionFile.Text = openFileDialog1.FileName;
                cbxPrinterDefinitionFile.Items.Add(openFileDialog1.FileName);
                xmlConfiguration.definitionFiles.selectedFile.Text = openFileDialog1.FileName;
                xmlConfiguration.definitionFiles.filePicks.Add(new FileName(openFileDialog1.FileName));
                LoadPrinterDefinition();
            }
        }

        private void btnPrinterDefinitionFile_Click(object sender, EventArgs e)
        {
            OpenPrinterDefinitionFile();
        }

        private void mnuOpenPrinterDefintionFile_Click(object sender, EventArgs e)
        {
            OpenPrinterDefinitionFile();
        }

        private void mnuSavePrinterDefinitionFile_Click(object sender, EventArgs e)
        {
            if (xmlConfiguration.definitionFiles.selectedFile.Text == "")
            {
                saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.FileName = cbxPrinterDefinitionFile.Text;
                DialogResult dr = saveFileDialog1.ShowDialog();

                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                cbxPrinterDefinitionFile.Text = saveFileDialog1.FileName;
                cbxPrinterDefinitionFile.Items.Add(saveFileDialog1.FileName);
                xmlConfiguration.definitionFiles.selectedFile.Text = saveFileDialog1.FileName;
                xmlConfiguration.definitionFiles.filePicks.Add(new FileName(saveFileDialog1.FileName));
            }
            UpdatePrinterDefinitions();
            //cfg.SavePrinterDefinitions(cbxPrinterDefinitionFile.Text);
        }

        private void mnuSavePrinterDefinitionFileAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FileName = cbxPrinterDefinitionFile.Text;
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            cbxPrinterDefinitionFile.Text = saveFileDialog1.FileName;
            cbxPrinterDefinitionFile.Items.Add(saveFileDialog1.FileName);
            xmlConfiguration.definitionFiles.selectedFile.Text = openFileDialog1.FileName;
            xmlConfiguration.definitionFiles.filePicks.Add(new FileName(openFileDialog1.FileName));
            UpdatePrinterDefinitions();
            xmlHerculesPrt.Save(cbxPrinterDefinitionFile.Text);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPrinterDefinitionFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Find(cbxPrinterDefinitionFile.Items, cbxPrinterDefinitionFile.Text))
                {
                    cbxPrinterDefinitionFile.Items.Add(cbxPrinterDefinitionFile.Text); // Add
                }
            }
        }

        private string GetOutputDir()
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }

            return null;
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string temp = btn.Name.Substring(3);
            temp = temp.Replace("OutputDir", "");

            string outDir = GetOutputDir();

            if (!(outDir == null))
            {
                switch (temp)
                {
                    case "TXT":
                        if (!Find(cbxTXTOutputDir.Items, folderBrowserDialog1.SelectedPath))
                        {
                            cbxTXTOutputDir.Text = folderBrowserDialog1.SelectedPath;
                            cbxTXTOutputDir.Items.Add(folderBrowserDialog1.SelectedPath); // Add
                        }
                        break;
                    case "RTF":
                        if (!Find(cbxRTFOutputDir.Items, folderBrowserDialog1.SelectedPath))
                        {
                            cbxRTFOutputDir.Text = folderBrowserDialog1.SelectedPath;
                            cbxRTFOutputDir.Items.Add(folderBrowserDialog1.SelectedPath); // Add
                        }
                        break;
                    case "PDF":
                        if (!Find(cbxPDFOutputDir.Items, folderBrowserDialog1.SelectedPath))
                        {
                            cbxPDFOutputDir.Text = folderBrowserDialog1.SelectedPath;
                            cbxPDFOutputDir.Items.Add(folderBrowserDialog1.SelectedPath); // Add
                        }
                        break;
                    case "HTML":
                        if (!Find(cbxHTMLOutputDir.Items, folderBrowserDialog1.SelectedPath))
                        {
                            cbxHTMLOutputDir.Text = folderBrowserDialog1.SelectedPath;
                            cbxHTMLOutputDir.Items.Add(folderBrowserDialog1.SelectedPath); // Add
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnDumpPacketsFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RAW files (*.raw)|*.raw|All files (*.*)|*.*";
            saveFileDialog1.FileName = cbDumpPacketsFile.Text;
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            cbDumpPacketsFile.Text = saveFileDialog1.FileName;
            cbDumpPacketsFile.Items.Add(saveFileDialog1.FileName);
        }

        private void cbxPrinterDefinitionFile_TextChanged(object sender, EventArgs e)
        {
            xmlConfiguration.definitionFiles.selectedFile.Text = cbxPrinterDefinitionFile.Text;
            LoadPrinterDefinition();
        }

        private void cbxOutputDir_TextChanged(object sender, EventArgs e)
        {
            if (formLoading) return;

            ComboBox cBox = (ComboBox)sender;
            string temp = cBox.Name.Substring(3);
            temp = temp.Replace("OutputDir", "");

            switch (temp)
            {
                case "TXT":
                    xmlHerculesPrt.TXTOutput.OutputDir = cbxTXTOutputDir.Text;
                    xmlHerculesPrt.TXTOutput.OutputDirPicks.Picks.Clear();
                    xmlHerculesPrt.TXTOutput.OutputDirPicks.Picks.AddRange(GetComboBoxItems(cbxTXTOutputDir));
                    break;
                case "RTF":
                    xmlHerculesPrt.RTFOutput.OutputDir = cbxRTFOutputDir.Text;
                    xmlHerculesPrt.RTFOutput.OutputDirPicks.Picks.Clear();
                    xmlHerculesPrt.RTFOutput.OutputDirPicks.Picks.AddRange(GetComboBoxItems(cbxRTFOutputDir));
                    break;
                case "PDF":
                    xmlHerculesPrt.PDFOutput.OutputDir = cbxPDFOutputDir.Text;
                    xmlHerculesPrt.PDFOutput.OutputDirPicks.Picks.Clear();
                    xmlHerculesPrt.PDFOutput.OutputDirPicks.Picks.AddRange(GetComboBoxItems(cbxPDFOutputDir));
                    break;
                case "HTML":
                    xmlHerculesPrt.HTMLOutput.OutputDir = cbxHTMLOutputDir.Text;
                    xmlHerculesPrt.HTMLOutput.OutputDirPicks.Picks.Clear();
                    xmlHerculesPrt.HTMLOutput.OutputDirPicks.Picks.AddRange(GetComboBoxItems(cbxHTMLOutputDir));
                    break;
                default:
                    break;
            }
        }

        private void cbxFileTemplate_TextChanged(object sender, EventArgs e)
        {
            if (formLoading) return;

            ComboBox cBox = (ComboBox)sender;
            string temp = cBox.Name.Substring(3);
            temp = temp.Replace("FileTemplate", "");

            switch (temp)
            {
                case "TXT":
                    xmlHerculesPrt.TXTOutput.OutputFileTemplate = cbxTXTFileTemplate.Text;
                    xmlHerculesPrt.TXTOutput.OutputFileTemplatePicks.Picks.Clear();
                    xmlHerculesPrt.TXTOutput.OutputFileTemplatePicks.Picks.AddRange(GetComboBoxItems(cbxTXTFileTemplate));
                    break;
                case "RTF":
                    xmlHerculesPrt.RTFOutput.OutputFileTemplate = cbxRTFFileTemplate.Text;
                    xmlHerculesPrt.RTFOutput.OutputFileTemplatePicks.Picks.Clear();
                    xmlHerculesPrt.RTFOutput.OutputFileTemplatePicks.Picks.AddRange(GetComboBoxItems(cbxRTFFileTemplate));
                    break;
                case "PDF":
                    xmlHerculesPrt.PDFOutput.OutputFileTemplate = cbxPDFFileTemplate.Text;
                    xmlHerculesPrt.PDFOutput.OutputFileTemplatePicks.Picks.Clear();
                    xmlHerculesPrt.PDFOutput.OutputFileTemplatePicks.Picks.AddRange(GetComboBoxItems(cbxPDFFileTemplate));
                    break;
                case "HTML":
                    xmlHerculesPrt.HTMLOutput.OutputFileTemplate = cbxHTMLFileTemplate.Text;
                    xmlHerculesPrt.HTMLOutput.OutputFileTemplatePicks.Picks.Clear();
                    xmlHerculesPrt.HTMLOutput.OutputFileTemplatePicks.Picks.AddRange(GetComboBoxItems(cbxHTMLFileTemplate));
                    break;
                default:
                    break;
            }
        }

        private void mnuDebugTestLogic_Click(object sender, EventArgs e)
        {
            mnuDebugTestLogic.Checked = !mnuDebugTestLogic.Checked;
            RowStyle style = tableLayoutPanel2.RowStyles[0];

            if (mnuDebugTestLogic.Checked)
            {
                gbxDeviceConnection.Enabled = false;
                gbxTestLogic.Visible = true;
                btnConnect.Enabled = false;
                btnConnect.Text = "Connect";
                btnConnect.Enabled = false;
                btnConnect.Visible = false;
                if (_herculesConnection.Connected)
                {
                    _herculesConnection.Disconnect();
                }
                style.Height = 0f;
            }
            else
            {
                gbxDeviceConnection.Enabled = true;
                gbxTestLogic.Visible = false;
                btnConnect.Visible = true;
                btnConnect.Enabled = true;
                style.Height = 112f;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (ckbDumpPackets.Checked)
            {
                MessageBox.Show("Cannot dump packets while reading from packet file.");
                return;
            }

            if (!(cbxTestPacketsFile.Text == ""))
            {
                packetFile = new FileStream(cbxTestPacketsFile.Text, FileMode.Open, FileAccess.Read);

                int bufSize = xmlHerculesPrt.Connection.BufferSize;

                if (bufSize <= 0)
                {
                    bufSize = 1024;
                }
                Byte[] buffer = new byte[bufSize];

                int dataRead = bufSize;

                while (dataRead > 0)
                {
                    dataRead = packetFile.Read(buffer, 0, bufSize);
                    if (dataRead > 0) { ProcessRAWInputBuffer(buffer, dataRead); }
                }

                if (_pageBuff.Count > 0)
                {
                    ProcessPageBuffer();
                }

                packetFile.Close();
                packetFile.Dispose();
            }
        }

        private void btnTestPacketsFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RAW files (*.raw)|*.raw|All files (*.*)|*.*";
            openFileDialog1.FileName = cbxTestPacketsFile.Text;
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                cbxTestPacketsFile.Text = openFileDialog1.FileName;
                cbxTestPacketsFile.Items.Add(openFileDialog1.FileName);
            }
        }

        private void ckbDisplayPackets_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.Diagnostics.DumpPacketsChecked = ckbVerboseLogging.Checked.ToString();
        }

        private void ckbDisplayInput_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDisplayInput.Checked)
            {
                ckbDumpPackets.Enabled = false;
            }
            else
            {
                ckbDumpPackets.Enabled = true;
            }
        }

        private void ckbDisplayStatistics_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.Diagnostics.DisplayStatisticsChecked = ckbDisplayStatistics.Checked.ToString();
        }

        private void ckbProtocolLogging_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.Diagnostics.ProtocolLoggingChecked = ckbProtocolLogging.Checked.ToString();
        }

        private void ckbPrintBOJSeparators_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.CustomizationData.BOJCustomization.BOJPrintBanners = ckbPrintBOJSeparators.Checked.ToString();
        }

        private void ckbPrintEOJSeparators_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.CustomizationData.EOJCustomization.EOJPrintBanners = ckbPrintEOJSeparators.Checked.ToString();
        }

        private void ckbHTMLHeader_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.HTMLOutput.HTMLHeaderChecked = ckbHTMLHeader.Checked.ToString();
        }

        private void cbxPDFPaperSize_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbxPDFPaperSize.Text)
            {
                case "Fanfold":
                    lblPaperDimensions.Text = "14 7/8 x 11";
                    break;
                case "Letter":
                    lblPaperDimensions.Text = "11 x 8 1/2";
                    break;
                default:
                    break;
            }

            xmlHerculesPrt.PDFOutput.PageSize = cbxPDFPaperSize.Text;
        }

        private void PrtMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void rbRawProtocol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRawProtocol.Checked)
            {
                xmlHerculesPrt.Connection.Protocol = "RAW";
                txtPort.Text = xmlHerculesPrt.Connection.RAWHostPort.ToString();
                SetProcessingPages();
            }
        }

        private void rbLPDProtocol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLPDProtocol.Checked)
            {
                xmlHerculesPrt.Connection.Protocol = "LPDLPR";
                txtPort.Text = xmlHerculesPrt.Connection.LPDLPRHostPort.ToString();
                SetProcessingPages();
            }
        }

        private void SetProcessingPages()
        {
            if (rbRawProtocol.Checked)
            {
                hiddenPages.Add(tpLPDLPRInfo);
                tcMainTabs.TabPages.Remove(tpLPDLPRInfo);

                tcMainTabs.TabPages.Insert(1, tpBOJInfo);
                tcMainTabs.TabPages.Insert(2, tpEOJInfo);
                hiddenPages.Remove(tpBOJInfo);
                hiddenPages.Remove(tpEOJInfo);
            }

            if (rbLPDProtocol.Checked)
            {
                hiddenPages.Add(tpBOJInfo);
                hiddenPages.Add(tpEOJInfo);
                tcMainTabs.TabPages.Remove(tpBOJInfo);
                tcMainTabs.TabPages.Remove(tpEOJInfo);

                tcMainTabs.TabPages.Insert(1, tpLPDLPRInfo);
                hiddenPages.Remove(tpLPDLPRInfo);
            }
        }

        private void ckbTXTOutput_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.CustomizationData.OutputToTXT = ckbTXTOutput.Checked.ToString();
            if (ckbTXTOutput.Checked)
            {
                // this page is always at this location
                int loc = 3;
                if (rbLPDProtocol.Checked) { loc--; } // unless we are using LPD/LPR protocol
                tcMainTabs.TabPages.Insert(loc, tpTXTOutput);
                hiddenPages.Remove(tpTXTOutput);
            }
            else
            {
                hiddenPages.Add(tpTXTOutput);
                tcMainTabs.TabPages.Remove(tpTXTOutput);
            }

        }

        private void ckbRTFOutput_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.CustomizationData.OutputToRTF = ckbRTFOutput.Checked.ToString();
            if (ckbRTFOutput.Checked)
            {
                // default to 3
                int loc = 3;
                int cLoc = 3;
                int pCount = tcMainTabs.TabPages.Count;
                if (rbLPDProtocol.Checked) { pCount++; } // adjust up if LPD/LPR protocol
                if (rbLPDProtocol.Checked) { cLoc--; }   // adjust down if LPD/LPR protocol
                switch (pCount)
                {
                    // possible combinations for case 5 are:
                    // TXT
                    // PDF
                    // HTML
                    // possible combinations for case 6 are:
                    // TXT, PDF
                    // TXT, HTML
                    // PDF, HTML
                    // possible combinations for case 7 are:
                    // TXT, PDF, HTML
                    case 5:
                    case 6:
                    case 7:
                        if (tcMainTabs.TabPages[cLoc].Name == "tpTXTOutput")
                        {
                            // we have TXT output, so it should be 4
                            loc = 4;
                        }
                        break;
                    default:
                        break;
                }
                if (rbLPDProtocol.Checked) { loc--; } // unless we are using LPD/LPR protocol
                tcMainTabs.TabPages.Insert(loc, tpRTFOutput);
                hiddenPages.Remove(tpRTFOutput);
            }
            else
            {
                hiddenPages.Add(tpRTFOutput);
                tcMainTabs.TabPages.Remove(tpRTFOutput);
            }
        }

        private void ckbPDFOutput_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.CustomizationData.OutputToPDF = ckbPDFOutput.Checked.ToString();
            if (ckbPDFOutput.Checked)
            {
                int loc = 3;
                int cLoc = 3;
                int pCount = tcMainTabs.TabPages.Count;
                if (rbLPDProtocol.Checked) { pCount++; } // adjust up if LPD/LPR protocol
                if (rbLPDProtocol.Checked) { cLoc--; }   // adjust down if LPD/LPR protocol
                switch (pCount)
                {
                    // possible combinations for case 5 are:
                    // TXT
                    // RTF
                    // HTML
                    // possible combinations for case 6 are:
                    // TXT, RTF
                    // TXT, HTML
                    // RTF, HTML
                    // possible combinations for case 7 are:
                    // TXT, RTF, HTML
                    case 5:
                        if ((tcMainTabs.TabPages[cLoc].Name == "tpTXTOutput") || (tcMainTabs.TabPages[cLoc].Name == "tpRTFOutput"))
                        {
                            // we have TXT or RTF output, so it should be 4
                            loc = 4;
                        }
                        break;
                    case 6:
                        loc = 5;
                        if (tcMainTabs.TabPages[cLoc + 1].Name == "tpHTMLOutput")
                        {
                            // we have HTML output, so it should be 4
                            loc = 4;
                        }
                        break;
                    case 7:
                        loc = 5;
                        break;
                    default:
                        break;
                }
                if (rbLPDProtocol.Checked) { loc--; } // unless we are using LPD/LPR protocol
                tcMainTabs.TabPages.Insert(loc, tpPDFOutput);
                hiddenPages.Remove(tpPDFOutput);
            }
            else
            {
                hiddenPages.Add(tpPDFOutput);
                tcMainTabs.TabPages.Remove(tpPDFOutput);
            }
        }

        private void ckbHTMLOutput_CheckedChanged(object sender, EventArgs e)
        {
            xmlHerculesPrt.CustomizationData.OutputToHTML = ckbHTMLOutput.Checked.ToString();
            if (ckbHTMLOutput.Checked)
            {
                int loc = 3;
                int cLoc = 3;
                int pCount = tcMainTabs.TabPages.Count;
                if (rbLPDProtocol.Checked) { pCount++; } // adjust up if LPD/LPR protocol
                if (rbLPDProtocol.Checked) { cLoc--; }   // adjust down if LPD/LPR protocol
                switch (pCount)
                {
                    // possible combinations for case 5 are:
                    // TXT
                    // RTF
                    // PDF
                    // possible combinations for case 6 are:
                    // TXT, RTF
                    // TXT, PDF
                    // RTF, PDF
                    // possible combinations for case 7 are:
                    // TXT, RTF, PDF
                    case 5:
                        loc = 4;
                        break;
                    case 6:
                        loc = 5;
                        break;
                    case 7:
                        loc = 6;
                        break;
                    default:
                        break;
                }
                if (rbLPDProtocol.Checked) { loc--; } // unless we are using LPD/LPR protocol
                tcMainTabs.TabPages.Insert(loc, tpHTMLOutput);
                hiddenPages.Remove(tpHTMLOutput);
            }
            else
            {
                hiddenPages.Add(tpHTMLOutput);
                tcMainTabs.TabPages.Remove(tpHTMLOutput);
            }
        }

        private void cbxLPDLPRWorkDir_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Find(cbxLPDLPRWorkDir.Items, cbxLPDLPRWorkDir.Text))
                {
                    cbxLPDLPRWorkDir.Items.Add(cbxLPDLPRWorkDir.Text); // Add
                }
            }
        }

        private void cbxLPDLPRWorkDir_TextChanged(object sender, EventArgs e)
        {
            if (formLoading) { return; }

            xmlHerculesPrt.LPDLPRProcessing.WorkDir = cbxLPDLPRWorkDir.Text;
            xmlHerculesPrt.LPDLPRProcessing.WorkDirPicks.Picks = GetComboBoxItems(cbxLPDLPRWorkDir);
        }

        private void btnLPDLPRWorkDir_Click(object sender, EventArgs e)
        {
            string outDir = GetOutputDir();

            if (!(outDir == null))
            {
                cbxLPDLPRWorkDir.Text = folderBrowserDialog1.SelectedPath;
                cbxLPDLPRWorkDir.Items.Add(folderBrowserDialog1.SelectedPath); // Add
            }
        }
    }
}


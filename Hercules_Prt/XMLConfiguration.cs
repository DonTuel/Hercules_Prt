using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Hercules_Prt
{
    #region configuration XML classes
    [XmlRoot(ElementName = "Configuration")]
    public class XMLConfiguration
    {
        [XmlElement(ElementName = "Window")]
        public Window window;
        [XmlElement(ElementName = "PrinterDefinitionFiles")]
        public PrinterDefinitionFiles definitionFiles;
        //[XmlArray(ElementName = "PrinterDefinitionFiles")]
        //[XmlArrayItem(ElementName = "SelectedFile", Type = typeof(SelectedFile))]
        //[XmlArrayItem(ElementName = "FileSelection", Type = typeof(FileSelection))]
        //public List<FileName> fileNames { get; set; }

        private bool _isDirty = false;

        public XMLConfiguration()
        {
            window = new Window();
            definitionFiles = new PrinterDefinitionFiles();
        }

        [XmlIgnore]
        public virtual bool IsDirty
        {
            get
            {
                if (window.main.IsDirty)
                //submitData.preJob.IsDirty || submitData.postJob.IsDirty || filesRecent.IsDirty ||
                //connection.IsDirty || diagnostics.IsDirty)
                {
                    _isDirty = true;
                }

                if (!_isDirty)
                {
                    //foreach (var item in replacementData)
                    //{
                    //    if (item.IsDirty)
                    //    {
                    //        _isDirty = true;
                    //        break;
                    //    }
                    //}
                }

                return _isDirty;
            }
            set
            {
                _isDirty = value;
                window.main.IsDirty = value;
                //printerDefinitions.IsDirty = value;
                //submitData.preJob.IsDirty = value;
                //submitData.postJob.IsDirty = value;
                //connection.IsDirty = value;
                //diagnostics.IsDirty = value;
                //foreach (var item in replacementData)
                //{
                //    item.IsDirty = value;
                //}
            }
        }

        public static XMLConfiguration Load(string path)
        {
            XMLConfiguration cfg;
            var serializer = new XmlSerializer(typeof(XMLConfiguration));
            try
            {
                if (File.Exists(path))
                {
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        cfg = serializer.Deserialize(stream) as XMLConfiguration;
                        cfg.IsDirty = false;
                        return cfg;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deserialize error");
            }
            cfg = new XMLConfiguration();
            return cfg;
        }

        public static string GetSaveFileName()
        {
            string sFileName;

            string commonAppDataPath = Application.CommonAppDataPath;
            //RegistryKey commonAppDataRegistry = Application.CommonAppDataRegistry;
            //string executablePath = Application.ExecutablePath;
            //string localUserAppDataPath = Application.LocalUserAppDataPath;
            //string startupPath = Application.StartupPath;
            //string userAppDataPath = Application.UserAppDataPath;
            //RegistryKey userAppDataRegistry = Application.UserAppDataRegistry;

            //string companyName = Application.CompanyName;
            string productName = Application.ProductName;
            string productVersion = Application.ProductVersion;

            sFileName = commonAppDataPath.Replace("dba ", "");
            sFileName = sFileName.Replace(productVersion, "");
            sFileName += productName + ".xml";

            return sFileName;
        }

        public void Save(string namepath)
        {
            char[] pSep = { '/', '\\' };
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(XMLConfiguration));
            if (namepath.LastIndexOfAny(pSep) >= 0)
            {
                string path = namepath.Substring(0, namepath.LastIndexOfAny(pSep));
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            using (var stream = new FileStream(namepath, FileMode.Create))
            {
                serializer.Serialize(stream, this, ns);
            }
        }
    }

    [XmlRoot(ElementName = "Window")]
    public class Window
    {
        [XmlElement(ElementName = "Main")]
        public Main main;

        public Window()
        {
            main = new Main();
        }
    }

    [XmlRoot(ElementName = "Main")]
    public class Main
    {
        private bool _isDirty = false;

        private int _Width;
        private int _Height;
        private int _Left;
        private int _Top;
        private string _State;

        public int Width
        {
            get { return _Width; }
            set { _Width = value; _isDirty = true; }
        }
        public int Height
        {
            get { return _Height; }
            set { _Height = value; _isDirty = true; }
        }
        public int Left
        {
            get { return _Left; }
            set { _Left = value; _isDirty = true; }
        }
        public int Top
        {
            get { return _Top; }
            set { _Top = value; _isDirty = true; }
        }
        public string State
        {
            get { return _State; }
            set { _State = value; _isDirty = true; }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }

        public Main()
        {
            _Width = 1160;
            _Height = 970;
            _Left = 560;
            _Top = 110;
            _State = "Normal";
            _isDirty = false;
        }
    }

    [XmlRoot(ElementName = "PrinterDefinitionFiles")]
    public class PrinterDefinitionFiles
    {
        private bool _isDirty = false;

        [XmlElement(ElementName = "SelectedFile")]
        public SelectedFile selectedFile;
        [XmlArray(ElementName = "FileSelections")]
        [XmlArrayItem(ElementName = "Pick")]
        public List<FileName> filePicks;

        public PrinterDefinitionFiles()
        {
            selectedFile = new SelectedFile();
            filePicks = new List<FileName>();
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }
    #endregion

    #region Print Configuration XML classes
    public class FileName
    {
        private bool _isDirty = false;

        private string _Text;

        public FileName() { }

        public FileName(string value)
        {
            _Text = value;
        }

        [XmlText]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; _isDirty = true; }
        }
        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }

    public class SelectedFile : FileName
    {
        public SelectedFile() { }
        public SelectedFile(string value)
        {
            base.Text = value;
        }
    }
    #endregion

    #region Hercules_Prt xml
    [XmlRoot(ElementName = "Connection")]
    public class Connection
    {
        private string _HerculesIP;
        private int _HerculesPort;
        private int _BufferSize;
        private string _ConnectAtStartChecked;
        private string _Protocol;
        private int _InputLinesPerPage;
        private int _RAWHostPort;
        private int _LPDLPRHostPort;

        public string HerculesIP
        {
            get { return _HerculesIP; }
            set { _HerculesIP = value; _IsDirty = true; }
        }
        public int HerculesPort
        {
            get { return _HerculesPort; }
            set { _HerculesPort = value; _IsDirty = true; }
        }
        public int BufferSize
        {
            get { return _BufferSize; }
            set { _BufferSize = value; _IsDirty = true; }
        }
        public string ConnectAtStartChecked
        {
            get { return _ConnectAtStartChecked; }
            set { _ConnectAtStartChecked = value; _IsDirty = true; }
        }
        public string Protocol
        {
            get { return _Protocol; }
            set { _Protocol = value; _IsDirty = true; }
        }
        public int InputLinesPerPage
        {
            get { return _InputLinesPerPage; }
            set { _InputLinesPerPage = value; _IsDirty = true; }
        }
        public int RAWHostPort
        {
            get { return _RAWHostPort; }
            set { _RAWHostPort = value; _IsDirty = true; }
        }
        public int LPDLPRHostPort
        {
            get { return _LPDLPRHostPort; }
            set { _LPDLPRHostPort = value; _IsDirty = true; }
        }

        private bool _IsDirty = false;
        [XmlIgnore]
        public bool IsDirty
        {
            get { return _IsDirty; }
            set { _IsDirty = value; }
        }
    }

    [XmlRoot(ElementName = "Qualification")]
    public class Qualification
    {
        private string _MustExist;
        private int _Line;
        private int _Column;
        private string _Value;

        [XmlAttribute(AttributeName = "MustExist")]
        public string MustExist
        {
            get { return _MustExist; }
            set { _MustExist = value; _IsDirty = true; }
        }
        [XmlAttribute(AttributeName = "Line")]
        public int Line
        {
            get { return _Line; }
            set { _Line = value; _IsDirty = true; }
        }
        [XmlAttribute(AttributeName = "Column")]
        public int Column
        {
            get { return _Column; }
            set { _Column = value; _IsDirty = true; }
        }
        [XmlAttribute(AttributeName = "Value")]
        public string Value
        {
            get { return _Value; }
            set { _Value = value; _IsDirty = true; }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get { return _IsDirty; }
            set { _IsDirty = value; }
        }
    }

    [XmlRoot(ElementName = "BOJQualifications")]
    public class BOJQualifications
    {
        private List<Qualification> _Qualifications;

        [XmlElement(ElementName = "Qualification")]
        public List<Qualification> Qualifications
        {
            get
            {
                return _Qualifications;
            }
            set
            {
                _Qualifications = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                foreach (var qual in _Qualifications)
                {
                    if (qual.IsDirty) return true;
                }
                return _IsDirty;
            }
            set
            {
                foreach (var qual in _Qualifications)
                {
                    qual.IsDirty = value;
                }
                _IsDirty = value;
            }
        }

        public BOJQualifications()
        {
            _Qualifications = new List<Qualification>();
        }
    }

    [XmlRoot(ElementName = "Field")]
    public class Field
    {
        private string _Name;
        private int _Line;
        private int _Column;
        private int _Width;
        private string _DefaultValue;

        [XmlAttribute(AttributeName = "Name")]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                _IsDirty = true;
            }
        }
        [XmlAttribute(AttributeName = "Line")]
        public int Line
        {
            get
            {
                return _Line;
            }
            set
            {
                _Line = value;
                _IsDirty = true;
            }
        }
        [XmlAttribute(AttributeName = "Column")]
        public int Column
        {
            get
            {
                return _Column;
            }
            set
            {
                _Column = value;
                _IsDirty = true;
            }
        }
        [XmlAttribute(AttributeName = "Width")]
        public int Width
        {
            get
            {
                return _Width;
            }
            set
            {
                _Width = value;
                _IsDirty = true;
            }
        }
        [XmlAttribute(AttributeName = "DefaultValue")]
        public string DefaultValue
        {
            get
            {
                return _DefaultValue;
            }
            set
            {
                _DefaultValue = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get { return _IsDirty; }
            set { _IsDirty = value; }
        }
    }

    [XmlRoot(ElementName = "BOJFields")]
    public class BOJFields
    {
        private List<Field> _Fields;

        [XmlElement(ElementName = "Field")]
        public List<Field> Fields
        {
            get
            {
                return _Fields;
            }
            set
            {
                _Fields = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                foreach (var field in _Fields)
                {
                    if (field.IsDirty) return true;
                }
                return _IsDirty;
            }
            set
            {
                foreach (var field in _Fields)
                {
                    field.IsDirty = value;
                }
                _IsDirty = value;
            }
        }

        public BOJFields()
        {
            _Fields = new List<Field>();
        }
    }

    [XmlRoot(ElementName = "BOJCustomization")]
    public class BOJCustomization
    {
        private BOJQualifications _BOJQualifications;
        private BOJFields _BOJFields;
        private int _BOJBannerPages;
        private int _BOJExtraBannerPages;
        private string _BOJPrintBanners;

        [XmlElement(ElementName = "BOJQualifications")]
        public BOJQualifications BOJQualifications
        {
            get
            {
                return _BOJQualifications;
            }
            set
            {
                _BOJQualifications = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "BOJFields")]
        public BOJFields BOJFields
        {
            get
            {
                return _BOJFields;
            }
            set
            {
                _BOJFields = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "BOJBannerPages")]
        public int BOJBannerPages
        {
            get
            {
                return _BOJBannerPages;
            }
            set
            {
                _BOJBannerPages = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "BOJExtraBannerPages")]
        public int BOJExtraBannerPages
        {
            get
            {
                return _BOJExtraBannerPages;
            }
            set
            {
                _BOJExtraBannerPages = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "BOJPrintBanners")]
        public string BOJPrintBanners
        {
            get
            {
                return _BOJPrintBanners;
            }
            set
            {
                _BOJPrintBanners = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_BOJQualifications.IsDirty || _BOJFields.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _BOJQualifications.IsDirty = value;
                _BOJFields.IsDirty = value;
                _IsDirty = value;
            }
        }

        public BOJCustomization()
        {
            _BOJQualifications = new BOJQualifications();
            _BOJFields = new BOJFields();
        }
    }

    [XmlRoot(ElementName = "EOJQualifications")]
    public class EOJQualifications
    {
        private List<Qualification> _Qualifications;

        [XmlElement(ElementName = "Qualification")]
        public List<Qualification> Qualifications
        {
            get
            {
                return _Qualifications;
            }
            set
            {
                _Qualifications = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                foreach (var qual in _Qualifications)
                {
                    if (qual.IsDirty) return true;
                }
                return _IsDirty;
            }
            set
            {
                foreach (var qual in _Qualifications)
                {
                    qual.IsDirty = value;
                }
                _IsDirty = value;
            }
        }

        public EOJQualifications()
        {
            _Qualifications = new List<Qualification>();
        }
    }

    [XmlRoot(ElementName = "EOJFields")]
    public class EOJFields
    {
        private List<Field> _Fields;

        [XmlElement(ElementName = "Field")]
        public List<Field> Fields
        {
            get
            {
                return _Fields;
            }
            set
            {
                _Fields = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                foreach (var field in _Fields)
                {
                    if (field.IsDirty) return true;
                }
                return _IsDirty;
            }
            set
            {
                foreach (var field in _Fields)
                {
                    field.IsDirty = value;
                }
                _IsDirty = value;
            }
        }

        public EOJFields()
        {
            _Fields = new List<Field>();
        }
    }

    [XmlRoot(ElementName = "EOJCustomization")]
    public class EOJCustomization
    {
        private EOJQualifications _EOJQualifications;
        private EOJFields _EOJFields;
        private int _EOJBannerPages;
        private int _EOJExtraBannerPages;
        private string _EOJPrintBanners;

        [XmlElement(ElementName = "EOJQualifications")]
        public EOJQualifications EOJQualifications
        {
            get
            {
                return _EOJQualifications;
            }
            set
            {
                _EOJQualifications = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "EOJFields")]
        public EOJFields EOJFields
        {
            get
            {
                return _EOJFields;
            }
            set
            {
                _EOJFields = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "EOJBannerPages")]
        public int EOJBannerPages
        {
            get
            {
                return _EOJBannerPages;
            }
            set
            {
                _EOJBannerPages = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "EOJExtraBannerPages")]
        public int EOJExtraBannerPages
        {
            get
            {
                return _EOJExtraBannerPages;
            }
            set
            {
                _EOJExtraBannerPages = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "EOJPrintBanners")]
        public string EOJPrintBanners
        {
            get
            {
                return _EOJPrintBanners;
            }
            set
            {
                _EOJPrintBanners = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_EOJQualifications.IsDirty || _EOJFields.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _EOJQualifications.IsDirty = value;
                _EOJFields.IsDirty = value;
                _IsDirty = value;
            }
        }

        public EOJCustomization()
        {
            _EOJQualifications = new EOJQualifications();
            _EOJFields = new EOJFields();
        }
    }

    [XmlRoot(ElementName = "CustomizationData")]
    public class CustomizationData
    {
        private BOJCustomization _BOJCustomization;
        private EOJCustomization _EOJCustomization;
        private string _OutputToTXT;
        private string _OutputToRTF;
        private string _OutputToPDF;
        private string _OutputToHTML;

        [XmlElement(ElementName = "BOJCustomization")]
        public BOJCustomization BOJCustomization
        {
            get
            {
                return _BOJCustomization;
            }
            set
            {
                _BOJCustomization = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "EOJCustomization")]
        public EOJCustomization EOJCustomization
        {
            get
            {
                return _EOJCustomization;
            }
            set
            {
                _EOJCustomization = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputToTXT")]
        public string OutputToTXT
        {
            get
            {
                return _OutputToTXT;
            }
            set
            {
                _OutputToTXT = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputToRTF")]
        public string OutputToRTF
        {
            get
            {
                return _OutputToRTF;
            }
            set
            {
                _OutputToRTF = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputToPDF")]
        public string OutputToPDF
        {
            get
            {
                return _OutputToPDF;
            }
            set
            {
                _OutputToPDF = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputToHTML")]
        public string OutputToHTML
        {
            get
            {
                return _OutputToHTML;
            }
            set
            {
                _OutputToHTML = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_BOJCustomization.IsDirty || _EOJCustomization.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _BOJCustomization.IsDirty = value;
                _EOJCustomization.IsDirty = value;
                _IsDirty = value;
            }
        }

        public CustomizationData()
        {
            _BOJCustomization = new BOJCustomization();
            _EOJCustomization = new EOJCustomization();
        }
    }

    [XmlRoot(ElementName = "DumpPacketsFilePicks")]
    public class DumpPacketsFilePicks
    {
        private List<Pick> _Picks;

        [XmlElement(ElementName = "Pick")]
        public List<Pick> Picks
        {
            get
            {
                return _Picks;
            }
            set
            {
                _Picks = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                foreach (var pick in _Picks)
                {
                    if (pick.IsDirty) return true;
                }
                return _IsDirty;
            }
            set
            {
                foreach (var pick in _Picks)
                {
                    pick.IsDirty = value;
                }
                _IsDirty = value;
            }
        }

        public DumpPacketsFilePicks()
        {
            _Picks = new List<Pick>();
        }
    }

    [XmlRoot(ElementName = "Diagnostics")]
    public class Diagnostics
    {
        private string _DumpPacketsChecked;
        private string _DumpPacketsFile;
        private DumpPacketsFilePicks _DumpPacketsFilePicks;
        private string _VerboseLoggingChecked;
        private string _DisplayInputChecked;
        private string _DisplayStatisticsChecked;
        private string _ProtocolLoggingChecked;

        [XmlElement(ElementName = "DumpPacketsChecked")]
        public string DumpPacketsChecked
        {
            get
            {
                return _DumpPacketsChecked;
            }
            set
            {
                _DumpPacketsChecked = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "DumpPacketsFile")]
        public string DumpPacketsFile
        {
            get
            {
                return _DumpPacketsFile;
            }
            set
            {
                _DumpPacketsFile = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "DumpPacketsFilePicks")]
        public DumpPacketsFilePicks DumpPacketsFilePicks
        {
            get
            {
                return _DumpPacketsFilePicks;
            }
            set
            {
                _DumpPacketsFilePicks = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "VerboseLoggingChecked")]
        public string VerboseLoggingChecked
        {
            get
            {
                return _VerboseLoggingChecked;
            }
            set
            {
                _VerboseLoggingChecked = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "DisplayInputChecked")]
        public string DisplayInputChecked
        {
            get
            {
                return _DisplayInputChecked;
            }
            set
            {
                _DisplayInputChecked = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "DisplayStatisticsChecked")]
        public string DisplayStatisticsChecked
        {
            get
            {
                return _DisplayStatisticsChecked;
            }
            set
            {
                _DisplayStatisticsChecked = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "ProtocolLoggingChecked")]
        public string ProtocolLoggingChecked
        {
            get
            {
                return _ProtocolLoggingChecked;
            }
            set
            {
                _ProtocolLoggingChecked = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_DumpPacketsFilePicks.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _DumpPacketsFilePicks.IsDirty = value;
                _IsDirty = value;
            }
        }

        public Diagnostics()
        {
            _DumpPacketsFilePicks = new DumpPacketsFilePicks();
        }
    }

    [XmlRoot(ElementName = "TXTOutput")]
    public class TXTOutput
    {
        private string _OutputDir;
        private OutputDirPicks _OutputDirPicks;
        private string _OutputFileTemplate;
        private OutputFileTemplatePicks _OutputFileTemplatePicks;

        [XmlElement(ElementName = "OutputDir")]
        public string OutputDir
        {
            get
            {
                return _OutputDir;
            }
            set
            {
                _OutputDir = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputDirPicks")]
        public OutputDirPicks OutputDirPicks
        {
            get
            {
                return _OutputDirPicks;
            }
            set
            {
                _OutputDirPicks = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputFileTemplate")]
        public string OutputFileTemplate
        {
            get
            {
                return _OutputFileTemplate;
            }
            set
            {
                _OutputFileTemplate = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputFileTemplatePicks")]
        public OutputFileTemplatePicks OutputFileTemplatePicks
        {
            get
            {
                return _OutputFileTemplatePicks;
            }
            set
            {
                _OutputFileTemplatePicks = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_OutputDirPicks.IsDirty || _OutputFileTemplatePicks.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _OutputDirPicks.IsDirty = value;
                _OutputFileTemplatePicks.IsDirty = value;
                _IsDirty = value;
            }
        }

        public TXTOutput()
        {
            _OutputDirPicks = new OutputDirPicks();
            _OutputFileTemplatePicks = new OutputFileTemplatePicks();
        }
    }

    [XmlRoot(ElementName = "RTFOutput")]
    public class RTFOutput
    {
        private string _OutputDir;
        private OutputDirPicks _OutputDirPicks;
        private string _OutputFileTemplate;
        private OutputFileTemplatePicks _OutputFileTemplatePicks;

        [XmlElement(ElementName = "OutputDir")]
        public string OutputDir
        {
            get
            {
                return _OutputDir;
            }
            set
            {
                _OutputDir = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputDirPicks")]
        public OutputDirPicks OutputDirPicks
        {
            get
            {
                return _OutputDirPicks;
            }
            set
            {
                _OutputDirPicks = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputFileTemplate")]
        public string OutputFileTemplate
        {
            get
            {
                return _OutputFileTemplate;
            }
            set
            {
                _OutputFileTemplate = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputFileTemplatePicks")]
        public OutputFileTemplatePicks OutputFileTemplatePicks
        {
            get
            {
                return _OutputFileTemplatePicks;
            }
            set
            {
                _OutputFileTemplatePicks = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_OutputDirPicks.IsDirty || _OutputFileTemplatePicks.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _OutputDirPicks.IsDirty = value;
                _OutputFileTemplatePicks.IsDirty = value;
                _IsDirty = value;
            }
        }

        public RTFOutput()
        {
            _OutputDirPicks = new OutputDirPicks();
            _OutputFileTemplatePicks = new OutputFileTemplatePicks();
        }
    }

    [XmlRoot(ElementName = "OutputDirPicks")]
    public class OutputDirPicks
    {
        private List<Pick> _Picks;

        [XmlElement(ElementName = "Pick")]
        public List<Pick> Picks
        {
            get
            {
                return _Picks;
            }
            set
            {
                _Picks = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                foreach (var pick in _Picks)
                {
                    if (pick.IsDirty) return true;
                }
                return _IsDirty;
            }
            set
            {
                foreach (var pick in _Picks)
                {
                    pick.IsDirty = value;
                }
                _IsDirty = value;
            }
        }

        public OutputDirPicks()
        {
            _Picks = new List<Pick>();
        }

        public List<string> ToList()
        {
            List<string> strings = new List<string>();
            foreach (var pick in _Picks)
            {
                strings.Add(pick.Text);
            }
            return strings;
        }
    }

    [XmlRoot(ElementName = "OutputFileTemplatePick")]
    public class OutputFileTemplatePicks
    {
        private List<Pick> _Picks;

        [XmlElement(ElementName = "Pick")]
        public List<Pick> Picks
        {
            get
            {
                return _Picks;
            }
            set
            {
                _Picks = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                foreach (var pick in _Picks)
                {
                    if (pick.IsDirty) return true;
                }
                return _IsDirty;
            }
            set
            {
                foreach (var pick in _Picks)
                {
                    pick.IsDirty = value;
                }
                _IsDirty = value;
            }
        }

        public OutputFileTemplatePicks()
        {
            _Picks = new List<Pick>();
        }

        public List<string> ToList()
        {
            List<string> strings = new List<string>();
            foreach (var pick in _Picks)
            {
                strings.Add(pick.Text);
            }
            return strings;
        }
    }

    [XmlRoot(ElementName = "PDFOutput")]
    public class PDFOutput
    {
        private string _OutputDir;
        private OutputDirPicks _OutputDirPicks;
        private string _OutputFileTemplate;
        private OutputFileTemplatePicks _OutputFileTemplatePicks;
        private string _PageSize;

        [XmlElement(ElementName = "OutputDir")]
        public string OutputDir
        {
            get
            {
                return _OutputDir;
            }
            set
            {
                _OutputDir = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputDirPicks")]
        public OutputDirPicks OutputDirPicks
        {
            get
            {
                return _OutputDirPicks;
            }
            set
            {
                _OutputDirPicks = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputFileTemplate")]
        public string OutputFileTemplate
        {
            get
            {
                return _OutputFileTemplate;
            }
            set
            {
                _OutputFileTemplate = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputFileTemplatePicks")]
        public OutputFileTemplatePicks OutputFileTemplatePicks
        {
            get
            {
                return _OutputFileTemplatePicks;
            }
            set
            {
                _OutputFileTemplatePicks = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "PageSize")]
        public string PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_OutputDirPicks.IsDirty || _OutputFileTemplatePicks.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _OutputDirPicks.IsDirty = value;
                _OutputFileTemplatePicks.IsDirty = value;
                _IsDirty = value;
            }
        }

        public PDFOutput()
        {
            _OutputDirPicks = new OutputDirPicks();
            _OutputFileTemplatePicks = new OutputFileTemplatePicks();
        }
    }

    [XmlRoot(ElementName = "HTMLOutput")]
    public class HTMLOutput
    {
        private string _OutputDir;
        private OutputDirPicks _OutputDirPicks;
        private string _OutputFileTemplate;
        private OutputFileTemplatePicks _OutputFileTemplatePicks;
        private string _HTMLHeaderChecked;

        [XmlElement(ElementName = "OutputDir")]
        public string OutputDir
        {
            get
            {
                return _OutputDir;
            }
            set
            {
                _OutputDir = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputDirPicks")]
        public OutputDirPicks OutputDirPicks
        {
            get
            {
                return _OutputDirPicks;
            }
            set
            {
                _OutputDirPicks = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputFileTemplate")]
        public string OutputFileTemplate
        {
            get
            {
                return _OutputFileTemplate;
            }
            set
            {
                _OutputFileTemplate = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "OutputFileTemplatePicks")]
        public OutputFileTemplatePicks OutputFileTemplatePicks
        {
            get
            {
                return _OutputFileTemplatePicks;
            }
            set
            {
                _OutputFileTemplatePicks = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "HTMLHeaderChecked")]
        public string HTMLHeaderChecked
        {
            get
            {
                return _HTMLHeaderChecked;
            }
            set
            {
                _HTMLHeaderChecked = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_OutputDirPicks.IsDirty || _OutputFileTemplatePicks.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _OutputDirPicks.IsDirty = value;
                _OutputFileTemplatePicks.IsDirty = value;
                _IsDirty = value;
            }
        }

        public HTMLOutput()
        {
            _OutputDirPicks = new OutputDirPicks();
            _OutputFileTemplatePicks = new OutputFileTemplatePicks();
        }
    }

    public class Pick
    {
        private string _Text;

        [XmlText]
        public string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get { return _IsDirty; }
            set { _IsDirty = value; }
        }

        public Pick() { }

        public Pick(string text)
        {
            _Text = text;
            _IsDirty = true;
        }
    }

    [XmlRoot(ElementName = "WorkDirPicks")]
    public class WorkDirPicks
    {
        private List<Pick> _Picks;

        [XmlElement(ElementName = "Pick")]
        public List<Pick> Picks
        {
            get
            {
                return _Picks;
            }
            set
            {
                _Picks = value;
                _IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                foreach (var pick in _Picks)
                {
                    if (pick.IsDirty) return true;
                }
                return _IsDirty;
            }
            set
            {
                foreach (var pick in _Picks)
                {
                    pick.IsDirty = value;
                }
                _IsDirty = value;
            }
        }

        public WorkDirPicks()
        {
            _Picks = new List<Pick>();
        }

        public List<string> ToList()
        {
            List<string> strings = new List<string>();
            foreach (var pick in _Picks)
            {
                strings.Add(pick.Text);
            }
            return strings;
        }
    }

    [XmlRoot(ElementName = "LPDLPRProcessing")]
    public class LPDLPRProcessing
    {
        private string _WorkDir;
        private WorkDirPicks _WorkDirPicks;

        [XmlElement(ElementName = "WorkDir")]
        public string WorkDir
        {
            get
            {
                return _WorkDir;
            }
            set
            {
                _WorkDir = value;
                _IsDirty = true;
            }
        }
        [XmlElement(ElementName = "WorkDirPicks")]
        public WorkDirPicks WorkDirPicks
        {
            get
            {
                return _WorkDirPicks;
            }
            set
            {
                _WorkDirPicks = value;
                _WorkDirPicks.IsDirty = true;
            }
        }

        private bool _IsDirty;
        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_WorkDirPicks.IsDirty) return true;
                return _IsDirty;
            }
            set
            {
                _WorkDirPicks.IsDirty = value;
                _IsDirty = value;
            }
        }

        public LPDLPRProcessing()
        {
            _WorkDirPicks = new WorkDirPicks();
        }
    }

    [XmlRoot(ElementName = "HerculesPrt")]
    public class XMLHerculesPrt
    {
        private Connection _Connection;
        private CustomizationData _CustomizationData;
        private Diagnostics _Diagnostics;
        private TXTOutput _TXTOutput;
        private RTFOutput _RTFOutput;
        private PDFOutput _PDFOutput;
        private HTMLOutput _HTMLOutput;
        private LPDLPRProcessing _LPDLPRProcessing;

        [XmlElement(ElementName = "Connection")]
        public Connection Connection
        {
            get { return _Connection; }
            set
            {
                _Connection = value;
                _Connection.IsDirty = true;
            }
        }
        [XmlElement(ElementName = "CustomizationData")]
        public CustomizationData CustomizationData
        {
            get { return _CustomizationData; }
            set
            {
                _CustomizationData = value;
                _CustomizationData.IsDirty = true;
            }
        }
        [XmlElement(ElementName = "Diagnostics")]
        public Diagnostics Diagnostics
        {
            get { return _Diagnostics; }
            set
            {
                _Diagnostics = value;
                _Diagnostics.IsDirty = true;
            }
        }
        [XmlElement(ElementName = "TXTOutput")]
        public TXTOutput TXTOutput
        {
            get { return _TXTOutput; }
            set
            {
                _TXTOutput = value;
                _TXTOutput.IsDirty = true;
            }
        }
        [XmlElement(ElementName = "RTFOutput")]
        public RTFOutput RTFOutput
        {
            get { return _RTFOutput; }
            set
            {
                _RTFOutput = value;
                _RTFOutput.IsDirty = true;
            }
        }
        [XmlElement(ElementName = "PDFOutput")]
        public PDFOutput PDFOutput
        {
            get { return _PDFOutput; }
            set
            {
                _PDFOutput = value;
                _PDFOutput.IsDirty = true;
            }
        }
        [XmlElement(ElementName = "HTMLOutput")]
        public HTMLOutput HTMLOutput
        {
            get { return _HTMLOutput; }
            set
            {
                _HTMLOutput = value;
                _HTMLOutput.IsDirty = true;
            }
        }
        [XmlElement(ElementName = "LPDLPRProcessing")]
        public LPDLPRProcessing LPDLPRProcessing
        {
            get { return _LPDLPRProcessing; }
            set
            {
                _LPDLPRProcessing = value;
                _LPDLPRProcessing.IsDirty = true;
            }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get
            {
                if (_Connection.IsDirty || _CustomizationData.IsDirty || _Diagnostics.IsDirty ||
                    _TXTOutput.IsDirty || _RTFOutput.IsDirty || _PDFOutput.IsDirty ||
                    _HTMLOutput.IsDirty || _LPDLPRProcessing.IsDirty)
                {
                    return true;
                }

                return false;
            }
            set
            {
                _Connection.IsDirty = value;
                _CustomizationData.IsDirty = value;
                _Diagnostics.IsDirty = value;
                _TXTOutput.IsDirty = value;
                _RTFOutput.IsDirty = value;
                _PDFOutput.IsDirty = value;
                _HTMLOutput.IsDirty = value;
                _LPDLPRProcessing.IsDirty = value;
            }
        }

        public XMLHerculesPrt()
        {
            _Connection = new Connection();
            _CustomizationData = new CustomizationData();
            _Diagnostics = new Diagnostics();
            _TXTOutput = new TXTOutput();
            _RTFOutput = new RTFOutput();
            _PDFOutput = new PDFOutput();
            _HTMLOutput = new HTMLOutput();
            _LPDLPRProcessing = new LPDLPRProcessing();
            IsDirty = true;
        }

        public static XMLHerculesPrt Load(string path)
        {
            XMLHerculesPrt cfg;
            var serializer = new XmlSerializer(typeof(XMLHerculesPrt));
            try
            {
                if (File.Exists(path))
                {
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        cfg = serializer.Deserialize(stream) as XMLHerculesPrt;
                        cfg.IsDirty = false;
                        return cfg;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deserialize error");
            }
            cfg = new XMLHerculesPrt();
            return cfg;
        }

        public void Save(string namepath)
        {
            char[] pSep = { '/', '\\' };
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(XMLHerculesPrt));
            if (namepath.LastIndexOfAny(pSep) >= 0)
            {
                string path = namepath.Substring(0, namepath.LastIndexOfAny(pSep));
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            using (var stream = new FileStream(namepath, FileMode.Create))
            {
                serializer.Serialize(stream, this, ns);
            }
        }
    }
    #endregion
}

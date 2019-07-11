using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_File_Organizer
{
    public partial class Form1 : Form
    {
        private List<string> musicList = new List<string>();
        private List<string> documentList = new List<string>();
        private List<string> videoList = new List<string>();
        private List<string> executableList = new List<string>();
        private List<string> imageList = new List<string>();
        private List<string> codeList = new List<string>();

        private string[] musicFormats = { ".mp3", ".wav", ".ogg", ".flac", ".aac", ".wma", ".mid", ".asd" };
        private string[] videoFormats = { ".mp4", ".wmv", ".avi", ".3gp", ".mkv", ".webm", ".mov" };
        private string[] imageFormats = { ".tif", ".tiff", ".gif", ".jpeg", "jpg", ".jif", ".jfif", ".jp2", ".jpx",
                    ".j2k", ".j2c", ".fpx", ".pcd", ".png"};
        private string[] documentFormats = { ".doc", ".docx", ".html", ".htm",
                    ".odt", ".pdf", ".xls", ".xlsx", ".ods", ".ppt", ".pptx", ".txt", ".zip", ".torrent", ".rar", ".iso" };
        private string[] executableFormats = { ".run", ".apk", ".exe", ".jar", ".bat", ".bin", ".app" };
        private string[] codeFormats = { ".4DB", ".4TH", ".A", ".A2W", ".AAB", ".ABC", ".ACD", ".ADDIN", ".ADS", ".AGI", ".AIA", ".ALB", ".AM4", ".AM5", ".AM6", ".AM7", ".ANE", ".AP_", ".APA", ".APPX", ".APPXUPLOAD", ".APS", ".ARSC", ".ARTPROJ", ".AS", ".AS2PROJ", ".AS3PROJ", ".ASC", ".ASI", ".ASM", ".ASM", ".ASVF", ".AU3", ".AUTOPLAY", ".AWK", ".B", ".BAS", ".BB", ".BBC", ".BBPROJECT", ".BBPROJECTD", ".BCP", ".BDSPROJ", ".BET", ".BLUEJ", ".BPG", ".BPL", ".BRX", ".BS2", ".BSC", ".C", ".C", ".CAF", ".CAPROJ", ".CAPX", ".CBL", ".CBP", ".CC", ".CCGAME", ".CCN", ".CCP", ".CCS", ".CD", ".CDF", ".CFC", ".CLASS", ".CLIPS", ".CLS", ".CLW", ".COB", ".COD", ".CONFIG", ".CP", ".CP", ".CPP", ".CS", ".CSI", ".CSI", ".CSN", ".CSP", ".CSPROJ", ".CSX", ".CTL", ".CTP", ".CTXT", ".CU", ".CVSRC", ".CXP", ".CXX", ".D", ".DBA", ".DBA", ".DBML", ".DBO", ".DBPRO", ".DBPROJ", ".DCP", ".DCPROJ", ".DCU", ".DCUIL", ".DEC", ".DEF", ".DEVICEIDS", ".DEX", ".DF1", ".DFM", ".DGML", ".DGSL", ".DIFF", ".DM1", ".DMD", ".DOB", ".DOX", ".DPK", ".DPKW", ".DPL", ".DPR", ".DPROJ", ".DSGM", ".DSP", ".DTD", ".EDML", ".EDMX", ".ENT", ".ENTITLEMENTS", ".EQL", ".ERB", ".ERL", ".EX", ".EXP", ".EXW", ".F", ".F90", ".FBP", ".FBZ7", ".FGL", ".FLA", ".FOR", ".FORTH", ".FPM", ".FRAMEWORK", ".FRX", ".FS", ".FSI", ".FSPROJ", ".FSPROJ", ".FSSCRIPT", ".FSX", ".FTL", ".FTN", ".FXC", ".FXCPROJ", ".FXL", ".FXML", ".FXPL", ".GAMEPROJ", ".GCH", ".GED", ".GEM", ".GEMSPEC", ".GFAR", ".GITATTRIBUTES", ".GITIGNORE", ".GLD", ".GM6", ".GM81", ".GMD", ".GMK", ".GMO", ".GMX", ".GORM", ".GREENFOOT", ".GROOVY", ".GROUPPROJ", ".GS", ".GS3", ".H", ".HAL", ".HAML", ".HAS", ".HBS", ".HH", ".HPF", ".HPP", ".HS", ".HXX", ".I", ".ICONSET", ".IDB", ".IDL", ".IDT", ".ILK", ".IML", ".INC", ".INL", ".INO", ".IPCH", ".IPR", ".IPR", ".ISE", ".ISM", ".IST", ".IWB", ".IWS", ".JAVA", ".JCP", ".JIC", ".JPR", ".JPX", ".JSFL", ".JSPF", ".KDEVELOP", ".KDEVPRJ", ".KPL", ".L", ".LBI", ".LBS", ".LDS", ".LGO", ".LHS", ".LICENSES", ".LICX", ".LISP", ".LIT", ".LIVECODE", ".LNT", ".LPROJ", ".LSPROJ", ".LTB", ".LUA", ".LUCIDSNIPPET", ".LXSPROJ", ".M", ".M", ".M4", ".MAGIK", ".MAK", ".MARKDOWN", ".MCP", ".MD", ".MDZIP", ".MER", ".MF", ".MFA", ".MK", ".ML", ".MM", ".MO", ".MOD", ".MOM", ".MPR", ".MRT", ".MSHA", ".MSHC", ".MSHI", ".MSIX", ".MSL", ".MSP", ".MSS", ".MV", ".MXML", ".MYAPP", ".NBC", ".NCB", ".NED", ".NFM", ".NIB", ".NK", ".NLS", ".NQC", ".NSH", ".NSI", ".NUPKG", ".NUSPEC", ".NVV", ".NW", ".NXC", ".O", ".OCA", ".OCTEST", ".OCX", ".ODL", ".OMO", ".OWL", ".P", ".P3D", ".PAS", ".PAS", ".PATCH", ".PB", ".PBG", ".PBJ", ".PBK", ".PBXBTREE", ".PBXPROJ", ".PBXUSER", ".PCH", ".PCP", ".PDE", ".PDM", ".PH", ".PIKA", ".PJX", ".PKGDEF", ".PKGUNDEF", ".PL", ".PL", ".PL1", ".PLAYGROUND", ".PLC", ".PLE", ".PLI", ".PM", ".PO", ".POD", ".POT", ".PPC", ".PRG", ".PRG", ".PRI", ".PRI", ".PRO", ".PROTO", ".PSC", ".PSM1", ".PTL", ".PWN", ".PXD", ".PY", ".PYD", ".PYW", ".PYX", ".QPR", ".R", ".R", ".R", ".RAV", ".RB", ".RBC", ".RBP", ".RBW", ".RC", ".RC2", ".RDLC", ".REFRESH", ".RES", ".RES", ".RESJSON", ".RESOURCES", ".RESW", ".RESX", ".REXX", ".RISE", ".RKT", ".RNC", ".RODL", ".RPY", ".RSRC", ".RSS", ".RUL", ".S", ".S19", ".SAS", ".SB", ".SB2", ".SB3", ".SBPROJ", ".SC", ".SCC", ".SCRIPTSUITE", ".SCRIPTTERMINOLOGY", ".SDEF", ".SH", ".SLN", ".SLOGO", ".SLTNG", ".SMA", ".SMALI", ".SNIPPET", ".SO", ".SPEC", ".SQLPROJ", ".SRC", ".SRC.RPM", ".SS", ".SSC", ".SSI", ".STORYBOARD", ".SUD", ".SUO", ".SUP", ".SVN-BASE", ".SWC", ".SWD", ".SWIFT", ".SYM", ".T", ".TARGETS", ".TCL", ".TDS", ".TESTRUNCONFIG", ".TESTSETTINGS", ".TEXTFACTORY", ".TK", ".TLD", ".TLH", ".TLI", ".TMLANGUAGE", ".TMPROJ", ".TNS", ".TPU", ".TRX", ".TT", ".TU", ".TUR", ".TWIG", ".UI", ".UML", ".V", ".V", ".V11.SUO", ".V12.SUO", ".VB", ".VBG", ".VBP", ".VBPROJ", ".VBX", ".VBZ", ".VC", ".VCP", ".VCPROJ", ".VCXPROJ", ".VDM", ".VDP", ".VDPROJ", ".VGC", ".VHD", ".VM", ".VSMACROS", ".VSMDI", ".VSMPROJ", ".VSP", ".VSPS", ".VSPSCC", ".VSPX", ".VSSSCC", ".VSZ", ".VTM", ".VTML", ".VTV", ".W", ".W32", ".WDGT", ".WDGTPROJ", ".WDL", ".WDP", ".WDW", ".WIQ", ".WIXLIB", ".WIXMSP", ".WIXMST", ".WIXOBJ", ".WIXOUT", ".WIXPDB", ".WIXPROJ", ".WORKSPACE", ".WPW", ".WSC", ".WSP", ".WXI", ".WXL", ".WXS", ".XAML", ".XAMLX", ".XAP", ".XCAPPDATA", ".XCARCHIVE", ".XCCONFIG", ".XCDATAMODELD", ".XCODEPROJ", ".XCSNAPSHOTS", ".XCWORKSPACE", ".XIB", ".XOJO_BINARY_PROJECT", ".XOJO_MENU", ".XOJO_PROJECT", ".XOJO_XML_PROJECT", ".XOML", ".XPP", ".XQ", ".XQL", ".XQM", ".XQUERY", ".XSD", ".XT", ".Y", ".YAML", ".YML", ".YMP", ".YPR" };


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function moves a list of files to a folder.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="path"></param>
        public void MoveFiles(List<string> lista, string path)
        {
            foreach (string i in lista)
            {
                File.Move(i, path + @"\"+Path.GetFileName(i));
            }
        }

        /// <summary>
        /// This method resets all values from the labels.
        /// </summary>
        public void ResetLabels()
        {
            lblFilesFound.Text = "Files found: 0";
            lblMusic.Text = "Music: 0";
            lblExecutables.Text = "Executables: 0";
            lblVideos.Text = "Videos: 0";
            lblDocuments.Text = "Documents: 0";
            lblImages.Text = "Images: 0";
        }

        /// <summary>
        /// This method increases the progress bar by 10.
        /// </summary>
        public void IncreaseProgressBar()
        {
            pgProgress.Value = pgProgress.Value + 8;
        }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            // Opening the folder dialog.
            var fb = new FolderBrowserDialog();

            DialogResult result = fb.ShowDialog();

            // If the user selects something.
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fb.SelectedPath))
            {
                // Get all files from the selected folder.
                string[] files = Directory.GetFiles(fb.SelectedPath);
                
                // For each file in the file list.
                foreach (string i in files)
                {
                    // If it's a music file.
                    if (musicFormats.Any(c => i.EndsWith(c, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        musicList.Add(i);
                    }
                    // If it's a video file.
                    else if (videoFormats.Any(c => i.EndsWith(c, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        videoList.Add(i);
                    }
                    // If it's an image file.
                    else if (imageFormats.Any(c => i.EndsWith(c, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        imageList.Add(i);
                    }
                    // If it's a document file.
                    else if (documentFormats.Any(c => i.EndsWith(c, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        documentList.Add(i);
                    }
                    // If it's an executable file.
                    else if (executableFormats.Any(c => i.EndsWith(c, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        executableList.Add(i);
                    }
                    else if (codeFormats.Any(c => i.EndsWith(c, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        codeList.Add(i);
                    }
                }

                // Update labels.
                lblFilesFound.Text = "Files found: " + files.Length.ToString();
                lblMusic.Text = "Music: " + musicList.ToArray().Length.ToString();
                lblExecutables.Text = "Executables: " + executableList.ToArray().Length.ToString();
                lblVideos.Text = "Videos: " + videoList.ToArray().Length.ToString();
                lblDocuments.Text = "Documents: " + documentList.ToArray().Length.ToString();
                lblImages.Text = "Images: " + imageList.ToArray().Length.ToString();
                lblCode.Text = "Code: " + codeList.ToArray().Length.ToString();

                // Confirming if the user wants to organize the files.
                DialogResult dialogResult = MessageBox.Show("We're about to organize all your files in folders. That means we'll move them. Is that ok?", "Confirmation", MessageBoxButtons.YesNo);

                // If he confirms.
                if (dialogResult == DialogResult.Yes)
                {
                    // Step 1 = 5 actions.
                    Directory.CreateDirectory(fb.SelectedPath + @"\Music Files"); // Music Folder.
                    IncreaseProgressBar();
                    Directory.CreateDirectory(fb.SelectedPath + @"\Video Files"); // Videos Folder.
                    IncreaseProgressBar();
                    Directory.CreateDirectory(fb.SelectedPath + @"\Image Files"); // Images Folder.
                    IncreaseProgressBar();
                    Directory.CreateDirectory(fb.SelectedPath + @"\Document Files"); // Documents Folder.
                    IncreaseProgressBar();
                    Directory.CreateDirectory(fb.SelectedPath + @"\Executable Files"); // Executables Folder.
                    IncreaseProgressBar();
                    Directory.CreateDirectory(fb.SelectedPath + @"\Code Files"); // Executables Folder.
                    IncreaseProgressBar();

                    // Step 2 = 5 actions.
                    MoveFiles(imageList, fb.SelectedPath + @"\Image Files");
                    IncreaseProgressBar();
                    MoveFiles(documentList, fb.SelectedPath + @"\Document Files");
                    IncreaseProgressBar();
                    MoveFiles(musicList, fb.SelectedPath + @"\Music Files");
                    IncreaseProgressBar();
                    MoveFiles(videoList, fb.SelectedPath + @"\Video Files");
                    IncreaseProgressBar();
                    MoveFiles(executableList, fb.SelectedPath + @"\Executable Files");
                    IncreaseProgressBar();
                    MoveFiles(codeList, fb.SelectedPath + @"\Code Files");
                    IncreaseProgressBar();

                    MessageBox.Show("Done!");
                    ResetLabels();
                    pgProgress.Value = 0;
                }
                else if (dialogResult == DialogResult.No)
                {
                    ResetLabels();
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any folders! :(", "OOPS!");
            }
        }
    }
}

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

        private string[] musicFormats = { ".mp3", ".wav", ".ogg", ".flac", ".aac", ".wma", ".mid", ".asd" };
        private string[] videoFormats = { ".mp4", ".wmv", ".avi", ".3gp", ".mkv", ".webm", ".mov" };
        private string[] imageFormats = { ".tif", ".tiff", ".gif", ".jpeg", "jpg", ".jif", ".jfif", ".jp2", ".jpx",
                    ".j2k", ".j2c", ".fpx", ".pcd", ".png"};
        private string[] documentFormats = { ".doc", ".docx", ".html", ".htm",
                    ".odt", ".pdf", ".xls", ".xlsx", ".ods", ".ppt", ".pptx", ".txt", ".zip", ".torrent", ".rar", ".iso" };
        private string[] executableFormats = { ".run", ".apk", ".exe", ".jar", ".bat", ".bin", ".app" };

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
            pgProgress.Value = pgProgress.Value + 10; 
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
                    if (musicFormats.Any(c => i.EndsWith(c)))
                    {
                        musicList.Add(i);
                    }
                    // If it's a video file.
                    else if (videoFormats.Any(c => i.EndsWith(c)))
                    {
                        videoList.Add(i);
                    }
                    // If it's an image file.
                    else if (imageFormats.Any(c => i.EndsWith(c)))
                    {
                        imageList.Add(i);
                    }
                    // If it's a document file.
                    else if (documentFormats.Any(c => i.EndsWith(c)))
                    {
                        documentList.Add(i);
                    }
                    // If it's an executable file.
                    else if (executableFormats.Any(c => i.EndsWith(c)))
                    {
                        executableList.Add(i);
                    }
                }

                // Update labels.
                lblFilesFound.Text = "Files found: " + files.Length.ToString();
                lblMusic.Text = "Music: " + musicList.ToArray().Length.ToString();
                lblExecutables.Text = "Executables: " + executableList.ToArray().Length.ToString();
                lblVideos.Text = "Videos: " + videoList.ToArray().Length.ToString();
                lblDocuments.Text = "Documents: " + documentList.ToArray().Length.ToString();
                lblImages.Text = "Images: " + imageList.ToArray().Length.ToString();

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

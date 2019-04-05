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
        public Form1()
        {
            InitializeComponent();
        }


        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            var fb = new FolderBrowserDialog();

            DialogResult result = fb.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fb.SelectedPath))
            {
                string[] files = Directory.GetFiles(fb.SelectedPath);

                List<string> musicList = new List<string>();
                List<string> documentList = new List<string>();
                List<string> videoList = new List<string>();

                string[] musicFormats = { ".mp3", ".wav", ".ogg", ".flac", ".aac", ".wma" };
                string[] videoFormats = { ".mp4", ".wmv", ".avi", ".3gp", ".mkv", ".webm", ".mov" };
                string[] documentFormats = { ".doc", ".docx", ".html", ".htm",
                    ".odt", ".pdf", ".xls", ".xlsx", ".ods", ".ppt", ".pptx", ".txt" };

                foreach (string i in files)
                {
                    if (musicFormats.Any(c => i.EndsWith(c)))
                    {
                        musicList.Add(i);
                    }
                    else if (videoFormats.Any(c => i.EndsWith(c)))
                    {
                        videoList.Add(i);
                    }
                    else if (documentFormats.Any(c => i.EndsWith(c)))
                    {
                        documentList.Add(i);
                    }
                }

                foreach (string i in videoList)
                {
                    Console.WriteLine(i);
                }

                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            } else
            {
                MessageBox.Show("You haven't selected any folders! :(", "OOPS!");
            }
        }
    }
}

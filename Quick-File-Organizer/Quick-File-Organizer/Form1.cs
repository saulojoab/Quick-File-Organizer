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

                foreach (string i in files)
                {
                    if (new[] { ".mp3", ".wav", ".ogg", ".flac", ".aac", ".wma" }.Any(c => i.EndsWith(c)))
                    {
                        musicList.Add(i);
                    }
                }

                foreach (string i in musicList)
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

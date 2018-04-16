using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Jukebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] extensions = new[] { ".mp3", ".wma", ".wav", ".MP3", ".WMA" };

        FileInfo[] files;
        string[] genre = new string[3];

        private void button2_Click(object sender, EventArgs e)
        {
            AboutForm form2 = new AboutForm();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetupForm form3 = new SetupForm();
            form3.ShowDialog();
        }

        private void lstboxTracks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstboxTracks.SelectedItem != null)
            {
                txtPlayingNow.Text = lstboxTracks.SelectedItem.ToString();
                axWindowsMediaPlayer1.URL = files[lstboxTracks.SelectedIndex].FullName;
               
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Tracks");
            files = dinfo.EnumerateFiles().Where(f => extensions.Contains(f.Extension.ToLower())).ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                lstboxTracks.Items.Add(files[i]);
            }
        }
    }
}

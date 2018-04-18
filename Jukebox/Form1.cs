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
        //Creates and array of extensions that the form will load
        string[] extensions = new[] { ".mp3", ".wma", ".wav", ".MP3", ".WMA" };

        FileInfo[] files;
        //Creates array of genres
        string[] genres = new string[] { "Rap", "Pop", "Others" };

        private void button2_Click(object sender, EventArgs e)
        {
            //Opens the About form when pressing the button
            AboutForm form2 = new AboutForm();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opens the Setup form when pressing the button
            SetupForm form3 = new SetupForm();
            form3.ShowDialog();
        }

        private void lstboxTracks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //After double clicking on the track, it will start to play and the title of the track will appear in the now playing box
            if (txtPlayingNow.Text == "")
            {
                txtPlayingNow.Text = lstboxTracks.SelectedItem.ToString();
                MediaPlayer.URL = files[lstboxTracks.SelectedIndex].FullName;
               
            }
            else
            {
                lstboxPlaylist.Items.Add(lstboxTracks.SelectedItem);
            }
            //Pseudo Code
            //If MediaPlayer.Playing = Timer1.Enabled = False
            //If MediaPlayer.Stopped = Timer1.Enabled = True
            //MediaPlayer.URL = files[listboxPlaylist]
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtGenre.Text = genres[0];
            //Makes the media player invisible to the user
            MediaPlayer.Visible = false;

            //Load the tracks into the application
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\Radit\source\repos\Jukebox\Tracks");
            files = dinfo.EnumerateFiles().Where(f => extensions.Contains(f.Extension.ToLower())).ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                lstboxTracks.Items.Add(files[i]);
            }
        }
    }
}

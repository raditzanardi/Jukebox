using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jukebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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

        private void lstboxTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstboxTracks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstboxTracks.SelectedItem != null)
            {

                txtPlayingNow.Text = lstboxTracks.SelectedItem.ToString();
            }

        }
            
    }
}

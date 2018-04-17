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
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        string[] files, paths;

        private void button2_Click(object sender, EventArgs e)
        {
            //Deletes all the items in the list box
            lstImport.Items.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Copies the tracks from the imported tracks list box to the present genre tracks list box
            if (lstImport.SelectedItem != null)
            {
                lstTracks.Items.Add(lstImport.SelectedItem);
            }
            else
            {
                MessageBox.Show("You have not selected a track");
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //Moves the track selected into the tracks list box
            if (lstImport.SelectedItem != null)
            {
                lstTracks.Items.Add(lstImport.SelectedItem);
                lstImport.Items.Remove(lstImport.SelectedItem);
            }
            //Shows a message if no track is selected but the button is pressed
            else
            {
                MessageBox.Show("You have not selected a track");
            }
           
        }

        private void btnCancelSetup_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //Opens the file browser for user to select files
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Enables user to select more than one file at once
            openFileDialog1.Multiselect = true;

            //Adds the selected files in to the imported tracks list box
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    lstImport.Items.Add(files[i]);
                }
            }
        }
    }
}

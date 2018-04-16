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
            listImport.Items.Clear();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //Opens the file browser for user to select files
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Enables user to select more than one file at once
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listImport.Items.Add(files[i]);
                }
            }
        }
    }
}

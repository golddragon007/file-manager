using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class NewVDir : Form
    {
        int mainID;

        public int MainID
        {
            get { return mainID; }
        }

        string newDirName;

        public string NewDirName
        {
            get { return newDirName; }
        }

        public NewVDir(VDirs[] pathNames)
        {
            InitializeComponent();

            comboBoxMainDir.Items.AddRange(pathNames);
            comboBoxMainDir.SelectedIndex = 0;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!textBoxNewDirName.Text.Equals(""))
            {
                newDirName = textBoxNewDirName.Text;

                if (comboBoxMainDir.SelectedItem != null)
                {
                    mainID = ((VDirs)comboBoxMainDir.SelectedItem).Id;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;  
                }
                else
                {
                    MessageBox.Show("Please choose from the list!");
                }
            }
            else
            {
                MessageBox.Show("Directory name is empty!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

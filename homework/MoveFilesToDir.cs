using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace homework
{
    public partial class MoveFilesToDir : Form
    {
        int newDirId;

        public int NewDirId
        {
            get { return newDirId; }
        }

        public MoveFilesToDir(VDirs[] dirs, VDirs selected)
        {
            InitializeComponent();

            comboBoxMoveToDir.Items.AddRange(dirs);
            comboBoxMoveToDir.SelectedItem = selected;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (comboBoxMoveToDir.SelectedItem != null)
            {
                this.newDirId = ((VDirs)comboBoxMoveToDir.SelectedItem).Id;
                this.DialogResult = System.Windows.Forms.DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Please select the new destination folder...");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

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

namespace DocumentManager
{
    public partial class MoveVDirs : Form
    {
        int newMainId;

        public int NewMainId
        {
            get { return newMainId; }
        }

        public MoveVDirs(VDirs[] dirs, string moveDir)
        {
            InitializeComponent();

            labelMoveableDir.Text = moveDir;
            comboBoxMoveInto.Items.AddRange(dirs);
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (comboBoxMoveInto.SelectedItem != null)
            {
                this.newMainId = ((VDirs)comboBoxMoveInto.SelectedItem).Id;
                this.DialogResult = System.Windows.Forms.DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("You need to select a target directory!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

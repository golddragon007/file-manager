using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManager
{
    public partial class RenameVDir : Form
    {
        string newName;

        public string NewName
        {
            get { return newName; }
        }

        public RenameVDir(string name)
        {
            InitializeComponent();
            textBoxNewName.Text = name;
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (!textBoxNewName.Text.Equals(""))
            {
                newName = textBoxNewName.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK; 
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

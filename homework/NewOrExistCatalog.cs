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
    public partial class NewOrExistCatalog : Form
    {
        string path;

        public string Path
        {
            get { return path; }
        }

        public NewOrExistCatalog()
        {
            InitializeComponent();

            this.path = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialogForCatalog.InitialDirectory = Environment.CurrentDirectory;
            if (saveFileDialogForCatalog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialogForCatalog.FileName.EndsWith(".dmdb"))
                {
                    path = saveFileDialogForCatalog.FileName;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK; 
                }
                else
                {
                    MessageBox.Show("Please select a filename with the '.dmdb' extension");
                }
            }
        }

        private void buttonExistCatalog_Click(object sender, EventArgs e)
        {
            openFileDialogForCatalog.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialogForCatalog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialogForCatalog.FileName.EndsWith(".dmdb"))
                {
                    path = openFileDialogForCatalog.FileName;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Please select a filename with the '.dmdb' extension");
                }
            }
        }
    }
}

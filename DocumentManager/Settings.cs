using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManager
{
    public partial class Settings : Form
    {
        int selected;

        public int Selected
        {
            get { return selected; }
        }

        string customTypes;

        public string CustomTypes
        {
            get { return customTypes; }
        }

        public Settings(int selected, string customTypes)
        {
            InitializeComponent();
            this.selected = selected;
            this.customTypes = customTypes;

            switch (selected)
            {
                case 1:
                    radioButtonDocument.Checked = true;
                    textBoxCustom.Text = Regex.Match(radioButtonDocument.Text, @"\((.*)\)").Value.Replace("/", ",").Replace(", ", ",");
                    textBoxCustom.Text = textBoxCustom.Text.Substring(1, textBoxCustom.Text.Length - 2);
                    break;
                case 2:
                    radioButtonPicture.Checked = true;
                    textBoxCustom.Text = Regex.Match(radioButtonPicture.Text, @"\((.*)\)").Value.Replace("/", ",").Replace(", ", ",");
                    textBoxCustom.Text = textBoxCustom.Text.Substring(1, textBoxCustom.Text.Length - 2);
                    break;
                case 3:
                    radioButtonAudio.Checked = true;
                    textBoxCustom.Text = Regex.Match(radioButtonAudio.Text, @"\((.*)\)").Value.Replace("/", ",").Replace(", ", ",");
                    textBoxCustom.Text = textBoxCustom.Text.Substring(1, textBoxCustom.Text.Length - 2);
                    break;
                case 4:
                    radioButtonVideo.Checked = true;
                    textBoxCustom.Text = Regex.Match(radioButtonVideo.Text, @"\((.*)\)").Value.Replace("/", ",").Replace(", ", ",");
                    textBoxCustom.Text = textBoxCustom.Text.Substring(1, textBoxCustom.Text.Length - 2);
                    break;
                case 5:
                    radioButtonExecuteable.Checked = true;
                    textBoxCustom.Text = Regex.Match(radioButtonExecuteable.Text, @"\((.*)\)").Value.Replace("/", ",").Replace(", ", ",");
                    textBoxCustom.Text = textBoxCustom.Text.Substring(1, textBoxCustom.Text.Length - 2);
                    break;
                case 6:
                    radioButtonCustom.Checked = true;
                    textBoxCustom.Text = customTypes;
                    break;
                default:
                    radioButtonDocument.Checked = true;
                    textBoxCustom.Text = Regex.Match(radioButtonDocument.Text, @"\((.*)\)").Value.Replace("/", ",").Replace(", ", ",");
                    textBoxCustom.Text = textBoxCustom.Text.Substring(1, textBoxCustom.Text.Length - 2);
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            RadioButton selectedRB = groupBoxFormat.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            
            if (Convert.ToInt32(selectedRB.Tag) != 6 || Convert.ToInt32(selectedRB.Tag) == 6 && !textBoxCustom.Text.Trim().Equals(""))
            {
                selected = Convert.ToInt32(selectedRB.Tag);
                if (selected == 6)
                {
                    customTypes = textBoxCustom.Text.Trim().Replace(", ", ",").Replace("; ", ",");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please give a valid value!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void radioButtonDocument_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked == true)
            {
                if (Convert.ToInt32(rb.Tag) == 6)
                {
                    textBoxCustom.ReadOnly = false;
                }
                else
                {
                    textBoxCustom.Text = Regex.Match(rb.Text, @"\((.*)\)").Value.Replace("/", ",").Replace(", ", ",");
                    textBoxCustom.Text = textBoxCustom.Text.Substring(1, textBoxCustom.Text.Length - 2);
                    textBoxCustom.ReadOnly = true;
                } 
            }
        }
    }
}

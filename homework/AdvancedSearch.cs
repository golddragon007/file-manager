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
    public partial class AdvancedSearch : Form
    {

        private ASCriteria criteria;

        public ASCriteria Criteria
        {
            get { return criteria; }
        }

        public AdvancedSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxYearFrom.ForeColor = Color.White;

            int yearFrom = 0;
            int yearTo = 0;
            DateTime addedFrom = DateTime.MinValue;
            DateTime addedTo = DateTime.MinValue;
            string errorMessage = "";

            if ((textBoxYearFrom.Text != "") && !(Int32.TryParse(textBoxYearFrom.Text, out yearFrom)))
            {
                errorMessage += "Not valid year format. (Year: From:) Please give an integer.\n";
                textBoxYearFrom.ForeColor = Color.Red;
            }

            if ((textBoxYearTo.Text != "") && !(Int32.TryParse(textBoxYearTo.Text, out yearTo)))
            {
                errorMessage += "Not valid year format. (Year: To:) Please give an integer.\n";
                textBoxYearTo.ForeColor = Color.Red;
            }

            if ((textBoxAddedFrom.Text != "") && !(DateTime.TryParse(textBoxAddedFrom.Text, out addedFrom)))
            {
                errorMessage += "Not valid date format. (Added: From:) Please give a date.\n";
                textBoxAddedFrom.ForeColor = Color.Red;
            }

            if ((textBoxAddedTo.Text != "") && !(DateTime.TryParse(textBoxAddedTo.Text, out addedTo)))
            {
                errorMessage += "Not valid date format. (Added: To:) Please give a date.\n";
                textBoxAddedTo.ForeColor = Color.Red;
            }

            if (errorMessage == "")
            {
                criteria = new ASCriteria(textBoxTitle.Text, textBoxAuthor.Text, yearFrom, yearTo, textBoxDOI.Text, textBoxTags.Text,
                    addedFrom, addedTo, textBoxNotes.Text, checkBoxFavourite.Checked);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}

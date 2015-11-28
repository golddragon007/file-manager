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
    public partial class AdvancedSearch : Form
    {

        private ASCriteria criteria;

        public ASCriteria Criteria
        {
            get { return criteria; }
        }

        public AdvancedSearch(ASCriteria criteria)
        {
            InitializeComponent();

            if (criteria != null)
            {
                if (criteria.AddedFrom > DateTime.MinValue)
                {
                    textBoxAddedFrom.Text = criteria.AddedFrom.ToString(); 
                }
                if (criteria.AddedTo > DateTime.MinValue)
                {
                    textBoxAddedTo.Text = criteria.AddedTo.ToString(); 
                }
                textBoxAuthor.Text = criteria.Author;
                textBoxDOI.Text = criteria.Doi;
                if (criteria.Favorite == 0)
                {
                    radioButtonNo.Checked = true;
                }
                else if (criteria.Favorite == 1)
                {
                    radioButtonYes.Checked = true;
                }
                textBoxNotes.Text = criteria.Notes;
                textBoxTags.Text = criteria.Tags;
                textBoxTitle.Text = criteria.Title;
                if (criteria.YearFrom > 0)
                {
                    textBoxYearFrom.Text = criteria.YearFrom.ToString(); 
                }
                if (criteria.YearTo > 0)
                {
                    textBoxYearTo.Text = criteria.YearTo.ToString(); 
                }
            }
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
                int favorite = 2;

                if (radioButtonNo.Checked)
                {
                    favorite = 0;
                }
                else if (radioButtonYes.Checked)
                {
                    favorite = 1;
                }

                criteria = new ASCriteria(textBoxTitle.Text, textBoxAuthor.Text, yearFrom, yearTo, textBoxDOI.Text, textBoxTags.Text,
                    addedFrom, addedTo, textBoxNotes.Text, favorite);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}

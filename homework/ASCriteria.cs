using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class ASCriteria
    {
        private string title;
        private string author;
        private int yearFrom;
        private int yearTo;
        private string doi;
        private string tags;
        private DateTime addedFrom;
        private DateTime addedTo;
        private string notes;
        private bool favorite;

        public ASCriteria(string in_title, string in_author, int in_yearFrom, int in_yearTo, string in_doi,
            string in_tags, DateTime in_addedFrom, DateTime in_addedTo, string in_notes, bool in_favorite) 
        {
            this.title = in_title;
            this.author = in_author;
            this.yearFrom = in_yearFrom;
            this.yearTo = in_yearTo;
            this.doi = in_doi;
            this.tags = in_tags;
            this.addedFrom = in_addedFrom;
            this.addedTo = in_addedTo;
            this.notes = in_notes;
            this.favorite = in_favorite;
        }

        public string Title 
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int YearFrom
        {
            get { return yearFrom; }
            set { yearFrom = value; }
        }

        public int YearTo
        {
            get { return yearTo; }
            set { yearTo = value; }
        }

        public string Doi
        {
            get { return doi; }
            set { doi = value; }
        }

        public string Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        public DateTime AddedFrom
        {
            get { return addedFrom; }
            set { addedFrom = value; }
        }

        public DateTime AddedTo
        {
            get { return addedTo; }
            set { addedTo = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public bool Favorite
        {
            get { return favorite; }
            set { favorite = value; }
        }
    }
}

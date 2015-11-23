using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Files
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        private string doi;

        public string Doi
        {
            get { return doi; }
            set { doi = value; }
        }

        private string vdir;

        public string Vdir
        {
            get { return vdir; }
            set { vdir = value; }
        }


        private bool favorite;

        public bool Favorite
        {
            get { return favorite; }
            set { favorite = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        private string added;

        public string Added
        {
            get { return added; }
            set { added = value; }
        }

        private string rread;

        public string Rread
        {
            get { return rread; }
            set { rread = value; }
        }

        private string tags;

        public string Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        public string Size
        {
            get {
                if (File.Exists(location))
	            {
                    FileInfo fi = new FileInfo(location);
                    return fi.Length.ToString();
	            }
                else
                {
                    return "File moved!";
                }
            }
        }

        public string SizeUnit
        {
            get
            {
                if (File.Exists(location))
                {
                    FileInfo fi = new FileInfo(location);
                    return GetBytesReadable(fi.Length);
                }
                else
                {
                    return "File moved!";
                }
            }
        }

        // Returns the human-readable file size for an arbitrary, 64-bit file size 
        // The default format is "0.### XB", e.g. "4.2 KB" or "1.434 GB"
        // Function's source: http://stackoverflow.com/questions/281640/how-do-i-get-a-human-readable-file-size-in-bytes-abbreviation-using-net
        public string GetBytesReadable(long i)
        {
            // Get absolute value
            long absolute_i = (i < 0 ? -i : i);
            // Determine the suffix and readable value
            string suffix;
            double readable;
            if (absolute_i >= 0x1000000000000000) // Exabyte
            {
                suffix = "EB";
                readable = (i >> 50);
            }
            else if (absolute_i >= 0x4000000000000) // Petabyte
            {
                suffix = "PB";
                readable = (i >> 40);
            }
            else if (absolute_i >= 0x10000000000) // Terabyte
            {
                suffix = "TB";
                readable = (i >> 30);
            }
            else if (absolute_i >= 0x40000000) // Gigabyte
            {
                suffix = "GB";
                readable = (i >> 20);
            }
            else if (absolute_i >= 0x100000) // Megabyte
            {
                suffix = "MB";
                readable = (i >> 10);
            }
            else if (absolute_i >= 0x400) // Kilobyte
            {
                suffix = "KB";
                readable = i;
            }
            else
            {
                return i.ToString("0 B"); // Byte
            }
            // Divide by 1024 to get fractional value
            readable = (readable / 1024);
            // Return formatted number with suffix
            return readable.ToString("0.### ") + suffix;
        }


        public Files(int id, string title, string author, string year, string doi, string vdir, bool favorite, string type, string tags, string note, string location, string added, string rread)
        {
            this.added = added;
            this.author = author;
            this.doi = doi;
            this.favorite = favorite;
            this.id = id;
            this.location = location;
            this.tags = tags;
            this.note = note;
            this.rread = rread;
            this.title = title;
            this.type = type;
            this.year = year;
            this.vdir = vdir;
        }
    }
}

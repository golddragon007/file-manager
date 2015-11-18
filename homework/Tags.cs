using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Tags
    {
        private int id;

        public int Id
        {
            get { return id; }
        }

        private string name;

        public string Name
        {
            get { return name; }
        }

        public Tags(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}

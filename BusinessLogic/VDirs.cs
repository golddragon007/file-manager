using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class VDirs
    {
        List<VDirs> subdirs;

        public List<VDirs> Subdirs
        {
            get { return subdirs; }
        }

        int id;

        public int Id
        {
            get { return id; }
        }

        string name;

        public string Name
        {
            get { return name; }
        }

        int parentId;

        public int ParentId
        {
            get { return parentId; }
            set { parentId = value; }
        }

        string fullPath;

        public string FullPath
        {
            get { return fullPath; }
            set { fullPath = value; }
        }

        public VDirs(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.subdirs = new List<VDirs>();
        }

        public VDirs(int id, string name, int parentId)
        {
            this.id = id;
            this.name = name;
            this.parentId = parentId;
            this.subdirs = new List<VDirs>();
        }

        public VDirs(int id, string name, int parentId, string fullPath)
        {
            this.id = id;
            this.name = name;
            this.parentId = parentId;
            this.fullPath = fullPath;
            this.subdirs = new List<VDirs>();
        }

        //Returns a child VDir, it search only deph - 1 level.
        public VDirs getSubDirObject(int id)
        {
            foreach (VDirs item in subdirs)
            {
                if (item.id == id)
                {
                    return item;
                }
            }

            return null;
        }

        // Returns a specified child's parent ID. It search only deph - 1 level.
        public int getSubDirObjectParentID(int id)
        {
            foreach (VDirs item in subdirs)
            {
                if (item.id == id)
                {
                    return item.parentId;
                }
            }

            return -1;
        }

        // Add new child.
        public void addNewChild(VDirs child)
        {
            if (child != null)
            {
                this.subdirs.Add(child);
            }
        }

        // Returns the child's number.
        public int getChildCount()
        {
            return this.subdirs.Count;
        }

        public override string ToString()
        {
            return fullPath;
        }
    }
}

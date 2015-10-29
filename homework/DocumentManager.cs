using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Data.SQLite.EF6;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace homework
{
    
    public partial class DocumentManager : Form
    {
        dbManager dbm;

        public DocumentManager()
        {
            InitializeComponent();

            dbm = new dbManager("catalog.fmdb");

            treeViewDirs.SelectedNode = treeViewDirs.Nodes[0];
            listViewRefresh();
            generateCustomVDirs();
        }

        // Build up the Custom dirs.
        private void generateCustomVDirs()
        {
            VDirs allVDirs = dbm.getVDirs();
            treeViewDirs.Nodes[6].Nodes.Clear();
            foreach (VDirs actualItem in allVDirs.Subdirs)
            {
                TreeNode tn = new TreeNode(actualItem.Name, generateCustomVDirsRecursive(actualItem));
                tn.Tag = actualItem;
                treeViewDirs.Nodes[6].Nodes.Add(tn);
            }
        }

        // Build up the Custom dirs. (children)
        private TreeNode[] generateCustomVDirsRecursive(VDirs actualPack)
        {
            if (actualPack != null)
            {
                TreeNode[] tn = new TreeNode[actualPack.Subdirs.Count];
                int actIndex = 0;
                foreach (VDirs actualItem in actualPack.Subdirs)
                {
                    TreeNode tnsub = new TreeNode(actualItem.Name, generateCustomVDirsRecursive(actualItem));
                    tnsub.Tag = actualItem;
                    tn[actIndex] = tnsub;
                    actIndex++;
                }
                return tn; 
            }
            return null;
        }

        private void treeViewDirs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewRefresh();
        }

        private TreeNode FindRootNode(TreeNode treeNode)
        {
            while (treeNode.Parent != null)
            {
                treeNode = treeNode.Parent;
            }
            return treeNode;
        }

        private void listViewRefresh()
        {
            TreeNode selected = treeViewDirs.SelectedNode;

            if (selected != null)
            {
                List<Files> files = null;
                TreeNode rtn = FindRootNode(selected);

                //MessageBox.Show(selected.FullPath + " > " + rtn.Index.ToString() + " : " + selected.Level.ToString() + " : " + selected.Index.ToString());

                if (selected.Level.ToString().Equals("0") && rtn.Index.ToString().Equals("0"))
                {
                    files = dbm.getAllFiles();
                }
                else if (selected.Level.ToString().Equals("0") && rtn.Index.ToString().Equals("1"))
                {
                    files = dbm.getAllFilesReceantlyAdded();
                }
                else if (selected.Level.ToString().Equals("0") && rtn.Index.ToString().Equals("2"))
                {
                    files = dbm.getAllFilesReceantlyRead();
                }
                else if (selected.Level.ToString().Equals("0") && rtn.Index.ToString().Equals("3"))
                {
                    files = dbm.getAllFilesFavorite();
                }
                else if (selected.Level.ToString().Equals("0") && rtn.Index.ToString().Equals("4"))
                {
                    files = new List<Files>();
                }
                else if (rtn.Index.ToString().Equals("4"))
                {
                    // TODO (handle all from authors)
                    files = new List<Files>();
                }
                else if (selected.Level.ToString().Equals("0") && rtn.Index.ToString().Equals("5"))
                {
                    files = dbm.getAllFilesWhichAreNotInADir();
                }
                else if (selected.Level.ToString().Equals("0") && rtn.Index.ToString().Equals("6"))
                {
                    files = new List<Files>();
                }
                else if (rtn.Index.ToString().Equals("6"))
                {
                    files = dbm.getAllFilesFromDir(((VDirs)selected.Tag).Id);
                }

                if (files != null)
                {
                    listViewDocs.Items.Clear();

                    foreach (Files fileItem in files)
                    {
                        ListViewItem lvi = new ListViewItem(fileItem.Favorite.ToString());
                        lvi.SubItems.Add(fileItem.Type);
                        lvi.SubItems.Add(fileItem.Title);
                        lvi.SubItems.Add(fileItem.Author);
                        lvi.SubItems.Add(fileItem.Year);
                        lvi.SubItems.Add(fileItem.Doi);
                        lvi.SubItems.Add(fileItem.Added);

                        lvi.Tag = fileItem;

                        listViewDocs.Items.Add(lvi);
                    }
                }
            }
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            string ext = dbm.getFileExtensions();

            string[] extexp = ext.Split(',');

            string ext2 = "";

            foreach (string extItem in extexp)
            {
                if (ext2.Equals(""))
                {
                    ext2 = "*." + extItem.Trim();
                }
                else
                {
                    ext2 += ";*." + extItem.Trim();
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Allowed file extension formats (" + ext + ")|" + ext2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbm.addFiles(ofd.FileNames);
                listViewRefresh();
            }
        }

        private void listViewDocs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewDocs.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    if (listViewDocs.SelectedItems[0] != null)
                    {
                        Files f = (Files)listViewDocs.SelectedItems[0].Tag;
                        int index = contextMenuStripDocList.Items.IndexOfKey("addToFavoriteToolStripMenuItem");
                        ((ToolStripMenuItem)contextMenuStripDocList.Items[index]).Checked = f.Favorite;
                    }
                    contextMenuStripDocList.Show(Cursor.Position);
                }
            } 
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = listViewDocs.SelectedItems;

            string[] ids = new string[selectedItems.Count];
            int i = 0;
            foreach (ListViewItem item in selectedItems)
            {
                ids[i] = ((Files) item.Tag).Id.ToString();
                listViewDocs.Items.Remove(item);
                i++;
            }

            dbm.removeFiles(ids);

            listViewDocs.Refresh();
        }

        private void listViewDocs_Click(object sender, EventArgs e)
        {
            if (listViewDocs.SelectedItems.Count == 1)
            {
                Files selectedFiles = (Files)listViewDocs.SelectedItems[0].Tag;

                textBoxAuthor.Text = selectedFiles.Author;
                textBoxDOI.Text = selectedFiles.Doi;
                textBoxNotes.Text = selectedFiles.Note;
                textBoxTags.Text = selectedFiles.Tags;
                textBoxTitle.Text = selectedFiles.Title;
                textBoxYear.Text = selectedFiles.Year;
                checkBoxFavourite.Checked = selectedFiles.Favorite;
                labelPathValue.Text = selectedFiles.Location;
                labelSizeValue.Text = selectedFiles.SizeUnit;
                labelAddedValue.Text = selectedFiles.Added;
            }
            else
            {
                textBoxAuthor.Text = "";
                textBoxDOI.Text = "";
                textBoxNotes.Text = "";
                textBoxTags.Text = "";
                textBoxTitle.Text = "";
                textBoxYear.Text = "";
                checkBoxFavourite.Checked = false;
                labelPathValue.Text = "";
                labelSizeValue.Text = "";
                labelAddedValue.Text = "";
            }
            textBoxAuthor.ReadOnly = true;
            textBoxDOI.ReadOnly = true;
            textBoxNotes.ReadOnly = true;
            textBoxTags.ReadOnly = true;
            textBoxTitle.ReadOnly = true;
            textBoxYear.ReadOnly = true;
            checkBoxFavourite.Enabled = false;
        }

        private void listViewDocs_DoubleClick(object sender, EventArgs e)
        {
            if (listViewDocs.SelectedItems.Count == 1)
            {
                Files selectedFiles = (Files)listViewDocs.SelectedItems[0].Tag;
                System.Diagnostics.Process.Start(selectedFiles.Location);
                dbm.setReceantlyReadNow(selectedFiles.Id);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewDocs.SelectedItems.Count > 0 && listViewDocs.SelectedItems.Count < 10)
            {
                foreach (ListViewItem selItem in listViewDocs.SelectedItems)
                {
                    Files selectedFiles = (Files)selItem.Tag;
                    System.Diagnostics.Process.Start(selectedFiles.Location);
                    dbm.setReceantlyReadNow(selectedFiles.Id);
                }
            }
            else if (listViewDocs.SelectedItems.Count >= 10) {
                if (MessageBox.Show("Are you sure you want to open all the " + listViewDocs.SelectedItems.Count + " files? It can take a few sec...", "Are you sure...", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (ListViewItem selItem in listViewDocs.SelectedItems)
                    {
                        Files selectedFiles = (Files)selItem.Tag;
                        System.Diagnostics.Process.Start(selectedFiles.Location);
                        dbm.setReceantlyReadNow(selectedFiles.Id);
                    }
                }
            }
        }

        private void DocumentManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbm.closeDbConn();
        }

        private void buttonSimpleSearch_Click(object sender, EventArgs e)
        {
            List<Files> files = dbm.simpleSearch(textBoxSimpleSearch.Text);

            if (files != null || files.Count == 0)
            {
                listViewDocs.Items.Clear();

                foreach (Files fileItem in files)
                {
                    ListViewItem lvi = new ListViewItem(fileItem.Favorite.ToString());
                    lvi.SubItems.Add(fileItem.Type);
                    lvi.SubItems.Add(fileItem.Title);
                    lvi.SubItems.Add(fileItem.Author);
                    lvi.SubItems.Add(fileItem.Year);
                    lvi.SubItems.Add(fileItem.Doi);
                    lvi.SubItems.Add(fileItem.Added);

                    lvi.Tag = fileItem;

                    listViewDocs.Items.Add(lvi);
                }

                treeViewDirs.SelectedNode = null;
            }
            else
            {
                MessageBox.Show("No resoults found!");
            }
        }

        // Get full paths in recursive mode.
        private void getAllFullPath(TreeNode tn, ref List<VDirs> fullPaths)
        {
            if (tn != null)
            {
                foreach (TreeNode tni in tn.Nodes)
                {
                    VDirs tmp = (VDirs)tni.Tag;
                    tmp.FullPath = tni.FullPath;
                    fullPaths.Add(tmp);
                    getAllFullPath(tni, ref fullPaths);
                }
            }
        }

        private void buttonCreateFolder_Click(object sender, EventArgs e)
        {
            List<VDirs> fullPaths = new List<VDirs>();

            fullPaths.Add(new VDirs(-1, treeViewDirs.Nodes[6].Text, -1, treeViewDirs.Nodes[6].FullPath));
            getAllFullPath(treeViewDirs.Nodes[6], ref fullPaths);

            NewVDir nvdw = new NewVDir(fullPaths.ToArray());
            if (nvdw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dbm.addVdirs(nvdw.MainID, nvdw.NewDirName);

                generateCustomVDirs();
            }
        }

        private void treeViewDirs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node.
                treeViewDirs.SelectedNode = treeViewDirs.GetNodeAt(e.X, e.Y);

                if (treeViewDirs.SelectedNode != null)
                {
                    TreeNode rtn = FindRootNode(treeViewDirs.SelectedNode);

                    if (treeViewDirs.SelectedNode.Level == 0 || rtn.Index == 4)
                    {
                        // Disabling all dir function on root items.
                        addNewDirToolStripMenuItem.Enabled = false;
                        moveDirToolStripMenuItem.Enabled = false;
                        deleteDirToolStripMenuItem.Enabled = false;
                        contextMenuStripDirs.Show(treeViewDirs, e.Location);
                    }
                    else
                    {
                        // Enabling all dir functions on all non-root items.
                        addNewDirToolStripMenuItem.Enabled = true;
                        moveDirToolStripMenuItem.Enabled = true;
                        deleteDirToolStripMenuItem.Enabled = true;
                        contextMenuStripDirs.Show(treeViewDirs, e.Location);
                    }
                }
            } 
        }

        private void addNewDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<VDirs> fullPaths = new List<VDirs>();

            fullPaths.Add(new VDirs(-1, treeViewDirs.Nodes[6].Text, -1, treeViewDirs.Nodes[6].FullPath));
            getAllFullPath(treeViewDirs.Nodes[6], ref fullPaths);

            VDirs vds = (VDirs)treeViewDirs.SelectedNode.Tag;
            vds.FullPath = treeViewDirs.SelectedNode.FullPath;

            NewVDir nvdw = new NewVDir(fullPaths.ToArray(), vds);
            if (nvdw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dbm.addVdirs(nvdw.MainID, nvdw.NewDirName);

                generateCustomVDirs();
            }
        }

        private void moveDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<VDirs> fullPaths = new List<VDirs>();

            fullPaths.Add(new VDirs(-1, treeViewDirs.Nodes[6].Text, -1, treeViewDirs.Nodes[6].FullPath));
            getAllFullPath(treeViewDirs.Nodes[6], ref fullPaths);

            VDirs vds = (VDirs)treeViewDirs.SelectedNode.Tag;
            vds.FullPath = treeViewDirs.SelectedNode.FullPath;

            MoveVDirs mvdw = new MoveVDirs(fullPaths.ToArray(), vds.FullPath);
            if (mvdw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dbm.moveVdirs(vds.Id, mvdw.NewMainId);

                generateCustomVDirs();
            }
        }

        private void deleteDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VDirs vds = (VDirs)treeViewDirs.SelectedNode.Tag;
            if (MessageBox.Show("Are you sure you want to delete this and the sub directories?", "Delete confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                dbm.removeVdirs(vds.Id);

                generateCustomVDirs();
            }
        }

        private void deleteALLDirsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete ALL directories from the root?", "Delete all directories?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                dbm.removeAllVdirs();

                generateCustomVDirs();
            }
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewDirs.ExpandAll();
        }

        private void colapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewDirs.CollapseAll();
        }

        private void addToFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewDocs.SelectedItems)
            {
                dbm.toggleToFavorite(((Files)item.Tag).Id, !addToFavoriteToolStripMenuItem.Checked);
            }
            listViewRefresh();
        }

        private void renameDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VDirs selected = (VDirs)treeViewDirs.SelectedNode.Tag;

            RenameVDir rvdw = new RenameVDir(selected.Name);
            if (rvdw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dbm.renameVdirs(selected.Id, rvdw.NewName);
            }

            generateCustomVDirs();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (listViewDocs.SelectedItems.Count != 0)
            {
                List<VDirs> fullPaths = new List<VDirs>();

                fullPaths.Add(new VDirs(-1, "No directory", -1, "<<No directory>>"));
                getAllFullPath(treeViewDirs.Nodes[6], ref fullPaths);

                Files selectedFile = ((Files)listViewDocs.SelectedItems[0].Tag);
                VDirs[] fullPathsArray = fullPaths.ToArray();
                VDirs selectedVdir = null;

                if (selectedFile.Vdir != null)
                {
                    foreach (VDirs currentVdir in fullPathsArray)
                    {
                        if (currentVdir.Id.ToString().Equals(selectedFile.Vdir))
                        {
                            selectedVdir = currentVdir;
                            break;
                        }
                    }
                }

                MoveFilesToDir mftdw = new MoveFilesToDir(fullPathsArray, (selectedVdir == null ? fullPathsArray[0] : selectedVdir));
                if (mftdw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dbm.moveFileToDir(selectedFile.Id, mftdw.NewDirId);

                    listViewRefresh();
                } 
            }
        }
    }
}

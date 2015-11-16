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
        Boolean editable;
        Files displayedFile;
        int selectedFileType;
        private ListViewColumnSorter lvwColumnSorter;

        public DocumentManager()
        {
            InitializeComponent();

            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewDocs.ListViewItemSorter = lvwColumnSorter;

            dbm = new dbManager("catalog.fmdb");
            editable = false;

            this.selectedFileType = dbm.getSelectedFileTypeExtensions();

            treeViewDirs.SelectedNode = treeViewDirs.Nodes[0];
            listViewRefresh();
            generateCustomVDirs();
            refreshTags();
        }

        // Refreshing tags in treeview.
        private void refreshTags()
        {
            List<Tags> tags = dbm.getTags();
            treeViewDirs.Nodes[6].Nodes.Clear();

            foreach (Tags tag in tags)
            {
                TreeNode tn = new TreeNode(tag.Name);
                tn.Tag = tag;
                treeViewDirs.Nodes[6].Nodes.Add(tn);
            }
        }

        // Build up the Custom dirs.
        private void generateCustomVDirs()
        {
            VDirs allVDirs = dbm.getVDirs();
            treeViewDirs.Nodes[7].Nodes.Clear();
            foreach (VDirs actualItem in allVDirs.Subdirs)
            {
                TreeNode tn = new TreeNode(actualItem.Name, generateCustomVDirsRecursive(actualItem));
                tn.Tag = actualItem;
                treeViewDirs.Nodes[7].Nodes.Add(tn);
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
                else if (selected.Level.ToString().Equals("0") && rtn.Index.ToString().Equals("7"))
                {
                    files = new List<Files>();
                }
                else if (rtn.Index.ToString().Equals("6"))
                {
                    files = dbm.getAllFilesByTag(((Tags)selected.Tag).Id);
                }
                else if (rtn.Index.ToString().Equals("7"))
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
            string ext = dbm.getFileExtensions(selectedFileType);

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

            fullPaths.Add(new VDirs(-1, treeViewDirs.Nodes[7].Text, -1, treeViewDirs.Nodes[7].FullPath));
            getAllFullPath(treeViewDirs.Nodes[7], ref fullPaths);

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

            fullPaths.Add(new VDirs(-1, treeViewDirs.Nodes[7].Text, -1, treeViewDirs.Nodes[7].FullPath));
            getAllFullPath(treeViewDirs.Nodes[7], ref fullPaths);

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

            fullPaths.Add(new VDirs(-1, treeViewDirs.Nodes[7].Text, -1, treeViewDirs.Nodes[7].FullPath));
            getAllFullPath(treeViewDirs.Nodes[7], ref fullPaths);

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
                getAllFullPath(treeViewDirs.Nodes[7], ref fullPaths);

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

        /// <summary>
        /// Makes the text boxes editable or not editable and changes the text on the buttonEdit.
        /// </summary>
        /// <param name="setEdit"></param>
        private void setEditable(Boolean setEdit) 
        {
            editable = setEdit;
            textBoxTitle.Enabled = setEdit;
            textBoxAuthor.Enabled = setEdit;
            textBoxYear.Enabled = setEdit;
            textBoxDOI.Enabled = setEdit;
            textBoxTags.Enabled = setEdit;
            checkBoxFavourite.Enabled = setEdit;
            textBoxTitle.ReadOnly = !setEdit;
            textBoxAuthor.ReadOnly = !setEdit;
            textBoxYear.ReadOnly = !setEdit;
            textBoxDOI.ReadOnly = !setEdit;
            textBoxTags.ReadOnly = !setEdit;

            if (setEdit)
                buttonEdit.Text = "Save";
            else
                buttonEdit.Text = "Edit";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (editable)
            {
                setEditable(false);
                displayedFile.Title = textBoxTitle.Text;
                displayedFile.Author = textBoxAuthor.Text;
                displayedFile.Year = textBoxYear.Text;
                displayedFile.Doi = textBoxDOI.Text;
                displayedFile.Tags = textBoxTags.Text;
                displayedFile.Favorite = checkBoxFavourite.Checked;
                dbm.saveModifiedFileRecords(displayedFile);
                refreshTags();
            }
            else
            {
                setEditable(true);
            }

        }

        /// <summary>
        /// Displays properties of the selected file on the right side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            setEditable(false);
            displayedFile = (Files)listViewDocs.SelectedItems[0].Tag;
            textBoxTitle.Text = displayedFile.Title;
            textBoxAuthor.Text = displayedFile.Author;
            textBoxYear.Text = displayedFile.Year;
            textBoxDOI.Text = displayedFile.Doi;
            textBoxTags.Text = displayedFile.Tags;
            checkBoxFavourite.Checked = displayedFile.Favorite;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings sw = new Settings(selectedFileType, dbm.getFileExtensions(6));

            if (sw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedFileType = sw.Selected;
                dbm.setSelectedFileTypeExtensions(selectedFileType);
                dbm.setCustomFileExtensions(sw.CustomTypes);
            }
        }

        private void DocumentManager_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void DocumentManager_DragDrop(object sender, DragEventArgs e)
        {
            List<string> paths = new List<string>();
            List<string> pathsUseable = new List<string>();
            
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            // Get all files/dirs which was dropped in the app
            foreach (string file in files)
            {
                AddFileFromPaths(ref paths, file);
            }

            string fileTypes = dbm.getFileExtensions(selectedFileType);

            string[] extexp = fileTypes.Split(',');

            string ext = "";

            foreach (string extItem in extexp)
            {
                ext += ";." + extItem.Trim();
            }
            ext += ";";

            // Remove non used files.
            foreach (string path in paths)
            {
                string fext = Path.GetExtension(path);
                if (ext.Contains(";" + fext + ";"))
                {
                    pathsUseable.Add(path);
                }
            }

            dbm.addFiles(pathsUseable.ToArray());
            listViewRefresh();

            paths.Clear();
            pathsUseable.Clear();
        }

        // Recursive get all files from a directory.
        private void AddFileFromPaths(ref List<string> paths, string fileOrDir)
        {
            if (File.Exists(fileOrDir))
            {
                paths.Add(fileOrDir);
            }
            else if (Directory.Exists(fileOrDir))
            {
                foreach (string dir in Directory.GetDirectories(fileOrDir))
                {
                    AddFileFromPaths(ref paths, dir);
                }

                foreach (string file in Directory.GetFiles(fileOrDir))
                {
                    paths.Add(file);
                }
            }
        }

        private void listViewDocs_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeViewDirs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                DocumentManager_DragEnter(sender, e);
            }
        }

        private void treeViewDirs_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                /*var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                MessageBox.Show(item.Text);*/
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                if (DestinationNode != null)
                {
                    TreeNode rtn = FindRootNode(DestinationNode);
                    if (rtn.Index == 7 && DestinationNode.Level > 0)
                    {
                        foreach (ListViewItem item in listViewDocs.SelectedItems)
                        {
                            dbm.moveFileToDir(((Files)item.Tag).Id, ((VDirs)DestinationNode.Tag).Id);
                        }

                        listViewRefresh();
                    }
                    else
                    {
                        // If wrong treeView item.
                        MessageBox.Show("You need to drop into a Custom Directory's chield!");
                    }
                }
                else
                {
                    // If there's no treeView item.
                    MessageBox.Show("You need to drop into a Custom Directory's chield!");
                }
            }
            else
            {
                DocumentManager_DragDrop(sender, e);
            }
        }

        private void listViewDocs_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listViewDocs.Sort();
        }

        private void aboutDocumentManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aw = new About();
            aw.ShowDialog();
        }
    }
}

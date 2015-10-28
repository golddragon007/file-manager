﻿using System;
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
            VDirs allVDirs = dbm.getVDirs();
            generateCustomVDirs(allVDirs);
        }

        // Build up the Custom dirs.
        private void generateCustomVDirs(VDirs actualPack)
        {
            treeViewDirs.Nodes[6].Nodes.Clear();
            foreach (VDirs actualItem in actualPack.Subdirs)
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

                MessageBox.Show(selected.FullPath + " > " + rtn.Index.ToString() + " : " + selected.Level.ToString() + " : " + selected.Index.ToString());

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

                treeViewDirs.SelectedNode = null;
            }
            else
            {
                MessageBox.Show("No resoults found!");
            }
        }
    }
}

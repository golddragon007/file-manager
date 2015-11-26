namespace homework
{
    partial class DocumentManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All Documents");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Recently Added");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Recently Read");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Favorites");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Author(s)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Unsorted");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tags");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Custom Directories");
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAnotherCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.createDiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDocumentManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSimpleSearch = new System.Windows.Forms.Button();
            this.buttonCreateFolder = new System.Windows.Forms.Button();
            this.treeViewDirs = new System.Windows.Forms.TreeView();
            this.listViewDocs = new System.Windows.Forms.ListView();
            this.favorite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.added = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdvancedSearch = new System.Windows.Forms.Button();
            this.Notes = new System.Windows.Forms.TabPage();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.Details = new System.Windows.Forms.TabPage();
            this.labelSizeValue = new System.Windows.Forms.Label();
            this.labelAddedValue = new System.Windows.Forms.Label();
            this.labelPathValue = new System.Windows.Forms.Label();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.labelTags = new System.Windows.Forms.Label();
            this.checkBoxFavourite = new System.Windows.Forms.CheckBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.labelFavorite = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelAdded = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxDOI = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelDOI = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.buttonAddDictionary = new System.Windows.Forms.Button();
            this.contextMenuStripDocList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripDirs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteALLDirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxSimpleSearch = new wmgCMS.WaterMarkTextBox();
            this.menuStripMain.SuspendLayout();
            this.Notes.SuspendLayout();
            this.Details.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStripDocList.SuspendLayout();
            this.contextMenuStripDirs.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAnotherCatalogToolStripMenuItem,
            this.toolStripSeparator5,
            this.addFileToolStripMenuItem,
            this.addDictionaryToolStripMenuItem,
            this.toolStripSeparator4,
            this.createDiToolStripMenuItem,
            this.toolStripSeparator3,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAnotherCatalogToolStripMenuItem
            // 
            this.openAnotherCatalogToolStripMenuItem.Name = "openAnotherCatalogToolStripMenuItem";
            this.openAnotherCatalogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openAnotherCatalogToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.openAnotherCatalogToolStripMenuItem.Text = "Open Another Catalog";
            this.openAnotherCatalogToolStripMenuItem.Click += new System.EventHandler(this.openAnotherCatalogToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(233, 6);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // addDictionaryToolStripMenuItem
            // 
            this.addDictionaryToolStripMenuItem.Name = "addDictionaryToolStripMenuItem";
            this.addDictionaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.addDictionaryToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.addDictionaryToolStripMenuItem.Text = "Add Folder";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(233, 6);
            // 
            // createDiToolStripMenuItem
            // 
            this.createDiToolStripMenuItem.Name = "createDiToolStripMenuItem";
            this.createDiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createDiToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.createDiToolStripMenuItem.Text = "Create Virtual Folder";
            this.createDiToolStripMenuItem.Click += new System.EventHandler(this.buttonCreateFolder_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(233, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(982, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutDocumentManagerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutDocumentManagerToolStripMenuItem
            // 
            this.aboutDocumentManagerToolStripMenuItem.Name = "aboutDocumentManagerToolStripMenuItem";
            this.aboutDocumentManagerToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.aboutDocumentManagerToolStripMenuItem.Text = "About Document Manager";
            this.aboutDocumentManagerToolStripMenuItem.Click += new System.EventHandler(this.aboutDocumentManagerToolStripMenuItem_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(598, 30);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 13);
            this.labelSearch.TabIndex = 3000;
            this.labelSearch.Text = "Simple Search:";
            // 
            // buttonSimpleSearch
            // 
            this.buttonSimpleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSimpleSearch.Location = new System.Drawing.Point(820, 25);
            this.buttonSimpleSearch.Name = "buttonSimpleSearch";
            this.buttonSimpleSearch.Size = new System.Drawing.Size(31, 23);
            this.buttonSimpleSearch.TabIndex = 23;
            this.buttonSimpleSearch.Text = "OK";
            this.buttonSimpleSearch.UseVisualStyleBackColor = true;
            this.buttonSimpleSearch.Click += new System.EventHandler(this.buttonSimpleSearch_Click);
            // 
            // buttonCreateFolder
            // 
            this.buttonCreateFolder.Location = new System.Drawing.Point(12, 54);
            this.buttonCreateFolder.Name = "buttonCreateFolder";
            this.buttonCreateFolder.Size = new System.Drawing.Size(93, 23);
            this.buttonCreateFolder.TabIndex = 3;
            this.buttonCreateFolder.Text = "Create Folder";
            this.buttonCreateFolder.UseVisualStyleBackColor = true;
            this.buttonCreateFolder.Click += new System.EventHandler(this.buttonCreateFolder_Click);
            // 
            // treeViewDirs
            // 
            this.treeViewDirs.AllowDrop = true;
            this.treeViewDirs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewDirs.HideSelection = false;
            this.treeViewDirs.Location = new System.Drawing.Point(12, 86);
            this.treeViewDirs.Name = "treeViewDirs";
            treeNode1.Name = "AllDocuments";
            treeNode1.Text = "All Documents";
            treeNode2.Name = "RecentlyAdded";
            treeNode2.Text = "Recently Added";
            treeNode3.Name = "RecentlyRead";
            treeNode3.Text = "Recently Read";
            treeNode4.Name = "Favorites";
            treeNode4.Text = "Favorites";
            treeNode5.Name = "Authors";
            treeNode5.Text = "Author(s)";
            treeNode6.Name = "Unsorted";
            treeNode6.Text = "Unsorted";
            treeNode7.Name = "Tags";
            treeNode7.Text = "Tags";
            treeNode8.Name = "CustomDirs";
            treeNode8.Text = "Custom Directories";
            this.treeViewDirs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeViewDirs.Size = new System.Drawing.Size(208, 377);
            this.treeViewDirs.TabIndex = 4;
            this.treeViewDirs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDirs_AfterSelect);
            this.treeViewDirs.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewDirs_DragDrop);
            this.treeViewDirs.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewDirs_DragEnter);
            this.treeViewDirs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewDirs_KeyDown);
            this.treeViewDirs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewDirs_MouseClick);
            // 
            // listViewDocs
            // 
            this.listViewDocs.AllowDrop = true;
            this.listViewDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDocs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.favorite,
            this.type,
            this.title,
            this.author,
            this.year,
            this.doi,
            this.added});
            this.listViewDocs.FullRowSelect = true;
            this.listViewDocs.Location = new System.Drawing.Point(229, 49);
            this.listViewDocs.Name = "listViewDocs";
            this.listViewDocs.Size = new System.Drawing.Size(441, 414);
            this.listViewDocs.TabIndex = 5;
            this.listViewDocs.UseCompatibleStateImageBehavior = false;
            this.listViewDocs.View = System.Windows.Forms.View.Details;
            this.listViewDocs.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewDocs_ColumnClick);
            this.listViewDocs.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewDocs_ItemDrag);
            this.listViewDocs.SelectedIndexChanged += new System.EventHandler(this.listViewDocs_SelectedIndexChanged);
            this.listViewDocs.Click += new System.EventHandler(this.listViewDocs_Click);
            this.listViewDocs.DragDrop += new System.Windows.Forms.DragEventHandler(this.DocumentManager_DragDrop);
            this.listViewDocs.DragEnter += new System.Windows.Forms.DragEventHandler(this.DocumentManager_DragEnter);
            this.listViewDocs.DoubleClick += new System.EventHandler(this.listViewDocs_DoubleClick);
            this.listViewDocs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewDocs_KeyDown);
            this.listViewDocs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewDocs_MouseClick);
            // 
            // favorite
            // 
            this.favorite.Text = "Favorite";
            // 
            // type
            // 
            this.type.Text = "Type";
            // 
            // title
            // 
            this.title.Text = "Title";
            // 
            // author
            // 
            this.author.Text = "Author(s)";
            // 
            // year
            // 
            this.year.Text = "Year";
            // 
            // doi
            // 
            this.doi.Text = "DOI";
            // 
            // added
            // 
            this.added.Text = "Added";
            // 
            // buttonAdvancedSearch
            // 
            this.buttonAdvancedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdvancedSearch.Location = new System.Drawing.Point(857, 24);
            this.buttonAdvancedSearch.Name = "buttonAdvancedSearch";
            this.buttonAdvancedSearch.Size = new System.Drawing.Size(113, 23);
            this.buttonAdvancedSearch.TabIndex = 24;
            this.buttonAdvancedSearch.Text = "Advanced Search";
            this.buttonAdvancedSearch.UseVisualStyleBackColor = true;
            this.buttonAdvancedSearch.Click += new System.EventHandler(this.buttonAdvancedSearch_Click);
            // 
            // Notes
            // 
            this.Notes.Controls.Add(this.textBoxNotes);
            this.Notes.Location = new System.Drawing.Point(4, 22);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(286, 388);
            this.Notes.TabIndex = 1;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(6, 6);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ReadOnly = true;
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(278, 373);
            this.textBoxNotes.TabIndex = 13;
            // 
            // Details
            // 
            this.Details.Controls.Add(this.labelSizeValue);
            this.Details.Controls.Add(this.labelAddedValue);
            this.Details.Controls.Add(this.labelPathValue);
            this.Details.Controls.Add(this.textBoxTags);
            this.Details.Controls.Add(this.labelTags);
            this.Details.Controls.Add(this.checkBoxFavourite);
            this.Details.Controls.Add(this.buttonMove);
            this.Details.Controls.Add(this.labelFavorite);
            this.Details.Controls.Add(this.labelSize);
            this.Details.Controls.Add(this.labelPath);
            this.Details.Controls.Add(this.labelAdded);
            this.Details.Controls.Add(this.buttonEdit);
            this.Details.Controls.Add(this.textBoxDOI);
            this.Details.Controls.Add(this.textBoxYear);
            this.Details.Controls.Add(this.textBoxAuthor);
            this.Details.Controls.Add(this.textBoxTitle);
            this.Details.Controls.Add(this.labelDOI);
            this.Details.Controls.Add(this.labelYear);
            this.Details.Controls.Add(this.labelAuthor);
            this.Details.Controls.Add(this.labelTitle);
            this.Details.Location = new System.Drawing.Point(4, 22);
            this.Details.Name = "Details";
            this.Details.Padding = new System.Windows.Forms.Padding(3);
            this.Details.Size = new System.Drawing.Size(286, 388);
            this.Details.TabIndex = 0;
            this.Details.Text = "Details";
            this.Details.UseVisualStyleBackColor = true;
            // 
            // labelSizeValue
            // 
            this.labelSizeValue.AutoSize = true;
            this.labelSizeValue.Location = new System.Drawing.Point(64, 166);
            this.labelSizeValue.Name = "labelSizeValue";
            this.labelSizeValue.Size = new System.Drawing.Size(0, 13);
            this.labelSizeValue.TabIndex = 27;
            // 
            // labelAddedValue
            // 
            this.labelAddedValue.AutoSize = true;
            this.labelAddedValue.Location = new System.Drawing.Point(64, 195);
            this.labelAddedValue.Name = "labelAddedValue";
            this.labelAddedValue.Size = new System.Drawing.Size(0, 13);
            this.labelAddedValue.TabIndex = 26;
            // 
            // labelPathValue
            // 
            this.labelPathValue.AutoSize = true;
            this.labelPathValue.Location = new System.Drawing.Point(64, 224);
            this.labelPathValue.Name = "labelPathValue";
            this.labelPathValue.Size = new System.Drawing.Size(0, 13);
            this.labelPathValue.TabIndex = 25;
            // 
            // textBoxTags
            // 
            this.textBoxTags.Location = new System.Drawing.Point(67, 134);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.ReadOnly = true;
            this.textBoxTags.Size = new System.Drawing.Size(207, 20);
            this.textBoxTags.TabIndex = 11;
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(6, 137);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(34, 13);
            this.labelTags.TabIndex = 23;
            this.labelTags.Text = "Tags:";
            // 
            // checkBoxFavourite
            // 
            this.checkBoxFavourite.AutoSize = true;
            this.checkBoxFavourite.Enabled = false;
            this.checkBoxFavourite.Location = new System.Drawing.Point(67, 253);
            this.checkBoxFavourite.Name = "checkBoxFavourite";
            this.checkBoxFavourite.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFavourite.TabIndex = 12;
            this.checkBoxFavourite.UseVisualStyleBackColor = true;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(134, 296);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 21;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // labelFavorite
            // 
            this.labelFavorite.AutoSize = true;
            this.labelFavorite.Location = new System.Drawing.Point(6, 253);
            this.labelFavorite.Name = "labelFavorite";
            this.labelFavorite.Size = new System.Drawing.Size(48, 13);
            this.labelFavorite.TabIndex = 20;
            this.labelFavorite.Text = "Favorite:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(6, 166);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 13);
            this.labelSize.TabIndex = 19;
            this.labelSize.Text = "Size:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 224);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(35, 13);
            this.labelPath.TabIndex = 18;
            this.labelPath.Text = "Path: ";
            // 
            // labelAdded
            // 
            this.labelAdded.AutoSize = true;
            this.labelAdded.Location = new System.Drawing.Point(6, 195);
            this.labelAdded.Name = "labelAdded";
            this.labelAdded.Size = new System.Drawing.Size(41, 13);
            this.labelAdded.TabIndex = 17;
            this.labelAdded.Text = "Added:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(43, 296);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxDOI
            // 
            this.textBoxDOI.Location = new System.Drawing.Point(67, 105);
            this.textBoxDOI.Name = "textBoxDOI";
            this.textBoxDOI.ReadOnly = true;
            this.textBoxDOI.Size = new System.Drawing.Size(207, 20);
            this.textBoxDOI.TabIndex = 10;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(67, 76);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.ReadOnly = true;
            this.textBoxYear.Size = new System.Drawing.Size(207, 20);
            this.textBoxYear.TabIndex = 9;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(67, 47);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(207, 20);
            this.textBoxAuthor.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(67, 18);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(207, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // labelDOI
            // 
            this.labelDOI.AutoSize = true;
            this.labelDOI.Location = new System.Drawing.Point(6, 108);
            this.labelDOI.Name = "labelDOI";
            this.labelDOI.Size = new System.Drawing.Size(29, 13);
            this.labelDOI.TabIndex = 5;
            this.labelDOI.Text = "DOI:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(6, 79);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(35, 13);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Year: ";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(6, 50);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(55, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author(s): ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(6, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(33, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Details);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Location = new System.Drawing.Point(676, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 414);
            this.tabControl1.TabIndex = 6;
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(12, 25);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(93, 23);
            this.buttonAddFile.TabIndex = 1;
            this.buttonAddFile.Text = "Add File";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // buttonAddDictionary
            // 
            this.buttonAddDictionary.Location = new System.Drawing.Point(111, 25);
            this.buttonAddDictionary.Name = "buttonAddDictionary";
            this.buttonAddDictionary.Size = new System.Drawing.Size(90, 23);
            this.buttonAddDictionary.TabIndex = 2;
            this.buttonAddDictionary.Text = "Add Folder";
            this.buttonAddDictionary.UseVisualStyleBackColor = true;
            this.buttonAddDictionary.Click += new System.EventHandler(this.buttonAddDictionary_Click);
            // 
            // contextMenuStripDocList
            // 
            this.contextMenuStripDocList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoriteToolStripMenuItem,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.contextMenuStripDocList.Name = "contextMenuStripDocList";
            this.contextMenuStripDocList.Size = new System.Drawing.Size(123, 120);
            // 
            // addToFavoriteToolStripMenuItem
            // 
            this.addToFavoriteToolStripMenuItem.Name = "addToFavoriteToolStripMenuItem";
            this.addToFavoriteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addToFavoriteToolStripMenuItem.Text = "Favorite";
            this.addToFavoriteToolStripMenuItem.Click += new System.EventHandler(this.addToFavoriteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // contextMenuStripDirs
            // 
            this.contextMenuStripDirs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDirToolStripMenuItem,
            this.renameDirToolStripMenuItem,
            this.moveDirToolStripMenuItem,
            this.deleteDirToolStripMenuItem,
            this.deleteALLDirsToolStripMenuItem,
            this.toolStripSeparator1,
            this.expandAllToolStripMenuItem,
            this.colapseAllToolStripMenuItem});
            this.contextMenuStripDirs.Name = "contextMenuStripDirs";
            this.contextMenuStripDirs.Size = new System.Drawing.Size(196, 164);
            // 
            // addNewDirToolStripMenuItem
            // 
            this.addNewDirToolStripMenuItem.Name = "addNewDirToolStripMenuItem";
            this.addNewDirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addNewDirToolStripMenuItem.Text = "Add new dir";
            this.addNewDirToolStripMenuItem.Click += new System.EventHandler(this.addNewDirToolStripMenuItem_Click);
            // 
            // renameDirToolStripMenuItem
            // 
            this.renameDirToolStripMenuItem.Name = "renameDirToolStripMenuItem";
            this.renameDirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.renameDirToolStripMenuItem.Text = "Rename dir";
            this.renameDirToolStripMenuItem.Click += new System.EventHandler(this.renameDirToolStripMenuItem_Click);
            // 
            // moveDirToolStripMenuItem
            // 
            this.moveDirToolStripMenuItem.Name = "moveDirToolStripMenuItem";
            this.moveDirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.moveDirToolStripMenuItem.Text = "Move dir";
            this.moveDirToolStripMenuItem.Click += new System.EventHandler(this.moveDirToolStripMenuItem_Click);
            // 
            // deleteDirToolStripMenuItem
            // 
            this.deleteDirToolStripMenuItem.Name = "deleteDirToolStripMenuItem";
            this.deleteDirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteDirToolStripMenuItem.Text = "Delete dir";
            this.deleteDirToolStripMenuItem.Click += new System.EventHandler(this.deleteDirToolStripMenuItem_Click);
            // 
            // deleteALLDirsToolStripMenuItem
            // 
            this.deleteALLDirsToolStripMenuItem.Name = "deleteALLDirsToolStripMenuItem";
            this.deleteALLDirsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteALLDirsToolStripMenuItem.Text = "Delete ALL custom dirs";
            this.deleteALLDirsToolStripMenuItem.Click += new System.EventHandler(this.deleteALLDirsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.expandAllToolStripMenuItem.Text = "Expand all";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // colapseAllToolStripMenuItem
            // 
            this.colapseAllToolStripMenuItem.Name = "colapseAllToolStripMenuItem";
            this.colapseAllToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.colapseAllToolStripMenuItem.Text = "Colapse all";
            this.colapseAllToolStripMenuItem.Click += new System.EventHandler(this.colapseAllToolStripMenuItem_Click);
            // 
            // textBoxSimpleSearch
            // 
            this.textBoxSimpleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxSimpleSearch.Location = new System.Drawing.Point(676, 27);
            this.textBoxSimpleSearch.Name = "textBoxSimpleSearch";
            this.textBoxSimpleSearch.Size = new System.Drawing.Size(138, 20);
            this.textBoxSimpleSearch.TabIndex = 22;
            this.textBoxSimpleSearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.textBoxSimpleSearch.WaterMarkText = "Search text...";
            this.textBoxSimpleSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSimpleSearch_KeyDown);
            // 
            // DocumentManager
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 473);
            this.Controls.Add(this.textBoxSimpleSearch);
            this.Controls.Add(this.listViewDocs);
            this.Controls.Add(this.buttonCreateFolder);
            this.Controls.Add(this.treeViewDirs);
            this.Controls.Add(this.buttonAddDictionary);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.buttonAdvancedSearch);
            this.Controls.Add(this.buttonSimpleSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(998, 511);
            this.Name = "DocumentManager";
            this.Text = "Document Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocumentManager_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DocumentManager_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DocumentManager_DragEnter);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.Notes.ResumeLayout(false);
            this.Notes.PerformLayout();
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStripDocList.ResumeLayout(false);
            this.contextMenuStripDirs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSimpleSearch;
        private System.Windows.Forms.ListView listViewDocs;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.TreeView treeViewDirs;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader added;
        private System.Windows.Forms.ColumnHeader doi;
        private System.Windows.Forms.Button buttonCreateFolder;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Button buttonAdvancedSearch;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage Details;
        private System.Windows.Forms.CheckBox checkBoxFavourite;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label labelFavorite;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelAdded;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxDOI;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelDOI;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.TextBox textBoxTags;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Button buttonAddDictionary;
        private System.Windows.Forms.ColumnHeader favorite;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutDocumentManagerToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDocList;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.Label labelSizeValue;
        private System.Windows.Forms.Label labelAddedValue;
        private System.Windows.Forms.Label labelPathValue;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDirs;
        private System.Windows.Forms.ToolStripMenuItem addNewDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteALLDirsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addToFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem renameDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem openAnotherCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private wmgCMS.WaterMarkTextBox textBoxSimpleSearch;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    }
}


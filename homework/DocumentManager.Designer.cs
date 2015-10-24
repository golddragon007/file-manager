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
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("All Documents");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Recently Added");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Recently Read");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Favorites");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Author(s)");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Unsorted");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Folder3");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Folder2", new System.Windows.Forms.TreeNode[] {
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Folder4");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Folder1", new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode79});
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.SimpleSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Docs = new System.Windows.Forms.ListView();
            this.favorite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.added = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.Notes = new System.Windows.Forms.TabPage();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.Details = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDocumentManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Notes.SuspendLayout();
            this.Details.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.addDictionaryToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // addDictionaryToolStripMenuItem
            // 
            this.addDictionaryToolStripMenuItem.Name = "addDictionaryToolStripMenuItem";
            this.addDictionaryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addDictionaryToolStripMenuItem.Text = "Add Dictionary";
            this.addDictionaryToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(682, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(598, 30);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(78, 13);
            this.Search.TabIndex = 3;
            this.Search.Text = "Simple Search:";
            this.Search.Click += new System.EventHandler(this.label1_Click);
            // 
            // SimpleSearch
            // 
            this.SimpleSearch.Location = new System.Drawing.Point(820, 25);
            this.SimpleSearch.Name = "SimpleSearch";
            this.SimpleSearch.Size = new System.Drawing.Size(31, 23);
            this.SimpleSearch.TabIndex = 4;
            this.SimpleSearch.Text = "OK";
            this.SimpleSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 415);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Folder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1, 35);
            this.treeView1.Name = "treeView1";
            treeNode71.Name = "AllDocuments";
            treeNode71.Text = "All Documents";
            treeNode72.Name = "RecentlyAdded";
            treeNode72.Text = "Recently Added";
            treeNode73.Name = "RecentlyRead";
            treeNode73.Text = "Recently Read";
            treeNode74.Name = "Favorites";
            treeNode74.Text = "Favorites";
            treeNode75.Name = "Author(s)";
            treeNode75.Text = "Author(s)";
            treeNode76.Name = "Unsorted";
            treeNode76.Text = "Unsorted";
            treeNode77.Name = "Folder3";
            treeNode77.Text = "Folder3";
            treeNode78.Name = "Folder2";
            treeNode78.Text = "Folder2";
            treeNode79.Name = "Folder4";
            treeNode79.Text = "Folder4";
            treeNode80.Name = "Folder1";
            treeNode80.Text = "Folder1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode80});
            this.treeView1.Size = new System.Drawing.Size(225, 377);
            this.treeView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Docs);
            this.panel2.Location = new System.Drawing.Point(226, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 414);
            this.panel2.TabIndex = 7;
            // 
            // Docs
            // 
            this.Docs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.favorite,
            this.type,
            this.title,
            this.author,
            this.year,
            this.added,
            this.doi});
            this.Docs.Location = new System.Drawing.Point(3, 0);
            this.Docs.Name = "Docs";
            this.Docs.Size = new System.Drawing.Size(441, 411);
            this.Docs.TabIndex = 1;
            this.Docs.UseCompatibleStateImageBehavior = false;
            this.Docs.View = System.Windows.Forms.View.Details;
            this.Docs.SelectedIndexChanged += new System.EventHandler(this.Docs_SelectedIndexChanged);
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
            this.year.DisplayIndex = 5;
            this.year.Text = "Year";
            // 
            // added
            // 
            this.added.DisplayIndex = 4;
            this.added.Text = "Added";
            // 
            // doi
            // 
            this.doi.Text = "DOI";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(857, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Advanced Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Notes
            // 
            this.Notes.Controls.Add(this.vScrollBar4);
            this.Notes.Location = new System.Drawing.Point(4, 22);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(290, 389);
            this.Notes.TabIndex = 1;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            this.Notes.Click += new System.EventHandler(this.Notes_Click);
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(272, 0);
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(17, 388);
            this.vScrollBar4.TabIndex = 0;
            // 
            // Details
            // 
            this.Details.Controls.Add(this.textBox5);
            this.Details.Controls.Add(this.label9);
            this.Details.Controls.Add(this.checkBox1);
            this.Details.Controls.Add(this.button3);
            this.Details.Controls.Add(this.label8);
            this.Details.Controls.Add(this.label4);
            this.Details.Controls.Add(this.label7);
            this.Details.Controls.Add(this.label6);
            this.Details.Controls.Add(this.button6);
            this.Details.Controls.Add(this.textBox6);
            this.Details.Controls.Add(this.textBox4);
            this.Details.Controls.Add(this.textBox3);
            this.Details.Controls.Add(this.textBox2);
            this.Details.Controls.Add(this.label5);
            this.Details.Controls.Add(this.label3);
            this.Details.Controls.Add(this.label2);
            this.Details.Controls.Add(this.label1);
            this.Details.Location = new System.Drawing.Point(4, 22);
            this.Details.Name = "Details";
            this.Details.Padding = new System.Windows.Forms.Padding(3);
            this.Details.Size = new System.Drawing.Size(290, 385);
            this.Details.TabIndex = 0;
            this.Details.Text = "Details";
            this.Details.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(67, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(207, 20);
            this.textBox5.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tags:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Move";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Favorite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Size:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Path: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Added:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(43, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(67, 105);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(207, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author(s): ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Details);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Location = new System.Drawing.Point(672, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(298, 411);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add File";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Add Dictionary";
            this.button5.UseVisualStyleBackColor = true;
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
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutDocumentManagerToolStripMenuItem
            // 
            this.aboutDocumentManagerToolStripMenuItem.Name = "aboutDocumentManagerToolStripMenuItem";
            this.aboutDocumentManagerToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.aboutDocumentManagerToolStripMenuItem.Text = "About Document Manager";
            // 
            // DocumentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 486);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SimpleSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DocumentManager";
            this.Text = "DocumentManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Notes.ResumeLayout(false);
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button SimpleSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView Docs;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader added;
        private System.Windows.Forms.ColumnHeader doi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.TabPage Details;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader favorite;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutDocumentManagerToolStripMenuItem;
    }
}


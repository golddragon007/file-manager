namespace homework
{
    partial class NewVDir
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
            this.textBoxNewDirName = new System.Windows.Forms.TextBox();
            this.labelAddInto = new System.Windows.Forms.Label();
            this.labelDirName = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxMainDir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNewDirName
            // 
            this.textBoxNewDirName.Location = new System.Drawing.Point(9, 25);
            this.textBoxNewDirName.Name = "textBoxNewDirName";
            this.textBoxNewDirName.Size = new System.Drawing.Size(260, 20);
            this.textBoxNewDirName.TabIndex = 1;
            // 
            // labelAddInto
            // 
            this.labelAddInto.AutoSize = true;
            this.labelAddInto.Location = new System.Drawing.Point(9, 48);
            this.labelAddInto.Name = "labelAddInto";
            this.labelAddInto.Size = new System.Drawing.Size(49, 13);
            this.labelAddInto.TabIndex = 2;
            this.labelAddInto.Text = "Add into:";
            // 
            // labelDirName
            // 
            this.labelDirName.AutoSize = true;
            this.labelDirName.Location = new System.Drawing.Point(9, 9);
            this.labelDirName.Name = "labelDirName";
            this.labelDirName.Size = new System.Drawing.Size(75, 13);
            this.labelDirName.TabIndex = 3;
            this.labelDirName.Text = "New dir name:";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(116, 100);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(197, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxMainDir
            // 
            this.comboBoxMainDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMainDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMainDir.FormattingEnabled = true;
            this.comboBoxMainDir.Location = new System.Drawing.Point(12, 64);
            this.comboBoxMainDir.Name = "comboBoxMainDir";
            this.comboBoxMainDir.Size = new System.Drawing.Size(257, 21);
            this.comboBoxMainDir.TabIndex = 4;
            // 
            // NewVDir
            // 
            this.AcceptButton = this.buttonCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(this.comboBoxMainDir);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelDirName);
            this.Controls.Add(this.labelAddInto);
            this.Controls.Add(this.textBoxNewDirName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewVDir";
            this.Text = "Add new directory to...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewDirName;
        private System.Windows.Forms.Label labelAddInto;
        private System.Windows.Forms.Label labelDirName;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxMainDir;
    }
}
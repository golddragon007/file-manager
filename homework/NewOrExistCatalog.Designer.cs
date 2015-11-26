namespace homework
{
    partial class NewOrExistCatalog
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
            this.buttonNewCatalog = new System.Windows.Forms.Button();
            this.buttonExistCatalog = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialogForCatalog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogForCatalog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonNewCatalog
            // 
            this.buttonNewCatalog.Location = new System.Drawing.Point(12, 45);
            this.buttonNewCatalog.Name = "buttonNewCatalog";
            this.buttonNewCatalog.Size = new System.Drawing.Size(153, 23);
            this.buttonNewCatalog.TabIndex = 0;
            this.buttonNewCatalog.Text = "Create new catalog";
            this.buttonNewCatalog.UseVisualStyleBackColor = true;
            this.buttonNewCatalog.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExistCatalog
            // 
            this.buttonExistCatalog.Location = new System.Drawing.Point(193, 45);
            this.buttonExistCatalog.Name = "buttonExistCatalog";
            this.buttonExistCatalog.Size = new System.Drawing.Size(153, 23);
            this.buttonExistCatalog.TabIndex = 1;
            this.buttonExistCatalog.Text = "Browse exist catalog";
            this.buttonExistCatalog.UseVisualStyleBackColor = true;
            this.buttonExistCatalog.Click += new System.EventHandler(this.buttonExistCatalog_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(125, 82);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Close program";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select one of the three options:";
            // 
            // saveFileDialogForCatalog
            // 
            this.saveFileDialogForCatalog.DefaultExt = "dmdb";
            this.saveFileDialogForCatalog.FileName = "newCatalog";
            this.saveFileDialogForCatalog.Filter = "Document Manager DB|*.dmdb";
            this.saveFileDialogForCatalog.Title = "Create new as...";
            // 
            // openFileDialogForCatalog
            // 
            this.openFileDialogForCatalog.DefaultExt = "dmdb";
            this.openFileDialogForCatalog.FileName = "newCatalog";
            this.openFileDialogForCatalog.Filter = "Document Manager DB|*.dmdb";
            this.openFileDialogForCatalog.Title = "Open...";
            // 
            // NewOrExistCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(359, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonExistCatalog);
            this.Controls.Add(this.buttonNewCatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewOrExistCatalog";
            this.Text = "Create new or open exist catalog?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewCatalog;
        private System.Windows.Forms.Button buttonExistCatalog;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogForCatalog;
        private System.Windows.Forms.OpenFileDialog openFileDialogForCatalog;
    }
}
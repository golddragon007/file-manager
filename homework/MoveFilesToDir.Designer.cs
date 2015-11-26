namespace homework
{
    partial class MoveFilesToDir
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
            this.labelSelectedFiles = new System.Windows.Forms.Label();
            this.comboBoxMoveToDir = new System.Windows.Forms.ComboBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelectedFiles
            // 
            this.labelSelectedFiles.AutoSize = true;
            this.labelSelectedFiles.Location = new System.Drawing.Point(12, 9);
            this.labelSelectedFiles.Name = "labelSelectedFiles";
            this.labelSelectedFiles.Size = new System.Drawing.Size(119, 13);
            this.labelSelectedFiles.TabIndex = 0;
            this.labelSelectedFiles.Text = "Move selected files to...";
            // 
            // comboBoxMoveToDir
            // 
            this.comboBoxMoveToDir.FormattingEnabled = true;
            this.comboBoxMoveToDir.Location = new System.Drawing.Point(15, 25);
            this.comboBoxMoveToDir.Name = "comboBoxMoveToDir";
            this.comboBoxMoveToDir.Size = new System.Drawing.Size(371, 21);
            this.comboBoxMoveToDir.TabIndex = 1;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(230, 52);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(311, 52);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MoveFilesToDir
            // 
            this.AcceptButton = this.buttonMove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(398, 87);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.comboBoxMoveToDir);
            this.Controls.Add(this.labelSelectedFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MoveFilesToDir";
            this.Text = "Move files to...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectedFiles;
        private System.Windows.Forms.ComboBox comboBoxMoveToDir;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonCancel;
    }
}
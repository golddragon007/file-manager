namespace DocumentManager
{
    partial class MoveVDirs
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
            this.labelMoveableDir = new System.Windows.Forms.Label();
            this.labelMoveInto = new System.Windows.Forms.Label();
            this.comboBoxMoveInto = new System.Windows.Forms.ComboBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMoveableDir
            // 
            this.labelMoveableDir.AutoSize = true;
            this.labelMoveableDir.Location = new System.Drawing.Point(13, 13);
            this.labelMoveableDir.Name = "labelMoveableDir";
            this.labelMoveableDir.Size = new System.Drawing.Size(67, 13);
            this.labelMoveableDir.TabIndex = 0;
            this.labelMoveableDir.Text = "MoveableDir";
            // 
            // labelMoveInto
            // 
            this.labelMoveInto.AutoSize = true;
            this.labelMoveInto.Location = new System.Drawing.Point(13, 30);
            this.labelMoveInto.Name = "labelMoveInto";
            this.labelMoveInto.Size = new System.Drawing.Size(57, 13);
            this.labelMoveInto.TabIndex = 1;
            this.labelMoveInto.Text = "Move into:";
            // 
            // comboBoxMoveInto
            // 
            this.comboBoxMoveInto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMoveInto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMoveInto.FormattingEnabled = true;
            this.comboBoxMoveInto.Location = new System.Drawing.Point(12, 46);
            this.comboBoxMoveInto.Name = "comboBoxMoveInto";
            this.comboBoxMoveInto.Size = new System.Drawing.Size(363, 21);
            this.comboBoxMoveInto.TabIndex = 2;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(219, 73);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(300, 73);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MoveVDirs
            // 
            this.AcceptButton = this.buttonMove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(387, 104);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.comboBoxMoveInto);
            this.Controls.Add(this.labelMoveInto);
            this.Controls.Add(this.labelMoveableDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MoveVDirs";
            this.Text = "Move directory into...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoveableDir;
        private System.Windows.Forms.Label labelMoveInto;
        private System.Windows.Forms.ComboBox comboBoxMoveInto;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonCancel;
    }
}
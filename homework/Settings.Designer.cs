namespace homework
{
    partial class Settings
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.radioButtonPicture = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustom = new System.Windows.Forms.TextBox();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonExecuteable = new System.Windows.Forms.RadioButton();
            this.radioButtonVideo = new System.Windows.Forms.RadioButton();
            this.radioButtonAudio = new System.Windows.Forms.RadioButton();
            this.radioButtonDocument = new System.Windows.Forms.RadioButton();
            this.groupBoxFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(403, 199);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(484, 199);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Controls.Add(this.radioButtonPicture);
            this.groupBoxFormat.Controls.Add(this.label1);
            this.groupBoxFormat.Controls.Add(this.textBoxCustom);
            this.groupBoxFormat.Controls.Add(this.radioButtonCustom);
            this.groupBoxFormat.Controls.Add(this.radioButtonExecuteable);
            this.groupBoxFormat.Controls.Add(this.radioButtonVideo);
            this.groupBoxFormat.Controls.Add(this.radioButtonAudio);
            this.groupBoxFormat.Controls.Add(this.radioButtonDocument);
            this.groupBoxFormat.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(547, 181);
            this.groupBoxFormat.TabIndex = 100;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Allowed file format";
            // 
            // radioButtonPicture
            // 
            this.radioButtonPicture.AutoSize = true;
            this.radioButtonPicture.Location = new System.Drawing.Point(7, 43);
            this.radioButtonPicture.Name = "radioButtonPicture";
            this.radioButtonPicture.Size = new System.Drawing.Size(173, 17);
            this.radioButtonPicture.TabIndex = 1;
            this.radioButtonPicture.TabStop = true;
            this.radioButtonPicture.Tag = "2";
            this.radioButtonPicture.Text = "Picture (jpg/jpeg, bmp, png, gif)";
            this.radioButtonPicture.UseVisualStyleBackColor = true;
            this.radioButtonPicture.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Separate with comma (\",\")";
            // 
            // textBoxCustom
            // 
            this.textBoxCustom.Location = new System.Drawing.Point(76, 134);
            this.textBoxCustom.Name = "textBoxCustom";
            this.textBoxCustom.ReadOnly = true;
            this.textBoxCustom.Size = new System.Drawing.Size(465, 20);
            this.textBoxCustom.TabIndex = 6;
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(7, 135);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCustom.TabIndex = 5;
            this.radioButtonCustom.Tag = "6";
            this.radioButtonCustom.Text = "Custom:";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // radioButtonExecuteable
            // 
            this.radioButtonExecuteable.AutoSize = true;
            this.radioButtonExecuteable.Location = new System.Drawing.Point(7, 111);
            this.radioButtonExecuteable.Name = "radioButtonExecuteable";
            this.radioButtonExecuteable.Size = new System.Drawing.Size(157, 17);
            this.radioButtonExecuteable.TabIndex = 4;
            this.radioButtonExecuteable.Tag = "5";
            this.radioButtonExecuteable.Text = "Executeable (exe, msi, com)";
            this.radioButtonExecuteable.UseVisualStyleBackColor = true;
            this.radioButtonExecuteable.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // radioButtonVideo
            // 
            this.radioButtonVideo.AutoSize = true;
            this.radioButtonVideo.Location = new System.Drawing.Point(7, 87);
            this.radioButtonVideo.Name = "radioButtonVideo";
            this.radioButtonVideo.Size = new System.Drawing.Size(279, 17);
            this.radioButtonVideo.TabIndex = 3;
            this.radioButtonVideo.Tag = "4";
            this.radioButtonVideo.Text = "Video (mkv, wmv, mp4, flv, 3gp, avi, divx, mpg, mpeg)";
            this.radioButtonVideo.UseVisualStyleBackColor = true;
            this.radioButtonVideo.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // radioButtonAudio
            // 
            this.radioButtonAudio.AutoSize = true;
            this.radioButtonAudio.Location = new System.Drawing.Point(7, 63);
            this.radioButtonAudio.Name = "radioButtonAudio";
            this.radioButtonAudio.Size = new System.Drawing.Size(252, 17);
            this.radioButtonAudio.TabIndex = 2;
            this.radioButtonAudio.Tag = "3";
            this.radioButtonAudio.Text = "Audio (mp3, flac, aac, ac3, wav, ogg, wma, mid)";
            this.radioButtonAudio.UseVisualStyleBackColor = true;
            this.radioButtonAudio.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // radioButtonDocument
            // 
            this.radioButtonDocument.AutoSize = true;
            this.radioButtonDocument.Checked = true;
            this.radioButtonDocument.Location = new System.Drawing.Point(7, 20);
            this.radioButtonDocument.Name = "radioButtonDocument";
            this.radioButtonDocument.Size = new System.Drawing.Size(253, 17);
            this.radioButtonDocument.TabIndex = 0;
            this.radioButtonDocument.TabStop = true;
            this.radioButtonDocument.Tag = "1";
            this.radioButtonDocument.Text = "Document (dox/docx, xls/xlsx, txt, pdf, htm/html)";
            this.radioButtonDocument.UseVisualStyleBackColor = true;
            this.radioButtonDocument.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // Settings
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(571, 233);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.TextBox textBoxCustom;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonExecuteable;
        private System.Windows.Forms.RadioButton radioButtonVideo;
        private System.Windows.Forms.RadioButton radioButtonAudio;
        private System.Windows.Forms.RadioButton radioButtonDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPicture;
    }
}
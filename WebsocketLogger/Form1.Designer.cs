namespace RP3_Interface
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MessageText = new System.Windows.Forms.Label();
            this.LogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileButton = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.FilePathDialog = new System.Windows.Forms.TextBox();
            this.CacheSizeText = new System.Windows.Forms.Label();
            this.NewlineCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Location = new System.Drawing.Point(518, 306);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(72, 13);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Last message";
            // 
            // LogFileDialog
            // 
            this.LogFileDialog.FileName = "LogFileDialog";
            this.LogFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LogFileDialog_FileOk);
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(596, 150);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 1;
            this.FileButton.Text = "Open file";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(521, 587);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(75, 23);
            this.SaveFile.TabIndex = 2;
            this.SaveFile.Text = "Save File";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // FilePathDialog
            // 
            this.FilePathDialog.Enabled = false;
            this.FilePathDialog.Location = new System.Drawing.Point(254, 153);
            this.FilePathDialog.Name = "FilePathDialog";
            this.FilePathDialog.Size = new System.Drawing.Size(336, 20);
            this.FilePathDialog.TabIndex = 3;
            // 
            // CacheSizeText
            // 
            this.CacheSizeText.AutoSize = true;
            this.CacheSizeText.Location = new System.Drawing.Point(524, 419);
            this.CacheSizeText.Name = "CacheSizeText";
            this.CacheSizeText.Size = new System.Drawing.Size(59, 13);
            this.CacheSizeText.TabIndex = 4;
            this.CacheSizeText.Text = "Cache size";
            // 
            // NewlineCheckbox
            // 
            this.NewlineCheckbox.AutoSize = true;
            this.NewlineCheckbox.Checked = true;
            this.NewlineCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewlineCheckbox.Location = new System.Drawing.Point(785, 156);
            this.NewlineCheckbox.Name = "NewlineCheckbox";
            this.NewlineCheckbox.Size = new System.Drawing.Size(108, 17);
            this.NewlineCheckbox.TabIndex = 6;
            this.NewlineCheckbox.Text = "Auto add newline";
            this.NewlineCheckbox.ThreeState = true;
            this.NewlineCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 865);
            this.Controls.Add(this.NewlineCheckbox);
            this.Controls.Add(this.CacheSizeText);
            this.Controls.Add(this.FilePathDialog);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.MessageText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.OpenFileDialog LogFileDialog;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.TextBox FilePathDialog;
        private System.Windows.Forms.Label CacheSizeText;
        private System.Windows.Forms.CheckBox NewlineCheckbox;
    }
}


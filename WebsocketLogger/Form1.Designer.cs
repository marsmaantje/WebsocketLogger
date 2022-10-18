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
            this.ApplicationStateText = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.CacheAutosaveLabel = new System.Windows.Forms.Label();
            this.AppendCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoSaveSizeField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AutoSaveSizeField)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Location = new System.Drawing.Point(9, 58);
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
            this.FileButton.Location = new System.Drawing.Point(354, 9);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 1;
            this.FileButton.Text = "Open file";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(12, 138);
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
            this.FilePathDialog.Location = new System.Drawing.Point(12, 12);
            this.FilePathDialog.Name = "FilePathDialog";
            this.FilePathDialog.Size = new System.Drawing.Size(336, 20);
            this.FilePathDialog.TabIndex = 3;
            // 
            // CacheSizeText
            // 
            this.CacheSizeText.AutoSize = true;
            this.CacheSizeText.Location = new System.Drawing.Point(9, 82);
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
            this.NewlineCheckbox.Location = new System.Drawing.Point(12, 38);
            this.NewlineCheckbox.Name = "NewlineCheckbox";
            this.NewlineCheckbox.Size = new System.Drawing.Size(108, 17);
            this.NewlineCheckbox.TabIndex = 6;
            this.NewlineCheckbox.Text = "Auto add newline";
            this.NewlineCheckbox.ThreeState = true;
            this.NewlineCheckbox.UseVisualStyleBackColor = true;
            // 
            // ApplicationStateText
            // 
            this.ApplicationStateText.AutoSize = true;
            this.ApplicationStateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationStateText.ForeColor = System.Drawing.Color.Red;
            this.ApplicationStateText.Location = new System.Drawing.Point(12, 322);
            this.ApplicationStateText.Name = "ApplicationStateText";
            this.ApplicationStateText.Size = new System.Drawing.Size(77, 20);
            this.ApplicationStateText.TabIndex = 7;
            this.ApplicationStateText.Text = "Stopped";
            // 
            // StartStopButton
            // 
            this.StartStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartStopButton.Location = new System.Drawing.Point(12, 296);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 9;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // CacheAutosaveLabel
            // 
            this.CacheAutosaveLabel.AutoSize = true;
            this.CacheAutosaveLabel.Location = new System.Drawing.Point(138, 100);
            this.CacheAutosaveLabel.Name = "CacheAutosaveLabel";
            this.CacheAutosaveLabel.Size = new System.Drawing.Size(107, 13);
            this.CacheAutosaveLabel.TabIndex = 10;
            this.CacheAutosaveLabel.Text = "Autosave Cache size";
            // 
            // AppendCheckBox
            // 
            this.AppendCheckBox.AutoSize = true;
            this.AppendCheckBox.Checked = true;
            this.AppendCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppendCheckBox.Location = new System.Drawing.Point(135, 38);
            this.AppendCheckBox.Name = "AppendCheckBox";
            this.AppendCheckBox.Size = new System.Drawing.Size(115, 17);
            this.AppendCheckBox.TabIndex = 11;
            this.AppendCheckBox.Text = "Append data to file";
            this.AppendCheckBox.ThreeState = true;
            this.AppendCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoSaveSizeField
            // 
            this.AutoSaveSizeField.Location = new System.Drawing.Point(12, 98);
            this.AutoSaveSizeField.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.AutoSaveSizeField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.AutoSaveSizeField.Name = "AutoSaveSizeField";
            this.AutoSaveSizeField.Size = new System.Drawing.Size(120, 20);
            this.AutoSaveSizeField.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(138, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "-1 for no limit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoSaveSizeField);
            this.Controls.Add(this.AppendCheckBox);
            this.Controls.Add(this.CacheAutosaveLabel);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.ApplicationStateText);
            this.Controls.Add(this.NewlineCheckbox);
            this.Controls.Add(this.CacheSizeText);
            this.Controls.Add(this.FilePathDialog);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.MessageText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AutoSaveSizeField)).EndInit();
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
        private System.Windows.Forms.Label ApplicationStateText;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Label CacheAutosaveLabel;
        private System.Windows.Forms.CheckBox AppendCheckBox;
        private System.Windows.Forms.NumericUpDown AutoSaveSizeField;
        private System.Windows.Forms.Label label1;
    }
}


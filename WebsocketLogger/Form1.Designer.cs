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
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Location = new System.Drawing.Point(551, 249);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(35, 13);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "label1";
            // 
            // LogFileDialog
            // 
            this.LogFileDialog.FileName = "LogFileDialog";
            this.LogFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LogFileDialog_FileOk);
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(331, 131);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 1;
            this.FileButton.Text = "Open file";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 865);
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
    }
}


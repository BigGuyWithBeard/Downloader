namespace Downloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFiles
            // 
            this.txtFiles.Location = new System.Drawing.Point(12, 57);
            this.txtFiles.Multiline = true;
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFiles.Size = new System.Drawing.Size(600, 370);
            this.txtFiles.TabIndex = 0;
            this.txtFiles.Text = resources.GetString("txtFiles.Text");
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(665, 27);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(12, 12);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(600, 23);
            this.txtDestination.TabIndex = 2;
            this.txtDestination.Text = "C:\\Users\\lobo_\\Downloads";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 434);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.btnDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblStatus;
    }
}


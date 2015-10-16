namespace SteamDeploy
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.downloadSteam = new System.Windows.Forms.Button();
            this.browseSteam = new System.Windows.Forms.Button();
            this.findSteam = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.MaximumSize = new System.Drawing.Size(265, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Steam client could not be detected on your system. Would you like to download" +
    " it? Alternatively, you can specify where Steam is located instead.";
            // 
            // downloadSteam
            // 
            this.downloadSteam.AutoSize = true;
            this.downloadSteam.Location = new System.Drawing.Point(12, 126);
            this.downloadSteam.Name = "downloadSteam";
            this.downloadSteam.Size = new System.Drawing.Size(127, 23);
            this.downloadSteam.TabIndex = 1;
            this.downloadSteam.Text = "Download Steam Client";
            this.downloadSteam.UseVisualStyleBackColor = true;
            this.downloadSteam.Click += new System.EventHandler(this.downloadSteam_Click);
            // 
            // browseSteam
            // 
            this.browseSteam.AutoSize = true;
            this.browseSteam.Location = new System.Drawing.Point(152, 126);
            this.browseSteam.Name = "browseSteam";
            this.browseSteam.Size = new System.Drawing.Size(120, 23);
            this.browseSteam.TabIndex = 2;
            this.browseSteam.Text = "Browse for Steam.exe";
            this.browseSteam.UseVisualStyleBackColor = true;
            this.browseSteam.Click += new System.EventHandler(this.browseSteam_Click);
            // 
            // findSteam
            // 
            this.findSteam.DefaultExt = "exe";
            this.findSteam.FileName = "Steam.exe";
            this.findSteam.Filter = "Steam Client|steam.exe";
            this.findSteam.Title = "Select the Steam client executable (steam.exe)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.browseSteam);
            this.Controls.Add(this.downloadSteam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Steam Game";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downloadSteam;
        private System.Windows.Forms.Button browseSteam;
        private System.Windows.Forms.OpenFileDialog findSteam;
    }
}


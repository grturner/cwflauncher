namespace WindowsFormsApplication1
{
    partial class LauncherMain
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
            this.Launch = new System.Windows.Forms.Button();
            this.CubeWorldForum = new System.Windows.Forms.Button();
            this.Skins = new System.Windows.Forms.Button();
            this.OrigLauncher = new System.Windows.Forms.Button();
            this.GameSettings = new System.Windows.Forms.Button();
            this.ServerSettings = new System.Windows.Forms.Button();
            this.LaunchServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backupButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(50, 246);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(351, 32);
            this.Launch.TabIndex = 0;
            this.Launch.Text = "Launch Cube World";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // CubeWorldForum
            // 
            this.CubeWorldForum.Location = new System.Drawing.Point(232, 285);
            this.CubeWorldForum.Name = "CubeWorldForum";
            this.CubeWorldForum.Size = new System.Drawing.Size(169, 32);
            this.CubeWorldForum.TabIndex = 1;
            this.CubeWorldForum.Text = "Cube World Forum";
            this.CubeWorldForum.UseVisualStyleBackColor = true;
            this.CubeWorldForum.Click += new System.EventHandler(this.CubeWorldForum_Click);
            // 
            // Skins
            // 
            this.Skins.Location = new System.Drawing.Point(232, 323);
            this.Skins.Name = "Skins";
            this.Skins.Size = new System.Drawing.Size(169, 32);
            this.Skins.TabIndex = 4;
            this.Skins.Text = "Skins";
            this.Skins.UseVisualStyleBackColor = true;
            this.Skins.Click += new System.EventHandler(this.Skins_Click);
            // 
            // OrigLauncher
            // 
            this.OrigLauncher.Location = new System.Drawing.Point(50, 286);
            this.OrigLauncher.Name = "OrigLauncher";
            this.OrigLauncher.Size = new System.Drawing.Size(169, 31);
            this.OrigLauncher.TabIndex = 5;
            this.OrigLauncher.Text = "Run Original Launcher";
            this.OrigLauncher.UseVisualStyleBackColor = true;
            this.OrigLauncher.Click += new System.EventHandler(this.OrigLauncher_Click);
            // 
            // GameSettings
            // 
            this.GameSettings.Location = new System.Drawing.Point(50, 323);
            this.GameSettings.Name = "GameSettings";
            this.GameSettings.Size = new System.Drawing.Size(169, 32);
            this.GameSettings.TabIndex = 6;
            this.GameSettings.Text = "Game Settings";
            this.GameSettings.UseVisualStyleBackColor = true;
            this.GameSettings.Click += new System.EventHandler(this.GameSettings_Click);
            // 
            // ServerSettings
            // 
            this.ServerSettings.Location = new System.Drawing.Point(50, 361);
            this.ServerSettings.Name = "ServerSettings";
            this.ServerSettings.Size = new System.Drawing.Size(169, 32);
            this.ServerSettings.TabIndex = 10;
            this.ServerSettings.Text = "Server Settings";
            this.ServerSettings.UseVisualStyleBackColor = true;
            this.ServerSettings.Click += new System.EventHandler(this.ServerSettings_Click);
            // 
            // LaunchServer
            // 
            this.LaunchServer.Location = new System.Drawing.Point(232, 361);
            this.LaunchServer.Name = "LaunchServer";
            this.LaunchServer.Size = new System.Drawing.Size(169, 32);
            this.LaunchServer.TabIndex = 11;
            this.LaunchServer.Text = "Launch Server";
            this.LaunchServer.UseVisualStyleBackColor = true;
            this.LaunchServer.Click += new System.EventHandler(this.ServerLaunch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fourth Party Launcher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Version 0.006b_r42";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Π";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(50, 399);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(169, 32);
            this.backupButton.TabIndex = 16;
            this.backupButton.Text = "Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(232, 399);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(169, 32);
            this.aboutButton.TabIndex = 17;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ivthparty;
            this.pictureBox1.Location = new System.Drawing.Point(7, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 130);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LauncherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 472);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaunchServer);
            this.Controls.Add(this.ServerSettings);
            this.Controls.Add(this.GameSettings);
            this.Controls.Add(this.OrigLauncher);
            this.Controls.Add(this.Skins);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CubeWorldForum);
            this.Controls.Add(this.Launch);
            this.Name = "LauncherMain";
            this.Text = "IVth Party Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.Button CubeWorldForum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Skins;
        private System.Windows.Forms.Button GameSettings;
        private System.Windows.Forms.Button OrigLauncher;
        private System.Windows.Forms.Button ServerSettings;
        private System.Windows.Forms.Button LaunchServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button aboutButton;
    }
}


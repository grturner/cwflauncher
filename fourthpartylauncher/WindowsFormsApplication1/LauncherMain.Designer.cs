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
            this.button1 = new System.Windows.Forms.Button();
            this.CubeWorldForum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Skins = new System.Windows.Forms.Button();
            this.OrigLauncher = new System.Windows.Forms.Button();
            this.GameSettings = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Launch Cube World";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Launch_Click);
            // 
            // CubeWorldForum
            // 
            this.CubeWorldForum.Location = new System.Drawing.Point(232, 285);
            this.CubeWorldForum.Name = "CubeWorldForum";
            this.CubeWorldForum.Size = new System.Drawing.Size(169, 50);
            this.CubeWorldForum.TabIndex = 1;
            this.CubeWorldForum.Text = "Cube World Forum";
            this.CubeWorldForum.UseVisualStyleBackColor = true;
            this.CubeWorldForum.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 130);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Skins
            // 
            this.Skins.Location = new System.Drawing.Point(232, 342);
            this.Skins.Name = "Skins";
            this.Skins.Size = new System.Drawing.Size(169, 50);
            this.Skins.TabIndex = 4;
            this.Skins.Text = "Skins";
            this.Skins.UseVisualStyleBackColor = true;
            this.Skins.Click += new System.EventHandler(this.button4_Click);
            // 
            // OrigLauncher
            // 
            this.OrigLauncher.Location = new System.Drawing.Point(50, 286);
            this.OrigLauncher.Name = "OrigLauncher";
            this.OrigLauncher.Size = new System.Drawing.Size(169, 50);
            this.OrigLauncher.TabIndex = 5;
            this.OrigLauncher.Text = "Run Original Launcher";
            this.OrigLauncher.UseVisualStyleBackColor = true;
            this.OrigLauncher.Click += new System.EventHandler(this.button5_Click);
            // 
            // GameSettings
            // 
            this.GameSettings.Location = new System.Drawing.Point(50, 342);
            this.GameSettings.Name = "GameSettings";
            this.GameSettings.Size = new System.Drawing.Size(169, 50);
            this.GameSettings.TabIndex = 6;
            this.GameSettings.Text = "Game Settings";
            this.GameSettings.UseVisualStyleBackColor = true;
            this.GameSettings.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(50, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(351, 38);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Fourth Party Launcher";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(267, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "By Tech Pony, Aristaeus, Obsoletepotato, et al";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = "";
            this.textBox3.Location = new System.Drawing.Point(175, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Version 0.001a";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Server Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 50);
            this.button3.TabIndex = 11;
            this.button3.Text = "Launch Server";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LauncherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 472);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GameSettings);
            this.Controls.Add(this.OrigLauncher);
            this.Controls.Add(this.Skins);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CubeWorldForum);
            this.Controls.Add(this.button1);
            this.Name = "LauncherMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CubeWorldForum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Skins;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button GameSettings;
        private System.Windows.Forms.Button OrigLauncher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


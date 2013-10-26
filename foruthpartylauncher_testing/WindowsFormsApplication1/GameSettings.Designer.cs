namespace WindowsFormsApplication1
{
    partial class GameSettings
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YaxisCheck = new System.Windows.Forms.CheckBox();
            this.FullScreenCheck = new System.Windows.Forms.CheckBox();
            this.WriteConfig = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Resolution = new System.Windows.Forms.ComboBox();
            this.fullScreenLabel = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.antialiasingLabel = new System.Windows.Forms.Label();
            this.renderDistanceLabel = new System.Windows.Forms.Label();
            this.soundVolumeLabel = new System.Windows.Forms.Label();
            this.musicVolumeLabel = new System.Windows.Forms.Label();
            this.cameraSmoothLabel = new System.Windows.Forms.Label();
            this.cameraSpeedLabel = new System.Windows.Forms.Label();
            this.fpsLimitLabel = new System.Windows.Forms.Label();
            this.antialiasingBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widthCustomLabel = new System.Windows.Forms.Label();
            this.heightCustomLabel = new System.Windows.Forms.Label();
            this.invertY_AxisLabel = new System.Windows.Forms.Label();
            this.editCurrentConfig = new System.Windows.Forms.Button();
            this.renderDistanceList = new System.Windows.Forms.ComboBox();
            this.cameraSmoothList = new System.Windows.Forms.ComboBox();
            this.cameraSpeedList = new System.Windows.Forms.ComboBox();
            this.musicVolList = new System.Windows.Forms.ComboBox();
            this.soundVolList = new System.Windows.Forms.ComboBox();
            this.fpsLimit = new System.Windows.Forms.ComboBox();
            this.widthCust = new System.Windows.Forms.TextBox();
            this.heightCust = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ivthparty;
            this.pictureBox1.Location = new System.Drawing.Point(7, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // YaxisCheck
            // 
            this.YaxisCheck.AutoSize = true;
            this.YaxisCheck.Location = new System.Drawing.Point(333, 188);
            this.YaxisCheck.Name = "YaxisCheck";
            this.YaxisCheck.Size = new System.Drawing.Size(15, 14);
            this.YaxisCheck.TabIndex = 22;
            this.YaxisCheck.UseVisualStyleBackColor = true;
            this.YaxisCheck.CheckedChanged += new System.EventHandler(this.Yaxis_CheckedChanged);
            // 
            // FullScreenCheck
            // 
            this.FullScreenCheck.AutoSize = true;
            this.FullScreenCheck.Location = new System.Drawing.Point(122, 187);
            this.FullScreenCheck.Name = "FullScreenCheck";
            this.FullScreenCheck.Size = new System.Drawing.Size(15, 14);
            this.FullScreenCheck.TabIndex = 23;
            this.FullScreenCheck.UseVisualStyleBackColor = true;
            this.FullScreenCheck.CheckedChanged += new System.EventHandler(this.FullScreenCheck_CheckedChanged);
            // 
            // WriteConfig
            // 
            this.WriteConfig.Location = new System.Drawing.Point(136, 437);
            this.WriteConfig.Name = "WriteConfig";
            this.WriteConfig.Size = new System.Drawing.Size(98, 23);
            this.WriteConfig.TabIndex = 26;
            this.WriteConfig.Text = "Write New";
            this.WriteConfig.UseVisualStyleBackColor = true;
            this.WriteConfig.Click += new System.EventHandler(this.WriteConfig_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(344, 437);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 23);
            this.Back.TabIndex = 28;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Resolution
            // 
            this.Resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Resolution.FormattingEnabled = true;
            this.Resolution.Items.AddRange(new object[] {
            "Custom",
            "1920 x 1200",
            "1920 x 1080",
            "1440 x 900",
            "1366 x 768",
            "1280 x 1024",
            "1280 x 720",
            "1024 x 768",
            "800 x 600"});
            this.Resolution.Location = new System.Drawing.Point(122, 211);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(121, 21);
            this.Resolution.TabIndex = 31;
            this.Resolution.SelectedIndex = 1;
            this.Resolution.SelectedIndexChanged += new System.EventHandler(this.Resolution_SelectedIndexChanged);
            // 
            // fullScreenLabel
            // 
            this.fullScreenLabel.AutoSize = true;
            this.fullScreenLabel.Location = new System.Drawing.Point(13, 187);
            this.fullScreenLabel.Name = "fullScreenLabel";
            this.fullScreenLabel.Size = new System.Drawing.Size(63, 13);
            this.fullScreenLabel.TabIndex = 32;
            this.fullScreenLabel.Text = "Full Screen:";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(13, 214);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(60, 13);
            this.resolutionLabel.TabIndex = 33;
            this.resolutionLabel.Text = "Resolution:";
            // 
            // antialiasingLabel
            // 
            this.antialiasingLabel.AutoSize = true;
            this.antialiasingLabel.Location = new System.Drawing.Point(13, 241);
            this.antialiasingLabel.Name = "antialiasingLabel";
            this.antialiasingLabel.Size = new System.Drawing.Size(63, 13);
            this.antialiasingLabel.TabIndex = 34;
            this.antialiasingLabel.Text = "Antialiasing:";
            // 
            // renderDistanceLabel
            // 
            this.renderDistanceLabel.AutoSize = true;
            this.renderDistanceLabel.Location = new System.Drawing.Point(13, 267);
            this.renderDistanceLabel.Name = "renderDistanceLabel";
            this.renderDistanceLabel.Size = new System.Drawing.Size(90, 13);
            this.renderDistanceLabel.TabIndex = 35;
            this.renderDistanceLabel.Text = "Render Distance:";
            // 
            // soundVolumeLabel
            // 
            this.soundVolumeLabel.AutoSize = true;
            this.soundVolumeLabel.Location = new System.Drawing.Point(13, 377);
            this.soundVolumeLabel.Name = "soundVolumeLabel";
            this.soundVolumeLabel.Size = new System.Drawing.Size(79, 13);
            this.soundVolumeLabel.TabIndex = 36;
            this.soundVolumeLabel.Text = "Sound Volume:";
            // 
            // musicVolumeLabel
            // 
            this.musicVolumeLabel.AutoSize = true;
            this.musicVolumeLabel.Location = new System.Drawing.Point(13, 350);
            this.musicVolumeLabel.Name = "musicVolumeLabel";
            this.musicVolumeLabel.Size = new System.Drawing.Size(76, 13);
            this.musicVolumeLabel.TabIndex = 37;
            this.musicVolumeLabel.Text = "Music Volume:";
            // 
            // cameraSmoothLabel
            // 
            this.cameraSmoothLabel.AutoSize = true;
            this.cameraSmoothLabel.Location = new System.Drawing.Point(13, 295);
            this.cameraSmoothLabel.Name = "cameraSmoothLabel";
            this.cameraSmoothLabel.Size = new System.Drawing.Size(107, 13);
            this.cameraSmoothLabel.TabIndex = 38;
            this.cameraSmoothLabel.Text = "Camera Smoothness:";
            // 
            // cameraSpeedLabel
            // 
            this.cameraSpeedLabel.AutoSize = true;
            this.cameraSpeedLabel.Location = new System.Drawing.Point(13, 322);
            this.cameraSpeedLabel.Name = "cameraSpeedLabel";
            this.cameraSpeedLabel.Size = new System.Drawing.Size(80, 13);
            this.cameraSpeedLabel.TabIndex = 39;
            this.cameraSpeedLabel.Text = "Camera Speed:";
            // 
            // fpsLimitLabel
            // 
            this.fpsLimitLabel.AutoSize = true;
            this.fpsLimitLabel.Location = new System.Drawing.Point(252, 267);
            this.fpsLimitLabel.Name = "fpsLimitLabel";
            this.fpsLimitLabel.Size = new System.Drawing.Size(54, 13);
            this.fpsLimitLabel.TabIndex = 40;
            this.fpsLimitLabel.Text = "FPS Limit:";
            // 
            // antialiasingBox
            // 
            this.antialiasingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.antialiasingBox.FormattingEnabled = true;
            this.antialiasingBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled 2x",
            "Enabled 4x"});
            this.antialiasingBox.Location = new System.Drawing.Point(122, 237);
            this.antialiasingBox.Name = "antialiasingBox";
            this.antialiasingBox.Size = new System.Drawing.Size(121, 21);
            this.antialiasingBox.TabIndex = 41;
            this.antialiasingBox.SelectedIndex = 0;
            this.antialiasingBox.SelectedIndexChanged += new System.EventHandler(this.antialiasingBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Game Config Generator";
            // 
            // widthCustomLabel
            // 
            this.widthCustomLabel.AutoSize = true;
            this.widthCustomLabel.Location = new System.Drawing.Point(252, 214);
            this.widthCustomLabel.Name = "widthCustomLabel";
            this.widthCustomLabel.Size = new System.Drawing.Size(38, 13);
            this.widthCustomLabel.TabIndex = 43;
            this.widthCustomLabel.Text = "Width:";
            // 
            // heightCustomLabel
            // 
            this.heightCustomLabel.AutoSize = true;
            this.heightCustomLabel.Location = new System.Drawing.Point(252, 241);
            this.heightCustomLabel.Name = "heightCustomLabel";
            this.heightCustomLabel.Size = new System.Drawing.Size(41, 13);
            this.heightCustomLabel.TabIndex = 44;
            this.heightCustomLabel.Text = "Height:";
            // 
            // invertY_AxisLabel
            // 
            this.invertY_AxisLabel.AutoSize = true;
            this.invertY_AxisLabel.Location = new System.Drawing.Point(252, 188);
            this.invertY_AxisLabel.Name = "invertY_AxisLabel";
            this.invertY_AxisLabel.Size = new System.Drawing.Size(69, 13);
            this.invertY_AxisLabel.TabIndex = 45;
            this.invertY_AxisLabel.Text = "Invert Y-Axis:";
            // 
            // editCurrentConfig
            // 
            this.editCurrentConfig.Location = new System.Drawing.Point(240, 437);
            this.editCurrentConfig.Name = "editCurrentConfig";
            this.editCurrentConfig.Size = new System.Drawing.Size(98, 23);
            this.editCurrentConfig.TabIndex = 46;
            this.editCurrentConfig.Text = "Edit Current";
            this.editCurrentConfig.UseVisualStyleBackColor = true;
            this.editCurrentConfig.Click += new System.EventHandler(this.editCurrentConfig_Click);
            // 
            // renderDistanceList
            // 
            this.renderDistanceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renderDistanceList.FormattingEnabled = true;
            this.renderDistanceList.Items.AddRange(new object[] {
            "100%",
            "95%",
            "90%",
            "85%",
            "80%",
            "75%",
            "70%",
            "65%",
            "60%",
            "55%",
            "50%",
            "45%",
            "40%",
            "35%",
            "30%",
            "25%"});
            this.renderDistanceList.Location = new System.Drawing.Point(122, 264);
            this.renderDistanceList.Name = "renderDistanceList";
            this.renderDistanceList.Size = new System.Drawing.Size(121, 21);
            this.renderDistanceList.TabIndex = 47;
            this.renderDistanceList.SelectedIndex = 0;
            this.renderDistanceList.SelectedIndexChanged += new System.EventHandler(this.renderDistanceList_SelectedIndexChanged);
            // 
            // cameraSmoothList
            // 
            this.cameraSmoothList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraSmoothList.FormattingEnabled = true;
            this.cameraSmoothList.Items.AddRange(new object[] {
            "100%",
            "95%",
            "90%",
            "85%",
            "80%",
            "75%",
            "70%",
            "65%",
            "60%",
            "55%",
            "50%",
            "45%",
            "40%",
            "35%",
            "30%",
            "25%",
            "20%",
            "15%",
            "10%",
            "5%",
            "0%"});
            this.cameraSmoothList.Location = new System.Drawing.Point(122, 292);
            this.cameraSmoothList.Name = "cameraSmoothList";
            this.cameraSmoothList.Size = new System.Drawing.Size(121, 21);
            this.cameraSmoothList.TabIndex = 48;
            this.cameraSmoothList.SelectedIndex = 0;
            this.cameraSmoothList.SelectedIndexChanged += new System.EventHandler(this.cameraSmoothList_SelectedIndexChanged);
            // 
            // cameraSpeedList
            // 
            this.cameraSpeedList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraSpeedList.FormattingEnabled = true;
            this.cameraSpeedList.Items.AddRange(new object[] {
            "100%",
            "95%",
            "90%",
            "85%",
            "80%",
            "75%",
            "70%",
            "65%",
            "60%",
            "55%",
            "50%",
            "45%",
            "40%",
            "35%",
            "30%",
            "25%",
            "20%",
            "15%",
            "10%"});
            this.cameraSpeedList.Location = new System.Drawing.Point(122, 319);
            this.cameraSpeedList.Name = "cameraSpeedList";
            this.cameraSpeedList.Size = new System.Drawing.Size(121, 21);
            this.cameraSpeedList.TabIndex = 49;
            this.cameraSpeedList.SelectedIndex = 0;
            this.cameraSpeedList.SelectedIndexChanged += new System.EventHandler(this.cameraSpeedList_SelectedIndexChanged);
            // 
            // musicVolList
            // 
            this.musicVolList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musicVolList.FormattingEnabled = true;
            this.musicVolList.Items.AddRange(new object[] {
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%",
            "Disabled"});
            this.musicVolList.Location = new System.Drawing.Point(121, 347);
            this.musicVolList.Name = "musicVolList";
            this.musicVolList.Size = new System.Drawing.Size(121, 21);
            this.musicVolList.TabIndex = 50;
            this.musicVolList.SelectedIndex = 0;
            this.musicVolList.SelectedIndexChanged += new System.EventHandler(this.musicVolList_SelectedIndexChanged);
            // 
            // soundVolList
            // 
            this.soundVolList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soundVolList.FormattingEnabled = true;
            this.soundVolList.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "0"});
            this.soundVolList.Location = new System.Drawing.Point(121, 374);
            this.soundVolList.Name = "soundVolList";
            this.soundVolList.Size = new System.Drawing.Size(121, 21);
            this.soundVolList.TabIndex = 51;
            this.soundVolList.SelectedIndex = 0;
            this.soundVolList.SelectedIndexChanged += new System.EventHandler(this.soundVolList_SelectedIndexChanged);
            // 
            // fpsLimit
            // 
            this.fpsLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fpsLimit.FormattingEnabled = true;
            this.fpsLimit.Items.AddRange(new object[] {
            "Unlimited",
            "1000",
            "500",
            "250",
            "166",
            "100",
            "76",
            "58",
            "40",
            "30",
            "20"});
            this.fpsLimit.Location = new System.Drawing.Point(333, 264);
            this.fpsLimit.Name = "fpsLimit";
            this.fpsLimit.Size = new System.Drawing.Size(100, 21);
            this.fpsLimit.TabIndex = 55;
            this.fpsLimit.SelectedIndex = 0;
            this.fpsLimit.SelectedIndexChanged += new System.EventHandler(this.fpsLimit_SelectedIndexChanged);
            // 
            // widthCust
            //
            this.widthCust.Enabled = false;
            this.widthCust.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.widthCust.Location = new System.Drawing.Point(333, 211);
            this.widthCust.Name = "widthCust";
            this.widthCust.Size = new System.Drawing.Size(100, 20);
            this.widthCust.TabIndex = 56;
            this.widthCust.TextChanged += new System.EventHandler(this.widthCust_TextChanged);
            this.widthCust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthCust_KeyPress_1);
            // 
            // heightCust
            //
            this.heightCust.Enabled = false;
            this.heightCust.Location = new System.Drawing.Point(333, 238);
            this.heightCust.Name = "heightCust";
            this.heightCust.Size = new System.Drawing.Size(100, 20);
            this.heightCust.TabIndex = 57;
            this.heightCust.TextChanged += new System.EventHandler(this.heightCust_TextChanged);
            this.heightCust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightCust_KeyPress);
            // 
            // GameSettings
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 472);
            this.Controls.Add(this.heightCust);
            this.Controls.Add(this.widthCust);
            this.Controls.Add(this.fpsLimit);
            this.Controls.Add(this.soundVolList);
            this.Controls.Add(this.musicVolList);
            this.Controls.Add(this.cameraSpeedList);
            this.Controls.Add(this.cameraSmoothList);
            this.Controls.Add(this.renderDistanceList);
            this.Controls.Add(this.editCurrentConfig);
            this.Controls.Add(this.invertY_AxisLabel);
            this.Controls.Add(this.heightCustomLabel);
            this.Controls.Add(this.widthCustomLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.antialiasingBox);
            this.Controls.Add(this.fpsLimitLabel);
            this.Controls.Add(this.cameraSpeedLabel);
            this.Controls.Add(this.cameraSmoothLabel);
            this.Controls.Add(this.musicVolumeLabel);
            this.Controls.Add(this.soundVolumeLabel);
            this.Controls.Add(this.renderDistanceLabel);
            this.Controls.Add(this.antialiasingLabel);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.fullScreenLabel);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.WriteConfig);
            this.Controls.Add(this.FullScreenCheck);
            this.Controls.Add(this.YaxisCheck);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameSettings";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox YaxisCheck;
        private System.Windows.Forms.CheckBox FullScreenCheck;
        private System.Windows.Forms.Button WriteConfig;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox Resolution;
        private System.Windows.Forms.Label fullScreenLabel;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Label antialiasingLabel;
        private System.Windows.Forms.Label renderDistanceLabel;
        private System.Windows.Forms.Label soundVolumeLabel;
        private System.Windows.Forms.Label musicVolumeLabel;
        private System.Windows.Forms.Label cameraSmoothLabel;
        private System.Windows.Forms.Label cameraSpeedLabel;
        private System.Windows.Forms.Label fpsLimitLabel;
        private System.Windows.Forms.ComboBox antialiasingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label widthCustomLabel;
        private System.Windows.Forms.Label heightCustomLabel;
        private System.Windows.Forms.Label invertY_AxisLabel;
        private System.Windows.Forms.Button editCurrentConfig;
        private System.Windows.Forms.ComboBox renderDistanceList;
        private System.Windows.Forms.ComboBox cameraSmoothList;
        private System.Windows.Forms.ComboBox cameraSpeedList;
        private System.Windows.Forms.ComboBox musicVolList;
        private System.Windows.Forms.ComboBox soundVolList;
        private System.Windows.Forms.ComboBox fpsLimit;
        private System.Windows.Forms.TextBox widthCust;
        private System.Windows.Forms.TextBox heightCust;
    }
}
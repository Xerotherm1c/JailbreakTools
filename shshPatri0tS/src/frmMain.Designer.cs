namespace shshPatri0tS {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbECIDType = new System.Windows.Forms.ComboBox();
            this.tbECID = new System.Windows.Forms.TextBox();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.lblECID = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lblBoardConfig = new System.Windows.Forms.Label();
            this.btnSaveBlobs = new System.Windows.Forms.Button();
            this.cbBoardConfig = new System.Windows.Forms.ComboBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.gbDeviceInfo = new System.Windows.Forms.GroupBox();
            this.chkSchedulingEnabled = new System.Windows.Forms.CheckBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.lblProfiles = new System.Windows.Forms.Label();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkApnonce = new System.Windows.Forms.CheckBox();
            this.cbApnonce = new System.Windows.Forms.ComboBox();
            this.btnAutoFetch = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutShshPatri0tSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPSWFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedBlobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutShshPatri0tSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAutosavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llToggleOutput = new System.Windows.Forms.LinkLabel();
            this.timerSilentWait = new System.Windows.Forms.Timer(this.components);
            this.llPatreon = new System.Windows.Forms.LinkLabel();
            this.gbDeviceInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbECIDType
            // 
            this.cbECIDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbECIDType.FormattingEnabled = true;
            this.cbECIDType.Items.AddRange(new object[] {
            "Hex (iTunes)",
            "Dec (UDID Calculator/ideviceinfo)"});
            this.cbECIDType.Location = new System.Drawing.Point(124, 98);
            this.cbECIDType.Name = "cbECIDType";
            this.cbECIDType.Size = new System.Drawing.Size(117, 21);
            this.cbECIDType.TabIndex = 0;
            this.cbECIDType.SelectedIndexChanged += new System.EventHandler(this.cbECIDType_SelectedIndexChanged);
            // 
            // tbECID
            // 
            this.tbECID.Location = new System.Drawing.Point(247, 99);
            this.tbECID.Name = "tbECID";
            this.tbECID.Size = new System.Drawing.Size(152, 20);
            this.tbECID.TabIndex = 1;
            // 
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Items.AddRange(new object[] {
            "iPhone",
            "iPod",
            "iPad",
            "AppleTV"});
            this.cbDevice.Location = new System.Drawing.Point(124, 125);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(117, 21);
            this.cbDevice.TabIndex = 2;
            this.cbDevice.SelectedIndexChanged += new System.EventHandler(this.cbDevice_SelectedIndexChanged);
            // 
            // lblECID
            // 
            this.lblECID.AutoSize = true;
            this.lblECID.Location = new System.Drawing.Point(50, 101);
            this.lblECID.Name = "lblECID";
            this.lblECID.Size = new System.Drawing.Size(32, 13);
            this.lblECID.TabIndex = 4;
            this.lblECID.Text = "ECID";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(50, 128);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(41, 13);
            this.lblDevice.TabIndex = 5;
            this.lblDevice.Text = "Device";
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(247, 125);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(275, 21);
            this.cbModel.TabIndex = 6;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // lblBoardConfig
            // 
            this.lblBoardConfig.AutoSize = true;
            this.lblBoardConfig.Location = new System.Drawing.Point(50, 159);
            this.lblBoardConfig.Name = "lblBoardConfig";
            this.lblBoardConfig.Size = new System.Drawing.Size(68, 13);
            this.lblBoardConfig.TabIndex = 7;
            this.lblBoardConfig.Text = "Board Config";
            // 
            // btnSaveBlobs
            // 
            this.btnSaveBlobs.Location = new System.Drawing.Point(406, 208);
            this.btnSaveBlobs.Name = "btnSaveBlobs";
            this.btnSaveBlobs.Size = new System.Drawing.Size(117, 23);
            this.btnSaveBlobs.TabIndex = 8;
            this.btnSaveBlobs.Text = "Save Blobs";
            this.btnSaveBlobs.UseVisualStyleBackColor = true;
            this.btnSaveBlobs.Click += new System.EventHandler(this.btnSaveBlobs_Click);
            // 
            // cbBoardConfig
            // 
            this.cbBoardConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoardConfig.Enabled = false;
            this.cbBoardConfig.FormattingEnabled = true;
            this.cbBoardConfig.Items.AddRange(new object[] {
            "iPhone",
            "iPod",
            "iPad",
            "AppleTV"});
            this.cbBoardConfig.Location = new System.Drawing.Point(124, 156);
            this.cbBoardConfig.Name = "cbBoardConfig";
            this.cbBoardConfig.Size = new System.Drawing.Size(117, 21);
            this.cbBoardConfig.TabIndex = 9;
            // 
            // rtbOutput
            // 
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Location = new System.Drawing.Point(29, 552);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(577, 147);
            this.rtbOutput.TabIndex = 10;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(29, 494);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(577, 23);
            this.pbProgress.Step = 1;
            this.pbProgress.TabIndex = 11;
            // 
            // gbDeviceInfo
            // 
            this.gbDeviceInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbDeviceInfo.Controls.Add(this.chkSchedulingEnabled);
            this.gbDeviceInfo.Controls.Add(this.lblSeparator);
            this.gbDeviceInfo.Controls.Add(this.btnLoadProfile);
            this.gbDeviceInfo.Controls.Add(this.btnSaveProfile);
            this.gbDeviceInfo.Controls.Add(this.lblProfiles);
            this.gbDeviceInfo.Controls.Add(this.cbProfiles);
            this.gbDeviceInfo.Controls.Add(this.label1);
            this.gbDeviceInfo.Controls.Add(this.chkApnonce);
            this.gbDeviceInfo.Controls.Add(this.cbApnonce);
            this.gbDeviceInfo.Controls.Add(this.btnAutoFetch);
            this.gbDeviceInfo.Controls.Add(this.cbECIDType);
            this.gbDeviceInfo.Controls.Add(this.tbECID);
            this.gbDeviceInfo.Controls.Add(this.cbDevice);
            this.gbDeviceInfo.Controls.Add(this.cbBoardConfig);
            this.gbDeviceInfo.Controls.Add(this.lblECID);
            this.gbDeviceInfo.Controls.Add(this.btnSaveBlobs);
            this.gbDeviceInfo.Controls.Add(this.lblDevice);
            this.gbDeviceInfo.Controls.Add(this.lblBoardConfig);
            this.gbDeviceInfo.Controls.Add(this.cbModel);
            this.gbDeviceInfo.Location = new System.Drawing.Point(29, 233);
            this.gbDeviceInfo.Name = "gbDeviceInfo";
            this.gbDeviceInfo.Size = new System.Drawing.Size(577, 255);
            this.gbDeviceInfo.TabIndex = 12;
            this.gbDeviceInfo.TabStop = false;
            this.gbDeviceInfo.Text = "Device Information";
            // 
            // chkSchedulingEnabled
            // 
            this.chkSchedulingEnabled.AutoSize = true;
            this.chkSchedulingEnabled.Location = new System.Drawing.Point(53, 212);
            this.chkSchedulingEnabled.Name = "chkSchedulingEnabled";
            this.chkSchedulingEnabled.Size = new System.Drawing.Size(349, 17);
            this.chkSchedulingEnabled.TabIndex = 20;
            this.chkSchedulingEnabled.Text = "This profile should automatically check for and download shsh blobs!";
            this.chkSchedulingEnabled.UseVisualStyleBackColor = true;
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(26, 75);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(525, 2);
            this.lblSeparator.TabIndex = 19;
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.Enabled = false;
            this.btnLoadProfile.Location = new System.Drawing.Point(124, 32);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(117, 23);
            this.btnLoadProfile.TabIndex = 18;
            this.btnLoadProfile.Text = "Load Profile";
            this.btnLoadProfile.UseVisualStyleBackColor = true;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(406, 32);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(117, 23);
            this.btnSaveProfile.TabIndex = 17;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // lblProfiles
            // 
            this.lblProfiles.AutoSize = true;
            this.lblProfiles.Location = new System.Drawing.Point(52, 36);
            this.lblProfiles.Name = "lblProfiles";
            this.lblProfiles.Size = new System.Drawing.Size(41, 13);
            this.lblProfiles.TabIndex = 16;
            this.lblProfiles.Text = "Profiles";
            // 
            // cbProfiles
            // 
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.Location = new System.Drawing.Point(247, 33);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(152, 21);
            this.cbProfiles.TabIndex = 15;
            this.cbProfiles.SelectedValueChanged += new System.EventHandler(this.cbProfiles_SelectedValueChanged);
            this.cbProfiles.LostFocus += new System.EventHandler(this.cbProfiles_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apnonce";
            // 
            // chkApnonce
            // 
            this.chkApnonce.AutoSize = true;
            this.chkApnonce.Location = new System.Drawing.Point(247, 158);
            this.chkApnonce.Name = "chkApnonce";
            this.chkApnonce.Size = new System.Drawing.Size(279, 17);
            this.chkApnonce.TabIndex = 13;
            this.chkApnonce.Text = "Specify Apnonce Manually (Use this at your own risk.)";
            this.chkApnonce.UseVisualStyleBackColor = true;
            this.chkApnonce.CheckedChanged += new System.EventHandler(this.chkApnonce_CheckedChanged);
            // 
            // cbApnonce
            // 
            this.cbApnonce.Enabled = false;
            this.cbApnonce.FormattingEnabled = true;
            this.cbApnonce.Location = new System.Drawing.Point(247, 181);
            this.cbApnonce.Name = "cbApnonce";
            this.cbApnonce.Size = new System.Drawing.Size(275, 21);
            this.cbApnonce.TabIndex = 11;
            // 
            // btnAutoFetch
            // 
            this.btnAutoFetch.Location = new System.Drawing.Point(406, 97);
            this.btnAutoFetch.Name = "btnAutoFetch";
            this.btnAutoFetch.Size = new System.Drawing.Size(117, 23);
            this.btnAutoFetch.TabIndex = 10;
            this.btnAutoFetch.Text = "AutoFetch";
            this.btnAutoFetch.UseVisualStyleBackColor = true;
            this.btnAutoFetch.Click += new System.EventHandler(this.btnAutoFetch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.schedulingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutShshPatri0tSToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.deleteProfileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openFolderToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutShshPatri0tSToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutShshPatri0tSToolStripMenuItem
            // 
            this.aboutShshPatri0tSToolStripMenuItem.Name = "aboutShshPatri0tSToolStripMenuItem";
            this.aboutShshPatri0tSToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutShshPatri0tSToolStripMenuItem.Text = "New Profile";
            this.aboutShshPatri0tSToolStripMenuItem.Click += new System.EventHandler(this.aboutShshPatri0tSToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Save Profile";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteProfileToolStripMenuItem.Text = "Delete Profile";
            this.deleteProfileToolStripMenuItem.Click += new System.EventHandler(this.deleteProfileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPSWFolderToolStripMenuItem,
            this.savedBlobsToolStripMenuItem,
            this.appDirectoryToolStripMenuItem});
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openFolderToolStripMenuItem.Text = "Open";
            // 
            // iPSWFolderToolStripMenuItem
            // 
            this.iPSWFolderToolStripMenuItem.Name = "iPSWFolderToolStripMenuItem";
            this.iPSWFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iPSWFolderToolStripMenuItem.Text = "IPSW Folder";
            this.iPSWFolderToolStripMenuItem.Click += new System.EventHandler(this.iPSWFolderToolStripMenuItem_Click);
            // 
            // savedBlobsToolStripMenuItem
            // 
            this.savedBlobsToolStripMenuItem.Name = "savedBlobsToolStripMenuItem";
            this.savedBlobsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.savedBlobsToolStripMenuItem.Text = "Saved Blobs";
            this.savedBlobsToolStripMenuItem.Click += new System.EventHandler(this.savedBlobsToolStripMenuItem_Click);
            // 
            // appDirectoryToolStripMenuItem
            // 
            this.appDirectoryToolStripMenuItem.Name = "appDirectoryToolStripMenuItem";
            this.appDirectoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.appDirectoryToolStripMenuItem.Text = "App Directory";
            this.appDirectoryToolStripMenuItem.Click += new System.EventHandler(this.appDirectoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // aboutShshPatri0tSToolStripMenuItem1
            // 
            this.aboutShshPatri0tSToolStripMenuItem1.Name = "aboutShshPatri0tSToolStripMenuItem1";
            this.aboutShshPatri0tSToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.aboutShshPatri0tSToolStripMenuItem1.Text = "About shshPatri0tS";
            this.aboutShshPatri0tSToolStripMenuItem1.Click += new System.EventHandler(this.aboutShshPatri0tSToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // schedulingToolStripMenuItem
            // 
            this.schedulingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyAutosavesToolStripMenuItem});
            this.schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            this.schedulingToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.schedulingToolStripMenuItem.Text = "Scheduling";
            // 
            // modifyAutosavesToolStripMenuItem
            // 
            this.modifyAutosavesToolStripMenuItem.Name = "modifyAutosavesToolStripMenuItem";
            this.modifyAutosavesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modifyAutosavesToolStripMenuItem.Text = "Modify Autosaves";
            this.modifyAutosavesToolStripMenuItem.Click += new System.EventHandler(this.modifyAutosavesToolStripMenuItem_Click);
            // 
            // llToggleOutput
            // 
            this.llToggleOutput.ActiveLinkColor = System.Drawing.Color.White;
            this.llToggleOutput.AutoSize = true;
            this.llToggleOutput.BackColor = System.Drawing.Color.Transparent;
            this.llToggleOutput.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.llToggleOutput.Location = new System.Drawing.Point(26, 531);
            this.llToggleOutput.Name = "llToggleOutput";
            this.llToggleOutput.Size = new System.Drawing.Size(100, 13);
            this.llToggleOutput.TabIndex = 15;
            this.llToggleOutput.TabStop = true;
            this.llToggleOutput.Text = "Toggle Raw Output";
            this.llToggleOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llToggleOutput_LinkClicked);
            // 
            // timerSilentWait
            // 
            this.timerSilentWait.Tick += new System.EventHandler(this.timerSilentWait_Tick);
            // 
            // llPatreon
            // 
            this.llPatreon.AutoSize = true;
            this.llPatreon.BackColor = System.Drawing.Color.Transparent;
            this.llPatreon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPatreon.LinkColor = System.Drawing.Color.Lime;
            this.llPatreon.Location = new System.Drawing.Point(400, 529);
            this.llPatreon.Name = "llPatreon";
            this.llPatreon.Size = new System.Drawing.Size(210, 16);
            this.llPatreon.TabIndex = 16;
            this.llPatreon.TabStop = true;
            this.llPatreon.Text = "Support Development via Patreon";
            this.llPatreon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPatreon_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 551);
            this.Controls.Add(this.llPatreon);
            this.Controls.Add(this.llToggleOutput);
            this.Controls.Add(this.gbDeviceInfo);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "shshPatri0tS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbDeviceInfo.ResumeLayout(false);
            this.gbDeviceInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbECIDType;
        private System.Windows.Forms.TextBox tbECID;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Label lblECID;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label lblBoardConfig;
        private System.Windows.Forms.Button btnSaveBlobs;
        private System.Windows.Forms.ComboBox cbBoardConfig;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.GroupBox gbDeviceInfo;
        private System.Windows.Forms.Button btnAutoFetch;
        private System.Windows.Forms.CheckBox chkApnonce;
        private System.Windows.Forms.ComboBox cbApnonce;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutShshPatri0tSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Label lblProfiles;
        private System.Windows.Forms.ComboBox cbProfiles;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPSWFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savedBlobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.CheckBox chkSchedulingEnabled;
        private System.Windows.Forms.ToolStripMenuItem schedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAutosavesToolStripMenuItem;
        private System.Windows.Forms.LinkLabel llToggleOutput;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutShshPatri0tSToolStripMenuItem1;
        private System.Windows.Forms.Timer timerSilentWait;
        private System.Windows.Forms.LinkLabel llPatreon;
    }
}
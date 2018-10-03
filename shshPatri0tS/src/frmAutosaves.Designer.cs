namespace shshPatri0tS {
    partial class frmAutosaves {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutosaves));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbAutosaving = new System.Windows.Forms.GroupBox();
            this.chkCondesneNotifications = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.gbCheckInterval = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblIntervalNote = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.gbAutosaving.SuspendLayout();
            this.gbCheckInterval.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel Changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Update Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbAutosaving
            // 
            this.gbAutosaving.Controls.Add(this.chkCondesneNotifications);
            this.gbAutosaving.Controls.Add(this.lblDescription);
            this.gbAutosaving.Controls.Add(this.chkEnable);
            this.gbAutosaving.Location = new System.Drawing.Point(12, 12);
            this.gbAutosaving.Name = "gbAutosaving";
            this.gbAutosaving.Size = new System.Drawing.Size(410, 177);
            this.gbAutosaving.TabIndex = 20;
            this.gbAutosaving.TabStop = false;
            this.gbAutosaving.Text = "Autosaving for Blobs";
            // 
            // chkCondesneNotifications
            // 
            this.chkCondesneNotifications.AutoSize = true;
            this.chkCondesneNotifications.Checked = true;
            this.chkCondesneNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCondesneNotifications.Enabled = false;
            this.chkCondesneNotifications.Location = new System.Drawing.Point(27, 148);
            this.chkCondesneNotifications.Name = "chkCondesneNotifications";
            this.chkCondesneNotifications.Size = new System.Drawing.Size(356, 17);
            this.chkCondesneNotifications.TabIndex = 22;
            this.chkCondesneNotifications.Text = "Condense profile notifications into a single \"final\" notification each day";
            this.chkCondesneNotifications.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(14, 18);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(383, 104);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(27, 125);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(344, 17);
            this.chkEnable.TabIndex = 21;
            this.chkEnable.Text = "Yes! Enable autochecking and autosaving for shsh blobs every day";
            this.chkEnable.UseVisualStyleBackColor = true;
            this.chkEnable.CheckedChanged += new System.EventHandler(this.chkEnable_CheckedChanged);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(17, 39);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(80, 20);
            this.dtpStartTime.TabIndex = 22;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // gbCheckInterval
            // 
            this.gbCheckInterval.Controls.Add(this.label2);
            this.gbCheckInterval.Controls.Add(this.label1);
            this.gbCheckInterval.Controls.Add(this.dtpEndTime);
            this.gbCheckInterval.Controls.Add(this.lblIntervalNote);
            this.gbCheckInterval.Controls.Add(this.lblStartTime);
            this.gbCheckInterval.Controls.Add(this.dtpStartTime);
            this.gbCheckInterval.Location = new System.Drawing.Point(12, 215);
            this.gbCheckInterval.Name = "gbCheckInterval";
            this.gbCheckInterval.Size = new System.Drawing.Size(410, 138);
            this.gbCheckInterval.TabIndex = 23;
            this.gbCheckInterval.TabStop = false;
            this.gbCheckInterval.Text = "Autocheck Interavl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "End Time";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(317, 39);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(80, 20);
            this.dtpEndTime.TabIndex = 25;
            // 
            // lblIntervalNote
            // 
            this.lblIntervalNote.Location = new System.Drawing.Point(14, 71);
            this.lblIntervalNote.Name = "lblIntervalNote";
            this.lblIntervalNote.Size = new System.Drawing.Size(383, 53);
            this.lblIntervalNote.TabIndex = 24;
            this.lblIntervalNote.Text = resources.GetString("lblIntervalNote.Text");
            this.lblIntervalNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(14, 23);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 23;
            this.lblStartTime.Text = "Start Time";
            // 
            // frmAutosaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.gbCheckInterval);
            this.Controls.Add(this.gbAutosaving);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmAutosaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scheduled Autosaving";
            this.Load += new System.EventHandler(this.frmAutosaves_Load);
            this.gbAutosaving.ResumeLayout(false);
            this.gbAutosaving.PerformLayout();
            this.gbCheckInterval.ResumeLayout(false);
            this.gbCheckInterval.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbAutosaving;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.GroupBox gbCheckInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblIntervalNote;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.CheckBox chkCondesneNotifications;
    }
}
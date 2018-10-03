namespace shshPatri0tS {
    partial class frmAutoFetch {
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudApnonceQueries = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbApnonceQuerying = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAutoFetch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudApnonceQueries)).BeginInit();
            this.gbApnonceQuerying.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please ensure your iDevice is plugged in via USB.";
            // 
            // nudApnonceQueries
            // 
            this.nudApnonceQueries.Location = new System.Drawing.Point(256, 25);
            this.nudApnonceQueries.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudApnonceQueries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudApnonceQueries.Name = "nudApnonceQueries";
            this.nudApnonceQueries.Size = new System.Drawing.Size(58, 20);
            this.nudApnonceQueries.TabIndex = 1;
            this.nudApnonceQueries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudApnonceQueries.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of times to query Apnonce";
            // 
            // gbApnonceQuerying
            // 
            this.gbApnonceQuerying.Controls.Add(this.label3);
            this.gbApnonceQuerying.Controls.Add(this.label2);
            this.gbApnonceQuerying.Controls.Add(this.nudApnonceQueries);
            this.gbApnonceQuerying.Location = new System.Drawing.Point(17, 53);
            this.gbApnonceQuerying.Name = "gbApnonceQuerying";
            this.gbApnonceQuerying.Size = new System.Drawing.Size(400, 106);
            this.gbApnonceQuerying.TabIndex = 3;
            this.gbApnonceQuerying.TabStop = false;
            this.gbApnonceQuerying.Text = "Apnonce Querying";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(53, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "It is not recommended to query less than 10 times unless\r\nyou know an Apnonce tha" +
    "t your device frequently generates.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutoFetch
            // 
            this.btnAutoFetch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAutoFetch.Location = new System.Drawing.Point(267, 176);
            this.btnAutoFetch.Name = "btnAutoFetch";
            this.btnAutoFetch.Size = new System.Drawing.Size(150, 23);
            this.btnAutoFetch.TabIndex = 11;
            this.btnAutoFetch.Text = "Fetch Device Info";
            this.btnAutoFetch.UseVisualStyleBackColor = true;
            this.btnAutoFetch.Click += new System.EventHandler(this.btnAutoFetch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(17, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAutoFetch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAutoFetch);
            this.Controls.Add(this.gbApnonceQuerying);
            this.Controls.Add(this.label1);
            this.Name = "frmAutoFetch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto Fetch Device Info";
            ((System.ComponentModel.ISupportInitialize)(this.nudApnonceQueries)).EndInit();
            this.gbApnonceQuerying.ResumeLayout(false);
            this.gbApnonceQuerying.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudApnonceQueries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbApnonceQuerying;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAutoFetch;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace DVLD
{
    partial class AddnewLocalDrivingLicense
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVLocalApplication = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbISactive = new System.Windows.Forms.ComboBox();
            this.lbFilterby = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterUser = new System.Windows.Forms.ComboBox();
            this.lbCountRecords = new System.Windows.Forms.Label();
            this.lbRcords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechudleToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechudleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechudleWritenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechudleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocalApplication)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(496, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Driving License Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGVLocalApplication
            // 
            this.DGVLocalApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLocalApplication.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVLocalApplication.Location = new System.Drawing.Point(49, 210);
            this.DGVLocalApplication.Name = "DGVLocalApplication";
            this.DGVLocalApplication.RowHeadersWidth = 62;
            this.DGVLocalApplication.RowTemplate.Height = 29;
            this.DGVLocalApplication.Size = new System.Drawing.Size(1214, 423);
            this.DGVLocalApplication.TabIndex = 2;
            this.DGVLocalApplication.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLocalApplication_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.sechudleToolsToolStripMenuItem,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showToolStripMenuItem,
            this.showLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(342, 260);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cbISactive
            // 
            this.cbISactive.FormattingEnabled = true;
            this.cbISactive.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.cbISactive.Location = new System.Drawing.Point(262, 171);
            this.cbISactive.Name = "cbISactive";
            this.cbISactive.Size = new System.Drawing.Size(228, 27);
            this.cbISactive.TabIndex = 14;
            this.cbISactive.SelectedIndexChanged += new System.EventHandler(this.cbISactive_SelectedIndexChanged);
            // 
            // lbFilterby
            // 
            this.lbFilterby.AutoSize = true;
            this.lbFilterby.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterby.Location = new System.Drawing.Point(1, 172);
            this.lbFilterby.Name = "lbFilterby";
            this.lbFilterby.Size = new System.Drawing.Size(78, 22);
            this.lbFilterby.TabIndex = 13;
            this.lbFilterby.Text = "FilterBy";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(265, 171);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(228, 27);
            this.tbFilter.TabIndex = 12;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged_1);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilterUser
            // 
            this.cbFilterUser.FormattingEnabled = true;
            this.cbFilterUser.Items.AddRange(new object[] {
            "None",
            "LocalDrivingLicenseApplicationID",
            "NationalNo",
            "FullName",
            "Status"});
            this.cbFilterUser.Location = new System.Drawing.Point(80, 170);
            this.cbFilterUser.Name = "cbFilterUser";
            this.cbFilterUser.Size = new System.Drawing.Size(179, 27);
            this.cbFilterUser.TabIndex = 11;
            this.cbFilterUser.SelectedIndexChanged += new System.EventHandler(this.cbFilterUser_SelectedIndexChanged);
            // 
            // lbCountRecords
            // 
            this.lbCountRecords.AutoSize = true;
            this.lbCountRecords.Location = new System.Drawing.Point(123, 650);
            this.lbCountRecords.Name = "lbCountRecords";
            this.lbCountRecords.Size = new System.Drawing.Size(14, 19);
            this.lbCountRecords.TabIndex = 16;
            this.lbCountRecords.Text = " ";
            // 
            // lbRcords
            // 
            this.lbRcords.AutoSize = true;
            this.lbRcords.Location = new System.Drawing.Point(35, 650);
            this.lbRcords.Name = "lbRcords";
            this.lbRcords.Size = new System.Drawing.Size(82, 19);
            this.lbRcords.TabIndex = 15;
            this.lbRcords.Text = "# Records";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1061, 639);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 43);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.info_file;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(341, 32);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.imap_folder_write;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(341, 32);
            this.editApplicationToolStripMenuItem.Text = "Edit Application ";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.file_info;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(341, 32);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application ";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.document_close;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(341, 32);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application ";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // sechudleToolsToolStripMenuItem
            // 
            this.sechudleToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechudleVisionTestToolStripMenuItem,
            this.sechudleWritenTestToolStripMenuItem,
            this.sechudleStreetTestToolStripMenuItem});
            this.sechudleToolsToolStripMenuItem.Image = global::DVLD.Properties.Resources.schedule_config;
            this.sechudleToolsToolStripMenuItem.Name = "sechudleToolsToolStripMenuItem";
            this.sechudleToolsToolStripMenuItem.Size = new System.Drawing.Size(341, 32);
            this.sechudleToolsToolStripMenuItem.Text = "Sechudle Tools";
            this.sechudleToolsToolStripMenuItem.Click += new System.EventHandler(this.sechudleToolsToolStripMenuItem_Click);
            // 
            // sechudleVisionTestToolStripMenuItem
            // 
            this.sechudleVisionTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.eye;
            this.sechudleVisionTestToolStripMenuItem.Name = "sechudleVisionTestToolStripMenuItem";
            this.sechudleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.sechudleVisionTestToolStripMenuItem.Text = "Sechudle Vision Test";
            this.sechudleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.sechudleVisionTestToolStripMenuItem_Click);
            // 
            // sechudleWritenTestToolStripMenuItem
            // 
            this.sechudleWritenTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.text_message;
            this.sechudleWritenTestToolStripMenuItem.Name = "sechudleWritenTestToolStripMenuItem";
            this.sechudleWritenTestToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.sechudleWritenTestToolStripMenuItem.Text = "Sechudle Writen Test";
            this.sechudleWritenTestToolStripMenuItem.Click += new System.EventHandler(this.sechudleWritenTestToolStripMenuItem_Click);
            // 
            // sechudleStreetTestToolStripMenuItem
            // 
            this.sechudleStreetTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.police_car1;
            this.sechudleStreetTestToolStripMenuItem.Name = "sechudleStreetTestToolStripMenuItem";
            this.sechudleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.sechudleStreetTestToolStripMenuItem.Text = "Sechudle Street Test";
            this.sechudleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.sechudleStreetTestToolStripMenuItem_Click);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD.Properties.Resources.issue_log_check;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(341, 32);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License(First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::DVLD.Properties.Resources.view__1_;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(341, 32);
            this.showToolStripMenuItem.Text = "Show License ";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            this.showLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.history;
            this.showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            this.showLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(341, 32);
            this.showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            this.showLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.documents;
            this.pictureBox2.Location = new System.Drawing.Point(1164, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.documents__1_;
            this.pictureBox1.Location = new System.Drawing.Point(656, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AddnewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 687);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbCountRecords);
            this.Controls.Add(this.lbRcords);
            this.Controls.Add(this.cbISactive);
            this.Controls.Add(this.lbFilterby);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterUser);
            this.Controls.Add(this.DGVLocalApplication);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddnewLocalDrivingLicense";
            this.Text = "AddnewLocalDrivingLicense";
            this.Load += new System.EventHandler(this.AddnewLocalDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocalApplication)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DGVLocalApplication;
        private System.Windows.Forms.ComboBox cbISactive;
        private System.Windows.Forms.Label lbFilterby;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterUser;
        private System.Windows.Forms.Label lbCountRecords;
        private System.Windows.Forms.Label lbRcords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechudleToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechudleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechudleWritenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechudleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
    }
}
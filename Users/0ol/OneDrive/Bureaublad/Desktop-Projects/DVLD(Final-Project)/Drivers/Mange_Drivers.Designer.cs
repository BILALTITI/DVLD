namespace DVLD
{
    partial class Mange_Drivers
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
            this.DGVDrivers = new System.Windows.Forms.DataGridView();
            this.cbISactive = new System.Windows.Forms.ComboBox();
            this.lbFilterby = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterUser = new System.Windows.Forms.ComboBox();
            this.lbMAngeDeivers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbCountRecords = new System.Windows.Forms.Label();
            this.lbRcords = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDrivers
            // 
            this.DGVDrivers.AllowUserToAddRows = false;
            this.DGVDrivers.AllowUserToDeleteRows = false;
            this.DGVDrivers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDrivers.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVDrivers.Location = new System.Drawing.Point(3, 187);
            this.DGVDrivers.Name = "DGVDrivers";
            this.DGVDrivers.ReadOnly = true;
            this.DGVDrivers.RowHeadersWidth = 62;
            this.DGVDrivers.RowTemplate.Height = 29;
            this.DGVDrivers.Size = new System.Drawing.Size(1110, 348);
            this.DGVDrivers.TabIndex = 0;
            // 
            // cbISactive
            // 
            this.cbISactive.FormattingEnabled = true;
            this.cbISactive.Items.AddRange(new object[] {
            "All",
            "Yes ",
            "No"});
            this.cbISactive.Location = new System.Drawing.Point(272, 159);
            this.cbISactive.Name = "cbISactive";
            this.cbISactive.Size = new System.Drawing.Size(228, 27);
            this.cbISactive.TabIndex = 20;
            this.cbISactive.SelectedIndexChanged += new System.EventHandler(this.cbISactive_SelectedIndexChanged);
            // 
            // lbFilterby
            // 
            this.lbFilterby.AutoSize = true;
            this.lbFilterby.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterby.Location = new System.Drawing.Point(8, 159);
            this.lbFilterby.Name = "lbFilterby";
            this.lbFilterby.Size = new System.Drawing.Size(78, 22);
            this.lbFilterby.TabIndex = 19;
            this.lbFilterby.Text = "FilterBy";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(272, 158);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(228, 27);
            this.tbFilter.TabIndex = 18;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbFilterUser
            // 
            this.cbFilterUser.FormattingEnabled = true;
            this.cbFilterUser.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "CreatedByUserID"});
            this.cbFilterUser.Location = new System.Drawing.Point(87, 157);
            this.cbFilterUser.Name = "cbFilterUser";
            this.cbFilterUser.Size = new System.Drawing.Size(179, 27);
            this.cbFilterUser.TabIndex = 17;
            this.cbFilterUser.SelectedIndexChanged += new System.EventHandler(this.cbFilterUser_SelectedIndexChanged);
            // 
            // lbMAngeDeivers
            // 
            this.lbMAngeDeivers.AutoSize = true;
            this.lbMAngeDeivers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMAngeDeivers.ForeColor = System.Drawing.Color.Red;
            this.lbMAngeDeivers.Location = new System.Drawing.Point(482, 126);
            this.lbMAngeDeivers.Name = "lbMAngeDeivers";
            this.lbMAngeDeivers.Size = new System.Drawing.Size(184, 29);
            this.lbMAngeDeivers.TabIndex = 15;
            this.lbMAngeDeivers.Text = "Mange Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(487, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(910, 545);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 50);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbCountRecords
            // 
            this.lbCountRecords.AutoSize = true;
            this.lbCountRecords.Location = new System.Drawing.Point(91, 557);
            this.lbCountRecords.Name = "lbCountRecords";
            this.lbCountRecords.Size = new System.Drawing.Size(14, 19);
            this.lbCountRecords.TabIndex = 22;
            this.lbCountRecords.Text = " ";
            // 
            // lbRcords
            // 
            this.lbRcords.AutoSize = true;
            this.lbRcords.Location = new System.Drawing.Point(3, 557);
            this.lbRcords.Name = "lbRcords";
            this.lbRcords.Size = new System.Drawing.Size(82, 19);
            this.lbRcords.TabIndex = 21;
            this.lbRcords.Text = "# Records";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(318, 68);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // Mange_Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 601);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbCountRecords);
            this.Controls.Add(this.lbRcords);
            this.Controls.Add(this.cbISactive);
            this.Controls.Add(this.lbFilterby);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMAngeDeivers);
            this.Controls.Add(this.DGVDrivers);
            this.Name = "Mange_Drivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mange_Drivers";
            this.Load += new System.EventHandler(this.Mange_Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDrivers;
        private System.Windows.Forms.ComboBox cbISactive;
        private System.Windows.Forms.Label lbFilterby;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMAngeDeivers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbCountRecords;
        private System.Windows.Forms.Label lbRcords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}
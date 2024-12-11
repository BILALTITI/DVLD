namespace DVLD
{
    partial class DetaineLicenceList
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbCountRecords = new System.Windows.Forms.Label();
            this.lbRcords = new System.Windows.Forms.Label();
            this.cbISactive = new System.Windows.Forms.ComboBox();
            this.lbFilterby = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterUser = new System.Windows.Forms.ComboBox();
            this.lbMAngeDeivers = new System.Windows.Forms.Label();
            this.DGVDetaindList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicensesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reliseDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PBDetained = new System.Windows.Forms.PictureBox();
            this.PBReleise = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetaindList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDetained)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBReleise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(871, 651);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 43);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbCountRecords
            // 
            this.lbCountRecords.AutoSize = true;
            this.lbCountRecords.Location = new System.Drawing.Point(-67, 482);
            this.lbCountRecords.Name = "lbCountRecords";
            this.lbCountRecords.Size = new System.Drawing.Size(14, 19);
            this.lbCountRecords.TabIndex = 32;
            this.lbCountRecords.Text = " ";
            // 
            // lbRcords
            // 
            this.lbRcords.AutoSize = true;
            this.lbRcords.Location = new System.Drawing.Point(-155, 482);
            this.lbRcords.Name = "lbRcords";
            this.lbRcords.Size = new System.Drawing.Size(82, 19);
            this.lbRcords.TabIndex = 31;
            this.lbRcords.Text = "# Records";
            // 
            // cbISactive
            // 
            this.cbISactive.FormattingEnabled = true;
            this.cbISactive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbISactive.Location = new System.Drawing.Point(273, 201);
            this.cbISactive.Name = "cbISactive";
            this.cbISactive.Size = new System.Drawing.Size(228, 27);
            this.cbISactive.TabIndex = 30;
            this.cbISactive.SelectedIndexChanged += new System.EventHandler(this.cbISactive_SelectedIndexChanged);
            // 
            // lbFilterby
            // 
            this.lbFilterby.AutoSize = true;
            this.lbFilterby.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterby.Location = new System.Drawing.Point(-150, 84);
            this.lbFilterby.Name = "lbFilterby";
            this.lbFilterby.Size = new System.Drawing.Size(78, 22);
            this.lbFilterby.TabIndex = 29;
            this.lbFilterby.Text = "FilterBy";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(273, 201);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(228, 27);
            this.tbFilter.TabIndex = 28;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbFilterUser
            // 
            this.cbFilterUser.FormattingEnabled = true;
            this.cbFilterUser.Items.AddRange(new object[] {
            "None",
            "DetainID",
            "IsReleased",
            "NationalNo",
            "FullName",
            "ReleaseApplicationID"});
            this.cbFilterUser.Location = new System.Drawing.Point(88, 199);
            this.cbFilterUser.Name = "cbFilterUser";
            this.cbFilterUser.Size = new System.Drawing.Size(179, 27);
            this.cbFilterUser.TabIndex = 27;
            this.cbFilterUser.SelectedIndexChanged += new System.EventHandler(this.cbFilterUser_SelectedIndexChanged);
            // 
            // lbMAngeDeivers
            // 
            this.lbMAngeDeivers.AutoSize = true;
            this.lbMAngeDeivers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMAngeDeivers.ForeColor = System.Drawing.Color.Red;
            this.lbMAngeDeivers.Location = new System.Drawing.Point(382, 153);
            this.lbMAngeDeivers.Name = "lbMAngeDeivers";
            this.lbMAngeDeivers.Size = new System.Drawing.Size(325, 29);
            this.lbMAngeDeivers.TabIndex = 25;
            this.lbMAngeDeivers.Text = "Licence Detained Licenses";
            this.lbMAngeDeivers.Click += new System.EventHandler(this.lbMAngeDeivers_Click);
            // 
            // DGVDetaindList
            // 
            this.DGVDetaindList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVDetaindList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetaindList.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVDetaindList.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVDetaindList.Location = new System.Drawing.Point(12, 243);
            this.DGVDetaindList.Name = "DGVDetaindList";
            this.DGVDetaindList.RowHeadersWidth = 62;
            this.DGVDetaindList.RowTemplate.Height = 29;
            this.DGVDetaindList.Size = new System.Drawing.Size(1088, 348);
            this.DGVDetaindList.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicensesDetailsToolStripMenuItem,
            this.showPersonLicensesHistoryToolStripMenuItem,
            this.reliseDetainedLicensesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(331, 132);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.info_file;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(330, 32);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicensesDetailsToolStripMenuItem
            // 
            this.showLicensesDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.file;
            this.showLicensesDetailsToolStripMenuItem.Name = "showLicensesDetailsToolStripMenuItem";
            this.showLicensesDetailsToolStripMenuItem.Size = new System.Drawing.Size(330, 32);
            this.showLicensesDetailsToolStripMenuItem.Text = "Show Licenses Details";
            this.showLicensesDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicensesDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicensesHistoryToolStripMenuItem
            // 
            this.showPersonLicensesHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.user;
            this.showPersonLicensesHistoryToolStripMenuItem.Name = "showPersonLicensesHistoryToolStripMenuItem";
            this.showPersonLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(330, 32);
            this.showPersonLicensesHistoryToolStripMenuItem.Text = "Show Person Licenses History ";
            this.showPersonLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicensesHistoryToolStripMenuItem_Click);
            // 
            // reliseDetainedLicensesToolStripMenuItem
            // 
            this.reliseDetainedLicensesToolStripMenuItem.Image = global::DVLD.Properties.Resources.hand__1_;
            this.reliseDetainedLicensesToolStripMenuItem.Name = "reliseDetainedLicensesToolStripMenuItem";
            this.reliseDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(330, 32);
            this.reliseDetainedLicensesToolStripMenuItem.Text = "Relise Detained Licenses";
            this.reliseDetainedLicensesToolStripMenuItem.DropDownOpening += new System.EventHandler(this.reliseDetainedLicensesToolStripMenuItem_DropDownOpening);
            this.reliseDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.reliseDetainedLicensesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "FilterBy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 675);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 675);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "# Records";
            // 
            // PBDetained
            // 
            this.PBDetained.Image = global::DVLD.Properties.Resources.hand;
            this.PBDetained.Location = new System.Drawing.Point(945, 158);
            this.PBDetained.Name = "PBDetained";
            this.PBDetained.Size = new System.Drawing.Size(85, 69);
            this.PBDetained.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBDetained.TabIndex = 26;
            this.PBDetained.TabStop = false;
            this.PBDetained.Click += new System.EventHandler(this.PBDetained_Click);
            // 
            // PBReleise
            // 
            this.PBReleise.Image = global::DVLD.Properties.Resources.hand__1_;
            this.PBReleise.Location = new System.Drawing.Point(843, 158);
            this.PBReleise.Name = "PBReleise";
            this.PBReleise.Size = new System.Drawing.Size(87, 70);
            this.PBReleise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBReleise.TabIndex = 26;
            this.PBReleise.TabStop = false;
            this.PBReleise.Click += new System.EventHandler(this.PBReleise_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.hand;
            this.pictureBox1.Location = new System.Drawing.Point(443, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // DetaineLicenceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 748);
            this.Controls.Add(this.cbISactive);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbCountRecords);
            this.Controls.Add(this.lbRcords);
            this.Controls.Add(this.lbFilterby);
            this.Controls.Add(this.cbFilterUser);
            this.Controls.Add(this.PBDetained);
            this.Controls.Add(this.PBReleise);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMAngeDeivers);
            this.Controls.Add(this.DGVDetaindList);
            this.Name = "DetaineLicenceList";
            this.Text = "DetaineLicenceList";
            this.Load += new System.EventHandler(this.DetaineLicenceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetaindList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBDetained)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBReleise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbCountRecords;
        private System.Windows.Forms.Label lbRcords;
        private System.Windows.Forms.ComboBox cbISactive;
        private System.Windows.Forms.Label lbFilterby;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMAngeDeivers;
        private System.Windows.Forms.DataGridView DGVDetaindList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PBReleise;
        private System.Windows.Forms.PictureBox PBDetained;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicensesDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reliseDetainedLicensesToolStripMenuItem;
    }
}
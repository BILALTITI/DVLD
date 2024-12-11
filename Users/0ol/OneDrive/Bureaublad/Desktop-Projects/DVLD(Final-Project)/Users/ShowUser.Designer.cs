namespace DVLD
{
    partial class ShowUser
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
            this.lbRcords = new System.Windows.Forms.Label();
            this.DGVUser = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCountRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbFilterUser = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilterby = new System.Windows.Forms.Label();
            this.PBImageADD = new System.Windows.Forms.PictureBox();
            this.PBMangeImage = new System.Windows.Forms.PictureBox();
            this.cbISactive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageADD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMangeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(435, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // lbRcords
            // 
            this.lbRcords.AutoSize = true;
            this.lbRcords.Location = new System.Drawing.Point(55, 650);
            this.lbRcords.Name = "lbRcords";
            this.lbRcords.Size = new System.Drawing.Size(82, 19);
            this.lbRcords.TabIndex = 1;
            this.lbRcords.Text = "# Records";
            // 
            // DGVUser
            // 
            this.DGVUser.AllowUserToAddRows = false;
            this.DGVUser.AllowUserToDeleteRows = false;
            this.DGVUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUser.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVUser.Location = new System.Drawing.Point(12, 207);
            this.DGVUser.Name = "DGVUser";
            this.DGVUser.ReadOnly = true;
            this.DGVUser.RowHeadersWidth = 62;
            this.DGVUser.RowTemplate.Height = 29;
            this.DGVUser.Size = new System.Drawing.Size(977, 420);
            this.DGVUser.TabIndex = 2;
            this.DGVUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 228);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.info_file;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::DVLD.Properties.Resources.user_add;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.papers__1_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.person_boy__2_;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.password;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.email_next;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.phone;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.phoneCallToolStripMenuItem.Text = "Phone Call ";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // lbCountRecords
            // 
            this.lbCountRecords.AutoSize = true;
            this.lbCountRecords.Location = new System.Drawing.Point(143, 650);
            this.lbCountRecords.Name = "lbCountRecords";
            this.lbCountRecords.Size = new System.Drawing.Size(14, 19);
            this.lbCountRecords.TabIndex = 3;
            this.lbCountRecords.Text = " ";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(829, 633);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close ";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbFilterUser
            // 
            this.cbFilterUser.FormattingEnabled = true;
            this.cbFilterUser.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "FullName",
            "UserName",
            "IsActive"});
            this.cbFilterUser.Location = new System.Drawing.Point(166, 174);
            this.cbFilterUser.Name = "cbFilterUser";
            this.cbFilterUser.Size = new System.Drawing.Size(179, 27);
            this.cbFilterUser.TabIndex = 6;
            this.cbFilterUser.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(351, 175);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(228, 27);
            this.tbFilter.TabIndex = 7;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // lbFilterby
            // 
            this.lbFilterby.AutoSize = true;
            this.lbFilterby.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterby.Location = new System.Drawing.Point(87, 176);
            this.lbFilterby.Name = "lbFilterby";
            this.lbFilterby.Size = new System.Drawing.Size(78, 22);
            this.lbFilterby.TabIndex = 8;
            this.lbFilterby.Text = "FilterBy";
            // 
            // PBImageADD
            // 
            this.PBImageADD.Image = global::DVLD.Properties.Resources.user_add;
            this.PBImageADD.Location = new System.Drawing.Point(875, 128);
            this.PBImageADD.Name = "PBImageADD";
            this.PBImageADD.Size = new System.Drawing.Size(87, 73);
            this.PBImageADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImageADD.TabIndex = 5;
            this.PBImageADD.TabStop = false;
            this.PBImageADD.Click += new System.EventHandler(this.PBImageADD_Click);
            // 
            // PBMangeImage
            // 
            this.PBMangeImage.Image = global::DVLD.Properties.Resources.user_config;
            this.PBMangeImage.Location = new System.Drawing.Point(440, 7);
            this.PBMangeImage.Name = "PBMangeImage";
            this.PBMangeImage.Size = new System.Drawing.Size(164, 118);
            this.PBMangeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBMangeImage.TabIndex = 5;
            this.PBMangeImage.TabStop = false;
            // 
            // cbISactive
            // 
            this.cbISactive.FormattingEnabled = true;
            this.cbISactive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbISactive.Location = new System.Drawing.Point(386, 171);
            this.cbISactive.Name = "cbISactive";
            this.cbISactive.Size = new System.Drawing.Size(228, 27);
            this.cbISactive.TabIndex = 10;
            this.cbISactive.SelectedIndexChanged += new System.EventHandler(this.cbISactive_SelectedIndexChanged);
            // 
            // ShowUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 693);
            this.Controls.Add(this.cbISactive);
            this.Controls.Add(this.lbFilterby);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterUser);
            this.Controls.Add(this.PBImageADD);
            this.Controls.Add(this.PBMangeImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbCountRecords);
            this.Controls.Add(this.DGVUser);
            this.Controls.Add(this.lbRcords);
            this.Controls.Add(this.label1);
            this.Name = "ShowUser";
            this.Text = "ShowUser";
            this.Load += new System.EventHandler(this.ShowUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBImageADD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMangeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRcords;
        private System.Windows.Forms.DataGridView DGVUser;
        private System.Windows.Forms.Label lbCountRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox PBMangeImage;
        private System.Windows.Forms.PictureBox PBImageADD;
        private System.Windows.Forms.ComboBox cbFilterUser;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lbFilterby;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbISactive;
    }
}
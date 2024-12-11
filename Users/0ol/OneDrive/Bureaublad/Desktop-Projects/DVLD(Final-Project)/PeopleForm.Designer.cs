namespace DVLD
{
    partial class PeopleForm
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
            this.DGVPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.lbCountrecord = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.BTAddNewPerson = new System.Windows.Forms.Button();
            this.BTClose = new System.Windows.Forms.Button();
            this.PBPeople = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPeople
            // 
            this.DGVPeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVPeople.Location = new System.Drawing.Point(179, 187);
            this.DGVPeople.Name = "DGVPeople";
            this.DGVPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVPeople.RowTemplate.Height = 29;
            this.DGVPeople.Size = new System.Drawing.Size(1449, 304);
            this.DGVPeople.TabIndex = 0;
            this.DGVPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAddNewPerson,
            this.TSMEdit,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem,
            this.showDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 196);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // TSMAddNewPerson
            // 
            this.TSMAddNewPerson.Image = global::DVLD.Properties.Resources.administrator;
            this.TSMAddNewPerson.Name = "TSMAddNewPerson";
            this.TSMAddNewPerson.Size = new System.Drawing.Size(224, 32);
            this.TSMAddNewPerson.Text = "Add New Person";
            this.TSMAddNewPerson.Click += new System.EventHandler(this.TSMAddNewPerson_Click);
            // 
            // TSMEdit
            // 
            this.TSMEdit.Image = global::DVLD.Properties.Resources.edit;
            this.TSMEdit.Name = "TSMEdit";
            this.TSMEdit.Size = new System.Drawing.Size(224, 32);
            this.TSMEdit.Text = "Edit";
            this.TSMEdit.Click += new System.EventHandler(this.TSMEdit_Click_1);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.person_boy__2_;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.email_next;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.call;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.info_file;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(712, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mangament People";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Location = new System.Drawing.Point(12, 605);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(88, 19);
            this.lbRecords.TabIndex = 5;
            this.lbRecords.Text = "#Records :";
            this.lbRecords.Click += new System.EventHandler(this.lbRecords_Click);
            // 
            // lbCountrecord
            // 
            this.lbCountrecord.AutoSize = true;
            this.lbCountrecord.Location = new System.Drawing.Point(115, 605);
            this.lbCountrecord.Name = "lbCountrecord";
            this.lbCountrecord.Size = new System.Drawing.Size(14, 19);
            this.lbCountrecord.TabIndex = 6;
            this.lbCountrecord.Text = " ";
            this.lbCountrecord.Click += new System.EventHandler(this.lbCountrecord_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(377, 144);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(284, 27);
            this.tbFilter.TabIndex = 7;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // CBFilter
            // 
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Items.AddRange(new object[] {
            "None",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "PersonID",
            "NationalNo",
            "Email",
            "Phone "});
            this.CBFilter.Location = new System.Drawing.Point(120, 145);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(196, 27);
            this.CBFilter.TabIndex = 8;
            this.CBFilter.SelectedIndexChanged += new System.EventHandler(this.CBFilter_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(-2, 145);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(114, 24);
            this.lbFilter.TabIndex = 9;
            this.lbFilter.Text = "Filter By : ";
            // 
            // BTAddNewPerson
            // 
            this.BTAddNewPerson.BackgroundImage = global::DVLD.Properties.Resources.administrator;
            this.BTAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTAddNewPerson.Location = new System.Drawing.Point(1505, 72);
            this.BTAddNewPerson.Name = "BTAddNewPerson";
            this.BTAddNewPerson.Size = new System.Drawing.Size(132, 109);
            this.BTAddNewPerson.TabIndex = 4;
            this.BTAddNewPerson.Text = " ";
            this.BTAddNewPerson.UseVisualStyleBackColor = true;
            this.BTAddNewPerson.Click += new System.EventHandler(this.BTAddNewPerson_Click);
            // 
            // BTClose
            // 
            this.BTClose.AutoSize = true;
            this.BTClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTClose.ForeColor = System.Drawing.Color.Red;
            this.BTClose.Image = global::DVLD.Properties.Resources.close__1_;
            this.BTClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTClose.Location = new System.Drawing.Point(1361, 533);
            this.BTClose.Name = "BTClose";
            this.BTClose.Size = new System.Drawing.Size(206, 78);
            this.BTClose.TabIndex = 3;
            this.BTClose.Text = "           Close";
            this.BTClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTClose.UseVisualStyleBackColor = false;
            this.BTClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // PBPeople
            // 
            this.PBPeople.Image = global::DVLD.Properties.Resources.focus_group;
            this.PBPeople.Location = new System.Drawing.Point(732, 12);
            this.PBPeople.Name = "PBPeople";
            this.PBPeople.Size = new System.Drawing.Size(222, 128);
            this.PBPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPeople.TabIndex = 1;
            this.PBPeople.TabStop = false;
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 680);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.CBFilter);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lbCountrecord);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.BTAddNewPerson);
            this.Controls.Add(this.BTClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBPeople);
            this.Controls.Add(this.DGVPeople);
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleForm";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPeople;
        private System.Windows.Forms.PictureBox PBPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTClose;
        private System.Windows.Forms.Button BTAddNewPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem TSMEdit;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label lbCountrecord;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.Label lbFilter;
    }
}
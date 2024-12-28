namespace DVLD
{
    partial class Schedule_Vision_Test
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
            this.lbScheduleVisonTest = new System.Windows.Forms.Label();
            this.DGVVISONTEST = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lbCountRecords = new System.Windows.Forms.Label();
            this.lbRcords = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.editTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTAKETest = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlApplicationInfo1 = new DVLD.ctrlApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVISONTEST)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScheduleVisonTest
            // 
            this.lbScheduleVisonTest.AutoSize = true;
            this.lbScheduleVisonTest.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScheduleVisonTest.ForeColor = System.Drawing.Color.Red;
            this.lbScheduleVisonTest.Location = new System.Drawing.Point(401, 116);
            this.lbScheduleVisonTest.Name = "lbScheduleVisonTest";
            this.lbScheduleVisonTest.Size = new System.Drawing.Size(258, 29);
            this.lbScheduleVisonTest.TabIndex = 0;
            this.lbScheduleVisonTest.Text = "Schedule Vision Test";
            this.lbScheduleVisonTest.Click += new System.EventHandler(this.lbScheduleVisonTest_Click);
            // 
            // DGVVISONTEST
            // 
            this.DGVVISONTEST.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVVISONTEST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVISONTEST.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVVISONTEST.Location = new System.Drawing.Point(155, 519);
            this.DGVVISONTEST.Name = "DGVVISONTEST";
            this.DGVVISONTEST.RowHeadersWidth = 62;
            this.DGVVISONTEST.RowTemplate.Height = 29;
            this.DGVVISONTEST.Size = new System.Drawing.Size(686, 171);
            this.DGVVISONTEST.TabIndex = 3;
            this.DGVVISONTEST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVISONTEST_CellContentClick);
            this.DGVVISONTEST.VisibleChanged += new System.EventHandler(this.DGVVISONTEST_VisibleChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestToolStripMenuItem,
            this.TTAKETest});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 101);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.VisibleChanged += new System.EventHandler(this.contextMenuStrip1_VisibleChanged);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(763, 696);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 43);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbCountRecords
            // 
            this.lbCountRecords.AutoSize = true;
            this.lbCountRecords.Location = new System.Drawing.Point(123, 708);
            this.lbCountRecords.Name = "lbCountRecords";
            this.lbCountRecords.Size = new System.Drawing.Size(14, 19);
            this.lbCountRecords.TabIndex = 19;
            this.lbCountRecords.Text = " ";
            // 
            // lbRcords
            // 
            this.lbRcords.AutoSize = true;
            this.lbRcords.Location = new System.Drawing.Point(35, 708);
            this.lbRcords.Name = "lbRcords";
            this.lbRcords.Size = new System.Drawing.Size(82, 19);
            this.lbRcords.TabIndex = 18;
            this.lbRcords.Text = "# Records";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.local_network;
            this.pictureBox2.Location = new System.Drawing.Point(867, 525);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // editTestToolStripMenuItem
            // 
            this.editTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.text_message;
            this.editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            this.editTestToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.editTestToolStripMenuItem.Text = "Edit ";
            this.editTestToolStripMenuItem.Click += new System.EventHandler(this.editTestToolStripMenuItem_Click);
            // 
            // TTAKETest
            // 
            this.TTAKETest.Image = global::DVLD.Properties.Resources.edit__3_;
            this.TTAKETest.Name = "TTAKETest";
            this.TTAKETest.Size = new System.Drawing.Size(248, 32);
            this.TTAKETest.Text = "Take Test ";
            this.TTAKETest.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.eye;
            this.pictureBox1.Location = new System.Drawing.Point(454, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.ApplicationID = 0;
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(126, 148);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(796, 374);
            this.ctrlApplicationInfo1.TabIndex = 2;
            this.ctrlApplicationInfo1.Load += new System.EventHandler(this.ctrlApplicationInfo1_Load);
            // 
            // Schedule_Vision_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 737);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbCountRecords);
            this.Controls.Add(this.lbRcords);
            this.Controls.Add(this.DGVVISONTEST);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbScheduleVisonTest);
            this.Name = "Schedule_Vision_Test";
            this.Text = "Schedule_Vision_Test";
            this.Load += new System.EventHandler(this.Schedule_Vision_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVISONTEST)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScheduleVisonTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlApplicationInfo ctrlApplicationInfo1;
        private System.Windows.Forms.DataGridView DGVVISONTEST;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbCountRecords;
        private System.Windows.Forms.Label lbRcords;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTAKETest;
    }
}
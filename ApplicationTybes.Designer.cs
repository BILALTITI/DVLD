namespace DVLD
{
    partial class ApplicationTybes
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
            this.DGVApplicationtyebes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTyebsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbManageAplicationTybes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbrecord = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVApplicationtyebes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVApplicationtyebes
            // 
            this.DGVApplicationtyebes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVApplicationtyebes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVApplicationtyebes.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVApplicationtyebes.Location = new System.Drawing.Point(250, 151);
            this.DGVApplicationtyebes.Name = "DGVApplicationtyebes";
            this.DGVApplicationtyebes.RowHeadersWidth = 62;
            this.DGVApplicationtyebes.RowTemplate.Height = 29;
            this.DGVApplicationtyebes.Size = new System.Drawing.Size(569, 354);
            this.DGVApplicationtyebes.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTyebsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(268, 36);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editApplicationTyebsToolStripMenuItem
            // 
            this.editApplicationTyebsToolStripMenuItem.Image = global::DVLD.Properties.Resources.document__1_;
            this.editApplicationTyebsToolStripMenuItem.Name = "editApplicationTyebsToolStripMenuItem";
            this.editApplicationTyebsToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.editApplicationTyebsToolStripMenuItem.Text = "Edit Application Tyebs";
            this.editApplicationTyebsToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTyebsToolStripMenuItem_Click);
            // 
            // lbManageAplicationTybes
            // 
            this.lbManageAplicationTybes.AutoSize = true;
            this.lbManageAplicationTybes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageAplicationTybes.ForeColor = System.Drawing.Color.Red;
            this.lbManageAplicationTybes.Location = new System.Drawing.Point(410, 117);
            this.lbManageAplicationTybes.Name = "lbManageAplicationTybes";
            this.lbManageAplicationTybes.Size = new System.Drawing.Size(310, 29);
            this.lbManageAplicationTybes.TabIndex = 1;
            this.lbManageAplicationTybes.Text = "Mange Application Tybes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.papers;
            this.pictureBox1.Location = new System.Drawing.Point(503, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbrecord
            // 
            this.lbrecord.AutoSize = true;
            this.lbrecord.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecord.Location = new System.Drawing.Point(25, 531);
            this.lbrecord.Name = "lbrecord";
            this.lbrecord.Size = new System.Drawing.Size(111, 24);
            this.lbrecord.TabIndex = 3;
            this.lbrecord.Text = "#Record :";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(152, 531);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 19);
            this.lbCount.TabIndex = 3;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::DVLD.Properties.Resources.close__4_;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(876, 505);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(158, 42);
            this.btnclose.TabIndex = 13;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ApplicationTybes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 559);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbrecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbManageAplicationTybes);
            this.Controls.Add(this.DGVApplicationtyebes);
            this.Name = "ApplicationTybes";
            this.Text = "ApplicationTybes";
            this.Load += new System.EventHandler(this.ApplicationTybes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVApplicationtyebes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVApplicationtyebes;
        private System.Windows.Forms.Label lbManageAplicationTybes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbrecord;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTyebsToolStripMenuItem;
    }
}
namespace DVLD
{
    partial class ctrlDriverLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TCDriverLicence = new System.Windows.Forms.TabControl();
            this.tclocal = new System.Windows.Forms.TabPage();
            this.tcInternational = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVLocal = new System.Windows.Forms.DataGridView();
            this.DGVInternational = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCount2 = new System.Windows.Forms.Label();
            this.CMSLocal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSInternatinal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TCDriverLicence.SuspendLayout();
            this.tclocal.SuspendLayout();
            this.tcInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInternational)).BeginInit();
            this.CMSLocal.SuspendLayout();
            this.CMSInternatinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCDriverLicence
            // 
            this.TCDriverLicence.ContextMenuStrip = this.CMSInternatinal;
            this.TCDriverLicence.Controls.Add(this.tclocal);
            this.TCDriverLicence.Controls.Add(this.tcInternational);
            this.TCDriverLicence.Location = new System.Drawing.Point(10, 31);
            this.TCDriverLicence.Name = "TCDriverLicence";
            this.TCDriverLicence.SelectedIndex = 0;
            this.TCDriverLicence.Size = new System.Drawing.Size(1249, 236);
            this.TCDriverLicence.TabIndex = 0;
            // 
            // tclocal
            // 
            this.tclocal.Controls.Add(this.lbCount2);
            this.tclocal.Controls.Add(this.label3);
            this.tclocal.Controls.Add(this.DGVLocal);
            this.tclocal.Location = new System.Drawing.Point(4, 28);
            this.tclocal.Name = "tclocal";
            this.tclocal.Padding = new System.Windows.Forms.Padding(3);
            this.tclocal.Size = new System.Drawing.Size(1241, 204);
            this.tclocal.TabIndex = 0;
            this.tclocal.Text = "Local";
            this.tclocal.UseVisualStyleBackColor = true;
            // 
            // tcInternational
            // 
            this.tcInternational.Controls.Add(this.DGVInternational);
            this.tcInternational.Controls.Add(this.lbCount);
            this.tcInternational.Controls.Add(this.label1);
            this.tcInternational.Location = new System.Drawing.Point(4, 28);
            this.tcInternational.Name = "tcInternational";
            this.tcInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tcInternational.Size = new System.Drawing.Size(1241, 204);
            this.tcInternational.TabIndex = 1;
            this.tcInternational.Text = "International";
            this.tcInternational.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(144, 185);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(33, 19);
            this.lbCount.TabIndex = 2;
            this.lbCount.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Driver License";
            // 
            // DGVLocal
            // 
            this.DGVLocal.AllowUserToAddRows = false;
            this.DGVLocal.AllowUserToDeleteRows = false;
            this.DGVLocal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLocal.ContextMenuStrip = this.CMSLocal;
            this.DGVLocal.Location = new System.Drawing.Point(8, 7);
            this.DGVLocal.Name = "DGVLocal";
            this.DGVLocal.ReadOnly = true;
            this.DGVLocal.RowHeadersWidth = 62;
            this.DGVLocal.RowTemplate.Height = 29;
            this.DGVLocal.Size = new System.Drawing.Size(1228, 173);
            this.DGVLocal.TabIndex = 0;
            // 
            // DGVInternational
            // 
            this.DGVInternational.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInternational.Location = new System.Drawing.Point(-19, 13);
            this.DGVInternational.Name = "DGVInternational";
            this.DGVInternational.RowHeadersWidth = 62;
            this.DGVInternational.RowTemplate.Height = 29;
            this.DGVInternational.Size = new System.Drawing.Size(1287, 174);
            this.DGVInternational.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Record";
            // 
            // lbCount2
            // 
            this.lbCount2.AutoSize = true;
            this.lbCount2.Location = new System.Drawing.Point(127, 183);
            this.lbCount2.Name = "lbCount2";
            this.lbCount2.Size = new System.Drawing.Size(33, 19);
            this.lbCount2.TabIndex = 1;
            this.lbCount2.Text = "???";
            // 
            // CMSLocal
            // 
            this.CMSLocal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMSLocal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.CMSLocal.Name = "CMSLocal";
            this.CMSLocal.Size = new System.Drawing.Size(235, 36);
            this.CMSLocal.Opening += new System.ComponentModel.CancelEventHandler(this.CMSLocal_Opening);
            // 
            // CMSInternatinal
            // 
            this.CMSInternatinal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMSInternatinal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem});
            this.CMSInternatinal.Name = "CMSInternatinal";
            this.CMSInternatinal.Size = new System.Drawing.Size(278, 69);
            this.CMSInternatinal.Opening += new System.ComponentModel.CancelEventHandler(this.CMSInternatinal_Opening);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Image = global::DVLD.Properties.Resources.Driver_License_32;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.cToolStripMenuItem.Text = "Show International Info";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.Driver_License_32;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // ctrlDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TCDriverLicence);
            this.Name = "ctrlDriverLicense";
            this.Size = new System.Drawing.Size(1255, 267);
            this.Load += new System.EventHandler(this.ctrlDriverLicense_Load);
            this.TCDriverLicence.ResumeLayout(false);
            this.tclocal.ResumeLayout(false);
            this.tclocal.PerformLayout();
            this.tcInternational.ResumeLayout(false);
            this.tcInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInternational)).EndInit();
            this.CMSLocal.ResumeLayout(false);
            this.CMSInternatinal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TCDriverLicence;
        private System.Windows.Forms.TabPage tclocal;
        private System.Windows.Forms.TabPage tcInternational;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVLocal;
        private System.Windows.Forms.Label lbCount2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVInternational;
        private System.Windows.Forms.ContextMenuStrip CMSLocal;
        private System.Windows.Forms.ContextMenuStrip CMSInternatinal;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}

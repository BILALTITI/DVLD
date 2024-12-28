namespace DVLD
{
    partial class LicenceInfoWithFilter
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
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.PBSeaech = new System.Windows.Forms.PictureBox();
            this.TbLicenceID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.licenceInfo1 = new DVLD.LicenceInfo();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSeaech)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.PBSeaech);
            this.FilterGroupBox.Controls.Add(this.TbLicenceID);
            this.FilterGroupBox.Controls.Add(this.label3);
            this.FilterGroupBox.Location = new System.Drawing.Point(28, 22);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(664, 84);
            this.FilterGroupBox.TabIndex = 49;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            this.FilterGroupBox.Enter += new System.EventHandler(this.FilterGroupBox_Enter);
            // 
            // PBSeaech
            // 
            this.PBSeaech.Image = global::DVLD.Properties.Resources.file_add;
            this.PBSeaech.Location = new System.Drawing.Point(400, 23);
            this.PBSeaech.Name = "PBSeaech";
            this.PBSeaech.Size = new System.Drawing.Size(61, 55);
            this.PBSeaech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSeaech.TabIndex = 51;
            this.PBSeaech.TabStop = false;
            // 
            // TbLicenceID
            // 
            this.TbLicenceID.Location = new System.Drawing.Point(131, 35);
            this.TbLicenceID.Name = "TbLicenceID";
            this.TbLicenceID.Size = new System.Drawing.Size(252, 27);
            this.TbLicenceID.TabIndex = 50;
            this.TbLicenceID.TextChanged += new System.EventHandler(this.TbLicenceID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Licence ID :";
            // 
            // licenceInfo1
            // 
            this.licenceInfo1.Location = new System.Drawing.Point(20, 106);
            this.licenceInfo1.Name = "licenceInfo1";
            this.licenceInfo1.Size = new System.Drawing.Size(672, 357);
            this.licenceInfo1.TabIndex = 0;
            this.licenceInfo1.Load += new System.EventHandler(this.licenceInfo1_Load);
            // 
            // LicenceInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.licenceInfo1);
            this.Name = "LicenceInfoWithFilter";
            this.Size = new System.Drawing.Size(712, 483);
            this.Load += new System.EventHandler(this.LicenceInfoWithFilter_Load);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSeaech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LicenceInfo licenceInfo1;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.PictureBox PBSeaech;
        private System.Windows.Forms.TextBox TbLicenceID;
        private System.Windows.Forms.Label label3;
    }
}

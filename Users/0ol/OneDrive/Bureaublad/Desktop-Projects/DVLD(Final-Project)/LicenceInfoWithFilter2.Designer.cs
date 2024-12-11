namespace DVLD
{
    partial class LicenceInfoWithFilter2
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
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.PBSeaech = new System.Windows.Forms.PictureBox();
            this.TbLicenceID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.image7 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.licenceInfo1 = new DVLD.LicenceInfo();
            this.btnfind = new System.Windows.Forms.Button();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSeaech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.PBSeaech);
            this.FilterGroupBox.Controls.Add(this.TbLicenceID);
            this.FilterGroupBox.Controls.Add(this.label3);
            this.FilterGroupBox.Controls.Add(this.btnfind);
            this.FilterGroupBox.Location = new System.Drawing.Point(14, 3);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(664, 84);
            this.FilterGroupBox.TabIndex = 51;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            this.FilterGroupBox.Enter += new System.EventHandler(this.FilterGroupBox_Enter);
            // 
            // PBSeaech
            // 
            this.PBSeaech.Image = global::DVLD.Properties.Resources.file_add;
            this.PBSeaech.Location = new System.Drawing.Point(398, 22);
            this.PBSeaech.Name = "PBSeaech";
            this.PBSeaech.Size = new System.Drawing.Size(61, 55);
            this.PBSeaech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSeaech.TabIndex = 51;
            this.PBSeaech.TabStop = false;
            this.PBSeaech.Click += new System.EventHandler(this.PBSeaech_Click);
            // 
            // TbLicenceID
            // 
            this.TbLicenceID.Location = new System.Drawing.Point(131, 35);
            this.TbLicenceID.Name = "TbLicenceID";
            this.TbLicenceID.Size = new System.Drawing.Size(252, 27);
            this.TbLicenceID.TabIndex = 50;
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
            // image7
            // 
            this.image7.Image = global::DVLD.Properties.Resources.person_boy;
            this.image7.Location = new System.Drawing.Point(592, 103);
            this.image7.Name = "image7";
            this.image7.Size = new System.Drawing.Size(149, 110);
            this.image7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image7.TabIndex = 52;
            this.image7.TabStop = false;
            this.image7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // licenceInfo1
            // 
            this.licenceInfo1.Location = new System.Drawing.Point(6, 87);
            this.licenceInfo1.Name = "licenceInfo1";
            this.licenceInfo1.Size = new System.Drawing.Size(672, 357);
            this.licenceInfo1.TabIndex = 50;
            this.licenceInfo1.Load += new System.EventHandler(this.licenceInfo1_Load);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(398, 22);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(61, 58);
            this.btnfind.TabIndex = 52;
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // LicenceInfoWithFilter2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.image7);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.licenceInfo1);
            this.Name = "LicenceInfoWithFilter2";
            this.Size = new System.Drawing.Size(759, 453);
            this.Load += new System.EventHandler(this.LicenceInfoWithFilter2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenceInfoWithFilter2_KeyPress);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.LicenceInfoWithFilter2_Validating);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSeaech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.PictureBox PBSeaech;
        private System.Windows.Forms.TextBox TbLicenceID;
        private System.Windows.Forms.Label label3;
        private LicenceInfo licenceInfo1;
        private System.Windows.Forms.PictureBox image7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnfind;
    }
}

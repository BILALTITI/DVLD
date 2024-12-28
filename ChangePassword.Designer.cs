namespace DVLD
{
    partial class ChangePassword
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
            this.LoginInfo = new System.Windows.Forms.GroupBox();
            this.lbIsActive2 = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbUserName2 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserID2 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbCurrentPassword = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlShowCard1 = new DVLD.ctrlShowCard();
            this.LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginInfo
            // 
            this.LoginInfo.Controls.Add(this.lbIsActive2);
            this.LoginInfo.Controls.Add(this.lbIsActive);
            this.LoginInfo.Controls.Add(this.lbUserName2);
            this.LoginInfo.Controls.Add(this.lbUserName);
            this.LoginInfo.Controls.Add(this.lbUserID2);
            this.LoginInfo.Controls.Add(this.lbUserID);
            this.LoginInfo.Location = new System.Drawing.Point(288, 467);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Size = new System.Drawing.Size(814, 66);
            this.LoginInfo.TabIndex = 2;
            this.LoginInfo.TabStop = false;
            this.LoginInfo.Text = "Login Information";
            // 
            // lbIsActive2
            // 
            this.lbIsActive2.AutoSize = true;
            this.lbIsActive2.Location = new System.Drawing.Point(732, 23);
            this.lbIsActive2.Name = "lbIsActive2";
            this.lbIsActive2.Size = new System.Drawing.Size(49, 19);
            this.lbIsActive2.TabIndex = 0;
            this.lbIsActive2.Text = "?????";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Location = new System.Drawing.Point(609, 24);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(81, 19);
            this.lbIsActive.TabIndex = 0;
            this.lbIsActive.Text = "Is Active :";
            // 
            // lbUserName2
            // 
            this.lbUserName2.AutoSize = true;
            this.lbUserName2.Location = new System.Drawing.Point(384, 23);
            this.lbUserName2.Name = "lbUserName2";
            this.lbUserName2.Size = new System.Drawing.Size(49, 19);
            this.lbUserName2.TabIndex = 0;
            this.lbUserName2.Text = "?????";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(280, 24);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(98, 19);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name :";
            // 
            // lbUserID2
            // 
            this.lbUserID2.AutoSize = true;
            this.lbUserID2.Location = new System.Drawing.Point(106, 24);
            this.lbUserID2.Name = "lbUserID2";
            this.lbUserID2.Size = new System.Drawing.Size(49, 19);
            this.lbUserID2.TabIndex = 0;
            this.lbUserID2.Text = "?????";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(6, 24);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(74, 19);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "User ID :";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(440, 684);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(240, 27);
            this.tbConfirmPassword.TabIndex = 9;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(439, 606);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(240, 27);
            this.tbNewPassword.TabIndex = 10;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.TextChanged += new System.EventHandler(this.tbNewPassword_TextChanged);
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(440, 543);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(240, 27);
            this.tbCurrentPassword.TabIndex = 11;
            this.tbCurrentPassword.UseSystemPasswordChar = true;
            this.tbCurrentPassword.TextChanged += new System.EventHandler(this.tbCurrentPassword_TextChanged);
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Location = new System.Drawing.Point(243, 675);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(144, 19);
            this.lbConfirmPassword.TabIndex = 3;
            this.lbConfirmPassword.Text = "Confirm Password:";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(271, 611);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(118, 19);
            this.lbNewPassword.TabIndex = 4;
            this.lbNewPassword.Text = "New Password:";
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.AutoSize = true;
            this.lbCurrentPassword.Location = new System.Drawing.Point(252, 545);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(140, 19);
            this.lbCurrentPassword.TabIndex = 5;
            this.lbCurrentPassword.Text = "Current Password:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.border_none;
            this.pictureBox4.Location = new System.Drawing.Point(399, 675);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.border_none;
            this.pictureBox3.Location = new System.Drawing.Point(399, 606);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(399, 541);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::DVLD.Properties.Resources.close__4_;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(969, 675);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(158, 42);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DVLD.Properties.Resources.close__4_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1151, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 42);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlShowCard1
            // 
            this.ctrlShowCard1.Location = new System.Drawing.Point(240, -1);
            this.ctrlShowCard1.Name = "ctrlShowCard1";
            this.ctrlShowCard1.PersonID = 0;
            this.ctrlShowCard1.Size = new System.Drawing.Size(901, 462);
            this.ctrlShowCard1.TabIndex = 0;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 728);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.lbCurrentPassword);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginInfo);
            this.Controls.Add(this.ctrlShowCard1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.LoginInfo.ResumeLayout(false);
            this.LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlShowCard ctrlShowCard1;
        private System.Windows.Forms.GroupBox LoginInfo;
        private System.Windows.Forms.Label lbIsActive2;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbUserName2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserID2;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbCurrentPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
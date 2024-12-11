namespace DVLD
{
    partial class AddnewUser
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
            this.lbAddnewUser = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPersonalInfo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlShowCard1 = new DVLD.ctrlShowCard();
            this.TLoginInfo = new System.Windows.Forms.TabPage();
            this.CHKIsActive = new System.Windows.Forms.CheckBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.LbUserID2 = new System.Windows.Forms.Label();
            this.LBUserID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TPersonalInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.TLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddnewUser
            // 
            this.lbAddnewUser.AutoSize = true;
            this.lbAddnewUser.BackColor = System.Drawing.Color.White;
            this.lbAddnewUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddnewUser.ForeColor = System.Drawing.Color.Red;
            this.lbAddnewUser.Location = new System.Drawing.Point(307, 9);
            this.lbAddnewUser.Name = "lbAddnewUser";
            this.lbAddnewUser.Size = new System.Drawing.Size(181, 29);
            this.lbAddnewUser.TabIndex = 0;
            this.lbAddnewUser.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPersonalInfo);
            this.tabControl1.Controls.Add(this.TLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(-4, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 487);
            this.tabControl1.TabIndex = 1;
            // 
            // TPersonalInfo
            // 
            this.TPersonalInfo.Controls.Add(this.groupBox1);
            this.TPersonalInfo.Controls.Add(this.btnNext);
            this.TPersonalInfo.Controls.Add(this.ctrlShowCard1);
            this.TPersonalInfo.Location = new System.Drawing.Point(4, 28);
            this.TPersonalInfo.Name = "TPersonalInfo";
            this.TPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPersonalInfo.Size = new System.Drawing.Size(823, 455);
            this.TPersonalInfo.TabIndex = 0;
            this.TPersonalInfo.Text = "Personal Info";
            this.TPersonalInfo.UseVisualStyleBackColor = true;
            this.TPersonalInfo.Click += new System.EventHandler(this.TPersonalInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.lbFilter);
            this.groupBox1.Controls.Add(this.CBFilter);
            this.groupBox1.Controls.Add(this.tbFilter);
            this.groupBox1.Location = new System.Drawing.Point(38, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 66);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.person_boy__5_;
            this.pictureBox5.Location = new System.Drawing.Point(666, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.person_boy__4_;
            this.pictureBox6.Location = new System.Drawing.Point(625, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(2, 16);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(114, 24);
            this.lbFilter.TabIndex = 12;
            this.lbFilter.Text = "Filter By : ";
            // 
            // CBFilter
            // 
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Items.AddRange(new object[] {
            "PersonID",
            "National No"});
            this.CBFilter.Location = new System.Drawing.Point(124, 16);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(196, 27);
            this.CBFilter.TabIndex = 11;
            this.CBFilter.SelectedIndexChanged += new System.EventHandler(this.CBFilter_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(335, 17);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(284, 27);
            this.tbFilter.TabIndex = 10;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::DVLD.Properties.Resources.next__1_;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(663, 407);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(141, 31);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "      Next                   ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlShowCard1
            // 
            this.ctrlShowCard1.Location = new System.Drawing.Point(-1, 56);
            this.ctrlShowCard1.Name = "ctrlShowCard1";
            this.ctrlShowCard1.PersonID = 0;
            this.ctrlShowCard1.Size = new System.Drawing.Size(829, 345);
            this.ctrlShowCard1.TabIndex = 0;
            this.ctrlShowCard1.userID = 0;
            this.ctrlShowCard1.Load += new System.EventHandler(this.ctrlShowCard1_Load);
            // 
            // TLoginInfo
            // 
            this.TLoginInfo.Controls.Add(this.CHKIsActive);
            this.TLoginInfo.Controls.Add(this.tbConfirmPassword);
            this.TLoginInfo.Controls.Add(this.tbPassword);
            this.TLoginInfo.Controls.Add(this.tbUserName);
            this.TLoginInfo.Controls.Add(this.lbConfirmPassword);
            this.TLoginInfo.Controls.Add(this.lbPassword);
            this.TLoginInfo.Controls.Add(this.lbUserName);
            this.TLoginInfo.Controls.Add(this.LbUserID2);
            this.TLoginInfo.Controls.Add(this.LBUserID);
            this.TLoginInfo.Controls.Add(this.pictureBox4);
            this.TLoginInfo.Controls.Add(this.pictureBox3);
            this.TLoginInfo.Controls.Add(this.pictureBox2);
            this.TLoginInfo.Controls.Add(this.pictureBox1);
            this.TLoginInfo.Location = new System.Drawing.Point(4, 28);
            this.TLoginInfo.Name = "TLoginInfo";
            this.TLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TLoginInfo.Size = new System.Drawing.Size(823, 455);
            this.TLoginInfo.TabIndex = 1;
            this.TLoginInfo.Text = "Login Info";
            this.TLoginInfo.UseVisualStyleBackColor = true;
            this.TLoginInfo.Click += new System.EventHandler(this.TLoginInfo_Click);
            // 
            // CHKIsActive
            // 
            this.CHKIsActive.AutoSize = true;
            this.CHKIsActive.Location = new System.Drawing.Point(239, 341);
            this.CHKIsActive.Name = "CHKIsActive";
            this.CHKIsActive.Size = new System.Drawing.Size(96, 23);
            this.CHKIsActive.TabIndex = 3;
            this.CHKIsActive.Text = "Is Active";
            this.CHKIsActive.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(222, 279);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(240, 27);
            this.tbConfirmPassword.TabIndex = 2;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(222, 210);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(240, 27);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(222, 143);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(240, 27);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Location = new System.Drawing.Point(26, 279);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(138, 19);
            this.lbConfirmPassword.TabIndex = 0;
            this.lbConfirmPassword.Text = "Confirm Password";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(82, 210);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(76, 19);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(77, 145);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(82, 19);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "UserName";
            // 
            // LbUserID2
            // 
            this.LbUserID2.AutoSize = true;
            this.LbUserID2.Location = new System.Drawing.Point(235, 89);
            this.LbUserID2.Name = "LbUserID2";
            this.LbUserID2.Size = new System.Drawing.Size(33, 19);
            this.LbUserID2.TabIndex = 0;
            this.LbUserID2.Text = "???";
            this.LbUserID2.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBUserID
            // 
            this.LBUserID.AutoSize = true;
            this.LBUserID.Location = new System.Drawing.Point(101, 92);
            this.LBUserID.Name = "LBUserID";
            this.LBUserID.Size = new System.Drawing.Size(58, 19);
            this.LBUserID.TabIndex = 0;
            this.LBUserID.Text = "UserID";
            this.LBUserID.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.border_none;
            this.pictureBox4.Location = new System.Drawing.Point(182, 279);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.border_none;
            this.pictureBox3.Location = new System.Drawing.Point(182, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(182, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.border_none;
            this.pictureBox1.Location = new System.Drawing.Point(182, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DVLD.Properties.Resources.diskette__7_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(664, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "       Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(515, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddnewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 585);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbAddnewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddnewUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.AddnewUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.TPersonalInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.TLoginInfo.ResumeLayout(false);
            this.TLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddnewUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPersonalInfo;
        private System.Windows.Forms.TabPage TLoginInfo;
        private ctrlShowCard ctrlShowCard1;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label LBUserID;
        private System.Windows.Forms.Label LbUserID2;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CHKIsActive;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
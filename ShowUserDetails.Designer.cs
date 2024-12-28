namespace DVLD
{
    partial class ShowUserDetails
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
            this.ctrlShowCard1 = new DVLD.ctrlShowCard();
            this.LoginInfo = new System.Windows.Forms.GroupBox();
            this.lbIsActive2 = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbUserName2 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserID2 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.ctrlShowCard2 = new DVLD.ctrlShowCard();
            this.LoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlShowCard1
            // 
            this.ctrlShowCard1.Location = new System.Drawing.Point(265, 12);
            this.ctrlShowCard1.Name = "ctrlShowCard1";
            this.ctrlShowCard1.PersonID = 0;
            this.ctrlShowCard1.Size = new System.Drawing.Size(857, 406);
            this.ctrlShowCard1.TabIndex = 0;
            this.ctrlShowCard1.Load += new System.EventHandler(this.ctrlShowCard1_Load);
            // 
            // LoginInfo
            // 
            this.LoginInfo.Controls.Add(this.lbIsActive2);
            this.LoginInfo.Controls.Add(this.lbIsActive);
            this.LoginInfo.Controls.Add(this.lbUserName2);
            this.LoginInfo.Controls.Add(this.lbUserName);
            this.LoginInfo.Controls.Add(this.lbUserID2);
            this.LoginInfo.Controls.Add(this.lbUserID);
            this.LoginInfo.Location = new System.Drawing.Point(308, 457);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Size = new System.Drawing.Size(814, 66);
            this.LoginInfo.TabIndex = 1;
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
            this.lbIsActive2.Click += new System.EventHandler(this.lbIsActive_Click);
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Location = new System.Drawing.Point(609, 24);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(81, 19);
            this.lbIsActive.TabIndex = 0;
            this.lbIsActive.Text = "Is Active :";
            this.lbIsActive.Click += new System.EventHandler(this.lbIsActive_Click);
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
            // btnclose
            // 
            this.btnclose.Image = global::DVLD.Properties.Resources.close__4_;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(1010, 595);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(120, 42);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ctrlShowCard2
            // 
            this.ctrlShowCard2.Location = new System.Drawing.Point(273, 20);
            this.ctrlShowCard2.Name = "ctrlShowCard2";
            this.ctrlShowCard2.PersonID = 0;
            this.ctrlShowCard2.Size = new System.Drawing.Size(881, 542);
            this.ctrlShowCard2.TabIndex = 3;
            this.ctrlShowCard2.Load += new System.EventHandler(this.ctrlShowCard2_Load);
            // 
            // ShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 693);
            this.Controls.Add(this.ctrlShowCard2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.LoginInfo);
            this.Controls.Add(this.ctrlShowCard1);
            this.Name = "ShowUserDetails";
            this.Text = "ShowUserDetails";
            this.Load += new System.EventHandler(this.ShowUserDetails_Load);
            this.LoginInfo.ResumeLayout(false);
            this.LoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowCard ctrlShowCard1;
        private System.Windows.Forms.GroupBox LoginInfo;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbUserName2;
        private System.Windows.Forms.Label lbUserID2;
        private System.Windows.Forms.Label lbIsActive2;
        private System.Windows.Forms.Button btnclose;
        private ctrlShowCard ctrlShowCard2;
    }
}
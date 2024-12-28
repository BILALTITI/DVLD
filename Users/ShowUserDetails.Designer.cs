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
            this.btnclose = new System.Windows.Forms.Button();
            this.userInfo1 = new DVLD.Controls.UserInfo1();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(603, 412);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(147, 46);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // userInfo1
            // 
            this.userInfo1.Location = new System.Drawing.Point(0, -1);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(823, 392);
            this.userInfo1.TabIndex = 3;
            this.userInfo1.Load += new System.EventHandler(this.userInfo1_Load);
            // 
            // ShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 459);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowUserDetails";
            this.Text = "ShowUserDetails";
            this.Load += new System.EventHandler(this.ShowUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnclose;
        private Controls.UserInfo1 userInfo1;
    }
}
namespace DVLD
{
    partial class Show_Application_Info
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlApplicationInfo1 = new DVLD.ctrlApplicationInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(565, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 48);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.ApplicationID = 0;
            this.ctrlApplicationInfo1.LicenceID = 0;
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(5, 1);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(722, 377);
            this.ctrlApplicationInfo1.TabIndex = 0;
            this.ctrlApplicationInfo1.Load += new System.EventHandler(this.ctrlApplicationInfo1_Load);
            // 
            // Show_Application_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 419);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Name = "Show_Application_Info";
            this.Text = "Show_Application_Info";
            this.Load += new System.EventHandler(this.Show_Application_Info_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlApplicationInfo ctrlApplicationInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}
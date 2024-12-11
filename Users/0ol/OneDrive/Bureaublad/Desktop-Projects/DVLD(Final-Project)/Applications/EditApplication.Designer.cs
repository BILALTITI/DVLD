namespace DVLD
{
    partial class EditApplication
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
            this.lbEditApp = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbID2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbFees = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEditApp
            // 
            this.lbEditApp.AutoSize = true;
            this.lbEditApp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditApp.ForeColor = System.Drawing.Color.Red;
            this.lbEditApp.Location = new System.Drawing.Point(92, 19);
            this.lbEditApp.Name = "lbEditApp";
            this.lbEditApp.Size = new System.Drawing.Size(278, 29);
            this.lbEditApp.TabIndex = 0;
            this.lbEditApp.Text = "Edit Application Types";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(15, 105);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(32, 19);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(15, 172);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(46, 19);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title:";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Location = new System.Drawing.Point(15, 247);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(46, 19);
            this.lbFees.TabIndex = 1;
            this.lbFees.Text = "Fees:";
            // 
            // lbID2
            // 
            this.lbID2.AutoSize = true;
            this.lbID2.Location = new System.Drawing.Point(102, 105);
            this.lbID2.Name = "lbID2";
            this.lbID2.Size = new System.Drawing.Size(30, 19);
            this.lbID2.TabIndex = 1;
            this.lbID2.Text = " ??";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(86, 172);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(296, 27);
            this.tbTitle.TabIndex = 2;
            // 
            // tbFees
            // 
            this.tbFees.Location = new System.Drawing.Point(86, 239);
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(296, 27);
            this.tbFees.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.edit__1_;
            this.pictureBox2.Location = new System.Drawing.Point(61, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.money_bag_dollar;
            this.pictureBox1.Location = new System.Drawing.Point(61, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DVLD.Properties.Resources.diskette__7_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(235, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(53, 301);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(158, 42);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // EditApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 368);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.tbFees);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbFees);
            this.Controls.Add(this.lbID2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbEditApp);
            this.Name = "EditApplication";
            this.Text = "Edit Application Types";
            this.Activated += new System.EventHandler(this.EditApplication_Activated);
            this.Load += new System.EventHandler(this.EditApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEditApp;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbID2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbFees;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
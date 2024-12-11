namespace DVLD
{
    partial class frmTests
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlSchduleTest1 = new DVLD.ctrlSchduleTest();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::DVLD.Properties.Resources.close__4_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(138, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlSchduleTest1
            // 
            this.ctrlSchduleTest1.Location = new System.Drawing.Point(0, 2);
            this.ctrlSchduleTest1.Name = "ctrlSchduleTest1";
            this.ctrlSchduleTest1.Size = new System.Drawing.Size(421, 662);
            this.ctrlSchduleTest1.TabIndex = 0;
            this.ctrlSchduleTest1.TestTypeID = DVLD__Business_Layer.TestTypess.TestTypes.enTestType.VisionTest;
            this.ctrlSchduleTest1.Load += new System.EventHandler(this.ctrlSchduleTest1_Load_1);
            // 
            // frmTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlSchduleTest1);
            this.Name = "frmTests";
            this.Text = "frmTests";
            this.Load += new System.EventHandler(this.frmTests_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSchduleTest ctrlSchduleTest1;
        private System.Windows.Forms.Button button1;
    }
}
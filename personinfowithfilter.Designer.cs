namespace DVLD
{
    partial class personinfowithfilter
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
            this.ctrlShowCard1 = new DVLD.ctrlShowCard();
            this.filter1 = new DVLD.Filter();
            this.SuspendLayout();
            // 
            // ctrlShowCard1
            // 
            this.ctrlShowCard1.Location = new System.Drawing.Point(0, 76);
            this.ctrlShowCard1.Name = "ctrlShowCard1";
            this.ctrlShowCard1.PersonID = 0;
            this.ctrlShowCard1.Size = new System.Drawing.Size(873, 352);
            this.ctrlShowCard1.TabIndex = 1;
            this.ctrlShowCard1.userID = 0;
            // 
            // filter1
            // 
            this.filter1.FilterEnabled = false;
            this.filter1.Location = new System.Drawing.Point(82, 3);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(733, 90);
            this.filter1.TabIndex = 2;
            // 
            // personinfowithfilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filter1);
            this.Controls.Add(this.ctrlShowCard1);
            this.Name = "personinfowithfilter";
            this.Size = new System.Drawing.Size(879, 483);
            this.Load += new System.EventHandler(this.personinfowithfilter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowCard ctrlShowCard1;
        private Filter filter1;
    }
}

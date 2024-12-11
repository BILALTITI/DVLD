namespace DVLD
{
    partial class cardDetails
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
            this.SuspendLayout();
            // 
            // ctrlShowCard1
            // 
            this.ctrlShowCard1.Location = new System.Drawing.Point(0, 2);
            this.ctrlShowCard1.Name = "ctrlShowCard1";
            this.ctrlShowCard1.PersonID = 0;
            this.ctrlShowCard1.Size = new System.Drawing.Size(839, 337);
            this.ctrlShowCard1.TabIndex = 0;
            this.ctrlShowCard1.userID = 0;
            this.ctrlShowCard1.Load += new System.EventHandler(this.ctrlShowCard1_Load);
            // 
            // cardDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 344);
            this.Controls.Add(this.ctrlShowCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "cardDetails";
            this.Text = "Card Details";
            this.Load += new System.EventHandler(this.cardDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowCard ctrlShowCard1;
    }
}
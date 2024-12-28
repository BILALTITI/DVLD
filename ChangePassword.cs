using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ChangePassword : Form
    {

        int PersonID;

        clsPerson _PersonID;
        int _UserID;
        User _User;
        public ChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _User = User.Find(UserID);
        }
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {

            ctrlShowCard1.ShowCard(_User.PersonID);
            lbUserName2.Text = _User.UserName;
            lbUserID2.Text = _UserID.ToString();
            lbIsActive2.Text = _User.IsActive.ToString();

        }

        private void tbCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbCurrentPassword.Text != _User.Password)
            {
                errorProvider1.SetError(tbCurrentPassword, "The Password is Incorrext");

            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, null);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            _User.Password = tbNewPassword.Text;
            if (_User.Save())

            {     

                MessageBox.Show("Data Saved Successfully.");
                 
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");
             
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbConfirmPassword==tbNewPassword)
            {

                errorProvider1.SetError(tbConfirmPassword, null);
 
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "The Confirm Passeord dose Not Match New Password");
            }
        }

        private void tbNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

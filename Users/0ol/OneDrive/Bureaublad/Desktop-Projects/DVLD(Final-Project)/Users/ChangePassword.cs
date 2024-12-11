using DVLD.Controls;
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
        public void _RestDefaaultValues()
        {
            tbNewPassword.Text = "";
            tbCurrentPassword.Text = "";
            tbConfirmPassword.Text = "";
            tbCurrentPassword.Focus();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
 
            _RestDefaaultValues();
            //Here we dont continue becuase the form is not valid
            if (_User == null)
            {
                MessageBox.Show("Could not Find User with id = " + _UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }
            userInfo11.LoadUserInfo(_UserID);
 
        }

        private void tbCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbCurrentPassword.Text != clsGloabalcs.CurrentUser.Password)
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


            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password =clsGloabalcs.ComputeHash(tbNewPassword.Text.Trim());

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RestDefaaultValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ChangePassword_Activated(object sender, EventArgs e)
        {
            tbCurrentPassword.Focus();
        }
    }
}

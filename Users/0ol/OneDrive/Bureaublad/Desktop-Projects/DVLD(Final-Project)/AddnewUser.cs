using ContactsBusinessLayer;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class AddnewUser : Form
    {


        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        

        public static DataTable dt = User.GetAllUser();
        int _UserID;
        User _User;
        public AddnewUser(int UserID)
        {

            InitializeComponent();
            _UserID = UserID;
            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

        }
        public AddnewUser()
        {

            InitializeComponent();

        }

        private void AddnewUser_Load(object sender, EventArgs e)
        {
            CBFilter.SelectedIndex = 0; 
            if (_Mode == enMode.AddNew)
            {


                TLoginInfo.Enabled = false;
                CHKIsActive.Checked = true;
                lbAddnewUser.Text = "Add New User";
                _User = new User();
                return;
            }
            _User = User.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("This Form Will be Close Becouse no User Found ");
                this.Close();
                return;

            }
            else
            {
                lbAddnewUser.Text = "Edit User ID =" + _UserID;
                ctrlShowCard1.ShowCard(_User.PersonID);
                CBFilter.SelectedIndex = 0;
                TLoginInfo.Enabled = true;
                tbFilter.Text = _User.PersonID.ToString();
                groupBox1.Enabled = false;
                LbUserID2.Text= _UserID.ToString();
                tbUserName.Text = _User.UserName;   
                tbPassword.Text = _User.Password;
                tbConfirmPassword.Text = _User.Password;
                CHKIsActive.Checked=true;
            }
        }

        private bool ChecUserValidate()
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
            { 
                errorProvider1.SetError(tbConfirmPassword, "The Password Is incorrect");
                return false;
                
            }
            if (tbUserName.Text == "" && tbPassword.Text == "" && tbConfirmPassword.Text == "")
            {
                MessageBox.Show("The Text Boxes Must have a Value");
                return false;
            }

            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (tbFilter.Text == "")
            {



                MessageBox.Show("Message box Must contain A value");

                return;
            }
            if (CBFilter.Text == "PersonID")
            {
                int PersonID = int.Parse(tbFilter.Text);

                ctrlShowCard1.ShowCard(PersonID);

            }
            else
            {
                string NationalNo = tbFilter.Text;

                ctrlShowCard1.ShowCard(NationalNo);


            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBFilter.Text == "PersonID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                {

                    e.Handled = true;

                    MessageBox.Show("Error, A Person ID  number can't contain a Letter ");


                }

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(tbFilter.Text);
           string NationalNo = tbFilter.Text;
            if (!User.isUserExsistbyPersonID(PersonID))
            {

                tabControl1.SelectedIndex = 1;
                TLoginInfo.Enabled = true;
            }

            else

            {

                tabControl1.SelectedIndex = 0;

                MessageBox.Show("The PersonID Is Already User ");
            }
        }

        private void TLoginInfo_Click(object sender, EventArgs e)
        {

        }

        private void TPersonalInfo_Click(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User _User = new User ();


             if (ChecUserValidate()==true)
            {

                _User.UserName = tbUserName.Text;
                _User.Password = tbPassword.Text;

                _User.IsActive = CHKIsActive.Checked;
                _User.PersonID = ctrlShowCard1.PersonID;
                if (tbConfirmPassword.Text != tbPassword.Text)
                {

                    errorProvider1.SetError(tbConfirmPassword, "The Password Is incorrect");
                    return;
                }
                if (_User.Save())
                {
                    MessageBox.Show("Data Saved Successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.");

                    LbUserID2.Text = _User.UserID.ToString();
                }
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            }
        }

        private void ctrlShowCard1_Load(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if ( tbConfirmPassword.Text != tbPassword.Text)
                {

                errorProvider1.SetError(tbConfirmPassword,"The Password Dose Not Match Password");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, null);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbUserName.Text =="")
            {
                errorProvider1.SetError(tbUserName,"Must have a  value");

            }
            else
            {
                errorProvider1.SetError(tbUserName, null);
            }
             }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(-1);
      
            form2.DataBack += Form2_databack;
            form2.ShowDialog();
        }
        private void Form2_databack(object sender,int PersonID)
        {
            tbFilter.Text = PersonID.ToString();
            CBFilter.SelectedIndex = 0;
            ctrlShowCard1.ShowCard(PersonID);
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

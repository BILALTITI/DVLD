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

namespace DVLD.Controls
{
    public partial class UserInfo1 : UserControl
    {
        int _UserID = -1;
        User _User;

        public UserInfo1()
        {
            InitializeComponent();
        }
        public void LoadUserInfo(int UserID)
        {
            _User = User.Find(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }
        private void _FillUserInfo()
        {

            ctrlShowCard1.ShowCard(_User.PersonID);
            lbUserID2.Text = _User.UserID.ToString();
            lbUserName2.Text = _User.UserName.ToString();

            if (_User.IsActive)
                lbIsActive2.Text = "Yes";
            else
                lbIsActive2.Text = "No";

        }


        private void _ResetPersonInfo()
        {

            ctrlShowCard1._RestValue();
            lbUserID2.Text = "[???]";
            lbUserName2.Text = "[???]";
            lbIsActive2.Text = "[???]";
        }

        private void ctrlShowCard1_Load(object sender, EventArgs e)
        {

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
 
        }
    }
  


}


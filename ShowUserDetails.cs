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
    public partial class ShowUserDetails : Form
    {
        int PersonID;

        clsPerson _PersonID;
        int _UserID;
       User _User;
        public ShowUserDetails(int UserID)
        {
            InitializeComponent();
        
        _UserID = UserID;
            _User = User.Find(UserID);
        }
        public ShowUserDetails(   )
        {
            InitializeComponent();
        }

        private void lbIsActive_Click(object sender, EventArgs e)
        {

        }

        private void ShowUserDetails_Load(object sender, EventArgs e)
        {

            ctrlShowCard1.ShowCard(_User.PersonID);
            lbUserName2.Text= _User.UserName;
            lbUserID2.Text= _UserID.ToString();
            lbIsActive2.Text=_User.IsActive.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlShowCard1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlShowCard2_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ShowUserDetails : Form
    {
        private int _UserID;

        public int UserID
        {
            get { return _UserID; }
        }
        public ShowUserDetails(int UserID)
        {
            InitializeComponent();
        
        _UserID = UserID;
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

        userInfo1.LoadUserInfo(_UserID);
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

        private void userInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}

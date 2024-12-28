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

namespace DVLD
{
    public partial class CTRLSHOWCARD : UserControl
    {
        int _PersonID;
        clsPerson _Person;
        public CTRLSHOWCARD()
        {
            InitializeComponent();
        }

        public void ShowCard2(int PersonID)
        {
            lbpersonid2.Text = PersonID.ToString();
            lbName2.Text = _Person.FullName();
            lbEmail2.Text = _Person.Email;
            lbPhone2.Text = _Person.Phone;
            LBAddress.Text = _Person.Address;
            lbDateofBirth2.Text = _Person.DateOfBirth.ToString();

            if (_Person.ImagePath != "")
            {
                PBIMage2.Load(_Person.ImagePath);
            }

            if (_Person.Gender == 0)
            {
                lbgendor2.Text = "Male";
            }
            else
            {
                lbgendor2.Text = "Female";
            }
        }

        private void CTRLSHOWCARD_Load(object sender, EventArgs e)
        {

        }

    }
}


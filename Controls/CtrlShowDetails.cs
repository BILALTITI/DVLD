using ContactsBusinessLayer;
using DVLD.Classes;
using DVLD.Properties;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ctrlShowCard : UserControl
    {
        public event EventHandler<int> OnLicenceSelected;
        public delegate void OnepersonSelect(object sender, int LicenseID);
        public event OnepersonSelect DataSend;
        int _PersonID;
        clsPerson _Person;
        User _User;
        public ctrlShowCard(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
         
        }
        public ctrlShowCard()
        {
            InitializeComponent();
        }
        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                PBIMage2.Image = Resources.person_girl;
            else
                PBIMage2.Image = Resources.person_boy;
            string ImagePath = _Person.ImagePath;
            if (File.Exists(ImagePath))
                PBIMage2.ImageLocation = ImagePath;
            else
                MessageBox.Show("Error Cant Load Photo");
     
        }
        public void _RestValue()
        { 
            this.PersonID = -1;
            lbName2.Text = "???"; 
            lbNAtionlno2.Text = "???";
            lbEmail2.Text = "???";
            lbPhone2.Text = "???";
            lbAddress2.Text = "???";
            lbDateofBirth2.Text = "???";
            lbgendor2.Text= "???";
            lbCountry2.Text = "???"; 
        }
        public int userID { get; set; }
        public int PersonID { get; set; }
        public void ShowCard(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
               PersonID =-1;
                _RestValue();
                return;

            }

            lbpersonid2.Text = NationalNo.ToString();
            this.PersonID = _Person.PersonID;
            lbName2.Text = _Person.FullName();
            lbNAtionlno2.Text = _Person.NationalNo;
            lbEmail2.Text = _Person.Email;
            lbPhone2.Text = _Person.Phone;
            lbAddress2.Text = _Person.Address;
            lbDateofBirth2.Text = _Person.DateOfBirth.ToString();
            lbgendor2.Text = _Person.GetGendor();
            lbCountry2.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;

            _LoadPersonImage();

        }
        public void ShowCard(int PersonID)
        { 
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                _RestValue();
                PersonID = -1;
                return;

            }
            else
            {



                lbpersonid2.Text = PersonID.ToString();
                this.PersonID = _Person.PersonID;

                lbName2.Text = _Person.FullName();
                lbNAtionlno2.Text = _Person.NationalNo;
                lbEmail2.Text = _Person.Email;
                lbPhone2.Text = _Person.Phone;
                lbAddress2.Text = _Person.Address;
                lbDateofBirth2.Text = _Person.DateOfBirth.ToString();
                lbgendor2.Text = _Person.GetGendor();
                lbCountry2.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
                _LoadPersonImage() ;
            }
        }
        public void ShowCardUser(int UserID)
        {
            _User = User.Find(userID);
            if (_User == null)
            {

                return;

            }
            else
            {



                lbpersonid2.Text = userID.ToString();
                this.userID =_User.UserID;

                lbName2.Text = _User.Personinfo.FullName();
                lbNAtionlno2.Text = _User.Personinfo.NationalNo;
                lbEmail2.Text = _User.Personinfo.Email;
                lbPhone2.Text = _User.Personinfo.Phone;
                lbAddress2.Text = _User.Personinfo.Address;
                lbDateofBirth2.Text = clsFormat.DateToShort(_User.Personinfo.DateOfBirth);

                lbCountry2.Text = clsCountry.Find(_User.Personinfo.NationalityCountryID).CountryName;

                if (_User.Personinfo.ImagePath != "")
                {
                    PBIMage2.Load(_User.Personinfo.ImagePath);
                }
                if (_User.Personinfo.Gender == 0)
                {
                    lbgendor2.Text = "Male";
                }
                else
                {
                    lbgendor2.Text = "Female";
                }
            }
        }
        private void ShowDetails_Load(object sender, EventArgs e)
        {
             //lbCountry2.Text = lbCountry2.FindString(clsCountry.Find(_Person.NationalityCountryID).CountryName);
        }

        private void lbPersonDetails_Click(object sender, EventArgs e)
        {

        }

        private void PBGendor_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LLEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddorEditPerson frmEditORADD = new frmAddorEditPerson(PersonID);
            frmEditORADD.ShowDialog();
            ShowCard(PersonID);
        }
    }
    }


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
    public partial class ctrlShowCard : UserControl
    {
        int _PersonID;
        clsPerson _Person;
      
        public ctrlShowCard(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
         
        }

        public int PersonID { get; set; }
        public void ShowCard(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {

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

            lbCountry2.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;

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
        public void ShowCard(int PersonID)
        { 
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {

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

                lbCountry2.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;

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
        }
        public ctrlShowCard()
        {
            InitializeComponent();
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
            Form2 frmEditORADD = new Form2(PersonID);
            frmEditORADD.ShowDialog();

        }
    }
    }


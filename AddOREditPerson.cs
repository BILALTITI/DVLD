using ContactsBusinessLayer;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DVLD
{
    public partial class AddOREditPerson : UserControl
    {

        public enum enMode { AddNew = 0, Update = 1 };
      private enMode _Mode;
        int _PersonID;
        clsPerson _Person;
        public AddOREditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else 
                _Mode = enMode.Update;
        }

        public AddOREditPerson()
        {
            InitializeComponent();
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNA_Click(object sender, EventArgs e)
        {
          
        }
        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                CBCountry.Items.Add(row.ToString());
            }
        }
            private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void AddOREditPerson_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                // Do stuff...
            }
            _FillCountriesInComoboBox();   
            CBCountry.SelectedIndex = 0;    
            if(_Mode==enMode.AddNew)
            {
                LBMODE.Text = "Add New Contact";
                _Person=new clsPerson();
                return;
            }
            _Person = clsPerson.Find(_PersonID);
            if (_PersonID == null)
            { 
                return;

            }
            LBMODE.Text = "Edit Contact ID =" + _PersonID;
           lbPersonID. Text = _PersonID.ToString();  
          TBFirstName. Text = _Person.FirstName ;
     TBSecondName.Text= _Person.SecondName ;
            TBThirdName.Text = _Person.ThirdName;
            TBLastName.Text = _Person.LastName;
          TBEmail. Text = _Person.Email ;
          TBphone. Text = _Person.Phone ;    
            TBAddress.Text = _Person. Address ;
           DTM.Value = _Person.DateOfBirth ;
            if (_Person.ImagePath!="")
            {
                pictureBox1.Load(_Person.ImagePath);
            }
            linkLabel1.Visible = (_Person.ImagePath != "");
            CBCountry.SelectedIndex = CBCountry.FindString(clsPerson.Find(_Person.NationalityCountryID).ToString());
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCountry.GetAllCountries();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                CBCountry.Items.Add(row.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

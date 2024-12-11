using ContactsBusinessLayer;
using DVLD.Properties;
using Presntation_Layet;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;



namespace DVLD
{
    public partial class Form2 : Form
    {
        public delegate void DataBackEventHandler(object seder, int PersonID);
        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPerson _Person;
        public Form2 _Sender;
        public Form2(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

        }
        public Form2( )
        {
            InitializeComponent();
        

        }


        private void _LoadData()
        {
            _FillCountriesInComoboBox();
            if (_Mode == enMode.AddNew)
            {
                RBmale.Checked = true;
                lbPersonMode.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("This Form Will be Close Becouse no Person Found ");
                this.Close();
                return;

            }
            lbPersonMode.Text = "Edit Person ID =" + _PersonID;
            LBPersonID.Text = _PersonID.ToString();
            tbFirst.Text = _Person.FirstName;
            tbNationalNO.Text = _Person.NationalNo;
            tbSecond.Text = _Person.SecondName;
            tbThird.Text = _Person.ThirdName;
            tbLast.Text = _Person.LastName;
            tbEmail.Text = _Person.Email;
            tbphone.Text = _Person.Phone;
            tbAddress.Text = _Person.Address;
            DTM.Value = _Person.DateOfBirth;

            if (_Person.ImagePath != "")
            {
                PBIMage.Load(_Person.ImagePath);
            }
            if (_Person.Gender == 0)
            {
                RBFemale.Checked = false;
                RBmale.Checked = true;
            }
            else
            {
                RBFemale.Checked = true;
                RBmale.Checked = false;
            }

 
            LLRemove.Visible = (_Person.ImagePath != "");


            if (_Person.Gender == 99)
            {
                RBFemale.Checked = false;
                RBmale.Checked = false;
            }

            CBCountry.SelectedIndex = CBCountry.FindString(clsCountry.Find(_Person.NationalityCountryID).CountryName);

        }

        public static void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                /////////////////////////////////////////////////////
                CBCountry.Items.Add(row["CountryName"].ToString());
                ////////////////////////////////////////////////////////
            }
            CBCountry.SelectedIndex = 89;
        }

        private ComboBox GetCBCountry()
        {
            return CBCountry;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != PBIMage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (PBIMage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = PBIMage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        PBIMage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (tbFirst.Text == "" || tbSecond.Text == "" || tbLast.Text == "" || tbNationalNO.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("The Text Boxes Must have a Value ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             

            }
            else
            {
                int CountryID = clsCountry.Find(CBCountry.Text).CountryID;

                _Person.FirstName = tbFirst.Text;
                _Person.SecondName = tbSecond.Text;
                _Person.ThirdName = tbThird.Text;
                _Person.LastName = tbLast.Text;
                _Person.NationalNo = tbNationalNO.Text;
                _Person.Email = tbEmail.Text;
                _Person.Phone = tbphone.Text;
                _Person.Address = tbAddress.Text;
                _Person.DateOfBirth = DTM.Value;
                _Person.NationalityCountryID = CountryID;

                if (PBIMage.ImageLocation != null)
                    _Person.ImagePath = PBIMage.ImageLocation;
                else
                    _Person.ImagePath = "";

                if (RBmale.Checked)
                {
                    _Person.Gender = 0;
                }
                else
                {
                    _Person.Gender = 1;
                }
                if (_Person.Save())

                {
                    MessageBox.Show("Data Saved Successfully.");

                 //int    PersonID = int.Parse(LBPersonID.Text);
                 DataBack?.Invoke(this, _Person.PersonID);
                    this.Close();
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");

                _Mode = enMode.Update;
                lbPersonMode.Text = "Edit Person ID = " + _Person.PersonID;
                LBPersonID.Text = _Person.PersonID.ToString();
            }
        }

        private void CBCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   _FillCountriesInComoboBox();
        }

        private void LLSETImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                PBIMage.ImageLocation=(selectedFilePath);
            }
            LLRemove.Visible = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            tbFirst.Focus();

            DTM.MaxDate = DateTime.Now.AddYears(-18);
            DTM.Value = DTM.MaxDate;

            _LoadData();
        }

        private void tbNationalNO_TextChanged(object sender, EventArgs e)
        {
            if (clsPerson.IsPersonExsist(tbNationalNO.Text))
            {
                errorProvider1.SetError(tbNationalNO, "The NationalNo IS Exsist");

            }
            else
            {
                errorProvider1.SetError(tbNationalNO, null);
            }

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                return;
            }

            if (tbEmail.Text.Contains("@.com")|| tbEmail.Text.Contains("@yahoo.com")|| tbEmail.Text.Contains("@hotmail.com")|| tbEmail.Text.Contains("@gmail.com")|| tbEmail.Text.Contains("@outlook.com"))
            {
                errorProvider1.SetError(tbEmail, null);
            }
            else
            {
                errorProvider1.SetError(tbEmail, " Email is not correct ");
            }

        }

        private void tbphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;

                MessageBox.Show("Error, A phone number can't contain a Letter ");


            }
        }

        private void tbphone_TextChanged(object sender, EventArgs e)
        {
            if (tbphone.Text.Length == 10)
            {
                tbphone.ForeColor = Color.Red;
            }
            else
            {
                tbphone.ForeColor = Color.Green;
            }

        }

        private void RBmale_CheckedChanged(object sender, EventArgs e)
        {

            if (RBmale.Checked && PBIMage.ImageLocation == null)
            {
                PBIMage.Image = Resources.person_boy;

            }
        }

        private void tbNationalNO_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.IsPersonExsist(tbNationalNO.Text))
            {
                errorProvider1.SetError(tbNationalNO,"The NationalNo IS Exsist");
               
            }
            else
            {
                errorProvider1.SetError(tbNationalNO,null);
            }
         
        }

        private void DTM_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PBIMage_Click(object sender, EventArgs e)
        {

          


        }

        private void RBFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (RBFemale.Checked&&PBIMage.ImageLocation==null)
            {
                PBIMage.Image = Resources.person_girl;
            }
            }

        private void LLRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PBIMage.ImageLocation = null;



            if (RBmale.Checked)
                PBIMage.Image = Resources.person_boy;
            else
                PBIMage.Image = Resources.person_girl;

            LLRemove.Visible = false;

        }

        private void DTM_ValueChanged_1(object sender, EventArgs e)
        {
            DTM.MaxDate = DateTime.Now.AddYears(-18);
            DTM.Value = DTM.MaxDate;
        }

        private void tbSecond_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirst_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirst.Text))
            {
                tbFirst.Focus();
                errorProvider1.SetError(tbFirst, "Must Contain a Value");
            }
            else
            {
                errorProvider1.SetError(tbFirst, "");
            }

        }

        private void tbLast_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbThird.Text))
            {
                tbThird.Focus();
                errorProvider1.SetError(tbThird, "Must Contain a Value");
            }
            else
            {
                errorProvider1.SetError(tbThird, "");
            }

        }

        private void DTM_Validating(object sender, CancelEventArgs e)
        {
        }

        private void DTM_Validated(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBAddress_Click(object sender, EventArgs e)
        {

        }
    }
}

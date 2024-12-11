using DVLD__Business_Layer;
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
    public partial class Daitain : Form
    {
        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;


        public Daitain()
        {
            InitializeComponent();
        }

        private void Daitain_Load(object sender, EventArgs e)
        {
              btnIssue.Enabled = false;
            LLShowHistory.Enabled = false;
            LLShowInfo.Enabled = false; 
            lbApplicationDate2.Text = DateTime.Now.ToString()  ;

            lbCreatedBy2.Text = 1 .ToString();
            
             
        
        
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            DetainedLicenses detained = new DetainedLicenses();
            detained.LicenseID = _SelectedLicenseID;

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFineFees.Focus();
                return;

            }

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }



            //Applications applications = new Applications();

            //applications.ApplicantPersonID = licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID;
            //applications.ApplicationsTypesID = Presntation_Layet.Applicationstype.Find(5).ApplicationTypeID;
            //applications.CreatedByUserID = 1;
            //applications.ApplicationDate = DateTime.Now;
            //applications.ApplicationStatus = 3;
            //applications.LastStatusDate = DateTime.Now;
            //applications.PaidFees = Presntation_Layet.Applicationstype.Find(5).ApplicationFees;
         
            //if (applications.Save())
            //{
                detained = new DetainedLicenses();

                 //detained.DetainID = licenceInfoWithFilter21.SelectedLiceenceInfo.DetainedInfo.DetainID;
                 detained.DetainDate = DateTime.Now;
                //detained.ReleaseDate = DateTime.Now;
                detained.FineFees = Convert.ToDecimal(tbFineFees.Text);
            //    detained.IsReleased = false;
                detained.LicenseID = licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID;
                detained.CreatedByUserID = 1;
                //detained.ReleaseApplicationID = Presntation_Layet.Applicationstype.Find(5).ApplicationTypeID ;

                if (!detained.Save())
                {
                    MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            if (!licenceInfoWithFilter21.SelectedLiceenceInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            if (!licenceInfoWithFilter21.SelectedLiceenceInfo.IsDetained)
            {
                MessageBox.Show("Selected License is Detained, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            lbIDDetain2.Text = detained.DetainID.ToString();
                MessageBox.Show("License Detained Successfully with ID=" + detained.DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIssue.Enabled = false;
                licenceInfoWithFilter21.FilterEnable = false;

                LLShowInfo.Enabled = true;

          
        }

        private void licenceInfoWithFilter21_OnLicenceSelected(object sender, int e)
        {
            _SelectedLicenseID = e;

           lbLicecnceIIDOld2.Text = _SelectedLicenseID.ToString();

            LLShowHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)

            {
                return;
            }



            //ToDo: make sure the license is not detained already.
            if (licenceInfoWithFilter21.SelectedLiceenceInfo.IsDetained )
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


btnIssue.Enabled = true;
         
        }

        private void licenceInfoWithFilter21_Load(object sender, EventArgs e)
        {

           
        }

        private void LLShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 info = new Form3(_SelectedLicenseID);
            info.Show();
        }

        private void LLShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Licence_History licence_History = new Licence_History(licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID);
            licence_History.Show();
        }
    }
}


using DVLD__Business_Layer;
using License;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class InternationalLicence : Form
    {
        private int _LicenseID;
        private License.License _License;


        private int _InternationalLicenseID = -1;


        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public InternationalLicence(int LicenseID)
        {
            _LicenseID = LicenseID;

            InitializeComponent();
        }
        public InternationalLicence()
        {
             InitializeComponent();
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InternationalLicence_Load(object sender, EventArgs e)
        {
            licenceInfoWithFilter21.txtLicenseIDFocus();

            btnIssue.Enabled = false;
            LLShowHistory.Enabled = false;
            LLShowInfo.Enabled = false; 
            lbApplicationDate2.Text = DateTime.Now.ToString()  ;

            lbCreatedBy2.Text = 1 .ToString();
            lbFees2.Text = Presntation_Layet.Applicationstype.Find(6).ApplicationFees.ToString();

            LbExpieationInterDate2.Text = DateTime.Now.AddYears(1).ToString();
            lbIssueDate22.Text = DateTime.Now.ToString();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void licenceInfoWithFilter21_OnLicenceSelected(object sender, int e)
        {
            int SelectedLicencID = e;
            lbLicecnceIID2.Text =SelectedLicencID.ToString();
            LLShowInfo.Enabled = (SelectedLicencID != -1);
            if (SelectedLicencID == -1)
            {
                return;

                
            }
            if(licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseClass!=3)
            {
                MessageBox.Show("Selected Licence Should be Class 3 , Select Another one .  ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }
            int ActiveInterNationalLicenceID= DVLD__Business_Layer.InternationalLicenses.GetActiveInternationalLicenceByDriverID2(licenceInfoWithFilter21.SelectedLiceenceInfo.DriverID);
            if (ActiveInterNationalLicenceID!=-1)

            {

                MessageBox.Show("Person Has Already an Active InterNational ID With ID =   "  + ActiveInterNationalLicenceID.ToString() , "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                LLShowHistory.Enabled = false;
                LLShowInfo.Enabled = false;

                return;
            }

            btnIssue.Enabled = true;
        
        }

        private void licenceInfoWithFilter21_Load(object sender, EventArgs e)
        {
         }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            DVLD__Business_Layer.InternationalLicenses internationa;

            Applications applications = new Applications();

            applications.ApplicantPersonID = licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID;
            applications.ApplicationsTypesID = Presntation_Layet.Applicationstype.Find(6).ApplicationTypeID;
            applications.CreatedByUserID = 1;
            applications.ApplicationDate = DateTime.Now;
            applications.ApplicationStatus = Applications.enApplicationStatus.Completed;
            applications.LastStatusDate = DateTime.Now;
            applications.PaidFees = Presntation_Layet.Applicationstype.Find(6).ApplicationFees;


            if (applications.Save())

            {
            


                //applications.ApplicationID = licenceInfoWithFilter21._License.ApplicationID;
              


                {
                    internationa = new DVLD__Business_Layer.InternationalLicenses();
                    internationa.ApplicationID = applications.ApplicationID;
                    internationa.CreatedByUserID = 1;
                    internationa.IssuedUsingLocalLicenseID = licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID;
                    internationa.DriverID = licenceInfoWithFilter21.SelectedLiceenceInfo.DriverID;
                    internationa.IssueDate = DateTime.Now;
                    internationa.ExpirationDate = DateTime.Now.AddYears(1);

                    internationa.IsActive = true;

                    if (!internationa.Save())
                    {
                        MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    lbILApplicationID2.Text = internationa.ApplicationID.ToString();
                    _InternationalLicenseID = internationa.InternationalLicenseID;
                    lbILicenceID2.Text = internationa.InternationalLicenseID.ToString();
 
                    MessageBox.Show("International License Issued Successfully with ID=" + internationa.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnIssue.Enabled = false;
                    licenceInfoWithFilter21.FilterEnable  = false;
                    LLShowHistory.Enabled = true;


                }

            }
            else
            {
               MessageBox.Show( " Error");
            } 
                
        }

        private void llShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
     Form3 info = new Form3(licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID);
            info.Show();
        }

        private void LLShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Licence_History licence_History = new Licence_History(licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID);
            licence_History.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InternationalLicence_Activated(object sender, EventArgs e)
        {
            licenceInfoWithFilter21.txtLicenseIDFocus();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class renew : Form
    {
        private int _LicenseID;
        private License.License _License;


        private int _NewLicenseID = -1;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public renew(int LicenceID)
        {
            _LicenseID = LicenceID;
            InitializeComponent();
        }
        public renew()
        {
            InitializeComponent();
        }

        private void renew_Load(object sender, EventArgs e)
        {
 
            btnIssue.Enabled = false;
            LLShowHistory.Enabled = false;
            LLShowInfo.Enabled = false;
            lbApplicationDate2.Text = DateTime.Now.ToString();

            lbCreatedBy2.Text = 1.ToString();
            lbApplicationFees2.Text = Presntation_Layet.Applicationstype.Find(2).ApplicationFees.ToString();

            LbExpieationInterDate2.Text =DateTime.Now.AddYears(1).ToString();
            lbIssueDate22.Text = DateTime.Now.ToString();
            //lboldLicecnceIID2.Text =licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID.ToString();;
            lbLicanceFees2.Text = Presntation_Layet.Applicationstype.Find(1).ApplicationFees.ToString();


            lbTotalFees2.Text = (Convert.ToDecimal(lbApplicationFees2.Text) + Convert.ToDecimal(lbLicanceFees2.Text)).ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void licenceInfoWithFilter21_OnLicenceSelected(object sender, int e)
        {
            int SelectedLicencID = e;
            lboldLicecnceIID2.Text = SelectedLicencID.ToString();
            LLShowHistory.Enabled = (SelectedLicencID != -1);
            if (SelectedLicencID == -1)
            {
                return;


            }
            int DefaultValidityLength = licenceInfoWithFilter21.SelectedLiceenceInfo.Licenseinfo.DefaultValidityLength;
            LbExpieationInterDate2.Text = DateTime.Now.AddYears(DefaultValidityLength).ToString();
            lbLicanceFees2.Text = licenceInfoWithFilter21.SelectedLiceenceInfo.Licenseinfo.ClassFees.ToString();
           lbTotalFees2.Text = (Convert.ToSingle(lbApplicationFees2.Text) + Convert.ToSingle(lbLicanceFees2 .Text)).ToString();
            tbNote.Text = licenceInfoWithFilter21.SelectedLiceenceInfo.Notes;
            int ActiveInterNationalLicenceID = License.License.GetActiveLicenceByDriverID(licenceInfoWithFilter21.SelectedLiceenceInfo.DriverID);
            
            if ( licenceInfoWithFilter21.SelectedLiceenceInfo.ExpirationDate>DateTime.Now)
            {
               MessageBox.Show("Selected License is not yet expiared, it will expire on: " + licenceInfoWithFilter21.SelectedLiceenceInfo.ExpirationDate
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                btnIssue.Enabled = false;


               return;
            }

            if (!licenceInfoWithFilter21.SelectedLiceenceInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }


            if (ActiveInterNationalLicenceID != -1)

            {

                MessageBox.Show("Person Has Already an Active Licence  ID With ID =   " + ActiveInterNationalLicenceID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                LLShowHistory.Enabled = false;
                LLShowInfo.Enabled = false;

                return;
            }

            btnIssue.Enabled = true;

        }

        private void LLShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Licence_History licence_History = new Licence_History(licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID);
            licence_History.Show();
        }

        private void LLShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 info = new Form3(_NewLicenseID);
            info.Show();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Applications applications = new Applications();

            applications.ApplicantPersonID = licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID;
            applications.ApplicationsTypesID = Presntation_Layet.Applicationstype.Find(2).ApplicationTypeID;
            applications.CreatedByUserID = 1;
            applications.ApplicationDate = DateTime.Now;
            applications.ApplicationStatus = 3;
            applications.LastStatusDate = DateTime.Now;
            applications.PaidFees = Presntation_Layet.Applicationstype.Find(2).ApplicationFees;


            if (applications.Save())

            {


                License.License NewLicense = new License.License();
                NewLicense.CreatedByUserID = 1;
                NewLicense.Notes = " ".Trim();
                NewLicense.ApplicationID = applications.ApplicationID;
                NewLicense.LicenseID = licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID;
                NewLicense.DriverID = licenceInfoWithFilter21.SelectedLiceenceInfo.DriverID;
                NewLicense.PaidFees = licenceInfoWithFilter21.SelectedLiceenceInfo.Licenseinfo.ClassFees;
                NewLicense.IsActive = true;
                NewLicense.IssueDate = DateTime.Now;
                NewLicense.ExpirationDate = DateTime.Now.AddYears(LicenseClasses.Find(licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseClass).DefaultValidityLength);
                NewLicense.IssueReason = 2;
                NewLicense.LicenseClass = licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseClass;


                if (!NewLicense.Save())
                {
                    MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                //if (NewLicense == null)
                //{
                //    MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //    return;
                //}

                lbILApplicationID2.Text = NewLicense.ApplicationID.ToString();
                _NewLicenseID = NewLicense.LicenseID;
                lbrenewILicenceID2.Text = _NewLicenseID.ToString();
                MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                licenceInfoWithFilter21.SelectedLiceenceInfo.DeActiveLicencee();
                btnIssue.Enabled = false;
                licenceInfoWithFilter21.FilterEnable = false;
                LLShowInfo.Enabled = true;


            }
        }

        private void licenceInfoWithFilter21_Load(object sender, EventArgs e)
        {

        }
    }
}

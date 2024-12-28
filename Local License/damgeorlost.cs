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
using System.Xml;
using static License.License;

namespace DVLD
{
    public partial class damgeorlost : Form
    {
        private int _NewLicenseID = -1;
        public damgeorlost()
        {
            InitializeComponent();
        }
        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use accirding 
            // to user selection.

            if (rbDamaged.Checked)

                return (int)Applications.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)Applications.enApplicationType.ReplaceLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rbDamaged.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }


        private void damgeorlost_Load(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
            LLShowHistory.Enabled = false;
            LLShowInfo.Enabled = false;
            licenceInfoWithFilter21.FilterEnable = true;

            lbApplicationDate2.Text = DateTime.Now.ToString();

            lbCreatedBy2.Text = clsGloabalcs.CurrentUser.UserName.ToString();
            lbFees2.Text = Presntation_Layet.Applicationstype.Find(3).ApplicationFees.ToString();

            rbDamaged.Checked = true;
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lbDamegeorLost.Text = "Replacement for Damaged License";
            this.Text = lbDamegeorLost.Text;
            lbFees2.Text = Presntation_Layet.Applicationstype.Find(4).ApplicationFees.ToString();


        }
        byte GetTypeRB()
        {
            return rbDamaged.Checked ? (byte)4 : (byte)3;
        }
        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lbDamegeorLost.Text = "Replacement for Lost License";
            this.Text = lbDamegeorLost.Text;
            lbFees2.Text = Presntation_Layet.Applicationstype.Find(3).ApplicationFees.ToString();

        }

        private void licenceInfoWithFilter21_OnLicenceSelected(object sender, int e)
        {
            int SelectedLicenseID = e;
           lbLicecnceIIDOld2.Text = SelectedLicenseID.ToString();
           LLShowHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            {
                return;
            }

            //dont allow a replacement if is not Active .
            if (!licenceInfoWithFilter21.SelectedLiceenceInfo.IsActive )
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            btnIssue.Enabled = true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Applications applications = new Applications();

            applications.ApplicantPersonID = licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID;
            applications.ApplicationsTypesID = Presntation_Layet.Applicationstype.Find(GetTypeRB()).ApplicationTypeID; 
            applications.CreatedByUserID = clsGloabalcs.CurrentUser.UserID;
            applications.ApplicationDate = DateTime.Now;
            applications.ApplicationStatus = Applications.enApplicationStatus.Completed;
            applications.LastStatusDate = DateTime.Now;
            applications.PaidFees = Presntation_Layet.Applicationstype.Find(GetTypeRB()).ApplicationFees;
            if (applications.Save())
            {
                License.License NewLicense = new License.License();
                NewLicense.CreatedByUserID = clsGloabalcs.CurrentUser.UserID;
                NewLicense.Notes = "";
                NewLicense.ApplicationID = applications.ApplicationID;
                NewLicense.LicenseID = licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID;
                NewLicense.DriverID = licenceInfoWithFilter21.SelectedLiceenceInfo.DriverID;
                NewLicense.PaidFees = 0;
                NewLicense.IsActive = true;
                NewLicense.IssueDate = DateTime.Now;
                NewLicense.ExpirationDate = DateTime.Now.AddYears(LicenseClasses.Find(licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseClass).DefaultValidityLength) ;
                NewLicense.IssueReason = GetTypeRB();
 
                
                NewLicense.LicenseClass = licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseClass;
             

                if (!NewLicense.Save())
                {
                    MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (NewLicense == null)
                {
                    MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                licenceInfoWithFilter21.SelectedLiceenceInfo.DeActiveLicencee();
                lbILApplicationID2.Text = NewLicense.ApplicationID.ToString();
                _NewLicenseID = NewLicense.LicenseID;

                lbILApplicationID2.Text = _NewLicenseID.ToString();
                MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIssue.Enabled = false;
                groupBox1.Enabled = false;
                licenceInfoWithFilter21.FilterEnable = false;
                LLShowInfo.Enabled = true;

            }
        }

        private void LLShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 info = new Form3(_NewLicenseID);
            info.Show();
        }

        private void LLShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Licence_History licence_History = new Licence_History(licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID);
            licence_History.Show();
        }

        private void licenceInfoWithFilter21_Load(object sender, EventArgs e)
        { 

        }

        private void damgeorlost_Activated(object sender, EventArgs e)
        {
            licenceInfoWithFilter21.txtLicenseIDFocus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }
    }

}

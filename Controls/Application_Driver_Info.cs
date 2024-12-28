using ContactsBusinessLayer;
using DVLD.Classes;
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
    public partial class ctrlApplicationInfo : UserControl
    {

        int _ApplicationID;
    LocalDrivingLicenseApplications _LocalDrivingApplication;
        public ctrlApplicationInfo(int ApplicationID)
        {
            InitializeComponent();
        
        _ApplicationID= ApplicationID;

        }
        public int ApplicationID { set; get; }
        public int LicenceID { set; get; }
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }
        public void _RestDefaultValue()
        {
            lbAppliedforLicense2.Text = "???"; 
            LbStatus2.Text = "???";
            LBFees2.Text = "???";
            LBTybe2.Text = "???";
            lbApplicant2.Text = "???";
            LbDate2.Text = "???";
            lbStatusDate2.Text = "???";
            lbCreatedBy2.Text = "???";
            LBID2.Text = "???";
            lbDrivingLicenseApplicationID2.Text = "???";
            LBPaidTest2.Text = "???";
            LLShowLicenseOnfo.Enabled = false;
            LLViewPersonInfo.Enabled = false;
        }
       
        public void ShowInfo(int LocalDrivingApplicationID)
        {

            _LocalDrivingApplication = LocalDrivingLicenseApplications.Find(LocalDrivingApplicationID);
            if (_LocalDrivingApplication == null)
            {
                _RestDefaultValue();
                return;

            }
            lbAppliedforLicense2.Text = LicenseClasses.Find(_LocalDrivingApplication.LicenseClassID).ClassName.ToString();
            LbStatus2.Text =_LocalDrivingApplication.Applicationinfo.ApplicationStatus.ToString();
            LBFees2.Text=_LocalDrivingApplication.Applicationinfo.PaidFees.ToString();
            LBTybe2.Text=_LocalDrivingApplication.Applicationinfo.ApplicationsTypesID.ToString();
            lbApplicant2.Text = clsPerson.Find(_LocalDrivingApplication.Applicationinfo.ApplicantPersonID).FullName();
            LbDate2.Text= clsFormat.DateToShort(_LocalDrivingApplication.Applicationinfo.ApplicationDate);
            lbStatusDate2.Text= clsFormat.DateToShort(_LocalDrivingApplication.Applicationinfo.LastStatusDate);
            lbCreatedBy2.Text=_LocalDrivingApplication.Applicationinfo.CreatedByUserID.ToString ();
            LBID2.Text=_LocalDrivingApplication.Applicationinfo.ApplicationID.ToString();
            lbDrivingLicenseApplicationID2.Text = LocalDrivingApplicationID.ToString();
            LBPaidTest2.Text = "N/A";
             if (_LocalDrivingApplication.IslicenseIssued())
                LLShowLicenseOnfo.Enabled=true;
             else
                LLShowLicenseOnfo.Enabled = false;
        }
        private void GBDrivingLicense_Enter(object sender, EventArgs e)
        {

        }

        private void GBApplicationBasicsInfo_Enter(object sender, EventArgs e)
        {

        }

        private void LLViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cardDetails cardDetails = new cardDetails(_LocalDrivingApplication.Applicationinfo.ApplicantPersonID);
            cardDetails.ShowDialog();
        }

        private void ctrlApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void LLShowLicenseOnfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int LicenceID = _LocalDrivingApplication.GetActiveLicence();
            Form3 form3 = new Form3(LicenceID);
            form3.ShowDialog();

        }
    }
}

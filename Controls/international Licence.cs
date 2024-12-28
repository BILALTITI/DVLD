using DVLD__Business_Layer;
using License;
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
    public partial class international_Licence1 : UserControl
    { 

        private int _internationalLicenseApplicationID;


        //public int LicenseID { get { return _LicenseID; } }
        //public License.License _License; 
        //
        License.License _License2;
        public InternationalLicenses _InterNationalLicense;



        public int LicenseID { get { return _internationalLicenseApplicationID; } }
        public international_Licence1()
        {
            InitializeComponent();
        }
        public void _intlicenceInfo(int internationalLicenseApplicationID)
        {
            getintLicenceInfo(internationalLicenseApplicationID);
        }
        public void getintLicenceInfo(int internationalLicenseApplicationID)
        {


            _InterNationalLicense = InternationalLicenses.Find(internationalLicenseApplicationID);
            _internationalLicenseApplicationID = internationalLicenseApplicationID;
            //_License = new License.License();    
            if (_InterNationalLicense == null)
            {
                MessageBox.Show("Could not find License ID = " + _internationalLicenseApplicationID.ToString(),
    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              _internationalLicenseApplicationID = -1;

                return;

            }
            label6.Text = _InterNationalLicense.ApplicationID .ToString();
            lbintLicence2.Text = _InterNationalLicense.InternationalLicenseID.ToString();
            lbName2.Text =_InterNationalLicense.Driversinfo.personinfo.FullName();
    lbLicenceId2.Text =_InterNationalLicense.IssuedUsingLocalLicenseID.ToString();
            lbNational2.Text =_InterNationalLicense.Driversinfo.personinfo.NationalNo.ToString();
            lbGendor2.Text =    _InterNationalLicense   .Driversinfo.personinfo.GetGendor();
            lbISsueDate2.Text = _InterNationalLicense.IssueDate.ToString();
            lbISActive2.Text =_InterNationalLicense.IsActive ? "Yes" : "No";
            lbDateOfBirth2.Text = _InterNationalLicense  .Driversinfo.personinfo.DateOfBirth.ToString();
            lbDriverID2.Text =               _InterNationalLicense.DriverID.ToString();
            lbEpier2.Text =     _InterNationalLicense.ExpirationDate.ToString();
         if (_InterNationalLicense.Driversinfo.personinfo.ImagePath!= "" && _InterNationalLicense.Driversinfo.personinfo.ImagePath!=null )    
            Photo2.Load(_InterNationalLicense.Driversinfo.personinfo.ImagePath);
        }
        private void international_Licence_Load(object sender, EventArgs e)
        {

        }
    }
}

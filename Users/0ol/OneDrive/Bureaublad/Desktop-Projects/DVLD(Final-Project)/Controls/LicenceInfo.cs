using DVLD.Classes;
using DVLD.Properties;
using License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class LicenceInfo : UserControl
    {
        private int _LicenseID;
        

        public int LicenseID { get{ return _LicenseID; } }
        public License.License _License;
        public License.License SelectedLicenseInfo { get { return _License; } }
         public LicenceInfo()
        {
            InitializeComponent();
        }
        public void _licenceInfo(int LicenseID)
        {
            getLicenceInfo(LicenseID);
        }
        private void _LoadPersonImage()
        {
            if (_License.Driversinfo.personinfo.Gender == 0)
                Photo2.Image = Resources.Male_512;
            else
               Photo2.Image = Resources.Female_512;

            string ImagePath = _License.Driversinfo.personinfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    Photo2.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void getLicenceInfo(int LicenseID)
        {


            _LicenseID = LicenseID;
            //_License = new License.License();   

            _License = License.License.Find(_LicenseID);
            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
         
                return;

            }
            //_License = new License.License();   

            LbClass2.Text = _License.Licenseinfo.ClassName;
            lbName2.Text = _License.Driversinfo.personinfo.FullName();
            lbLicenceId2.Text = _License.LicenseID.ToString();
            lbNational2.Text = _License.Driversinfo.personinfo.NationalNo;
            lbGendor2.Text = _License.Driversinfo.personinfo.GetGendor();
            lbISsueDate2.Text = clsFormat.DateToShort(  _License.IssueDate);
            lbNote2.Text = _License.Notes == "" ? "No Notes" : _License.Notes.ToString();
            lbISActive2.Text = _License.IsActive ? "Yes" : "No";
            lbDateOfBirth2.Text = clsFormat.DateToShort(_License.Driversinfo.personinfo.DateOfBirth);
            lbDriverID2.Text = _License.DriverID.ToString();
            lbEpier2.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lbDaitend2.Text = _License.IsDetained ? "Yes":"No" ;
            lbIssueReason2.Text = _License.GetIssueReasonText();
            if (_License.Driversinfo.personinfo.ImagePath != "")
                _LoadPersonImage();
        }
        private void LicenceInfo_Load(object sender, EventArgs e)
        {
            ////getLicenceInfo(_LicenseID);
            //getLicenceInfo(_LicenseID);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Photo2_Click(object sender, EventArgs e)
        {

        }
    }
}

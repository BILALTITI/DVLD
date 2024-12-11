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
    public partial class issueDriving_license_first_tie : Form
    {
        int _localDrivingLicenseApplicationID;
        LocalDrivingLicenseApplications _LocalDrivingLicenseApplications;
        public issueDriving_license_first_tie(int localDrivingLicenseApplicationID)
        {
            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            InitializeComponent();
        }
        public issueDriving_license_first_tie()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ctrlApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void issueDriving_license_first_tie_Load(object sender, EventArgs e)
        {
            tbNote.Focus();
            _LocalDrivingLicenseApplications = LocalDrivingLicenseApplications.Find(_localDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplications == null)
            {

                MessageBox.Show("No Applicaiton with ID=" + _localDrivingLicenseApplicationID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            //if (!LocalDrivingLicenseApplications.IsPassedTest(_localDrivingLicenseApplicationID,))
            //{

            //    MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //    return;
            //}

            //int LicenseID = LocalDrivingLicenseApplications.GetAlLocalDrivingLicenseApplications();
            //if (LicenseID != -1)
            //{

            //    MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //    return;

            //}

            ctrlApplicationInfo1.ShowInfo(_localDrivingLicenseApplicationID);



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Drivers drivers = Drivers.FindbyPersonID(_LocalDrivingLicenseApplications.Applicationinfo.ApplicantPersonID);
             
            if (drivers == null)
            {
                drivers = new Drivers();

                drivers.PersonID = _LocalDrivingLicenseApplications.Applicationinfo.ApplicantPersonID;
                drivers.CreatedDate = DateTime.Now;
                drivers.CreatedByUserID = 1;
                drivers.DriverID = _LocalDrivingLicenseApplications.ApplicationID;
              if (!drivers.Save())
                {
                    return;
                }
            }
            else
            {
                License.License License = new License.License();
                 License.ApplicationID = _LocalDrivingLicenseApplications.ApplicationID;
                License.DriverID = drivers.DriverID;
                License.LicenseClass = _LocalDrivingLicenseApplications.LicenseClassID;
                License.IssueDate = DateTime.Now;
                License.ExpirationDate = DateTime.Now.AddYears(_LocalDrivingLicenseApplications.LicenseClassesinfo.DefaultValidityLength);
                License.Notes = tbNote.Text.ToString();
                License.PaidFees = _LocalDrivingLicenseApplications.LicenseClassesinfo.ClassFees;
                License.IsActive = true;
                License.IssueReason = 1;
                License.CreatedByUserID = 1;
          
                
                if (License.Save())
                {
                    _LocalDrivingLicenseApplications.Applicationinfo.SetStatusComplet();
                    MessageBox.Show("The Licence Issue Succsed ");

                    btnIssue.Enabled = false;

                }



            }

        }
    }
}



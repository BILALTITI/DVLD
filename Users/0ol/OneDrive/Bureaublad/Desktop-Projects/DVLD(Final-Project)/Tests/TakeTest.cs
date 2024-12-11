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
using static DVLD__Business_Layer.TestTypess;

namespace DVLD
{
    public partial class TakeTest : Form
    {

        private TestTypes.enTestType _TestType;

         int _TestAppointmentsID;
        LocalDrivingLicenseApplications _localDrivingLicenseApplications;
        Tests _TestResult;
        TestAppointments _testAppointments;
        public TakeTest(TestTypes.enTestType enTestType, int TestAppointmentsID)
        {
            _TestAppointmentsID = TestAppointmentsID;
            _TestType = enTestType;

            _testAppointments =TestAppointments.Find(TestAppointmentsID);
            InitializeComponent();
        }

        public TakeTest()
        {
            InitializeComponent();
        }
        void LoadData()
        { 

            LBDLAPPID2.Text = _testAppointments.LocalDrivingLicenseApplicationID.ToString();
             lbAppliedForlicence2.Text = LicenseClasses.Find(_testAppointments.LocalDrivingLicenseApplicationsInfo.LicenseClassID).ClassName.ToString();
            lbTrail2.Text = "";
            lbDate2.Text = _testAppointments.AppointmentDate.ToString();
            LBName2.Text = clsPerson.Find(_testAppointments.LocalDrivingLicenseApplicationsInfo.Applicationinfo.ApplicantPersonID).FullName();

            lbfees2.Text = _testAppointments.PaidFees.ToString();
            if (_TestAppointmentsID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;

            RBPass.Enabled = true;

            _TestResult = new Tests();
        
        }
        private void TakeTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                      "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
             )
            {
                return;
            }

            _TestResult.TestAppointmentID = _testAppointments.TestAppointmentID;
            _TestResult.TestResult = RBPass.Checked;
            _TestResult.Notes = tbNote.Text.Trim();
            _TestResult.CreatedByUserID = clsGloabalcs.CurrentUser.UserID;

            if (_TestResult.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTestID2.Text = _TestResult.TestID.ToString();
                groupBox2.Enabled = false;
                btnSave.Enabled = false;
                 this.Close();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

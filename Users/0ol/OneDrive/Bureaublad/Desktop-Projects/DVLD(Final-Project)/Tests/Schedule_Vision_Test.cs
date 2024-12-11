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
    public partial class Schedule_Vision_Test : Form
    {
 
        int _LocalDrivingApplicationID;
        int _TestTypeID;
        int _TestAppointmentsID;
      LocalDrivingLicenseApplications _LocalDrivingApplication;
        private TestTypess.TestTypes.enTestType _TestType = TestTypess.TestTypes.enTestType.VisionTest;

        User _User;
        public Schedule_Vision_Test(int LocalDrivingApplicationID,int TestTypeID,int TestAppointmentsID)
        {
        
        InitializeComponent();
            _TestAppointmentsID = TestAppointmentsID;
            _TestTypeID= TestTypeID;
            _TestType = (TestTypes.enTestType)TestTypeID;
            _LocalDrivingApplicationID = LocalDrivingApplicationID;
            _LocalDrivingApplication = LocalDrivingLicenseApplications.Find(LocalDrivingApplicationID);
        }
        public Schedule_Vision_Test(int LocalDrivingApplicationID)
        {
            _LocalDrivingApplicationID = LocalDrivingApplicationID;
            InitializeComponent();
        }
        private void _refresh()
        {
          DGVVISONTEST.DataSource = TestAppointments.GetGetApplicationTestAppointmentsPerTestType(_LocalDrivingApplicationID, _TestTypeID);

        }
        private void Schedule_Vision_Test_Load(object sender, EventArgs e)
        {
          
            DataTable dt = TestAppointments.GetGetApplicationTestAppointmentsPerTestType(_LocalDrivingApplicationID,_TestTypeID);
        ctrlApplicationInfo1.ShowInfo(_LocalDrivingApplicationID);

            DGVVISONTEST.DataSource = dt;

            lbCountRecords.Text = DGVVISONTEST.RowCount.ToString();
            if (DGVVISONTEST.Rows.Count > 0)
            {
                DGVVISONTEST.Columns[0].HeaderText = "Appointment ID";
                DGVVISONTEST.Columns[0].Width = 150;

                DGVVISONTEST.Columns[1].HeaderText = "Appointment Date";
                DGVVISONTEST.Columns[1].Width = 200;

                DGVVISONTEST.Columns[2].HeaderText = "Paid Fees";
                DGVVISONTEST.Columns[2].Width = 150;

                DGVVISONTEST.Columns[3].HeaderText = "Is Locked";
                DGVVISONTEST.Columns[3].Width = 100;
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplications _localDrivingLicenseApplication = LocalDrivingLicenseApplications.Find(_LocalDrivingApplicationID);

             if (_localDrivingLicenseApplication.IsThereAttemps(_LocalDrivingApplicationID,_TestTypeID))
            {

                MessageBox.Show("Person Already Have an Active Appointment for this test ,You can't Add a new Appotment" +" "

                   , "Not Alloed Yet ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tests LastTest = _LocalDrivingApplication.GetLastTestPerTestType(_TestType);

            if (LastTest == null)
            {
                frmTests frm1 = new frmTests(_LocalDrivingApplicationID, _TestType);
                frm1.ShowDialog();
                Schedule_Vision_Test_Load(null, null);
                return;
            }
            if (TestAppointments.getTestResult(_localDrivingLicenseApplication.Applicationinfo.ApplicantPersonID, _TestTypeID, _LocalDrivingApplication. LicenseClassID))
            {


                MessageBox.Show(" Cannot Sechule, Vision Becose Is Passed ", "ُError :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

                frmTests frm = new frmTests(_LocalDrivingApplicationID,_TestType);
                frm.ShowDialog();
            _refresh();
            }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)DGVVISONTEST.CurrentRow.Cells[0].Value;

            TakeTest takeTest = new TakeTest(_TestType,TestAppointmentID);
            takeTest.ShowDialog();

            _refresh();
        }

        private void DGVVISONTEST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            bool IsPassed = (bool)DGVVISONTEST.CurrentRow.Cells[3].Value;
            TTAKETest.Enabled = !IsPassed;
            editTestToolStripMenuItem.Enabled = !IsPassed;
        }

        private void ctrlApplicationInfo2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVVISONTEST_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
           
        }

        private void ctrlApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void lbScheduleVisonTest_Click(object sender, EventArgs e)
        {

            
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)DGVVISONTEST.CurrentRow.Cells[0].Value;
            frmTests schedule_Test = new frmTests(  _LocalDrivingApplicationID, _TestType, TestAppointmentID  );
            schedule_Test.ShowDialog();
        }
    }
}

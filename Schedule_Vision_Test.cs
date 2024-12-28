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
using static DVLD__Business_Layer.TestAppointment;
using static DVLD__Business_Layer.TestTypess;

namespace DVLD
{
    public partial class Schedule_Vision_Test : Form
    {
 
        int _LocalDrivingApplicationID;
        int _TestTypeID;
        int _TestAppointmentsID;
      LocalDrivingLicenseApplications _LocalDrivingApplication;
         User _User;
        public Schedule_Vision_Test(int LocalDrivingApplicationID,int TestTypeID,int TestAppointmentsID)
        {
        
        InitializeComponent();
            _TestAppointmentsID = TestAppointmentsID;
            _TestTypeID= TestTypeID;
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
          DGVVISONTEST.DataSource = TestAppointments.GetAllTestAppointment(_LocalDrivingApplicationID, _TestTypeID);

        }
        private void Schedule_Vision_Test_Load(object sender, EventArgs e)
        {
            if (_TestTypeID==1)
            {
                lbScheduleVisonTest.Text = "Schedule Vision Test ";
            }

            if (_TestTypeID == 2)
            {
                lbScheduleVisonTest.Text = "Schedule Written Test ";
                
            }
            if (_TestTypeID == 3)
            {
                lbScheduleVisonTest.Text = "Schedule Street Test ";
            }

            DataTable dt = TestAppointments.GetAllTestAppointment(_LocalDrivingApplicationID,_TestTypeID);
        ctrlApplicationInfo1.ShowInfo(_LocalDrivingApplicationID);
           
             DGVVISONTEST.DataSource =TestAppointments.GetAllTestAppointment(_LocalDrivingApplicationID,_TestTypeID);
       

            lbCountRecords.Text = DGVVISONTEST.RowCount.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             if (LocalDrivingLicenseApplications.IsThereAttemps(_LocalDrivingApplicationID,_TestTypeID))
            {

                MessageBox.Show("Person Already Have an Active Appointment for this test ,You can't Add a new Appotment" +" "

                   , "Not Alloed Yet ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TestAppointment.TestAppointments.getTestResult(_LocalDrivingApplication.Applicationinfo.ApplicantPersonID, _TestTypeID, _LocalDrivingApplication. LicenseClassID))
            {


                MessageBox.Show(" Cannot Sechule, Vision Becose Is Passed ", "ُError :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

                Schedule_test schedule_Test = new Schedule_test(_LocalDrivingApplicationID,-1,_TestTypeID);
                schedule_Test.ShowDialog();
            _refresh();
            }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)DGVVISONTEST.CurrentRow.Cells[0].Value;

            TakeTest takeTest = new TakeTest(_TestTypeID,TestAppointmentID);
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
            Schedule_test schedule_Test = new Schedule_test(  _LocalDrivingApplicationID, TestAppointmentID,   _TestTypeID  );
            schedule_Test.ShowDialog();
        }
    }
}

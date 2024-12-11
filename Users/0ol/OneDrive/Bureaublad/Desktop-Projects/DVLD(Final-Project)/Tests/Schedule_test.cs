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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class Schedule_test2 : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public enum enCreationTest { FirstTime = 0, Retake = 1 };
        private enCreationTest _Mode2;
         LocalDrivingLicenseApplications _LocalDrivingLicenseApplications;
        private int _LocalDrivingLicenseApplicationID = -1;
  TestAppointments  _TestAppointment;
        private int _TestAppointmentID = -1;
        private   int   _TestTybeID=-1;
        


        public Schedule_test2(int LocalDrivingLicenseApplicationsID,int TestApointmentID=-1,int TestTybe =1)
        {

            _TestTybeID = TestTybe;
            _TestAppointmentID = TestApointmentID;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationsID;

            InitializeComponent();
        }
        public Schedule_test2()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            _TestAppointment = TestAppointments.Find(_TestAppointmentID);
            if (_TestAppointment == null )
          
            {
                MessageBox.Show("Error : No Test Appoitment  With ID=" + _TestAppointmentID.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
                return;
            }
            lbfees2.Text=_TestAppointment.PaidFees.ToString();
           if (DateTime.Compare(DateTime.Now,_TestAppointment.AppointmentDate)>0)
            {
                dateTimePicker1.MinDate = DateTime.Now;
            }
           else
            {
                dateTimePicker1.MinDate = _TestAppointment.AppointmentDate;
            }
            dateTimePicker1.Enabled = false;
            btnSave.Enabled = false;
            lbb.Text = "Person Already Sat for this Test ,Appoitment Locked";
            if (_TestAppointment.RetakeTestApplicationID==-1)
            {
                lbRetakeFees2.Text = "0";
                lbRetakeTestAPPID2 .Text= "N/A";
            }
            else
            {
               lbRetakeFees2.Text=_TestAppointment.RetakeTestApplicationInfo.PaidFees.ToString() ;
                groupBox2.Enabled = true;
                lbScheduleTest.Text = "Scheduled Retake Test";
                lbRetakeTestAPPID2.Text=_TestAppointment.RetakeTestApplicationID.ToString   ();

                
            }
        }
        private void Schedule_test_Load(object sender, EventArgs e)
        {


            Refresh();


            if (_TestAppointmentID == -1)

                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            _LocalDrivingLicenseApplications = LocalDrivingLicenseApplications.Find(_LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplications==null)
            {
                MessageBox.Show("Error : No Local Driving License Application With ID="+ _LocalDrivingLicenseApplicationID.ToString(),"Error ",MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled=false;
                return; 
            }
            if (LocalDrivingLicenseApplications.IsAttends(_LocalDrivingLicenseApplicationID, _TestTybeID)) 
            _Mode2 = enCreationTest.Retake;
            else
                _Mode2 = enCreationTest.FirstTime;
                   if (_Mode2==enCreationTest.Retake)
            {
                lbRetakeFees2.Text=Applicationstype.Find(8).ApplicationFees.ToString();
                groupBox2.Enabled = true;
                lbScheduleTest.Text = "Schedule Retake Test ";
                lbRetakeTestAPPID2.Text = "N/A";
                lbRetakeFees2.Text = "0";
            }
                   else
            {
                groupBox2.Enabled = false;
                lbScheduleTest.Text = "Schedule Test ";
                lbRetakeTestAPPID2.Text = "N/A";
                lbRetakeFees2.Text = "0";
            }
                   LBDLAPPID2.Text=_LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
            lbAppliedForlicence2.Text = LicenseClasses.Find(_LocalDrivingLicenseApplications.LicenseClassID).ClassName;
            LBName2.Text=clsPerson.Find(_LocalDrivingLicenseApplications.Applicationinfo.ApplicantPersonID).FullName().ToString();
            lbTrail2.Text = "";
            if (_Mode==enMode.AddNew)
            {
                //lbfees2.Text = TestTypes.Find(_TestTybeID).TestTypeFees.ToString();
                dateTimePicker1.MinDate = DateTime.Now;
                lbRetakrtestAPPID.Text = "N/A";
                _TestAppointment = new TestAppointments();
            }
            else
            {
                 loadData(); 
            }
            lbtotoalfees2.Text = (Convert.ToDecimal(lbfees2.Text) + Convert.ToDecimal(lbRetakeFees2.Text)).ToString();
        }

        private void lbDLAPPID_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void LBDLAPPID2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool HandelRetakeTest()
        {
            if (_Mode == enMode.AddNew && _Mode2==enCreationTest.Retake)
            {
                Applications App = new Applications();

            App.ApplicationDate=DateTime.Now;

                App.ApplicationsTypesID = Applicationstype.Find(8).ApplicationTypeID;
                App.ApplicationStatus = Applications.enApplicationStatus.Completed;
                App.ApplicantPersonID = _LocalDrivingLicenseApplications.Applicationinfo.ApplicantPersonID;
                App.PaidFees = Applicationstype.Find(8).ApplicationFees;
                    App.LastStatusDate=DateTime.Now;
                App.CreatedByUserID = clsGloabalcs.CurrentUser.UserID;
           if (!App.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                     MessageBox.Show("Failed To Create Application ","Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);  
                    return false;
                }
                _TestAppointment.RetakeTestApplicationID = App.ApplicationID;

            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!HandelRetakeTest())
                return;





            _TestAppointment.TestTypeID=TestTypes.enTestType.VisionTest;
            _TestAppointment.AppointmentDate = dateTimePicker1.Value;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID;
            _TestAppointment.PaidFees = Convert.ToDecimal(lbfees2.Text);
            _TestAppointment.CreatedByUserID = clsGloabalcs.CurrentUser.UserID;








            if (_TestAppointment.Save())
            {
                _LocalDrivingLicenseApplications.Applicationinfo.ApplicationDate = dateTimePicker1.Value;
                {
                    lbRetakeTestAPPID2.Text = _LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
                    MessageBox.Show("Data Saved Succesfully");
                    
                    _Mode = enMode.Update;
                    this.Close();
                    Refresh();
                }

            }
            else
            {
                MessageBox.Show("Data Not Saved Succesfully");

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbRetakeTestAPPID2_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using DVLD.Properties;
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
    public partial class ctrlSchduleTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;


        private TestTypess.TestTypes.enTestType _TestTypeID = TestTypess.TestTypes.enTestType.VisionTest;
        private LocalDrivingLicenseApplications _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;
        private TestAppointments _TestAppointment;
        private int _TestAppointmentID = -1;

        public TestTypess.TestTypes.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case TestTypess.TestTypes.enTestType.VisionTest:
                        {
                            gbTestType.Text = "Vision Test";
                            pbTestTypeImage.Image = Resources.Vision_512;
                            break;
                        }

                    case TestTypess.TestTypes.enTestType.WrittenTest:
                        {
                            gbTestType.Text = "Written Test";
                            pbTestTypeImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case TestTypess.TestTypes.enTestType.StreetTest:
                        {
                            gbTestType.Text = "Street Test";
                            pbTestTypeImage.Image = Resources.driving_test_512;
                            break;


                        }
                }
            }
        }
    

      

        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && LocalDrivingLicenseApplications.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                lbMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dateTimePicker1.Enabled = false;
                return false;
            }

            return true;
        }
        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = TestAppointments.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lbfees2.Text = _TestAppointment.PaidFees.ToString();

            //we compare the current date with the appointment date to set the min date.
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dateTimePicker1.MinDate = DateTime.Now;
            else
               dateTimePicker1.MinDate = _TestAppointment.AppointmentDate;

            dateTimePicker1.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lbrappfees2.Text = "0";
              lbRtestAppid2.Text = "N/A";
            }
            else
            {
                lbrappfees2.Text = _TestAppointment.RetakeTestApplicationInfo.PaidFees.ToString();
                GPRetakeTestInfo.Enabled = true;
              lbScheduleTest.Text = "Schedule Retake Test";
                lbRtestAppid2.Text = _TestAppointment.RetakeTestApplicationID.ToString();

            }
            return true;
        }
        private bool _HandleAppointmentLockedConstraint()
        {
            //if appointment is locked that means the person already sat for this test
            //we cannot update locked appointment
            if (_TestAppointment.IsLocked)
            {
                lbMessage.Visible = true;
              lbMessage.Text = "Person already sat for the test, appointment loacked.";
                dateTimePicker1.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }
            else
              lbMessage.Visible = false;

            return true;
        }
        private bool _HandlePrviousTestConstraint()
        {
            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (TestTypeID)
            {
                case TestTypess.TestTypes.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    lbMessage.Visible = false;

                    return true;

                case TestTypess.TestTypes.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.
                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(TestTypess.TestTypes.enTestType.VisionTest))
                    {
                        lbMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lbMessage.Visible = true;
                        btnSave.Enabled = false;
                        dateTimePicker1.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lbMessage.Visible = false;
                        btnSave.Enabled = true;
                       dateTimePicker1.Enabled = true;
                    }


                    return true;

                case TestTypess.TestTypes.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(TestTypess.TestTypes.enTestType.VisionTest))
                    {
                        lbMessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lbMessage.Visible = true;
                        btnSave.Enabled = false;
                        dateTimePicker1.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lbMessage.Visible = false;
                        btnSave.Enabled = true;
                       dateTimePicker1.Enabled = true;
                    }


                    return true;

            }
            return true;

        }
        private bool _HandleRetakeApplication()
        {
            //this will decide to create a seperate application for retake test or not.
            // and will create it if needed , then it will linkit to the appoinment.
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                //incase the mode is add new and creation mode is retake test we should create a seperate application for it.
                //then we linke it with the appointment.

                //First Create Applicaiton 
             Applications Application = new Applications();

                Application.ApplicantPersonID = _LocalDrivingLicenseApplication.Applicationinfo.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationID = (int)Applications.enApplicationType.RetakeTest;
                Application.ApplicationStatus = 3;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = Applicationstype.Find((int)Applications.enApplicationType.RetakeTest).ApplicationFees;
                Application.CreatedByUserID =clsGloabalcs.CurrentUser.UserID;

                if (!Application.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;

            }
            return true;
        }

        public void LoadInfo(int LocalDrivingLicenseApplicationID,int AppointmentID = -1)
        {
            if (AppointmentID==-1)
                _Mode= enMode.AddNew;
            else
           _Mode=enMode.Update;

            _LocalDrivingLicenseApplicationID=LocalDrivingLicenseApplicationID;
            _TestAppointmentID= AppointmentID;

            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {

                MessageBox.Show("Error : No Local Driving License Application With ID=" + _LocalDrivingLicenseApplicationID.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            if (_LocalDrivingLicenseApplication.DoesAttendTestType(_TestTypeID))

                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;


            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {
                lbrappfees2.Text =Applicationstype.Find((int)Applications.enApplicationType.RetakeTest).ApplicationFees.ToString();
                GPRetakeTestInfo.Enabled = true;
             lbScheduleTest.Text = "Schedule Retake Test";
                lbRtestAppid2.Text = "0";
            }
            else
            {
                GPRetakeTestInfo.Enabled = false;
             lbScheduleTest.Text = "Schedule Test";
                lbrappfees2.Text = "0";
              lbRtestAppid2.Text = "N/A";
            }

      LBDLAPPID2.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lbAppliedForlicence2.Text = _LocalDrivingLicenseApplication.LicenseClassesinfo.ClassName;
           LBName2.Text = _LocalDrivingLicenseApplication.Applicationinfo.personinfo.FullName();

            //this will show the trials for this test before  
           lbTrail2.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest( _TestTypeID).ToString();


            if (_Mode == enMode.AddNew)
            {
                lbfees2.Text =TestTypess.TestTypes.Find(_TestTypeID).TestTypeFees.ToString();
                dateTimePicker1.MinDate = DateTime.Now;
               lbRtestAppid2.Text = "N/A";

                _TestAppointment = new TestAppointments();
            }

            else
            {

                if (!_LoadTestAppointmentData())
                    return;
            }


            lbtotalfees2.Text = (Convert.ToDecimal(lbfees2.Text) + Convert.ToDecimal(lbrappfees2.Text)).ToString();


            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePrviousTestConstraint())
                return;





        }
        public ctrlSchduleTest()
        
        {
            InitializeComponent();
        }

        private void ctrlSchduleTest_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID =_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.AppointmentDate = dateTimePicker1.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(lbfees2.Text);
            _TestAppointment.CreatedByUserID = clsGloabalcs.CurrentUser.UserID;
            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void GPVisionTest_Enter(object sender, EventArgs e)
        {

        }

        private void lbTrail_Click(object sender, EventArgs e)
        {

        }

        private void lbfees2_Click(object sender, EventArgs e)
        {

        }
    }
}
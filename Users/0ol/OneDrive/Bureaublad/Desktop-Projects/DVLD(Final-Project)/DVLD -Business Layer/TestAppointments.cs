using Data_Accses__Layer;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
 using static DVLD__Business_Layer.TestTypess;

namespace DVLD__Business_Layer
{

        public class TestAppointments
        {
            public enum enMode { AddNew = 0, Update = 1 };
            public enMode Mode = enMode.AddNew;

     public     TestTypes.enTestType  TestTypeID { set; get; }
      public    int TestAppointmentID { get; set; }
      public    int LocalDrivingLicenseApplicationID { get; set; }
      public    DateTime AppointmentDate { get; set; }
            public LocalDrivingLicenseApplications LocalDrivingLicenseApplicationsInfo;
      public    decimal PaidFees { get; set; }
           public int CreatedByUserID { get; set; }
      public    bool IsLocked { get; set; }
          public int RetakeTestApplicationID {  get; set; }
            public Applications RetakeTestApplicationInfo;
            public int TestID
            {
                get { return _GetTestID(); }

            }

            public TestAppointments()
            {

                this.RetakeTestApplicationID = -1;

                this.TestAppointmentID = -1;
                this.TestTypeID = TestTypes.enTestType.VisionTest;

                this.LocalDrivingLicenseApplicationID = -1;

                this.AppointmentDate = DateTime.Now;
                this.PaidFees = 0;
                this.CreatedByUserID = -1;
                this.IsLocked = false;

                Mode = enMode.AddNew;

            }

            private TestAppointments(int TestAppointmentID,  TestTypes.enTestType TestTypeID,
            int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTest)
            {
          this.     TestAppointmentID = TestAppointmentID;
          this.     TestTypeID = TestTypeID;
          this.     LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
          this.     AppointmentDate = AppointmentDate;
          this.     PaidFees = PaidFees;
          this.     CreatedByUserID = CreatedByUserID;
          this.     IsLocked = IsLocked;
                this.RetakeTestApplicationID= RetakeTest;
                this.RetakeTestApplicationInfo = Applications.Find(RetakeTest);
                this.LocalDrivingLicenseApplicationsInfo = LocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);
                Mode = enMode.Update;
            }
            private bool _AddNewTestAppointment()
            {
                //call DataAccess Layer 

                this.TestAppointmentID = TestAppointmentsData.AddNewTestAppointments(
              (int)   this.TestTypeID,
            this.LocalDrivingLicenseApplicationID,
            this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID);

                return (this.TestAppointmentID != -1);
            }

            private bool _UpdateTestAppointment()
            {
                //call DataAccess Layer 

                return TestAppointmentsData.UpdateTestAppointments(this.TestAppointmentID,(int) this.TestTypeID,
            this.LocalDrivingLicenseApplicationID,
            this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID);

            }

            public static TestAppointments Find(int TestAppointmentID)
            {
                int RetakeTestApplicationID = -1;
                int TestTypeID = -1;
 
                int LocalDrivingLicenseApplicationID = 0;

                DateTime AppointmentDate = DateTime.Now;
                decimal PaidFees = 0;
                int CreatedByUserID = 0;
                 
                bool IsLocked= false;
                if (TestAppointmentsData.GetTestAppointmentsInfoByID(  TestAppointmentID, ref  TestTypeID,
           ref   LocalDrivingLicenseApplicationID,
          ref    AppointmentDate,ref    PaidFees,ref    CreatedByUserID, ref  IsLocked,ref RetakeTestApplicationID))

                    return new TestAppointments(TestAppointmentID,(TestTypes.enTestType) TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked,RetakeTestApplicationID);
                else
                    return null;

            }




            public bool Save()
            {


                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewTestAppointment())
                        {

                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.Update:

                        return _UpdateTestAppointment();

                }




                return false;
            }

            public static DataTable GetAllTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
            {
                return TestAppointmentsData.GetAllTestAppointments(LocalDrivingLicenseApplicationID, TestTypeID);

            }
            public static DataTable GetGetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
            {
                return TestAppointmentsData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, TestTypeID);

            }
            public   DataTable GetGetApplicationTestAppointmentsPerTestType(TestTypes.enTestType TestTypeID)
            {
                return TestAppointmentsData.GetApplicationTestAppointmentsPerTestType(this.LocalDrivingLicenseApplicationID,(int) TestTypeID);

            }

            public static bool DeleteTestAppointment(int ID)
            {
                return TestAppointmentsData.DeleteTestAppointments(ID);
            }

            public static bool isTestTestAppointmentExist(int ID)
            {
                return TestAppointmentsData.IsTestAppointmentsExist(ID);
            }
            public static bool getTestResult(int PersonID, int TestTypeID, int LicenseClassID)
            {
                return TestAppointmentsData.GetTestResult(PersonID, TestTypeID, LicenseClassID);
            }

            private int _GetTestID()
            {
                return TestAppointmentsData.GetTestID(TestAppointmentID);
            }


        }

    }


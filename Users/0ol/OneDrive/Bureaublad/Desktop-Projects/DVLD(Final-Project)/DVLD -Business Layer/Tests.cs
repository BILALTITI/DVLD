using ContactsBusinessLayer;
using ContactsDataAccessLayer;
using Data_Accses__Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Business_Layer
{
    public class Tests
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public  enum enTestType { Vision = 1, Written = 2, Street=3 };
        private enTestType _Test;
        public int TestID { get; set; }
        public TestAppointments Appointmentsinfo { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public Tests ()
        {



            this.TestID = -1;
            this.TestAppointmentID = 0;
            this.Notes = "";
            this.CreatedByUserID = 0;
            this.TestResult = false;
            Mode = enMode.AddNew;

        }

        private Tests(int TestID,  int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.Appointmentsinfo = TestAppointments.Find(TestAppointmentID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }
        private bool _AddNewTest()
        {
            //call DataAccess Layer 

            this.TestID = TestsData.AddNewTest(this.TestAppointmentID,  this. TestResult, this.Notes, this. CreatedByUserID);

            return (this.TestID != -1);
        }

        private bool _UpdateTest()
        {
            //call DataAccess Layer 

            return TestsData.UpdateTest(   this.TestID,    this.TestAppointmentID,   this.TestResult,  this.Notes,   this. CreatedByUserID);

        }

        public static Tests Find(int TestID)
        {

            string TestName = "";
            bool TestResult = false;
            int TestAppointmentID = 0;
            
            string Notes = "";
           int CreatedByUserID = 0;
            if (TestsData.GetTestInfoByID(TestID, ref TestAppointmentID,ref TestResult,ref TestName,ref CreatedByUserID))

                return new Tests ( TestID,  TestAppointmentID,  TestResult,  Notes,  CreatedByUserID);
            else
                return null;

        }

        public static Tests FindbyPersonIDAndLicenseClass(int PersonID, int LicenseClassID, TestTypess.TestTypes.enTestType TestTypeID)
        {
            int TestID = -1;
            string TestName = "";
            bool TestResult = false;
            int TestAppointmentID = 0;

            string Notes = "";
            int CreatedByUserID = 0;
            if (TestsData.GetLastTestByPersonAndTestTypeAndLicenseClass(PersonID,LicenseClassID,(int)TestTypeID,ref TestID, ref TestAppointmentID, ref TestResult, ref TestName, ref CreatedByUserID))

                return new Tests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;

        }



        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTest();

            }




            return false;
        }

        public static DataTable GetAllCountries()
        {
            return TestsData.GetAllCountries();

        }

        public static bool DeleteTest(int ID)
        {
            return TestsData.DeleteTest(ID);
        }
        public static Byte GetPassedTest(int ID)
        {
            return TestsData.GetPassedTestCount(ID);
        }
        public static bool GetAllPassedTest(int ID)
        {
            return TestsData.GetPassedTestCount(ID)==3;
        }

        public static bool isTestExist(int ID)
        {
            return TestsData.IsTestExist(ID);
        }

    

    }
}

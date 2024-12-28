using Data_Accses__Layer;
using Data_Accses_Layer;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD__Business_Layer.TestTypess;

namespace DVLD__Business_Layer
{
    public class LocalDrivingLicenseApplications 
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public Applications Applicationinfo { get; set; }
public LicenseClasses LicenseClassesinfo { get; set; }
        public int LicenseClassID { get; set; }
        //public License.License Licenseinfo { get; set; }
        public LocalDrivingLicenseApplications()

        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = 0;
             this.LicenseClassID = 0;

            Mode = enMode.AddNew;

        }

        private LocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {

            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.Applicationinfo = Applications.Find(ApplicationID);
            this.LicenseClassesinfo = LicenseClasses.Find(LicenseClassID);

            //this.Licenseinfo = License.License.Find(Licenseinfo.LicenseID);
            Mode = enMode.Update;
        }



        private bool _AddNewDriverData()
        {
            //call DataAccess Layer 
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationsData.AddNewLocalDrivingLicenseApplications(this.ApplicationID, this.LicenseClassID );

            return (this.LocalDrivingLicenseApplicationID != -1);
        }
        private bool _UpdateDriverData()
        {
            //call DataAccess Layer 
            return LocalDrivingLicenseApplicationsData.UpdateLocalDrivingLicenseApplications(
  this.LocalDrivingLicenseApplicationID, this.ApplicationID,
              this.LicenseClassID
             );


        }
        public static  LocalDrivingLicenseApplications Find(int LocalDrivingLicenseApplicationID)
        {


            int ApplicationID = 0;
             int LicenseClassID = 0;
            bool isfound = LocalDrivingLicenseApplicationsData.GetLocalDrivingLicenseApplicationsInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID,
        ref  LicenseClassID);


            if (isfound)
                return new LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, ApplicationID,
         LicenseClassID);

            return null;
        }
         public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriverData())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDriverData();

            }




            return false;
        }
        public static DataTable GetAlLocalDrivingLicenseApplications()
        {
            return LocalDrivingLicenseApplicationsData.GetAlLocalDrivingLicenseApplications();

        }
        public bool DoesPassTestType(TestTypes.enTestType TestTypeID)

        {
            return LocalDrivingLicenseApplicationsData.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, TestTypes.enTestType TestTypeID)

        {

            return LocalDrivingLicenseApplicationsData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public bool DoesAttendTestType(TestTypes.enTestType TestTypeID)

        {
            return LocalDrivingLicenseApplicationsData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
      
        public bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, Tests.enTestType TestTypeID)

        {
            return LocalDrivingLicenseApplicationsData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static bool DeletetLocalDrivingLicenseApplications(int ID)
        {
            return LocalDrivingLicenseApplicationsData.DeleteLocalDrivingLicenseApplications(ID);;
        }
        //public Tests GetLastTestPerTestType(TestTypes.enTestType TestTypeID)
        //{
        //    return Tests.FindLastTestPerPersonAndLicenseClass(this.ApplicantPersonID, this.LicenseClassID, TestTypeID);
        //}

        public static bool isLocalDrivingLicenseApplicationsExsist(int ID)
        {
            return LocalDrivingLicenseApplicationsData.IsLocalDrivingLicenseApplicationsExist(ID) ;
        }
        public static bool IsAttends(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            return LocalDrivingLicenseApplicationsData.IsLocalDrivingLicenseApplicationsAttendTest(LocalDrivingLicenseApplicationID, TestTypeID);   
        }
        public  bool IsThereAttemps(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return LocalDrivingLicenseApplicationsData.IsThereAttemps(LocalDrivingLicenseApplicationID, TestTypeID);
        }
        public static bool IsPassedTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return LocalDrivingLicenseApplicationsData.IsPassedTest(LocalDrivingLicenseApplicationID,TestTypeID);
        }
        public   int GetActiveLicence()
        {
            return LocalDrivingLicenseApplicationsData.GetActiveLicence(this.Applicationinfo.ApplicantPersonID, this.LicenseClassID);
        }
        public byte TotalTrialsPerTest(TestTypes.enTestType TestTypeID)
        {
            return LocalDrivingLicenseApplicationsData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        //public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, TestTypes.enTestType TestTypeID)

        //{

        //    return LocalDrivingLicenseApplicationsData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        //}
        public Tests GetLastTestPerTestType(TestTypes.enTestType TestTypeID)
        {
            return Tests.FindbyPersonIDAndLicenseClass(this.Applicationinfo.ApplicantPersonID, this.LicenseClassID, TestTypeID);
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, TestTypes.enTestType TestTypeID)

        {
            return LocalDrivingLicenseApplicationsData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool IslicenseIssued()
        {
            return GetActiveLicence() != -1;
        }
    }
}

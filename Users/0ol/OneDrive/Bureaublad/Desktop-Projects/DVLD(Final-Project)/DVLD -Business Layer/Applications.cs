using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Accses_Layer;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Net;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;


namespace Presntation_Layet
{
    public class  Applications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };
        public enum enCreationTest { FirstTime = 0, Retake = 1 };
        private enCreationTest _Mode2;
           public int ApplicationID{  get; set; }
  public int ApplicantPersonID {  get; set; }
        public int ApplicationsTypesID { set; get; }
      public  int CreatedByUserID { set; get; }
        public DateTime ApplicationDate  { set; get; }
        public enApplicationStatus ApplicationStatus { set; get; }
        public   DateTime LastStatusDate{ set; get; }
        public decimal PaidFees { set; get; }
        public clsPerson personinfo { set; get; }
   
        public  Applications()

        {
            this.ApplicationID = -1;
            this.ApplicationsTypesID = 0;
            this.ApplicantPersonID = 0;
            this.ApplicationDate = DateTime.Now;
            this.LastStatusDate= DateTime.Now;
            this.PaidFees = 0;
            this.ApplicationStatus = enApplicationStatus.New;
            this.CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }

        private  Applications(int ApplicationID,int ApplicantPersonID,DateTime ApplicationDate,
       enApplicationStatus ApplicationStatus,int ApplicationsTypesID, DateTime LastStatusDate,decimal PaidFees,int CreatedByUserID)
        {
            this.ApplicationID= ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.personinfo = clsPerson.Find(ApplicantPersonID);
            this.ApplicationDate= ApplicationDate;
            this.ApplicationStatus= ApplicationStatus;
            this.LastStatusDate= LastStatusDate;
            this.CreatedByUserID= CreatedByUserID;
            this.ApplicationsTypesID= ApplicationsTypesID;
            this.PaidFees= PaidFees;
           Mode = enMode.Update;
        }

        

        private bool _AddNewApplication ()
        {
            //call DataAccess Layer 
            this.ApplicationID = clsApplicationsTypesData.AddNewApplications(this. ApplicantPersonID, this. ApplicationDate, this.ApplicationsTypesID, (byte) this. ApplicationStatus,   this. LastStatusDate, this. PaidFees, this .CreatedByUserID);
              
        return (this.ApplicationID != -1);
        }
        private bool _UpdateApplications ()
        {
            //call DataAccess Layer 
            return clsApplicationsTypesData.UpdateApplications(
  this. ApplicantPersonID,   this.ApplicationDate,
           ( byte) this.ApplicationStatus,
              this.LastStatusDate,     this.PaidFees,  this.CreatedByUserID);

 
        }
        public static Applications Find(int ApplicationID)
        {
             
            int ApplicantPersonID = 0;
            DateTime ApplicationDate = DateTime.Now;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            int ApplicationStatus = 0;
            int ApplicationsTypesID = 0;
            int CreatedByUserID = 0;
            bool isfound = clsApplicationsTypesData.GetApplicationsByID( ApplicationID,ref   ApplicantPersonID, ref   ApplicationDate,
     ref ApplicationsTypesID,   ref    ApplicationStatus, ref   LastStatusDate, ref  PaidFees, ref    CreatedByUserID);


            if (isfound)
                return new Applications(ApplicationID,ApplicantPersonID,ApplicationDate,
      (enApplicationStatus)  ApplicationsTypesID, ApplicationStatus, LastStatusDate,PaidFees,CreatedByUserID);
             
                return null;
        }
    


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplications();

            }




            return false;
        }
        public static DataTable GetAllApplicationsTypes()
        {
            return  clsApplicationsTypesData.GetAllApplications();

        }

        public static bool DeletetPerso(int ID)
        {
            return  clsApplicationsTypesData.DeleteApplications(ID);
        }

        public static bool isApplicationsTypesExsist(int ID)
        {
            return  clsApplicationsTypesData.IsApplicationsExsist(ID);
        }
        public  bool UpDateApplicationStatus(int ApplicationID, int NewStatus)
        {
            return clsApplicationsTypesData.UpDateApplicationStatus(this.ApplicationID,   NewStatus);
   
        }
        public static int GetActiveApplicationIDForLicenseClass(int PersonID,  Applications.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationsTypesData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }

        public bool Cancel()
        {

            return clsApplicationsTypesData.UpDateApplicationStatus(this.ApplicationID, 2);
        }

        public bool SetStatusComplet( )
        {
            return clsApplicationsTypesData.UpDateApplicationStatus(this.ApplicationID, 3);
        }
    }

}

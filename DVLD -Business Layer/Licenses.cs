using Data_Accses__Layer;
using DVLD__Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace License
{
    public class License
    {


   public   int LicenseID { get; set; }
   public   DateTime IssueDate { get; set; }
   public   int ApplicationID { get; set; }
   public   int DriverID { get; set; }
   public   int LicenseClass { get; set; }
   public   DateTime ExpirationDate { get; set; }
        public LicenseClasses Licenseinfo;  
        public LocalDrivingLicenseApplications LocalDrivingLicenseApplications { get; set; }
public InternationalLicenses InternationalLicensesinfo { get; set; }
        public Drivers Driversinfo { get; set; }
        public string Notes { get; set; }
   public   decimal PaidFees { get; set; }
   public   bool IsActive { get; set; }
   public   byte  IssueReason { get; set; }
         public string GetIssueReasonText()
        {
            switch (IssueReason)
            {
                case 1:
                    return "First Time ";
                  case 2:
                    return "Renew ";
 
                case 4:
                    return "Replacement for Damaged ";


                default:
                    return "Replacement for Lost. ";
 
              }
         }
        public bool IsDetained
        {
            get { return DetainedLicenses.isDetained(this.LicenseID); }
        }
        public DetainedLicenses DetainedInfo { set; get; }
        public int CreatedByUserID { get; set; }
        public object DeActiveLicence { get; set; }

        public    enum enMode { AddNew = 0, Update = 1 };
   public    enMode Mode = enMode.AddNew;

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };


        public License()

        {
            this.LicenseID  = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.CreatedByUserID = -1;
            this.LicenseClass = -1;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.IsActive = true;
            this.IssueReason = 1;
            this.PaidFees = 0;
            this.IssueDate= DateTime.Now;
 
            Mode = enMode.AddNew;

        }

        private License(int LicenseID,   DateTime IssueDate,
         int ApplicationID, int DriverID, int LicenseClass, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.CreatedByUserID = CreatedByUserID;
             this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.PaidFees = PaidFees;
            this.IssueDate = IssueDate;
             this.ApplicationID = ApplicationID;
            this.LicenseClass = LicenseClass;
            this.Licenseinfo = LicenseClasses.Find(this.LicenseClass);
         this.DetainedInfo= DetainedLicenses.Find(this.LicenseID);
            this.Driversinfo = Drivers.Find(this.DriverID);
            this.LocalDrivingLicenseApplications = LocalDrivingLicenseApplications.Find(this.LicenseID);
      this.InternationalLicensesinfo= InternationalLicenses.Find(this.LicenseID);   
            Mode = enMode.Update;
        }



        private bool  _AddNewLicenses()
        {
            //call DataAccess Layer 
            this.LicenseID = LicensesData.AddNewLicensess( this. IssueDate,
         this. ApplicationID, this. DriverID, this. LicenseClass, this. ExpirationDate, this. Notes, this. PaidFees, this. IsActive, this.IssueReason, this. CreatedByUserID);

            return (this.LicenseID != -1);
        }
        private bool _UpdateLicensess()
        {
            //call DataAccess Layer 
            return LicensesData.UpdateLicensess(this.LicenseID, this.IssueDate,
         this.ApplicationID, this.DriverID, this.LicenseClass, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID
             );


        }
        public static License Find(int LicenseID)
        {
      

            int ApplicationID = -1;
            int DriverID = -1;
            int CreatedByUserID = -1;
            int LicenseClass = -1;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            bool IsActive = true;
            byte IssueReason = 1;
           decimal  PaidFees = -1;
           DateTime IssueDate = DateTime.Now;














            bool isfound = LicensesData.GetLicensessLicenseByID(  LicenseID, ref   IssueDate,
       ref ApplicationID, ref DriverID, ref LicenseClass, ref  ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);


            if (isfound)
                return new License(LicenseID,
                                    IssueDate,
                                    ApplicationID,
                                    DriverID,
                                    LicenseClass,
                                    ExpirationDate,
                                    Notes,
                                    PaidFees,
                                    IsActive,
                                    IssueReason,
                                    CreatedByUserID);

            return null;
        }



        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenses())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicensess();

            }




            return false;
        }
        public Boolean IslicenseExpierd()
        {
            return (this.ExpirationDate < DateTime.Now);
                
        }
        public static DataTable GetAlLLicense()
        {
            return LicensesData.GetAllLicensess();

        }
        public static DataTable GetAlLLicenseByPersonID(int PersonID)
        {
            return LicensesData.GetLicencebyPersonID(PersonID);

        }
        public static DataTable GetInternationalLicencebyPersonID(int PersonID)
        {
            return LicensesData.GetInternationalLicencebyPersonID(PersonID);

        }
        public static bool DeleteLicense(int ID)
        {
            return LicensesData.DeleteLicensess(ID);
        }
        public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)

        {
            return LicensesData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);

        }
        public static DataTable GetDriverLicenses(int DriverID)
        {
            return LicensesData.GetDriverLicenses(DriverID);
        }

        public static bool isLocalLicenseExsist(int ID)
        {
            return LicensesData.IsLicensessExsist(ID);
        }
        public static int GetActiveLicenceByDriverID(int DriverID)
        {
            return LicensesData.GetActiveLicenceByDriverID(DriverID);
        }
        public void  DeActiveLicencee()
        {
             LicensesData.DeActiveLicence(this.LicenseID);
        }
    }
}

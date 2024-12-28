using Data_Accses__Layer;
using Data_Accses_Layer;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static DVLD__Business_Layer.TestTypess;
namespace DVLD__Business_Layer
{
    public class InternationalLicenses

    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int InternationalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public DateTime ExpirationDate { set; get; }
        public LicenseClasses Licenseinfo;
        public LocalDrivingLicenseApplications LocalDrivingLicenseApplications { get; set; }
        public Drivers Driversinfo {  set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }

        public int CreatedByUserID { set; get; }
        public bool IsActive { set; get; }






        public InternationalLicenses()
        {
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.IssuedUsingLocalLicenseID = -1;
            this.CreatedByUserID = -1;

            this.InternationalLicenseID = -1;
            this.IssueDate = DateTime.Now;


            Mode = enMode.AddNew;

        }


        public InternationalLicenses(int InternationalLicenseID, DateTime IssueDate, int ApplicationID, int DriverID, DateTime ExpirationDate, int IssuedUsingLocalLicen, int CreatedByUserID, bool IsActive)
        {
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicen;
            this.CreatedByUserID = CreatedByUserID;
           
           
            this.InternationalLicenseID = InternationalLicenseID;
            this.IssueDate = IssueDate;

            this.Driversinfo = Drivers.Find(this.DriverID);
            Mode = enMode.Update;

        }

        private bool _AddNewInternationalLicensesData()
        {
            //call DataAccess Layer 
            this.InternationalLicenseID = InternationalLicensesData.AddNewInternationalLicenses(this.IssueDate,
         this.ApplicationID, this.DriverID, this.ExpirationDate, this.IssuedUsingLocalLicenseID, this.CreatedByUserID, this.IsActive);

            return (this.InternationalLicenseID != -1);
        }
        private bool _UpdateInternationalLicensesData()
        {
            //call DataAccess Layer 
            return InternationalLicensesData.UpdateInternationalLicenses(this.InternationalLicenseID, this.IssueDate,
         this.ApplicationID, this.DriverID, this.ExpirationDate, this.IssuedUsingLocalLicenseID, this.CreatedByUserID, this.IsActive
             );


        }
        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return InternationalLicensesData.GetDriverInternationalLicenses(DriverID);
        }

        public static InternationalLicenses  Find(int InternationalLicenseID)
        {
             
            DateTime IssueDate = DateTime.Now;
            int ApplicationID = -1;
            int DriverID = -1;
            DateTime ExpirationDate = DateTime.Now;
            int IssuedUsingLocalLicenseID = -1;
            int CreatedByUserID = -1;
            bool IsActive = false;


            bool isfound = InternationalLicensesData.GetInternationalLicensesByID(InternationalLicenseID, ref IssueDate,
         ref ApplicationID, ref DriverID, ref ExpirationDate, ref IssuedUsingLocalLicenseID, ref CreatedByUserID, ref IsActive);


            if (isfound)
                return new
              InternationalLicenses (InternationalLicenseID, IssueDate,
           ApplicationID, DriverID, ExpirationDate, IssuedUsingLocalLicenseID, CreatedByUserID, IsActive);

            return null;
        }
        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicensesData())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateInternationalLicensesData();

            }




            return false;
        }


        public static DataTable GetAlInternationalLicence()
        {
            return InternationalLicensesData.GetAllInternationalLicenses();

        }

        public static bool DeleteInternationalLicence(int ID)
        {
            return InternationalLicensesData.DeleteInternationalLicenses(ID); ;
        }

        public static bool isInternationalLicenceExsist(int ID)
        {
            return InternationalLicensesData.IsInternationalLicensesExsist(ID);
        }
        public  int GetActiveInternationalLicenceByDriverID(   )
        {
            return InternationalLicensesData.GetActiveInternationalLicenceByDriverID (this.DriverID);
        }
        public static int GetActiveInternationalLicenceByDriverID2(int DriverId)
        {
            return InternationalLicensesData.GetActiveInternationalLicenceByDriverID(DriverId);
        }
    }


    }




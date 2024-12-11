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


namespace Presntation_Layet
{
    public class  ApplicationsTypes
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

  public int  ApplicantPersonID {  get; set; }
        public int  ApplicationsTypesID { set; get; }
      public  int        CreatedByUserID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int  ApplicationStatus { set; get; }
        public   DateTime LastStatusDate { set; get; }
        public double PaidFees { set; get; }
     
   
        public  ApplicationsTypes()

        {
            this.ApplicationsTypesID = -1;
            this.ApplicantPersonID = 0;
            this.ApplicationDate = DateTime.Now;
            this.LastStatusDate= DateTime.Now;
            this.PaidFees = 0;
            this.ApplicationStatus = 0;
            this.CreatedByUserID = 0;
             Mode = enMode.AddNew;

        }

        private  ApplicationsTypes(int ApplicationTypeID,int ApplicantPersonID,DateTime ApplicationDate,
       int ApplicationStatus,DateTime LastStatusDate,double PaidFees,int CreatedByUserID)
        {

          this.ApplicantPersonID= ApplicantPersonID;
            this.ApplicationDate= ApplicationDate;
            this.ApplicationStatus= ApplicationStatus;
            this.LastStatusDate= LastStatusDate;
            this.CreatedByUserID= CreatedByUserID;
            this.ApplicationsTypesID= ApplicationTypeID;
            this.PaidFees= PaidFees;
           Mode = enMode.Update;
        }

        

        private bool _AddNewApplicationsTypes()
        {
            //call DataAccess Layer 
            this.ApplicationsTypesID = clsApplicationsTypes.AddNewApplicationsTypes(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
              
        return (this.ApplicationsTypesID != -1);
        }
        private bool _UpdateApplicationsTypes()
        {
            //call DataAccess Layer 
            return clsApplicationsTypes.UpdateApplicationsTypes(
  this. ApplicantPersonID,   this.ApplicationDate,
              this.ApplicationStatus,
              this.LastStatusDate,     this.PaidFees,  this.CreatedByUserID);

 
        }
        public static  clsApplicationsTypes Find(int ApplicationsTypesID)
        {

             
            int ApplicantPersonID = 0;
            DateTime ApplicationDate = DateTime.Now;
            DateTime LastStatusDate = DateTime.Now;
            double PaidFees = 0;
            int ApplicationStatus = 0;
            int CreatedByUserID = 0;
            bool isfound = clsApplicationsTypes.GetApplicationsTypesByID(ref   ApplicantPersonID, ref   ApplicationDate,
       ref    ApplicationsTypesID, ref    ApplicationStatus, ref   LastStatusDate, ref  PaidFees, ref    CreatedByUserID);


            if (isfound)
                return new ApplicationsTypes( ApplicationsTypesID,ApplicantPersonID,ApplicationDate,
         ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID);
             
                return null;
        }
    


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationsTypes())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplicationsTypes();

            }




            return false;
        }
        public static DataTable GetAllApplicationsTypes()
        {
            return  clsApplicationsTypes.GetAllApplicationsTypes();

        }

        public static bool DeletetPerso(int ID)
        {
            return  clsApplicationsTypes.DeleteApplicationsTypes(ID);
        }

        public static bool isApplicationsTypesExsist(int ID)
        {
            return  clsApplicationsTypes.IsApplicationsTypesExsist(ID);
        }

    }

}

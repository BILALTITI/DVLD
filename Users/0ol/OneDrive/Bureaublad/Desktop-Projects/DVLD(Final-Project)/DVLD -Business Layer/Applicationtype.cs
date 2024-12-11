using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Accses_Layer;
using System.ComponentModel;
using Data_Accses__Layer;


namespace Presntation_Layet
{
    public class Applicationstype
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ApplicationTypeID { set; get; }
        public  Applications  ApplicationInfo { set; get; }

        public string ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }
       
        public Applicationstype()

        {
           this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = 0;
            Mode = enMode.AddNew;

        }

        private Applicationstype(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees
             )
        {

            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle= ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            this.ApplicationInfo = Applications.Find(this.ApplicationTypeID);

            Mode = enMode.Update;
        }
        private bool _AddNewApplicationstype()
        {
            //call DataAccess Layer 

            this.ApplicationTypeID = clsApplicationtypeData.AddNewApplicationstype(this.ApplicationTypeTitle,this. ApplicationFees);

            return (this.ApplicationTypeID != -1);
        }
        private bool _UpdateApplicationstype()
        {
            //call DataAccess Layer 

            return clsApplicationtypeData.UpdateApplicationstype( this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees) ;

        }
        public static Applicationstype Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = 0;

            bool isfound = clsApplicationtypeData.GetApplicationstypeByID(ApplicationTypeID,  ref ApplicationTypeTitle, ref  ApplicationFees);


            if (isfound)
                return new Applicationstype( ApplicationTypeID, ApplicationTypeTitle,  ApplicationFees
           );
            else
                return null;
        }
         


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationstype())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplicationstype();

            }




            return false;
        }
        public static DataTable GetAllApplicationtype()
        {
            return clsApplicationtypeData.GetAllApplicationstype();

        }

        public static bool DeleteApplicationtype(int ID)
        {
            return clsApplicationtypeData.DeleteApplicationstype(ID);
        }

        public static bool isApplicationtype(int ID)
        {
            return clsApplicationtypeData.IsApplicationstypeExsist(ID);
        }

    }

}

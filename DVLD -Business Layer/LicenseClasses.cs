using Data_Accses__Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Business_Layer
{
    public class LicenseClasses
    {

    public  int LicenseClassID { get; set; }
    public  string ClassName { get; set; }
    public  string ClassDescription { get; set; }
     public  int DriveMinimumAllowedAgerID { get; set; }
    public  int DefaultValidityLength { get; set; }
    public  decimal ClassFees { get; set; }
             public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public LicenseClasses()

        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.DriveMinimumAllowedAgerID = 18;
            this.DefaultValidityLength = 10;
             this.ClassFees = 0; 
            Mode = enMode.AddNew;

        }

        private LicenseClasses(int LicenseClassID, string ClassName,
     string ClassDescription, int DriveMinimumAllowedAgerID, int DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.DriveMinimumAllowedAgerID = DriveMinimumAllowedAgerID;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
             Mode = enMode.Update;
        }



        private bool _AddNewLicensessClasses()
        {
            //call DataAccess Layer 
            this.LicenseClassID = LicenseClassesData.AddNewLicensessClasses(this. ClassName,
     this. ClassDescription, this. DriveMinimumAllowedAgerID, this.DefaultValidityLength, this. ClassFees);

            return (this.LicenseClassID != -1);
        }
        private bool _UpdateLicensessClasses()
        {
            //call DataAccess Layer 
            return LicenseClassesData.UpdateLicensessClasses(this.LicenseClassID,this.ClassName,
     this.ClassDescription, this.DriveMinimumAllowedAgerID, this.DefaultValidityLength, this.ClassFees
             );


        }
        public static LicenseClasses Find(int LicenseClassID)
        {


            string ClassDescription = "";
            string ClassName = "";
            int DriveMinimumAllowedAgerID = 18;
            int DefaultValidityLength = 10;
            decimal ClassFees = 0;
             













            bool isfound = LicenseClassesData.GetLicensessLicenseClassesByID(LicenseClassID,ref ClassName,
    ref ClassDescription,ref DriveMinimumAllowedAgerID,ref DefaultValidityLength, ref ClassFees);


            if (isfound)
                return new LicenseClasses(LicenseClassID, ClassName,
     ClassDescription, DriveMinimumAllowedAgerID, DefaultValidityLength, ClassFees);

            return null;
        }

        public static LicenseClasses Find(string ClassName)
        {


            string ClassDescription = "";
            int LicenseClassID = -1;     
            int DriveMinimumAllowedAgerID = 18;
            int DefaultValidityLength = 10;
            decimal ClassFees = 0;














            bool isfound = LicenseClassesData.GetLicensessLicenseClassesByClassName(ClassName,ref LicenseClassID,   
    ref ClassDescription, ref DriveMinimumAllowedAgerID, ref DefaultValidityLength, ref ClassFees);


            if (isfound)
                return new LicenseClasses(LicenseClassID, ClassName,
     ClassDescription, DriveMinimumAllowedAgerID, DefaultValidityLength, ClassFees);

            return null;
        }



        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicensessClasses())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicensessClasses();

            }




            return false;
        }
        public static DataTable GetAlLLicenseClasses()
        {
            return LicenseClassesData.GetAllLicensess();

        }

        public static bool DeleteLicenseClasses(int ID)
        {
            return LicenseClassesData.DeleteLicensess(ID);
        }

        public static bool isLocalLicenseClassesExsist(int ID)
        {
            return LicenseClassesData.IsLicensessExsist(ID);
        }

    }

}

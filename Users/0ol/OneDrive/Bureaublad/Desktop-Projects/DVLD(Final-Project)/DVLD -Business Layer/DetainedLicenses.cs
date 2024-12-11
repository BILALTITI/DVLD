using Data_Accses__Layer;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Business_Layer
{
    public class DetainedLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DetainID { set; get; }

        public int LicenseID { set; get; }
        public decimal FineFees { set; get; }
        public DateTime DetainDate { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public int ReleaseApplicationID { set; get; }
        public DetainedLicenses()

        {
            this.DetainID = -1;
            this.LicenseID =  -1;
            this.FineFees = 0;
            this.DetainDate = DateTime.Now;
            this.ReleaseDate = DateTime.Now;
            this.ReleaseApplicationID = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleasedByUserID = -1;
  

            Mode = enMode.AddNew;

        }

        private DetainedLicenses(int DetainID ,
            int LicenseID ,
            decimal FineFees ,
           DateTime DetainDate ,
           DateTime ReleaseDate ,  
            int ReleaseApplicationID ,
            int CreatedByUserID ,
            bool IsReleased ,
            int ReleasedByUserID 
  
             )
        {

            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.FineFees = FineFees;
            this.DetainDate = DetainDate;
            this.ReleaseDate = ReleaseDate;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleasedByUserID = ReleasedByUserID;

            Mode = enMode.Update;
        }
        private bool _AddNewDetainedLicenses()
        {
            //call DataAccess Layer 

            this.DetainID = DetainedLicensesData.AddNewDetainedLicenses(
            this.LicenseID,
            this.FineFees,
           this.DetainDate,
           this.CreatedByUserID
          
           );

            return (this.DetainID != -1);
        }
        private bool _UpdateDetainedLicenses()
        {
            //call DataAccess Layer 

            return DetainedLicensesData.UpdateDetainedLicenses(this. DetainID,
            this.LicenseID,
            this.FineFees,
           this.DetainDate,
           this.ReleaseDate,
            this.ReleaseApplicationID,
            this.CreatedByUserID,
            this.IsReleased,
            this.ReleasedByUserID);

        }
        public static DetainedLicenses Find(int LicenseID)
        {
             decimal FineFees = 0;
            DateTime DetainDate = DateTime.MinValue;
            int DetainID = -1;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleaseApplicationID =-1;
            int CreatedByUserID = -1;
            bool IsReleased = false;

            int ReleasedByUserID = -1;

            bool isfound = DetainedLicensesData.GetDetainedLicensesInfoByLicenceID( LicenseID,
             ref DetainID,
             ref FineFees,
             ref DetainDate,
            ref ReleaseDate,
             ref ReleaseApplicationID,
             ref CreatedByUserID,
             ref IsReleased,
             ref ReleasedByUserID);


            if (isfound)
                return new DetainedLicenses(DetainID, LicenseID,
              FineFees,
             DetainDate,
             ReleaseDate,
              ReleaseApplicationID,
              CreatedByUserID,
              IsReleased,
              ReleasedByUserID
           );
            else
                return null;
        }



        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicenses())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetainedLicenses();

            }




            return false;
        }
        public static DataTable GetDetainedLicenses()
        {
            return DetainedLicensesData.GetAllDetainedLicenses();

        }

        public static bool DeleteDetainedLicenses(int ID)
        {
            return DetainedLicensesData.DeleteDetainedLicenses(ID);
        }

        public static bool isDetainedLicenses(int ID)
        {
            return DetainedLicensesData.IsDetainedLicensesExist(ID);
        }
        public  static  bool isDetained (int LicenseID)
        {
            return DetainedLicensesData.IsLicenseDetained(LicenseID);
        }

        public bool ReliseDetainLicence(int RelisedApplicationID,int CreatedByUserID)
        {
        return DetainedLicensesData.RelisedApplicationID(this.DetainID, RelisedApplicationID, CreatedByUserID);
        }
    }
}

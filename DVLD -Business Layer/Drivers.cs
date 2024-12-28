using Data_Accses__Layer;
using Data_Accses_Layer;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static DVLD__Business_Layer.InternationalLicenses;

using static License.License;

namespace DVLD__Business_Layer
{
    public class Drivers 
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
    public    int DriverID { get; set; }
       public int PersonID { get; set; }
      public clsPerson personinfo { set; get; }
      public  DateTime CreatedDate { get; set; }
       public int CreatedByUserID { get; set; }
        
        public Drivers()

        {
            this.DriverID = -1;
            this.PersonID = 0;
            this.CreatedDate = DateTime.Now;
             this.CreatedByUserID = 0;
         
            Mode = enMode.AddNew;

        }

        private Drivers(int DriverID, int PersonID, DateTime CreatedDate, int CreatedByUserID)
        {

            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedDate = CreatedDate;
             this.CreatedByUserID = CreatedByUserID;
            this.personinfo = clsPerson.Find(this.PersonID);

            Mode = enMode.Update;
        }



        private bool _AddNewDriverData()
        {
            //call DataAccess Layer 
            this.DriverID = DriversData.AddNewDriver(this.PersonID, this.CreatedDate, this.CreatedByUserID);

            return (this.DriverID != -1);
        }
        private bool _UpdateDriverData()
        {
            //call DataAccess Layer 
            return DriversData.UpdateDriver(
  this.DriverID, this.PersonID,
              this.CreatedDate,
              this.CreatedByUserID);
 
        }
        public static Drivers Find(int DriverID)
        {


            int PersonID = -1;
            DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = 0;
            bool isfound = DriversData.GetDriverInfoByID (  DriverID, ref  PersonID,
      ref   CreatedDate,ref   CreatedByUserID);


            if (isfound)
                return new Drivers(DriverID, PersonID, 
         CreatedDate, CreatedByUserID);

            return null;
        }

        public static Drivers FindbyPersonID(int PersonID)
        {


            int DriverID = -1;
            DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = 0;
            bool isfound = DriversData.GetDriverInfoByPersonID(PersonID,ref DriverID,
        ref CreatedDate,ref CreatedByUserID);


            if (isfound)
                return new Drivers(DriverID, PersonID,
         CreatedDate, CreatedByUserID);

            return null;
        }

        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return InternationalLicenses.GetInternationalLicenses(DriverID);
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
        public static DataTable GetAllDriverData()
        {
            return DriversData.GetAllDrivers();

        }

        public static bool DeletetPerso(int ID)
        {
            return DriversData.DeleteDriver(ID);
        }
        public static DataTable GetLicense(int DriverID)
        {

           return License.License.GetDriverLicenses(DriverID);
        }
        //public static DataTable GetInternationalLicense(int DriverID)
        //{
        //    return InternationalLicenses.GetActiveInternationalLicenceByDriverID2(DriverID);
        //}
        public static bool isDriverDataExsist(int ID)
        {
            return DriversData.IsDriverExist(ID);
        }

    }


}

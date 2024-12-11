using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Accses_Layer;
namespace Presntation_Layet
{
    internal class User : clsPerson
    {
    public int UserID { get; set; }
         public int PersonID { get; set; }
         public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public User()


        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            Mode = enMode.AddNew;

        }

        private User(enMode mode, int uerID,string userName, string password , bool isActive)
        {
           
         UserID = uerID;
            UserName = userName;
            Password = password;
            IsActive = isActive;

            mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            //call DataAccess Layer 

            this.UserID = clsUserData.AddNewUser (this.UserName,this.Password,this.IsActive,this.PersonID);

            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUserData.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive, this.PersonID);
        }
        public static clsUserData Find(int UserID)
        {

            UserID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;
            int PersonID = 0;
            
            if (clsUserData.GetUserByID( UserID,  UserName,  Password,  IsActive ,  PersonID ))

                return new clsUserData( UserName,Password,IsActive, PersonID);
            else
                return null;
        }


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }




            return false;
        }
        public static DataTable GetAllUser()
        {
            return clsUserData.GetAllUser();

        }

        public static bool DeletetUser(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }

        public static bool isUserExsist(int ID)
        {
            return clsUserData.IsUserExsist(ID);
        }

    }

}

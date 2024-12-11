using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data;
using System.Data.SqlClient;
using Data_Accses_Layer;

namespace Data_Accses_Layer
{

    public class clsUserData  
    {
        public int UserID;
        public int PersonID;
        public string UserName;
        public string Password;
        public bool IsActive;
        public clsUserData(int UserID,string UserName,string Password ,bool IsActive , int PersonID )
        {
            this.UserID=UserID;
       this.PersonID = PersonID;
          this.UserName = UserName;
          this.Password = Password;
       this.IsActive = IsActive;

          

  
        }

        public clsUserData( string username, string password, bool isActive, int personID)

        {
        this.UserName=username;
            this.Password=password;
            this.IsActive = isActive;
            this.PersonID=personID;
        }

        public static bool GetUserByID(int UserID, string UserName, string Password, bool isActive, int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    UserName =(string) reader["UserName"];
                     Password=(string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    isActive = (bool)reader["IscActive"];
                    
                }

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound = true;
        }
        public static bool GetUserByName(ref int UserID,ref string UserName,ref string Password,ref bool isActive,ref int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    isActive = (bool)reader["IscActive"];

                }

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound = true;
        }
        public static int AddNewUser(string UserName, string Password, bool isActive, int PersonID)
        {
            int UserID = -1;


            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"INSERT INTO Users ( UserName,Password,isActive,PersonID )
                             VALUES (@UserName,@Password,@isActive,@PersonID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@PersonID", PersonID);
        
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return UserID;


        }

        public static bool UpdateUser(int UserID , string UserName, string Password, bool isActive, int PersonID)

        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Update  Users  
                            set UserName = @UserName,
                                Password=@Password,
                                isActive=@isActive,
                                PersonID = @PersonID 
                             ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllUser()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Delete Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
        public static bool IsUserExsist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }



}

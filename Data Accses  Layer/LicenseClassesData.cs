using Data_Accses_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Accses__Layer
{
    public class LicenseClassesData
    {
        public static bool GetLicensessClassesByID(int LicenseClassID,   string ClassName,
     string ClassDescription, int DriveMinimumAllowedAgerID, int DefaultValidityLength, decimal ClassFees )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM  LicenseClasses WHERE  LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    DriveMinimumAllowedAgerID = (byte)reader["MinimumAllowedAge"];
                    ClassFees = (decimal)reader["ClassFees"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
 
                 
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
            return isFound ;
        }
        public static bool GetLicensessLicenseClassesByID(int LicenseClassID,ref string ClassName,
     ref string ClassDescription, ref int DriveMinimumAllowedAgerID, ref int DefaultValidityLength,ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM  LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    DriveMinimumAllowedAgerID = (byte)reader["MinimumAllowedAge"];
                    ClassFees = (decimal)reader["ClassFees"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];

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
            return isFound ;
        }
        public static bool GetLicensessLicenseClassesByClassName(string ClassName, ref int LicenseClassID,
ref string ClassDescription, ref int DriveMinimumAllowedAgerID, ref int DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM  LicenseClasses WHERE   ClassName=@ClassName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    LicenseClassID = (int)reader["LicenseClassID"];
                    //ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    DriveMinimumAllowedAgerID = (byte)reader["MinimumAllowedAge"];
                    ClassFees = (decimal)reader["ClassFees"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];

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
            return isFound ;
        }
        public static bool GetLicensessLicenseClassesByIDS(string LicenseClassID, ref string ClassName,
 ref string ClassDescription, ref int DriveMinimumAllowedAgerID, ref int DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM  LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    //LicenseClassID = (string)reader["LicenseClassID"];
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    DriveMinimumAllowedAgerID = (byte)reader["MinimumAllowedAge"];
                    ClassFees = (decimal)reader["ClassFees"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];

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
            return isFound ;
        }
        public static int AddNewLicensessClasses(    string ClassName,
     string ClassDescription, int DriveMinimumAllowedAgerID, int DefaultValidityLength, decimal ClassFees )
        {
            int LicenseClassID = -1;


            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"INSERT INTO  LicenseClasses (ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees)
                             VALUES (@ClassName,@ClassDescription,@DriveMinimumAllowedAgerID,@DefaultValidityLength,@ClassFees);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            //command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@DriveMinimumAllowedAgerID", DriveMinimumAllowedAgerID);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

      
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseClassID = insertedID;
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

            return LicenseClassID;


        }

        public static bool UpdateLicensessClasses(int LicenseClassID, string ClassName,
     string ClassDescription, int DriveMinimumAllowedAgerID, int DefaultValidityLength, decimal ClassFees)

        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Update   LicenseClasses  
                            set  ClassName = @ClassName,
                                  ClassDescription=@ClassDescription,
                                  DriveMinimumAllowedAgerID=@DriveMinimumAllowedAgerID,

                                 DriveMinimumAllowedAgerID=@DriveMinimumAllowedAgerID, 
                              DefaultValidityLength=@DefaultValidityLength,
                       ClassFees=@ClassFees,
                                    CreatedByUserID=@CreatedByUserID, 
                                where LicenseClassID=@LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@DriveMinimumAllowedAgerID", DriveMinimumAllowedAgerID);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);


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

        public static DataTable GetAllLicensess()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM  LicenseClasses Order by ClassName ";

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
        public static bool DeleteLicensess(int LicenseClassID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Delete  LicenseClasses 
                                where  LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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
        public static bool IsLicensessExsist(int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM  LicenseClasses WHERE  LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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
        public static bool IsLicensessExsistbyID(int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM  LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

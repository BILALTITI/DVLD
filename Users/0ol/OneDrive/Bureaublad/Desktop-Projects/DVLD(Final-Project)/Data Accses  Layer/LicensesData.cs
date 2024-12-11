using Data_Accses_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Data_Accses__Layer
{
    public class LicensesData
    {

        public static bool GetLicensessByID(  int LicenseID,   ref DateTime IssueDate,
       ref  int ApplicationID, ref  int DriverID, ref int LicenseClass, ref DateTime ExpirationDate,ref string Notes, ref  decimal PaidFees,ref bool IsActive,ref byte IssueReason,  ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM  Licensess WHERE  LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    Notes = (string)reader["Notes"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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
            return isFound;
        }
        public static bool GetLicensessLicenseByID(  int LicenseID,  ref  DateTime IssueDate,
      ref    int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime ExpirationDate,    ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM  Licenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                     IssueDate = (DateTime)reader["IssueDate"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    LicenseClass = (int)reader["LicenseClass"];
                    
                     if (reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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
        public static int AddNewLicensess(   DateTime IssueDate,
         int ApplicationID, int DriverID, int LicenseClass, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int  LicensessID = -1;


            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"INSERT INTO  Licenses (ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)
                             VALUES (@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);

            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                     LicensessID = insertedID;
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

            return  LicensessID;


        }

        public static bool UpdateLicensess(int LicenseID, DateTime IssueDate,
         int ApplicationID, int DriverID, int LicenseClass, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)

        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Update   Licenses  
                            set  LicenseID = @LicenseID,
                                  LicenseClass=@LicenseClass,
                                  IssueDate=@IssueDate,

                                 ApplicationID = @ApplicationID, 
                              DriverID=@DriverID,
                       PaidFees=@PaidFees,
                                    CreatedByUserID=@CreatedByUserID,
                                    Notes = @Notes, 
                              IsActive=@IsActive,
                       IssueReason=@IssueReason,
                                    CreatedByUserID=@CreatedByUserID,
                                where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
             command.Parameters.AddWithValue("@DriverID", DriverID);

            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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

            string query = "SELECT * FROM  Licenses";

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
        public static DataTable GetDriverLicenses(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"SELECT     
                           Licenses.LicenseID,
                           ApplicationID,
		                   LicenseClasses.ClassName, Licenses.IssueDate, 
		                   Licenses.ExpirationDate, Licenses.IsActive
                           FROM Licenses INNER JOIN
                                LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            where DriverID=@DriverID
                            Order By IsActive Desc, ExpirationDate Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

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
        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"SELECT        Licenses.LicenseID
                            FROM Licenses INNER JOIN
                                                     Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE  
                             
                             Licenses.LicenseClass = @LicenseClass 
                              AND Drivers.PersonID = @PersonID
                              And IsActive=1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
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


            return LicenseID;
        }
        public static DataTable GetLicencebyPersonID(int PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"SELECT  *
                            FROM Licenses INNER JOIN
                            Drivers ON Licenses.DriverID = Drivers.DriverID
                          WHERE Drivers.PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
                //Console.WriteLine("Error: " + ex.Message);
             }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        public static DataTable GetInternationalLicencebyPersonID(int PersonID)
        {
            DataTable dt2 = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"SELECT  *  FROM InternationalLicenses INNER JOIN
                            Drivers ON InternationalLicenses.DriverID = Drivers.DriverID
                          WHERE Drivers.PersonID= @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)

                {
                    dt2.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt2;
        }
        public static bool DeleteLicensess(int LicenseID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Delete  Licenses 
                                where  LicenseID = @ LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ LicenseID", LicenseID);

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
        public static bool IsLicensessExsist(int LicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM  Licenses WHERE  LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ LicenseID", LicenseID);

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
        public static bool IsLicensessExsistbyID(int LicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM  Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ LicenseID", LicenseID);

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
        public static int GetActiveLicenceByDriverID(int DriverID)
        {
            int ISActiveLicenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"SELECT top 1  LicenseID
                            FROM Licenses  
                          WHERE
                                 Drivers.DriverID = @DriverID
                              And IsActive=0; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ReturnedResult))
                {
                    ISActiveLicenseID = ReturnedResult;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                ISActiveLicenseID = -1;
            }
            finally
            {
                connection.Close();
            }

            return ISActiveLicenseID;
        }
        public static bool DeActiveLicence(int LicenseID)

        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Update   Licenses  
                            set   IsActive=0  
where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

          command.Parameters.AddWithValue("@LicenseID", LicenseID);
             
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
    }



}

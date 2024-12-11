using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data;
using System.Data.SqlClient;
using Data_Accses_Layer;

namespace Data_Accses_Layer
{

    public class clsApplicationsTypes
    {

        public static bool GetApplicationsTypesByID(ref int ApplicantPersonID  ,      ref       DateTime ApplicationDate,
       ref   int  ApplicationTypeID, ref int  ApplicationStatus  , ref DateTime LastStatusDate, ref  double PaidFees ,ref   int  CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM Applications WHERE ApplicationsTypesID = @ApplicationsTypesID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationsTypesID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (int)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (double)reader["PaidFees"];
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
            return isFound = true;
        }
        public static bool GetApplicationsTypesByPersonID(  int ApplicantPersonID, ref DateTime ApplicationDate,
      ref    int ApplicationTypeID, int ApplicationStatus, ref DateTime LastStatusDate, ref double PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (int)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (double)reader["PaidFees"];
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
            return isFound = true;
        }
        public static int AddNewApplicationsTypes(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationStatus, DateTime LastStatusDate, double PaidFees, int CreatedByUserID)
        {
            int ApplicationsTypesID = -1;


            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"INSERT INTO Applications (ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                             VALUES (@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
             command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
       
 
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationsTypesID = insertedID;
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

            return ApplicationsTypesID;


        }

        public static bool UpdateApplicationsTypes (  int ApplicantPersonID,   DateTime ApplicationDate,
     int ApplicationStatus,
              DateTime LastStatusDate,  double PaidFees,  int CreatedByUserID)

        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Update  Applications  
                            set ApplicationsTypesID = @ApplicationsTypesID,
                                ApplicantPersonID=@ApplicantPersonID,
                                ApplicationDate=@ApplicationDate,
                                ApplicationStatus = @ApplicationStatus, 
                              LastStatusDate=@LastStatusDate,
                       PaidFees=PaidFees,
                                    CreatedByUserID=@CreatedByUserID,
                              
                                where ApplicantPersonID = @ApplicantPersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
      
              
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

        public static DataTable GetAllApplicationsTypes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM Applications";

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
        public static bool DeleteApplicationsTypes(int ApplicationsTypesID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Delete Applications 
                                where ApplicationsTypesID = @ApplicationsTypesID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationsTypesID", ApplicationsTypesID);

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
        public static bool IsApplicationsTypesExsist(int ApplicationTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM Applications WHERE ApplicationsTypesID = @ApplicationsTypesID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationsTypesID", ApplicationTypeID);

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
        public static bool IsApplicationsTypesExsistbyID(int ApplicantPersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationsTypesID", ApplicantPersonID);

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

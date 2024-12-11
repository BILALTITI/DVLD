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
    public class clsApplicationtypeData
    {


        public static bool GetApplicationstypeByID(int ApplicationTypeID,ref string ApplicationTypeTitle,ref decimal ApplicationFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
                    
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
       
        public static int AddNewApplicationstype( string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int ApplicationsTypesID = -1;


            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"INSERT INTO ApplicationTypes (ApplicationTypeTitle,ApplicationFees,ApplicationTypeID)
                             VALUES (@ApplicationTypeTitle,@ApplicationFees,@ApplicationTypeID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationsTypesID", ApplicationsTypesID);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
         

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

        public static bool UpdateApplicationstype(  int ApplicationTypeID,  string ApplicationTypeTitle,   decimal ApplicationFees)

        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Update  ApplicationTypes  
                            set 
                                ApplicationTypeTitle=@ApplicationTypeTitle,
                                ApplicationFees=@ApplicationFees
                      
                              
                                where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            

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

        public static DataTable GetAllApplicationstype()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes order by ApplicationTypeTitle ";

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
        public static bool DeleteApplicationstype(int ApplicationsTypeID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Delete ApplicationTypes 
                                where ApplicationsTypeID = @ApplicationsTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationsTypeID", ApplicationsTypeID);

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
        public static bool IsApplicationstypeExsist(int ApplicationTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM ApplicationTypes WHERE ApplicationsTypeID = @ApplicationsTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationsTypeID", ApplicationTypeID);

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


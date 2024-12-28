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
    public class DetainedLicensesData
    {


        public static bool GetDetainedLicensesInfoByID(int DetainID,
          ref  int LicenseID,
           ref decimal FineFees,
          ref DateTime DetainDate,
           ref DateTime ReleaseDate,
            ref int ReleaseApplicationID,
            ref int CreatedByUserID,
            ref bool IsReleased,
            ref int ReleasedByUserID
                                      )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    DetainID = (int)reader["DetainID"];

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    FineFees = (decimal)reader["FineFees"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

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

        public static bool GetDetainedLicensesInfoByLicenceID(int LicenseID,
       ref int DetainID,
        ref decimal FineFees,
       ref DateTime DetainDate,
        ref DateTime ReleaseDate,
         ref int ReleaseApplicationID,
         ref int CreatedByUserID,
         ref bool IsReleased,
         ref int ReleasedByUserID
                                   )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT top 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID order by DetainID desc"; 

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    DetainID = (int)reader["DetainID"];

                     DetainDate = (DateTime)reader["DetainDate"];
  
                    CreatedByUserID = (int)reader["CreatedByUserID"];
          
                     FineFees = (decimal)reader["FineFees"];
                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] == DBNull.Value)

                        ReleaseDate = DateTime.MaxValue;
                    else
                        ReleaseDate = (DateTime)reader["ReleaseDate"];


                    if (reader["ReleasedByUserID"] == DBNull.Value)

                        ReleasedByUserID = -1;
                    else
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    if (reader["ReleaseApplicationID"] == DBNull.Value)

                        ReleaseApplicationID = -1;
                    else
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];



                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

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




        public static int AddNewDetainedLicenses(
            int LicenseID,
            decimal FineFees,
           DateTime DetainDate,
            int CreatedByUserID
          )
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int DetainedLicensesID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased)
                             VALUES (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,0);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);




            command.Parameters.AddWithValue("@LicenseID",LicenseID);


 
            command.Parameters.AddWithValue("@FineFees",FineFees);


            command.Parameters.AddWithValue("@DetainDate",DetainDate);


 
            command.Parameters.AddWithValue("@CreatedByUserID",CreatedByUserID);

        



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainedLicensesID = insertedID;
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


            return DetainedLicensesID;
        }

        public static bool UpdateDetainedLicenses(int DetainID,
            int LicenseID,
            decimal FineFees,
           DateTime DetainDate,
           DateTime ReleaseDate,
            int ReleaseApplicationID,
            int CreatedByUserID,
            bool IsReleased,
            int ReleasedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Update  DetainedLicenses  
                            set
                                 LicenseID=@LicenseID,
                                   FineFees=@FineFees

                                DetainDate=@DetainDate,
                                   ReleaseDate=@ReleaseDate
                                ReleaseApplicationID=@ReleaseApplicationID,
                                   CreatedByUserID=@CreatedByUserID

                                IsReleased=@IsReleased,
                                   ReleasedByUserID=@ReleasedByUserID
                                where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

            command.Parameters.AddWithValue("@IsReleased", IsReleased);


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

        public static DataTable GetAllDetainedLicenses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses_View order  by IsReleased ,DetainID";

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

        public static bool DeleteDetainedLicenses(int DetainID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Delete DetainedLicenses
                                where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

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

        public static bool IsDetainedLicensesExist(int DetainID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"select IsDetained=1 
                            from detainedLicenses 
                            where 
                            LicenseID=@LicenseID 
                            and IsReleased=0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsDetained = Convert.ToBoolean(result);
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


            return IsDetained;
            ;

        }
        public static bool RelisedApplicationID(int DetainID, int ReleaseApplicationID , int ReleasedByUserID)
        {

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            int rowsAffected = 0;
 
            string query = @"Update  DetainedLicenses  
                            SET 
 
                                   ReleaseDate=@ReleaseDate,
                                ReleaseApplicationID=@ReleaseApplicationID,
                                   IsReleased=1,
                                   ReleasedByUserID=@ReleasedByUserID
                                where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);
             command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);


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
            ;

        }



    }
}

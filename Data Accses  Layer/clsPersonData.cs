using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data;
using System.Data.SqlClient;
using Data_Accses_Layer;

namespace Data_Accses_Layer
{

    public class clsPersonData
    {

        public static bool GetPersonByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName
            , ref string ThirdName, ref string LastName, ref string Email, ref string Phone
            , ref byte Gender, ref string Address, ref int nationalitycountryID, ref DateTime DateOfbirth, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    NationalNo = (string)reader["NationalNo"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfbirth = (DateTime)reader["DateOfBirth"];
                    nationalitycountryID = (int)reader["NationalitycountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                    if (reader["Email"]!=DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";

                    }
                    if (reader["Gendor"] != DBNull.Value)
                    {
                       Gender = (byte)reader["Gendor"];
                    }
                    else
                    {
                        Gender = 99;

                    }
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";

                    }
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
        public static bool GetPersonByNationalNo(string NationalNo, ref int PersonID,   ref string FirstName, ref string SecondName
        , ref string ThirdName, ref string LastName, ref string Email, ref string Phone
        , ref byte Gender, ref string Address, ref int nationalitycountryID, ref DateTime DateOfbirth, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];   
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfbirth = (DateTime)reader["DateOfBirth"];
                    nationalitycountryID = (int)reader["NationalitycountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
           
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";

                    }
                    if (reader["Gendor"] != DBNull.Value)
                    {
                        Gender = (byte)reader["Gendor"];
                    }
                    else
                    {
                        Gender = 99;

                    }
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";

                    }
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
        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, string Email,
            string Phone, byte Gender, string Address, int NationalityCountryID, DateTime DateOfBirth, string ImagePath)
        {
            int PersonID = -1;


            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);
/////////////////////////////////////////////////////////////////////////////////////////////////////////
            string query = @"INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName, LastName, DateOfBirth,Gendor,Address,  Phone,Email,NationalitycountryID,ImagePath)
                             VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName, @DateOfBirth, @Gendor, @Address,@Phone,@Email,@NationalitycountryID,@ImagePath);
                             SELECT SCOPE_IDENTITY();";
            ///////////////////////////////////////////////////////////////////////////////////////////////
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@NationalitycountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);




            if (ThirdName != "" )
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            if (Gender != 99)
                command.Parameters.AddWithValue("@Gendor", Gender);
            else
                command.Parameters.AddWithValue("@Gendor", System.DBNull.Value);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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

            return PersonID;


        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName
           , string ThirdName, string LastName, string Email, string Phone
           , byte Gender, string Address, int nationalitycountryID, DateTime DateOfbirth, string ImagePath)

        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);
            //////////////////////////////////////////////////////
            string query = @"Update  People  
                            set NationalNo=@NationalNo,

                              FirstName = @FirstName,
                                SecondName=@SecondName,
                                ThirdName=@ThirdName,
                                LastName = @LastName, 
                                 DateOfBirth = @DateOfBirth,
                                    Gendor=@Gendor,
                                Address = @Address, 
                                 Phone = @Phone, 
                                 Email = @Email, 
                                 NationalitycountryID=@NationalitycountryID,
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";
            //////////////////////////////////////////////////////
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@NationalitycountryID", nationalitycountryID);
            command.Parameters.AddWithValue("@LastName", LastName);
            //command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfbirth);
             command.Parameters.AddWithValue("@PersonID", PersonID);

/////////////////////////////////////////////////////////////////
            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            if (Email!="")
                command.Parameters.AddWithValue("@Email", Email);
else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            if (Gender!= 99)
                command.Parameters.AddWithValue("@Gendor", Gender);
else
                command.Parameters.AddWithValue("@Gendor", System.DBNull.Value);

            ///////////////////////////////////////////////////////////////////////

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

        public static DataTable GetAllPerson()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query =   @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";

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
        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = @"Delete People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static bool IsPersonExsist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

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
        public static bool IsPersonExsist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccsesSetting.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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

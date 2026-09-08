using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_DataAccessLayer
{
    public class clsPatientData
    {
        public static int AddNewPatient(string firstName, string lastName, string gender, DateTime dateOfBirth,
            string phone, string email, string address, string allergies)
        {
            int patientID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewPatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@phone", phone);
                    if (email != null && email != "")
                    {
                        command.Parameters.AddWithValue("@email", email);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@email", System.DBNull.Value);

                    }
                    if (address != null && address != "")
                    {
                        command.Parameters.AddWithValue("@address", address);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@address", System.DBNull.Value);

                    }
                    if (allergies != "" && allergies != null)
                    {
                        command.Parameters.AddWithValue("@allergies", allergies);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@allergies", System.DBNull.Value);

                    }
                    try
                    {
                        connection.Open();
                        Object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            patientID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error : " + ex.Message);

                    }

                }
            }
            return patientID;
        }

        public static bool UpdatePatient(int patientID, string firstName, string lastName, string gender, DateTime dateOfBirth,
                    string phone,string email,string address, string allergies, DateTime createdAt)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatePatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@patientID", patientID);

                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

                    command.Parameters.AddWithValue("@phone", phone);
                    if (email != null && email != "")
                    {
                        command.Parameters.AddWithValue("@email", email);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@email", System.DBNull.Value);

                    }
                    if (address != null && address != "")
                    {
                        command.Parameters.AddWithValue("@address", address);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@address", System.DBNull.Value);

                    }
                    if (allergies != "" && allergies != null)
                    {
                        command.Parameters.AddWithValue("@allergies", allergies);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@allergies", System.DBNull.Value);

                    }
                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error updating patient :" + ex.Message);
                    }
                }
            }
            return (rowIffected > 0);
        }

        public static bool DeletePatient (int patientID)
            {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("HardDeletePatient", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@patientID", patientID);
                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error deleting patient :" + ex.Message);
                    }
                    
                }
            }
            return (rowIffected > 0);

        }

        public static DataTable GetAllPatient()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllPatientProf", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
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
                        throw new Exception("Error get all data: " + ex.Message);
                    }
                 
                }
            }
            return dt;

        }

        public static bool GetInfoPatientByID(int id, ref string firstName, ref string lastName, ref string gender, ref DateTime dateOfBirth,
                 ref string phone, ref string email, ref string address, ref string allergies, ref DateTime createdAt)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInfoPatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@patientID", id);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            firstName = (string)reader["firstName"];
                            lastName = (string)reader["lastName"];
                            gender = (string)reader["Gender"];

                            dateOfBirth = (DateTime)reader["DateOfBirth"];

                            phone = (string)reader["phone"];
                            email = (string)reader["email"];
                            address = (string)reader["Address"];
                            allergies = (string)reader["Allergies"];
                            createdAt = (DateTime)reader["createdAt"];
                        }

                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                        throw new Exception("error" + ex.Message);

                    }
                }
            }
            return isFound;
        }

        public static bool GetInfoPatientByName( string firstName,ref int id, ref string lastName, ref string gender, ref DateTime dateOfBirth,
                ref string phone, ref string email, ref string address, ref string allergies, ref DateTime createdAt)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInfoPatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@patientName", firstName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            id = (int)reader["PatientID"];
                            lastName = (string)reader["lastName"];
                            gender = (string)reader["Gender"];
                            dateOfBirth = (DateTime)reader["DateOfBirth"];
                            phone = (string)reader["phone"];
                            email = (string)reader["email"];
                            address = (string)reader["Address"];
                            allergies = (string)reader["Allergies"];
                            createdAt = (DateTime)reader["createdAt"];
                        }

                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                        throw new Exception("error" + ex.Message);

                    }
                }
            }
            return isFound;
        }

        public static bool IsPatientExist(int patientID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = "select dbo.isPatientExist(@patientID) )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@patientID", patientID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);

                        isFound = false;
                    }
                   
                }
            }
            return isFound;
        }
        public static  int Totalpatients()
        {
            int number = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select dbo.totalPatients()";
                using (SqlCommand command =new SqlCommand(query,conn))
                {
                    try
                    {
                        conn.Open();
                        object result = command.ExecuteScalar();
                        if(result!=null&&int.TryParse(result.ToString(),out int newResult))
                        {
                            number = newResult;
                        }
                    }catch(Exception ex)
                    {
                        throw new Exception("error" + ex.Message);
                    }
                }
            }
            return number;
        }

    }
}

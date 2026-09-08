using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DentalClinic_DataAccessLayer
{
    public class ClsSpecializationsData
    {
        public static int AddNewSpecialzation(string specializationName)
        {
            int specID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewSpecialization", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@specName", specializationName);
                 


                    try
                    {
                        connection.Open();
                        Object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            specID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error : " + ex.Message);
                    }

                }
            }
            return specID;
        }
        public static bool UpdateSpecialization(int id,string specializationName)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_updateSpecialization", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SPECID", id);
                    command.Parameters.AddWithValue("@specName", specializationName);

                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error:" + ex.Message);
                    }
                }
            }
            return (rowIffected > 0);
        }
        public static bool DeleteSpecialization(int specID)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteSpecialization", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@specID", specID);
                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error:" + ex.Message);
                    }

                }
            }
            return (rowIffected > 0);

        }
        public static DataTable GetAllsSpecialization()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllSpecialization", connection))
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
                        throw new Exception("Error: " + ex.Message);
                    }

                }
            }
            return dt;

        }
        public static bool GetInfoSpecializationByID(int ID, ref string specializationName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInfoSpecialization", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SpecID", ID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            specializationName = (string)reader["specializationName"];
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

        public static bool GetInfoSpecializationByName( string specializationName,ref int ID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInfoSpecialization", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SpecName", specializationName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            ID = (int)reader["specializationID"];
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



    }
}

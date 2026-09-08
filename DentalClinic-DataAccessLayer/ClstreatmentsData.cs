using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_DataAccessLayer
{
    public class ClstreatmentsData
    {
        public static int AddNewTreatment(string TreatmentName,string description,decimal price )
        {
            int TreatmentID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewTreatment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TreatmentName", TreatmentName);
                    if (description != null && description != "")
                    {
                        command.Parameters.AddWithValue("@Description", description);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Description", System.DBNull.Value);

                    }

                    command.Parameters.AddWithValue("@price", price);
                    try
                    {
                        connection.Open();
                        Object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TreatmentID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error : " + ex.Message);
                    }

                }
            }
            return TreatmentID;
        }
        public static bool UpdateTreatment(int TreatmentID, string TreatmentName, string description, decimal? price)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_updateTreatment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (TreatmentName != null && TreatmentName != "")
                    {

                        command.Parameters.AddWithValue("@treatmentName", TreatmentName);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@treatmentName", System.DBNull.Value);

                    }
                    if (description != null && description != "")
                    {

                        command.Parameters.AddWithValue("@Description", description);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Description", System.DBNull.Value);

                    }
                    if (price.HasValue)
                    {
                        command.Parameters.AddWithValue("@price",price);

                    }
                    else
                    {
                        command.Parameters.AddWithValue("@price", System.DBNull.Value);

                    }
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
        public static bool DeleteTreatmenrt(int TreatmentID)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteTreatment", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@treatmentID", TreatmentID);
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
        public static DataTable GetAllTreatment()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllTreatments", connection))
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
        public static bool GetInfoTreatmantByID(int id,ref string TreatmentName,ref string description,ref decimal price)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInfoTreatments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@treatmentID", id);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            TreatmentName = (string)reader["TreatmentName"];
                            description = (string)reader["Description"];
                            price = (Decimal)reader["price"];
                            
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

        public static bool GetInfoTreatmantByName( string TreatmentName,ref int id, ref string description,ref decimal price)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInfoTreatments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TreatmentName", TreatmentName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            id = (int)reader["treatmentID"];
                            description = (string)reader["Description"];
                            price = (Decimal)reader["price"];

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

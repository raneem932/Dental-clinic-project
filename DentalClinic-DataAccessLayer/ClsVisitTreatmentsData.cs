using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_DataAccessLayer
{
    public class ClsVisitTreatmentsData
    {
        public static int AddNewVisitTreatment(int visitID,int treatmentID,Decimal Cost, string notes)
        {
            int VisitTreatmentID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewVisitTreatment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@visitID", visitID);
                    command.Parameters.AddWithValue("@TreatmentID", treatmentID);
                    command.Parameters.AddWithValue("@cost", Cost);

                    if (notes != null && notes != "")
                    {
                        command.Parameters.AddWithValue("@notes", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@notes", System.DBNull.Value);

                    }

                  
                    try
                    {
                        connection.Open();
                        Object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            VisitTreatmentID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error : " + ex.Message);
                    }

                }
            }
            return VisitTreatmentID;
        }
        public static bool UpdateVisitTreatment(int VisitTreatmentID,int? visitID, int? treatmentID, Decimal? Cost, string notes)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateVisitTreatment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@visitTreatmentID", VisitTreatmentID);
                    if (visitID.HasValue)
                    {
                        command.Parameters.AddWithValue("@visitID", visitID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@visitID", System.DBNull.Value);

                    }
                    if (treatmentID.HasValue)
                    {
                        command.Parameters.AddWithValue("@TreatmentID", treatmentID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@TreatmentID", System.DBNull.Value);

                    }

                    if (Cost.HasValue)
                    {
                        command.Parameters.AddWithValue("@cost", Cost);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@cost", System.DBNull.Value);

                    }
           

                    if (notes != null && notes != "")
                    {
                        command.Parameters.AddWithValue("@notes", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@notes", System.DBNull.Value);

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
        public static bool DeleteVisitTreatmenrt(int VisitTreatmentID)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteVisitTreatment", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@visitTreatmentID", VisitTreatmentID);
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
        public static DataTable GetAllVisitTreatment(int? treatmentID,int? visitID)
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetVisitTreatments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (treatmentID.HasValue)
                    {

                        command.Parameters.AddWithValue("@treatmentID", treatmentID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@treatmentID", System.DBNull.Value);

                    }
                    if (visitID.HasValue)
                    {

                        command.Parameters.AddWithValue("@visitID", visitID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@visitID", System.DBNull.Value);

                    }
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

        public static DataTable GetAllVisitsWithTreatments()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getAllVisitsWithTreatments", connection))
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

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_DataAccessLayer
{
    public class ClsVisitData
    {
        public static int AddNewVisit(int patientID, int DentistID,int? appointmentID , string diagnosis, string notes)
        {
            int VisitID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewVisit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@patientID", patientID);
                    command.Parameters.AddWithValue("@DentistID", DentistID);
                    if (appointmentID.HasValue)
                    {
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@AppointmentID", System.DBNull.Value);

                    }
                    if (notes != null && notes != "")
                    {
                        command.Parameters.AddWithValue("@notes", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@notes", System.DBNull.Value);
                    }
                    if (diagnosis != null && diagnosis != "")
                    {
                        command.Parameters.AddWithValue("@Diagosis", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Diagosis", System.DBNull.Value);
                    }
          
                    try
                    {
                        connection.Open();
                        Object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            appointmentID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error : " + ex.Message);
                    }

                }
            }
            return VisitID;
        }

        public static bool UpdateVisit(int visitID, int patientID, int DentistID, int? appointmentID, string diagnosis, string notes)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateVisit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@visitID", patientID);

                    command.Parameters.AddWithValue("@patientID", patientID);
                    command.Parameters.AddWithValue("@DentistID", DentistID);
                    if (appointmentID.HasValue)
                    {
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@AppointmentID", System.DBNull.Value);

                    }
                    if (notes != null && notes != "")
                    {
                        command.Parameters.AddWithValue("@notes", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@notes", System.DBNull.Value);
                    }
                    if (diagnosis != null && diagnosis != "")
                    {
                        command.Parameters.AddWithValue("@Diagosis", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Diagosis", System.DBNull.Value);
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
        public static bool HardDeleteVisit(int VisitID)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteVisit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@visitID", VisitID);
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
        public static DataTable GetAllVisitsWithFilterAndPatientSearch(int? patientID,int? dentiestID,DateTime? visitDate,string search)
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllVisitsWithFilterAndPatientSearch", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (patientID.HasValue)
                    {
                        command.Parameters.AddWithValue("@patientID", patientID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@patientID", System.DBNull.Value);

                    }
                    if (dentiestID.HasValue)
                    {
                        command.Parameters.AddWithValue("@DentistID", dentiestID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@DentistID", System.DBNull.Value);

                    }
                    if (visitDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@VisitDate", patientID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@VisitDate", System.DBNull.Value);

                    }
                    if (search != null && search != "")
                    {
                        command.Parameters.AddWithValue("@search", search);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@search", System.DBNull.Value);

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
                        throw new Exception("Error get data: " + ex.Message);
                    }

                }
            }
            return dt;
        }
        public static DataTable GetAllVisits()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllVisits", connection))
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
                        throw new Exception("Error get data: " + ex.Message);
                    }

                }
            }
            return dt;
        }

        public static bool IsVisitExist(int VisitID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = "select 1 from visits where visitID=@visitid";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@visitid", VisitID);

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
        public static bool GetInfoVisitByID(int ID,ref int patientID,ref int dentiestID,ref int? appointmentID,ref DateTime visitDate, ref String diagnosis,ref string notes)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getVisitInfobyID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", ID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            patientID = (int)reader["PatientID"];
                            dentiestID = (int)reader["DentistID"];
                             visitDate = (DateTime)reader["visitDate"];
                            appointmentID = reader["AppointmentID"] == DBNull.Value ? null : (int?)reader["AppointmentID"];

                            diagnosis = (string)reader["Diagnosis"];
                            notes = (string)reader["notes"];
                    
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

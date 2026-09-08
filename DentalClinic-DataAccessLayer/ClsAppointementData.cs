using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_DataAccessLayer
{
    public class ClsAppointementData
    {
        public static int AddNewAppointment(int patientID, int DentistID, DateTime AppointmentDate, string status, string notes, TimeSpan startTime,
            TimeSpan EndTime)
        {
            int appointmentID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@patientID", patientID);
                    command.Parameters.AddWithValue("@DentistID", DentistID);
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@status", status);

                    if (notes != null && notes != "")
                    {
                        command.Parameters.AddWithValue("@notes", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@notes", System.DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@startTime", startTime);


                    command.Parameters.AddWithValue("@endTime", EndTime);
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
            return appointmentID;
        }
        public static bool UpdateAppointment(int AppointmentID, int patientID, int DentistID, DateTime AppointmentDate, string status, string notes, TimeSpan startTime,
            TimeSpan EndTime)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateAppointments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    command.Parameters.AddWithValue("@PatientID", patientID);
                    command.Parameters.AddWithValue("@DentistID", DentistID);
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@Status", status);

                    if (notes != null && notes != "")
                    {
                        command.Parameters.AddWithValue("@Notes", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@startTime", startTime);


                    command.Parameters.AddWithValue("@endTime", EndTime);

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
        public static bool SOFTDeleteApointment(int AppointmentID)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteAppointment", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
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
        public static bool IsAppointmentExist(int AppointmentID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = "select 1 from AppointmentTB where AppointmentID=@AppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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
        public static DataTable GetAllAppointments()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllAppointmentfiltered", connection))
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
        public static DataTable GetAllTodayAppointments()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getTodayAppointments", connection))
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
        public static DataTable GetAllApppointmentsThisMonth()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getAppointmentsthisMonth", connection))
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
        public static DataTable GetAllAppointmentsThisYear()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getAppointmentsthisYear", connection))
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
        public static DataTable GetAllAppointmentsInSpecificDate(DateTime date)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getAppointmentsInSpecificDate", connection))
                   
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@date", date);
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
        public static bool GetInfoAppointmentByID(int Appointmentid, ref int patientID, ref int DentistID, ref DateTime AppointmentDate, ref string status, ref string notes, ref TimeSpan startTime,
          ref TimeSpan EndTime, ref DateTime createdAt)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getInfoAppointmentByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", Appointmentid);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            patientID = (int)reader["PatientID"];
                            DentistID = (int)reader["DentistID"];
                            AppointmentDate = (DateTime)reader["AppointmentDate"];
                            status = (string)reader["Status"];
                            notes = (string)reader["notes"];
                            startTime = (TimeSpan)reader["startTime"];
                            EndTime = (TimeSpan)reader["endTime"];
                            createdAt = (DateTime)reader["CreatedAt"];
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

        public static int NumberOfTodaysAppointment()
        {
            int number = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select dbo.GetNumberOfAppointmentsToday()";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if(result!=null&& int.TryParse(result.ToString(),out int Newnumber))
                        {
                            number = Newnumber;
                        }
                    }
                    catch(Exception ex) 
                    {
                        throw new Exception  ("error" + ex.Message);
                    }
                }

            }
            return number;
        }
        public static bool isAppointmentDateAndtimeBooked(DateTime appointmentDate,TimeSpan startTime,TimeSpan endTime,int DentistID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

              

                using (SqlCommand command = new SqlCommand("sp_isAppointmentDateAndtimeBooked", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    command.Parameters.AddWithValue("@startTime", startTime);
                    command.Parameters.AddWithValue("@endTime", endTime);
                    command.Parameters.AddWithValue("@DentistID", DentistID);

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
           

        
    }
}

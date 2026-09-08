using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_DataAccessLayer
{
    public class ClsDentistData
    {
        public static int AddNewDentist(string firstName,string lastName,string phone,string email,DateTime? hireDate,string status,int? specializationID)
        {
            int newID=-1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewDentist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);

                    command.Parameters.AddWithValue("@specializationID", specializationID);
                    command.Parameters.AddWithValue("@phone", phone);
                    if (email != null && email != "")
                    {
                        command.Parameters.AddWithValue("@email ", email);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@email ", System.DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@hiredate", hireDate);
                    command.Parameters.AddWithValue("@status", status);
                    try
                    {
                        connection.Open();

                        Object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error adding dentist" + ex.Message);
                    }
                }
            }
            return newID;
        }

        public static bool updateDentist(int dentistID, string firstName, string lastName, string phone, string email, DateTime? hireDate, string status, int? specializationID)
        {
            int rowIffected = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateDentist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DentistID", dentistID);
                    if (firstName != "")
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@firstName", System.DBNull.Value);
                    }
                    if (lastName != "")
                    {
                        command.Parameters.AddWithValue("@lastName", lastName);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@lastName", System.DBNull.Value);
                    }
                    if (phone != "")
                    {
                        command.Parameters.AddWithValue("@phone", phone);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@phone", System.DBNull.Value);
                    }
                    if (email != "")
                    {
                        command.Parameters.AddWithValue("@email", email);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@email", System.DBNull.Value);
                    }
                    if (hireDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@hiredate", hireDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@hiredate", System.DBNull.Value);
                    }
                    if (status != "")
                    {
                        command.Parameters.AddWithValue("@status", status);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@status", System.DBNull.Value);
                    }
                    if (specializationID.HasValue)
                    {
                        command.Parameters.AddWithValue("@specializationid", specializationID);

                    }
                    else
                    {
                        command.Parameters.AddWithValue("@specializationid", System.DBNull.Value);
                    }
                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();
                    }
                    catch(Exception ex) { throw new Exception("error update dentist" + ex.Message); }
                }
            }
            return (rowIffected > 0);
        }
        public static bool DeleteDentist(int id)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"delete from Dentist where DentistID=@dentistid;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dentistid", id);
                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { throw new Exception("Error deleting dentist" + ex.Message); }
                }
            }
                    return (rowIffected > 0);
                
            
        }
        public static DataTable GetAllDentists()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllDentists", connection))
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
                return dt;
            
            }
        }
        public static DataTable GetAllDentistswithStatus(string status,int specializationID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllDentistswithFilter", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@specializationID", specializationID);


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
                return dt;

            }
        }
      
        public static bool GetInfoDentistByID(int dentistID,ref string firstName,ref string lastName,ref string phone,ref string email,ref DateTime hireDate,ref string status,ref int specializationID)
        {
            bool isFound = false;
         
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getDentistInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id",dentistID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            firstName = (string)reader["firstName"];
                            lastName = (string)reader["lastName"];
                            specializationID =  (int)reader["specializationID"];
                            hireDate =  (DateTime)reader["HirDate"];

                            phone = (string)reader["phone"];
                            if (reader["email"] != "" && reader["email"] != null)
                            {
                                email = (string)reader["email"];
                            }
                            else
                            {
                                email = "";
                            }
                                status = (string)reader["status"];
                         
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

        public static bool GetInfoDentistByName( string firstName,ref int dentistID, ref string lastName, ref string phone, ref string email, ref DateTime hireDate, ref string status, ref int specializationID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getDentistInfoByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", firstName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            dentistID = (int)reader["DentistID"];
                            lastName = (string)reader["lastName"];
                            specializationID = (int)reader["specializationID"];
                            hireDate = (DateTime)reader["HirDate"];
                            phone = (string)reader["phone"];
                            email = (string)reader["email"];
                            status = (string)reader["status"];

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
        public static bool IsDentistExist(int DentistID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = "select [dbo].[CheckDentistExists] )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_DataAccessLayer
{
    public class ClsUsersData
    {
        public static int AddNewUser(string userName,string password,int roleID,int? DentistID,bool isActive)
        {
            int userID = -1;
     
            using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command=new SqlCommand("sp_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@roleID", roleID);
                    if (DentistID.HasValue)
                    {
                        command.Parameters.AddWithValue("@DentistID", DentistID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@DentistID", System.DBNull.Value);

                    }
                    command.Parameters.AddWithValue("@isActive", isActive);
                    try
                    {
                        connection.Open();

                        Object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            userID = insertedID;
                        }

                    }
                    catch(Exception ex)
                    {
                        throw new Exception("error adding data " + ex.Message);
                    }
                }
            }
            return userID;
        }
        public static bool UdpateUser(int userid, string userName, string password, int roleID, int? DentistID, bool isActive)
        {
            int rowEffected = -1;
            using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_updeteUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userid);
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@roleID", roleID);
                    if (DentistID.HasValue)
                    {
                        command.Parameters.AddWithValue("@DentistID", DentistID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@DentistID", System.DBNull.Value);

                    }
                    command.Parameters.AddWithValue("@isActive", isActive);
                    try
                    {
                        connection.Open();
                        rowEffected = command.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    { 
                        throw new Exception("error" + ex.Message);
                    }

                }

            
            }

            return (rowEffected > 0);
        }
        public static bool DeleteUser(int id)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"delete from Users where userID=@userid;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userid", id);
                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { throw new Exception("Error deleting user" + ex.Message); }
                }
            }
            return (rowIffected > 0);


        }
        public static DataTable GetAllUserWithFilter(int RoleID,bool IsActive)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("GetAllUsersWithFilter", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

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
        public static DataTable GetAllUser()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("GetAllUsers", connection))
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

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = "select 1 from Users where userID=@userid )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@userid",UserID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error " + ex.Message);

                        isFound = false;
                    }

                }
            }
            return isFound;
        }
        public static bool IsUserExistbyUserNameAndPassword(string userName,int password)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("loginUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userName", userName);

                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error " + ex.Message);

                        isFound = false;
                    }

                }
            }
            return isFound;
        }
        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {



                using (SqlCommand command = new SqlCommand("sp_changePasswod", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@password", NewPassword);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                        return false;
                    }
                }
            }
            return (rowsAffected > 0);
        }

        public static bool GetInfoUserByID(int userid,ref string userName,ref string password,ref int roleID,ref int? DentistID,ref bool isActive,ref DateTime createdAT)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getUserInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", userid);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            userName = (string)reader["username"];
                            password = (string)reader["passwordHash"];
                            roleID = (int)reader["RoleID"];
                            DentistID = reader["DentistID"] == DBNull.Value ? null : (int?)reader["DentistID"];


                            isActive = (bool)reader["isActive"];
                            createdAT = (DateTime)reader["createdAT"];
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
        public static bool GetInfoUserByuserNameAndPassword(string userName,string password,ref int userid, ref int roleID, ref int DentistID, ref bool isActive, ref DateTime createdAT)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getInfoUserByUserNameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@userName", userName);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            userid = (int)reader["userID"];
                            roleID = (int)reader["RoleID"];
                            DentistID = (int)reader["DentistID"];

                            isActive = (bool)reader["isActive"];
                            createdAT = (DateTime)reader["createdAT"];
                        }

                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                        throw new Exception("error" + ex.Message);

                    }
                    return isFound;
                }
            
            }
            
        }





    }
}

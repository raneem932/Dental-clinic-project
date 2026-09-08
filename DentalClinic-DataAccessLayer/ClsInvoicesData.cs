using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DentalClinic_DataAccessLayer
{
    public class ClsInvoicesData
    {
        public static int AddNewInvoice(int visitID, decimal paidAmount, string status)
        {
            int newID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VisitID", visitID);
                    command.Parameters.AddWithValue("@paidAmount", paidAmount);

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
                        throw new Exception("error adding Invoice" + ex.Message);
                    }
                }
            }
            return newID;
        }
        public static bool updateInvoice(int InvoiceID, int? patientID,int? visitID,DateTime? invoiceDate,Decimal? totalAmount,Decimal? paidAmount,
            string  status )
        {
            int rowIffected = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_updateInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@invoiceID", InvoiceID);

                    if (patientID.HasValue)
                    {
                        command.Parameters.AddWithValue("@patientID", patientID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@patientID", System.DBNull.Value);
                    }
                    if (visitID.HasValue)
                    {
                        command.Parameters.AddWithValue("@VisitID", visitID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@VisitID", System.DBNull.Value);
                    }
                    if (invoiceDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@invoiceDate", invoiceDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@invoiceDate", System.DBNull.Value);
                    }
                    if (totalAmount.HasValue)
                    {
                        command.Parameters.AddWithValue("@totalAmount", totalAmount);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@totalAmount", System.DBNull.Value);
                    }
                    if (paidAmount.HasValue)
                    {
                        command.Parameters.AddWithValue("@paidAmount", paidAmount);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@paidAmount", System.DBNull.Value);
                    }
                    if (status != "")
                    {
                        command.Parameters.AddWithValue("@status", status);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@status", System.DBNull.Value);
                    }

                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex) { throw new Exception("error update Invoice" + ex.Message); }
                }
            }
            return (rowIffected > 0);
        }
        public static bool DeleteInvoice(int id)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
               
                using (SqlCommand command = new SqlCommand("sp_deleteInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceID", id);
                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { throw new Exception("Error deleting Invoice" + ex.Message); }
                }
            }
            return (rowIffected > 0);


        }

        public static DataTable GetAllInvoices()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllInvoices", connection))
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
        public static DataTable GetAllInvoicesByDate(DateTime startDate,DateTime endDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllInvoicesAndByDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);


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
        public static bool GetInfoInvoiceByID(int invoiceID, ref int patientID, ref int visitID, ref DateTime invoiceDate, ref decimal totalAmount, ref decimal paidAmount, ref decimal? remainnigAmount, ref string status)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getInvoiceInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceID", invoiceID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            patientID = (int)reader["PatientID"];
                            visitID = (int)reader["visitID"];
                            invoiceDate = (DateTime)reader["InvoiceDate"];
                            paidAmount = (decimal)reader["paidAmount"];
                            remainnigAmount = reader["remainingAmount"] == DBNull.Value ? null : (decimal?)reader["remainingAmount"];

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


    }
}

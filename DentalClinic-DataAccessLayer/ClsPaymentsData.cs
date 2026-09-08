using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_DataAccessLayer
{
    public class ClsPaymentsData
    {
        public static int AddNewPayment(int invioceID, decimal amount, string notes)
        {
            int PaymentID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_addNewPayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@invoiceID", invioceID);
                    command.Parameters.AddWithValue("@Amount", amount);
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
                            PaymentID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error adding data " + ex.Message);
                    }
                }
            }
            return PaymentID;
        }
        public static bool UdpatePayment(int paymentID, int? invoiceID, decimal? Amount, string notes)
        {
            int rowEffected = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatePayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@paymentID", paymentID);
                    if (invoiceID.HasValue)
                    {
                        command.Parameters.AddWithValue("@invoiceID", invoiceID);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@invoiceID", System.DBNull.Value);

                    }
                    if (Amount.HasValue)
                    {
                        command.Parameters.AddWithValue("@Amount", Amount);

                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Amount", System.DBNull.Value);

                    }
                    if (notes != null && notes != "")
                    {
                        command.Parameters.AddWithValue("@notes", notes);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@notes", DBNull.Value);

                    }
                    try
                        {
                            connection.Open();
                            rowEffected = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("error" + ex.Message);
                        }

                }


            }

            return (rowEffected > 0);
        }
        public static bool DeletePayment(int id)
        {
            int rowIffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
             
                using (SqlCommand command = new SqlCommand("sp_DeletePayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@paymentID", id);
                    try
                    {
                        connection.Open();
                        rowIffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { throw new Exception("Error deleting payment" + ex.Message); }
                }
            }
            return (rowIffected > 0);


        }

        public static DataTable GetAllPayment()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetALLpayments", connection))
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
        public static DataTable GetInfoPaymentsforInvoice(int invoiceID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInfoPaymentforInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@invoiceID", invoiceID);
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
        public static bool GetInfoPaymentByID(int paymentID,ref int invoiceID,ref DateTime paymentDate,ref decimal Amount,ref string notes)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_getPaymentInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", paymentID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            invoiceID = (int)reader["invoiceID"];
                            paymentDate = (DateTime)reader["PaymentDate"];
                            Amount = (decimal)reader["Amount"];

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

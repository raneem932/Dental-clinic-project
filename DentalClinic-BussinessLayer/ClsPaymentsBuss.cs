using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace DentalClinic_BussinessLayer
{
    public class ClsPaymentsBuss
    {
        public int paymentID { get; set; }
        public int invoiceID { get; set; }
        public DateTime PaymentDate { get; set; }
        public Decimal Amount { get; set; }
        public string notes {  get; set; }
        public enum enMode { AddNew=0,Update=1}
        public enMode Mode = enMode.AddNew;

        public ClsPaymentsBuss(int paymentID, int invoiceID, DateTime paymentDate, decimal amount, string notes)
        {
            this.paymentID = paymentID;
            this.invoiceID = invoiceID;
            PaymentDate = paymentDate;
            Amount = amount;
            this.notes = notes;
            this.Mode = enMode.Update;
        }
        private ClsPaymentsBuss()
        {
            this.paymentID =-1;
            this.invoiceID = -1;
            this.PaymentDate =DateTime.Now;
            this.Amount = 0;
            this.notes = notes;
            this.Mode = enMode.AddNew;
        }
        private bool _AddNewPayment()
        {
            this.paymentID = ClsPaymentsData.AddNewPayment(this.invoiceID, this.Amount, this.notes);
            return (this.paymentID != -1);
        }
        private bool _UpdatePayment()
        {
            return ClsPaymentsData.UdpatePayment(this.paymentID, this.invoiceID, this.Amount, this.notes);
        }
        public bool save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPayment())
                        {
                            Mode = enMode.AddNew;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return (_UpdatePayment());
                    }
            }
            return false;
        }
        public static bool DeletePayment(int id)
        {
            return ClsPaymentsData.DeletePayment(id);
        }
        public static DataTable GetAllPayment()
        {
            return ClsPaymentsData.GetAllPayment();
        }
        public static DataTable GetInfoPaymentsForInvoice(int invoiceID)
        {
            return ClsPaymentsData.GetInfoPaymentsforInvoice(invoiceID);
        }
        public static ClsPaymentsBuss find(int paymentID)
        {
             int invoiceID=-1;
            DateTime paymentDate = DateTime.Now;
            decimal Amount = 0;
            string notes = "";
            bool isfound = ClsPaymentsData.GetInfoPaymentByID(paymentID, ref invoiceID, ref paymentDate, ref Amount, ref notes);
            if (isfound)
            {
                return new ClsPaymentsBuss(paymentID, invoiceID, paymentDate, Amount, notes);
            }
            else
            {
                return null;
            }

        }
    }
}

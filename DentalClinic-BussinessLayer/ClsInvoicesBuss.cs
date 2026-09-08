using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class ClsInvoicesBuss
    {
        public int invoiceID { get; set; }
        public int patientID { get; set; }
        public int visitID {  get; set; }   
        public DateTime invoiceDate {  get; set; }
        public decimal totalAmount {  get; set; }
        public decimal paidAmount {  get; set; }
        public decimal? remainingAmount { get; set; }
        public string status {  get; set; }
        public enum enmode { AddNew=0,Update=1}
        enmode Mode = enmode.AddNew;
        private ClsInvoicesBuss()
        {
            this.invoiceID = -1;
            this.patientID = -1;
            this.visitID = -1;
            this.invoiceDate = DateTime.Now;
            this.totalAmount = 0;
            this.paidAmount = 0;
            this.remainingAmount = 0;
            this.status = "";
            Mode = enmode.AddNew;
        }
        public ClsInvoicesBuss(int invoiceID, int patientID, int visitID, DateTime invoiceDate, decimal totalAmount, decimal paidAmount,
          Decimal? remainingAmount,  string status)
        {
            this.invoiceID = invoiceID;
            this.patientID = patientID;
            this.visitID = visitID;
            this.invoiceDate = invoiceDate;
            this.totalAmount = totalAmount;
            this.paidAmount = paidAmount;
            this.remainingAmount = remainingAmount;
            this.status = status;
            Mode = enmode.Update;
        }
        private bool _AddNewInvoice()
        {
            this.invoiceID = ClsInvoicesData.AddNewInvoice(this.visitID, this.patientID, this.status);
            return (this.invoiceID != -1);
        }
        private bool _updateInvoice()
        {
            return ClsInvoicesData.updateInvoice(this.invoiceID,this.patientID,this.visitID,this.invoiceDate,this.totalAmount,this.paidAmount,this.status);
        }
        public bool save()
        {
            switch (Mode)
            {
                case enmode.AddNew:
                    if (_AddNewInvoice())
                    {
                        Mode = enmode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enmode.Update:
                    return (_updateInvoice());
            }
            return false;
        }
        public static bool DeleteInvoice(int id)
        {
            return ClsInvoicesData.DeleteInvoice(id);
        }
        public static DataTable GetAllInvoices()
        {
            return ClsInvoicesData.GetAllInvoices();
        }
        public static DataTable GetAllInvoicesByDate(DateTime startDate, DateTime endDate)
        {
            return ClsInvoicesData.GetAllInvoicesByDate(startDate, endDate);
        }
        public static ClsInvoicesBuss find(int id)
        {
            int patientID = -1, visitID = -1;
            DateTime invoiceDate = DateTime.Now;
            decimal totalAmount = 0, paidAmount = 0;
            Decimal? remainnigAmount = 0;
            string status = "";
            bool isfound = ClsInvoicesData.GetInfoInvoiceByID(id, ref patientID, ref visitID, 
            ref invoiceDate, ref totalAmount, ref paidAmount, ref remainnigAmount, ref status);
            if (isfound)
            {
                return new ClsInvoicesBuss(id, patientID, visitID, invoiceDate, totalAmount, paidAmount,remainnigAmount, status);
            }
            else
            {
                return null;
            }
        }

    }
} 

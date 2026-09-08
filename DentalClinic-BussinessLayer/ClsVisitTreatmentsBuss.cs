using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class ClsVisitTreatmentsBuss
    {
        public int visitTreatmentID {  get; set; }
        public int visitID {  get; set; }
        public int treatmentID {  get; set; }
        public decimal cost { get; set; }
        public string notes {  get; set; }
        public enum enMode { addnew=0,Update=1}
        public enMode Mode = enMode.addnew;

        public ClsVisitTreatmentsBuss(int visitTreatmentID, int visitID, int treatmentID, decimal cost, string notes)
        {
            this.visitTreatmentID = visitTreatmentID;
            this.visitID = visitID;
            this.treatmentID = treatmentID;
            this.cost = cost;
            this.notes = notes;
            Mode = enMode.Update;
        }
        private ClsVisitTreatmentsBuss()
        {
            this.visitTreatmentID  =-1;
            this.visitID = -1;
            this.treatmentID = -1;
            this.cost = 0;
            this.notes = "";
            Mode = enMode.addnew;
        }
        private bool _AddNewVisitTreatment()
        {
            this.visitTreatmentID = ClsVisitTreatmentsData.AddNewVisitTreatment(this.visitID, this.treatmentID, this.cost, this.notes);
            return (this.visitTreatmentID != -1);
        }
        private bool _updateVisitTreatment()
        {
            return ClsVisitTreatmentsData.UpdateVisitTreatment(this.visitTreatmentID, this.visitID, this.treatmentID, this.cost, this.notes);
        }
        public bool save()
        {
            switch (Mode)
            {
                case enMode.addnew:
                    if (_AddNewVisitTreatment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return (_updateVisitTreatment());
            }
            return false;
        }
        public static bool DeleteVisitTreatment(int VisitTreatmentid)
        {
            return ClsVisitTreatmentsData.DeleteVisitTreatmenrt(VisitTreatmentid);
        }
        public static DataTable GetAllVisitTreatment(int? treatmentID, int? visitID)
        {
            return ClsVisitTreatmentsData.GetAllVisitTreatment(treatmentID, visitID);
        }
    }
}

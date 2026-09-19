using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class ClsVisitsBuss
    {
        public int visitID { get; set; }
        public int patientID { get; set; }
        public int dentistID { get; set; }
        public int? AppointmentID { get; set; }
        public DateTime visitDate { get;  }
        public string diagnosis { get; set; }
        public string notes { get; set; }
        public List<int> treatmntIDs{get;set;}
        public enum enmode { AddNew=0,update=1}
        public enmode mode = enmode.AddNew;
        public ClsVisitsBuss()
        {
            this.visitID = -1;
            this.patientID = -1;
            this.dentistID = -1;
            this.AppointmentID = -1;
            this.visitDate = DateTime.Now;
            this.diagnosis = "";
            this.notes = "";
            this.mode = enmode.AddNew;
            this.treatmntIDs = new List<int>();
        }
        public ClsVisitsBuss(int visitID, int patientID, int dentistID, int? appointmentID, DateTime visitDate, string diagnosis, string notes, List<int> treatmntIDs)
        {
            this.visitID = visitID;
            this.patientID = patientID;
            this.dentistID = dentistID;
            AppointmentID = appointmentID;
            this.visitDate = visitDate;
            this.diagnosis = diagnosis;
            this.notes = notes;
            this.mode = enmode.update;
            this.treatmntIDs =treatmntIDs;
        }
       
        private bool _updateVisit()
        {
            return ClsVisitData.UpdateVisit(this.visitID, this.patientID, this.dentistID, this.AppointmentID, this.diagnosis, this.notes);

        }
        public bool save()
        {
            this.visitID = ClsVisitData.addnewvisitWithTreatments(this.patientID, this.dentistID, this.AppointmentID, this.diagnosis, this.notes, this.treatmntIDs);
            return this.visitID != -1;

        }
        public static bool DeleteVisit(int id)
        {
            return ClsVisitData.HardDeleteVisit(id);
        }
        public static DataTable GetAllVisitsWithFilterAndPatientSearch(int? patientID, int? dentiestID, DateTime? visitDate, string search)
        {
            return ClsVisitData.GetAllVisitsWithFilterAndPatientSearch(patientID, dentiestID, visitDate, search);
        }
        public static DataTable GetAllVisits()
        {
            return ClsVisitData.GetAllVisits();
        }
        public static bool isVisitEXIST(int id)
        {
            return ClsVisitData.IsVisitExist(id);
        }
        public static DataSet getVisitDetails(int id)
        {
            return ClsVisitData.getVisitDetails(id);
        }
       /* public static ClsVisitsBuss find(int id)
        {
            int patientID = -1, dentiestID = -1;
            int? appointmentID = -1;
            DateTime visitDate = DateTime.Now;
            String diagnosis = "", notes = "";
            
            bool isfound = ClsVisitData.GetInfoVisitByID(id, ref patientID, ref dentiestID, ref appointmentID, ref visitDate, ref diagnosis, ref notes);
            if (isfound)
            {
                return new ClsVisitsBuss(id, patientID, dentiestID, appointmentID, visitDate, diagnosis, notes);
            }
            else
            {
                return null;
            }
        }*/
       public static bool deleteVisitWithTreatments(int visitID)
        {
            return ClsVisitData.DeleteVisitWithTreatents(visitID);
        }
    }
   
}

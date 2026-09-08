using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class ClsAppointmentBuss
    {
        public int AppointmentID {  get; set; } 
        public int patientID { get; set; }
        public int dentistID {  get; set; }
        public DateTime appointmentDate { get; set; }
        public string status {  get; set; }
        public string notes {  get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public DateTime createdAt { get; set; }
        public enum enMode { addNew=0,update=1}
        enMode Mode = enMode.addNew;
        public ClsAppointmentBuss()
        {
            this.AppointmentID = -1;
            this.patientID = -1;
            this.dentistID = -1;
            this.appointmentDate = DateTime.Now;
            this.status = "";
            this.notes = "";
            this.startTime = TimeSpan.Zero;
            this.endTime = TimeSpan.Zero;
            this.createdAt = DateTime.Now;
            Mode = enMode.addNew;
        }
        public ClsAppointmentBuss(int appointmentID, int patientID, int dentistID, DateTime appointmentDate, string status, string notes, TimeSpan startTime, TimeSpan endTime, DateTime createdAt)
        {
            AppointmentID = appointmentID;
            this.patientID = patientID;
            this.dentistID = dentistID;
            this.appointmentDate = appointmentDate;
            this.status = status;
            this.notes = notes;
            this.startTime = startTime;
            this.endTime = endTime;
            this.createdAt = createdAt;
            Mode = enMode.update;
        }
        private bool _AddNewAppointment()
        {
            this.AppointmentID = ClsAppointementData.AddNewAppointment(this.patientID, this.dentistID, this.appointmentDate, this.status,
                this.notes, this.startTime, this.endTime);
            return (this.AppointmentID != -1);
        }
        private bool _UpdateAppointment()
        {
            return ClsAppointementData.UpdateAppointment(this.AppointmentID, this.patientID, this.dentistID, this.appointmentDate, this.status,
                this.notes, this.startTime, this.endTime);
        }
        public bool save()
        {
            switch (Mode)
            {
                case enMode.addNew:
                    if (_AddNewAppointment())
                    {
                        Mode = enMode.update;
                        return true;
                    }
                    else
                        return false;
                case enMode.update:
                    return (_UpdateAppointment());
            }
            return false;
        }
        public static bool deleteAppointment(int id)
        {
            return ClsAppointementData.SOFTDeleteApointment(id);
        }
        public static bool isAppointmentExist(int id)
        {
            return ClsAppointementData.IsAppointmentExist(id);
        }
        public static DataTable GetAllAppointments()
        {
            return ClsAppointementData.GetAllAppointments();
        }
        public static DataTable GetAllTodayAppointments()
        {
            return ClsAppointementData.GetAllTodayAppointments();
        }
        public static DataTable GetAllAppointmentsthisMonth()
        {
            return ClsAppointementData.GetAllApppointmentsThisMonth();
        }
        public static DataTable GetAllAppointmentsthisYear()
        {
            return ClsAppointementData.GetAllAppointmentsThisYear();
        }
        public static DataTable getAllAppointmentsInSpecificDate(DateTime date)
        {
            return ClsAppointementData.GetAllAppointmentsInSpecificDate(date);
        }
        public static ClsAppointmentBuss find(int id)
        {
            int patientID=-1, DentistID = -1;
            DateTime AppointmentDate = DateTime.Now;
            string status = "", notes = "";
            TimeSpan startTime = TimeSpan.Zero;
            TimeSpan EndTime = TimeSpan.Zero;
            DateTime createdAt = DateTime.Now;
            bool isfound = ClsAppointementData.GetInfoAppointmentByID(id, ref patientID, ref DentistID, ref AppointmentDate, ref status,
                ref notes, ref startTime, ref EndTime, ref createdAt);
            if (isfound)
            {
                return new ClsAppointmentBuss(id, patientID, DentistID, AppointmentDate, status, notes, startTime, EndTime, createdAt);
            }
            else
                return null;
        }

        public static int NumberOfTodaysAppointment()
        {
            return ClsAppointementData.NumberOfTodaysAppointment();
        }
        public static bool isAppointmentBooked(DateTime appointmentDate,TimeSpan startTime,TimeSpan endTime,int dentistID)
        {
            return ClsAppointementData.isAppointmentDateAndtimeBooked(appointmentDate, startTime, endTime, dentistID);
        }
    }
}

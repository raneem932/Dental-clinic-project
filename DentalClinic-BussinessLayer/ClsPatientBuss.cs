using DentalClinic_DataAccessLayer;
using Microsoft.Xaml.Behaviors.Media;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class ClsPatientBuss
    {
        public int patientID { get; set; }
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        public string gender {  get; set; } 
        public DateTime dateOfBirth { get; set; }   
        public String phone {  get; set; }
        public string email {  get; set; }
        public String Address {  get; set; }    
        public string Allergies {  get; set; }
        public DateTime CreatedAt {  get; set; }
        private enum enMode { addNew=0,Update=1 }
        enMode mode = enMode.addNew;

        public ClsPatientBuss()
        {
            this.patientID = -1;
            this.firstName = "";
            this.lastName = "";
            this.gender ="";
            this.dateOfBirth = DateTime.Now;
            this.phone = "";
            this.email = "";
            this.Address = "";
            this.Allergies = "";
            this.CreatedAt = DateTime.Now;
            this.mode = enMode.addNew;
        }
        private ClsPatientBuss(int patientID, string firstName, string lastName, string gender, DateTime dateOfBirth,
            string phone, string email, string address, string allergies, DateTime createdAt)
        {
            this.patientID = patientID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.phone = phone;
            this.email = email;
            this.Address = address;
            this.Allergies = allergies;
            this.CreatedAt = createdAt;
            this.mode = enMode.Update;
        }
        private bool _AddNewPatient()
        {
            this.patientID = clsPatientData.AddNewPatient(this.firstName, this.lastName, this.gender, this.dateOfBirth, this.phone, this.email, this.Address, this.Allergies);
            return (patientID != -1);
        }
        
        private bool _UpdatePatient()
        {
            return clsPatientData.UpdatePatient(this.patientID, this.firstName, this.lastName, this.gender, this.dateOfBirth,
            this.phone, this.email, this.Address, this.Allergies, this.CreatedAt);
        }
        public static ClsPatientBuss find (int patientID)
        {
            String firstName = "";string lastName = "";string Gender = "";DateTime dateofBirth=DateTime.Now;

         
            string phone = "";string email = "";string address = "";String allergies = "";DateTime createsAT = DateTime.Now;
            bool isFound = clsPatientData.GetInfoPatientByID(patientID, ref firstName, ref lastName, ref Gender, ref dateofBirth,
                 ref phone, ref email, ref address, ref allergies, ref createsAT);
            if (isFound)
            {
                return new ClsPatientBuss(patientID, firstName, lastName, Gender,dateofBirth, phone, email, address, allergies, createsAT);
            }
            else
            {
                return null;
            }
        }
        public static ClsPatientBuss find(string patientName)
        {
           int patientID=-1; string lastName = ""; string Gender = ""; DateTime dateofBirth = DateTime.Now;


            string phone = ""; string email = ""; string address = ""; String allergies = ""; DateTime createsAT = DateTime.Now;
            bool isFound = clsPatientData.GetInfoPatientByName(patientName,ref patientID, ref lastName, ref Gender, ref dateofBirth,
                 ref phone, ref email, ref address, ref allergies, ref createsAT);
            if (isFound)
            {
                return new ClsPatientBuss(patientID,patientName, lastName, Gender, dateofBirth, phone, email, address, allergies, createsAT);
            }
            else
            {
                return null;
            }
        }

        public bool save()
        {
            switch (mode)
            {
                case enMode.addNew:
                    if (_AddNewPatient())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return (_UpdatePatient());

            }
            return false;
        }
        public static bool DeletePatient(int id)
        {
            return clsPatientData.DeletePatient(id);
        }
        public static DataTable GetAllPatient()
        {
            return clsPatientData.GetAllPatient();
        }
        public static bool isPatientExist(int id )
        {
            return clsPatientData.IsPatientExist(id);
        }
        public static int totalPatients()
        {
            return clsPatientData.Totalpatients();
        }
    }
}

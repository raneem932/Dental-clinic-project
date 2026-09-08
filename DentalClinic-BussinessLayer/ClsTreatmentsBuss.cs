using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class ClsTreatmentsBuss
    {
        public int TreatmentID {  get; set; }   
        public string TreatmentName { get; set; }
        public string TreatmentDescription { get;set; }
        public Decimal price {  get; set; }
        public enum enMode { addNew=0,Update=1}
        public enMode Mode = enMode.addNew;

      private  ClsTreatmentsBuss()
        {
            this.TreatmentID = -1;
            this.TreatmentDescription = "";
            this.TreatmentName = "";
            this.price = 0;
            this.Mode = enMode.addNew;
        }
        public ClsTreatmentsBuss(int treatmentID, string treatmentName, string treatmentDescription, decimal price)
        {
            TreatmentID = treatmentID;
            TreatmentName = treatmentName;
            TreatmentDescription = treatmentDescription;
            this.price = price;
            Mode = enMode.Update;
        }
        private bool _AddNewTreatment()
        {
            this.TreatmentID = ClstreatmentsData.AddNewTreatment(this.TreatmentName, this.TreatmentDescription, this.price);
            return (this.TreatmentID != -1);
        }
        private bool _UpdateTreatment()
        {
            return ClstreatmentsData.UpdateTreatment(this.TreatmentID,this.TreatmentName,this.TreatmentDescription,this.price);

        }
        public bool save()
        {
            switch (Mode)
            {
                case enMode.addNew:

                    if (_AddNewTreatment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateTreatment();

                    
            }
            return false;
        }
        public static bool DeleteTreatment(int id)
        {
            return ClstreatmentsData.DeleteTreatmenrt(id);
        }
        public static DataTable GetAllTreatments()
        {
            return ClstreatmentsData.GetAllTreatment();
        }
        public static ClsTreatmentsBuss find(int id)
        {
            string TreatmentName = "", description = "";
            decimal price = 0;
            bool isfound=ClstreatmentsData.GetInfoTreatmantByID(id,ref TreatmentName,ref description,ref price);
            if (isfound)
            {
                return new ClsTreatmentsBuss(id, TreatmentName, description, price);
            }
            else
            {
                return null;
            }
        }
        public static ClsTreatmentsBuss find(string name)
        {
            int id = -1;
             string description = "";
            decimal price = 0;
            bool isfound = ClstreatmentsData.GetInfoTreatmantByName(name ,ref id, ref description, ref price);
            if (isfound)
            {
                return new ClsTreatmentsBuss(id, name, description, price);
            }
            else
            {
                return null;
            }
        }

    }
}

using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class clsSpecializationsBuss
    {
        public int specializationID {  get; set; }  
        public String specializationName { get; set; }
        public enum enmode { addNew=0,Update=1}
        public enmode mode=enmode.addNew;
        private clsSpecializationsBuss()
        {
            this.specializationID = -1;
            this.specializationName = "";
        }
        public clsSpecializationsBuss (int specia,string speiaName)
        {
            this.specializationID = specia;
            this.specializationName=speiaName;
        }
        private bool _AddNewSpecia()
        {
            this.specializationID = ClsSpecializationsData.AddNewSpecialzation(this.specializationName);
            return (this.specializationID != -1);
        }
        private bool _UpdateSpecia()
        {
            return (ClsSpecializationsData.UpdateSpecialization(this.specializationID, this.specializationName));
        }
        public static bool _DeleteSpecia(int id) {
            return ClsSpecializationsData.DeleteSpecialization(id);
        }
        public bool save()
        {
            switch (mode)
            {
                case enmode.addNew:
                    if (_AddNewSpecia())
                    {
                        mode = enmode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enmode.Update:
                    return (_UpdateSpecia());
            }
            return false;
        }
        public static DataTable GetAllSpecia()
        {
            return ClsSpecializationsData.GetAllsSpecialization();
        }
        public static clsSpecializationsBuss find (int speciaID)
        {
            String speciName = "";
            bool isfound = ClsSpecializationsData.GetInfoSpecializationByID(speciaID, ref speciName);
            if (isfound)
            { 
            return new clsSpecializationsBuss(speciaID,speciName);
            }
            else
            {
                return null;
            }
        }
        public static clsSpecializationsBuss find(string specName)
        {
         int specID = -1;
            bool isfound = ClsSpecializationsData.GetInfoSpecializationByName(specName, ref specID);
            if (isfound)
            {
                return new clsSpecializationsBuss(specID, specName);
            }
            else
            {
                return null;
            }
        }

    }
}

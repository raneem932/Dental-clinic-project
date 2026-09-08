using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic_BussinessLayer
{
    public class ClsDentistBuss
    {
        public int dintistID { get; set; }
       public  string FirstName {  get; set; }  
        public string LastName {  get; set; }
        public string phone {  get; set; }
        public string email {  get; set; }
        public DateTime hireDate { get; set; }
        public string status {  get; set; } 
        public int specializationID { get; set;}
        public string fullName {  get; set; }

        private enum enmode { AddNew=0,update=1}
        private enmode mode = enmode.AddNew;
         public ClsDentistBuss()
        {
            this.dintistID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.phone = "";
            this.email = "";
            this.hireDate = DateTime.Now; 
            this.status = "";
            this.specializationID = -1;
          
            this.mode = enmode.AddNew;
        }
        private ClsDentistBuss(int doctorID,String firstName,string lastName,string phone,string email,DateTime hireDate,string status,int specializationID)
        {
            this.dintistID   = doctorID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.phone = phone;
            this.email = email;
            this.hireDate = hireDate;
            this.status=status;
            this.specializationID = specializationID;
            this.mode = enmode.update;
            this.fullName = this.FirstName + " " + this.LastName;
            
        }
          private bool _AddNewDoctor()
        {
            this.dintistID = ClsDentistData.AddNewDentist(this.FirstName, this.LastName, this.phone, this.email, this.hireDate, this.status, this.specializationID);
            return (dintistID != -1);
        }
        private bool _UpdateDentist()
        {
            return ClsDentistData.updateDentist(this.dintistID, this.FirstName, this.LastName, this.phone, this.email, this.hireDate, this.status, this.specializationID);
               
        }
        public bool save()
        {
            switch (mode)
            {
                case enmode.AddNew:
                    if (_AddNewDoctor())
                    {
                        mode = enmode.update;
                        return true;
                    }
                    else
                        return false;
                case enmode.update:
                    return (_UpdateDentist());
                    
            }
            return false;
        }
        public static bool  Delete(int id)
        {
            return ClsDentistData.DeleteDentist(id);
        }
     

        public static ClsDentistBuss find(int id)
        {
            string firstName="", lastName="", phone="", email="", status="";
            DateTime hireDate=DateTime.Now;
            
            int specializationID=-1;
            bool isfound = ClsDentistData.GetInfoDentistByID(id, ref firstName, ref lastName, ref phone, ref email, ref  hireDate, ref status, ref specializationID);
         

            if (isfound)
            {
                return new ClsDentistBuss(id, firstName, lastName, phone, email,hireDate, status, specializationID);
            }
            else
                return null;
        }

        public static ClsDentistBuss find(string name)
        {
            int id = -1;
            string lastName = "", phone = "", email = "", status = "";
            DateTime hireDate = DateTime.Now;

            int specializationID = -1;
            bool isfound = ClsDentistData.GetInfoDentistByName(name,ref id, ref lastName, ref phone, ref email, ref hireDate, ref status, ref specializationID);


            if (isfound)
            {
                return new ClsDentistBuss(id, name, lastName, phone, email, hireDate, status, specializationID);
            }
            else
                return null;
        }
        public static DataTable GetAllDentists()
        {
            return ClsDentistData.GetAllDentists();
        }
        public static DataTable GetAllDentistswithStatus(string status, int specializationID)
        {
            return ClsDentistData.GetAllDentistswithStatus(status, specializationID);
        }
        public static bool isDentistExist(int id)
        {
            return ClsDentistData.IsDentistExist(id);
        }

    }
}

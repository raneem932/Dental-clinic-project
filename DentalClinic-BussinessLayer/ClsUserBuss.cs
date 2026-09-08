using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class ClsUserBuss
    {
        public int userID {  get; set; }
        public String userName {  get; set; }
        public string Password {  get; set; }
        public int roleID {  get; set; }
        public int? DentistID {  get; set; } 
        public bool isActive {  get; set; } 
         public DateTime createdAT { get; set; }
         
        private enum enmode { addnew=0,update=1}
        enmode mode = enmode.addnew;
        public ClsUserBuss()
        {
            this.userID = -1;
            this.userName = "";
            this.Password = "";
            this.roleID = -1;
            this.DentistID = -1;
            this.isActive = true;
            this.createdAT = DateTime.Now;
            this.mode = enmode.addnew;
        }
        public ClsUserBuss(int userID, string userName, string password, int roleID, int? dentistID, bool isActive, DateTime createdAT)
        {
            this.userID = userID;
            this.userName = userName;
            this.Password = password;
            this.roleID = roleID;
            DentistID = dentistID;
            this.isActive = isActive;
            this.createdAT = createdAT;
            this.mode = enmode.update ;
        }

        private bool _AddnewUser()
        {
           this.userID = ClsUsersData.AddNewUser(this.userName, this.Password, this.roleID, this.DentistID, this.isActive);
            return (userID != -1);
        }
        private bool _UpdateUser()
        {
            return ClsUsersData.UdpateUser(this.userID, this.userName, this.Password, this.roleID, this.DentistID, this.isActive);
        }
        public bool save()
        {
            switch (mode)
            {
                case enmode.addnew:
                    if (_AddnewUser())
                    {
                        mode = enmode.update;
                        return true;
                    }
                    else
                 
                        return false;
                case enmode.update:
                    return (_UpdateUser());

            }
            return false;
        }
        public static ClsUserBuss find(int id)
        {
            int roleID = -1;
            string userName = "", password = ""; 
            int? DentistID=-1;
            bool isActive = true;
            DateTime createdAT = DateTime.Now;
            bool isfound = ClsUsersData.GetInfoUserByID(id, ref userName, ref password, ref roleID, ref DentistID, ref isActive, ref createdAT);
            if (isfound)
            {
                return new ClsUserBuss(id, userName, password, roleID, DentistID, isActive, createdAT);
            }
            else
                return null;
        }
        public static ClsUserBuss find(string userName,string password)
        {
            int userID=-1, roleID = -1;
            int DentistID = -1;
            bool isActive = false;
            DateTime createdAT = DateTime.Now;
            bool isfound = ClsUsersData.GetInfoUserByuserNameAndPassword( userName,password, ref userID, ref roleID, ref DentistID, ref isActive, ref createdAT);
            if (isfound)
            {
                return new ClsUserBuss(userID, userName, password, roleID, DentistID, isActive, createdAT);
            }
            else
                return null;
        }

        public static bool deleteUser(int id)
        {
            return ClsUsersData.DeleteUser(id);
        }
        public static DataTable GetAllUserWithFilter(int RoleID, bool IsActive)
        {
            return ClsUsersData.GetAllUserWithFilter(RoleID, IsActive);
        }
        public static DataTable GetAllUsers()
        {
            return ClsUsersData.GetAllUser();
        }
        public static bool IsUserExist(int id)
        {
            return ClsUsersData.IsUserExist(id);
        }
        public static bool IsUserExistbyUserNameAndPassword(string userName, int password)
        {
            return ClsUsersData.IsUserExistbyUserNameAndPassword(userName, password);
        }

    }
}

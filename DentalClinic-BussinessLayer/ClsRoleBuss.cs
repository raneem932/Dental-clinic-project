using DentalClinic_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_BussinessLayer
{
    public class ClsRoleBuss
    {
        public int roleID {  get; set; }
        public string RoleName {  get; set; }
        private ClsRoleBuss()
        {
            this.roleID = -1;
            this.RoleName = "";

        }
        public ClsRoleBuss(int roleID, string roleName)
        {
            this.roleID = roleID;
            RoleName = roleName;
        }
        public static   DataTable GetAllRole()
        {
            return ClsRoleData.GetAllRole();
        }
        public static ClsRoleBuss find(int roleID)
        {
            string roleName = "";
            bool isfound = ClsRoleData.GetInfoRoleByID(roleID, ref roleName);
            if (isfound)
            {
                return new ClsRoleBuss(roleID, roleName);
            }
            else return null;
        }
        public static ClsRoleBuss find(string roleName)
        {
            int roleID = -1;
            bool isfound = ClsRoleData.GetInfoRoleByName(roleName, ref roleID);
            if (isfound)
            {
                return new ClsRoleBuss(roleID, roleName);
            }
            else return null;
        }

    }
}

using DentalClinic_BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Dental_Clinic_Project.global
{
    internal static class ClsGlobal
    {
        public static ClsUserBuss currentUset;
        public static bool SaveUserNameAndPasswordToRegistry(string userName, string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DentalClinicProject";
            string valueName = "userName";
            string valueData = userName;
            string valueName2 = "password";
            string valueData2 = password;
            try
            {
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                Registry.SetValue(keyPath, valueName2, valueData2, RegistryValueKind.String);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception($"an error occurred:{ex.Message}");
                return false;
            }
        }
        public static bool GetUserNameAndPasswordFromRegistry(ref string userName, ref string password)
       {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DentalClinicProject";
            string valueName = "userName";
            string ValueName2 = "password";
            try
            {
                string value = Registry.GetValue(keyPath, valueName, null) as string;
                string value2 = Registry.GetValue(keyPath, ValueName2, null) as string;
                if (value != null && value2 != null)
                {
                    userName = value;
                    password = value2;
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex) {
                throw new Exception($"an error occurred:{ex.Message}");
                return false;
            }


        }

    }
}

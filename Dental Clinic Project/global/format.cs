using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Clinic_Project.global
{
    internal class format
    {
        static public string dateToString (DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy");
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    internal class StaffDL
    {
        public static List<Staff> staffs = new List<Staff>();
        public static void addstaff(Staff staff)
        {
            staffs.Add(staff);
        }
    }
}

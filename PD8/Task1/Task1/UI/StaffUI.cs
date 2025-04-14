using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1.UI
{
    internal class StaffUI
    {
        public static void addStaff()
        {
            Console.Write("Enter Name of Staff: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter School: ");
            string school = Console.ReadLine();
            Console.Write("Enter Pay: ");
            double pay = Double.Parse(Console.ReadLine());
            Staff s = new Staff(name, address, school, pay);
            StaffDL.addstaff(s);

        }

    }
}

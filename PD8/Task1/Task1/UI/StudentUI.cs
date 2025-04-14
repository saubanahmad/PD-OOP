using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1.UI
{
    internal class StudentUI
    {
        public static void  addStudent()
        {
            Console.Write("Enter Name of Student: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Program: ");
            string progeam = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter fee: ");
            double fee = Double.Parse(Console.ReadLine());
            Student s = new Student(name, address, progeam, year, fee);
            StudentDl.addStudent(s);
        }

        
    }
}

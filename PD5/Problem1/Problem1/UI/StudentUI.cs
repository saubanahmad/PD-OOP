using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.DL;
using Problem1.BL;

namespace Problem1.UI
{
    internal class StudentUI
    {
        public static Student InputStudentDetails()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC marks: ");
            float fsc = float.Parse(Console.ReadLine());
            Console.Write("Enter Ecat marks: ");
            float ecat = float.Parse(Console.ReadLine());
            return new Student(name, age, fsc, ecat);
        }
      


    }
}

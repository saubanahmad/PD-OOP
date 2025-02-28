using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.DL;
using Problem1.BL;

namespace Problem1.UI
{
    internal class SubjectUI
    {
        public static void InputSubjectDetails()
        {
            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();

            Console.Write("Enter Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Type: ");
            string type = Console.ReadLine();


            Console.Write("Enter Fee: ");
            int fee = int.Parse(Console.ReadLine());

            Subject newSubject = new Subject(code, creditHours, type, fee);
            SubjectDL.subjects.Add(newSubject);
            Console.WriteLine("Subject Added Successfully!\n");
        }



    }
}

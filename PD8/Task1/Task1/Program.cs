using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.UI;
using Task1.DL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1. Add Student: ");
                Console.WriteLine("2. Add Staff: ");
                Console.WriteLine("3. Show a Person: ");
                Console.WriteLine("4. Exit: ");
                string option = (Console.ReadLine());
                switch (option)
                {
                    case "1":
                        StaffUI.addStaff();
                        break;
                    case "2":
                        StudentUI.addStudent();
                        break;
                    case "3":
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();
                        bool yes = false;
                        foreach (Student student in StudentDl.students)
                        {
                            Console.Write(student.toString());
                            if (name == student.getName())
                            {
                                Console.WriteLine("Student: ");
                                Console.Write(student.toString());
                                yes = true;
                            }
                        }
                        foreach (Staff staff in StaffDL.staffs)
                        {
                            if (name == staff.getName())
                            {
                                Console.WriteLine("Staff: ");
                                Console.Write(staff.toString());
                                yes = true;
                            }
                        }
                        if (!yes) Console.WriteLine("Person Not Found");
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                


            }
            while (true);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Problem.UI;
using Problem1.BL;
using Problem1.DL;
using Problem1.UI;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                ConsoleUtility.DisplayMainMenu();
                choice = ConsoleUtility.GetMenuChoice();

                switch (choice)
                {
                    case 1:
                        Student student = StudentUI.InputStudentDetails();
                        StudentDL.AddStudent(student);
                        break;
                    case 2:
                        DegreeProgram program = DegreeProgramUI.InputProgramDetails();
                        DegreeProgramDL.AddProgram(program);
                        break;
                    case 3:
                        DegreeProgramUI.GenerateMerit();
                        break;
                    case 4:
                        StudentDL.DisplayAllStudents();
                        break;
                    case 5:
                        DegreeProgramUI.DisplayStudentsInDegree();
                        break;
                    //case 6:
                    case 7:
                        Student.GenerateFees();
                        break;
                    case 8:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            while (choice != 8);
        }
    }
}

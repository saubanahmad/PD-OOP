using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.DL;
using Problem1.BL;
using System.Security.Cryptography;

namespace Problem.UI
{
    internal class DegreeProgramUI
    {
        public static DegreeProgram InputProgramDetails()
        {
            Console.Write("Enter Degree Name: ");
            string title = Console.ReadLine();
            Console.Write("Enter degree duration: ");
            float duration = float.Parse(Console.ReadLine());
            Console.Write("Enter seats for degree: ");
            int seats = int.Parse(Console.ReadLine());
            Console.Write("Enter how many subjects to add:");
            int subs = int.Parse(Console.ReadLine());
            for (int i = 0; i < subs; i++)
            {
                Console.Write("Enter subject code: ");
                string code = Console.ReadLine();
                Console.Write("Enter subject type: ");
                string type = Console.ReadLine();
                Console.Write("Enter subject credit hours: ");
                int creditHours = int.Parse(Console.ReadLine());
                Console.Write("Enter subject fees: ");
                int fee = int.Parse(Console.ReadLine());
                Subject sub = new Subject(code, creditHours, type, fee);
                SubjectDL.subjects.Add(sub);
            }
            Console.Write("Press any key to continue: ");
            Console.ReadKey();
            return new DegreeProgram(title, duration, seats);
        }

        public static void GenerateMerit()
        {
            foreach (var degree in DegreeProgramDL.programs)
            {
                List<Student> sortedStudents = degree.assignDegree();


                foreach (var student in sortedStudents)
                {
                    if (degree.Studentsindegree.Contains(student))
                    {
                        Console.WriteLine($"{student.name} got Admission in {degree.title}");
                    }
                    else
                    {
                        Console.WriteLine($"{student.name} did not get Admission");
                    }
                }
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        public static void DisplayStudentsInDegree()
        {
            Console.Write("Enter Degree Name: ");
            string degreeName = Console.ReadLine();

            DegreeProgram selectedDegree = DegreeProgramDL.programs
                .FirstOrDefault(d => d.title.Equals(degreeName, StringComparison.OrdinalIgnoreCase));

            if (selectedDegree != null)
            {
                Console.WriteLine("\nName\tFSC\tEcat\tAge");

                foreach (var student in selectedDegree.GetStudentsInDegree())
                {
                    Console.WriteLine($"{student.name}\t{student.FSCMarks}\t{student.ECATMarks}\t{student.age}");
                }
            }
            else
            {
                Console.WriteLine("Degree not found!");
            }

            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
        }
    }
}


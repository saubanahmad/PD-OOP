using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;
using Problem1.DL;
using Problem1.UI;

namespace Problem1.BL
{
    internal class Student
    {
        public string name;
        public int age;
        public float FSCMarks;
        public float ECATMarks;
        public float merit;
        public List<Subject> RegisteredSubjects = new List<Subject>();

        
        public Student(string name, int age, float FSCMarks, float ECATMarks)
        {
            this.name = name;
            this.age = age;
            this.FSCMarks = FSCMarks;
            this.ECATMarks = ECATMarks;
            CalculateMerit();
        }
        public void CalculateMerit()
        {
            merit = (30 * (FSCMarks / 1200)) + (70 * (ECATMarks / 400));
        }
       
       


        private int GetTotalCredits()
        {
            return RegisteredSubjects.Sum(sub => sub.creditHours);
        }
        public static void GenerateFees()
        {
            foreach (var student in StudentDL.GetAllStudents())
            {
                int totalFee = student.RegisteredSubjects.Sum(sub => sub.subjectFee);
                Console.WriteLine($"Total fee for student {student.name} is {totalFee}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.Read();
        }
    }
}

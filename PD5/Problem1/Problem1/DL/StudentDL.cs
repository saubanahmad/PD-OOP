using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;
using Problem1.UI;

namespace Problem1.DL
{
    internal class StudentDL
    {
        public static List<Student> students = new List<Student>();



        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
        public static void DisplayAllStudents()
        {
            Console.WriteLine("Name \t\t Age \t\t FSC Marks \t\t ECAT Marks \t\t Merit");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.name} \t\t {student.age} \t\t {student.FSCMarks} \t\t {student.ECATMarks} \t\t {student.merit}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        public static List<Student> GetAllStudents()
        {
            return students;
        }
        
    }
}

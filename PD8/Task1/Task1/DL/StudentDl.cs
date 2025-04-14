using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    internal class StudentDl
    {
        public static List<Student> students = new List<Student>();
        public static void addStudent(Student student)
        {
            students.Add(student);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;
using Problem1.DL;

namespace Problem1.BL
{
    internal class DegreeProgram
    {
        public string title;
        public float duration;
        public int seats;
        public List<Subject> Subjects = new List<Subject>();
        public List<Student> Studentsindegree = new List<Student>();

        public DegreeProgram(string title, float duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
        }
        public bool AddSubject(Subject sub)
        {
            if (CalculateTotalCredits() + sub.creditHours <= 20)
            {
                Subjects.Add(sub);
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CalculateTotalCredits()
        {
            return Subjects.Sum(sub => sub.creditHours);
        }

        public List<Student> assignDegree()
        {
            List<Student> students = StudentDL.GetAllStudents();
            List<Student> sortedByMerit = students.OrderByDescending(s => s.merit).ToList();

            int seatsAvailable = this.seats;

            foreach (var student in sortedByMerit)
            {
                if (seatsAvailable > 0)
                {
                    this.Studentsindegree.Add(student);
                    seatsAvailable--;
                }

            }

            return sortedByMerit;
        }
        public Subject FindSubjectByCode(string subjectCode)
        {
            return Subjects.FirstOrDefault(sub => sub.code.Equals(subjectCode, StringComparison.OrdinalIgnoreCase));
        }

        public List<Student> GetStudentsInDegree()
        {
            return Studentsindegree;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class GradedCourse : Course
    {
        public int Grade { get; set; }

        public GradedCourse(string courseName, int grade)
            : base(courseName)
        {
            Grade = grade;
        }

        public override bool Passed()
        {
            return Grade >= 2;
        }

        public override string ToString()
        {
            return $"{CourseName}: Grade {Grade}, Passed? {Passed()}";
        }
    }
}

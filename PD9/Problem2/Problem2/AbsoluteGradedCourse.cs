using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class AbsoluteGradedCourse : Course
    {
        public int Marks { get; set; }
        public string Grade { get; set; }

        public AbsoluteGradedCourse(string courseName, int marks, string grade)
            : base(courseName)
        {
            Marks = marks;
            Grade = grade;
        }

        public override bool Passed()
        {
            return Marks >= 50;
        }

        public override string ToString()
        {
            return $"{CourseName}: {Marks}% ({Grade}), Passed? {Passed()}";
        }
    }
}

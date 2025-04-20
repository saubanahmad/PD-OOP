using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    public class GradedCourse
    {
        public string CourseName { get; set; }
        public int Grade { get; set; }

        public GradedCourse(string CourseName, int Grade)
        {
            this.CourseName = CourseName;
            this.Grade = Grade;
        }
        public bool Passed()
        {
            return Grade >= 2;
        }
    }
}

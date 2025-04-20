using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1 {
    public class AbsolutegradedCourse
    {
        public string CourseName { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
        public AbsolutegradedCourse(string CourseName, int Marks, string Grade)
        {
            this.CourseName = CourseName;
            this.Marks = Marks;
            this.Grade = Grade;
        }
        public bool Passed()
        {
            return Marks >= 50;
        }
    }
}

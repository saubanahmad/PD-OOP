﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Course
    {
        public string CourseName { get; set; }
        public Course(string courseName)
        {
            CourseName = courseName;
        }
        public virtual bool Passed()
        {
            return false;
        }
        public override string ToString()
        {
            return CourseName;
        }
    }
}

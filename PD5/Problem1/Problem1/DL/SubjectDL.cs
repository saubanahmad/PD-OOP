﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.DL
{
    internal class SubjectDL
    {
        public static List<Subject> subjects = new List<Subject>();

        public static void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }


    }
}

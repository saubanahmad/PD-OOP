﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    internal class Subject
    {
        public string code;
        public int creditHours;
        public string subjectType;
        public int subjectFee;

        public Subject(string code, int creditHours, string subjectType, int subjectFee)
        {
            this.code = code;
            this.creditHours = creditHours;
            this.subjectType = subjectType;
            this.subjectFee = subjectFee;
        }
        public bool ValidateCreditHours()
        {
            return creditHours > 0 && creditHours <= 9;
        }
    }
}

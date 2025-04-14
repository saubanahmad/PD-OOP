using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Student : Person
    {
        private string Program;
        private int Year;
        private double Fee;

        public Student(string Name, string Address, string Program, int Year, double Fee) : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
        public string getProgram()
        {
            return Program;
        }
        public void setProgram(string Program)
        {
            this.Program = Program;
        }
        public int getYear()
        {
            return this.Year;
        }
        public void setYear(int Year)
        {
            this.Year = Year;
        }
        public double getFee()
        {
            return Fee;
        }
        public void setFee(double Fee)
        {
            this.Fee = Fee;
        }
        public new string toString()
        {
            return $"Name:{Name}, Address: {Address} , Program: {Program}, Year: {Year}, Fee: {Fee}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Staff : Person
    {
        private string School;
        private double Pay;

        public Staff(string Name, string Address, string School, double Pay) : base (Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }
        public string getSchool()
        {
            return School;
        }
        public void setSchool (string School)
        {
            this.School = School;
        }
        public double getPay()
        {
            return Pay;
        }
        public void setPay(double Pay)
        {
            this.Pay = Pay;
        }
        public string toString()
        {
            return $"Name: {Name}, Address:{Address}, School:{School}, Pay:{Pay}";
        }
    }
}

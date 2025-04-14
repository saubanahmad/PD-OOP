using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Person
    {
        protected string Name;
        protected string Address;

        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public string getName()
        {
            return Name;
        }
        public string getAddress()
        {
            return Address;
        }

        public void setAddress(string Address)
        {
            this.Address = Address;
        }
        public string toString() 
        {
            return $"Name: {Name}, Address: {Address}";     
        }
    }
}

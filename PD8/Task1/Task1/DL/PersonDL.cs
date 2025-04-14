using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    internal class PersonDL
    {
        public static List<Person> persons = new List<Person>();
        public static void addPerson(Person p)
        {
            persons.Add(p);
        }
        
        
    }

}

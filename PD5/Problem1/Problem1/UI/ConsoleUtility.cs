using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.UI
{
    internal class ConsoleUtility
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("                   UAMS                     ");
            Console.WriteLine("********************************************");
            Console.Write("1. Add Student\n" +
                "2. Add Degree Program\n3. Generate Merit\n" +
                "4. View Registered Students\n5. View Students of a specific Program\n" +
                "6. Register Subjects for a specific Student\n" +
                "7. Calculate Fees for all registered Students\n" +
                "8. Exit\nEnter Option: ");

        }

        //public static int GetMenuChoice()
        //{
        //    return int.Parse(Console.ReadLine());
        //}
        public static int GetMenuChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return choice;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbsolutegradedCourse p1c1 = new AbsolutegradedCourse("Software Engineering", 85, "A");
            AbsolutegradedCourse p1c2 = new AbsolutegradedCourse("Database Management", 75, "B");
            GradedCourse p1c3 = new GradedCourse("Programming Fundamentals", 10);
            GradedCourse p1c4 = new GradedCourse("Algorithms and Data Structures", 7);

            AbsolutegradedCourse p2c1 = new AbsolutegradedCourse("Research Methods", 70, "B");
            AbsolutegradedCourse p2c2 = new AbsolutegradedCourse("Literature Review", 80, "A");
            GradedCourse p2c3 = new GradedCourse("Statistical Analysis", 12);
            GradedCourse p2c4 = new GradedCourse("Research Findings Presentation", 10);

            Project project1 = new Project("Software Development Project", p1c1, p1c2, p1c3, p1c4 );
            Project project2 = new Project("Research Project", p2c1, p2c2, p2c3, p2c4 );

            PrintProjectResult(project1);
            PrintProjectResult(project2);
        }
        static void PrintProjectResult(Project proj)
        {
            Console.WriteLine($"=== {proj.ProjectName} ===");
            Console.WriteLine($"{proj.Course1.CourseName}: {proj.Course1.Marks}% {proj.Course1.Grade}, Passed? {proj.Course1.Passed()}");
            Console.WriteLine($"{proj.Course2.CourseName}: {proj.Course2.Marks}% {proj.Course2.Grade}, Passed? {proj.Course2.Passed()}");
            Console.WriteLine($"{proj.Course3.CourseName}: Grade {proj.Course3.Grade}, Passed? {proj.Course3.Passed()}");
            Console.WriteLine($"{proj.Course4.CourseName}: Grade {proj.Course4.Grade}, Passed? {proj.Course4.Passed()}");
            Console.WriteLine($"Overall project passed? {proj.Passed()}");
            Console.WriteLine();
        }
    }
}

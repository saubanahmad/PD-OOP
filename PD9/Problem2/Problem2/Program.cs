using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> project1Courses = new List<Course>
            {
                new AbsoluteGradedCourse("Software Engineering",            85, "A"),
                new AbsoluteGradedCourse("Database Management",             75, "B"),
                new GradedCourse        ("Programming Fundamentals",        10),
                new GradedCourse        ("Algorithms and Data Structures",   7)
            };
            Project project1 = new Project("Software Development Project", project1Courses);

            // Project 2: Research Project
            List<Course> project2Courses = new List<Course>
            {
                new AbsoluteGradedCourse("Research Methods",                70, "B"),
                new AbsoluteGradedCourse("Literature Review",               80, "A"),
                new GradedCourse        ("Statistical Analysis",            12),
                new GradedCourse        ("Research Findings Presentation",  10)
            };
            Project project2 = new Project("Research Project", project2Courses);

            // Print results for both
            PrintProjectResult(project1);
            PrintProjectResult(project2);
        }
        static void PrintProjectResult(Project proj)
        {
            Console.WriteLine($"=== {proj.ProjectName} ===");
            foreach (Course c in proj.Courses)
                Console.WriteLine(c);
            Console.WriteLine($"Overall project passed? {proj.Passed()}");
            Console.WriteLine();
        }
    }
}

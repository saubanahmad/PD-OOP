using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Project
    {
        public string ProjectName { get; set; }
        public List<Course> Courses { get; set; }

        public Project(string projectName, List<Course> courses)
        {
            ProjectName = projectName;
            Courses = courses;
        }

        public bool Passed()
        {
            int passedCount = 0;
            foreach (Course c in Courses)
            {
                if (c.Passed())
                    passedCount++;
            }
            return passedCount >= 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace problem1
{
    public class Project
    {
        public string ProjectName { get; set; }
        public AbsolutegradedCourse Course1 { get; set; }
        public AbsolutegradedCourse Course2 { get; set; }
        public GradedCourse Course3 { get; set; }
        public GradedCourse Course4 { get; set; }

        public Project(string ProjectName, AbsolutegradedCourse Course1, AbsolutegradedCourse Course2, GradedCourse Course3, GradedCourse Course4)
        {
            this.ProjectName = ProjectName;
            this.Course1 = Course1;
            this.Course2 = Course2;
            this.Course3 = Course3;
            this.Course4 = Course4;
        }
        public bool Passed()
        {
            int passedCount = 0;
            if (Course1.Passed())
            {
                passedCount++;
            }
            if (Course2.Passed()) 
            {
                passedCount++;
            }
            if (Course3.Passed()) 
            {
                passedCount++; 
            }
            if (Course4.Passed()) 
            {
                passedCount++;
            }
            return passedCount >= 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
    // GraduateCourse class inherits from UndergraduateCourse
    class GraduateCourse : UndergraduateCourse
    {
        // Private field to store the research focus of the graduate course
        private string researchFocus;

        // Default constructor that calls the base (UndergraduateCourse) constructor
        public GraduateCourse() : base() { }

        // Parameterized constructor that initializes name, code, and researchFocus
        public GraduateCourse(string name, string code, string researchFocus) : base(name, code)
        {
            this.researchFocus = researchFocus;
        }

        // Overriding the print method to display the graduate course details
        public override void print()
        {
            // Display the course code
            Console.WriteLine(this.getCourseCode() + " ");

            // Display the course name
            Console.WriteLine(this.getCourseName());

            // Display the research focus
            Console.Write("The research focus: ");
            Console.WriteLine(this.researchFocus);
        }
    }
}


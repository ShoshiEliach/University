using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{

    

    class GraduateCourse : UndergraduateCourse
    {

        private string researchFocus;

        public GraduateCourse() : base() { }
        public GraduateCourse(string name,string code,string researchFocus):base(name,code)
        {
            this.researchFocus = researchFocus;
        }

        //to display the GraduateCourse data
        public override void print()
        {
            Console.WriteLine(this.getCourseCode() + " ");
            Console.WriteLine(this.getCourseName());
            Console.Write("The researchFocus: ");
            Console.WriteLine(this.researchFocus);
        }
    }
}


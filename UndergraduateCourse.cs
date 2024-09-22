using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace verysoft_test
{

    class UndergraduateCourse :Course
     {
        private string courseName;
        private string courseCode;
        private List<Person> participants=new List<Person>();

        public UndergraduateCourse() { }
        public UndergraduateCourse(string courseName, string courseCode)
        {     
            this.courseName = courseName;
            this.courseCode = courseCode;
        }

        public string getCourseName()
        {
         return courseName;
        }

        public string getCourseCode()
        {
            return courseCode;
        }

        public void addParticipant(Person person)
        {
            participants.Add(person);
        }

        public List<Person> getParticipants()
        {
            return participants;
        }


        //To display
        public virtual void print()
        {
            Console.Write(this.getCourseCode()+" ");
            Console.WriteLine(this.getCourseName());
        }
     }
}

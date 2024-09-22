using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace verysoft_test
{
    // UndergraduateCourse class implements the Course interface
    class UndergraduateCourse : Course
     {
        // Private fields for course name and course code
        private string courseName;
        private string courseCode;
        private List<Person> participants=new List<Person>();

        // List to store participants (Person objects)
        private List<Person> participants = new List<Person>();

        // Default constructor
        public UndergraduateCourse() { }

        // Parameterized constructor to initialize course name and code
        public UndergraduateCourse(string courseName, string courseCode)
        {     
            this.courseName = courseName;
            this.courseCode = courseCode;
        }

        // Method to return the course name
        public string getCourseName()
        {
         return courseName;
        }

        // Method to return the course code
        public string getCourseCode()
        {
            return courseCode;
        }

        // Method to add a participant to the course (Person object)
        public void addParticipant(Person person)
        {
            participants.Add(person);
        }

        // Method to return the list of participants
        public List<Person> getParticipants()
        {
            return participants;
        }

        // Virtual method to display the course code and name
        public virtual void print()
        {
            Console.Write(this.getCourseCode() + " ");
            Console.WriteLine(this.getCourseName());
        }
     }
}

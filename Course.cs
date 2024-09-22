using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
    // Interface representing a course
    interface Course
    {
        // Method to get the course name
        string getCourseName();

        // Method to get the course code
        string getCourseCode();

        // Method to add a participant to the course, takes a Person object as parameter
        void addParticipant(Person person);

        // Method to get the list of participants in the course
        List<Person> getParticipants();

        // Method to print course details
        void print();

    }
}

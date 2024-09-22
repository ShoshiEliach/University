using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
    interface  Course
    {
        string getCourseName();
        string getCourseCode();
        void addParticipant(Person person);
        List<Person> getParticipants();


        //To display courses
        void print();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
    // Student class that inherits from the Person class
     class Student : Person
     {
        // Private field to store the student's ID
        private string studentId;

        // Default constructor that calls the base (Person) constructor
        public Student() : base() { }

        // Parameterized constructor to initialize the studentId, name, age, and address
        public Student(string studentId, string name, int age, string address) : base(name, age, address)
        {
            this.studentId = studentId; 
        }

        // Override method to return the role of the person, in this case "Student"
        public override string getRole()
        {
            return "Student";
        }

        // Method that describing the study activity 
        public string study()
        {
            return "";
        }

        // Override method to display the student's properties
        public override void print()
        {
            Console.Write(this.getRole() + " ");
            Console.Write(this.studentId + " ");
            Console.Write(this.getName() + " ");
            Console.Write(this.getAge() + " ");
            Console.Write(this.getAddress() + " ");
            Console.WriteLine();
        }

     }
}

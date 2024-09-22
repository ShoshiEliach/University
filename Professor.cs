using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
    // Professor class inheriting from the Person class
    class Professor : Person
    {
        // Private field to store the professor's department
        private string department;

        // Default constructor that calls the base (Person) constructor
        public Professor() : base() { }

        // Parameterized constructor to initialize name, age, department, and address
        public Professor(string name, int age, string department, string address) : base(name, age, address)
        {
            this.department = department;
        }

        // Override method to return the role of the person
        public override string getRole()
        {
            return "Professor";
        }

        // Method that describing the teaching activity 
        public string teach()
        {
            return "";
        }

        // Override method to display the professor's details
        public override void print()
        {
            Console.Write(this.getRole() + " ");
            Console.Write(this.getName() + " ");
            Console.Write(this.department + " ");
            Console.Write(this.getAge() + " ");
            Console.Write(this.getAddress());
            Console.WriteLine(" ");
        }
    }
}

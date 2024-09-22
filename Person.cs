using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
    // Abstract class representing a Person
    abstract class Person
    {
        // Private fields for name and age of the person
        private string name;
        private int age;

        // Protected field for address
        protected string address;

        // Default constructor
        public Person()
        {

        }

        // Parameterized constructor to initialize name, age, and address
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        // Method to get the person's name
        public string getName() { return name; }

        // Method to get the person's age
        public int getAge() { return age; }

        // Method to get the person's address
        public string getAddress() { return address; }

        // Abstract method to get the role of the person
        public abstract string getRole();

        // Abstract method to display person details
        public abstract void print();
    }
}

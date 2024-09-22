using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
    abstract class Person
    {

        private string name;
        private int age;
        protected string address;

        public Person() 
        {

        }
        public Person(string name, int age,string address) { this.name = name; this.age = age;this.address = address; }


        public string getName() { return name; }
        public int getAge() { return age; }
        public string getAddress() { return address; }
        public abstract string getRole();


        //display the person
        public abstract void print() ; 

    }
}
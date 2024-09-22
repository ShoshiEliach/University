using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
     class Student : Person
     {
        private string studentId;

        public Student() : base() { }

        
        public Student(string studentId,string name,int age,string address):base(name,age,address) 
        {
            this.studentId = studentId; 
        }
        public override string getRole()
        {
            return "Student";
        }

        public string study()
        {
            return "";
        }


        //to display the student properties
        public override void print()
        {
            Console.Write(this.getRole() + " ");
            Console.Write(this.studentId+" ");
            Console.Write(this.getName()+" ");
            Console.Write(this.getAge() + " ");
            Console.Write(this.getAddress() + " ");
            Console.WriteLine();
        }

     }
}

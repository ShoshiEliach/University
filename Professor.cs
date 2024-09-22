using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verysoft_test
{
     class Professor:Person
     {
        private string department;

        public Professor() : base() { }
        public Professor(string name,int age,string department,string address) : base(name, age,address)
        {
            this.department = department;
        }
        public override string getRole()
        {
            return "Professor";
        }

        public string teach() 
        { 
            return ""; 
        }


        //To display the proffesor properties
        public override void print()
        {
            Console.Write(this.getRole()+" ");
            Console.Write(this.getName()+" ");
            Console.Write(this.department+" ");
            Console.Write(this.getAge() + " ");
            Console.Write(this.getAddress());
            Console.WriteLine(" ");
        }
    }
}

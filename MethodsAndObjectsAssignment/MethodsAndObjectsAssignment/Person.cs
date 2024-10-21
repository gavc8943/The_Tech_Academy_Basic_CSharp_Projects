using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Person
    { // Create a class called Person and give it two properties , FirstName and Lastname
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Give this class a void method called SayName that takes no parameters and writes persons full name to the console

        public void SayName()
        {
            Console.WriteLine( "Name:" + this.FirstName + " " + this.LastName);
        }
    }
}

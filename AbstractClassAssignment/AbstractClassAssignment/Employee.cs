using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable //  Inherits from Person   Inherits IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit() // implement the Quit() Method
        {
            Console.WriteLine(" I don't earn enough, I quit!");
        }
    }
}

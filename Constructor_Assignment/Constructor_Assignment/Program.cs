using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        const string Greeting = "Welcome!"; // const variable
        static void Main(string[] args)
        {
            var name = "Michael"; // Var variable created

            Console.WriteLine(Greeting);
            Console.WriteLine("Hello " + name );

            // Create a new object creating a class constructor
            var person = new Person("Peter", 32); // calls the first constructor
            var otherPerson = new Person("Jason", 42, "Barber"); // second constructor is called

            Console.WriteLine(person.ToString());
            Console.WriteLine(otherPerson.ToString());

            Console.ReadLine();
        }
    }
}

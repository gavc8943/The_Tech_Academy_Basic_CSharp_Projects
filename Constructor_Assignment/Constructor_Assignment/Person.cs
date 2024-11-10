using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }

        // Constructor that takes two parameters
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Constructor that takes 3 parameters Name, Age, and Occupation
        // This constructor calls the first (constructor chaining)

        public Person(string name, int age, string occupation) :this(name,age)
        {
            Occupation = occupation;
        }

        // Override the Tostring() method to display persons details in a readable format
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Occupation: {Occupation}"; // Return a formatted string with persons info
        }
    }
}

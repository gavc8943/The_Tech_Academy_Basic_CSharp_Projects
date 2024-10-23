using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee Object

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName(); // Call the same name method on the object
            Console.ReadLine();
        }
    }
}

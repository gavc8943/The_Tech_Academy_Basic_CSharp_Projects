using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and Initialize an Employee object
            Employee employee = new Employee(); /*{ FirstName = "Sample", LastName = "Student" };*/ // other way
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the superclass method SayName on the employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}

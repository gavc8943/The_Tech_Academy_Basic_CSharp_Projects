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
            employee.SayName(); // Call the Sayname method on the object

            Salary salary = new Salary();
            salary.pay();

            IQuittable quittable = new Salary();
            salary.Quit();
            

            employee.Quit(); // calling the Quit method
            Console.ReadLine();
        }
    }
}

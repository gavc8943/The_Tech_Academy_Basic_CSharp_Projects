using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe" , LastName = "Bloggs"},
                new Employee { Id = 2, FirstName = "Jane" , LastName = "Brown"},
                new Employee { Id = 3, FirstName = "Peter" , LastName = "North"},
                new Employee { Id = 4, FirstName = "Ron" , LastName = "Jeremy"},
                new Employee { Id = 5, FirstName = "Joe" , LastName = "Jones"},
                new Employee { Id = 6, FirstName = "Sarah" , LastName = "Cain"},
                new Employee { Id = 7, FirstName = "Teresa" , LastName = "Green"},
                new Employee { Id = 8, FirstName = "Martin" , LastName = "Luther"},
                new Employee { Id = 9, FirstName = "Donald" , LastName = "Trump"},
                new Employee { Id = 10, FirstName = "Bill" , LastName = "Gates"},
            };

            List<Employee> joes = new List<Employee>();

            foreach (var employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
               
            }
            Console.WriteLine("Employees with the first name 'Joe':");
            foreach (var joe in joes)
            {
                Console.WriteLine(joe);
              
            }
            

            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> greaterThanFive = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine(joes2);
            Console.WriteLine(greaterThanFive);
            Console.ReadLine();
        }
    }
}

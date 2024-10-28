using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(50001,"Rick","Smith");
            Employee employee2 = new Employee(50002,"Susan","Jones");

            Console.WriteLine($"employee1 == employee2: {employee1== employee2}");
            Console.ReadLine();


        }
    }
}

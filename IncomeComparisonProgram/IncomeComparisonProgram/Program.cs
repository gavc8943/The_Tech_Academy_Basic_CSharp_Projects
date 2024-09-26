using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine()); // converts hourly rate to int
            Console.WriteLine("Hours worked per week?");
            int weeklyHours1 = Convert.ToInt32(Console.ReadLine());
            int salary1 = Convert.ToInt32((hourlyRate1 * weeklyHours1) * 52); // multiplys to find yearly total
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int weeklyHours2 = Convert.ToInt32(Console.ReadLine());
            int salary2 = Convert.ToInt32((hourlyRate2 * weeklyHours2) * 52);
            Console.WriteLine("Annual Salary of Person 1");
            Console.WriteLine(salary1); // prints yearly total
            Console.WriteLine("Annual Salary of Person 2");
            Console.WriteLine(salary2);
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool bestEarner = salary1 > salary2; // boolean and comparison operator
            Console.WriteLine(bestEarner);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The date and time right now are " + DateTime.Now); // print current date and time
            Console.WriteLine("Please input a number"); // ask for input
            double yourInput = Convert.ToDouble( Console.ReadLine()); // get input
            Console.WriteLine("In " + yourInput + " hours the date and time will be " + DateTime.Now.AddHours(yourInput));
            Console.ReadLine();    // print out the current time and date plus input number
        }
    }
}

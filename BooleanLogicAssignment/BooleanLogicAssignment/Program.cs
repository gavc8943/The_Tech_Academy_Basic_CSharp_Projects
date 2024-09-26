using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Assesment");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); // age variable created 
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string response = Console.ReadLine().ToLower(); // To lower used in case of "yes" or "no"
            bool hasDUI = response == "yes"; // created a boolean true if user has DUI
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); // created variable to hold speed ticket amount
            Console.WriteLine("Qualified?");
            bool isQualified = age > 15 && !hasDUI && speedingTickets <= 3; // another boolean, not operator used, must be over 15, have no DUI and have less than 3 speeding tickets
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
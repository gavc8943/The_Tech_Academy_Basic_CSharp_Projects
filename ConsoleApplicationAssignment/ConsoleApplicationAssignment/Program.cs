using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            double yourNumber = Convert.ToDouble(Console.ReadLine()); // gets user number and converts to a double
            Console.WriteLine("Your number multiplied by 50 is: " + yourNumber * 50); // multiplies user input by 50
            Console.WriteLine("Input another number");
            int secondNumber = Convert.ToInt32(Console.ReadLine()); // gets user input and converts to an int
            int addedNumber = Convert.ToInt32(25);
            Console.WriteLine("your number plus twenty five is: " + (secondNumber + addedNumber)); // adds 25 to user number
            Console.WriteLine("Input another number please");
            decimal thirdNum = Convert.ToDecimal(Console.ReadLine());
            decimal numDivided = Convert.ToDecimal(12.5); // converts number to decimal
            Console.WriteLine("Your number divided by 12.5 is: " + (thirdNum / numDivided)); // divides input number by 12.5
            Console.WriteLine("Please input a number");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());
            bool aboveFifty = fourthNumber > 50; // using the boolean type and the comparison operator
            Console.WriteLine("Is your number greater than fifty? " + aboveFifty);
            Console.WriteLine("Please enter your final number");
            int finalNumber = Convert.ToInt32(Console.ReadLine());
            int remainder = finalNumber % 7; // using the modulus operator
            Console.WriteLine("Your final number modulus 7 leaves a remainder of: " + remainder);
            Console.ReadLine(); // keep the window open
        }
    }
}

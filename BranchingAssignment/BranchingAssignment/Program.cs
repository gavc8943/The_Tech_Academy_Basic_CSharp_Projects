using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter your package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine()); // receive input and Convert to Int

            if (packageWeight < 50)     //  if else statement , using comparison operator
            {
                Console.WriteLine("Thank you"); 
            }
            else if (packageWeight >= 50)
            {
                Console.WriteLine("Package too big to be shipped by Package Express. Have a nice day");
                //return;  // Would end the program
            }

            Console.WriteLine("Please enter package width");  // taking input for width height and length and converting to int
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height");
            int packageheight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length");
            int packagelength = Convert.ToInt32(Console.ReadLine());

            decimal total = Convert.ToDecimal(packageWidth + packageheight + packagelength); // created total variable 

            if (total >= 50)  // another if else statement
            {
                Console.WriteLine("Package too big to be shipped by Package Express");
                //return; // would exit program
            }
            else
            {
                Console.WriteLine("Thank you");
            }

            decimal quote = Convert.ToDecimal((packageWidth * packagelength * packageheight) * packageWeight / 100); // quote variable created and converted to decimal for monetary value

            Console.WriteLine("Your estimated total for shiiping this package is $" + quote);
            Console.WriteLine("Thank you");


            Console.ReadLine();

        }
    }
}

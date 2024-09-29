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
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight < 50)     // 
            {
                Console.WriteLine("Thank you");
            }
            else if (packageWeight >= 50)
            {
                Console.WriteLine("Package too big to be shipped by Package Express. Have a nice day");
                //return;  // Would end the program
            }

            Console.WriteLine("Please enter package width");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height");
            int packageheight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length");
            int packagelength = Convert.ToInt32(Console.ReadLine());

            decimal total = Convert.ToDecimal(packageWidth + packageheight + packagelength);

            if (total >= 50)
            {
                Console.WriteLine("Package too big to be shipped by Package Express");
                //return; // would exit program
            }
            else
            {
                Console.WriteLine("Thank you");
            }

            decimal quote = Convert.ToDecimal((packageWidth * packagelength * packageheight) * packageWeight / 100);

            Console.WriteLine("Your estimated total for shiiping this package is $" + quote);
            Console.WriteLine("Thank you");


            Console.ReadLine();

        }
    }
}

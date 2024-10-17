using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathMethod Class
            MathMethod mathOp = new MathMethod();
            // ask user to provide first parameter
            Console.WriteLine("Please enter an Integer");
            int yourInteger = Convert.ToInt32(Console.ReadLine());
            // ask user to provide second parameter
            Console.WriteLine("Enter a second integer or just press enter");
            try
            {
                // call method with two parameters if both are provided
                int yourInteger2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.mathMethod(yourInteger, yourInteger2);
                Console.WriteLine(yourInteger + " x " + yourInteger2 + " = " + results);
            }
            catch
            {
                // call method with one parameter if only one is provided
                int results = mathOp.mathMethod(yourInteger);
                Console.WriteLine(yourInteger + " x Default 1 = " + results);

            }
            Console.ReadLine();
        }
    }
}

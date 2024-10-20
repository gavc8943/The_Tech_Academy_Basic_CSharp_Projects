using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            Class1 math = new Class1();
            // call the method
            Console.WriteLine("Input a number");
            int dividend = Convert.ToInt32(Console.ReadLine());
            math.MyCalc(dividend);
            Console.ReadLine();
            //////
            /// create a method with output parameters
            int a = 40, b = 60;
            int sum = 0;
            int product = 0;
            math.MyCalc2(a, b, out sum, out product); // passing numbers a and b into x and y

            Console.WriteLine("Sum = {0} and Product = {1}", sum, product);


            // Overload a method

            Console.WriteLine("The sum of two ints = {0}",math.sum(43, 62));
            Console.WriteLine("The sum of two doubles = {0}", math.sum(45.23,62.33));
            Console.WriteLine("Two concatenated strings = {0}", math.sum("Hello ", "World"));
           

            Class2.SayHello("John");
            Console.ReadLine();
        }
    }
}

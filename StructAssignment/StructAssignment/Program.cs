using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        struct Number // Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {    /// In the Main() method, create an object of data type Number and assign an amount to it.
            Number number = new Number();
            
            number.Amount = 215.876m;

            Console.WriteLine(number.Amount); // Print this amount to the console
            Console.ReadLine();
        }
    }
}

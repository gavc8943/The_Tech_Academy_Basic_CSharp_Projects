using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Math class
            Math math1 = new Math();
            // Call the first method with an int parameter
            Console.WriteLine(math1.myMath(8));
            // Call the second method with a decimal parameter
            Console.WriteLine(math1.myMath(2.4m));
            // Call the third method with a string parameter
            Console.WriteLine(math1.myMath("8"));
            Console.ReadLine();
        }
    }
}

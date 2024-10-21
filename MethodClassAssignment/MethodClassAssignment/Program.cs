using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperation mathOp = new MathOperation();
            mathOp.myMethod(5, 6); // call the method with two numbers
            mathOp.myMethod(b:3,c:7) ; // call the method specifying the parameters by name
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment2
{
    class Class1
    {
        public  void MyCalc(int a)
        {
            Console.WriteLine("Your number divided by 2 = " + a / 2);
        }
        // Create a method with output parameters
        public void MyCalc2(int x, int y, out int sum, out int prod) // use keyword out // void doesnt return anything
        {
            sum = x + y;
            prod = x * y;
        }
        /// Overload a method 
        public  int sum(int x ,int y)
        {
            int add = x + y;
            return add;
        }
        public double sum(double x, double y)
        {
            double add = x + y;
            return add;
        }
        public string sum(string x, string y)
        {
            string add = x + y;
            return add;
        }
    }
}

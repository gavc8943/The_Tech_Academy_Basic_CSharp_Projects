using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
      public class Math
    {
        // First Integer method
        public int myMath(int num)
        {
            return num * 4; 
        }
        // Second Method that takes a decimal
        public int myMath(decimal num)
        {
            // Convert decimal to int 
            int myNum = Convert.ToInt32(num);
            return myNum * 25;
        }
        // Third Method that takes a string

        public int myMath(string num)
        {
            // Convert the string to an Int
            int myNum = Convert.ToInt32(num);
            return myNum / 2;
        }
    }
}

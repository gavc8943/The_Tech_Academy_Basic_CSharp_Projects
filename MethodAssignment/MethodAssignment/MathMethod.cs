using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class MathMethod
    { 
        public int mathMethod( int a , int b = 3)
        {
            int result = a * b;
            return result;
        }
    }
}

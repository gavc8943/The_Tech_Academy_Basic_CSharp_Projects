using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Salary :Employee, IQuittable
    {
        public void pay()
        {
            Console.WriteLine("Your Salary is below average");
        }

        public void Quit()
        {
            Console.WriteLine("I don't earn enough, I quit");
        }
  
           
    }

}

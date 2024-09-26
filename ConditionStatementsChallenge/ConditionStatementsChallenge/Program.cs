using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which is your favorite meal? (Chicken , Beef or Fish?)");
            string faveFood = Console.ReadLine().ToLower();

            if (faveFood == "chicken")
            {
                Console.WriteLine("Enyoy your chicken dinner");
            }
            else if (faveFood == "beef")
            {
                Console.WriteLine("Enjoy your beef dinner");
            }
            else if (faveFood == "fish") 
            {
                Console.WriteLine("Enjoy your fish supper");
            }
            Console.ReadLine();
        }
    }
}

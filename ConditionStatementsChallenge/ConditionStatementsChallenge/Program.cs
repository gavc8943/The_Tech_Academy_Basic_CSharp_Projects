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
            //Console.WriteLine("Which is your favorite meal? (Chicken , Beef or Fish?)");
            //string faveFood = Console.ReadLine().ToLower();

            //if (faveFood == "chicken")
            //{
            //    Console.WriteLine("Enyoy your chicken dinner");
            //}
            //else if (faveFood == "beef")
            //{
            //    Console.WriteLine("Enjoy your beef dinner");
            //}
            //else if (faveFood == "fish") 
            //{
            //    Console.WriteLine("Enjoy your fish supper");
            //}
            //Console.ReadLine();

            // not operator

            //Console.WriteLine("Please enter your name");
            //string yourName = Console.ReadLine();

            //if (yourName != "Gavin")
            //{
            //    Console.WriteLine("Hello nice to meet you");
            //}
            //else
            //{
            //    Console.WriteLine("Hey thats my name too");
            //}
            //Console.ReadLine();

            //Console.WriteLine("Please enter your age");
            //int yourAge = Convert.ToInt32(Console.ReadLine());

            //if (yourAge >= 18)
            //{
            //    Console.WriteLine("You may drink alcohol");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry you cant drink alcohol yet");
            //}


            //Console.WriteLine("How many pints do you drink on a night out?");
            //int pintsDrank = Convert.ToInt32(Console.ReadLine());

            //if (pintsDrank <= 3)
            //{
            //    Console.WriteLine("Thats a sensible amount");
            //}
            //else
            //{
            //    Console.WriteLine("You might have a hangover the next day");
            //}

            //Console.ReadLine();

            int num1 = 22;
            int num2 = 25;

            string result = num1 < num2 ? "num1 is less than num2" : "num1 is not less than num2";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

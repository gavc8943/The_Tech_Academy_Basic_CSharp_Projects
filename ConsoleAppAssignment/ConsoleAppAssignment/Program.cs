using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Guess my age"); 
            //int age = Convert.ToInt32( Console.ReadLine()); // Converting input to int
            //bool correctGuess = age == 43;  // created boolean 

            //do  // do switch statement first before while loop
            //{
            //    switch (age)   // Switch Statement
            //    {
            //        case 21:
            //            Console.WriteLine("I wish I was 21 , sorry incorrect");
            //            Console.WriteLine("Guess my age");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 65:
            //            Console.WriteLine("Im not that old!, sorry incorrect");
            //            Console.WriteLine("Guess my age");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 40:
            //            Console.WriteLine("Getting closer but incorrect");
            //            Console.WriteLine("Guess my age");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 46:
            //            Console.WriteLine("Wow you guessed my age, 46 is correct!");
            //            correctGuess = true;
            //            break;
            //        default:
            //            Console.WriteLine("Sorry thats not correct");
            //            Console.WriteLine("Guess my age");
            //            age = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!correctGuess); // while correctGuess all false 



            //Console.Read();

            int num = 0;
            while (num < 8)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.Read();
        }
    }
}

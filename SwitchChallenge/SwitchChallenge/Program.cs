using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string favColor = "blue";
            switch (favColor)
            {
                case "green":
                    Console.WriteLine("Green is a nice color but not my favorite");
                    break;
                case "red":
                    Console.WriteLine("Red is great but not my favorite");
                    break;
                case "orange":
                    Console.WriteLine("I dont like orange");
                    break;
                case "blue":
                    Console.WriteLine("Hey thats my favorite color!!!");
                    break;
                case "yellow":
                    Console.WriteLine("A nice color but not my favorite");
                    break;

            }
            Console.ReadLine();
        }
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProject
{
    class Program
    {
        public enum Actions
        {
            Increase,
            Decrease,
            Reset,
            Exit
        }
        static void Main(string[] args)
        {
            int score = 10;
            bool running = true;

            while(running)
            {
                Console.WriteLine("Current score = " + score);
                Console.WriteLine("Choose an action (Increase, Decrease, Reset,Exit):");
                string userInput = Console.ReadLine();

                try
                {
                    Actions action = (Actions)Enum.Parse(typeof(Actions), userInput, true);

                    switch (action)
                    {
                        case Actions.Increase:
                            score += 1;
                            break;
                        case Actions.Decrease:
                            score -= 1;
                            break;
                        case Actions.Reset:
                            score  = 10;
                            break;
                        case Actions.Exit:
                            running = false;
                            break;
                    }
                }

                catch(ArgumentException)
                {
                    Console.WriteLine("Invalid action. Please enter Increase, Decrease, Reset, or Exit.");
                }
            }
            Console.WriteLine("Final score: " + score);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        // Create an enum for days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the day of the week");
            //string dayInput = Console.ReadLine();
            //bool isValid = Enum.TryParse(dayInput, out DaysOfTheWeek dayInAWeek);  

            //if(isValid)
            //{
            //    Console.WriteLine( "Have a lovely " + dayInAWeek);
            //    Console.ReadLine();
            //}


            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    // Ask user to enter day of the week
                    Console.WriteLine("Enter the day of the week");
                    string dayInput = Console.ReadLine();
                    // assign the value to a variable of that enum data type  you just craeted
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayInput);
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();
                    isValid = true;
                }
                catch (ArgumentException )
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
        }


        
    }
}

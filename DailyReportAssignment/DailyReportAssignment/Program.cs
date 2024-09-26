using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy Of Learning Career College\nStudent Daily Report"); // new line below added
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine(); // saves answer
            Console.WriteLine("Your name is: " + yourName);
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine(); // used string type
            Console.WriteLine("The course you are on is: " + yourCourse);
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine()); // converted to an integer
            Console.WriteLine("The page number is: " + pageNumber);
            Console.WriteLine("Do you need help with anything? please answer \"true\" or\" false\".");
            bool helpAnswer = Convert.ToBoolean(Console.ReadLine()); // converted to a boolean
            Console.WriteLine("You answered: " + helpAnswer);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string myExperience = Console.ReadLine();
            Console.WriteLine("Your experience in your words was: " + myExperience);
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("In your own words: " + yourFeedback);
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine()); // converted to integer
            Console.WriteLine("You studied: " + hoursStudied + "hours today ");
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly.Have a great day!");
            Console.ReadLine();
        }
    }
}

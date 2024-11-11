using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try // start try and catch block for exceptions
            {
                Console.WriteLine("Hello please input your age."); // Ask the user for their age.
                int ageInput = Convert.ToInt32(Console.ReadLine()); // get the input
                if(ageInput  <= 0) // check for valid input
                {
                    Console.WriteLine("Invalid input. Input must be a positive number greater than )");
                }
                else
                {
                    int currentYear = DateTime.Now.Year; // gets current year
                    int birthYear = currentYear - ageInput; // gets birth year by subtacting ageInput from currentYear
                    Console.WriteLine("The year you were born is " + birthYear); // display birth year
                    Console.ReadLine();
                }
               
            }
            catch (FormatException) // catch for specific error
            {
                Console.WriteLine("Please enter a valid number,no decimals");
            }
            catch(Exception) // catch for general error
            {
                Console.WriteLine("An error occured. Please try again");
            }
            
        }
    }
}

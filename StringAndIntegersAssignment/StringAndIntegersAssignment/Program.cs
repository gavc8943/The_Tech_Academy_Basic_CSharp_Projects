using System;
using System.Collections.Generic;


namespace StringAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try // try block
            {
                List<int> intList = new List<int>() { 46, 54, 22, 17, 89, 65 };  // create list of integers
                Console.WriteLine("Please input a number for division");
                int yourNum = Convert.ToInt32(Console.ReadLine());  // get input from user

                for (int i = 0; i < intList.Count; i++) 
                {
                    Console.WriteLine(intList[i] / yourNum);   // dividing each element in the list
                }
            }
            catch(DivideByZeroException ex)  // catch block , catches divide by zero error
            {
                Console.WriteLine("Please use only a whole number"); // create personalised message
            }
            catch(FormatException ex)  
            {
                Console.WriteLine(ex);  // prints error message
            } 
            finally
            {
                Console.WriteLine("Program has exited try/catch block");
            }
           
            Console.ReadLine();

            //// Model Answer ////

            List<int> intList2 = new List<int> { 5, 99, 23, 10, 185, 22, 12, 2994, 101, 77000 };
            // get user input and divide numbers in the list by the input
            bool numValid = false;

            while(!numValid)
            {
                // try catch block for errors
                try
                {
                    Console.WriteLine("Enter a number to divide the above list by");
                    float numDivide = float.Parse(Console.ReadLine());
                    // if statement to check if user entered 0

                    if(numDivide == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0 ");
                    }
                    // Dividing each number in the list by the input
                    else
                    {
                        foreach(int num in intList2)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + "=" + Divide);
                        }
                        numValid = true;
                    }
                }
                // catch block to display error message for string input
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number");
                }
            }
            // Message to let the user know the program has exited try/catch block
            Console.WriteLine("The program has exited the try/catch block.");
            Console.ReadLine();
        }
       
    }
}

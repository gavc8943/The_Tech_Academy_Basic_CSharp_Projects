using System;
using System.Collections.Generic;
using System.Text;



    class Program
    {
        static void Main(string[] args)
        {
        //    // Assignment 1 //
        //    // Create a one dimensional array of strings
        //    string[] wordStart =
        //    {
        //        "Hello i'm from ",
        //        "My name is ",
        //        "I speak "
        //    };
        //    string[] wordEnd =
        //    {
        //        " a great Country.",
        //        "." ,
        //        " fluently."
        //    };

        //    List<string> responses = new List<string>();
        //    // User inputs text

        //    Console.WriteLine("Please enter your home Country");
        //    responses.Add(Console.ReadLine()); // adds to responses List
        //    Console.WriteLine("Please enter your name");
        //    responses.Add(Console.ReadLine()); // adds to responses List
        //    Console.WriteLine("Please enter the language you speak");
        //    responses.Add(Console.ReadLine()); // adds to responses List

        //    // Create a loop that goes through each string in the array and adds users text to the string
        //    for (int i = 0; i < wordStart.Length;i++)
        //    {
        //        wordStart[i] += responses[i];  // wordStart[i] = wordStart[i] + responses[i]
        //        Console.WriteLine(wordStart[i] + wordEnd[i]);
        //    }
        //    Console.ReadLine();
        //    Console.WriteLine("The strings we used: ");
        //// Create a loop that prints off each string in the array on a seperate line

        //    for (int i = 0; i < wordStart.Length; i++)
        //{
        //    Console.WriteLine(wordStart[i] + wordEnd[i]);

        //    // Part 2 Infinite loop (uncomment i-- for an infinite loop
        //    //i--;
        //}
        //Console.ReadLine();

        // Part 3 
        Console.WriteLine("Is that a Monster?");
        StringBuilder grr = new StringBuilder();
        grr.Append("G");
        // Create a loop where the comparison thats used to determine whether to continue iterating the loop is "<" operator

        while (grr.Length < 6)
        {
            grr.Append("r");
        }
        grr.Append("!");
        Console.ReadLine();
        Console.WriteLine(grr);
        Console.ReadLine();

        StringBuilder echo = new StringBuilder();
        echo.Append("Is there an echo ?");
      //Create a loop where the comparison thats used to determine whether to continue iterating the loop is "<=" operator
        
        while (echo.Length <= 60)
        {
            echo.Append(" echo ");
        }
        echo.Append(".");
        Console.WriteLine(echo);
        Console.ReadLine();

        // Part 4 
        // Create a list of strings where each string is unique

        List<string> footballTeams = new List<string>() { "Liverpool", "Arsenal", "Chelsea", "Tottenham", "West Ham" };
        Console.WriteLine("Premier League Standings");
        // Ask the user to input text to look for in the list
        Console.WriteLine("Enter team name:");
        int standing = 0;
        bool isValid = false;
        int index = 0;
        // Create a loop that iterates through the loop and displays the index of the array that contains matching text on the screen.

        while (!isValid) // true
        {
            int i2 = 0;
            string teamChoice = Console.ReadLine();

            foreach (string team in footballTeams)
            {
                if (teamChoice == team)
                {
                    standing = i2 + 1;
                    index = i2;
                }

                i2++; // increments by 1
            }

            // add code to above loop that tells a user if they put in text that isnt in the list
            if (standing == 0)
            {
                Console.WriteLine("That isnt a valid team. Enter again");
            }
            // add code to the above loop that stops it from executing once a match has been found
            else
            {
                isValid = true;
            }
        }
        Console.WriteLine("Processing... Index is..." + index + ". S0...");
        Console.WriteLine("Standing is: " + standing);
        Console.ReadLine();

        // Part 5 
        // Create a list of strings that has at least two identical strings in the list

        List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" };
        Console.WriteLine("Welcome to Imperial Garden Chinese! \n  Please use our computerized check in.\n If you have a reservation type "
            + "\"Reserved\". \n If you are joining a party that is already here type \"Taken\". \n Otherwise type \"Vacant\".");
        // Ask user to select text to search for in the list
        Console.WriteLine("Enter Selection");
        string selection = Console.ReadLine();

        while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
        {
            Console.WriteLine("Please enter one of the 3 choices: ");
            selection = Console.ReadLine();
        }
        Console.WriteLine("The tables that match your selection are numbered:");
        // Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen

        for(int i3 = 0; i3 < tables.Count; i3++)
        {
            if (selection == tables[i3]) 
            {
                Console.WriteLine(i3);
            }
        }
        Console.ReadLine();

        // Part 6
        // Craete a list of strings that has at least two identical strings in the list

        List<string> animals = new List<string>() { "Cat", "Dog", "Fish", "Dog", "Horse", "Sasquatch" };
        List<string> checkList = new List<string>();
        Console.WriteLine("Pets");
        // create a foreach loop that evaluates each item in the list , and displays a message showing the string and whether or not it has already appeared in the list
        foreach(string animal in animals)
        {
            Console.WriteLine(animal);
            if(checkList.Contains(animal))
            {
                Console.WriteLine("This animal has been repeated");
            }
            else
            {
                Console.WriteLine("This animal has not been repeated");
            }
            checkList.Add(animal); // adds to checkList
        }
        Console.ReadLine();
        }
    
    }


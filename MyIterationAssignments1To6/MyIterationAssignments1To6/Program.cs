using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //// App Assignment Part 1
        //// one dimensional array of strings
        //string[] names = { "John", "Mark", "Wayne", "Peter", "Alan" };
        //// ask user to input text
        //Console.WriteLine("Please input the text \" is a friend of mine \"");
        //string yourName = Console.ReadLine();  // getting user input

        //for (int i = 0; i < names.Length; i++) // iterates through array
        //{
        //    names[i] = names[i] + yourName;  // adding user input

        //    for (int j = 0; j < names.Length; j++)   // nested inner loop
        //    {
        //        Console.WriteLine(names[i]);

        //    }

        //}

        //Console.ReadLine();

        /////////////// Assignment Part 2 ////////////////
        /// Infinite Loop  ///
        /// While Loop //

        //int increment = 0; 

        // while (true)
        //{
        //    Console.WriteLine( increment++); // prints infinite times

        //    // add a condition and a break to exit the loop
        //    if (increment >= 100)
        //    {
        //        break;
        //    }
        //}
        //Console.ReadLine();

        ///////////////// App Assignment Part 3 ///////////////
        // First Loop
        //int incrementFive = 0;  // create variable

        //while (incrementFive < 100)
        //{
        //    Console.WriteLine(incrementFive += 5);  // increments by 5 each time
        //}
        //Console.ReadLine();

        // Second loop

        //for (int i = 0; i < 20; i++)
        //{
        //    if (i <=8)
        //    {
        //        continue;  // continues the iteration after 8
        //    }
        //    Console.WriteLine(i);
        //}

        //Console.ReadLine();

        // Assignment 4 //

        List<string> groceryItems = new List<string>(); // created a list
        groceryItems.Add("bread");
        groceryItems.Add("milk");
        groceryItems.Add("eggs");
        groceryItems.Add("rice");
        groceryItems.Add("beans");
        groceryItems.Add("fruit");
        groceryItems.Add("vegetables");

        Console.WriteLine("Please enter a food item");   // ask for input
        string yourChoice = Console.ReadLine().ToLower();   // take input and convert to lowercase
        int index = -1; // created index ariable

        foreach (string item in groceryItems)
        {
            index++;

            if (yourChoice == item)
            {
                Console.WriteLine("Your food item is on the list at index " + index);
            }
        }
        Console.ReadLine();


        ///////////////// Assignment 5 ///////////////////   

        //List<string> friendNames = new List<string>() { "JOHN", "MARK", "PETER",  "JOHN", "WAYNE" }; // list with two identical strings
        //Console.WriteLine("Please enter a friends name");
        //string yourFriendsName = Console.ReadLine().ToUpper();  // take in user input

        //while (!(yourFriendsName == "JOHN" || yourFriendsName == "MARK" || yourFriendsName == "PETER" || yourFriendsName == "WAYNE"))
        //{
        //    Console.WriteLine("Sorry that names not on the List");  // Code for names not in the list
        //        yourFriendsName = Console.ReadLine().ToUpper();
        //}

        //Console.WriteLine("The Indices of that name are below ");

        //for (int i = 0; i < friendNames.Count; i++)    // created loop , iterates and if an element matches user input, index is printed
        //{
        //     if(yourFriendsName == friendNames[i])
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //Console.ReadLine();  

        //// Assignment 6 //////////////////

        //        List<string> petsList = new List<string> { "Cat", "Goldfish", "Dog", "Cat", "Hamster", "Gerbil " };  // create a list of strings with two identical strings
        //        List<string> checkList = new List<string>(); // Created another list

        //        foreach (string pet in petsList) // loop evaluates each item in the list and prints a message depending on the condition
        //        {
        //            Console.WriteLine(pet);
        //            if (checkList.Contains(pet))
        //            {
        //                Console.WriteLine("This pet is in the list more than once");
        //            }
        //            else
        //            {
        //                Console.WriteLine("This pet is not repeated in the list");
        //            }
        //            checkList.Add(pet);

        //        }
        //        Console.ReadLine();
    }
}


        }
    }


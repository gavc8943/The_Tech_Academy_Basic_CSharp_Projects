﻿using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        //string[] nameArray = { "John", "Peter", "Mark", "", "Sofia" };  // create an array
        //Console.WriteLine("Please select an index from 0 to 4");      // message to user
        //int indexChoice = Convert.ToInt32(Console.ReadLine());        // take in user input

        //if (indexChoice == 0)                  // if else statement 
        //{
        //    Console.WriteLine(nameArray[0]);  // prints the string at 0 index
        //}
        //else if (indexChoice == 1)
        //{
        //    Console.WriteLine(nameArray[1]);
        //}
        //else if (indexChoice == 2)
        //{
        //    Console.WriteLine(nameArray[2]);
        //}
        //else if (indexChoice == 3)
        //{
        //    Console.WriteLine(nameArray[3]);
        //}
        //else if (indexChoice == 4)
        //{
        //    Console.WriteLine(nameArray[4]);
        //}
        //else
        //{
        //    Console.WriteLine("Only a number from 0 to 4 please."); // prints if anything other than 0 to 4 is chosen
        //}
        //Console.ReadLine();

        //int[] numArray = { 5, 10, 15, 20, 25, 30, 35, 40 };     // array of integers
        //Console.WriteLine("Please select an index from 0 to 7");
        //int myIndexPick = Convert.ToInt32(Console.ReadLine());  // get user input

        //switch (myIndexPick)            // switch statement
        //{ 
        //    case 0:
        //        Console.WriteLine(numArray[0]);
        //        break;
        //    case 1:
        //        Console.WriteLine(numArray[1]);
        //        break;
        //    case 2:
        //        Console.WriteLine(numArray[2]);
        //        break;
        //    case 3:
        //        Console.WriteLine(numArray[3]);
        //        break;
        //    case 4:
        //        Console.WriteLine(numArray[4]);
        //        break;
        //    case 5:
        //        Console.WriteLine(numArray[5]);
        //        break;
        //    case 6:
        //        Console.WriteLine(numArray[6]);
        //        break;
        //    case 7:
        //        Console.WriteLine(numArray[7]);
        //        break;
        //    default:
        //        Console.WriteLine("Only a number from 0 to 7 please.");
        //        break;
        //}
        //Console.ReadLine();

        List<string> myStringList = new List<string>();   // creating a list
        myStringList.Add("Hello");
        myStringList.Add("Nice to meet you");
        myStringList.Add("Hows things?");
        myStringList.Add("Long time no see");
        Console.WriteLine("Please choose a number 0 to 3");
        int yourNum = Convert.ToInt32(Console.ReadLine());    // Converts to integer

        if (yourNum == 0)
        {
            Console.WriteLine(myStringList[0]);
        }
        else if (yourNum == 1)
        {
            Console.WriteLine(myStringList[1]);
        }
        else if (yourNum == 2)
        {
            Console.WriteLine(myStringList[2]);
        }
        else if (yourNum == 3)
        {
            Console.WriteLine(myStringList[3]);
        }
        else
        {
            Console.WriteLine("Only a number from 0 to 3 please");
        }
        Console.ReadLine();
    }
    }


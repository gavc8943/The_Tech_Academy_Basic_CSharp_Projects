using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string greeting = "Hello";
            //string name = "Gavin";
            //int age = Convert.ToInt32(46);

            //string sentence = greeting + " My name is " + name + " and I am " + age + " years old.";
            //Console.WriteLine(sentence);
            //Console.ReadLine();

            //string allLower = "change me to uppercase";
            //allLower = allLower.ToUpper();
            //Console.WriteLine(allLower);
            //Console.ReadLine();

            StringBuilder myStringBuilder = new StringBuilder();

            myStringBuilder.Append("My name is Gavin \n");
            myStringBuilder.Append("I am from England \n");
            myStringBuilder.Append("I live in Ireland \n");
            myStringBuilder.Append("Im studying C Sharp \n");
            myStringBuilder.Append("I hope this works!");

            Console.WriteLine(myStringBuilder);
            Console.ReadLine();

        }
    }
}

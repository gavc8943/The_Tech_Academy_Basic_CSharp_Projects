using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said \\Hello \", Jesse. \n Hello on a new line. \n \t Hello on a tab ";

            //string fileName = "C:\\Users\\Jesse";
            //string fileName2 = @"C:\Users\Gavin";

            //bool trueOrFalse = name.Contains("s");  // does the string name contain an s  true / false
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length; // length of name

            ////name = name.ToUpper();
            //name = name.ToLower();

            ////Console.WriteLine(quote);
            ////Console.WriteLine(fileName);
            ////Console.WriteLine(fileName2);
            //Console.WriteLine(name);
            //Console.Read();

            StringBuilder  sb = new StringBuilder();
            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.Read();
        }
    }
}

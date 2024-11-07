using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\Users\User\log\log.html", Convert.ToString(yourNum));
            int fileContent = Convert.ToInt32(File.ReadAllText(@"C:\Users\User\log\log.html"));
            Console.WriteLine("Your number is " + fileContent);
            Console.ReadLine();
        }
    }
}

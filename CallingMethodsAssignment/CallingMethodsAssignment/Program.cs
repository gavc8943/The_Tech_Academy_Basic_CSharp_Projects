using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number to pass into my methods.");
            int yourNum = Convert.ToInt32(Console.ReadLine()); // receive user input

            int firstResult = Class1.timesFive(yourNum); // calling the methods
            int SecondResult = Class1.plusTen(yourNum);
            int ThirdResult = Class1.divide2(yourNum);

            Console.WriteLine(" Your number passed through my first method returned " + firstResult);
            Console.WriteLine(" Your number passed through my Second method returned " + SecondResult);
            Console.WriteLine(" Your number passed through my Third method returned " + ThirdResult);
            Console.ReadLine();

            //////////////////// Model Aswer ////////////////////

            Console.WriteLine("You've encountered Groznyi the Brigand and he launches a surprise attack");
            Console.WriteLine("Input your defense stat");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = Class1.Defense(defense);
            Console.WriteLine("You have taken " + enemy_damage + " HP of damage");
            Console.WriteLine("Your healer Serra is nearby. She heals you with her staff");
            Console.WriteLine("Input your healers magic stat");

            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = Class1.Heal(magic);
            Console.WriteLine("You have been healed for " + hitpoints + " HP.");
            Console.WriteLine("Now its your turn to counter attack");
            Console.WriteLine("Input your strength stat");

            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = Class1.Attack(strength);
            Console.WriteLine("You have landed a critical attack and dealt " + damage + " HP worth of damage. ");
            Console.ReadLine();

        }

    }
}

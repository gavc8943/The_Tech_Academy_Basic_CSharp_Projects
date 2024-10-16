using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Class1
    {
        // Create 3 methods that take one integer parameter and return an integer
        public static int timesFive(int firstNum)
        {
            int newTotal = firstNum * 5;
            return newTotal;
        }

        public static int plusTen(int secondNum)
        {
            int newTotal1 = secondNum + 10;
            return newTotal1;
        }
        public static int divide2(int thirdNum)
        {
            int newTotal2 = thirdNum / 2;
            return newTotal2;
        }

        ///// Now the model answer for practice and understanding
        // Create 3 methods that take one integer parameter and return an integer

        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }
        public static int Defense(int defense)
        {
            int enemy_str = 7;
            int weapon_mt = 11;
            int triangle_bonus = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (weapon_mt + triangle_bonus) - defense) * crit_coeff;
            return damage;
        }
        public static int Attack(int strength)
        {
            int enemy_def = 4;
            int weapon_mt = 8;
            int triangle_bonus = -1;
            int crit_coeff = 3;
            int damage = (strength + (weapon_mt + triangle_bonus) - enemy_def) * crit_coeff;
            return damage;
        }
    }
}
   

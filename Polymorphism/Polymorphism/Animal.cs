using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }

        public void MakeAnimalSound(Animal animal)
        {
            animal.MakeSound();
        }
    }
}

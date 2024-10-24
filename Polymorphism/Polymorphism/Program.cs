using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {           // 1 method => different implementations
                // 1 Action Different behaviours based on object type
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();



            animal.MakeAnimalSound(animal);
            animal.MakeAnimalSound(dog);
            animal.MakeAnimalSound(cat);
            Console.ReadLine();





        }
    }
}

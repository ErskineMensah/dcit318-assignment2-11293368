using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_MethodOverriding
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();


            // Calling the MakeSound() method on each instances.
            Console.Write("Every animal makes ");
            genericAnimal.MakeSound();


            Console.Write("The sound a Dog makes is ");
            dog.MakeSound();


            Console.Write("The sound a cat makes is ");
            cat.MakeSound();

            Console.ReadKey();
        }
    }
}

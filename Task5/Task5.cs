using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound() 
        {
            Console.WriteLine("Гав!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound() 
        {
            Console.WriteLine("Мяу!");
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.MakeSound();
            cat.MakeSound(); 
        }
    }
}

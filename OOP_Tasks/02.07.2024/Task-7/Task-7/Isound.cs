using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public interface Isound
    {
        void MakeSound();
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Eat();

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }


        public class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }

            public override void Eat()
            {
                Console.WriteLine($"{Name} is eating mulukhiahh.");
            }
            public void WHAT()
            {
                Console.WriteLine($"WHAT THE DOOOGGG DOOOIIINNN!!!!!!");
            }

            public void MakeSound()
            {
                Console.WriteLine($"{Name} says: Woof!");
            }
        }

        public class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }

            public override void Eat()
            {
                Console.WriteLine($"{Name} is eating saneura.");
            }

            public void MakeSound()
            {
                Console.WriteLine($"{Name} says: Meow!");
            }
        }
    }

}

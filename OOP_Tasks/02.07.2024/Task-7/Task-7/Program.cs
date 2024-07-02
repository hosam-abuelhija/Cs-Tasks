using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task7.Animal;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("ajjwa");
            myDog.Eat();
            myDog.Sleep();
            myDog.MakeSound();
            myDog.WHAT();

            Cat myCat = new Cat("sukar");
            myCat.Eat();
            myCat.Sleep();
            myCat.MakeSound();
        }
    }
}

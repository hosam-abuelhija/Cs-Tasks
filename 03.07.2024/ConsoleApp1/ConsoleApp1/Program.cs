using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name;
            int birthYear;
            int currentYear = DateTime.Now.Year;
            Console.Write("Whats Your Name: ");
            var name = Console.ReadLine();
            Console.Write("Year Of Birth: ");
            birthYear = int.Parse(Console.ReadLine());
            string message = $"Hello, {name}. You are {currentYear - birthYear} years old.";
            Console.WriteLine(message);




            //Accessing Individual Characters
            //string text = "Hello, World!";
            //char firstChar = text[0];   // 'H'
            //char lastChar = text[text.Length - 1]; // '!'
            //Console.WriteLine(firstChar); // Output: H
            //Console.WriteLine(lastChar);  // Output: !



            // Substrings
            //string text = "Hello, World!";
            //string hello = text.Substring(0, 5); // "Hello"
            //string world = text.Substring(7, 5); // "World"
            //Console.WriteLine(hello);  // Output: Hello
            //Console.WriteLine(world);  // Output: World



            //String Length
            //string text = "Hello, World!";
            //int length = text.Length; // 13
            //Console.WriteLine(length); // Output: 13




        }
    }
}

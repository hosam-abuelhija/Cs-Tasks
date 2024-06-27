using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////task 1

            //Console.Write("Enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int smaller = (num1 < num2) ? num1 : num2;
            //Console.WriteLine($"The smaller number is: {smaller}");

            ////Task 2
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sign = Math.Sign(number);
            //string signMessage = sign == 1 ? "The sign is +" : sign == -1 ? "The sign is -" : "The number is zero";
            //Console.WriteLine(signMessage);

            ////Task 3
            //Console.Write("Enter the first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int[] nums = { num1, num2, num3 };
            //Array.Sort(nums);
            //Console.WriteLine($"Sorted numbers: {nums[0]}, {nums[1]}, {nums[2]}");

            ////Task 4
            //Console.Write("Enter the first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the third number: ");
            //num3 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the fourth number: ");
            //int num4 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the fifth number: ");
            //int num5 = Convert.ToInt32(Console.ReadLine());
            //nums = new int[] { num1, num2, num3, num4, num5 };
            //int maxNum = nums.Max();
            //Console.WriteLine($"The maximum number is: {maxNum}");

            ////Task 5
            //Console.Write("Enter kilometers per hour: ");
            //double km = Convert.ToDouble(Console.ReadLine());
            //double mile = km * 0.621371192;
            //Console.WriteLine($"{km} kilometers per hour is equal to {mile} miles per hour.");

            ////Task 6
            //Console.Write("Enter hours: ");
            //int hours = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter minutes: ");
            //int minutes = Convert.ToInt32(Console.ReadLine());
            //int totalMinutes = hours * 60 + minutes;
            //Console.WriteLine($"Total: {totalMinutes} minutes.");

            ////Task 7
            //Console.Write("Enter minutes: ");
            //totalMinutes = Convert.ToInt32(Console.ReadLine());
            //hours = totalMinutes / 60;
            //minutes = totalMinutes % 60;
            //Console.WriteLine($"{hours} Hours, {minutes} Minutes");

            ////Task 8
            //string[] sentences = {
            //    "BBQ sauce is the best invintion humans ever made",
            //    "Hello",
            //    "pink floyed is the greatest band ever",
            //    "fried potato is awesome",
            //    "ps is better than xbox"
            //};
            //Console.WriteLine(sentences[0]);
            //Console.WriteLine(sentences[1]);
            //Console.WriteLine(sentences[2]);
            //Console.WriteLine(sentences[3]);
            //Console.WriteLine(sentences[4]);

            //Console.WriteLine(sentences[0].Length);
            //Console.WriteLine(sentences[1].Length);
            //Console.WriteLine(sentences[2].Length);
            //Console.WriteLine(sentences[3].Length);
            //Console.WriteLine(sentences[4].Length);

            int i = 0;
            while (i < 999999999)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}

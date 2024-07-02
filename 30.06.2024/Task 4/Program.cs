using System;


namespace Task_4
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Q1
            Console.WriteLine(Class.ReturnSumAndAverage(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //Q2
            Console.Write("Input number : ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }
            for (int i = 1; i <= num; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{cube}");
            }

            //Q3
            Console.WriteLine("Years greater than 1950:");
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            Class.GetYears(years);

            //Q4
            Console.Write("Enter age in years: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Class.CalculateAgeInDays(x);


            //Q5
            Person person = new Person();
            Console.WriteLine(person.ShowInfo());

            Person person2 = new Person(24, "Male", "hosam", "hosam.gmail.com", "12345", "0785571654");
            Console.WriteLine(person2.ShowInfo());



        }
    }
}

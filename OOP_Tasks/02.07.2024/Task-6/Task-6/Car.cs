using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string Platenumber { get; set; }
        public string Color { get; set; }

        // Constructor
        public Car(string make, int year, string type, double price, string color, string model, string platenumber)
        {
            Year = year;
            Type = type;
            Price = price;
            Make = make;
            Color = color;
            Model = model;
            Platenumber = platenumber;
        }

        public void DisplayInfo(string make, int year)
        {
            Console.WriteLine($"Car Make: {make}, Year: {year}");
        }

        public void DisplayInfo(string make)
        {
            Console.WriteLine($"Car Make: {make}");
        }

        public virtual void Display()
        {
            Console.WriteLine("Welcome Car");
        }

        public class BMW : Car
        {
            public BMW(string make, int year, string type, double price, string model, string palletNo, string color)
                : base(make, year, type, price, model, palletNo, color)
            {
            }

            public override void Display()
            {
                Console.WriteLine("Welcome BMW");
            }
        }

    }
}

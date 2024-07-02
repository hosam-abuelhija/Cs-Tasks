using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_6.Car;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car("Toyota", 1998, "cupe", 90000, "SUPRA MK4", "14-18314", "Black");
            myCar.DisplayInfo("Toyota", 1998);
            myCar.DisplayInfo("Dodge");
            myCar.Display();


            //BMW myBMW = new BMW("BMW", 1989, "cupe", 50000, "M3", "14-18314", "Blue");
            //myBMW.Display();

            Car myBMW = new BMW("BMW", 1989, "cupe", 50000, "M3", "14-18314", "Blue");
            myBMW.Display();

        }
    }
}

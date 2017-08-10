using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, surfaceArea, height, radius;
            double pi = 3.1415926535897931;
            string userHeightInput, userRadiusInput, 
                askForRadius = "What is the radius of your cylinder in inches?", 
                askForHeight = "What is the height of yur cylinder in inches?";

            Console.WriteLine("This program will determine the volume " +
                "and the surface area of your cylinder ");
            Console.WriteLine("");

            Console.WriteLine(askForHeight);
            userHeightInput = Console.ReadLine();
            height = Convert.ToDouble(userHeightInput);

            Console.WriteLine(askForRadius);
            userRadiusInput = Console.ReadLine();
            radius = Convert.ToDouble(userRadiusInput);

            volume = pi * (radius * radius) * height;
            surfaceArea = 2 * pi * radius * (radius + height);

            Console.WriteLine("The volume of your cylinder is " + volume + " cubic inches");
            Console.WriteLine();

            Console.Write("The surface area or your cylinder is " 
                + surfaceArea + " square inches");


            Console.ReadLine();




        }
    }
}

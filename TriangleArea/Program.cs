using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaOfTriangle, baseOfTriangle, heightOfTraingle ;
            const float oneHalfF = .5F;

            baseOfTriangle = 20.3658;
            heightOfTraingle = 6.52222;

            areaOfTriangle = oneHalfF * (baseOfTriangle * heightOfTraingle);

            Console.WriteLine("The base of the triangle is " + baseOfTriangle + " inches");
            Console.WriteLine("The height of the triangle is " + heightOfTraingle + " inches");
            Console.WriteLine("The area of the triangle is " + areaOfTriangle + " Square Inches");
            Console.ReadLine();

        }
    }
}

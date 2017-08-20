using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndAveOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] min = new int[] { 4, -1000, -7, 13, 12, 15, -8, 45, 90 };

            int currentMin = Int32.MaxValue;
            int total = 0;           

            foreach (int value in min)
            {
                if (currentMin > value)
                    currentMin = value;
            }
            Console.WriteLine("The minimum number in the array is " + currentMin);
            Console.ReadLine();

            int[] ave = new int[] { 4, 51, -7, 13, -99, 1500, -8, 45, 90 };

            foreach (int number in ave)
            {
                total += number;
            }
            Console.WriteLine("The average of the numbers in the array is " + (float)total / ave.Length);
            Console.ReadLine();
        }        
    }
}

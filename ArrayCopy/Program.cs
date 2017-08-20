using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        private static int index;
        private static int firstIndex;

        static void Main(string[] args)
        {
            int[] firstArray = new int[10] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 92 };           
            int[] secondArray = new int[10];

            Console.Write(firstArray[firstIndex] + " ");
            Console.WriteLine();

            for (int firstIndex = 0; firstIndex < firstArray.Length; firstIndex++)
            {
                Console.Write(firstArray[firstIndex] + " ");            
            }
            Console.WriteLine();

                for (int firstIndex = 0; firstIndex < firstArray.Length; firstIndex++)
            {
                secondArray[index] = firstArray[firstIndex];
                Console.Write(secondArray[index] + " ");
            }            
            Console.ReadLine();
        }
    }
}

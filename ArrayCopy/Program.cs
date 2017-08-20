using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        //private static int index;
        //private static int firstIndex;

        static void Main(string[] args)
        {
            int[] firstArray = new int[10] { 1002, 6, 9, 12, 15, 18, 21, 24, 27, 92 };           
            int[] secondArray = new int[firstArray.Length];

            for (int firstIndex = 0; firstIndex < firstArray.Length; firstIndex++)
            {
                Console.Write(firstArray[firstIndex] + " ");            
            }
            Console.WriteLine();

            for (int index = 0; index < firstArray.Length; index++)
            {
                secondArray[index] = firstArray[index];
                Console.Write(secondArray[index] + " ");
            }
            Console.WriteLine();

            secondArray[0] = 5;

            for (int firstIndex = 0; firstIndex < firstArray.Length; firstIndex++)
            {
                Console.Write(firstArray[firstIndex] + " ");
            }
            Console.WriteLine();

            for (int index = 0; index < secondArray.Length; index++)
            {
                Console.Write(secondArray[index] + " ");
            }


                Console.ReadLine();
        }
    }
}

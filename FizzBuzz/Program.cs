using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int count =1; count <  101; count++)
            {
                //int[] newLine = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                    continue;
                }               
                if (count % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                if(count % 5 == 0)
                {
                    Console.Write("Buzz ");
                }                
                else
                {
                    Console.Write(count + " ");
                }
            }
            Console.ReadLine();
        }
    }
}

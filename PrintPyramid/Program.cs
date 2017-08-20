using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for(int row = 0; row < 5; row++)
            {
                for(int column = 0; column < 10; column++)
                
                    Console.Write("*");
                    Console.WriteLine();                
            }
            Console.ReadLine();

            for(int row = 0; row < 10; row++)
            {
                for (int column = 0; column < row + 1; column++) 

                    Console.Write("*");
                    Console.WriteLine();
            }
            Console.ReadLine();*/

            for (int row = 0; row < 5; row++)
            {
                for (int space = 0; space < 5 - row -1; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < 2 * row + 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                
            }
            Console.ReadLine();
        }   

    }
}

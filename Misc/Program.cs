using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstOperand;
            string secondOperand;
            double firstNumberToCheck;
            double secondNumberToCheck;


            Console.WriteLine("Program to determine if your " +
                "muliplication should be positive or negative: ");
            Console.WriteLine("Enter the first number to be multiplied");
            firstOperand = Console.ReadLine();
            Console.WriteLine("Enter the second number to multiplied");
            secondOperand = Console.ReadLine();

            firstNumberToCheck = Convert.ToDouble(firstOperand);
            secondNumberToCheck = Convert.ToDouble(secondOperand);
            //int i = 0;

           // do
           // {
                if (firstNumberToCheck > 0 && secondNumberToCheck > 0 || firstNumberToCheck < 0 && secondNumberToCheck < 0)
                {
                    Console.WriteLine("Your multiplication result will be Positive; ");
                }
                else
                {
                    Console.WriteLine("Your multiplication result will be Negative; ");
                }
                //i = i++;

           // }

           // while (i < 5);
                
                Console.ReadLine();


            




        }
    }
}

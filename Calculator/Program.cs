using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {

        string firstNumber, secondNumber;
        double operandOne, operandTwo;
        double addition, subtraction, multiplication, division, modulo, exponent;
        char add = '+', sub = '-', mul = '*', div = '/', mod = '%', exp = '^';

            Console.WriteLine("This program will do Calculations for you ");
            Console.WriteLine("Type in your first number: ");
            firstNumber = Console.ReadLine();
            operandOne = Convert.ToDouble(firstNumber);

            Console.WriteLine("Type in your second number ");
            secondNumber = Console.ReadLine();
            operandTwo = Convert.ToDouble(secondNumber);

            Console.WriteLine("Type in the calculation you desire, " +
                add + " for addition, " + sub + " for subtraction, " + mul + 
                " for multiplication, " + div + " for division, " + mod + 
                " for remainder, " + exp + " for exponent. ");




            //Console.WriteLine("This program will do Calculations for you ");

            Console.ReadLine();
        }
    }
}

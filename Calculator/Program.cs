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

        string firstNumber, secondNumber, operater;
        double operandOne, operandTwo;
        char add = '+', sub = '-', mul = '*', div = '/', mod = '%', exp = '^';
        char input;

            Console.WriteLine("This program will do Calculations for you ");
            Console.WriteLine("If you want and exponent the second number should be the power");
            Console.WriteLine("you want the first number raised to  ");
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

            operater = Console.ReadLine();
            input = Convert.ToChar(operater);

            switch (input)
            {
                case '+':
                    Console.WriteLine(operandOne + " Plus " + operandTwo + " = " + (operandOne + operandTwo));
                    break;

                case '-':
                    Console.WriteLine(operandOne + " Minus " + operandTwo + " = " + (operandOne - operandTwo));
                    break;

                case '*':
                    Console.WriteLine(operandOne + " Times " + operandTwo + " = " + (operandOne * operandTwo));
                    break;

                case '/':
                    if(operandTwo == 0)
                    {
                        Console.Write("You can not divide by zero ");
                        break;
                    }
                    Console.WriteLine(operandOne + " Divided by " + operandTwo + " = " + (operandOne / operandTwo));
                    break;

                case '%':
                    Console.WriteLine("Remainder of " + operandOne + " Divided by " + operandTwo + " = " + (operandOne % operandTwo));
                    break;

                case '^':
                    Console.WriteLine(operandOne + " To the Power of " + operandTwo + " = " + (operandOne = Math.Pow(operandOne, operandTwo)));
                    break;
                    default:                
                    Console.WriteLine(" Something went wrong ");
                    break;               
            }
            Console.ReadLine();
        }
    }
}

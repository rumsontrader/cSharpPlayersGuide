﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsEnum
{
    enum MonthsOfYear
    {
        January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7,
        August = 8, September = 9, October = 10, November = 11, December = 12 
    }
    
    class Program
    {
    
        static void Main(string[] args)
        {
            MonthsOfYear thisMonth;
            string input;

            Console.WriteLine("Enter a number between 1 and 12");
            input = Console.ReadLine();
            int convertedInput = Convert.ToInt32(input);

            if(convertedInput >0 && convertedInput < 13)
            {
                thisMonth = (MonthsOfYear)convertedInput;
                Console.WriteLine($"You picked {thisMonth} as your month ");
            }

            Console.ReadLine();
            
        }
    }
}

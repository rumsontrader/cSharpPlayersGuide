using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumbertoCalculateRemainder;
            int secondNumbertoCalculateRemainder;
            int quotient;
            int remainder;

            firstNumbertoCalculateRemainder = 1205;
            secondNumbertoCalculateRemainder = 12;

            quotient = firstNumbertoCalculateRemainder / secondNumbertoCalculateRemainder;
            remainder = firstNumbertoCalculateRemainder % secondNumbertoCalculateRemainder;

            Console.WriteLine(firstNumbertoCalculateRemainder + "/" + secondNumbertoCalculateRemainder +
                " is " + quotient + " remainder " + remainder);
            Console.ReadLine();
        }
    }
}

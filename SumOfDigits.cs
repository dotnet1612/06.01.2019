using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            // read number until number between 1-1000
            int a = ReadNumberBetween1_1000();
            int b = ReadNumberBetween1_1000();
            int c = ReadNumberBetween1_1000();

            // calculate sum of digits
            //int sum_a = SumDigits(a);
            //int sum_b = SumDigits(b);
            //int sum_c = SumDigits(c);


            // check if sum of digits is larger than 15
            // if threee numbers sum of digits larger than 15 -> print sum a + b + c
            // else print "not all threee sum of digits is larger than 15"
            if (SumDigits(a) > 15 && SumDigits(b) > 15 && SumDigits(c) > 15)
            {
                Console.WriteLine($"All bigger than 15, sum = {a + b + c}");
            }
            else
            {
                Console.WriteLine("Not all threee numbers sum of digits is larger than 15");
            }
        }

        private static int SumDigits(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum = sum + a % 10;
                a = a / 10;
            }

            return a;
        }

        private static int ReadNumberBetween1_1000()
        {
            int a;
            do
            {
                Console.Write("Enter number between 1-1000: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a < 1 || a > 1000);

            return a;
        }
    }
}

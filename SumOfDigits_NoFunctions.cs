using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Enter number between 1-1000: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a < 1 || a > 1000);

            int b;
            do
            {
                Console.Write("Enter number between 1-1000: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b < 1 || b > 1000);

            int c;
            do
            {
                Console.Write("Enter number between 1-1000: ");
                c = Convert.ToInt32(Console.ReadLine());
            }
            while (c < 1 || c > 1000);


            int sum_a = 0;
            int temp = a;
            while (temp > 0)
            {
                sum_a = sum_a + temp % 10;
                temp = temp / 10;
            }

            int sum_b = 0;
            temp = b;
            while (temp > 0)
            {
                sum_b = sum_b + temp % 10;
                temp = temp / 10;
            }

            int sum_c = 0;
            temp = c;
            while (temp > 0)
            {
                sum_c = sum_c + temp % 10;
                temp = temp / 10;
            }

            if (sum_a > 15 && sum_b > 15 && sum_c > 15)
            {
                Console.WriteLine($"All bigger than 15, sum = {a + b + c}");
            }
            else
            {
                Console.WriteLine("Not all threee numbers sum of digits is larger than 15");
            }
        }
    }
}

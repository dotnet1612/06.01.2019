using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0601
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int primeNumber = Convert.ToInt32(Console.ReadLine());

            if (PrimeNumber(primeNumber))
            {
                Console.WriteLine($"{primeNumber} is Prime!");
            }
            else
            {
                Console.WriteLine($"{primeNumber} is NOT Prime!");
            }

            int num;
            do
            {
                Console.WriteLine("Enter two digits number");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (CheckIsTwoDigitNumber(num) == false);
        }

        private static bool CheckIsTwoDigitNumber(int num)
        {
            if (num > 9 && num < 100)
            {
                return true;
            }
            else
            {
                return false;
            }

            // one-liner:
            //return (num > 9 && num < 100);
        }

        private static bool PrimeNumber(int primeNumber)
        {
            int m;

            // input number
            primeNumber = Convert.ToInt32(Console.ReadLine());

            // check if number is prime?
            m = 2;
            while (primeNumber % m != 0)
            {
                m++;
            }

            if (m < primeNumber)
            {
                return false;
            }
            else
            {
                return true;
            }

            //return m >= primeNumber;
        }
    }
}

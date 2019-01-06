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
            /*
            int x = GetRandomNumber();

            Console.WriteLine(x);

            bool isZugiNumber = x % 2 == 0;
            //bool1 = true;
            //bool1 = false;

            Console.WriteLine(isZugiNumber);

            if (isZugiNumber) // same as if (isZugiNumber == true)
            {
                Console.WriteLine("Zugi");
            }
            else
            {
                Console.WriteLine("E zugi");
            }
            */

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            bool is_zugi = CheckIfZugi(num1);
            Console.WriteLine($"{num1} is zugi? {is_zugi}");

            Console.WriteLine($"{num1} is zugi? { CheckIfZugi(num1) }");

            if (CheckIfZugi(num1))
            {
                Console.WriteLine("Zugi");
            }
            else
            {
                Console.WriteLine("E Zugi");
            }

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

        private static bool CheckIfZugi(int num1)
        {
            if (num1 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetRandomNumber()
        {
            Random r = new Random();
            int number = r.Next(101);

            return number;

        }
    }
}

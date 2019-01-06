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

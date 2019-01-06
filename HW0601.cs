using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0601
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1();

            Question2();

            Question3();

            Question4();
        }

        private static void Question4()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int shurot = size / 2 + 1;
            int space = size / 2;
            int stars = 1;

            for (int i = 1; i <= shurot; i++)
            {
                // print spaces
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(' ');
                }

                // print stars
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();

                // update counters
                space--;
                stars = stars + 2;
            }
        }

        private static void Question3()
        {
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void Question2()
        {
            // input numbner of students
            int students = Convert.ToInt32(Console.ReadLine());

            // divide to 100, 30, 10 + print
            int number100 = students / 100; // number of 100 in class 
            //students = students - number100 * 100;
            students = students % 100;

            int number30 = students / 30; // number of 100 in class 
            students = students % 30;

            int number10 = students / 10; // number of 100 in class 
            students = students % 10;

            // print how much in class
            Console.WriteLine($"classes of 100 {number100}");
            Console.WriteLine($"classes of 30 {number30}");
            Console.WriteLine($"classes of 10 {number10}");

            // print how many left?
            Console.WriteLine($"stduents went home {students}");
        }

        private static void Question1()
        {
            int a, m;

            do
            {
                // input number
                a = Convert.ToInt32(Console.ReadLine());

                // check if number is prime?
                m = 2;
                while (a % m != 0)
                {
                    m++;
                }

                if (m < a)
                {
                    Console.WriteLine($"{a} is NOT prime");
                }
                else
                {
                    Console.WriteLine($"{a} is prime indeed");
                }

            }
            // while number is Prime
            while (a == m);
        }
    }
}

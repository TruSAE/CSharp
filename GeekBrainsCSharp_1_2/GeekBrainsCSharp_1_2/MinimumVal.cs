using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCSharp_1_2
{
    class MinimumVal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число:");
            int c = Convert.ToInt32(Console.ReadLine());

            MinimumOfThree(a, b, c);
            Console.ReadKey();
        }

        private static void MinimumOfThree(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                Console.WriteLine($"Минимальное введенное число - {a}");
            }
            else
            {
                if (b <= a && b <= c)
                {
                    Console.WriteLine($"Минимальное введенное число - {b}");
                }
                else
                {
                    if (c <= b && c <= a)
                    {
                        Console.WriteLine($"Минимальное введенное число - {c}");
                    }
                }
            }
        }
    }
}

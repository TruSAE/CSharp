using System;

// Трус Алексей
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

namespace Lesson_1_ExchValMethod
{
    class ExchValWuthoutTemp
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое первое число");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое второе число");
            int y = Convert.ToInt32(Console.ReadLine());

            x = x + y;
            y = y - x;
            y = -y;
            x = x - y;

            Console.WriteLine("Ваши числа поменялись местами");
            Console.WriteLine(x + " " + y);
            // Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}

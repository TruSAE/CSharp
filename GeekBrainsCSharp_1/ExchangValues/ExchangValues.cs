using System;

// Трус Алексей
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

namespace ExchangValues
{
    class ExchangValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение");
            var A = Console.ReadLine();
            Console.WriteLine("Вы ввели    " + A);
            
            Console.WriteLine("Введите второе значение    ");
            var B = Console.ReadLine();
            Console.WriteLine("Вы ввели    " + B);

            var C = A;
            A = B;
            B = C;

            Console.WriteLine("После обмена значения на первом месте мы имеем:    " + A);
            Console.WriteLine("После обмена значения на втором месте мы имеем:    " + B);

            Console.ReadKey();


        }
    }
}

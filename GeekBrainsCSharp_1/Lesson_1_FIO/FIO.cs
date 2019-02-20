using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Трус Алексей
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int
//  x, int y).

namespace Lesson_1_FIO
{
    class FIO
    {
        static void Main(string[] args)
        {
            string name, surname, sity;
            
            Console.WriteLine("Введите Ваше имя");
            name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            surname = Console.ReadLine();

            Console.WriteLine("Введите город проживания");
            sity = Console.ReadLine();

            Console.SetCursorPosition(200, 200);
            Console.Write(surname, name, sity);

            Console.ReadKey();
        }
    }
}

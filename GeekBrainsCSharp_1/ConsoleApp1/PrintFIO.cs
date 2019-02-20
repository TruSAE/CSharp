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
            name = "Алексей";
            surname = "Трус";
            sity = "Москве";

            Console.SetCursorPosition(50, 20);
            
            string print = $"Меня зовут {surname}  {name}, я живу в {sity}";
            Console.WriteLine(print);

            Console.ReadKey();
        }
    }
}

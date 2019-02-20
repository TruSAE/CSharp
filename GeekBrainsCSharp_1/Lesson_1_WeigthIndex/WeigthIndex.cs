using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
//I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

namespace Lesson_1_WeigthIndex
{
    class WeigthIndex
    {
        static void Main(string[] args)
        {
            double h, m;

            Console.WriteLine("Введите свой рост в формате метры,сантиметры");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите свой вес в килограммах");
            m = Convert.ToDouble(Console.ReadLine());

            var WeigthIndex = m / (Math.Pow(h, 2));

            string output = $"Ваш индекс массы тела равен {WeigthIndex:f2}";
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}

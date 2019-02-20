using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Трус Алексей
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
//y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
//используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
//метода.


namespace Graphic
{
    class Graphic
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            Console.WriteLine("ВВедите значение Х1");
            x1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("ВВедите значение Y1");
            y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("ВВедите значение Х2");
            x2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("ВВедите значение Y2");
            y2 = Double.Parse(Console.ReadLine());

            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            string output = $"{r:f2}";
            Console.WriteLine("Расстояние между точками равно:  " + output);

            Console.ReadKey();

        }
    }
}

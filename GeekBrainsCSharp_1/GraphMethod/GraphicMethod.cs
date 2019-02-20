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

namespace GraphMethod
{
    class GraphicMethod
    {
        static double GraphMethod(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.Write("Х1= ");
            var x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y1= ");
            var y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Х2= ");
            var x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y2= ");
            var y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{GraphMethod(x1, y1, x2, y2):f2}");

            Console.ReadKey();
        }
    }
}

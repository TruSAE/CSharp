using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Трус Алексей
// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
// рост, вес). В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// b) используя форматированный вывод;
// c) используя вывод со знаком $.
namespace GeekBrainsCSharp_1
{
    class Form
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age; 
            double growth, weigth;

            Console.WriteLine("Введите Ваше имя");
            name = Console.ReadLine();
            
            Console.WriteLine("Введите фамилию");
            surname = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст в годах");
            age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой рост в формате метры,сантиметры");
            growth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите свой вес в килограммах");
            weigth = Convert.ToDouble(Console.ReadLine());
            // a)
            Console.WriteLine("Уважаемый " + surname + " " + name + ", " + "Ваш возраст " + age + ", " + "рост " + growth + " см, " + "вес " + weigth + "кг");

            //b)
            Console.WriteLine("Уважаемый {0}, {1}, Ваш возраст {2}, рост {3}см, вес {4}кг ", surname, name, age, growth, weigth);

            //c
            string output = $"Уважаемый {surname}  {name}, Ваш возраст {age}, рост {growth} см, вес {weigth}кг ";
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
// рост, вес). В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.
namespace GeekBrainsCSharp_1
{
    class Form
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age, growth, weigth;

            Console.WriteLine("Введите Ваше имя");
            name = Console.ReadLine();
            
            Console.WriteLine("Введите фамилию");
            surname = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст в годах");
            age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой рост в сантиметрах");
            growth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой вес в килограммах");
            weigth = Int32.Parse(Console.ReadLine());
            // a)
            Console.WriteLine("Уважаемый " + surname + " " + name + ", " + "Ваш возраст " + age + "лет" + ", " + "рост " + growth + " см, " + "вес " + weigth + "кг");

            //b)
            Console.WriteLine("Уважаемый {0}, {1}, Ваш возраст {2} лет, рост {3}см, вес {4}кг ", surname, name, age, growth, weigth);

            //c
            string output = $"Уважаемый {surname}  {name}, Ваш возраст {age} лет, рост {growth} см, вес {weigth}кг ";
            Console.WriteLine(output);


            Console.ReadKey();


            
        }
    }
}

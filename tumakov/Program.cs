using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("лабораторная 2.1");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

            Console.WriteLine("лабораторная 2.2");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (y == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else
            {
                Console.WriteLine($"{x / y}");
            }

            Console.WriteLine("Домашнее задание 2.1");
            Console.WriteLine("Введите букву: ");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'z')
            {
                Console.WriteLine('a');
            }

            else
            {
                Console.WriteLine((char)(letter + 1));
            }

            Console.WriteLine("Домашнее задание 2.2");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля, корней нет");
            }
            else
            {
                if (D == 0)
                {
                    double res1 = -b / (2 * a);
                    Console.WriteLine("Дискриминант равен нулю, один корень: " + res1);
                }
                else
                {
                    double res2 = (-b - Math.Pow(D, 0.5)) / (2 * a);
                    double res3 = (-b + Math.Pow(D, 0.5)) / (2 * a);
                    Console.WriteLine("Первый корень равен " + res2 + "Второй корень равен" + res3);
                }
            }
        }
    }
}

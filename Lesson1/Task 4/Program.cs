using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Меняем местами значения переменных 2-мя способами

namespace Task_4
{
    internal class Program
    {
        static void Revers(double a, double b)
        {
            double c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine($" Поменяли местами числа a и b. Теперь" +
                $"\n a = {a}" +
                $"\n b = {b}");

        }

        static void Revers2(double a, double b)
        {
            b = a + b;
            a = b - a;
            b = b - a;

            Console.WriteLine($" Поменяли местами числа a и b без использования третьей переменной. Теперь:" +
                $"\n a = {a}" +
                $"\n b = {b}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine(" Введите число а");
            Console.Write(" a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Введите число b");
            Console.Write(" b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Revers(a, b);
            Revers2(a, b);
            Console.ReadKey();

            
        }
    }
}

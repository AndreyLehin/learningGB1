using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Расстояние между точками с методом и без

namespace Task_3
{
    internal class Program
    {
        static double Distance(int x1, int y1, int x2, int y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X1 ");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y1 ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату X2 ");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y2 ");
            int y2 = int.Parse(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками равно");
            Console.WriteLine("{0:F2}",r);

            Console.WriteLine("Расстояние между точками равно (вычисления в методе)");
            Console.WriteLine("{0:F2}",Distance(x1,y1,x2,y2));
            Console.ReadKey();

            
        }
    }
}

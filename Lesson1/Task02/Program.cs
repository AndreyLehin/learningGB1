using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Индекс массы тела

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш РОСТ в сантиметрах");
            string Height = Console.ReadLine();

            Console.WriteLine("Введите Ваш ВЕС в килограммах");
            string Weight = Console.ReadLine();

            double h = Convert.ToDouble(Height);
            double w = Convert.ToDouble(Weight);
            double IndexM = w *10000 / (h * h);
          
            Console.WriteLine($"Ваш индекс массы тела равен ");
            Console.WriteLine("{0:F}", IndexM);
            Console.ReadKey();
        }
    }
}

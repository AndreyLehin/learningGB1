 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Выводит на экран имя и город  в определенное место экрана

namespace Task_5
{
    internal class Program
    {
         
        static void Print (string msq, string town, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вас зовут "+msq+" ");

            Console.SetCursorPosition(x, y+1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Вы живете в городе  {town}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут? ");
            string msq = Console.ReadLine();

            Console.WriteLine("Где Вы живете? ");
            string town = Console.ReadLine();

            Console.WriteLine("Введите координаты вывода");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());  

            Print(msq, town, x, y);
            Console.ReadKey();
        }
    }
}

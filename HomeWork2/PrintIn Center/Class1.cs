using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPrintInCenter
{
    public class PrintInCenter
    {
        /// <summary>
        /// Устанавливает курсор в центр экрана
        /// </summary>
        /// <param name="text">ваш текст</param>
        public static void CursorOnCenter(string text)

        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2-10, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);

        }
    }
}

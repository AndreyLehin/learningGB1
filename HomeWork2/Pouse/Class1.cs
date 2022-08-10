using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pause
{
    public class PauseMy
    {
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу, чтобы начать");
            Console.ReadKey();
            Console.Clear();
            //Console.SetCursorPosition(0, 0);
        }
    }
}

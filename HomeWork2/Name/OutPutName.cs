﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    public class OutPutName
    {

        /// <summary>
        /// Вывод информации о студенте
        /// </summary>
        /// <param name="homeworkNamber">номер домашней работы</param>
        /// <param name="fio">имя студента</param>
        public static void PrintInfo(int homeworkNamber)
        {
            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================================");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine($"Домашнее задание номер: {homeworkNamber}");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("Студент: Легин Андрей Александрович");
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("Беларусь. г. Солигорск");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine();
            //Console.WriteLine();

        }
    }
}

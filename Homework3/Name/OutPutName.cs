using System;
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

           

        }

        /// <summary>
        /// Устанавливает курсор в центр экрана
        /// </summary>
        /// <param name="text">ваш текст</param>
        public static void CursorOnCenter(string text)

        {
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            //Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2 - 10, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);

        }


        /// <summary>
        /// Пауза до нажатия на любую клавишу
        /// </summary>
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу:");
            Console.ReadKey();
            Console.Clear();
        }



        /// <summary>
        /// Проверка введеного значения на (int) и возврат значения
        /// </summary>
        /// <param name="message">информация о вводимом значении</param>
        /// <returns></returns>
        public static int Numbers(string message)
        {
            int x;
            string s;
            bool flag;
            do
            {

                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);

            }
            while (!flag);
            return x;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name;
using Pause;
using TextPrintInCenter;

namespace Tasks
{
    internal class Program
    { 
        
        static void Main(string[] args)
        {
            //Console.SetCursorPosition(Console.WindowWidth -  / 2, Console.WindowHeight / 2 - 1);
            OutPutName.PrintInfo(2);
            PauseMy.Pause();
            Console.Clear();

            


            //Задача 1. Определить меньше из 3-х чисел.

            PrintInCenter.CursorOnCenter("Задача 1.Определить меньшее из 3 - х чисел.");
            PauseMy.Pause();        
            
            Console.WriteLine("Введите три числа ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Меньшее число  {MinVolue(a,b,c)}");
            


            //Задача 2. Подсчет количества цифр


            PrintInCenter.CursorOnCenter("Задача 2. Посчет количества цифр");
            PauseMy.Pause();

            Console.WriteLine("Введите число");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"В этом числе  {NamberOfDigit(d)} цифр");
            

            // Задача 3. Подсчет суммы положительных и четных чисел


            PrintInCenter.CursorOnCenter("Задача 3. Подсчет суммы положительных и четных чисел");
            PauseMy.Pause();

            int Summ = SummPositivNumber();
            Console.WriteLine($"Сумма чисел {Summ}" );


            // Задача 4. Логин и пароль


            PrintInCenter.CursorOnCenter("Задача 4. Логин и пароль");
            PauseMy.Pause();

            string log, pass, output;
            int p = 0;
            do
            {
                Console.WriteLine("Введите логин");
                log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                pass = Console.ReadLine();

                bool k = Check(log, pass);

                if (k == true)
                {
                    output = "Пароль введен верно!";
                    break;

                }
                else
                {

                    p++;

                    Console.WriteLine("Не верны логин или пароль");
                    Console.WriteLine($"осталось {3-p} попыток");
                    Console.WriteLine();
                    output = "Вы вообще не знаете пароль или логин не верный";


                }
            }
            while (p < 3);
            Console.WriteLine();
            Console.WriteLine( output);



            // Задача 5. Индекс массы тела


            PrintInCenter.CursorOnCenter("Задача 5. Индекс массы тела");
            PauseMy.Pause();

            double h = 0;
            double w = 0;
            int l = 0;  

            double ind = Index(ref h,ref  w);

            if (ind < 25 && ind > 18.5) l = 0;

            if (ind < 18.5) l = 1;

            if (ind >25) l = 2;
            

            Normal(ind,ref w, ref h, ref l);




            // Задача 6. Подсчет хороших чисел

            PrintInCenter.CursorOnCenter("Задача 6. Подсчет хороших чисел");
            PauseMy.Pause();
            DateTime start = DateTime.Now;
            Console.WriteLine(start.ToString());

            int good = IsGoodValue();

            DateTime end = DateTime.Now;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Хороших чисел {good}, время подсчета {end-start}");

            PauseMy.Pause();










        }

        /// <summary>
        /// определяет меньшее из трех чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int MinVolue(int a, int b, int c)
        {
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            return min;
        }

        /// <summary>
        /// определяет количество цифр в числе
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int NamberOfDigit(int a)
        {
            int count = 0;
            do
            {
                count++;
                a = a / 10;

            }
            while (a > 0);
            return count;

        }


        /// <summary>
        /// Подсчет суммы положительных и четных чисел
        /// </summary>
        /// <returns></returns>
        static int SummPositivNumber()
        {
            int summ = 0;
            int q;

            do
            {
                Console.WriteLine("Введите число. Число 0 конец ввода. ");
                q = int.Parse(Console.ReadLine());
                if (q % 2 == 0 && q > 0)
                {
                    summ = summ + q;
                    Console.WriteLine($"Сумма чисел равна  {summ}");
                }
                else
                {
                    Console.WriteLine($"Сумма не изменилась и равна {summ}");
                }
                Console.WriteLine();
            }
            while (q != 0);
            return summ;



        }

        /// <summary>
        /// Проверка пароля и логина
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static bool Check( string login, string password)
        {
            if (login == null || password == null)
            {
                Console.WriteLine("Вы не все параметры ввели");
                return false;
            }
            if (login =="root" && password == "GeekBrains")
            {
                return true;
            }
            else return false;
        }



        /// <summary>
        /// Расчет массы тела
        /// </summary>
        /// <param name="h"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        static double Index(ref double h, ref double w)
        {
            Console.WriteLine("Введите Ваш РОСТ в сантиметрах");
            string Height = Console.ReadLine();

            Console.WriteLine("Введите Ваш ВЕС в килограммах");
            string Weight = Console.ReadLine();


            h = Convert.ToDouble(Height);
            w = Convert.ToDouble(Weight);
            double IndexM = w * 10000 / (h * h);
            Console.WriteLine(IndexM);
            return IndexM;


        }

        /// <summary>
        /// Рекомендации по массе тела
        /// </summary>
        /// <param name="Index"></param>
        /// <param name="w"></param>
        /// <param name="l"></param>
        static void Normal(double Index,ref double w, ref double h, ref int l)
        {
            double k;
            switch(l)
            {
                case 0:
                    Console.WriteLine("Изменять вес не нужно");
                    break;
                case 1:

                    k = 18.5 * h * h /10000 - w;
                    Console.WriteLine($"Нужно набрать хотя бы {k} килограмм");
                    break;
                case 2:
                    k = w - 25 * h * h /10000;
                    Console.WriteLine($"Нужно сбросить хотя бы {k} килограмм");
                    break;

            }
        }


        /// <summary>
        /// Подсчет хороших чисел
        /// </summary>
        /// <returns></returns>
        static int IsGoodValue()
        {

            int result = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                int summ = 0;
                
                int r = i;
                do
                {
                    
                    int b = r % 10;
                    summ = summ + b;
                    r = r / 10;
                    
                }
                while (r > 0);

               
                if (i%summ  == 0)
                {
                    result++;
                   
                }

            }

            return result;

        }



    }
}



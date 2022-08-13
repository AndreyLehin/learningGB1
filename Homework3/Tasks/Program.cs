using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name;


namespace Tasks

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            OutPutName.PrintInfo(3);
            OutPutName.Pause();
            Console.Clear();


            // Задача 1. Структура и класс комплексного числа

            OutPutName.CursorOnCenter("Задача 1. Структура и класс комплексного числа");
            OutPutName.Pause();

            Complex complex1, complex2;
            Console.WriteLine("Введите комплексное число");
            complex1.re = double.Parse(Console.ReadLine());
            complex1.im = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе комплексное число");
            complex2.re = double.Parse(Console.ReadLine());
            complex2.im = double.Parse(Console.ReadLine());

            Complex result1 = complex1.Minus(complex2);
            Console.WriteLine($"Разность чисел (структура) равна:  {result1.ToString()}");

            ComplexClass complexClass1 = new ComplexClass();
            ComplexClass complexClass2 = new ComplexClass();

            complexClass1.im = complex1.im;
            complexClass1.re = complex1.re;
            complexClass2.im = complex2.im;
            complexClass2.re = complex2.re;


            ComplexClass result2 = complexClass1.Minus(complexClass2);
            Console.WriteLine($"Разность чисел (класс) равна:  {result2.ToString()}");
            ComplexClass result3 = complexClass1.Multiply(complexClass2);
            Console.WriteLine($"Произведение чисел (класс) равно:  {result3.ToString()}");

            string message = "Если нужно сделать вычитание, нажмите 1\n Если умножение, нажмите 2";
            bool r = false;
            do
            {
                
                int q = OutPutName.Numbers(message);

                r = ComplexClass.DoSomething(q, result2, result3);
                
            }
            while (!r );



            //Задача 2. Считаем сумму нечетных положительных чисел.


            OutPutName.Pause();
            OutPutName.CursorOnCenter("Задача 2. Считаем сумму нечетных положительных чисел. Цифра 0 - конец");
            OutPutName.Pause();


            string message2 = "введите число";
            int summ = 0;
            int e = 0;

            do
            {
                e = OutPutName.Numbers(message2);
                summ = SummNambers(e, summ);
                Console.WriteLine($"Вы ввели число {e}, сумма нечетных положительных чисел равна {summ}");


            }
            while (e!= 0);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine($"Сумма чисел равна  {summ}");
            OutPutName.Pause();
        }
        // КОНЕЦ




        /// <summary>
        /// Структура уомплексного числа с методом вычитания
        /// </summary>
        struct Complex
        {
            public double im;
            public double re;

            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

        public class ComplexClass
        {
            public double im;
            public double re;

            public ComplexClass Minus(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public ComplexClass Multiply(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = im * x.im;
                y.re = re * x.re;
                return y;

            }

            public string ToString()
            {
                return re + "+" + im + "i";
            }


            /// <summary>
            /// Метод выводит результат вычислений комплексных чисел
            /// </summary>
            /// <param name="q">выбор действий 1 или 2</param>
            /// <param name="w">результат вычитания</param>
            /// <param name="e">результат умножения</param>
            public static  bool DoSomething(int q, ComplexClass w, ComplexClass e)
            {
                switch (q)
                {
                    case 1:
                        Console.WriteLine($"Разность чисел (класс) равна:  {w.ToString() }");
                        return true;
                    case 2:
                        Console.WriteLine($"Произведение чисел (класс) равно:  {e.ToString()}");
                        return true;
                    default:
                        Console.WriteLine(" Вы ввели не верное число");
                        return false;



                }

            }

            


            
        }
        /// <summary>
        /// проверяет и суммирует
        /// </summary>
        /// <param name="n"></param>
        /// <param name="summ"></param>
        /// <returns></returns>
        public static int SummNambers(int n, int summ)
        {
            if (n > 0 && n % 2 !=0)
                summ = summ + n;
            return summ;
        }
    }
}

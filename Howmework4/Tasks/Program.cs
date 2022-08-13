using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name;
using System.IO;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OutPutName.PrintInfo(3);
            OutPutName.Pause();
            Console.Clear();


            // Задача 1. Класс для работы с массивом.

            OutPutName.CursorOnCenter("Задача 1. Класс для работы с массивом.");
            OutPutName.Pause();

            // Создаем определенный массив

            Console.WriteLine("Введите число - размер массива");
            int n =int.Parse( Console.ReadLine());

            Console.WriteLine("Введите число - минимальное значение массива");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число - шаг заполнения массива");
            int step = int.Parse(Console.ReadLine());

            //Создаем массив и выводим в одну строку
            int[]arr1 = new int[n];
            arr1 = WorkWithArray.Special( n, min, step);
            WorkWithArray.PrintArray(arr1);
            OutPutName.Pause();

            //Подсчитываем сумму значений элементов рандомного массива
            Console.WriteLine($" Рандомный массив:");
            int[] arr2;
            arr2 = WorkWithArray.RandomArrayAll();
            WorkWithArray.PrintArray(arr2);
            int summ = WorkWithArray.Summ(arr2);
            Console.WriteLine($"  Сумма элементов массива равна: {summ}");


            //Меняем местами значения массива
            int [] arr3;
            arr3 = WorkWithArray.Invers(arr2);
            Console.WriteLine($"  Инверсия массива:");
            WorkWithArray.PrintArray(arr3);


            //Умножаем каждое значение массива на определенное число
            Console.WriteLine("Введите число, на которое будет умножен последний массив");
            int u = int.Parse( Console.ReadLine());
            int []arr4;
            arr4 = WorkWithArray.Multi(arr3, u);
            Console.WriteLine($"Возвращаем произведение элементов массива на число {u} методом Multi");
            WorkWithArray.PrintArray(arr4);


            //Подсчитываем колличество максимальных цифр рандомного массива
            Console.WriteLine($" Рандомный массив:");
            int[] arr5;
            arr5 = WorkWithArray.RandomArray(30,1,10);
            WorkWithArray.PrintArray(arr5);
            int count;
            count = WorkWithArray.MaxCount(arr5);
            Console.WriteLine("Возвращаем количество максимальных элементов последнего массива");
            Console.WriteLine(count);


            OutPutName.Pause();


            // Бонус. Считаем колличество максимальных цифр в массиве и показываем, 
            // что исходный массив не пострадал
            Console.WriteLine($" Рандомный массив (бонус): ");
            int[] arr6;
            arr6 = WorkWithArray.RandomArray(20, 1, 10);
            WorkWithArray.PrintArray(arr6);
            WorkWithArray.HowManyValues(arr6);
            WorkWithArray.PrintArray(arr6);
            OutPutName.Pause();

            
            //Считываем из файла значения и проверяем правильность ввода пароля и логина
            Console.WriteLine("Введите логин и пароль (подсказка: r  и  g)");
            string log = Console.ReadLine();
            string pass = Console.ReadLine();
            string[] arr10;
            arr10 = LoadArrFromFile(AppDomain.CurrentDomain.BaseDirectory + "MyAccount.txt");
            bool enter = Check(arr10,log,pass);
            OutPutName.Pause();

            // Записываем данные из массива в файл
            Console.WriteLine($" Рандомный массив (бонус): ");
            int[] arrOut;
            arrOut = WorkWithArray.RandomArray(20, 1, 10);
            WorkWithArray.PrintArray(arrOut);
            //string[] arr7 = arrOut;
            SaveArrFromFile(AppDomain.CurrentDomain.BaseDirectory + "OutFile.txt", arrOut);
            OutPutName.Pause();



        }


        /// <summary>
        /// Считывание данных их файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static string [] LoadArrFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName);
                string[] arrBuf = new string[1000];
                int count = 0;
                while (!sr.EndOfStream)
                {
                    arrBuf[count] = sr.ReadLine();
                    count++;
                }

                string[] arr01 = new string[count];
                Array.Copy(arrBuf, arr01, count);
                sr.Close();
                return arr01;
            }
            else
                throw new FileNotFoundException(fileName);
        }


        /// <summary>
        /// Проверка на правильность ввода пароля и логина
        /// </summary>
        /// <param name="s"></param>
        /// <param name="log"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool Check(string[]s, string log, string pass)
        {
            if (s[0] == log && s[1] == pass)
            {
                Console.WriteLine("Логин и пароль верны");
                return true;
            }
            else
            {
                Console.WriteLine("Не верный ввод!");
                return false;
            }
        }


        /// <summary>
        /// Записываем данные в файл
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <exception cref="FileNotFoundException"></exception>
        public static void SaveArrFromFile(string fileName, int[]data)
        {
            if (File.Exists(fileName))
            {
                StreamWriter sr = new StreamWriter(fileName);
                //{
                    //sr.AutoFlush = true;
                    int count = data.Length;
                    for (int i = 0; i < count; i++)
                    {
                        sr.Write("{0}", data[i]);
                    }
                    sr.WriteLine("Hello");
                    sr.Close ();
                    
                    Console.WriteLine("Данные записаны");
                //}
            }
            else
                throw new FileNotFoundException(fileName);
        }
    }
}

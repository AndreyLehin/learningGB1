using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    public  class WorkWithArray
    {
        int[] a;
        public void Arr(int n)
        {
            a = new int[n];
        }

        public int Get(int i)
        {
            return a[i];
        }

        public void Set(int i, int vaule)
        {
            a[i] = vaule;
        }

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        

        /// <summary>
        /// суммирует значения массива
        /// </summary>
        public static int Summ(int[]a)
        {
            int summ = 0;
            int n = a.Length;
           
            for (int i = 0; i < n; i++)
            {
                summ = summ + a[i];
            }
            return summ;
        }
            



        /// <summary>
        /// меняет местами значения массива
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] Invers(int[]a)
        {
            int n = a.Length;
            int [] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = a[(n-1) - i];
            }
            return b;
        }


        /// <summary>
        /// Возвращаем новый массив с умноженными значениями на какое-то число
        /// </summary>
        /// <param name="a">массив</param>
        /// <param name="k">число умножения</param>
        /// <returns></returns>
        public static int[] Multi(int[]a, int k)
        {
            int n = a.Length;
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = a[i] * k;
            }
            return b;
        }


        /// <summary>
        /// Подсчитываем количество максимальных цифр
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int MaxCount(int[]a)
        {
            int max = a[0];
            int count = 0;
            int n = a.Length;
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"  Максимальное значение данного массива равно:  {max}");
            for (int i = 0; i < n; i++)
            {
                if (max == a[i])
                {
                    count++;
                }

            }
            return count;
        }


        /// <summary>
        /// Считает количество одинаковых элементов в массиве
        /// </summary>
        /// <param name="a">массив</param>
        /// <returns></returns>
        public static void HowManyValues(int[] a)
        {
            int[] b = new int[a.Length];
            Array.Copy(a, b, a.Length);
            int j;
            int count;
            int m;
            int n = b.Length;
            int c = b[0];
            for (int i = 0; i < n; i++)
            {
                count = 0;
                m = b[i];
                if (i > 0 && b[i] == c)
                {
                    //Console.WriteLine("contineu");
                    continue;
                }
                for ( j = 0; j < n; j++)
                {
                    
                        if (m == b[j])
                        {
                            count++;
                            b[j] = c;
                        }
                    
                    
                }
                Console.WriteLine($"   Значений  {m}  в массиве  {count}");
            }

        }

        /// <summary>
        /// Создание рандомного массива с предельными параметрами извне
        /// </summary>
        /// <param name="n"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int[] RandomArray(int n, int min, int max)
        {
            
            int[] b = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                b[i] = r.Next (min,max);
            }
            return b;
        }

        /// <summary>
        /// Создание рандомного массива с предельными параметрами ВНУТРИ
        /// </summary>
        /// <returns></returns>
        public static int[] RandomArrayAll()
        {
            Random r = new Random();
            int n = r.Next(9, 15);
            int[] b = new int[n];
            int min = r.Next(0, 10);
            int max = r.Next(0, 10);
            
            for (int i = 0; i < n; i++)
            {
                b[i] = r.Next(0, max);
            }
            return b;
        }

        /// <summary>
        /// Создание массива определенного размера, мин зачения и шага заполнения.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="min"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static int[] Special(int n, int min, int step)
        {
            int[] b =new int[n];
            b[0] = min;
            int summ =min;
            for (int i = 1; i < n; i++)
            {
                summ = summ + step;
                b[i] = summ;
            }
            return b;
        }


        /// <summary>
        /// Вывод массива в одну строку
        /// </summary>
        /// <param name="a"></param>
        public static void PrintArray(int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"   {a[i]}");
            }
            Console.WriteLine();

        }

        //public static string Word()
       // {
       //     char[] sim = "qwertyuiopasdfghjklzxcvbnm".ToCharArray;
       //
       // }

    }

}

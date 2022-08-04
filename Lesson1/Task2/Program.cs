using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//    Анкета

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите Ваше ИМЯ ");
            string Name = Console.ReadLine();

            Console.WriteLine("Введите Вашу ФАМИЛИЮ");
            string Surname = Console.ReadLine();

            Console.WriteLine("Введите Ваш ВОЗРАСТ ");
            string Age = Console.ReadLine();

            Console.WriteLine("Введите Ваш РОСТ");
            string Height = Console.ReadLine();

            Console.WriteLine("Введите Ваш ВЕС");
            string Weight = Console.ReadLine();

            Console.WriteLine(Name+" "+Surname+": возраст "+Age+", рост "+Height+", вес "+Weight);
            Console.WriteLine("{0} {1}: возраст {2}, рост {3}, вес {4}", Name, Surname, Age, Height, Weight );
            Console.WriteLine($"{Name} {Surname}: возраст {Age}, рост {Height}, вес {Weight}");

            Console.ReadKey();
        }
    }
}

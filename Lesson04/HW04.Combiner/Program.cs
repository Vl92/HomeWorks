using System;

namespace HW04.Combiner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Здравствуйте, " + name +" " + surname +  ", сегодня хороший день");
            


            Console.ReadKey();
        }
    }
}

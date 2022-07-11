using System;
using System.Collections.Generic;
using System.Linq;

namespace HW07.StringWorkerTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Мы имеем текст: ");
            Console.WriteLine("Пользователь вводит строку. Нужно провести ряд операций.");
            string text = "Пользователь вводит строку. Нужно провести ряд операций.";
            string sep = ".";
            string[] arrayText = text.Split(' ');
            Console.WriteLine();

            //Removing the longest word
            Console.WriteLine("В начале удаляем самое длинное слово: ");
            var strOut = new string(text.Where(x => !sep.Contains(x)).ToArray()).Split(' ').Select(v => v.Trim(' '));
            var maxLenWrd = strOut.Where(z => z.Length != strOut.Max(c => c.Length));

            Console.WriteLine(string.Join(" ", maxLenWrd));
            Console.WriteLine();

            //changing places
            Console.WriteLine("Теперь меняем местами самое короткое и самое длинное слово:");
            Console.WriteLine(arrayText[5] + " " + arrayText[1] + " " + arrayText[2] + " " + arrayText[3] + " " +
                              arrayText[4] + " " + arrayText[0] + " " + arrayText[6]);
            Console.WriteLine();

            //sorting
            Console.WriteLine("разбиваем текст по словам и сортируем в порядке убывания:");
          
            var sorted = arrayText.OrderBy(p => p, new CustomStringComparer());
            foreach (var p in sorted)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // counting characters and letters
            Console.WriteLine("Посчитаем количество букв и знаков");
            int count = 0;
            foreach (var el in text) if (char.IsLetter(el)) count++;
            Console.WriteLine("Букв:" + count);

            Console.WriteLine("Знаков:" + text.Count(char.IsPunctuation));
            Console.ReadKey(true);
            Console.ReadKey();
        }
    }

    internal class CustomStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int xLength = x?.Length ?? 0;
            int yLength = y?.Length ?? 0;
            return yLength - xLength;
        }
    }
}

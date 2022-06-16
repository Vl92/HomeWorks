using System;

namespace HW04.Separator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var word = Console.ReadLine();

            foreach (char item in word)
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();

        }
    }
}

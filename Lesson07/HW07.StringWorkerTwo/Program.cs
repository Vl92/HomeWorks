using System;

namespace HW07.StringWorkerTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] words = line.Split('.', ',',' ', '!',':',';','?');

            int max = 0;
            foreach (string word in words)
                if (word.Length > max)
                    max = word.Length;
            Console.WriteLine(max);

         



            Console.ReadKey();
        }
    }
}

﻿using System;

namespace HW06.Separator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userImput = "Я помню чудное мгновенье:; Передо мной явилась ты,;" +
                               "Как мимолетное виденье, ; Как гений чистой красоты.";
            string[] splitedArray = userImput.Split(';');
            string poem = "";
            for (int i = 0; i < splitedArray.Length; i++)
            {
                poem += (splitedArray[i] + "\n").Trim(' ').Replace('о', 'а');
            }
            Console.WriteLine(poem);

            string[] plitedArrayTwo = poem.Split(' ');
            string poemColumn = "";
            for (int i = 0; i < plitedArrayTwo.Length; i++)
            {
                poemColumn += (plitedArrayTwo[i] + "\n").Trim(';');
            }
            Console.WriteLine(poemColumn);

            Console.ReadKey();
        }
    }
}

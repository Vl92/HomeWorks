using System;

namespace HW07.Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                             {11,12,13,14,15},
                             {00,22,44,17,97},
                             {02,15,10,66,76},
                             {40,09,03,55,37},
                             {58,25,53,07,44}
                           };

            int numberOfLines = array.GetLength(0), numberOfColumns = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int element = array[i, j];
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
            
                if (array[1, 1] > array[0, 0]&&array[1, 1] > array[2, 2]&&array[1, 1] > array[3, 3] && array[1, 1] > array[4, 4]) 
                {
                    Console.WriteLine("Наибольшее число в диагонали A: " + array[ 1,1]);
                }
                else if (array[0, 0] > array[1, 1] && array[0, 0] > array[2, 2] && array[0, 0] > array[3, 3] && array[0, 0] > array[4, 4])
                {
                Console.WriteLine("Наибольшее число в диагонали A: " + array[0,0]);
                }
                else if (array[2, 2] > array[1, 1] && array[2, 2] > array[0, 0] && array[2, 2] > array[3, 3] && array[2, 2] > array[4, 4])
                {
                    Console.WriteLine("Наибольшее число в диагонали A: " + array[2, 2]);
                }
                else if (array[3, 3] > array[1, 1] && array[3, 3] > array[2, 2] && array[3, 3] > array[0, 0] && array[3, 3] > array[4, 4])
                {
                    Console.WriteLine("Наибольшее число в диагонали A: " + array[3, 3]);
                }
                else if (array[4, 4] > array[1, 1] && array[4, 4] > array[2, 2] && array[4, 4] > array[3, 3] && array[4, 4] > array[0, 0])
                {
                Console.WriteLine("Наибольшее число в диагонали A: " + array[4, 4]);
                }
            Console.WriteLine();

            if (array[0,4] < array[1,3] && array[0,4] < array[2, 2] && array[0,4] < array[3, 1] && array[0, 4] < array[4,0])
            {
                Console.WriteLine("Наименьшее число в диагонали В: " + array[0, 4]);
            }
            else if (array[1, 3] < array[0, 4] && array[1, 3] < array[2, 2] && array[1, 3] < array[3, 1] && array[1, 3] < array[4, 0])
            {
                Console.WriteLine("Наименьшее число в диагонали В: " + array[1, 3]);
            }
            else if (array[2, 2] < array[1, 3] && array[2, 2] < array[1, 4] && array[2, 2] < array[3, 1] && array[2, 2] < array[4, 0])
            {
                Console.WriteLine("Наименьшее число в диагонали В: " + array[2, 2]);
            }
            else if (array[3, 1] < array[1, 3] && array[3, 1] < array[2, 2] && array[3, 1] < array[0, 4] && array[3, 1] < array[4, 0])
            {
                Console.WriteLine("Наименьшее число в диагонали В: " + array[3, 1]);
            }
            else if (array[4,0] < array[1, 3] && array[4, 0] < array[2, 2] && array[4, 0] < array[3, 1] && array[4, 0] < array[0, 4])
            {
                Console.WriteLine("Наименьшее число в диагонали В: " + array[4, 0]);
            }

            Console.ReadKey();
        }
    }
}

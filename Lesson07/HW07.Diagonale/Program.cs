using System;


namespace HW07.Diagonale
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


            var counter = 0;

            int[] arrayTwo = new int[array.GetLength(1)];
            int maxValueInRow = int.MinValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == counter)
                    {
                        arrayTwo[j] = array[i, j];
                    }
                }
                counter++;
            }

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                if (arrayTwo[i] > maxValueInRow)
                {
                    maxValueInRow = arrayTwo[i];
                }
                Console.Write($"{arrayTwo[i]} ");
            }
            Console.Write($"Max value = {maxValueInRow}");
            Console.WriteLine();

            int counterTwo = array.GetLength(1) - 1;
            int[] arrayThree = new int[array.GetLength(1)];
            int minValueInRow = int.MaxValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == counterTwo)
                    {
                        arrayThree[j] = array[i, j];
                    }
                }
                counterTwo--;
            }

            for (int i = 0; i < arrayThree.Length; i++)
            {
                if (arrayThree[i] < minValueInRow)
                {
                    minValueInRow = arrayThree[i];
                }
                Console.Write($"{arrayThree[i]} ");
            }
            Console.Write($"Min value = {minValueInRow}");

            Console.ReadKey();
        }
    }
}

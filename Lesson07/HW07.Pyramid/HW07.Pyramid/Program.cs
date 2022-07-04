using System;

namespace HW07.Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 4, j = 5;
            int[,] array = new int[i, j];

            array[1, 2] = 1; array[2, 1] = 1; array[2, 2] = 1; array[2, 3] = 1; array[3, 0] = 1;
            array[3, 1] = 1; array[3, 2] = 1; array[3, 3] = 1; array[3, 4] = 1;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                    Console.Write(array[row, column] + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

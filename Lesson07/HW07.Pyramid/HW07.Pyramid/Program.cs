using System;

namespace HW07.Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 4;
            int colummneCount = 5;

            int[,] array = new int[rowCount, colummneCount];

            int displayValueOne = 1;
            int displayValueZero = 0; 

            int middleValueOne = (colummneCount - 1) / 2;
            int middleValueTwo = (colummneCount - 1) / 2;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        Console.Write(displayValueZero);
                    }
                    else
                    {
                        if (j > middleValueOne && j < middleValueTwo)
                        {
                            Console.Write(displayValueOne);
                        }
                        else
                        {
                            Console.Write(displayValueZero);
                        }
                    }
                }
                middleValueOne--;
                middleValueTwo++;
                Console.WriteLine();              
            }
            Console.ReadKey();
        }
    }
  
}

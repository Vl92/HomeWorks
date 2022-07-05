using System;

namespace HW07.BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int z = 3, y = 4, x = 4;
        
            int[,,] array = new int[z, y, x]

            
            {
                {
                    {09,12,05,15 },
                    {10,08,07,11 },
                    {35,12,12,16 },
                    {15,24,67,89 }
                },
                {
                    {88,76,13,33 },
                    {11,53,61,14 },
                    {56,44,22,17 },
                    {11,98,13,14 }
                },
                {
                    {29,27,77,14 },
                    {78,03,55,17 },
                    {48,19,68,80 },
                    {68,41,14,07 }
                }
            };

            int max = array[0,0,0];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    for (int k = 0; k < z; k++)
                    if (array[k, j, i] > max)
                        max = array[i, j, k];
            Console.WriteLine("max:{0}", max);

            
           int min = array[0,0,0];
            for (int g = 0; g < x; g++)
                for (int h = 0; h < y; h++)
                    for (int f = 0; f < z; f++)
                        if (array[f, h, g] < min)
                            min = array[f, h, g];
            Console.WriteLine("min:{0}", min);

            Console.ReadKey();
        }
    }
}

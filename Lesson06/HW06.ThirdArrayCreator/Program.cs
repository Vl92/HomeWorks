using System;


namespace HW06.ThirdArrayCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOwn = new int[4];
            int[] arrayTwo = new int[4];
            int[] arrayThree = new int[4];

            Random randomInstance = new Random();

            for (int i = 0; i < arrayOwn.Length; i++)
            {
                arrayOwn[i] = randomInstance.Next(0, 100);
                Console.WriteLine(arrayOwn[i]);
            }
            Console.WriteLine("enter four numbers");
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("addition result");
            for (int i = 0; i < arrayThree.Length; i++)
            {
                arrayThree[i] = arrayOwn[i] + arrayTwo[i];
                Console.WriteLine(arrayThree[i]);
            }        
            Console.ReadKey();
        }
    }
}

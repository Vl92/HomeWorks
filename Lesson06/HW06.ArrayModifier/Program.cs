using System;

namespace HW06.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;                   
            int[] arr = new int[10];
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int pos = 0;
            Console.Write("Enter position : ");
            pos = int.Parse(Console.ReadLine());

            int item = 0;
            Console.Write("Enter new item : ");
            item = int.Parse(Console.ReadLine());

            for (i = 5; i >= pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[pos - 1] = item;
            Console.WriteLine("Array elements after insertion : ");
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

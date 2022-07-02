using System;

namespace HW06.TheTriangleBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = Convert.ToInt32(Console.ReadLine());
            var counterOne = userInput;

            var displayValue = 0;

            for (int i = userInput; i >=0; i--)
            {
                var counterTwo  = userInput - counterOne;
                for (int k = 0; k <= counterTwo; k++) 
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= counterOne; j++)
                {
                    Console.Write(displayValue);
                    Console.Write(" ");
                }
                displayValue++;
                if(displayValue == 10)
                {
                    displayValue = 0;
                }
                Console.WriteLine();
                counterOne--;
            }
            Console.ReadKey();
                
        }
    }
}

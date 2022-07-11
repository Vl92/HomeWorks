using System;
using System.Linq;

namespace HW07.StringWorkerThree
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string initialData = "gdfgdf234dg54gf+23oP42";
            Console.WriteLine("original number: " + initialData);
            string[] signSeparation = initialData.Split('+','-','*','/');
                                 
            int value;
            int.TryParse(string.Join("", signSeparation[0].Where(c => char.IsDigit(c))), out value);
            Console.WriteLine("first value: " + value);

            int valueTwo;
            int.TryParse(string.Join("", signSeparation[1].Where(c => char.IsDigit(c))), out valueTwo);
            Console.WriteLine("second meaning: " + valueTwo);

            int sum = value + valueTwo;
            Console.WriteLine("Sum: " + sum);
       
            Console.ReadKey();
        }
    }
}

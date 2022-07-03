using System;
using System.Linq;

namespace HW07.StringWorkerThree
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string initialВata = "gdfgdf234dg54gf+23oP42";
            Console.WriteLine("Изначальное значение: " + initialВata);
            string[] signSeparation = initialВata.Split('+','-','*','/');

            foreach (var word in signSeparation)
            { }                      
            
            int value;
            int.TryParse(string.Join("", signSeparation[0].Where(c => char.IsDigit(c))), out value);
            Console.WriteLine("Первое значение: " + value);

            int valueTwo;
            int.TryParse(string.Join("", signSeparation[1].Where(c => char.IsDigit(c))), out valueTwo);
            Console.WriteLine("Второе значение: "+valueTwo);

            int sum = value + valueTwo;
            Console.WriteLine(sum);
       
            Console.ReadKey();
        }
    }
}

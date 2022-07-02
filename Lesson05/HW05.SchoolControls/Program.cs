using System;

namespace HW05.SchoolControls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Введите номер контрольного теста");
                int numtest = 0;
                numtest = Convert.ToInt32(Console.ReadLine());

                if ((numtest >= 1) && (numtest <= 15))
                {
                    Console.WriteLine("Тест который вы ввели относится к первой четверти");
                }
                else if ((numtest >= 16) && (numtest <= 30))
                {
                    Console.WriteLine("Тест который вы ввели относится ко второй четверти");
                }
                else if ((numtest >= 31) && (numtest <= 45))
                {
                    Console.WriteLine("Тест который вы ввели относится к третьей четверти");
                }
                else if ((numtest >= 46) && (numtest <= 60))
                {
                    Console.WriteLine("Тест который вы ввели относится к четвертой четверти");
                }
            }
           Console.ReadKey();
        }
    }
}

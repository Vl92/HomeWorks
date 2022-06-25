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
                int testNumber = 0;
                testNumber = Convert.ToInt32(Console.ReadLine());

                if ((testNumber >= 1) && (testNumber <= 15))
                {
                    Console.WriteLine("Тест который вы ввели относится к первой четверти");
                }
                else if ((testNumber >= 16) && (testNumber <= 30))
                {
                    Console.WriteLine("Тест который вы ввели относится ко второй четверти");
                }
                else if ((testNumber >= 31) && (testNumber <= 45))
                {
                    Console.WriteLine("Тест который вы ввели относится к третьей четверти");
                }
                else if ((testNumber >= 46) && (testNumber <= 60))
                {
                    Console.WriteLine("Тест который вы ввели относится к четвертой четверти");
                }
            }
           Console.ReadKey();
        }
    }
}

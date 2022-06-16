using System;

namespace HW04.Birthday
{
    internal class Program
    {
        public int year, month, day;
        public int yearTwo, monthTwo, dayTwo;
        public int resultyear, resultmonth;
        public void info()
        {
            Console.Write("Год = ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Месяц = ");
            month = int.Parse(Console.ReadLine());
            Console.Write("День = ");
            day = int.Parse(Console.ReadLine());
        }
        
        public void info_t()
        {
            Console.Write("Год = ");
            yearTwo = int.Parse(Console.ReadLine());
            Console.Write("Месяц = ");
            monthTwo = int.Parse(Console.ReadLine());
            Console.Write("День = ");
            dayTwo = int.Parse(Console.ReadLine());
        }
        
        public void Result()
        {
            if ((monthTwo - month) > 0)
            {
                resultmonth = monthTwo - month;
                resultyear = yearTwo - year;
                Console.WriteLine("Получается {0} лет и {1} месяцов ", resultyear, resultmonth);
            }
            else
            {
                resultmonth = monthTwo + 12 - month;
                resultyear = yearTwo - 1 - year;
                Console.WriteLine("Получается {0} лет и {1} месяцов ", resultyear, resultmonth);
            }
        }
        static void Main()
        {
            Program program = new Program();
            Console.WriteLine("Настоящая дата рождения : ");
            program.info();
            Console.WriteLine("\nHа сегодняшний день : ");
            program.info_t();

            program.Result();
            Console.ReadLine();
        }
    }
}

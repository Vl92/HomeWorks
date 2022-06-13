using System;


namespace HW04.Birthday
{
    internal class Program
    {
        public int year, month, day;
        public int year_2, month_2, day_2;
        public int result_year, result_month;
        static void Main()
        {
            Program vadym = new Program();
            Console.WriteLine("Настоящая дата рождения : ");
            vadym.info();
            Console.WriteLine("\nHа сегодняшний день : ");
            vadym.info_t();

            vadym.Result();
            Console.ReadLine();
        }
        
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
            year_2 = int.Parse(Console.ReadLine());
            Console.Write("Месяц = ");
            month_2 = int.Parse(Console.ReadLine());
            Console.Write("День = ");
            day_2 = int.Parse(Console.ReadLine());
        }
        
        public void Result()
        {
            if ((month_2 - month) > 0)
            {
                result_month = month_2 - month;
                result_year = year_2 - year;
                Console.WriteLine("Получается {0} лет и {1} месяцов ", result_year, result_month);
            }
            else
            {
                result_month = month_2 + 12 - month;
                result_year = year_2 - 1 - year;
                Console.WriteLine("Получается {0} лет и {1} месяцов ", result_year, result_month);
            }
        }

    }
}

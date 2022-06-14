using System;


namespace HW04.SalaryBonusCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string basic;
            double experience;
            int experience1 = 5;
            int experience2 = 10;
            int experience3 = 15;
            int experience4 = 20;
            int experience5 = 25;
            

            Console.WriteLine("Введите вашу зарплату");
            basic = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ваша зарплата" + " " +basic);
            Console.Clear();

            Console.WriteLine("Введите ваш стаж работы");
            experience = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ваш стаж" + " " +experience);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            if (experience < experience1)
            {
                double bonus = (Convert.ToDouble(basic) * 10) / 100;
                double totalsalry = Convert.ToDouble(basic) + bonus;
                
                Console.WriteLine("Общая зарплата {0}", totalsalry);
            }

            if ((experience >= experience1 ) && ( experience < experience2))
            {
                double bonus = (Convert.ToDouble(basic) * 15) / 100;
                double totalsalry = Convert.ToDouble(basic) + bonus;
                Console.WriteLine("Общая зарплата {0}", totalsalry);
            }

            if ((experience >= experience2) && (experience < experience3))
            {
                double bonus = (Convert.ToDouble(basic) * 25) / 100;
                double totalsalry = Convert.ToDouble(basic) + bonus;
                Console.WriteLine("Общая зарплата {0}", totalsalry);
            }

            if ((experience >= experience3) && (experience < experience4))
            {
                double bonus = (Convert.ToDouble(basic) * 35) / 100;
                double totalsalry = Convert.ToDouble(basic) + bonus;
                Console.WriteLine("Общая зарплата {0}", totalsalry);
            }

            if (experience >= experience5) 
            {
                double bonus = (Convert.ToDouble(basic) * 50) / 100;
                double totalsalry = Convert.ToDouble(basic) + bonus;
                Console.WriteLine("Общая зарплата {0}", totalsalry);
            }

            Console.ReadLine();
        }
    }
}

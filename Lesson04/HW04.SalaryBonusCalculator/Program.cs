using System;


namespace HW04.SalaryBonusCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string salary;
            string experience;
            int experience1 = 5, experience2 = 10, experience3 = 15, experience4 = 20, experience5 = 25;



            Console.WriteLine("Введите вашу зарплату");
            salary = (Console.ReadLine());
            bool result = int.TryParse(salary, out int value);

            if (result == true)
            {
                Console.WriteLine("Ваша зарплата" + " " + salary);
                Console.WriteLine("Введите ваш стаж работы");
                experience = Console.ReadLine();
                result = int.TryParse(experience, out int valueTwo);

                if (result == true)
                {
                    Console.WriteLine("Ваш стаж" + " " + experience);


                    if (valueTwo < experience1)
                    {
                        double bonus = (Convert.ToDouble(salary) * 10) / 100;
                        double totalsalary = Convert.ToDouble(salary) + bonus;
                        Console.WriteLine("Общая зарплата {0}", totalsalary);
                    }

                    if ((valueTwo >= experience1) && (valueTwo < experience2))
                    {
                        double bonus = (Convert.ToDouble(salary) * 15) / 100;
                        double totalsalary = Convert.ToDouble(salary) + bonus;
                        Console.WriteLine("Общая зарплата {0}", totalsalary);
                    }

                    if ((valueTwo >= experience2) && (valueTwo < experience3))
                    {
                        double bonus = (Convert.ToDouble(salary) * 25) / 100;
                        double totalsalary = Convert.ToDouble(salary) + bonus;
                        Console.WriteLine("Общая зарплата {0}", totalsalary);
                    }

                    if ((valueTwo >= experience3) && (valueTwo < experience4))
                    {
                        double bonus = (Convert.ToDouble(salary) * 35) / 100;
                        double totalsalary = Convert.ToDouble(salary) + bonus;
                        Console.WriteLine("Общая зарплата {0}", totalsalary);
                    }

                    if (valueTwo >= experience5)
                    {
                        double bonus = (Convert.ToDouble(salary) * 50) / 100;
                        double totalsalary = Convert.ToDouble(salary) + bonus;
                        Console.WriteLine("Общая зарплата {0}", totalsalary);
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не верное значение");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не верное значение");
            }






            Console.ReadLine();
        }
    }
}

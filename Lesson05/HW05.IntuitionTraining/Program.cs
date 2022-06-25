using System;


namespace HW05.IntuitionTraining
{
    internal class Program
    {       
        public static object Guess { get; private set; }

        static void Main(string[] args)
        {
            while(true)
            {
                Random random = new Random();
                int returnValue = random.Next(1, 5);
                int userImput = 0;
                Console.WriteLine("Я загадал число от 1 до 5. Сможешь угадать?");

                userImput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вы загадали число " + userImput);

                if (userImput != returnValue)
                {
                    Console.WriteLine("К сожалению вы не угадали. Попробуйте еще раз");
                }
                else if (userImput == returnValue)
                {
                    Console.WriteLine("Красавчик, правильный ответ " + returnValue);
                }
                Console.WriteLine("Хотите продолжить?");
            } 
            Console.ReadLine();

        }
    }
}

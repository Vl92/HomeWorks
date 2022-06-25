using System;
using System.Threading;

namespace HW05.Movement
{

    public class Program
    {
        public static void Main(string[] args)
        {
            const char toWrite = '!'; 

            int x = 0, y = 0;

            Write(toWrite); 

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var command = Console.ReadKey().Key;

                    switch (command)
                    {
                        case ConsoleKey.S:
                            y++;
                            break;
                        case ConsoleKey.W:
                            if (y > 0)
                            {
                                y--;
                            }
                            break;
                        case ConsoleKey.A:
                            if (x > 0)
                            {
                                x--;
                            }
                            break;
                        case ConsoleKey.D:
                            x++;
                            break;
                    }

                    Write(toWrite, x, y);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        public static void Write(char toWrite, int x = 0, int y = 0)
        {
            try
            {
                if (x >= 0 && y >= 0) 
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write(toWrite);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

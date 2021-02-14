using System;

namespace MovieTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int a = a1; a < a2; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 1; c < n / 2; c++)
                    {
                        if ((a % 2 != 0) && ((b + c + (int)a) % 2 != 0))
                        {
                            Console.WriteLine($"{(char)a}-{b}{c}{(int)a}");
                        }
                    }
                }
            }
        }
    }
}

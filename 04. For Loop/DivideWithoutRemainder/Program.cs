using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int divisibleBy2 = 0;
            int divisibleBy3 = 0;
            int divisibleBy4 = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    divisibleBy2++;
                }

                if (number % 3 == 0)
                {
                    divisibleBy3++;
                }

                if (number % 4 == 0)
                {
                    divisibleBy4++;
                }
            }

            Console.WriteLine($"{(double)divisibleBy2 / numbersCount * 100:f2}%");
            Console.WriteLine($"{(double)divisibleBy3 / numbersCount * 100:f2}%");
            Console.WriteLine($"{(double)divisibleBy4 / numbersCount * 100:f2}%");
        }
    }
}

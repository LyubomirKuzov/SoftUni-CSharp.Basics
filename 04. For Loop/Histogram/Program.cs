using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int to199Count = 0;
            int to399Count = 0;
            int to599Count = 0;
            int to799Count = 0;
            int above800Count = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= 199)
                {
                    to199Count++;
                }

                else if (number <= 399)
                {
                    to399Count++;
                }

                else if (number <= 599)
                {
                    to599Count++;
                }

                else if (number <= 799)
                {
                    to799Count++;
                }

                else if (number >= 800)
                {
                    above800Count++;
                }
            }

            Console.WriteLine($"{(double)to199Count / numbersCount * 100:f2}%");
            Console.WriteLine($"{(double)to399Count / numbersCount * 100:f2}%");
            Console.WriteLine($"{(double)to599Count / numbersCount * 100:f2}%");
            Console.WriteLine($"{(double)to799Count / numbersCount * 100:f2}%");
            Console.WriteLine($"{(double)above800Count / numbersCount * 100:f2}%");
        }
    }
}

using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            double averageNumber = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                averageNumber += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(((double)averageNumber / numbersCount).ToString("f2"));
        }
    }
}

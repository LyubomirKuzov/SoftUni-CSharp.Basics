using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            if (sum - maxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }

            else
            {
                Console.WriteLine("No");

                sum -= maxNumber;

                Console.WriteLine($"Diff = {Math.Abs(sum - maxNumber)}");
            }
        }
    }
}

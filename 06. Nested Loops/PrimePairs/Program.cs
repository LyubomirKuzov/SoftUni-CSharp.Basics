using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairStart = int.Parse(Console.ReadLine());
            int secondPairStart = int.Parse(Console.ReadLine());
            int firstPairDifference = int.Parse(Console.ReadLine());
            int secondPairDifference = int.Parse(Console.ReadLine());

            int firstPairEnd = firstPairStart + firstPairDifference;
            int secondPairEnd = secondPairStart + secondPairDifference;

            for (int a = firstPairStart; a <= firstPairEnd; a++)
            {
                for (int b = secondPairStart; b <= secondPairEnd; b++)
                {
                    if (CheckIfNumberIsPrime(a) && CheckIfNumberIsPrime(b))
                    {
                        Console.WriteLine($"{a}{b}");
                    }
                }
            }
        }

        private static bool CheckIfNumberIsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

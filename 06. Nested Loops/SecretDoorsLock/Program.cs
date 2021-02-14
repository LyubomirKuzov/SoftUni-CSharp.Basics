using System;

namespace SecretDoorsLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBorderC = int.Parse(Console.ReadLine());
            int upperBorderB = int.Parse(Console.ReadLine());
            int upperBorderA = int.Parse(Console.ReadLine());

            for (int c = 1; c <= upperBorderC; c++)
            {
                for (int b = 1; b <= upperBorderB; b++)
                {
                    for (int a = 1; a <= upperBorderA; a++)
                    {
                        if (b > 1)
                        {
                            if (a % 2 == 0 && c % 2 == 0 && CheckIfNumberIsPrime(b))
                            {
                                Console.WriteLine($"{c} {b} {a}");
                            }
                        }
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

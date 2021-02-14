using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumBorder = int.Parse(Console.ReadLine());
            int secondNumBorder = int.Parse(Console.ReadLine());
            int thirdNumBorder = int.Parse(Console.ReadLine());

            for (int a = 1; a <= firstNumBorder; a++)
            {
                for (int b = 1; b <= secondNumBorder; b++)
                {
                    for (int c = 1; c <= thirdNumBorder; c++)
                    {
                        if (a % 2 == 0 && c % 2 == 0 && CheckIfNumberIsPrime(b))
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }
                    }
                }
            }
        }

        private static bool CheckIfNumberIsPrime(int number)
        {
            if (number > 1)
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

            return false;
        }
    }
}

using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool combinationFound = false;
            int combinationCount = 1;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCount} ({i} + {j} = {magicNumber})");
                        combinationFound = true;
                        break;
                    }

                    combinationCount++;
                }

                if (combinationFound)
                {
                    break;
                }
            }

            if (!combinationFound)
            {
                Console.WriteLine($"{combinationCount - 1} combinations - neither equals {magicNumber}");
            }
        }
    }
}

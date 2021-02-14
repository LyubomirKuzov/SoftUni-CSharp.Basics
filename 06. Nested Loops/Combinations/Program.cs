using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int correctResultCount = 0;

            for (int x1 = 0; x1 <= N; x1++)
            {
                for (int x2 = 0; x2 <= N; x2++)
                {
                    for (int x3 = 0; x3 <= N; x3++)
                    {
                        if (x1 + x2 + x3 == N)
                        {
                            correctResultCount++;
                        }
                    }
                }
            }

            Console.WriteLine(correctResultCount);
        }
    }
}

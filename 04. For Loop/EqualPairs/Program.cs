using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());

            bool allPairsAreEqual = true;
            int maxDifference = int.MinValue;
            int previousValue = 0;
            int prevFirstNum = 0;
            int prevSecondNum = 0;

            for (int i = 0; i < pairsCount; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                int pairValue = firstNum + secondNum;

                if (i > 0)
                {
                    if (pairValue != previousValue)
                    {
                        int difference = Math.Abs(Math.Max(pairValue, previousValue) - Math.Min(pairValue, previousValue));
                        allPairsAreEqual = false;

                        if (difference > maxDifference && previousValue == prevFirstNum + prevSecondNum)
                        {
                            maxDifference = difference;
                        }
                    }
                }

                else
                {
                    previousValue = pairValue;
                }

                previousValue = pairValue;
                prevFirstNum = firstNum;
                prevSecondNum = secondNum;
            }

            if (allPairsAreEqual)
            {
                Console.WriteLine($"Yes, value={previousValue}");
            }
            
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}

using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= numbersCount; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                }

                else
                {
                    oddSum += number;

                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine($"OddMin={(numbersCount >= 1 ? oddMin.ToString("f2") : "No")},");
            Console.WriteLine($"OddMax={(numbersCount >= 1 ? oddMax.ToString("f2") : "No")},");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine($"EvenMin={(numbersCount >= 2 ? evenMin.ToString("f2") : "No")},");
            Console.WriteLine($"EvenMax={(numbersCount >= 2 ? evenMax.ToString("f2") : "No")}");
        }
    }
}

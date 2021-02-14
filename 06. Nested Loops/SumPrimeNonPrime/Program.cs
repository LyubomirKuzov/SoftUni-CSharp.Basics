using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primesSum = 0;
            int nonPrimesSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                if (number > 1)
                {
                    bool isPrime = true;

                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            nonPrimesSum += number;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        primesSum += number;
                    }
                }

                else
                {
                    nonPrimesSum += number;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primesSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimesSum}");
        }
    }
}

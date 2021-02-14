using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;

                if (sum >= targetNumber)
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }

                double money = double.Parse(input);

                if (money <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {money:f2}");
                sum += money;
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}

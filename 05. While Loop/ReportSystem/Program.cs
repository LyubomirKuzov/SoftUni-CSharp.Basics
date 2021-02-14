using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedProfit = int.Parse(Console.ReadLine());

            int currentProfit = 0;
            int counter = 1;
            int moneyInCash = 0;
            int moneyWithCard = 0;
            int cashTransactionsCount = 0;
            int cardTransactionsCount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");   
                    break;
                }

                int money = int.Parse(input);

                if (counter % 2 == 0)
                {
                    if (money >= 10)
                    {
                        cardTransactionsCount++;
                        currentProfit += money;
                        moneyWithCard += money;
                        Console.WriteLine("Product sold!");
                    }

                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }

                else
                {
                    if (money <= 100)
                    {
                        cashTransactionsCount++;
                        currentProfit += money;
                        moneyInCash += money;
                        Console.WriteLine("Product sold!");
                    }

                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }

                if (currentProfit >= expectedProfit)
                {
                    Console.WriteLine($"Average CS: {(double)moneyInCash / cashTransactionsCount:f2}");
                    Console.WriteLine($"Average CC: {(double)moneyWithCard / cardTransactionsCount:f2}");
                    break;
                }

                counter++;
            }
        }
    }
}

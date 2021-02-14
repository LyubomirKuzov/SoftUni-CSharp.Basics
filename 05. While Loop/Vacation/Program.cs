using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int consequtiveSpendingDays = 0;
            int daysCount = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                daysCount++;

                if (action == "save")
                {
                    consequtiveSpendingDays = 0;
                    currentMoney += amount;

                    if (currentMoney >= vacationPrice)
                    {
                        Console.WriteLine($"You saved the money for {daysCount} days.");
                        break;
                    }
                }

                else if (action == "spend")
                {
                    consequtiveSpendingDays++;

                    if (amount > currentMoney)
                    {
                        currentMoney = 0;
                    }

                    else
                    {
                        currentMoney -= amount;
                    }

                    if (consequtiveSpendingDays == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                }
            }
        }
    }
}

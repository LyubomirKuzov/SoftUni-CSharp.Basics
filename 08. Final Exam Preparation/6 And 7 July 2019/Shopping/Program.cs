using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardsCount = int.Parse(Console.ReadLine());
            int processorsCount = int.Parse(Console.ReadLine());
            int ramMemoryCount = int.Parse(Console.ReadLine());

            double videoCardsPrice = videoCardsCount * 250;
            double processorsPrice = videoCardsPrice * 0.35 * processorsCount;
            double ramMemoryPrice = videoCardsPrice * 0.1 * ramMemoryCount;
            double totalPrice = videoCardsPrice + processorsPrice + ramMemoryPrice;

            if (videoCardsCount > processorsCount)
            {
                totalPrice *= 0.85;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}

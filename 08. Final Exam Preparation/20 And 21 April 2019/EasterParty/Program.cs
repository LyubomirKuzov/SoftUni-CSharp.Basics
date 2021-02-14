using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            double envelopePricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guestsCount >= 10 && guestsCount <= 15)
            {
                envelopePricePerPerson *= 0.85;
            }

            else if (guestsCount > 15 && guestsCount <= 20)
            {
                envelopePricePerPerson *= 0.8;
            }

            else if (guestsCount > 20)
            {
                envelopePricePerPerson *= 0.75;
            }

            double cakePrice = budget * 0.1;
            double moneyNeeded = guestsCount * envelopePricePerPerson + cakePrice;

            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"It is party time! {budget - moneyNeeded:f2} leva left.");
            }

            else
            {
                Console.WriteLine($"No party! {moneyNeeded - budget:f2} leva needed.");
            }
        }
    }
}

using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;

                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;

                case "Winter":
                    price = 2600;
                    break;
            }

            if (fishermenCount <= 6)
            {
                price *= 0.9;
            }

            else if (fishermenCount <= 11)
            {
                price *= 0.85;
            }

            else if (fishermenCount >= 12)
            {
                price *= 0.75;
            }

            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                price *= 0.95;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}

using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string place = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                switch (season)
                {
                    case "summer":
                        price = budget * 0.3;
                        place = "Camp";
                        break;

                    case "winter":
                        price = budget * 0.7;
                        place = "Hotel";
                        break;
                }
            }

            else if (budget <= 1000)
            {
                destination = "Balkans";

                switch (season)
                {
                    case "summer":
                        price = budget * 0.4;
                        place = "Camp";
                        break;

                    case "winter":
                        price = budget * 0.8;
                        place = "Hotel";
                        break;
                }
            }

            else if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                price = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");
        }
    }
}

﻿using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string location = string.Empty;
            string place = string.Empty;

            if (budget <= 1000)
            {
                place = "Camp";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.65;
                        break;

                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.45;
                        break;
                }
            }

            else if (budget <= 3000)
            {
                place = "Hut";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.8;
                        break;

                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.6;
                        break;
                }
            }

            else if (budget > 3000)
            {
                place = "Hotel";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.9;
                        break;

                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.9;
                        break;
                }
            }

            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}

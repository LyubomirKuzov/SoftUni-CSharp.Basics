using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double carPrice = 0;
            string carType = string.Empty;
            string carClass = string.Empty;

            if (budget <= 100)
            {
                carClass = "Economy class";

                switch (season)
                {
                    case "Summer":
                        carType = "Cabrio";
                        carPrice = budget * 0.35;
                        break;

                    case "Winter":
                        carType = "Jeep";
                        carPrice = budget * 0.65;
                        break;
                }
            }

            else if (budget <= 500)
            {
                carClass = "Compact class";

                switch (season)
                {
                    case "Summer":
                        carType = "Cabrio";
                        carPrice = budget * 0.45;
                        break;

                    case "Winter":
                        carType = "Jeep";
                        carPrice = budget * 0.8;
                        break;
                }
            }

            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                carPrice = budget * 0.9;
            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {carPrice:f2}");
        }
    }
}

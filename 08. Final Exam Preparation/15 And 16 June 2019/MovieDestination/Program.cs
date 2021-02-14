using System;

namespace MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Winter":
                    switch (destination)
                    {
                        case "Dubai":
                            price = 45000;
                            break;

                        case "Sofia":
                            price = 17000;
                            break;

                        case "London":
                            price = 24000;
                            break;
                    }
                    break;

                case "Summer":
                    switch (destination)
                    {
                        case "Dubai":
                            price = 40000;
                            break;

                        case "Sofia":
                            price = 12500;
                            break;

                        case "London":
                            price = 20250;
                            break;
                    }
                    break;
            }

            price *= daysCount;

            if (destination == "Dubai")
            {
                price *= 0.7;
            }

            else if (destination == "Sofia")
            {
                price *= 1.25;
            }

            if (movieBudget >= price)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {movieBudget - price:f2} leva left!");
            }
            
            else
            {
                Console.WriteLine($"The director needs {price - movieBudget:f2} leva more!");
            }
        }
    }
}

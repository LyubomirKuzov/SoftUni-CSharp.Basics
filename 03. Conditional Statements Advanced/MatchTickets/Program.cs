using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int groupSize = int.Parse(Console.ReadLine());

            double transportPrice = 0;
            double ticketsPrice = 0;

            if (groupSize >= 1 && groupSize <= 4)
            {
                transportPrice = budget * 0.75;
            }

            else if (groupSize <= 9)
            {
                transportPrice = budget * 0.6;
            }

            else if (groupSize <= 24)
            {
                transportPrice = budget * 0.5;
            }

            else if (groupSize <= 49)
            {
                transportPrice = budget * 0.4;
            }

            else if (groupSize >= 50)
            {
                transportPrice = budget * 0.25;
            }

            switch (category)
            {
                case "VIP":
                    ticketsPrice = 499.99;
                    break;

                case "Normal":
                    ticketsPrice = 249.99;
                    break;
            }

            ticketsPrice *= groupSize;

            double totalPrice = ticketsPrice + transportPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}

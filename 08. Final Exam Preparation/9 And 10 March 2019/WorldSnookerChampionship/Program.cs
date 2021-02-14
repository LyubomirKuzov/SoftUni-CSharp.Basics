using System;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            char pictureWithTrophy = char.Parse(Console.ReadLine());

            double price = 0;

            switch (tournamentStage)
            {
                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard":
                            price = 55.50;
                            break;

                        case "Premium":
                            price = 105.20;
                            break;

                        case "VIP":
                            price = 118.90;
                            break;
                    }
                    break;

                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard":
                            price = 75.88;
                            break;

                        case "Premium":
                            price = 125.22;
                            break;

                        case "VIP":
                            price = 300.40;
                            break;
                    }
                    break;

                case "Final":
                    switch (ticketType)
                    {
                        case "Standard":
                            price = 110.10;
                            break;

                        case "Premium":
                            price = 160.66;
                            break;

                        case "VIP":
                            price = 400;
                            break;
                    }
                    break;
            }

            price *= ticketsCount;

            if (price > 4000)
            {
                price *= 0.75;
            }

            else
            {
                if (price > 2500)
                {
                    price *= 0.9;
                }

                if (pictureWithTrophy == 'Y')
                {
                    price += 40 * ticketsCount;
                }
            }

            Console.WriteLine(price.ToString("f2"));
        }
    }
}

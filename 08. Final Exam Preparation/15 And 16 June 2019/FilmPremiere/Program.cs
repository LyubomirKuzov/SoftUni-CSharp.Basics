using System;

namespace FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string package = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (movie)
            {
                case "John Wick":
                    switch (package)
                    {
                        case "Drink":
                            price = 12;
                            break;

                        case "Popcorn":
                            price = 15;
                            break;

                        case "Menu":
                            price = 19;
                            break;
                    }
                    break;

                case "Star Wars":
                    switch (package)
                    {
                        case "Drink":
                            price = 18;
                            break;

                        case "Popcorn":
                            price = 25;
                            break;

                        case "Menu":
                            price = 30;
                            break;
                    }
                    break;

                case "Jumanji":
                    switch (package)
                    {
                        case "Drink":
                            price = 9;
                            break;

                        case "Popcorn":
                            price = 11;
                            break;

                        case "Menu":
                            price = 14;
                            break;
                    }
                    break;
            }

            price *= ticketsCount;

            if (movie == "Star Wars" && ticketsCount >= 4)
            {
                price *= 0.7;
            }

            else if (movie == "Jumanji" && ticketsCount == 2)
            {
                price *= 0.85;
            }

            Console.WriteLine($"Your bill is {price:f2} leva.");
        }
    }
}

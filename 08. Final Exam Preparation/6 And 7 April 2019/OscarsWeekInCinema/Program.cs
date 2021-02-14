using System;

namespace OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string hallType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());

            double income = 0;

            switch (hallType)
            {
                case "normal":
                    switch (movieName)
                    {
                        case "A Star Is Born":
                            income = 7.50;
                            break;

                        case "Bohemian Rhapsody":
                            income = 7.35;
                            break;

                        case "Green Book":
                            income = 8.15;
                            break;

                        case "The Favourite":
                            income = 8.75;
                            break;
                    }
                    break;

                case "luxury":
                    switch (movieName)
                    {
                        case "A Star Is Born":
                            income = 10.50;
                            break;

                        case "Bohemian Rhapsody":
                            income = 9.45;
                            break;

                        case "Green Book":
                            income = 10.25;
                            break;

                        case "The Favourite":
                            income = 11.55;
                            break;
                    }
                    break;

                case "ultra luxury":
                    switch (movieName)
                    {
                        case "A Star Is Born":
                            income = 13.50;
                            break;

                        case "Bohemian Rhapsody":
                            income = 12.75;
                            break;

                        case "Green Book":
                            income = 13.25;
                            break;

                        case "The Favourite":
                            income = 13.95;
                            break;
                    }
                    break;
            }

            income *= ticketsCount;

            Console.WriteLine($"{movieName} -> {income:f2} lv.");
        }
    }
}

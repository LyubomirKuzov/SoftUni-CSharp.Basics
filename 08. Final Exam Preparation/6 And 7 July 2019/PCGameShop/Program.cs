using System;

namespace PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGamesCount = int.Parse(Console.ReadLine());

            int hearthstoneCount = 0;
            int fortniteCount = 0;
            int overwatchCount = 0;
            int othersCount = 0;

            for (int g = 0; g < soldGamesCount; g++)
            {
                string gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "Hearthstone":
                        hearthstoneCount++;
                        break;

                    case "Fornite":
                        fortniteCount++;
                        break;

                    case "Overwatch":
                        overwatchCount++;
                        break;

                    default:
                        othersCount++;
                        break;
                }
            }

            Console.WriteLine($"Hearthstone - {(double)hearthstoneCount / soldGamesCount * 100:f2}%");
            Console.WriteLine($"Fornite - {(double)fortniteCount / soldGamesCount * 100:f2}%");
            Console.WriteLine($"Overwatch - {(double)overwatchCount/ soldGamesCount * 100:f2}%");
            Console.WriteLine($"Others - {(double)othersCount / soldGamesCount * 100:f2}%");
        }
    }
}

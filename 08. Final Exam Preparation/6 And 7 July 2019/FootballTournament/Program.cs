using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            if (gamesPlayed == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
                return;
            }

            int winsCount = 0;
            int drawsCount = 0;
            int defeatsCount = 0;
            int points = 0;

            for (int g = 0; g < gamesPlayed; g++)
            {
                char result = char.Parse(Console.ReadLine());

                switch (result)
                {
                    case 'W':
                        winsCount++;
                        points += 3;
                        break;

                    case 'D':
                        drawsCount++;
                        points += 1;
                        break;

                    case 'L':
                        defeatsCount++;
                        break;
                }
            }

            Console.WriteLine($"{teamName} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {winsCount}");
            Console.WriteLine($"## D: {drawsCount}");
            Console.WriteLine($"## L: {defeatsCount}");
            Console.WriteLine($"Win rate: {(double)winsCount / gamesPlayed * 100:f2}%");
        }
    }
}

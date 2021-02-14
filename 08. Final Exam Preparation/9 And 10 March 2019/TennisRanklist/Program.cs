using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int pointsWon = 0;
            int tournamentWon = 0;

            for (int t = 0; t < tournamentsCount; t++)
            {
                string tournamentStage = Console.ReadLine();

                switch (tournamentStage)
                {
                    case "W":
                        pointsWon += 2000;
                        tournamentWon++;
                        break;

                    case "F":
                        pointsWon += 1200;
                        break;

                    case "SF":
                        pointsWon += 720;
                        break;
                }
            }

            Console.WriteLine($"Final points: {startingPoints + pointsWon}");
            Console.WriteLine($"Average points: {Math.Floor((double)pointsWon / tournamentsCount)}");
            Console.WriteLine($"{(double)tournamentWon / tournamentsCount * 100:f2}%");
        }
    }
}

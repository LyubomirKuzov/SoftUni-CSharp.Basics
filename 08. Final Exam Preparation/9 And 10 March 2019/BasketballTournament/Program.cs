using System;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int wonMatches = 0;
            int lostMatches = 0;

            while (true)
            {
                string tournamentName = Console.ReadLine();

                if (tournamentName == "End of tournaments")
                {
                    int totalMatches = wonMatches + lostMatches;
                    Console.WriteLine($"{(double)wonMatches / totalMatches * 100:f2}% matches win");
                    Console.WriteLine($"{(double)lostMatches / totalMatches * 100:f2}% matches lost");
                    break;
                }

                int matchesCount = int.Parse(Console.ReadLine());

                for (int m = 0; m < matchesCount; m++)
                {
                    int desiTeamPoints = int.Parse(Console.ReadLine());
                    int opponentTeamPoints = int.Parse(Console.ReadLine());

                    if (desiTeamPoints > opponentTeamPoints)
                    {
                        Console.WriteLine($"Game {m + 1} of tournament {tournamentName}: win with {desiTeamPoints - opponentTeamPoints} points.");
                        wonMatches++;
                    }

                    else if (opponentTeamPoints > desiTeamPoints)
                    {
                        Console.WriteLine($"Game {m + 1} of tournament {tournamentName}: lost with {opponentTeamPoints - desiTeamPoints} points.");
                        lostMatches++;
                    }
                }
            }
        }
    }
}

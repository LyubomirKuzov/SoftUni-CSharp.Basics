using System;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMatchResult = Console.ReadLine();
            string secondMatchResult = Console.ReadLine();
            string thirdMatchResult = Console.ReadLine();

            int winsCount = 0;
            int defeatsCount = 0;
            int drawsCount = 0;

            DetermineResults(firstMatchResult, ref winsCount, ref defeatsCount, ref drawsCount);
            DetermineResults(secondMatchResult, ref winsCount, ref defeatsCount, ref drawsCount);
            DetermineResults(thirdMatchResult, ref winsCount, ref defeatsCount, ref drawsCount);

            Console.WriteLine($"Team won {winsCount} games.");
            Console.WriteLine($"Team lost {defeatsCount} games.");
            Console.WriteLine($"Drawn games: {drawsCount}");
        }

        private static void DetermineResults(string match, ref int winsCount, ref int defeatsCount, ref int drawsCount)
        {
            int ourTeamGoals = int.Parse(match[0].ToString());
            int opponentTeamGoals = int.Parse(match[2].ToString());

            if (ourTeamGoals > opponentTeamGoals)
            {
                winsCount++;
            }

            else if (opponentTeamGoals > ourTeamGoals)
            {
                defeatsCount++;
            }

            else
            {
                drawsCount++;
            }
        }
    }
}

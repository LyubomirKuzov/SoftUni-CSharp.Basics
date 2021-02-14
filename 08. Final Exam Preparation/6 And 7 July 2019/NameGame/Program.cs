using System;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string winner = string.Empty;
            int winnerPoints = 0;

            while (true)
            {
                string playerName = Console.ReadLine();

                if (playerName == "Stop")
                {
                    break;
                }

                int playerPoints = 0;
                int rowsCount = playerName.Length;

                for (int r = 0; r < rowsCount; r++)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (playerName[r] == number)
                    {
                        playerPoints += 10;
                    }

                    else
                    {
                        playerPoints += 2;
                    }
                }

                if (playerPoints >= winnerPoints)
                {
                    winnerPoints = playerPoints;
                    winner = playerName;
                }
            }

            Console.WriteLine($"The winner is {winner} with {winnerPoints} points!");
        }
    }
}

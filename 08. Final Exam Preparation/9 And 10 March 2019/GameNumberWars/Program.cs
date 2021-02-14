using System;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End of game")
                {
                    Console.WriteLine($"{firstPlayerName} has {firstPlayerPoints} points");
                    Console.WriteLine($"{secondPlayerName} has {secondPlayerPoints} points");
                    break;
                }

                int firstPlayerCard = int.Parse(input);
                int secondPlayerCard = int.Parse(Console.ReadLine());

                if (firstPlayerCard == secondPlayerCard)
                {
                    Console.WriteLine("Number wars!");
                    string winner = string.Empty;
                    int winnerPoints = 0;

                    int firstPlayerWarsCard = int.Parse(Console.ReadLine());
                    int secondPlayerWarsCard = int.Parse(Console.ReadLine());

                    if (firstPlayerWarsCard > secondPlayerWarsCard)
                    {
                        winner = firstPlayerName;
                        winnerPoints = firstPlayerPoints;
                    }

                    else if (secondPlayerWarsCard > firstPlayerWarsCard)
                    {                      
                        winner = secondPlayerName;
                        winnerPoints = secondPlayerPoints;
                    }

                    Console.WriteLine($"{winner} is winner with {winnerPoints} points");

                    break;
                }

                else if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerPoints += Math.Abs(firstPlayerCard - secondPlayerCard);
                }

                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerPoints += Math.Abs(firstPlayerCard - secondPlayerCard);
                }
            }
        }
    }
}

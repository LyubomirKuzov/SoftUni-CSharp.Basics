using System;

namespace FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesCount = 0;

            string bestMovie = string.Empty;
            int bestPoints = 0;

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "STOP")
                {
                    break;
                }

                if (moviesCount == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                moviesCount++;
                int moviePoints = 0;

                for (int i = 0; i < movieName.Length; i++)
                {
                    moviePoints += movieName[i];

                    if (char.IsLower(movieName[i]))
                    {
                        moviePoints -= 2 * movieName.Length;
                    }
                    
                    else if (char.IsUpper(movieName[i]))
                    {
                        moviePoints -= movieName.Length;
                    }
                }

                if (moviePoints > bestPoints)
                {
                    bestPoints = moviePoints;
                    bestMovie = movieName;
                }
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {bestPoints} ASCII sum.");
        }
    }
}

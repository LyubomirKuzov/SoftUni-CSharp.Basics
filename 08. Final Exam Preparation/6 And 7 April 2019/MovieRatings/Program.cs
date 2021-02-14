using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesCount = int.Parse(Console.ReadLine());

            double lowestRating = double.MaxValue;
            double highestRating = double.MinValue;
            double averageRating = 0;
            string lowestRatedMovie = string.Empty;
            string highestRatedMovie = string.Empty;

            for (int m = 0; m < moviesCount; m++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                averageRating += movieRating;

                if (movieRating > highestRating)
                {
                    highestRating = movieRating;
                    highestRatedMovie = movieName;
                }

                if (movieRating < lowestRating)
                {
                    lowestRating = movieRating;
                    lowestRatedMovie = movieName;
                }
            }

            Console.WriteLine($"{highestRatedMovie} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{lowestRatedMovie} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating / moviesCount:f1}");
        }
    }
}

using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerWalk = int.Parse(Console.ReadLine());
            int walksCount = int.Parse(Console.ReadLine());
            int caloriesEaten = int.Parse(Console.ReadLine());

            int caloriesBurned = 5 * minutesPerWalk * walksCount;

            if (caloriesBurned >= caloriesEaten / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }

            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}

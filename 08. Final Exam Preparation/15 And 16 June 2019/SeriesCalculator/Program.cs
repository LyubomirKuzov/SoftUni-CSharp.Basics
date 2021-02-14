using System;

namespace SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string showName = Console.ReadLine();
            int seasonCount = int.Parse(Console.ReadLine());
            int episodesCount = int.Parse(Console.ReadLine());
            double episodeDuration = double.Parse(Console.ReadLine());

            double totalTime = seasonCount * episodesCount * episodeDuration;
            totalTime *= 1.2;
            totalTime += seasonCount * 10;

            Console.WriteLine($"Total time needed to watch the {showName} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}

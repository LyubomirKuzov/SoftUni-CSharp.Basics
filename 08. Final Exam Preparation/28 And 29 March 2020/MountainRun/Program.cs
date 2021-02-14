using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsForOneMeter = double.Parse(Console.ReadLine());

            double delaysCount = Math.Floor(distanceInMeters / 50);
            double time = distanceInMeters * secondsForOneMeter + delaysCount * 30;

            if (time < recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {time:f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No! He was {time - recordInSeconds:f2} seconds slower.");
            }
        }
    }
}

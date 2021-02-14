using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int recordMinutes = int.Parse(Console.ReadLine());
            int recordSeconds = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsFor100Meters = double.Parse(Console.ReadLine());

            double delayedCount = distance / 120;
            double recordTime = recordMinutes * 60 + recordSeconds;
            double newTime = ((double)distance / 100) * secondsFor100Meters - delayedCount * 2.5;

            if (newTime <= recordTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {newTime:f3}.");
            }

            else
            {
                Console.WriteLine($"No, Marin failed! He was {newTime - recordTime:f3} second slower.");
            }
        }
    }
}

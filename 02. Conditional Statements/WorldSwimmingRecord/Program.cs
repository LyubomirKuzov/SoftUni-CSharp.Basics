using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double ivanSecondsForOneMeter = double.Parse(Console.ReadLine());

            int delaysCount = (int)Math.Floor(distance / 15);
            double ivanTime = distance * ivanSecondsForOneMeter + (delaysCount * 12.5);

            if (ivanTime < worldRecordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {ivanTime - worldRecordInSeconds:f2} seconds slower.");
            }
        }
    }
}

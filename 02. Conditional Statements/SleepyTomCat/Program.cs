using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInHome = int.Parse(Console.ReadLine());
            int daysAtWork = 365 - daysInHome;

            int timePlayed = daysInHome * 127 + daysAtWork * 63;

            if (timePlayed <= 30000)
            {
                timePlayed = 30000 - timePlayed;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{timePlayed / 60} hours and {timePlayed % 60} minutes less for play");
            }

            else
            {
                timePlayed -= 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{timePlayed / 60} hours and {timePlayed % 60} minutes more for play");
            }
        }
    }
}

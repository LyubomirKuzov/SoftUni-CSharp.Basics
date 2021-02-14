using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidaysCount = int.Parse(Console.ReadLine());
            int weeksInHomeTown = int.Parse(Console.ReadLine());

            int weeksInSofia = 48 - weeksInHomeTown;
            double gamesInHomeTown = weeksInHomeTown;
            double gamesInSofia = holidaysCount * 2.0 / 3 + weeksInSofia * 3.0 / 4;
            double totalGames = gamesInHomeTown + gamesInSofia;

            if (yearType == "leap")
            {
                totalGames *= 1.15;
            }

            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}

using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsCount = int.Parse(Console.ReadLine());
            int seniorsCount = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();

            double juniorsPrice = 0;
            double seniorsPrice = 0;

            switch (track)
            {
                case "trail":
                    juniorsPrice = 5.5;
                    seniorsPrice = 7;
                    break;

                case "cross-country":
                    juniorsPrice = 8;
                    seniorsPrice = 9.5;
                    break;

                case "downhill":
                    juniorsPrice = 12.25;
                    seniorsPrice = 13.75;
                    break;

                case "road":
                    juniorsPrice = 20;
                    seniorsPrice = 21.5;
                    break;
            }

            double money = juniorsCount * juniorsPrice + seniorsCount * seniorsPrice;

            if (track == "cross-country" && juniorsCount + seniorsCount >= 50)
            {
                money *= 0.75;
            }

            money *= 0.95;

            Console.WriteLine(money.ToString("f2"));
        }
    }
}

using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            int totalPoints = 301;
            int successfulShots = 0;
            int unsuccessfulShots = 0;

            while (true)
            {
                string zone = Console.ReadLine();

                if (zone == "Retire")
                {
                    Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                switch (zone)
                {
                    case "Double":
                        points *= 2;
                        break;

                    case "Triple":
                        points *= 3;
                        break;
                }

                if (totalPoints - points >= 0)
                {
                    successfulShots++;
                    totalPoints -= points;
                }

                else
                {
                    unsuccessfulShots++;
                    continue;
                }

                if (totalPoints == 0)
                {
                    Console.WriteLine($"{playerName} won the leg with {successfulShots} shots.");
                    break;
                }
            }
        }
    }
}

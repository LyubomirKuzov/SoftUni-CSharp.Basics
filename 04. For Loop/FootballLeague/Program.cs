using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int totalFansCount = int.Parse(Console.ReadLine());

            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 0; i < totalFansCount; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A':
                        sectorA++;
                        break;

                    case 'B':
                        sectorB++;
                        break;

                    case 'V':
                        sectorV++;
                        break;

                    case 'G':
                        sectorG++;
                        break;
                }
            }

            Console.WriteLine($"{(double)sectorA / totalFansCount * 100:f2}%");
            Console.WriteLine($"{(double)sectorB / totalFansCount * 100:f2}%");
            Console.WriteLine($"{(double)sectorV / totalFansCount * 100:f2}%");
            Console.WriteLine($"{(double)sectorG / totalFansCount * 100:f2}%");
            Console.WriteLine($"{(double)totalFansCount / stadiumCapacity * 100:f2}%");
        }
    }
}

using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double fieldArea = double.Parse(Console.ReadLine());
            double grapesHarvestedPerSquareMeter = double.Parse(Console.ReadLine());
            double neededLitersWine = double.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double totalGrapes = fieldArea * grapesHarvestedPerSquareMeter;
            double grapesForWine = totalGrapes * 0.4;
            double litersWineMade = grapesForWine / 2.5;

            if (litersWineMade < neededLitersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersWine - litersWineMade)} liters wine needed.");
            }

            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWineMade)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersWineMade - neededLitersWine)} liters left -> {Math.Ceiling((litersWineMade - neededLitersWine) / workersCount)} liters per person.");
            }
        }
    }
}

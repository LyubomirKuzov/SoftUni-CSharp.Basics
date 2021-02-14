using System;

namespace TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRocketPrice = double.Parse(Console.ReadLine());
            int tennisRocketsCount = int.Parse(Console.ReadLine());
            int shoesCount = int.Parse(Console.ReadLine());

            double rocketsPrice = tennisRocketPrice * tennisRocketsCount;
            double shoesPrice = tennisRocketPrice / 6 * shoesCount;
            double otherEquipment = (rocketsPrice + shoesPrice) / 5;
            double totalMoney = rocketsPrice + shoesPrice + otherEquipment;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalMoney / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalMoney * 7 / 8)}");
        }
    }
}

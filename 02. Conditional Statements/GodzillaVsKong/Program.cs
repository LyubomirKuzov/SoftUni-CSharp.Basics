using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());

            double decorationsPrice = movieBudget * 0.1;

            if (statistsCount > 150)
            {
                outfitPrice *= 0.9;
            }

            double totalPrice = decorationsPrice + statistsCount * outfitPrice;

            if (totalPrice > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - movieBudget:f2} leva more.");
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - totalPrice:f2} leva left.");
            }
        }
    }
}

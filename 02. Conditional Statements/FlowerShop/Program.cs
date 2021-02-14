using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double moneyEarned = magnoliasCount * 3.25 + hyacinthsCount * 4 + rosesCount * 3.50 + cactusesCount * 8;
            moneyEarned *= 0.95;

            if (moneyEarned >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(moneyEarned - presentPrice)} leva.");
            }

            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - moneyEarned)} leva.");
            }
        }
    }
}

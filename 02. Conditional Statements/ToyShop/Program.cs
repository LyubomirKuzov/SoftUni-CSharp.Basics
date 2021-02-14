using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int talkingDollsCount = int.Parse(Console.ReadLine());
            int teddybearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            int totalToysCount = puzzlesCount + talkingDollsCount + teddybearsCount + minionsCount + trucksCount;
            double totalMoneyEarned = puzzlesCount * 2.6 + talkingDollsCount * 3 + teddybearsCount * 4.1 + minionsCount * 8.2 + trucksCount * 2;

            if (totalToysCount >= 50)
            {
                totalMoneyEarned *= 0.75;
            }

            totalMoneyEarned *= 0.9;

            if (totalMoneyEarned >= tripPrice)
            {
                Console.WriteLine($"Yes! {totalMoneyEarned - tripPrice:f2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalMoneyEarned:f2} lv needed.");
            }
        }
    }
}

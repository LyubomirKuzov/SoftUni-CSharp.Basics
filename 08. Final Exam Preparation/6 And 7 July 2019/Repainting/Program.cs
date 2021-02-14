using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonAmount = int.Parse(Console.ReadLine());
            int litersPaintNeeded = int.Parse(Console.ReadLine());
            int litersThinner = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            double nylonPrice = nylonAmount * 1.50;
            double paintPrice = litersPaintNeeded * 14.50;
            double thinnerPrice = litersThinner * 5;

            double totalPrice = nylonPrice + paintPrice + thinnerPrice;
            totalPrice += ((double)(litersPaintNeeded * 0.1) * 14.50);
            totalPrice += 2 * 1.50;
            totalPrice += 0.40;

            double priceForWork = totalPrice * 0.3;
            priceForWork *= hoursNeeded;
            totalPrice += priceForWork;

            Console.WriteLine($"Total expenses: {totalPrice:f2} lv.");
        }
    }
}

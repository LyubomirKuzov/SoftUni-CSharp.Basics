using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double priceForSunbed = double.Parse(Console.ReadLine());
            double priceForUmbrella = double.Parse(Console.ReadLine());

            double umbrellasCount = Math.Ceiling((double)peopleCount / 2);
            double sunbedsCount = Math.Ceiling(peopleCount * 0.75);
            double totalPrice = peopleCount * tax + sunbedsCount * priceForSunbed + umbrellasCount * priceForUmbrella;

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}

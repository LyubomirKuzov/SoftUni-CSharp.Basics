using System;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double easterBreadsCount = Math.Ceiling((double)guestsCount / 3);
            double eggsCount = guestsCount * 2;
            double moneyNeeded = easterBreadsCount * 4 + eggsCount * 0.45;

            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"Lyubo bought {easterBreadsCount} Easter bread and {eggsCount} eggs.");
                Console.WriteLine($"He has {budget - moneyNeeded:f2} lv. left.");
            }

            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {moneyNeeded - budget:f2} lv. more.");
            }
        }
    }
}

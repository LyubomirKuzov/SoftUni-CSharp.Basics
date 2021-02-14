using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double percentAdditionalExpenses = (double)int.Parse(Console.ReadLine()) / 100;

            if (nightsCount > 7)
            {
                pricePerNight *= 0.95;
            }

            double additionalExpenses = budget * percentAdditionalExpenses;
            double moneySpent = nightsCount * pricePerNight + additionalExpenses;

            if (budget >= moneySpent)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - moneySpent:f2} leva after vacation.");
            }
            
            else
            {
                Console.WriteLine($"{moneySpent - budget:f2} leva needed.");
            }
        }
    }
}

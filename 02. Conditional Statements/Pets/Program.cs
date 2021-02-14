using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            double kgFoodLeft = double.Parse(Console.ReadLine());
            double kgForDogPerDay = double.Parse(Console.ReadLine());
            double kgForCatPerDay = double.Parse(Console.ReadLine());
            double gramsForTurtlePerDay = double.Parse(Console.ReadLine()) / 1000;

            double totalFoodEaten = daysCount * (kgForDogPerDay + kgForCatPerDay + gramsForTurtlePerDay);

            if (kgFoodLeft >= totalFoodEaten)
            {
                Console.WriteLine($"{Math.Floor(kgFoodLeft - totalFoodEaten)} kilos of food left.");
            }

            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodEaten - kgFoodLeft)} more kilos of food are needed.");
            }
        }
    }
}

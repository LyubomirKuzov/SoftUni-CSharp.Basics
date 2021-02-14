using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodKgBought = int.Parse(Console.ReadLine());

            int totalFoodEaten = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Adopted")
                {
                    break;
                }

                int foodEaten = int.Parse(input);
                totalFoodEaten += foodEaten;
            }

            if (foodKgBought >= totalFoodEaten)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodKgBought - totalFoodEaten} grams.");
            }

            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFoodEaten - foodKgBought} grams more.");
            }
        }
    }
}

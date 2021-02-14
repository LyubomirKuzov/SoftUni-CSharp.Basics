using System;

namespace FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            double foodAmount = double.Parse(Console.ReadLine());

            double foodEaten = 0;
            double cookiesAmount = 0;
            double totalDogFood = 0;
            double totalCatFood = 0;

            for (int d = 0; d < daysCount; d++)
            {
                int foodEatenByDog = int.Parse(Console.ReadLine());
                int foodEatenByCat = int.Parse(Console.ReadLine());

                totalDogFood += foodEatenByDog;
                totalCatFood += foodEatenByCat;
                int foodEatedToday = foodEatenByDog + foodEatenByCat;
                foodEaten += foodEatedToday;

                if ((d + 1) % 3 == 0)
                {
                    cookiesAmount += foodEatedToday * 0.1;
                }
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(cookiesAmount)}gr.");
            Console.WriteLine($"{(double)foodEaten / foodAmount * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(double)totalDogFood / foodEaten * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(double)totalCatFood / foodEaten * 100:f2}% eaten from the cat.");
        }
    }
}

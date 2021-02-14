using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadsCount = int.Parse(Console.ReadLine());

            int totalGramsSugar = 0;
            int totalGramsFlour = 0;
            int maxUsedSugar = int.MinValue;
            int maxUsedFlour = int.MinValue;

            for (int e = 0; e < easterBreadsCount; e++)
            {
                int gramsSugar = int.Parse(Console.ReadLine());
                int gramsFlour = int.Parse(Console.ReadLine());

                totalGramsSugar += gramsSugar;
                totalGramsFlour += gramsFlour;

                if (gramsSugar > maxUsedSugar)
                {
                    maxUsedSugar = gramsSugar;
                }

                if (gramsFlour > maxUsedFlour)
                {
                    maxUsedFlour = gramsFlour;
                }
            }

            double sugarPackages = Math.Ceiling((double)totalGramsSugar / 950);
            double flourPackages = Math.Ceiling((double)totalGramsFlour / 750);

            Console.WriteLine($"Sugar: {sugarPackages}");
            Console.WriteLine($"Flour: {flourPackages}");
            Console.WriteLine($"Max used flour is {maxUsedFlour} grams, max used sugar is {maxUsedSugar} grams.");
        }
    }
}

using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesCount = int.Parse(Console.ReadLine());

            int totalDetergent = bottlesCount * 750;
            int counter = 1;
            int platesCount = 0;
            int potsCount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{platesCount} dishes and {potsCount} pots were washed.");
                    Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
                    break;
                }

                int newDishes = int.Parse(input);

                if (counter % 3 == 0)
                {
                    totalDetergent = totalDetergent - (newDishes * 15);
                    potsCount += newDishes;
                }

                else
                {
                    totalDetergent = totalDetergent - (newDishes * 5);
                    platesCount += newDishes;
                }

                if (totalDetergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergent)} ml. more necessary!");
                    break;
                }

                counter++;
            }
        }
    }
}

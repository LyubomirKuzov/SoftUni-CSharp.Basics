using System;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitorsCount = int.Parse(Console.ReadLine());

            int backCount = 0;
            int chestCount = 0;
            int legsCount = 0;
            int absCount = 0;
            int proteinShakeCount = 0;
            int proteinBarCount = 0;

            for (int v = 0; v < visitorsCount; v++)
            {
                string muscleGroup = Console.ReadLine();

                switch (muscleGroup)
                {
                    case "Back":
                        backCount++;
                        break;

                    case "Chest":
                        chestCount++;
                        break;

                    case "Legs":
                        legsCount++;
                        break;

                    case "Abs":
                        absCount++;
                        break;

                    case "Protein shake":
                        proteinShakeCount++;
                        break;

                    case "Protein bar":
                        proteinBarCount++;
                        break;
                }
            }

            int trainingCount = backCount + chestCount + legsCount + absCount;
            int boughtProductCount = proteinBarCount + proteinShakeCount;

            Console.WriteLine($"{backCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legsCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{proteinShakeCount} - protein shake");
            Console.WriteLine($"{proteinBarCount} - protein bar");
            Console.WriteLine($"{(double)trainingCount / visitorsCount * 100:f2}% - work out");
            Console.WriteLine($"{(double)boughtProductCount / visitorsCount * 100:f2}% - protein");
        }
    }
}

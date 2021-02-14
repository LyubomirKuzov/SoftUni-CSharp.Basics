using System;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            string species = string.Empty;

            switch (animal)
            {
                case "dog":
                    species = "mammal";
                    break;

                case "snake":
                case "crocodile":
                case "tortoise":
                    species = "reptile";
                    break;

                default:
                    species = "unknown";
                    break;
            }

            Console.WriteLine(species);
        }
    }
}

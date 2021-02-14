using System;

namespace MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetForActors = double.Parse(Console.ReadLine());

            while (true)
            {
                string actor = Console.ReadLine();

                if (actor == "ACTION")
                {
                    Console.WriteLine($"We are left with {budgetForActors:f2} leva.");
                    break;
                }

                double salary = 0;

                if (actor.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                }

                else
                {
                    salary = budgetForActors * 0.2;
                }

                budgetForActors -= salary;

                if (budgetForActors < 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budgetForActors):f2} leva for our actors.");
                    break;
                }
            }
        }
    }
}

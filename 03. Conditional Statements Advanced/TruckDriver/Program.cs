using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometersPerMonth = double.Parse(Console.ReadLine());

            double moneyEarned = 0;

            if (kilometersPerMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        moneyEarned = 0.75;
                        break;

                    case "Summer":
                        moneyEarned = 0.9;
                        break;

                    case "Winter":
                        moneyEarned = 1.05;
                        break;
                }
            }

            else if (kilometersPerMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        moneyEarned = 0.95;
                        break;

                    case "Summer":
                        moneyEarned = 1.1;
                        break;

                    case "Winter":
                        moneyEarned = 1.25;
                        break;
                }
            }

            else if (kilometersPerMonth <= 20000)
            {
                moneyEarned = 1.45;
            }

            moneyEarned *= kilometersPerMonth * 4;
            moneyEarned *= 0.9;

            Console.WriteLine(moneyEarned.ToString("f2"));
        }
    }
}

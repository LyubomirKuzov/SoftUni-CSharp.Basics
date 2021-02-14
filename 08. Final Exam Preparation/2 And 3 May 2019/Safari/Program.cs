using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double neededLitersFuel = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double price = neededLitersFuel * 2.10 + 100;

            switch (dayOfWeek)
            {
                case "Saturday":
                    price *= 0.9;
                    break;

                case "Sunday":
                    price *= 0.8;
                    break;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Safari time! Money left: {budget - price:f2} lv. ");
            }

            else
            {
                Console.WriteLine($"Not enough money! Money needed: {price - budget:f2} lv.");
            }
        }
    }
}

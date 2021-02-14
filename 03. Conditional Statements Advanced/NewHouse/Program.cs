using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flowersType)
            {
                case "Roses":
                    price = 5;
                    break;

                case "Dahlias":
                    price = 3.8;
                    break;

                case "Tulips":
                    price = 2.8;
                    break;

                case "Narcissus":
                    price = 3;
                    break;

                case "Gladiolus":
                    price = 2.5;
                    break;
            }

            price *= flowersCount;

            if (flowersCount > 80 && flowersType == "Roses")
            {
                price *= 0.9;
            }

            else if (flowersCount > 90 && flowersType == "Dahlias")
            {
                price *= 0.85;
            }

            else if (flowersCount > 80 && flowersType == "Tulips")
            {
                price *= 0.85;
            }

            else if (flowersCount < 120 && flowersType == "Narcissus")
            {
                price *= 1.15;
            }

            else if (flowersCount < 80 && flowersType == "Gladiolus")
            {
                price *= 1.2;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - price:f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}

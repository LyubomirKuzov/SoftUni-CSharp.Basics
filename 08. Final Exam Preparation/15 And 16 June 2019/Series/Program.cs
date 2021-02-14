using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int seriesCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int s = 0; s < seriesCount; s++)
            {
                string seriesName = Console.ReadLine();
                double seriesPrice = double.Parse(Console.ReadLine());

                switch (seriesName)
                {
                    case "Thrones":
                        seriesPrice *= 0.5;
                        break;

                    case "Lucifer":
                        seriesPrice *= 0.6;
                        break;

                    case "Protector":
                        seriesPrice *= 0.7;
                        break;

                    case "TotalDrama":
                        seriesPrice *= 0.8;
                        break;

                    case "Area":
                        seriesPrice *= 0.9;
                        break;
                }

                totalPrice += seriesPrice;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {budget - totalPrice:f2} lv.");
            }

            else
            {
                Console.WriteLine($"You need {totalPrice - budget:f2} lv. more to buy the series!");
            }
        }
    }
}

using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char isHoliday = char.Parse(Console.ReadLine());

            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumsPrice = 2;
                    rosesPrice = 4.1;
                    tulipsPrice = 2.5;
                    break;

                case "Autumn":
                case "Winter":
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.5;
                    tulipsPrice = 4.15;
                    break;
            }

            if (isHoliday == 'Y')
            {
                chrysanthemumsPrice *= 1.15;
                rosesPrice *= 1.15;
                tulipsPrice *= 1.15;
            }

            double totalPrice = chrysanthemumsCount * chrysanthemumsPrice + rosesCount * rosesPrice + tulipsCount * tulipsPrice;

            if (season == "Spring" && tulipsCount > 7)
            {
                totalPrice *= 0.95;
            }

            if (season == "Winter" && rosesCount >= 10)
            {
                totalPrice *= 0.9;
            }

            if (chrysanthemumsCount + rosesCount + tulipsCount > 20)
            {
                totalPrice *= 0.8;
            }

            totalPrice += 2;

            Console.WriteLine(totalPrice.ToString("f2"));
        }
    }
}

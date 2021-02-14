using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());

            double currentProfit = 0;

            while (true)
            {
                string cocktailName = Console.ReadLine();

                if (cocktailName == "Party!")
                {
                    Console.WriteLine($"We need {desiredProfit - currentProfit:f2} leva more.");
                    break;
                }

                int cocktailsCount = int.Parse(Console.ReadLine());
                double cocktailPrice = cocktailName.Length;
                double orderPrice = cocktailPrice * cocktailsCount;

                if (orderPrice % 2 != 0)
                {
                    orderPrice *= 0.75;
                }

                currentProfit += orderPrice;

                if (currentProfit >= desiredProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
            }

            Console.WriteLine($"Club income - {currentProfit:f2} leva.");
        }
    }
}

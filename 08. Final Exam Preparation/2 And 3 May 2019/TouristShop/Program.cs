using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            int productsCounter = 0;
            int boughtProductsCount = 0;

            while (true)
            {
                string productName = Console.ReadLine();

                if (productName == "Stop")
                {
                    Console.WriteLine($"You bought {boughtProductsCount} products for {totalPrice:f2} leva.");
                    break;
                }

                double productPrice = double.Parse(Console.ReadLine());
                productsCounter++;

                if (productsCounter % 3 == 0)
                {
                    productPrice *= 0.5;
                }

                if (totalPrice + productPrice > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    totalPrice += productPrice;
                    Console.WriteLine($"You need {totalPrice - budget:f2} leva!");
                    break;
                }

                else
                {
                    totalPrice += productPrice;
                    boughtProductsCount++;
                }
            }
        }
    }
}

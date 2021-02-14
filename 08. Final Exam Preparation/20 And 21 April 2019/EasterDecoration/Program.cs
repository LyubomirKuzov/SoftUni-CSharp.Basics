using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int customersCount = int.Parse(Console.ReadLine());

            double totalMoneySpent = 0;

            for (int c = 0; c < customersCount; c++)
            {
                int productsCount = 0;
                double moneySpent = 0;

                while (true)
                {
                    string product = Console.ReadLine();

                    if (product == "Finish")
                    {
                        if (productsCount % 2 == 0)
                        {
                            moneySpent *= 0.8;
                        }

                        Console.WriteLine($"You purchased {productsCount} items for {moneySpent:f2} leva.");
                        totalMoneySpent += moneySpent;
                        break;
                    }

                    productsCount++;

                    switch (product)
                    {
                        case "basket":
                            moneySpent += 1.50;
                            break;

                        case "wreath":
                            moneySpent += 3.80;
                            break;

                        case "chocolate bunny":
                            moneySpent += 7;
                            break;
                    }
                }
            }

            Console.WriteLine($"Average bill per client is: {(double)totalMoneySpent / customersCount:f2} leva.");
        }
    }
}

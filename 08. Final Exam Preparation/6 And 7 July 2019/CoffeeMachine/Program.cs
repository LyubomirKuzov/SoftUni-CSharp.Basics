using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drinkType = Console.ReadLine();
            string sugarOption = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (drinkType)
            {
                case "Espresso":
                    switch (sugarOption)
                    {
                        case "Without":
                            price = 0.90;
                            break;

                        case "Normal":
                            price = 1;
                            break;

                        case "Extra":
                            price = 1.20;
                            break;
                    }
                    break;

                case "Cappuccino":
                    switch (sugarOption)
                    {
                        case "Without":
                            price = 1;
                            break;

                        case "Normal":
                            price = 1.20;
                            break;

                        case "Extra":
                            price = 1.60;
                            break;
                    }
                    break;

                case "Tea":
                    switch (sugarOption)
                    {
                        case "Without":
                            price = 0.50;
                            break;

                        case "Normal":
                            price = 0.60;
                            break;

                        case "Extra":
                            price = 0.70;
                            break;
                    }
                    break;
            }

            price *= drinksCount;

            if (sugarOption == "Without")
            {
                price *= 0.65;
            }

            if (drinkType == "Espresso" && drinksCount >= 5)
            {
                price *= 0.75;
            }

            if (price > 15)
            {
                price *= 0.8;
            }

            Console.WriteLine($"You bought {drinksCount} cups of {drinkType} for {price:f2} lv.");
        }
    }
}

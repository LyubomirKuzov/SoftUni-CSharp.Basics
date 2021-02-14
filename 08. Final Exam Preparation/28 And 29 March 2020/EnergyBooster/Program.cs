using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int setsCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (setSize)
            {
                case "small":
                    switch (fruit)
                    {
                        case "Watermelon":
                            price = 56;
                            break;

                        case "Mango":
                            price = 36.66;
                            break;

                        case "Pineapple":
                            price = 42.10;
                            break;

                        case "Raspberry":
                            price = 20;
                            break;
                    }
                    break;

                case "big":
                    switch (fruit)
                    {
                        case "Watermelon":
                            price = 28.70;
                            break;

                        case "Mango":
                            price = 19.60;
                            break;

                        case "Pineapple":
                            price = 24.80;
                            break;

                        case "Raspberry":
                            price = 15.20;
                            break;
                    }
                    break;
            }

            switch (setSize)
            {
                case "small":
                    price *= 2;
                    break;

                case "big":
                    price *= 5;
                    break;
            }

            price *= setsCount;

            if (price >= 400 && price <= 1000)
            {
                price *= 0.85;
            }

            else if (price > 1000)
            {
                price *= 0.5;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}

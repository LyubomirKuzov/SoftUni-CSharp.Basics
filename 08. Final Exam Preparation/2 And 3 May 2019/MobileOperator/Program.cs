﻿using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractDurationInYears = Console.ReadLine();
            string contractType = Console.ReadLine();
            string addedMobileInternet = Console.ReadLine();
            int monthsCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (contractDurationInYears)
            {
                case "one":
                    switch (contractType)
                    {
                        case "Small":
                            price = 9.98;
                            break;

                        case "Middle":
                            price = 18.99;
                            break;

                        case "Large":
                            price = 25.98;
                            break;

                        case "ExtraLarge":
                            price = 35.99;
                            break;
                    }
                    break;

                case "two":
                    switch (contractType)
                    {
                        case "Small":
                            price = 8.58;
                            break;

                        case "Middle":
                            price = 17.09;
                            break;

                        case "Large":
                            price = 23.59;
                            break;

                        case "ExtraLarge":
                            price = 31.79;
                            break;
                    }
                    break;
            }

            if (addedMobileInternet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }

                else if (price <= 30)
                {
                    price += 4.35;
                }

                else if (price > 30)
                {
                    price += 3.85;
                }
            }

            price *= monthsCount;

            if (contractDurationInYears == "two")
            {
                price *= 0.9625;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}

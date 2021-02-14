using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packageType = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            if (daysCount < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            double pricePerDay = 0;
            double discountPercentage = 0;

            switch (city)
            {
                case "Bansko":
                case "Borovets":
                    switch (packageType)
                    {
                        case "withEquipment":
                            pricePerDay = 100;
                            discountPercentage = 10;
                            break;

                        case "noEquipment":
                            pricePerDay = 80;
                            discountPercentage = 5;
                            break;

                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;

                case "Varna":
                case "Burgas":
                    switch (packageType)
                    {
                        case "withBreakfast":
                            pricePerDay = 130;
                            discountPercentage = 12;
                            break;

                        case "noBreakfast":
                            pricePerDay = 100;
                            discountPercentage = 7;
                            break;

                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input!");
                    return;
            }

            discountPercentage /= 100;
            double totalPrice = pricePerDay * daysCount;

            if (daysCount > 7)
            {
                totalPrice -= pricePerDay;
            }

            if (vipDiscount == "yes")
            {
                totalPrice *= (1 - discountPercentage);
            }

            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
        }
    }
}

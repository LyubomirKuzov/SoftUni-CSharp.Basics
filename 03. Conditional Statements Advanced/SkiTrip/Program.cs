using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int nightsCount = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string opinion = Console.ReadLine();

            double price = 0;

            switch (roomType)
            {
                case "room for one person":
                    price = 18;
                    break;

                case "apartment":
                    price = 25;

                    if (nightsCount < 10)
                    {
                        price *= 0.7;
                    }

                    else if (nightsCount >= 10 && nightsCount <= 15)
                    {
                        price *= 0.65;
                    }

                    else if (nightsCount > 15)
                    {
                        price *= 0.5;
                    }
                    break;

                case "president apartment":
                    price = 35;

                    if (nightsCount < 10)
                    {
                        price *= 0.9;
                    }

                    else if (nightsCount >= 10 && nightsCount <= 15)
                    {
                        price *= 0.85;
                    }

                    else if (nightsCount > 15)
                    {
                        price *= 0.8;
                    }
                    break;
            }

            price *= nightsCount;

            if (opinion == "positive")
            {
                price *= 1.25;
            }

            else if (opinion == "negative")
            {
                price *= 0.9;
            }

            Console.WriteLine(price.ToString("f2"));
        }
    }
}

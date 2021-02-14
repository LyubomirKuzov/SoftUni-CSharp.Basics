﻿using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string reservationDuration = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (destination)
            {
                case "France":
                    switch (reservationDuration)
                    {
                        case "21-23":
                            price = 30;
                            break;

                        case "24-27":
                            price = 35;
                            break;
                        case "28-31":
                            price = 40;
                            break;
                    }
                    break;

                case "Italy":
                    switch (reservationDuration)
                    {
                        case "21-23":
                            price = 28;
                            break;

                        case "24-27":
                            price = 32;
                            break;
                        case "28-31":
                            price = 39;
                            break;
                    }
                    break;

                case "Germany":
                    switch (reservationDuration)
                    {
                        case "21-23":
                            price = 32;
                            break;

                        case "24-27":
                            price = 37;
                            break;
                        case "28-31":
                            price = 43;
                            break;
                    }
                    break;
            }

            price *= nightsCount;

            Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");
        }
    }
}

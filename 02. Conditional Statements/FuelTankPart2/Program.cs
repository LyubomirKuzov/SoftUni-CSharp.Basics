using System;

namespace FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelAmount = double.Parse(Console.ReadLine());
            string clubCardPosession = Console.ReadLine();

            double price = 0;

            if (clubCardPosession == "Yes")
            {
                if (fuelType == "Gasoline")
                {
                    price = fuelAmount * 2.04;
                }

                else if (fuelType == "Diesel")
                {
                    price = fuelAmount * 2.21;
                }

                else if (fuelType == "Gas")
                {
                    price = fuelAmount * 0.85;
                }    
            }

            else if (clubCardPosession == "No")
            {
                if (fuelType == "Gasoline")
                {
                    price = fuelAmount * 2.22;
                }

                else if (fuelType == "Diesel")
                {
                    price = fuelAmount * 2.33;
                }

                else if (fuelType == "Gas")
                {
                    price = fuelAmount * 0.93;
                }
            }

            if (fuelAmount >= 20 && fuelAmount <= 25)
            {
                price *= 0.92;
            }

            else if (fuelAmount > 25)
            {
                price *= 0.9;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}

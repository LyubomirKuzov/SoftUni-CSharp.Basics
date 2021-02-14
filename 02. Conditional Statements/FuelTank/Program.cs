using System;
using System.Linq;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litersFuelInTank = double.Parse(Console.ReadLine());

            string[] validFuelTypes = new string[] { "Diesel", "Gas", "Gasoline" };

            if (validFuelTypes.Any(x => x == fuelType))
            {
                if (litersFuelInTank >= 25)
                {
                    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                }

                else
                {
                    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                }
            }

            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}

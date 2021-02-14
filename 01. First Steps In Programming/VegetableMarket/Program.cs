using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPricePerKg = double.Parse(Console.ReadLine());
            double fruitsPricePerKg = double.Parse(Console.ReadLine());
            double vegetablesAmount = double.Parse(Console.ReadLine());
            double fruitsAmount = double.Parse(Console.ReadLine());

            double totalPrice = vegetablesAmount * vegetablesPricePerKg + fruitsAmount * fruitsPricePerKg;

            totalPrice /= 1.94;

            Console.WriteLine(totalPrice.ToString("f2"));
        }
    }
}

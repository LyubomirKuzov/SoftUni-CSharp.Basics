using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoAmount = double.Parse(Console.ReadLine());
            double scadAmount = double.Parse(Console.ReadLine());
            double shellsAmount = double.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice * 1.6 * bonitoAmount;
            double scadPrice = spratPrice * 1.8 * scadAmount;
            double shellsPrice = 7.5 * shellsAmount;

            double totalPrice = bonitoPrice + scadPrice + shellsPrice;

            Console.WriteLine(totalPrice.ToString("f2"));
        }
    }
}

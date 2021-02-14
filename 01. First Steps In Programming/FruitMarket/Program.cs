using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasAmount = double.Parse(Console.ReadLine());
            double orangesAmount = double.Parse(Console.ReadLine());
            double raspberriesAmount = double.Parse(Console.ReadLine());
            double strawberriesAmount = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice * 0.5;
            double orangesPrice = raspberriesPrice * 0.6;
            double bananasPrice = raspberriesPrice * 0.2;

            double totalPrice = strawberriesAmount * strawberriesPrice + bananasAmount * bananasPrice + raspberriesAmount * raspberriesPrice + orangesAmount * orangesPrice;

            Console.WriteLine(totalPrice.ToString("f2"));
        }
    }
}

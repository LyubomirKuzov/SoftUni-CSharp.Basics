using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlyTax = int.Parse(Console.ReadLine());

            double shoesPrice = yearlyTax * 0.6;
            double uniformPrice = shoesPrice * 0.8;
            double ballPrice = uniformPrice / 4;
            double accessoariesPrice = ballPrice / 5;
            double totalPrice = shoesPrice + uniformPrice + ballPrice + accessoariesPrice + yearlyTax;

            Console.WriteLine(totalPrice.ToString("f2"));
        }
    }
}

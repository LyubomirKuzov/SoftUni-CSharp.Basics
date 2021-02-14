using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double cakePrice = hallRent * 0.2;
            double drinksPrice = cakePrice * 0.55;
            double animatorPrice = hallRent / 3;

            double totalExpenses = hallRent + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(totalExpenses);
        }
    }
}

using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            double litersCleanerChemical = double.Parse(Console.ReadLine());
            double percentageDiscount = double.Parse(Console.ReadLine()) / 100;

            double money = pensCount * 5.80 + markersCount * 7.20 + litersCleanerChemical * 1.20;
            money *= (1 - percentageDiscount);

            Console.WriteLine(money.ToString("f3"));
        }
    }
}

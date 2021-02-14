using System;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            int eggPackagesCount = int.Parse(Console.ReadLine());
            int packagesYeast = int.Parse(Console.ReadLine());

            double sugarPrice = flourPrice * 0.75;
            double eggPackagePrice = flourPrice * 1.1;
            double yeastPackagePrice = sugarPrice * 0.2;
            double totalMoney = flourPrice * kgFlour + sugarPrice * kgSugar + eggPackagePrice * eggPackagesCount + packagesYeast * yeastPackagePrice;

            Console.WriteLine(totalMoney.ToString("f2"));
        }
    }
}

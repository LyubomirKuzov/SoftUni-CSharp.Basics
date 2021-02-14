using System;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadsCount = int.Parse(Console.ReadLine());
            int eggPackages = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());

            double moneyForEggPaint = 12 * eggPackages * 0.15;
            double neededMoney = moneyForEggPaint + easterBreadsCount * 3.20 + eggPackages * 4.35 + kgCookies * 5.40;

            Console.Write(neededMoney.ToString("f2"));
        }
    }
}

using System;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuesPrice = rent * 0.7;
            double cateringPrice = statuesPrice * 0.85;
            double musicPrice = cateringPrice / 2;
            double expenses = rent + statuesPrice + cateringPrice + musicPrice;

            Console.WriteLine(expenses.ToString("f2"));
        }
    }
}

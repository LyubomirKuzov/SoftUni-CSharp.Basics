using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int confectionersCount = int.Parse(Console.ReadLine());
            int cakesPerDay = int.Parse(Console.ReadLine());
            int wafflesPerDay = int.Parse(Console.ReadLine());
            int pancakesPerDay = int.Parse(Console.ReadLine());

            double cakesIncomePerDay = cakesPerDay * 45;
            double wafflesIncomePerDay = wafflesPerDay * 5.80;
            double pancakesIncomePerDay = pancakesPerDay * 3.20;

            double totalIncome = confectionersCount * (cakesIncomePerDay + wafflesIncomePerDay + pancakesIncomePerDay) * daysCount;
            totalIncome = totalIncome * 7 / 8;

            Console.WriteLine(totalIncome);
        }
    }
}

using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int monthsOfContract = int.Parse(Console.ReadLine());
            double increasePercentage = double.Parse(Console.ReadLine()) / 100;

            double expectedMoney = depositedSum + monthsOfContract * ((depositedSum * increasePercentage) / 12);

            Console.WriteLine(expectedMoney.ToString("f2"));
        }
    }
}

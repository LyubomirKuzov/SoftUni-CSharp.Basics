using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthsCount = int.Parse(Console.ReadLine());

            double waterTotal = monthsCount * 20;
            double internetTotal = monthsCount * 15;
            double otherTotal = 0;
            double electricityTotal = 0;

            for (int i = 0; i < monthsCount; i++)
            {
                double electricityMonthly = double.Parse(Console.ReadLine());
                electricityTotal += electricityMonthly;

                double otherMonthly = (20 + 15 + electricityMonthly) * 1.2;
                otherTotal += otherMonthly;
            }

            double average = (double)(waterTotal + internetTotal + otherTotal + electricityTotal) / monthsCount;

            Console.WriteLine($"Electricity: {electricityTotal:f2} lv");
            Console.WriteLine($"Water: {waterTotal:f2} lv");
            Console.WriteLine($"Internet: {internetTotal:f2} lv");
            Console.WriteLine($"Other: {otherTotal:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}

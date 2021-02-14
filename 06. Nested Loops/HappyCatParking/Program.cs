using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());

            double tax = 0;

            for (int d = 1; d <= daysCount; d++)
            {
                double sumForDay = 0;

                for (int h = 1; h <= hoursPerDay; h++)
                {
                    if (d % 2 == 0 && h % 2 != 0)
                    {
                        sumForDay += 2.50;
                    }

                    else if (d % 2 != 0 && h % 2 == 0)
                    {
                        sumForDay += 1.25;
                    }

                    else
                    {
                        sumForDay += 1;
                    }
                }

                Console.WriteLine($"Day: {d} - {sumForDay:f2} leva");
                tax += sumForDay;
            }

            Console.WriteLine($"Total: {tax:f2} leva");
        }
    }
}

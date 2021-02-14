using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int d = 1; d <= daysCount; d++)
            {
                double priceForDay = 0;

                for (int h = 1; h <= hoursPerDay; h++)
                {
                    if (d % 2 == 0 && h % 2 != 0)
                    {
                        priceForDay += 2.50;
                    }

                    else if (d % 2 != 0 && h % 2 == 0)
                    {
                        priceForDay += 1.25;
                    }

                    else
                    {
                        priceForDay += 1;
                    }
                }

                Console.WriteLine($"Day: {d} - {priceForDay:f2} leva");
                totalPrice += priceForDay;
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}

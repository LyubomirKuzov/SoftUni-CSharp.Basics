using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadsCount = int.Parse(Console.ReadLine());

            int withMicrobus = 0;
            int withTruck = 0;
            int withTrain = 0;

            for (int i = 0; i < loadsCount; i++)
            {
                int loadWeight = int.Parse(Console.ReadLine());

                if (loadWeight >= 12)
                {
                    withTrain += loadWeight;
                }

                else if (loadWeight >= 4)
                {
                    withTruck += loadWeight;
                }

                else if (loadWeight < 4)
                {
                    withMicrobus += loadWeight;
                }
            }

            int totalTons = withMicrobus + withTruck + withTrain;
            double averagePrice = (double)(withMicrobus * 200 + withTruck * 175 + withTrain * 120) / totalTons;

            Console.WriteLine(averagePrice.ToString("f2"));
            Console.WriteLine($"{(double)withMicrobus / totalTons * 100:f2}%");
            Console.WriteLine($"{(double)withTruck / totalTons * 100:f2}%");
            Console.WriteLine($"{(double)withTrain / totalTons * 100:f2}%");
        }
    }
}

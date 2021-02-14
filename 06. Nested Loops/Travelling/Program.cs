using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                double moneyNeeded = double.Parse(Console.ReadLine());

                double moneySaved = 0;

                while (true)
                {
                    double income = double.Parse(Console.ReadLine());
                    moneySaved += income;

                    if (moneySaved >= moneyNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}

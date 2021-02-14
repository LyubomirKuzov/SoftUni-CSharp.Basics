using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double price = 0;

            if (distance >= 100)
            {
                price = distance * 0.06;
            }

            else if (distance >= 20)
            {
                price = distance * 0.09;
            }

            else
            {
                if (timeOfDay == "day")
                {
                    price = distance * 0.79 + 0.70;
                }

                else if (timeOfDay == "night")
                {
                    price = distance * 0.90 + 0.70;
                }
            }

            Console.WriteLine(price.ToString("f2"));
        }
    }
}

using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double result = 0;

            if (from == "mm")
            {
                if (to == "cm")
                {
                    result = amount / 10;
                }

                else if (to == "m")
                {
                    result = amount / 1000;
                }
            }

            else if (from == "cm")
            {
                if (to == "mm")
                {
                    result = amount * 10;
                }

                else if (to == "m")
                {
                    result = amount / 100;
                }
            }

            if (from == "m")
            {
                if (to == "mm")
                {
                    result = amount * 1000;
                }

                else if (to == "cm")
                {
                    result = amount * 100;
                }
            }

            Console.WriteLine(result.ToString("f3"));
        }
    }
}

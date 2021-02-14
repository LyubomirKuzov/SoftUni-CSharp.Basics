using System;

namespace WeatherForecastPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            string result = string.Empty;

            if (degrees >= 5 && degrees <= 11.9)
            {
                result = "Cold";
            }

            else if (degrees >= 12 && degrees <= 14.9)
            {
                result = "Cool";
            }

            else if (degrees >= 15 && degrees <= 20)
            {
                result = "Mild";
            }    

            else if (degrees >= 20.1 && degrees <= 25.9)
            {
                result = "Warm";
            }

            else if (degrees >= 26 && degrees <= 35)
            {
                result = "Hot";
            }

            else
            {
                result = "unknown";
            }

            Console.WriteLine(result);
        }
    }
}

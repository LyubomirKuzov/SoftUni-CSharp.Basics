using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int turnsCount = int.Parse(Console.ReadLine());

            double points = 0;
            int to9 = 0;
            int to19 = 0;
            int to29 = 0;
            int to39 = 0;
            int to50 = 0;
            int invalid = 0;

            for (int i = 0; i < turnsCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 50)
                {
                    if (number >= 0 && number <= 9)
                    {
                        points += number * 0.2;
                        to9++;
                    }

                    else if (number <= 19)
                    {
                        points += number * 0.3;
                        to19++;
                    }

                    else if (number <= 29)
                    {
                        points += number * 0.4;
                        to29++;
                    }

                    else if (number <= 39)
                    {
                        points += 50;
                        to39++;
                    }

                    else if (number <= 50)
                    {
                        points += 100;
                        to50++;
                    }
                }

                else
                {
                    points /= 2;
                    invalid++;
                }
            }

            Console.WriteLine(points.ToString("f2"));
            Console.WriteLine($"From 0 to 9: {(double)to9 / turnsCount * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(double)to19 / turnsCount * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(double)to29 / turnsCount * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(double)to39 / turnsCount * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(double)to50 / turnsCount * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(double)invalid / turnsCount * 100:f2}%");
        }
    }
}

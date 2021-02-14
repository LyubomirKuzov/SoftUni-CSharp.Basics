using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallHeight = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            double noPaintPercentage = double.Parse(Console.ReadLine()) / 100;

            double wallsArea = wallHeight * wallWidth * 4;
            double noPaintArea = wallsArea * noPaintPercentage;
            double paintArea = Math.Ceiling(wallsArea - noPaintArea);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Tired!")
                {
                    Console.WriteLine($"{paintArea} quadratic m left.");
                    break;
                }

                int currLitersToPaint = int.Parse(input);
                paintArea -= currLitersToPaint;

                if (paintArea <= 0)
                {
                    if (paintArea < 0)
                    {
                        Console.WriteLine($"All walls are painted and you have {Math.Abs(paintArea)} l paint left!" );
                    }

                    else if (paintArea == 0)
                    {
                        Console.WriteLine("All walls are painted! Great job, Pesho!");
                    }

                    break;
                }
            }
        }
    }
}

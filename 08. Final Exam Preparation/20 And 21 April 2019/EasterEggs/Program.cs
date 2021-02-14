using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggsCount = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            string mostPaintedColor = string.Empty;

            for (int e = 0; e < paintedEggsCount; e++)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        redEggs++;
                        break;

                    case "orange":
                        orangeEggs++;
                        break;

                    case "blue":
                        blueEggs++;
                        break;

                    case "green":
                        greenEggs++;
                        break;
                }
            }

            int mostPaintedColorCount = Math.Max(redEggs, Math.Max(orangeEggs, Math.Max(blueEggs, greenEggs)));

            if (mostPaintedColorCount == redEggs)
            {
                mostPaintedColor = "red";
            }

            else if (mostPaintedColorCount == orangeEggs)
            {
                mostPaintedColor = "orange";
            }

            else if (mostPaintedColorCount == blueEggs)
            {
                mostPaintedColor = "blue";
            }

            else if (mostPaintedColorCount == greenEggs)
            {
                mostPaintedColor = "green";
            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {mostPaintedColorCount} -> {mostPaintedColor}");
        }
    }
}

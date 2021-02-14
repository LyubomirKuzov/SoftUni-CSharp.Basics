using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double frontSideLength = double.Parse(Console.ReadLine());
            double sideWallLength = double.Parse(Console.ReadLine());
            double triangleSideHeight = double.Parse(Console.ReadLine());

            double greenPaintArea = (((frontSideLength * frontSideLength) * 2) - (2 * 1.2)) + (((frontSideLength * sideWallLength) * 2) - (1.5 * 1.5 * 2));
            double redPaintArea = (frontSideLength * sideWallLength * 2) + (2 * (frontSideLength * triangleSideHeight / 2));

            double greenPaintLiters = greenPaintArea / 3.4;
            double redPaintLiters = redPaintArea / 4.3;

            Console.WriteLine(greenPaintLiters.ToString("f2"));
            Console.WriteLine(redPaintLiters.ToString("f2"));
        }
    }
}

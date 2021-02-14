using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine(area.ToString("f2"));
            Console.WriteLine(perimeter.ToString("f2"));
        }
    }
}

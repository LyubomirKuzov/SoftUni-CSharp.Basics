using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (b1 + b2) * height / 2;

            Console.WriteLine(area.ToString("f2"));
        }
    }
}

using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double area = 0;

            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = Math.PI * Math.Pow(radius, 2);
            }
            
            else if (figure == "rectangle")
            {
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());

                area = firstSide * secondSide;
            }

            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                area = Math.Pow(side, 2);
            }

            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = side * height / 2;
            }

            Console.WriteLine(area.ToString("f3"));
        }
    }
}
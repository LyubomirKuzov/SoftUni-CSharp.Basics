using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double percentageTaken = double.Parse(Console.ReadLine()) / 100;

            double aquariumSpace = length * height * width;
            aquariumSpace = aquariumSpace * (1 - percentageTaken);

            Console.WriteLine(aquariumSpace / 1000);
        }
    }
}

using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine()) * 100;
            double hallWidth = double.Parse(Console.ReadLine()) * 100 - 100;

            int placesInLength = (int)hallLength / 120;
            int placesInWidth = (int)hallWidth / 70;

            int totalPlaces = placesInLength * placesInWidth - 3;

            Console.WriteLine(totalPlaces);
        }
    }
}

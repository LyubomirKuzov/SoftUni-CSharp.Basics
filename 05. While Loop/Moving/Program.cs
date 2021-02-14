using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());

            int totalFreeSpace = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{totalFreeSpace} Cubic meters left.");
                    break;
                }

                int boxesCount = int.Parse(input);
                totalFreeSpace -= boxesCount;

                if (totalFreeSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(totalFreeSpace)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}

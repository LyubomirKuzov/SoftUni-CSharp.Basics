using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());

            int cakeSize = cakeWidth * cakeHeight;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    break;
                }

                int pieces = int.Parse(input);
                cakeSize -= pieces;

                if (cakeSize <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                    break;
                }
            }
        }
    }
}

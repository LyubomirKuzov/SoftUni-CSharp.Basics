using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalGoal = int.Parse(Console.ReadLine());

            int currentGoal = finalGoal - 30;
            int totalJumpsCount = 0;

            while (true)
            {
                int currHeightJumpsCount = 0;

                while (true)
                {
                    int currJumpHeight = int.Parse(Console.ReadLine());
                    currHeightJumpsCount++;
                    totalJumpsCount++;

                    if (currJumpHeight > currentGoal)
                    {
                        currentGoal += 5;

                        if (currentGoal > finalGoal)
                        {
                            Console.WriteLine($"Tihomir succeeded, he jumped over {currentGoal - 5}cm after {totalJumpsCount} jumps.");
                            Environment.Exit(0);
                        }

                        break;
                    }

                    if (currHeightJumpsCount == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {currentGoal}cm after {totalJumpsCount} jumps.");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}

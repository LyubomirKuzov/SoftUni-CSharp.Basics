using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string showName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            double lunchBreakDuration = double.Parse(Console.ReadLine());

            double timeForEating = (double)lunchBreakDuration / 8;
            double timeForRest = (double)lunchBreakDuration / 4;
            lunchBreakDuration -= (timeForEating + timeForRest);

            if (lunchBreakDuration >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {showName} and left with {Math.Ceiling(lunchBreakDuration - episodeDuration)} minutes free time.");
            }

            else
            {
                Console.WriteLine($"You don't have enough time to watch {showName}, you need {Math.Ceiling(episodeDuration - lunchBreakDuration)} more minutes.");
            }
        }
    }
}

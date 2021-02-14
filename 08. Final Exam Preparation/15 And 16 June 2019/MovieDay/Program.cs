using System;

namespace MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForPictures = int.Parse(Console.ReadLine());
            int scenesCount = int.Parse(Console.ReadLine());
            int sceneDuration = int.Parse(Console.ReadLine());

            double timeForPreparation = (timeForPictures) * 0.15;
            double timeNeeded = timeForPreparation + sceneDuration * scenesCount;

            if (timeForPictures >= timeNeeded)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForPictures - timeNeeded)} minutes left!");
            }

            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(timeNeeded - timeForPictures)} minutes.");
            }
        }
    }
}

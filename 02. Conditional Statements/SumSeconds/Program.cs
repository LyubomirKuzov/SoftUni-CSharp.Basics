using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRacerTime = int.Parse(Console.ReadLine());
            int secondRacerTime = int.Parse(Console.ReadLine());
            int thirdRacerTime = int.Parse(Console.ReadLine());

            int totalTime = firstRacerTime + secondRacerTime + thirdRacerTime;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}

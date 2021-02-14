using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadsCount = int.Parse(Console.ReadLine());

            string winner = string.Empty;
            int maxPoints = 0;

            for (int e = 0; e < easterBreadsCount; e++)
            {
                string bakerName = Console.ReadLine();

                int bakerPoints = 0;

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "Stop")
                    {
                        Console.WriteLine($"{bakerName} has {bakerPoints} points.");
                        break;
                    }

                    int points = int.Parse(input);
                    bakerPoints += points;
                }

                if (bakerPoints > maxPoints)
                {
                    maxPoints = bakerPoints;
                    winner = bakerName;
                    Console.WriteLine($"{bakerName} is the new number 1!");
                }
            }

            Console.WriteLine($"{winner} won competition with {maxPoints} points!");
        }
    }
}

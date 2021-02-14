using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int cinemaCapacity = int.Parse(Console.ReadLine());

            double moneyEarned = 0;
            int peopleEntered = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Movie time!")
                {
                    Console.WriteLine($"There are {cinemaCapacity - peopleEntered} seats left in the cinema.");
                    break;
                }

                int people = int.Parse(input);

                if (people + peopleEntered > cinemaCapacity)
                {
                    Console.WriteLine("The cinema is full.");
                    break;
                }

                int currIncome = people * 5;

                if (people % 3 == 0)
                {
                    currIncome -= 5;
                }

                moneyEarned += currIncome;
                peopleEntered += people;

            }

            Console.WriteLine($"Cinema income - {moneyEarned} lv.");
        }
    }
}

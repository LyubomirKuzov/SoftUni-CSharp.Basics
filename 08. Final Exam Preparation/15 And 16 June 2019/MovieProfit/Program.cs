using System;

namespace MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());
            int ticketsCount = int.Parse(Console.ReadLine());
            double pricePerTicket = double.Parse(Console.ReadLine());
            double percentageForCinema = double.Parse(Console.ReadLine()) / 100;

            double moneyEarned = daysCount * ticketsCount * pricePerTicket;
            moneyEarned *= 1 - percentageForCinema;

            Console.WriteLine($"The profit from the movie {movieName} is {moneyEarned:f2} lv.");
        }
    }
}

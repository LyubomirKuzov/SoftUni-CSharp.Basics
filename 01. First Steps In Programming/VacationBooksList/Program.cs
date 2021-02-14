using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int maxReadablePagesPerHour = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());

            double hoursNeededPerDay = 1.0 * pagesCount / maxReadablePagesPerHour / daysAvailable;

            Console.WriteLine(hoursNeededPerDay);
        }
    }
}

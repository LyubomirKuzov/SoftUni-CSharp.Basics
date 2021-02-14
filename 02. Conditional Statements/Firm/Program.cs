using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeededToFinish = int.Parse(Console.ReadLine());
            double daysAvailable = double.Parse(Console.ReadLine());
            int overtimeWorkersCount = int.Parse(Console.ReadLine());

            double hoursWorked = Math.Floor(daysAvailable * 0.9 * 8 + daysAvailable * overtimeWorkersCount * 2);

            if (hoursWorked >= hoursNeededToFinish)
            {
                Console.WriteLine($"Yes!{hoursWorked - hoursNeededToFinish} hours left.");
            }

            else
            {
                Console.WriteLine($"Not enough time!{hoursNeededToFinish - hoursWorked} hours needed.");
            }
        }
    }
}

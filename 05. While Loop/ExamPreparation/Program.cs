using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarksAllowed = int.Parse(Console.ReadLine());

            int badMarksCount = 0;
            double averageMark = 0;
            int tasksCount = 0;
            string lastTaskName = string.Empty;

            while (true)
            {
                string task = Console.ReadLine();

                if (task == "Enough")
                {
                    Console.WriteLine($"Average score: {(double)averageMark / tasksCount:f2}");
                    Console.WriteLine($"Number of problems: {tasksCount}");
                    Console.WriteLine($"Last problem: {lastTaskName}");
                    break;
                }

                int mark = int.Parse(Console.ReadLine());
                lastTaskName = task;
                averageMark += mark;
                tasksCount++;

                if (mark <= 4)
                {
                    badMarksCount++;

                    if (badMarksCount == badMarksAllowed)
                    {
                        Console.WriteLine($"You need a break, {badMarksCount} poor grades.");
                        break;
                    }
                }
            }
        }
    }
}

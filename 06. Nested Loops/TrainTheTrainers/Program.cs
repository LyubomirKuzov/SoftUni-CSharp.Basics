using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());

            double totalAverageGrade = 0;
            int presentationsCount = 0;

            while (true)
            {
                string presentationName = Console.ReadLine();

                if (presentationName == "Finish")
                {
                    break;
                }

                presentationsCount++;
                double presentationAverageGrade = 0;

                for (int i = 0; i < judgesCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    presentationAverageGrade += grade;
                }

                totalAverageGrade += (double)presentationAverageGrade / judgesCount;
                Console.WriteLine($"{presentationName} - {(double)presentationAverageGrade / judgesCount:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {(double)totalAverageGrade / presentationsCount:f2}.");
        }
    }
}

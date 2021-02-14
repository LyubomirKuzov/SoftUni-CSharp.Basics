using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            int grade = 1;
            int badMarksCount = 0;
            double averageGrade = 0;

            while (true)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark >= 4)
                {
                    grade++;
                    averageGrade += mark;

                    if (grade > 12)
                    {
                        Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade / 12:f2}");
                        break;
                    }
                }

                else
                {
                    badMarksCount++;

                    if (badMarksCount > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grade} grade");
                        break;
                    }
                }
            }
        }
    }
}

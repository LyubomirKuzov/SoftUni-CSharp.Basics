using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            int below3Count = 0;
            int below4Count = 0;
            int below5Count = 0;
            int aboveOr5Count = 0;
            double averageGrade = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 3)
                {
                    below3Count++;
                }

                else if (grade < 4)
                {
                    below4Count++;
                }

                else if (grade < 5)
                {
                    below5Count++;
                }

                else if (grade >= 5)
                {
                    aboveOr5Count++;
                }

                averageGrade += grade;
            }

            averageGrade /= studentsCount;

            Console.WriteLine($"Top students: {(double)aboveOr5Count / studentsCount * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)below5Count / studentsCount * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: { (double)below4Count / studentsCount * 100:f2}%");
            Console.WriteLine($"Fail: {(double)below3Count / studentsCount * 100:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}

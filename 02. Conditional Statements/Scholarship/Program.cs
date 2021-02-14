using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double excellentGrageScholarship = 0;

            if (averageGrade >= 5.50)
            {
                excellentGrageScholarship = averageGrade * 25;

                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentGrageScholarship)} BGN");
            }

            else if (income < minimalWage && averageGrade > 4.50)
            {
                socialScholarship = minimalWage * 0.35;

                if (averageGrade >= 5.50)
                {
                    excellentGrageScholarship = averageGrade * 25;
                }

                if (excellentGrageScholarship == 0)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }

                else
                {
                    if (excellentGrageScholarship >= socialScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentGrageScholarship)} BGN");
                    }

                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                    }
                }
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}

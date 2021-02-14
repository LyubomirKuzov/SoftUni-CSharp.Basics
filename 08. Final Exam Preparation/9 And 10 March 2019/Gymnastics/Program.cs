using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string tool = Console.ReadLine();

            double difficultyGrade = 0;
            double presentationGrade = 0;

            switch (country)
            {
                case "Russia":
                    switch (tool)
                    {
                        case "ribbon":
                            difficultyGrade = 9.100;
                            presentationGrade = 9.400;
                            break;

                        case "hoop":
                            difficultyGrade = 9.300;
                            presentationGrade = 9.800;
                            break;

                        case "rope":
                            difficultyGrade = 9.600;
                            presentationGrade = 9.000;
                            break;
                    }
                    break;

                case "Bulgaria":
                    switch (tool)
                    {
                        case "ribbon":
                            difficultyGrade = 9.600;
                            presentationGrade = 9.400;
                            break;

                        case "hoop":
                            difficultyGrade = 9.550;
                            presentationGrade = 9.750;
                            break;

                        case "rope":
                            difficultyGrade = 9.500;
                            presentationGrade = 9.400;
                            break;
                    }
                    break;

                case "Italy":
                    switch (tool)
                    {
                        case "ribbon":
                            difficultyGrade = 9.200;
                            presentationGrade = 9.500;
                            break;

                        case "hoop":
                            difficultyGrade = 9.450;
                            presentationGrade = 9.350;
                            break;

                        case "rope":
                            difficultyGrade = 9.700;
                            presentationGrade = 9.150;
                            break;
                    }
                    break;
            }

            double totalGrade = difficultyGrade + presentationGrade;

            Console.WriteLine($"The team of {country} get {totalGrade:f3} on {tool}.");
            Console.WriteLine($"{100 - (totalGrade / 20 * 100):f2}%");
        }
    }
}

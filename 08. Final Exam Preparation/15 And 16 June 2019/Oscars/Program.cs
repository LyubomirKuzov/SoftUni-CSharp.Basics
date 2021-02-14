using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judgesCount = int.Parse(Console.ReadLine());

            for (int j = 0; j < judgesCount; j++)
            {
                string judgeName = Console.ReadLine();
                double pointsFromJudge = double.Parse(Console.ReadLine());

                pointsFromJudge = (double)(judgeName.Length * pointsFromJudge / 2);
                academyPoints += pointsFromJudge;

                if (academyPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }
            }

            if (academyPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:f1} more!");
            }
        }
    }
}

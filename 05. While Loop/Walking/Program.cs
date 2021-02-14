using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalSteps = 10000;

            int stepsTravelled = 0;

            bool goalReached = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());

                    stepsTravelled += stepsToHome;

                    if (stepsTravelled >= goalSteps)
                    {
                        goalReached = true;
                    }

                    break;
                }

                int steps = int.Parse(input);

                stepsTravelled += steps;

                if (stepsTravelled >= goalSteps)
                {
                    goalReached = true;
                    break;
                }
            }

            if (goalReached)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsTravelled - goalSteps} steps over the goal!");
            }

            else
            {
                Console.WriteLine($"{goalSteps - stepsTravelled} more steps to reach goal.");
            }
        }
    }
}

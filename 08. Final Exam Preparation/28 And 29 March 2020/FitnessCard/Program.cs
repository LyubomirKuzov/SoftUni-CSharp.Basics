using System;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentMoney = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double moneyNeeded = 0;

            switch (gender)
            {
                case 'm':
                    switch (sport)
                    {
                        case "Gym":
                            moneyNeeded = 42;
                            break;

                        case "Boxing":
                            moneyNeeded = 41;
                            break;

                        case "Yoga":
                            moneyNeeded = 45;
                            break;

                        case "Zumba":
                            moneyNeeded = 34;
                            break;

                        case "Dances":
                            moneyNeeded = 51;
                            break;

                        case "Pilates":
                            moneyNeeded = 39;
                            break;
                    }
                    break;

                case 'f':
                    switch (sport)
                    {
                        case "Gym":
                            moneyNeeded = 35;
                            break;

                        case "Boxing":
                            moneyNeeded = 37;
                            break;

                        case "Yoga":
                            moneyNeeded = 42;
                            break;

                        case "Zumba":
                            moneyNeeded = 31;
                            break;

                        case "Dances":
                            moneyNeeded = 53;
                            break;

                        case "Pilates":
                            moneyNeeded = 37;
                            break;
                    }
                    break;
            }

            if (age <= 19)
            {
                moneyNeeded *= 0.8;
            }

            if (currentMoney >= moneyNeeded)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }

            else
            {
                Console.WriteLine($"You don't have enough money! You need ${moneyNeeded - currentMoney:f2} more.");
            }
        }
    }
}

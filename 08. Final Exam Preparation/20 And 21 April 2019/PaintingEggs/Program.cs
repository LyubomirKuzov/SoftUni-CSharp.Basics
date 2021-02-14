using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColor = Console.ReadLine();
            int lotsCount = int.Parse(Console.ReadLine());

            double income = 0;

            switch (eggsSize)
            {
                case "Large":
                    switch (eggsColor)
                    {
                        case "Red":
                            income = 16;
                            break;

                        case "Green":
                            income = 12;
                            break;

                        case "Yellow":
                            income = 9;
                            break;
                    }
                    break;

                case "Medium":
                    switch (eggsColor)
                    {
                        case "Red":
                            income = 13;
                            break;

                        case "Green":
                            income = 9;
                            break;

                        case "Yellow":
                            income = 7;
                            break;
                    }
                    break;

                case "Small":
                    switch (eggsColor)
                    {
                        case "Red":
                            income = 9;
                            break;

                        case "Green":
                            income = 8;
                            break;

                        case "Yellow":
                            income = 5;
                            break;
                    }
                    break;
            }

            income *= lotsCount;
            income *= 0.65;

            Console.WriteLine($"{income:f2} leva.");
        }
    }
}

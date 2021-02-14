using System;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggsCount = int.Parse(Console.ReadLine());
            int secondPlayerEggsCount = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End of battle")
                {
                    Console.WriteLine($"Player one has {firstPlayerEggsCount} eggs left.");
                    Console.WriteLine($"Player two has {secondPlayerEggsCount} eggs left.");
                    break;
                }

                else if (input == "one")
                {
                    secondPlayerEggsCount--;
                }

                else if (input == "two")
                {
                    firstPlayerEggsCount--;
                }

                if (firstPlayerEggsCount == 0 || secondPlayerEggsCount == 0)
                {
                    break;
                }
            }

            if (firstPlayerEggsCount == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggsCount} eggs left.");
            }

            else if (secondPlayerEggsCount == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggsCount} eggs left.");
            }
        }
    }
}

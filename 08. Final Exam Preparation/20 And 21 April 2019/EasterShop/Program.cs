using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsInShop = int.Parse(Console.ReadLine());

            int boughtEggsCount = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{boughtEggsCount} eggs sold.");
                    break;
                }

                int eggsCount = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    if (eggsInShop >= eggsCount)
                    {
                        boughtEggsCount += eggsCount;
                        eggsInShop -= eggsCount;
                    }

                    else
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsInShop}.");
                        break;
                    }
                }

                else if (command == "Fill")
                {
                    eggsInShop += eggsCount;
                }
            }
        }
    }
}

using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevaCount = int.Parse(Console.ReadLine());
            int twoLevaCount = int.Parse(Console.ReadLine());
            int fiveLevaCount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int o = 0; o <= oneLevaCount; o++)
            {
                for (int t = 0; t <= twoLevaCount; t++)
                {
                    for (int f = 0; f <= fiveLevaCount; f++)
                    {
                        if (o * 1 + t * 2 + f * 5 == sum)
                        {
                            Console.WriteLine($"{o} * 1 lv. + {t} * 2 lv. + {f} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            int moneyConverted = (int)(money * 100);
            int coinsCount = 0;

            if (moneyConverted >= 200)
            {
                coinsCount += moneyConverted / 200;
                moneyConverted %= 200;
            }

            if (moneyConverted >= 100)
            {
                coinsCount += moneyConverted / 100;
                moneyConverted %= 100;
            }

            if (moneyConverted >= 50)
            {
                coinsCount += moneyConverted / 50;
                moneyConverted %= 50;
            }

            if (moneyConverted >= 20)
            {
                coinsCount += moneyConverted / 20;
                moneyConverted %= 20;
            }

            if (moneyConverted >= 10)
            {
                coinsCount += moneyConverted / 10;
                moneyConverted %= 10;
            }

            if (moneyConverted >= 5)
            {
                coinsCount += moneyConverted / 5;
                moneyConverted %= 5;
            }

            if (moneyConverted >= 2)
            {
                coinsCount += moneyConverted / 2;
                moneyConverted %= 2;
            }

            if (moneyConverted >= 1)
            {
                coinsCount += moneyConverted / 1;
                moneyConverted %= 1;
            }

            Console.WriteLine(coinsCount);
        }
    }
}

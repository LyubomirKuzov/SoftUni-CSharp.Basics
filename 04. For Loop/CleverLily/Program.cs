using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toysCount = 0;
            double moneySaved = 0;
            double moneyGivenForBirthday = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved += moneyGivenForBirthday;
                    moneyGivenForBirthday += 10;
                    moneySaved -= 1;
                }

                else
                {
                    toysCount++;
                }
            }

            moneySaved += toysCount * toyPrice;

            if (moneySaved >= laundryPrice)
            {
                Console.WriteLine($"Yes! {moneySaved - laundryPrice:f2}");
            }

            else
            {
                Console.WriteLine($"No! {laundryPrice - moneySaved:f2}");
            }
        }
    }
}

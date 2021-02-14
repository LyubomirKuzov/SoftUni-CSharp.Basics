﻿using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int finalYear = int.Parse(Console.ReadLine());

            int age = 18;

            for (int i = 1800; i <= finalYear; i++)
            {
                if (i % 2 == 0)
                {
                    inheritedMoney -= 12000;
                }

                else
                {
                    inheritedMoney = inheritedMoney - (12000 + (50 * age));
                }

                age++;
            }

            if (inheritedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
            }

            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}

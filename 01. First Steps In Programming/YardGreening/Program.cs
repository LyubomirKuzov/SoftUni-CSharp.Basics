using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetersToBeGreened = double.Parse(Console.ReadLine());

            double moneyNeeded = squareMetersToBeGreened * 7.61;
            double discount = moneyNeeded * 0.18;
            moneyNeeded -= discount;

            Console.WriteLine($"The final price is: {moneyNeeded:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}

using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            double bill = chickenMenus * 10.35 + fishMenus * 12.40 + vegetarianMenus * 8.15;
            double dessertPrice = bill * 0.2;
            bill += dessertPrice + 2.50;

            Console.WriteLine($"Total: {bill.ToString("f2")}");
        }
    }
}

using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());

            int totalSeats = rowsCount * colsCount;
            double price = 0;

            switch (projectionType)
            {
                case "Premiere":
                    price = 12;
                    break;

                case "Normal":
                    price = 7.5;
                    break;

                case "Discount":
                    price = 5;
                    break;
            }

            price *= totalSeats;
            Console.WriteLine(price.ToString("f2"));
        }
    }
}

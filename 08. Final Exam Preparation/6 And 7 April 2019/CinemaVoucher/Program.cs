using System;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInVoucher = double.Parse(Console.ReadLine());

            int purchasesCount = 0;
            int ticketsCount = 0;

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "End")
                {
                    break;
                }

                if (product.Length > 8)
                {
                    int ticketPrice = product[0] + product[1];

                    if (ticketPrice > moneyInVoucher)
                    {
                        break;
                    }

                    ticketsCount++;
                    moneyInVoucher -= ticketPrice;
                }

                else
                {
                    int productPrice = product[0];

                    if (productPrice > moneyInVoucher)
                    {
                        break;
                    }

                    purchasesCount++;
                    moneyInVoucher -= productPrice;
                }
            }

            Console.WriteLine(ticketsCount);
            Console.WriteLine(purchasesCount);
        }
    }
}

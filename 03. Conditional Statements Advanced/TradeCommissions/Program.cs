using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double salesAmount = double.Parse(Console.ReadLine());

            double percentage = 0;

            if (salesAmount >= 0)
            {
                switch (city)
                {
                    case "Sofia":

                        if (salesAmount >= 0 && salesAmount <= 500)
                        {
                            percentage = 5;
                        }

                        else if (salesAmount <= 1000)
                        {
                            percentage = 7;
                        }

                        else if (salesAmount <= 10000)
                        {
                            percentage = 8;
                        }

                        else if (salesAmount > 10000)
                        {
                            percentage = 12;
                        }

                        break;

                    case "Varna":

                        if (salesAmount >= 0 && salesAmount <= 500)
                        {
                            percentage = 4.5;
                        }

                        else if (salesAmount <= 1000)
                        {
                            percentage = 7.5;
                        }

                        else if (salesAmount <= 10000)
                        {
                            percentage = 10;
                        }

                        else if (salesAmount > 10000)
                        {
                            percentage = 13;
                        }

                        break;

                    case "Plovdiv":

                        if (salesAmount >= 0 && salesAmount <= 500)
                        {
                            percentage = 5.5;
                        }

                        else if (salesAmount <= 1000)
                        {
                            percentage = 8;
                        }

                        else if (salesAmount <= 10000)
                        {
                            percentage = 12;
                        }

                        else if (salesAmount > 10000)
                        {
                            percentage = 14.5;
                        }

                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

                if (percentage != 0)
                {
                    percentage /= 100;
                    Console.WriteLine((salesAmount * percentage).ToString("f2"));
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

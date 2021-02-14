using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int groupSize = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = string.Empty;

            switch (season)
            {
                case "Winter":

                    switch (typeOfGroup)
                    {
                        case "boys":
                            price = 9.6;
                            sport = "Judo";
                            break;

                        case "girls":
                            price = 9.6;
                            sport = "Gymnastics";
                            break;

                        case "mixed":
                            price = 10;
                            sport = "Ski";
                            break;
                    }

                    break;

                case "Spring":

                    switch (typeOfGroup)
                    {
                        case "boys":
                            price = 7.2;
                            sport = "Tennis";
                            break;

                        case "girls":
                            price = 7.2;
                            sport = "Athletics";
                            break;

                        case "mixed":
                            price = 9.5;
                            sport = "Cycling";
                            break;
                    }

                    break;

                case "Summer":

                    switch (typeOfGroup)
                    {
                        case "boys":
                            price = 15;
                            sport = "Football";
                            break;

                        case "girls":
                            price = 15;
                            sport = "Volleyball";
                            break;

                        case "mixed":
                            price = 20;
                            sport = "Swimming";
                            break;
                    }

                    break;
            }

            price *= groupSize * nightsCount;

            if (groupSize >= 50)
            {
                price *= 0.5;
            }

            else if (groupSize >= 20)
            {
                price *= 0.85;
            }

            else if (groupSize >= 10)
            {
                price *= 0.95;
            }

            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}

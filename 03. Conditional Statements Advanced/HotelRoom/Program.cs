using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    break;

                case "June":
                case "September":
                    studioPrice = 75.2;
                    apartmentPrice = 68.7;
                    break;

                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
            }

            studioPrice *= nightsCount;
            apartmentPrice *= nightsCount;

            if ((month == "May" || month == "October") && nightsCount > 14)
            {
                studioPrice *= 0.7;
            }

            else if ((month == "May" || month == "October") && nightsCount > 7)
            {
                studioPrice *= 0.95;
            }

            else if ((month == "June" || month == "September") && nightsCount > 14)
            {
                studioPrice *= 0.8;
            }

            if (nightsCount > 14)
            {
                apartmentPrice *= 0.9;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}

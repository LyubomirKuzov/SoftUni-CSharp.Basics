using System;

namespace WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();

            string result = string.Empty;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    result = "Working day";
                    break;

                case "Saturday":
                case "Sunday":
                    result = "Weekend";
                    break;

                default:
                    result = "Error";
                    break;
            }

            Console.WriteLine(result);
        }
    }
}

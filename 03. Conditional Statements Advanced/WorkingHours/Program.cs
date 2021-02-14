using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            string result = string.Empty;

            if (hour >= 10 && hour <= 18)
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        result = "open";
                        break;

                    case "Sunday":
                        result = "closed";
                        break;
                }
            }

            else
            {
                result = "closed";
            }

            Console.WriteLine(result);
        }
    }
}

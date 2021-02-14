using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int timeOfExam = hourOfExam * 60 + minuteOfExam;
            int timeOfArrival = hourOfArrival * 60 + minuteOfArrival;

            if (timeOfArrival > timeOfExam)
            {
                Console.WriteLine("Late");

                int difference = timeOfArrival - timeOfExam;

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }

                else
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;

                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }

            else if (timeOfArrival < timeOfExam - 30)
            {
                Console.WriteLine("Early");

                int difference = timeOfExam - timeOfArrival;

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }

                else
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;

                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }

            else
            {
                Console.WriteLine("On time");

                if (timeOfArrival != timeOfExam)
                {
                    Console.WriteLine($"{timeOfExam - timeOfArrival} minutes before the start");
                }
            }
        }
    }
}

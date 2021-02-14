using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTicketsCount = 0;
            int standardTicketsCount = 0;
            int kidTicketsCount = 0;

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    int totalTickets = studentTicketsCount + standardTicketsCount + kidTicketsCount;

                    Console.WriteLine($"Total tickets: {totalTickets}");
                    Console.WriteLine($"{(double)studentTicketsCount / totalTickets * 100:f2}% student tickets.");
                    Console.WriteLine($"{(double)standardTicketsCount / totalTickets * 100:f2}% standard tickets.");
                    Console.WriteLine($"{(double)kidTicketsCount / totalTickets * 100:f2}% kids tickets.");

                    break;
                }

                int freeSpaces = int.Parse(Console.ReadLine());
                int spacesTaken = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        Console.WriteLine($"{movieName} - {(double)spacesTaken / freeSpaces * 100:f2}% full.");
                        break;
                    }

                    spacesTaken++;

                    switch (ticketType)
                    {
                        case "student":
                            studentTicketsCount++;
                            break;

                        case "standard":
                            standardTicketsCount++;
                            break;

                        case "kid":
                            kidTicketsCount++;
                            break;
                    }

                    if (spacesTaken == freeSpaces)
                    {
                        Console.WriteLine($"{movieName} - {(double)spacesTaken / freeSpaces * 100:f2}% full.");
                        break;
                    }
                }
            }
        }
    }
}

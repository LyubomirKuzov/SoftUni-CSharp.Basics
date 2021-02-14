using System;
using System.Text;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsPerSector = int.Parse(Console.ReadLine());
            int seatsPerOddRow = int.Parse(Console.ReadLine());

            int seatsCount = 0;

            for (int s = 'A'; s <= lastSector; s++)
            {
                if (s != 'A')
                {
                    rowsPerSector++;
                }

                for (int r = 1; r <= rowsPerSector; r++)
                {
                    int seatsInCurrentRow = seatsPerOddRow;

                    if (r % 2 == 0)
                    {
                        seatsInCurrentRow += 2;
                    }

                    for (int p = 0; p < seatsInCurrentRow; p++)
                    {
                        seatsCount++;
                        Console.WriteLine($"{(char)s}{r}{(char)(p + 97)}");
                    }
                }
            }

            Console.WriteLine(seatsCount);
        }
    }
}

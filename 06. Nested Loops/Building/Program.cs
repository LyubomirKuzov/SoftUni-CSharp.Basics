using System;
using System.Text;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int f = floorsCount; f > 0; f--)
            {
                string identification = string.Empty;

                if (f == floorsCount)
                {
                    identification = "L";
                }

                else
                {
                    if (f % 2 == 0)
                    {
                        identification = "O";
                    }

                    else
                    {
                        identification = "A";
                    }
                }

                for (int r = 0; r < roomsPerFloor; r++)
                {
                    sb.Append($"{identification}{f}{r} ");
                }

                sb.ToString().TrimEnd();
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

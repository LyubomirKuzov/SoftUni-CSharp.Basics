using System;
using System.Text;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int menClientsCount = int.Parse(Console.ReadLine());
            int womenClientsCount = int.Parse(Console.ReadLine());
            int maxTablesCount = int.Parse(Console.ReadLine());

            int takenTablesCount = 0;
            bool noFreeTables = false;

            StringBuilder sb = new StringBuilder();

            for (int m = 1; m <= menClientsCount; m++)
            {
                for (int w = 1; w <= womenClientsCount; w++)
                {
                    sb.Append($"({m} <-> {w}) ");
                    takenTablesCount++;

                    if (takenTablesCount == maxTablesCount)
                    {
                        noFreeTables = true;
                        break;
                    }
                }

                if (noFreeTables)
                {
                    break;
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

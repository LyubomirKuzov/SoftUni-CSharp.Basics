using System;
using System.Text;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int r = 1; r <= N; r++)
            {
                string uniqueSymbol = string.Empty;

                if (r == 1 || r == N)
                {
                    uniqueSymbol = "+ ";
                }

                else
                {
                    uniqueSymbol = "| ";
                }

                sb.Append(uniqueSymbol);

                for (int i = 0; i < N - 2; i++)
                {
                    sb.Append("- ");
                }

                sb.AppendLine(uniqueSymbol.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

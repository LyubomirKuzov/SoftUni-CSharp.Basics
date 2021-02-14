using System;
using System.Text;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int middleRow = FindMiddleRow(N);
            StringBuilder sb = new StringBuilder();

            for (int r = 1; r <= N; r++)
            {
                if (r == 1 || r == N)
                {
                    sb.AppendLine(new string('*', 2 * N) + new string(' ', N) + new string('*', 2 * N));
                }

                else
                {
                    sb.Append('*' + new string('/', 2 * N - 2) + '*');

                    if (r == middleRow)
                    {
                        sb.Append(new string('|', N));
                    }

                    else
                    {
                        sb.Append(new string(' ', N));
                    }

                    sb.AppendLine('*' + new string('/', 2 * N - 2) + '*');
                }
            }

            Console.WriteLine(sb.ToString());
        }

        private static int FindMiddleRow(int N)
        {
            if (N % 2 == 0)
            {
                return N / 2;
            }

            return N / 2 + 1;
        }
    }
}

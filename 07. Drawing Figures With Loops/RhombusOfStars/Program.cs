using System;
using System.Text;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int r = 1; r <= N; r++)
            {
                sb.Append(new string(' ', N - r));

                for (int c = 1; c <= r; c++)
                {
                    sb.Append($"* ");
                }

                sb.AppendLine();
            }

            for (int r = N - 1; r > 0; r--)
            {
                sb.Append(new string(' ', N - r));

                for (int c = 1; c <= r; c++)
                {
                    sb.Append($"* ");
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

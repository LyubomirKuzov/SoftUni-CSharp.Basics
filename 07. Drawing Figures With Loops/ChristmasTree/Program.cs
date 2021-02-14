using System;
using System.Text;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string(' ', N + 1) + '|');

            for (int r = 1; r <= N; r++)
            {
                sb.Append(new string(' ', N - r) + new string('*', r) + " | ");
                sb.AppendLine(new string('*', r));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

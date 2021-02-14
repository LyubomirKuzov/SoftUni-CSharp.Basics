using System;
using System.Text;

namespace TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    sb.Append("$ ");
                }

                sb.ToString().Trim();
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

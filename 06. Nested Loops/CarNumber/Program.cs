using System;
using System.Text;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    for (int c = start; c <= end; c++)
                    {
                        for (int d = start; d <= end; d++)
                        {
                            if ((a % 2 == 0 && d % 2 != 0) || (a % 2 != 0 && d % 2 == 0))
                            {
                                if (a > d && (b + c) % 2 == 0)
                                {
                                    sb.Append($"{a}{b}{c}{d} ");
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

using System;
using System.Text;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a + b == c + d && N % (a + b) == 0)
                            {
                                sb.Append($"{a}{b}{c}{d} ");
                            }
                        }
                    }
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

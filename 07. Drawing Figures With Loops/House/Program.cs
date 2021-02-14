using System;
using System.Text;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int leftIndex = 0;
            int rightIndex = 0;
            SetIndexes(N, ref leftIndex, ref rightIndex);

            for (int r = 1; r <= N; r++)
            {
                while (leftIndex >= 1 && rightIndex <= N)
                {
                    for (int c = 1; c <= N; c++)
                    {
                        if (c >= leftIndex && c <= rightIndex)
                        {
                            sb.Append('*');
                        }

                        else
                        {
                            sb.Append('-');
                        }
                    }

                    sb.AppendLine();
                    leftIndex--;
                    rightIndex++;
                    r++;
                }

                sb.AppendLine('|' + new string('*', N - 2) + '|');
            }

            Console.WriteLine(sb.ToString());
        }

        private static void SetIndexes(int size, ref int leftIndex, ref int rightIndex)
        {
            if (size % 2 == 0)
            {
                leftIndex = size / 2;
                rightIndex = leftIndex + 1;
            }

            else
            {
                leftIndex = size / 2 + 1;
                rightIndex = leftIndex;
            }
        }
    }
}

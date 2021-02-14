using System;
using System.Text;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int leftIndex = 0;
            int rightIndex = 0;
            bool halfReached = false;
            DetermineIndexes(N, ref leftIndex, ref rightIndex);

            if (N == 1)
            {
                sb.AppendLine("*");
            }

            else if (N == 2)
            {
                sb.AppendLine("**");
            }

            else
            {
                for (int r = 1; r <= N; r++)
                {
                    if (!halfReached)
                    {
                        while (leftIndex >= 1 && rightIndex <= N)
                        {
                            for (int c = 1; c <= N; c++)
                            {
                                if (c == leftIndex || c == rightIndex)
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
                    }

                    halfReached = true;

                    if (leftIndex < 1 && rightIndex > N)
                    {
                        leftIndex = 2;
                        rightIndex = N - 1;
                    }

                    for (int c = 1; c <= N; c++)
                    {
                        if (c == leftIndex || c == rightIndex)
                        {
                            sb.Append('*');
                        }

                        else
                        {
                            sb.Append('-');
                        }
                    }

                    if (leftIndex == rightIndex - 1 || leftIndex == rightIndex)
                    {
                        break;
                    }

                    leftIndex++;
                    rightIndex--;
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb.ToString());
        }

        private static void DetermineIndexes(int size, ref int leftIndex, ref int rightIndex)
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

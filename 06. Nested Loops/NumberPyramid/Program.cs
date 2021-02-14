using System;
using System.Text;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            bool numberReached = false;
            StringBuilder sb = new StringBuilder();

            for (int r = 1; r <= N; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    sb.Append(currentNumber + " ");
                    currentNumber++;

                    if (currentNumber > N)
                    {
                        numberReached = true;
                        break;
                    }
                }

                if (numberReached)
                {
                    break;
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

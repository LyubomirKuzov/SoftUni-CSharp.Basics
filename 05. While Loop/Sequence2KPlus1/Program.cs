using System;

namespace Sequence2KPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int nextNumber = 0;

            while (true)
            {
                nextNumber = 2 * nextNumber + 1;

                if (nextNumber <= N)
                {
                    Console.WriteLine(nextNumber);
                }

                else
                {
                    break;
                }
            }
        }
    }
}

using System;
using System.Text;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int maxPasswordsCount = int.Parse(Console.ReadLine());

            char A = (char)35;
            char B = (char)64;
            int passwordsCounter = 0;
            bool maxPasswordsReached = false;
            StringBuilder sb = new StringBuilder();

            while (!maxPasswordsReached)
            {
                for (int x = 1; x <= numberA; x++)
                {
                    for (int y = 1; y <= numberB; y++)
                    {
                        if (A > (char)55)
                        {
                            A = (char)35;
                        }

                        if (B > 96)
                        {
                            B = (char)64;
                        }

                        sb.Append($"{A}{B}{x}{y}{B}{A}|");
                        A++;
                        B++;
                        passwordsCounter++;

                        if (passwordsCounter == maxPasswordsCount || (x == numberA && y == numberB))
                        {
                            maxPasswordsReached = true;
                            break;
                        }
                    }

                    if (maxPasswordsReached == true)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

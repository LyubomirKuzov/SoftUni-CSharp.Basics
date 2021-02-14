using System;
using System.Text;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int passwordsCounter = 0;
            string password = string.Empty;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d)
                            {
                                if (a * b + c * d == M)
                                {
                                    passwordsCounter++;
                                    sb.Append($"{a}{b}{c}{d} ");

                                    if (passwordsCounter == 4)
                                    {
                                        password = $"{a}{b}{c}{d}";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (sb.ToString().Length > 0)
            {
                Console.WriteLine(sb.ToString().Trim());
            }

            if (passwordsCounter >= 4)
            {
                Console.WriteLine($"Password: {password}");
            }

            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}

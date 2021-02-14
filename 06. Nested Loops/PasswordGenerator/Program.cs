using System;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberL = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int a = 1; a <= numberN; a++)
            {
                for (int b = 1; b <= numberN; b++)
                {
                    for (int c = 97; c < 97 + numberL; c++)
                    {
                        for (int d = 97; d < 97 + numberL; d++)
                        {
                            for (int e = 1; e <= numberN; e++)
                            {
                                if (e > a && e > b)
                                {
                                    sb.Append($"{a}{b}{(char)c}{(char)d}{e} ");
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

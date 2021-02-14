using System;
using System.Text;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startingLetter = char.Parse(Console.ReadLine());
            char endingLetter = char.Parse(Console.ReadLine());
            char letterToAvoid = char.Parse(Console.ReadLine());

            int combinationsCount = 0;
            StringBuilder sb = new StringBuilder();

            for (int a = startingLetter; a <= endingLetter; a++)
            {
                for (int b = startingLetter; b <= endingLetter; b++)
                {
                    for (int c = startingLetter; c <= endingLetter; c++)
                    {
                        if (a != letterToAvoid && b != letterToAvoid && c != letterToAvoid)
                        {
                            combinationsCount++;
                            sb.Append($"{(char)a}{(char)b}{(char)c} ");
                        }
                    }
                }
            }

            sb.Append(combinationsCount);

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

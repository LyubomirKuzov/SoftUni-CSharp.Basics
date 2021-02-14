using System;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxPower = 0;
            string mostPowerfulWord = string.Empty;

            while (true)
            {
                string word = Console.ReadLine();

                if (word == "End of words")
                {
                    break;
                }

                double wordSum = 0;

                for (int s = 0; s < word.Length; s++)
                {
                    wordSum += word[s];
                }

                switch (char.ToLower(word[0]))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        wordSum *= word.Length;
                        break;

                    default:
                        wordSum = Math.Floor((double)wordSum / word.Length);
                        break;
                }

                if (wordSum > maxPower)
                {
                    maxPower = wordSum;
                    mostPowerfulWord = word;
                }
            }

            Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {maxPower}");
        }
    }
}

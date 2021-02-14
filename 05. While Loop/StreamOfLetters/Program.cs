using System;
using System.Text;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder();
            StringBuilder word = new StringBuilder();
            bool cMet = false;
            bool oMet = false;
            bool nMet = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine(message.ToString());
                    break;
                }

                char letter = char.Parse(input);

                if (char.IsLetter(letter))
                {
                    if (letter == 'c' && !cMet)
                    {
                        cMet = true;
                    }

                    else if (letter == 'o' && !oMet)
                    {
                        oMet = true;
                    }

                    else if (letter == 'n' && !nMet)
                    {
                        nMet = true;
                    }

                    else
                    {
                        word.Append(letter);
                    }

                    if (cMet && oMet && nMet)
                    {
                        message.Append(word.ToString() + " ");
                        word.Clear();
                        cMet = false;
                        oMet = false;
                        nMet = false;
                    }
                }
            }
        }
    }
}

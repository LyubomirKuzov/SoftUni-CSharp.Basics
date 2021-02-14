using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string receivedPassword = Console.ReadLine();

            if (receivedPassword == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

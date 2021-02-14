using System;

namespace Number100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string result = string.Empty;

            if (number < 100)
            {
                result = "Less than 100";
            }

            else if (number <= 200)
            {
                result = "Between 100 and 200";
            }

            else if (number > 200)
            {
                result = "Greater than 200";
            }

            Console.WriteLine(result);
        }
    }
}

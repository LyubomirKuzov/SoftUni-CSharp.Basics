using System;
using System.Text;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 1111; i <= 9999; i++)
            {
                bool specialNumber = true;

                string number = i.ToString();

                for (int j = 0; j < number.Length; j++)
                {
                    int digit = int.Parse(number[j].ToString());

                    if (digit == 0 || N % digit != 0)
                    {
                        specialNumber = false;
                        break;
                    }
                }

                if (specialNumber)
                {
                    sb.Append(number + " ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

using System;
using System.Text;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            if (firstNum > secondNum)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }

            for (int n = firstNum; n <= secondNum; n++)
            {
                string number = n.ToString();

                int evenSum = 0;
                int oddSum = 0;

                for (int m = 0; m < number.Length; m++)
                {
                    if (m % 2 == 0)
                    {
                        evenSum += int.Parse(number[m].ToString());
                    }

                    else
                    {
                        oddSum += int.Parse(number[m].ToString());
                    }
                }

                if (evenSum == oddSum)
                {
                    sb.Append(number + " ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

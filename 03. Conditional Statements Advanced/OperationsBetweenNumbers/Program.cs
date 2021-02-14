using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());

            double result = 0;
            string oddOrEven = string.Empty;

            if ((oper == '/' || oper == '%') && secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }

            else
            {
                switch (oper)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        break;

                    case '-':
                        result = firstNumber - secondNumber;
                        break;

                    case '*':
                        result = firstNumber * secondNumber;
                        break;

                    case '/':
                        result = (double)firstNumber / secondNumber;
                        break;

                    case '%':
                        result = firstNumber % secondNumber;
                        break;
                }
            }

            if (oper == '+' || oper == '-' || oper == '*')
            {
                Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
            }

            else if (oper == '/' && secondNumber != 0)
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");
            }

            else if (oper == '%' && secondNumber != 0)
            {
                Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
            }
        }
    }
}

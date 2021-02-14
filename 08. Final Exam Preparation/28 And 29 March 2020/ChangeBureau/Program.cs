using System;

namespace ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinsCount = int.Parse(Console.ReadLine());
            double chineseUansCount = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine()) / 100;

            double leva = bitcoinsCount * 1168;
            double dollars = chineseUansCount * 0.15;
            leva += dollars * 1.76;
            double euros = leva / 1.95;
            euros *= (1 - commission);

            Console.WriteLine(euros.ToString("f2"));
        }
    }
}

using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double poolCapacity = double.Parse(Console.ReadLine());
            double firstPipeDebit = double.Parse(Console.ReadLine());
            double secondPipeDebit = double.Parse(Console.ReadLine());
            double hoursWorkerIsAway = double.Parse(Console.ReadLine());

            double waterFromFirstPipe = firstPipeDebit * hoursWorkerIsAway;
            double waterFromSecondPipe = secondPipeDebit * hoursWorkerIsAway;
            double waterInPool = waterFromFirstPipe + waterFromSecondPipe;

            if (waterInPool > poolCapacity)
            {
                Console.WriteLine($"For {hoursWorkerIsAway} hours the pool overflows with {waterInPool - poolCapacity:f2} liters.");
            }

            else
            {
                Console.WriteLine($"The pool is {waterInPool / poolCapacity * 100.0:f2}% full. Pipe 1: {waterFromFirstPipe / waterInPool * 100.0:f2}%. Pipe 2: {waterFromSecondPipe / waterInPool * 100.0:f2}%.");
            }
        }
    }
}

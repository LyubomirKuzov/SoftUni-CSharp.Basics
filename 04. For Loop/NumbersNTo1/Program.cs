﻿using System;

namespace NumbersNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = N; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

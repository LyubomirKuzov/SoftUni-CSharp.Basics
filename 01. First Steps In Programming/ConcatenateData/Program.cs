﻿using System;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();

            Console.WriteLine(string.Format("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, city));
        }
    }
}

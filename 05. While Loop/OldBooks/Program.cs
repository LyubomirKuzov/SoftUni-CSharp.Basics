using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string desiredBook = Console.ReadLine();

            bool bookFound = false;
            int checkedBooksCount = 0;

            while (true)
            {
                string book = Console.ReadLine();

                if (book == "No More Books")
                {
                    break;
                }

                checkedBooksCount++;

                if (book == desiredBook)
                {
                    bookFound = true;
                    break;
                }
            }

            if (bookFound)
            {
                Console.WriteLine($"You checked {checkedBooksCount - 1} books and found it.");
            }

            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooksCount} books.");
            }
        }
    }
}

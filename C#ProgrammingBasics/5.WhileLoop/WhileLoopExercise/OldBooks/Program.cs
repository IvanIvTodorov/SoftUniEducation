using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();

            string book = "";
            int number = 0;

            while (book != "No More Books")
            {
                book = Console.ReadLine();
                if (book == favBook)
                {
                    Console.WriteLine($"You checked {number} books and found it.");
                    Environment.Exit(0);
                }
                else if (book != "No More Books")
                {
                    number += 1;
                }
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {number} books.");
        }
    }
}

using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookLookedFor = Console.ReadLine();
            int titels = 0;
            string bookTitel = Console.ReadLine();

            while (bookTitel != "No More Books")
            {
                if (bookTitel == bookLookedFor)
                {
                    Console.WriteLine($"You checked {titels} books and found it.");
                    break;
                }
                titels++;
                bookTitel = Console.ReadLine();
            }
            if (bookTitel == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {titels} books.");
            }

        }
    }
}

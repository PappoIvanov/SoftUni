using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            bool isEnd = false;
            int studentTicketsCounter = 0;
            int standartTicketsCounter = 0;
            int kidTicketsCounter = 0;
            int totalTickets = 0;
            int totalTicketsForAMovie = 0;
            int freeSpaces = 0;

            while (movieName != "Finish")
            {
                freeSpaces = int.Parse(Console.ReadLine());
                int spaceCounter = freeSpaces;

                while (spaceCounter > 0)
                {
                    string typeOfTicket = Console.ReadLine();
                    spaceCounter--;

                    switch (typeOfTicket)
                    {
                        case "student": studentTicketsCounter++; totalTicketsForAMovie++; totalTickets++; break;
                        case "standard": standartTicketsCounter++; totalTicketsForAMovie++; totalTickets++; break;
                        case "kid": kidTicketsCounter++; totalTicketsForAMovie++; totalTickets++; break;
                        case "End": isEnd = true; break;
                    }

                    if (isEnd) break;

                }

                Console.WriteLine($"{movieName} - {1.0 * totalTicketsForAMovie / freeSpaces * 100:f2}% full.");
                totalTicketsForAMovie = 0;
                isEnd = false;

                movieName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{1.0 * studentTicketsCounter / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double) standartTicketsCounter / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{1.0 * kidTicketsCounter / totalTickets * 100:f2}% kids tickets.");
        }
    }
}

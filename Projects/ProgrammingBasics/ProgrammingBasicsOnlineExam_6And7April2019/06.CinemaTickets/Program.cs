using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int studentTicketsCounter = 0;
            int standartTicketsCounter = 0;
            int kidTicketsCounter = 0;
            int totalTicketsCounter = 0;
            int amountOfTicketsForCurrentProjection = 0;

            while (movieName != "Finish")
            {
                int freeSpaces = int.Parse(Console.ReadLine());
                string typeOfProjection = Console.ReadLine();
                int leftSpaces = freeSpaces;

                while (typeOfProjection != "End")
                {
                    leftSpaces--;
                    switch (typeOfProjection)
                    {
                        case "student": studentTicketsCounter++; totalTicketsCounter++; amountOfTicketsForCurrentProjection++; break;
                        case "standard": standartTicketsCounter++; totalTicketsCounter++; amountOfTicketsForCurrentProjection++; break;
                        case "kid": kidTicketsCounter++; totalTicketsCounter++; amountOfTicketsForCurrentProjection++; break;
                    }

                    if (leftSpaces == 0) { break; }

                    typeOfProjection = Console.ReadLine(); 
                }

                Console.WriteLine($"{movieName} - {1.0 * amountOfTicketsForCurrentProjection / freeSpaces * 100:f2}% full.");
                amountOfTicketsForCurrentProjection = 0;

                movieName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTicketsCounter}");
            Console.WriteLine($"{(double)studentTicketsCounter / totalTicketsCounter * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standartTicketsCounter / totalTicketsCounter * 100:f2}% standard tickets.");
            Console.WriteLine($"{1.0 * kidTicketsCounter / totalTicketsCounter * 100:f2}% kids tickets.");
        }
    }
}

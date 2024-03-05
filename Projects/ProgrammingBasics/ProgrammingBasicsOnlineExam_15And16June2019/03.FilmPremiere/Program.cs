using System;

namespace _03.FilmPremiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string premiereName = Console.ReadLine();
            string peckForMovie = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            switch (premiereName)
            {
                case "John Wick":
                    switch (peckForMovie)
                    {
                        case "Drink": ticketPrice = 12; break;
                        case "Popcorn": ticketPrice = 15; break;
                        case "Menu": ticketPrice = 19; break;
                    } break;
                case "Star Wars": 
                    switch (peckForMovie)
                    {
                        case "Drink": ticketPrice = 18; break;
                        case "Popcorn": ticketPrice = 25; break;
                        case "Menu": ticketPrice = 30; break;
                    } break;
                case "Jumanji": 
                    switch (peckForMovie)
                    {
                        case "Drink": ticketPrice = 9; break;
                        case "Popcorn": ticketPrice = 11; break;
                        case "Menu": ticketPrice = 14; break;
                    } break;
            }

            double sumOfAll = ticketsCount * ticketPrice;

            if (premiereName == "Star Wars" && ticketsCount >= 4) { sumOfAll *= 0.70; }
            if (premiereName == "Jumanji" && ticketsCount == 2) { sumOfAll *= 0.85; }

            Console.WriteLine($"Your bill is {sumOfAll:f2} leva.");
        }
    }
}

using System;

namespace _03.OscarsWeekInCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string typeOfHall = Console.ReadLine();
            decimal countOfTickets = decimal.Parse(Console.ReadLine());

            switch (movieName)
            {
                case "A Star Is Born": switch (typeOfHall) 
                    { 
                        case "normal": countOfTickets *= 7.50m; break;
                        case "luxury": countOfTickets *= 10.50m; break;
                        case "ultra luxury": countOfTickets *= 13.50m; break;
                    } break;

                case "Bohemian Rhapsody": switch (typeOfHall)
                    {
                        case "normal": countOfTickets *= 7.350m; break;
                        case "luxury": countOfTickets *= 9.450m; break;
                        case "ultra luxury": countOfTickets *= 12.750m; break;
                    } break;

                case "Green Book": switch (typeOfHall)
                    {
                        case "normal": countOfTickets *= 8.150m; break;
                        case "luxury": countOfTickets *= 10.250m; break;
                        case "ultra luxury": countOfTickets *= 13.250m; break;
                    } break;

                case "The Favourite":
                    switch (typeOfHall)
                    {
                        case "normal": countOfTickets *= 8.750m; break;
                        case "luxury": countOfTickets *= 11.550m; break;
                        case "ultra luxury": countOfTickets *= 13.950m; break;
                    } break;
            }

            Console.WriteLine($"{movieName} -> {countOfTickets:f2} lv.");
        }
    }
}

using System;

namespace _03.WorldSnookerChampionship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stateOfTheChampionship = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int countOfTickets = int.Parse(Console.ReadLine());
            char photoWithTropfy = char.Parse(Console.ReadLine());
            decimal sum = 0;

            switch (stateOfTheChampionship)
            {
                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard": sum = countOfTickets * 55.50m; break;
                        case "Premium": sum = countOfTickets * 105.20m; break;
                        case "VIP": sum = countOfTickets * 118.90m; break;
                    }
                    break;

                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard": sum = countOfTickets * 75.88m; break;
                        case "Premium": sum = countOfTickets * 125.22m; break;
                        case "VIP": sum = countOfTickets * 300.40m; break;
                    }
                    break;

                case "Final":
                    switch (ticketType)
                    {
                        case "Standard": sum = countOfTickets * 110.10m; break;
                        case "Premium": sum = countOfTickets * 160.66m; break;
                        case "VIP": sum = countOfTickets * 400m; break;
                    }
                    break;
            }
            switch (sum)
            {
                case > 4000: sum *= 0.75m; break;
                case > 2500: sum *= 0.90m; 
                    switch (photoWithTropfy)
                    {
                        case 'Y': sum += countOfTickets * 40; break;
                        case 'N': sum = sum; break;
                    } break;
                case < 2500: sum = sum; 
                    switch (photoWithTropfy) 
                    { 
                        case 'Y': sum += countOfTickets * 40; break;
                        case 'N': sum = sum; break;
                    }
                    break;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}

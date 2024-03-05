using System;

namespace _01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInGroup = int.Parse(Console.ReadLine());
            decimal transportTaxes = budget;
            decimal budgetWithoutTransport = 0;
            decimal total = 0;
            decimal priceOfTickets = 0;

            switch (category)
            {
                case "VIP":
                    priceOfTickets = 499.99m;
                    if (peopleInGroup > 50)
                        transportTaxes *= 0.25m;
                    
                    else if (peopleInGroup <= 4)
                        transportTaxes *= 0.75m;
                    
                    else if (peopleInGroup <= 9)
                        transportTaxes *= 0.6m;
                    
                    else if (peopleInGroup <= 24)
                        transportTaxes *= 0.5m;
                    
                    else if (peopleInGroup <= 49)
                        transportTaxes *= 0.4m;

                    budgetWithoutTransport = budget - transportTaxes;
                    total = peopleInGroup * priceOfTickets;

                    if (total <= budgetWithoutTransport) Console.WriteLine($"Yes! You have {budgetWithoutTransport - total:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {total - budgetWithoutTransport} leva.");
                    break;

                case "Normal":
                    priceOfTickets = 249.99m;
                    if (peopleInGroup > 50)
                        transportTaxes *= 0.25m;
                    
                    else if (peopleInGroup <= 4)
                        transportTaxes *= 0.75m;
                    
                    else if (peopleInGroup <= 9)
                        transportTaxes *= 0.6m;

                    else if (peopleInGroup <= 24)
                        transportTaxes *= 0.5m;
                    
                    else if (peopleInGroup <= 49)
                        transportTaxes *= 0.4m;

                    budgetWithoutTransport = budget - transportTaxes;
                    total = peopleInGroup * priceOfTickets;

                    if (total <= budgetWithoutTransport) Console.WriteLine($"Yes! You have {budgetWithoutTransport - total:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {total - budgetWithoutTransport} leva."); 
                    break;
            }
        }
    }
}

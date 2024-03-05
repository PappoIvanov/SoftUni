using System;

namespace _01.AgencyProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aircompanyName = Console.ReadLine();
            int adultsTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            decimal priceAdultTicket = decimal.Parse(Console.ReadLine());
            decimal serviceTax = decimal.Parse(Console.ReadLine());

            decimal priceKidTicket = priceAdultTicket * 0.30m;

            decimal totalSum = adultsTickets * (priceAdultTicket + serviceTax) + kidsTickets * (priceKidTicket + serviceTax);
            decimal profitOfAgency = totalSum * 0.20m;

            Console.WriteLine($"The profit of your agency from {aircompanyName} tickets is {profitOfAgency:f2} lv.");
        }
    }
}

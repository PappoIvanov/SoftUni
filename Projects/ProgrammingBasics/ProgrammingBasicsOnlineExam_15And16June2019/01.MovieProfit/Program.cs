using System;

namespace _01.MovieProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());
            int ticketsCount = int.Parse(Console.ReadLine());
            double priceOfTicket = double.Parse(Console.ReadLine());
            int rateForTheCinema = int.Parse(Console.ReadLine());

            double income = daysCount * ticketsCount * priceOfTicket;
            double profit = income - (income * rateForTheCinema / 100);

            Console.WriteLine($"The profit from the movie {movieName} is {profit:f2} lv.");
        }
    }
}

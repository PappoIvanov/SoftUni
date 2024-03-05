using System;

namespace _02.EasterParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfGuests = int.Parse(Console.ReadLine());
            decimal priceOfCover = decimal.Parse(Console.ReadLine());
            decimal budgetOfDesi = decimal.Parse(Console.ReadLine());

            decimal coverTotalAmount = countOfGuests * priceOfCover;

            if (countOfGuests >= 10 && countOfGuests <= 15) { coverTotalAmount *= 0.85m; }
            else if (countOfGuests > 15 && countOfGuests <= 20) { coverTotalAmount *= 0.80m; }
            else if (countOfGuests > 20) { coverTotalAmount *= 0.75m; }

            decimal cacePrice = budgetOfDesi * 0.1m;
            decimal sumTotalAmount = coverTotalAmount + cacePrice;

            if (budgetOfDesi >= sumTotalAmount)
            
                Console.WriteLine($"It is party time! {budgetOfDesi - sumTotalAmount:f2} leva left.");
            
            else if (budgetOfDesi < sumTotalAmount)
            
                Console.WriteLine($"No party! {sumTotalAmount - budgetOfDesi:f2} leva needed.");

        }
    }
}
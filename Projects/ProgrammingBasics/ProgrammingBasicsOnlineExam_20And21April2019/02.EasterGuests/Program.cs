using System;

namespace _02.EasterGuests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfGuests = int.Parse(Console.ReadLine());
            decimal budgetOfLiubo = decimal.Parse(Console.ReadLine());

            decimal easterCakeCount = Math.Ceiling(countOfGuests / 3.0m);
            decimal easterCakePrice = 4.0m;

            int eggsCount = countOfGuests * 2;
            decimal eggsPrice = 0.45m;

            decimal sumTotalAmount = easterCakePrice * easterCakeCount + eggsPrice * eggsCount;

            if (budgetOfLiubo >= sumTotalAmount)
            {
                Console.WriteLine($"Lyubo bought {easterCakeCount} Easter bread and {eggsCount} eggs.");
                Console.WriteLine($"He has {budgetOfLiubo - sumTotalAmount:f2} lv. left.");
            }
            else if (budgetOfLiubo < sumTotalAmount)
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {sumTotalAmount - budgetOfLiubo:f2} lv. more.");
            }
        }
    }
}

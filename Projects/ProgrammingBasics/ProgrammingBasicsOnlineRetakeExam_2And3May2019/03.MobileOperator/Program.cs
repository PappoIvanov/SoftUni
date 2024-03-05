using System;

namespace _03.MobileOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contractDeadline = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int countOfMonths = int.Parse(Console.ReadLine());
            decimal taxPrice = 0;
            decimal totalSum = 0;

            if (contractDeadline == "one")
            {
                switch (typeOfContract)
                {
                    case "Small": taxPrice = 9.98m; break;
                    case "Middle": taxPrice = 18.99m; break;
                    case "Large": taxPrice = 25.98m; break;
                    case "ExtraLarge": taxPrice = 35.99m; break;
                }
                switch (mobileInternet)
                {
                    case "yes": 
                        if (taxPrice <= 10) { taxPrice += 5.50m; }
                        else if (taxPrice <= 30) { taxPrice += 4.35m; }
                        else if (taxPrice > 30) { taxPrice += 3.85m; } break;
                }
                totalSum = taxPrice * countOfMonths;
            }
            else if (contractDeadline == "two")
            {
                switch (typeOfContract)
                {
                    case "Small": taxPrice = 8.58m; break;
                    case "Middle": taxPrice = 17.09m; break;
                    case "Large": taxPrice = 23.59m; break;
                    case "ExtraLarge": taxPrice = 31.79m; break;
                }
                switch (mobileInternet)
                {
                    case "yes": 
                        if (taxPrice <= 10) { taxPrice += 5.50m; }
                        else if (taxPrice <= 30) { taxPrice += 4.35m; }
                        else if (taxPrice > 30) { taxPrice += 3.85m; } break;
                }
                totalSum = taxPrice * countOfMonths * 0.9625m;
            }

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
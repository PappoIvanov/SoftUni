using System;

namespace _05.Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfSeries = int.Parse(Console.ReadLine());
            double totalSum = 0;


            for (int i = 1; i <= countOfSeries; i++)
            {
                string currentSerialName = Console.ReadLine();
                double priceOfCurrentSerial = double.Parse(Console.ReadLine());
                double sumOfCurrentSerial = priceOfCurrentSerial;

                switch (currentSerialName)
                {
                    case "Thrones": sumOfCurrentSerial *= 0.50; break;
                    case "Lucifer": sumOfCurrentSerial *= 0.60; break;
                    case "Protector": sumOfCurrentSerial *= 0.70; break;
                    case "TotalDrama": sumOfCurrentSerial *= 0.80; break;
                    case "Area": sumOfCurrentSerial *= 0.90; break;
                }

                totalSum += sumOfCurrentSerial;

                sumOfCurrentSerial = 0;
            }

            if (budget >= totalSum) 
            { Console.WriteLine($"You bought all the series and left with {budget - totalSum:f2} lv."); }
            else if (budget < totalSum) { Console.WriteLine($"You need {totalSum - budget:f2} lv. more to buy the series!"); }
        }
    }
}

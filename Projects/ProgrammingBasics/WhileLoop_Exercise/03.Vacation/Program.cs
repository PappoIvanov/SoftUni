using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForExcursion = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int spendingDaysInARow = 0;
            int dayCounter = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                dayCounter++;

                if (action == "save")
                {
                    availableMoney += sum;
                    spendingDaysInARow = 0;

                    if (availableMoney >= moneyForExcursion)
                    {
                        break;
                    }
                }
                else if (action == "spend")
                {
                    availableMoney -= sum;
                    if (availableMoney <= 0)
                    {
                        availableMoney = 0;
                    }
                    spendingDaysInARow++;
                    if (spendingDaysInARow >= 5)
                    {
                        break;
                    }
                }
            }

            if (availableMoney >= moneyForExcursion)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{dayCounter}");
            }
        }
    }
}

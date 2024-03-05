using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesLostCount = int.Parse(Console.ReadLine());
            int gameLostCoppy = gamesLostCount;
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashed = 0, mouseTrashed = 0, keyboardTrashed = 0, displayTrashed = 0;

            for (int gameLost = 1; gameLost <= gamesLostCount; gameLost++)
            {
                if (gameLost % 2 == 0)
                {
                    headsetTrashed++;
                }
                if (gameLost % 3 == 0)
                {
                    mouseTrashed++;
                }
                if (gameLost % 2 == 0 && gameLost % 3 == 0)
                {
                    keyboardTrashed++;
                }
            }

            displayTrashed = keyboardTrashed / 2;

            double headsetTotalPrice = headsetPrice * headsetTrashed;
            double mouseTotalPrice = mousePrice * mouseTrashed;
            double keyboardTotalPrice = keyboardPrice * keyboardTrashed;
            double displayTotalPrice = displayPrice * displayTrashed;
            double totalExpenses = headsetTotalPrice + mouseTotalPrice + keyboardTotalPrice + displayTotalPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
using System;

namespace _04.EasterShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double initalCountOfEggs = double.Parse(Console.ReadLine());
            string orderOrFillOrClose = Console.ReadLine();
            double newCountOfEggs = initalCountOfEggs;
            double countOfEggs = 0;
            double soldEggs = 0;
            bool notEnoghEggs = false;
            

            while (orderOrFillOrClose != "Close")
            {
                switch (orderOrFillOrClose) 
                {
                    case "Buy": countOfEggs = double.Parse(Console.ReadLine()); soldEggs += countOfEggs;
                        if (countOfEggs > newCountOfEggs) { notEnoghEggs = true; break; }
                        newCountOfEggs -= countOfEggs; break;
                    case "Fill": countOfEggs = double.Parse(Console.ReadLine());
                        newCountOfEggs += countOfEggs; break;
                }
                if (notEnoghEggs) break;

                orderOrFillOrClose = Console.ReadLine();
            }

            if (orderOrFillOrClose == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
            else if (newCountOfEggs < countOfEggs)
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {newCountOfEggs}.");
            }
        }
    }
}
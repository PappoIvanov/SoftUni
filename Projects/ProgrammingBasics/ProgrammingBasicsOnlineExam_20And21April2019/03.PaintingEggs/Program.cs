using System;
using System.Globalization;

namespace _03.PaintingEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sizeOfEggs = Console.ReadLine();
            string paintOfEggs = Console.ReadLine();
            int countOfConsignment = int.Parse(Console.ReadLine());
            int priceOfConsignment = 0;

            if (sizeOfEggs == "Large")
            {
                switch (paintOfEggs)
                {
                    case "Red": priceOfConsignment = 16; break;
                    case "Green": priceOfConsignment = 12; break;
                    case "Yellow": priceOfConsignment = 9; break;
                }
            }
            else if (sizeOfEggs == "Medium")
            {
                switch (paintOfEggs)
                {
                    case "Red": priceOfConsignment = 13; break;
                    case "Green": priceOfConsignment = 9; break;
                    case "Yellow": priceOfConsignment = 7; break;
                }
            }
            else if (sizeOfEggs == "Small")
            {
                switch (paintOfEggs)
                {
                    case "Red": priceOfConsignment = 9; break;
                    case "Green": priceOfConsignment = 8; break;
                    case "Yellow": priceOfConsignment = 5; break;
                }
            }

            int sumOfConsignment = countOfConsignment * priceOfConsignment;
            decimal profit = 1.0m * sumOfConsignment * 0.65m;
            Console.WriteLine($"{profit:f2} leva.");
        }
    }
}
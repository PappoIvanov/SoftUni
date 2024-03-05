using System;

namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCargos = int.Parse(Console.ReadLine());
            int sum = 0;
            int amountOfWeight = 0;
            int busCargo = 0;
            int truckCargo = 0;
            int trainCargo = 0;

            for (int i = 1; i <= countOfCargos; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    sum += 200 * weight;
                    amountOfWeight += weight;
                    busCargo += weight;
                }
                else if (weight <= 11)
                {
                    sum += 175 * weight;
                    amountOfWeight += weight;
                    truckCargo += weight;
                }
                else if (weight >= 12)
                {
                    sum += 120 * weight;
                    amountOfWeight += weight;
                    trainCargo += weight;
                }
            }

            Console.WriteLine($"{(double)sum / amountOfWeight:f2}");
            Console.WriteLine($"{(double)busCargo / amountOfWeight * 100:f2}%");
            Console.WriteLine($"{(double)truckCargo / amountOfWeight * 100:f2}%");
            Console.WriteLine($"{(double)trainCargo / amountOfWeight * 100:f2}%");
        }
    }
}

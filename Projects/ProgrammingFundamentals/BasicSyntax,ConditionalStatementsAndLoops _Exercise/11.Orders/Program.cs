using System;
using System.Diagnostics;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 0; i < numberOfOrders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double priceOfCoffee = (days * capsulesCount) * capsulePrice;
                totalPrice += priceOfCoffee;
                Console.WriteLine($"The price for the coffee is: ${priceOfCoffee:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

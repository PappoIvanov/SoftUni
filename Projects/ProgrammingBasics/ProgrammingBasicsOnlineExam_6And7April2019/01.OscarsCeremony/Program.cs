using System;

namespace _01.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal hallPrice = decimal.Parse(Console.ReadLine());

            decimal statuesPrice = hallPrice * 0.7m;
            decimal katererPrice = statuesPrice * 0.85m;
            decimal djPrice = katererPrice * 0.5m;
            
            decimal sumOfAll = hallPrice + statuesPrice + katererPrice + djPrice;
            Console.WriteLine($"{sumOfAll:f2}");
        }
    }
}

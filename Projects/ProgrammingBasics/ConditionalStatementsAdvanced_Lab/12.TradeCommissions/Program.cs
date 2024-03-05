using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());

            if (sale >= 0 && sale <= 500)
            {
                switch (city)
                {
                    case "Sofia": Console.WriteLine($"{(sale * 1.05) - sale:f2}"); break;
                    case "Varna": Console.WriteLine($"{(sale * 1.045) - sale:f2}"); break;
                    case "Plovdiv": Console.WriteLine($"{(sale * 1.055) - sale:f2}"); break;
                        default: Console.WriteLine("error"); break;
                }
            }
            else if (sale > 500 && sale <= 1000)
            {
                switch (city)
                {
                    case "Sofia": Console.WriteLine($"{(sale * 1.07) - sale:f2}"); break;
                    case "Varna": Console.WriteLine($"{(sale * 1.075) - sale:f2}"); break;
                    case "Plovdiv": Console.WriteLine($"{(sale * 1.08) - sale:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sale > 1000 && sale <= 10_000)
            {
                switch (city)
                {
                    case "Sofia": Console.WriteLine($"{(sale * 1.08) - sale:f2}"); break;
                    case "Varna": Console.WriteLine($"{(sale * 1.1) - sale:f2}"); break;
                    case "Plovdiv": Console.WriteLine($"{(sale * 1.12) - sale:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sale > 10_000)
            {
                switch (city)
                {
                    case "Sofia": Console.WriteLine($"{(sale * 1.12) - sale:f2}"); break;
                    case "Varna": Console.WriteLine($"{(sale * 1.13) - sale:f2}"); break;
                    case "Plovdiv": Console.WriteLine($"{(sale * 1.145) - sale:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

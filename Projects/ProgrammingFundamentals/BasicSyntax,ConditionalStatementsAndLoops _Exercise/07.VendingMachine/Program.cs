using System;
using System.Runtime;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);

                switch (coins)
                {
                    case 0.1: sum += 0.1; break;
                    case 0.2: sum += 0.2; break;
                    case 0.5: sum += 0.5; break;
                    case 1.0: sum += 1.0; break;
                    case 2.0: sum += 2.0; break;
                    default: Console.WriteLine($"Cannot accept {coins}"); break;
                }

                command = Console.ReadLine();
            }

            double productPrice = 0;
            string products = Console.ReadLine();
            while (products != "End")
            {
                switch (products)
                {
                    case "Nuts": productPrice = 2.0; 
                        if (sum >= productPrice)
                        {
                            sum -= productPrice; Console.WriteLine($"Purchased nuts");
                        }
                        else { Console.WriteLine("Sorry, not enough money"); }
                        break;
                    case "Water": productPrice = 0.7; 
                        if (sum >= productPrice)
                        {
                            sum -= productPrice; Console.WriteLine($"Purchased water");
                        }
                        else { Console.WriteLine("Sorry, not enough money"); }
                        break;
                    case "Crisps": productPrice = 1.5; 
                        if (sum >= productPrice)
                        {
                            sum -= productPrice; Console.WriteLine($"Purchased crisps");
                        }
                        else { Console.WriteLine("Sorry, not enough money"); }
                        break;
                    case "Soda": productPrice = 0.8; 
                        if (sum >= productPrice)
                        {
                            sum -= productPrice; Console.WriteLine($"Purchased soda");
                        }
                        else { Console.WriteLine("Sorry, not enough money"); }
                        break;
                    case "Coke": productPrice = 1.0; 
                        if (sum >= productPrice)
                        {
                            sum -= productPrice; Console.WriteLine($"Purchased coke");
                        }
                        else { Console.WriteLine("Sorry, not enough money"); }
                        break;
                    default: Console.WriteLine("Invalid product"); break;
                }

                products = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}

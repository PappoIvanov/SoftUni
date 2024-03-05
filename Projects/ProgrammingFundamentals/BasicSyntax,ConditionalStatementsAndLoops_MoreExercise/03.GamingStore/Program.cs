using System;
using System.Reflection;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OutFall 4       $39.99
            // CS: OG          $15.99
            // Zplinter Zell   $19.99
            // Honored 2       $59.99
            // RoverWatch      $29.99
            // RoverWatchOrign $39.99

            double budget = double.Parse(Console.ReadLine());
            double remainingMoney = budget, totalMoneySpent = 0, gamePrice = 0;

            string command = Console.ReadLine();
            while (command != "Game Time")
            {
                switch (command)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        if (remainingMoney >= gamePrice)
                        {
                            remainingMoney -= gamePrice;
                            totalMoneySpent += gamePrice;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        if (remainingMoney >= gamePrice)
                        {
                            remainingMoney -= gamePrice;
                            totalMoneySpent += gamePrice;
                            Console.WriteLine("Bought CS: GO");
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        if (remainingMoney >= gamePrice)
                        {
                            remainingMoney -= gamePrice;
                            totalMoneySpent += gamePrice;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        if (remainingMoney >= gamePrice)
                        {
                            remainingMoney -= gamePrice;
                            totalMoneySpent += gamePrice;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        if (remainingMoney >= gamePrice)
                        {
                            remainingMoney -= gamePrice;
                            totalMoneySpent += gamePrice;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        if (remainingMoney >= gamePrice)
                        {
                            remainingMoney -= gamePrice;
                            totalMoneySpent += gamePrice;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else { Console.WriteLine("Too Expensive"); }
                        break;
                    default: Console.WriteLine("Not Found"); command = Console.ReadLine(); continue;
                }
                if (remainingMoney <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                command = Console.ReadLine();
            }

            // Output
            Console.WriteLine($"Total spent: ${totalMoneySpent:f2}. Remaining: ${remainingMoney:f2}");
        }
    }
}

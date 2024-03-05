using System;
using System.Xml;

namespace _03.FitnessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string typeOfSport = Console.ReadLine();

            int tax = 0;

            switch (gender)
            {
                case 'm': switch (typeOfSport) 
                    {
                        case "Gym": tax = 42; break;
                        case "Boxing": tax = 41; break;
                        case "Yoga": tax = 45; break;
                        case "Zumba": tax = 34; break;
                        case "Dances": tax = 51; break;
                        case "Pilates": tax = 39; break;
                    } break;
                case 'f': switch (typeOfSport)
                    {
                        case "Gym": tax = 35; break;
                        case "Boxing": tax = 37; break;
                        case "Yoga": tax = 42; break;
                        case "Zumba": tax = 31; break;
                        case "Dances": tax = 53; break;
                        case "Pilates": tax = 37; break;
                    } break;
            }

            double discountForSudents = 0;
            if (age <= 19) { discountForSudents = tax * 0.80; }
            else { discountForSudents = tax; }

            if (budget >= discountForSudents)
            {
                Console.WriteLine($"You purchased a 1 month pass for {typeOfSport:f2}.");
            }
            else if (budget < discountForSudents)
            {
                double needemoney = discountForSudents - budget;
                Console.WriteLine($"You don't have enough money! You need ${needemoney:f2} more.");
            }
        }
    }
}

using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //     5        3.80       2.80        3          2.50

            string typeOfFlower = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosesPrice = 5.00 * countOfFlowers;
            double dahliasPrice = 3.80 * countOfFlowers;
            double tulipsPrice = 2.80 * countOfFlowers;
            double narcissusPrice = 3.00 * countOfFlowers;
            double gladiolusPrice = 2.50 * countOfFlowers;
            double sum = 0;

            if (typeOfFlower == "Roses")
            {
                sum = rosesPrice;
                if (typeOfFlower == "Roses" && countOfFlowers > 80)
                    sum = rosesPrice * 0.90;

                if (budget >= sum)
                {
                    double moneyLeft = budget - sum;
                    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlower} and {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = sum - budget;
                    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
                }
            }

            else if (typeOfFlower == "Dahlias")
            {
                sum = dahliasPrice;
                if (typeOfFlower == "Dahlias" && countOfFlowers > 90)
                    sum = dahliasPrice * 0.85;
                
                if (budget >= sum)
                {
                    double moneyLeft = budget - sum;
                    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlower} and {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = sum - budget;
                    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
                } 
            }
            
            else if (typeOfFlower == "Tulips")
            {
                sum = tulipsPrice;

                if (typeOfFlower == "Tulips" && countOfFlowers > 80)
                    sum = tulipsPrice * 0.85;

                if (budget >= sum)
                {
                    double moneyLeft = budget - sum;
                    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlower} and {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = sum - budget;
                    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
                }
            }
            else if (typeOfFlower == "Narcissus")
            {
                sum = narcissusPrice;

                if (typeOfFlower == "Narcissus" && countOfFlowers < 120)
                    sum = narcissusPrice * 1.15;

                if (budget >= sum)
                {
                    double moneyLeft = budget - sum;
                    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlower} and {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = sum - budget;
                    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
                }
            }
            else if (typeOfFlower == "Gladiolus")
            {
                sum = gladiolusPrice;

                if (typeOfFlower == "Gladiolus" && countOfFlowers < 80)
                    sum = gladiolusPrice * 1.20;
                
                if(budget >= sum)
                {
                    double moneyLeft = budget - sum;
                    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlower} and {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = sum - budget;
                    Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
                }
            }
        }
    }
}

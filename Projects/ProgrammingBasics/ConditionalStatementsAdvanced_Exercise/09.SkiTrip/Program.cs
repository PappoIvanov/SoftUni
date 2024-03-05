using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string typeOfRoom = Console.ReadLine();
            string rate = Console.ReadLine();
            double priceForOnePersonRoom = 18.00;
            double priceForApartament = 25.00;
            double priceForPresidentApartament = 35.00;
            double sum = 0;

            switch (typeOfRoom)
            {
                case "room for one person": 
                    if (days < 10)
                    {
                        sum = priceForOnePersonRoom * days;
                    }
                    else if (days <= 15)
                    {
                        sum = priceForOnePersonRoom * days;
                    }
                    else if (days > 15)
                    {
                        sum = priceForOnePersonRoom * days;
                    }

                    if (rate == "positive")
                    {
                        sum *= 1.25;
                    }
                    else if (rate == "negative")
                    {
                        sum *= 0.9;
                    }
                    break;
                case "apartment":
                    if (days < 10)
                    {
                        sum = priceForApartament * days * 0.70;
                    }
                    else if (days <= 15)
                    {
                        sum = priceForApartament * days * 0.65;
                    }
                    else if (days > 15)
                    {
                        sum = priceForApartament * days * 0.50;
                    }

                    if (rate == "positive")
                    {
                        sum *= 1.25;
                    }
                    else if (rate == "negative")
                    {
                        sum *= 0.9;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        sum = priceForPresidentApartament * days * 0.90;
                    }
                    else if (days <= 15)
                    {
                        sum = priceForPresidentApartament * days * 0.85;
                    }
                    else if (days > 15)
                    {
                        sum = priceForPresidentApartament * days * 0.80;
                    }

                    if (rate == "positive")
                    {
                        sum *= 1.25;
                    }
                    else if (rate == "negative")
                    {
                        sum *= 0.9;
                    }
                    break;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}

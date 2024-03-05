using System;
using System.Diagnostics;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal priceSinglePerson = 0, totalPrice = 0;
            decimal freePrice = 0;

            switch (dayOfWeek)
            {
                case "Friday": switch (typeOfGroup)
                    {
                        case "Students": priceSinglePerson = 8.45m; break;
                        case "Business": priceSinglePerson = 10.90m; break;
                        case "Regular": priceSinglePerson = 15.00m; break;
                    }
                    break;
                case "Saturday": switch (typeOfGroup)
                    {
                        case "Students": priceSinglePerson = 9.80m; break;
                        case "Business": priceSinglePerson = 15.60m; break;
                        case "Regular": priceSinglePerson = 20.00m; break;
                    }
                    break;
                case "Sunday": switch (typeOfGroup)
                    {
                        case "Students": priceSinglePerson = 10.46m; break;
                        case "Business": priceSinglePerson = 16.00m; break;
                        case "Regular": priceSinglePerson = 22.50m; break;
                    }
                    break;
            }

            //Console.WriteLine(priceSinglePerson);

            totalPrice = countOfPeople * priceSinglePerson;

            if (typeOfGroup == "Students" && countOfPeople >= 30)
            {
                totalPrice *= 0.85m;
            }
            if (typeOfGroup == "Business" && countOfPeople >= 100)
            {
                freePrice = 10 * priceSinglePerson;
                totalPrice -= freePrice;
            }
            if (typeOfGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                totalPrice *= 0.95m;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}

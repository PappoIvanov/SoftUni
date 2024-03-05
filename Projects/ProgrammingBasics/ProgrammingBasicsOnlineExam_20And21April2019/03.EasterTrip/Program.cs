using System;

namespace _03.EasterTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dateOfReservation = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());
            int priceOfNight = 0;

            switch (destination)
            {
                case "France": 
                    if (dateOfReservation == "21-23") { priceOfNight = 30; }
                    else if (dateOfReservation == "24-27") { priceOfNight = 35; }
                    else if (dateOfReservation == "28-31") { priceOfNight = 40; }
                    break;
                case "Italy":
                    if (dateOfReservation == "21-23") { priceOfNight = 28; }
                    else if (dateOfReservation == "24-27") { priceOfNight = 32; }
                    else if (dateOfReservation == "28-31") { priceOfNight = 39; }
                    break;
                case "Germany": 
                    if (dateOfReservation == "21-23") { priceOfNight = 32; }
                    else if (dateOfReservation == "24-27") { priceOfNight = 37; }
                    else if (dateOfReservation == "28-31") { priceOfNight = 43; }
                    break;
            }

            decimal expenditureOfTheVacation = priceOfNight * countOfNights;

            Console.WriteLine($"Easter trip to {destination} : {expenditureOfTheVacation:f2} leva.");
        }
    }
}

using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartamentPrice = 0;

            switch (month)
            {
                case "May":
                    if (countOfNights <= 7)
                    {
                        studioPrice = 50;
                        apartamentPrice = 65;
                    }
                    else if (countOfNights > 14)
                    {
                        studioPrice = 50 * 0.7;
                        apartamentPrice = 65 * 0.9;
                    }
                    else if (countOfNights > 7)
                    {
                        studioPrice = 50 * 0.95;
                        apartamentPrice = 65;
                    }
                    break;
                case "October":
                    if (countOfNights <= 7)
                    {
                        studioPrice = 50;
                        apartamentPrice = 65;
                    }
                    else if (countOfNights > 14)
                    {
                        studioPrice = 50 * 0.7;
                        apartamentPrice = 65 * 0.9;
                    }
                    else if (countOfNights > 7)
                    {
                        studioPrice = 50 * 0.95;
                        apartamentPrice = 65;
                    }
                    break;
                case "June": 
                    if (countOfNights > 14)
                    {
                        studioPrice = 75.20 * 0.8;
                        apartamentPrice = 68.70 * 0.9;
                    }
                    else
                    {
                        studioPrice = 75.20;
                        apartamentPrice = 68.70;
                    }
                    break;
                case "September":
                    if (countOfNights > 14)
                    {
                        studioPrice = 75.20 * 0.8;
                        apartamentPrice = 68.70 * 0.9;
                    }
                    else
                    {
                        studioPrice = 75.20;
                        apartamentPrice = 68.70;
                    }
                    break;
                case "July":
                    if (countOfNights > 14)
                    {
                        studioPrice = 76;
                        apartamentPrice = 77 * 0.9;
                    }
                    else
                    {
                        studioPrice = 76;
                        apartamentPrice = 77;
                    }
                    break;
                case "August":
                    if (countOfNights > 14)
                    {
                        studioPrice = 76;
                        apartamentPrice = 77 * 0.9;
                    }
                    else
                    {
                        studioPrice = 76;
                        apartamentPrice = 77;
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {apartamentPrice * countOfNights:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice * countOfNights:f2} lv.");
        }
    }
}

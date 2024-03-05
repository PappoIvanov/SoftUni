using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int sumOfExam = hourOfExam * 60 + minuteOfExam;
            int sumOfArrival = arrivalHour * 60 + arrivalMinute;

            if (sumOfExam >= sumOfArrival)
            {
                int difference = sumOfExam - sumOfArrival;
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (difference <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference >= 60)
                {
                    int hoursDifference = difference / 60;
                    int minutesDifference = difference % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hoursDifference}:{minutesDifference:d2} hours before the start");
                }
                else if (difference > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if (sumOfExam <= sumOfArrival)
            {
                int difference = sumOfArrival - sumOfExam;
                if (difference < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else if (difference >= 60)
                {
                    int hoursDifference = difference / 60;
                    int minutesDifference = difference % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hoursDifference}:{minutesDifference:d2} hours after the start");
                }
            }
        }
    }
}
    
        
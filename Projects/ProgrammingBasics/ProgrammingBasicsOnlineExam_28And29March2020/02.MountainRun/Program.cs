using System;

namespace _02.MountainRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hikkingRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double slowingUp = Math.Floor(distance / 50);
            slowingUp *= 30;
            double georgeTime = timePerMeter * distance + slowingUp;

            if (georgeTime < hikkingRecord)
            {
                Console.WriteLine($"Yes! The new record is {georgeTime:f2} seconds.");
            }
            else if (georgeTime >= hikkingRecord)
            {
                double neededSeconds = georgeTime - hikkingRecord;
                Console.WriteLine($"No! He was {neededSeconds:f2} seconds slower.");
            }
        }
    }
}

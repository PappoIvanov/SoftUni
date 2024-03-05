using System;

namespace _01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double haritageMoney = double.Parse(Console.ReadLine());
            int ageToLive = int.Parse(Console.ReadLine());
            int startingAge = 1800;
            int ivansAge = 18;

            while (startingAge <= ageToLive)
            {
                if (startingAge % 2 == 0) haritageMoney -= 12_000;
                else haritageMoney = haritageMoney - (12_000 + 50 * ivansAge);

                startingAge++;
                ivansAge++;
            }

            if (haritageMoney >= 0) Console.WriteLine($"Yes! He will live a carefree life and will have {haritageMoney:f2} dollars left.");
            else Console.WriteLine($"He will need {Math.Abs(haritageMoney):f2} dollars to survive.");
        }
    }
}

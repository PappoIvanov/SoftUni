using System;

namespace _03.AluminumJoinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joineryCount = int.Parse(Console.ReadLine());
            string typeOfJoinery = Console.ReadLine();
            string dellivery = Console.ReadLine();

            decimal totalSum = 0, priceOfJoinery = 0;

            if (joineryCount < 10) { Console.WriteLine("Invalid order"); return; }

            switch (typeOfJoinery)
            {
                case "90X130": priceOfJoinery = 110.00m;
                    switch (joineryCount)
                    {
                        case > 60: priceOfJoinery *= 0.92m; break;
                        case > 30: priceOfJoinery *= 0.95m; break;
                    }
                    totalSum = joineryCount * priceOfJoinery;

                    switch (dellivery)
                    {
                        case "With delivery": totalSum += 60; break;
                    } break;
                case "100X150":
                    priceOfJoinery = 140.00m;
                    switch (joineryCount)
                    {
                        case > 80: priceOfJoinery *= 0.90m; break;
                        case > 40: priceOfJoinery *= 0.94m; break;
                    }
                    totalSum = joineryCount * priceOfJoinery;

                    switch (dellivery)
                    {
                        case "With delivery": totalSum += 60; break;
                    } break;
                case "130X180":
                    priceOfJoinery = 190.00m;
                    switch (joineryCount)
                    {
                        case > 50: priceOfJoinery *= 0.88m; break;
                        case > 20: priceOfJoinery *= 0.93m; break;
                    }
                    totalSum = joineryCount * priceOfJoinery;

                    switch (dellivery)
                    {
                        case "With delivery": totalSum += 60; break;
                    } break;
                case "200X300":
                    priceOfJoinery = 250.00m;
                    switch (joineryCount)
                    {
                        case > 50: priceOfJoinery *= 0.86m; break;
                        case > 25: priceOfJoinery *= 0.91m; break;
                    }
                    totalSum = joineryCount * priceOfJoinery;

                    switch (dellivery)
                    {
                        case "With delivery": totalSum += 60; break;
                    } break;
            }

            if (joineryCount > 99) { totalSum *= 0.96m; }

            Console.WriteLine($"{totalSum:f2} BGN");
        }
    }
}

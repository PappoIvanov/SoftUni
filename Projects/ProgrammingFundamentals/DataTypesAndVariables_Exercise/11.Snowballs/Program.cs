using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int snowballSnow = 0, bestSnowballSnow = 0;
            int snowballTime = 0, bestSnowballTime = 0;
            int snowballQuality = 0, bestSnowballQuality = 0;
            BigInteger bestSnowball = int.MinValue;

            for (int currentSnowball = 0; currentSnowball < numberOfSnowballs; currentSnowball++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                int snowballDivision = snowballSnow / snowballTime;
                BigInteger snowBallResult = BigInteger.Pow(snowballDivision, snowballQuality);

                if (snowBallResult > bestSnowball)
                {
                    bestSnowball = snowBallResult;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowball} ({bestSnowballQuality})");
        }
    }
}

//int numberOfSnowballs = int.Parse(Console.ReadLine());
//BigInteger snowballSnow = 0, bestSnowballSnow = 0;
//BigInteger snowballTime = 0, bestSnowballTime = 0;
//int snowballQuality = 0, bestSnowballQuality = 0;
//BigInteger bestSnowball = int.MinValue;

//for (int currentSnowball = 0; currentSnowball < numberOfSnowballs; currentSnowball++)
//{
//    snowballSnow = BigInteger.Parse(Console.ReadLine());
//    snowballTime = BigInteger.Parse(Console.ReadLine());
//    snowballQuality = int.Parse(Console.ReadLine());

//    BigInteger snowballDivision = snowballSnow / snowballTime;
//    BigInteger snowBallResult = BigInteger.Pow(snowballDivision, snowballQuality);

//    if (snowBallResult > bestSnowball)
//    {
//        bestSnowball = snowBallResult;
//        bestSnowballSnow = snowballSnow;
//        bestSnowballTime = snowballTime;
//        bestSnowballQuality = snowballQuality;
//    }
//}
//Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowball} ({bestSnowballQuality})");
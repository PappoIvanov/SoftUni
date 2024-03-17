using System.Runtime.Serialization.Formatters;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestKegModel = "";


            double currentKegVolume = 0;
            string kegModel = "";

            for (int j = 0; j < numberOfKegs; j++)
            {
                kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                currentKegVolume = Math.PI * kegRadius * kegRadius * kegHeight;

                if (currentKegVolume > biggestKeg)
                {
                    biggestKeg = currentKegVolume;
                    biggestKegModel = kegModel;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}

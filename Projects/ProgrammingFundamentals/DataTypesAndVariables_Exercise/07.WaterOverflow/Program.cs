namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = 255;
            int numberOfLines = int.Parse(Console.ReadLine());
            int sumPouredWater = 0, currentVolume = poolVolume;

            for (int times = 0; times < numberOfLines; times++)
            {
                int currentWaterQuantity = int.Parse(Console.ReadLine());

                if (currentVolume >= currentWaterQuantity)
                {
                    currentVolume -= currentWaterQuantity;
                    sumPouredWater += currentWaterQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sumPouredWater);
        }
    }
}

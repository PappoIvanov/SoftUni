namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int storagedSpices = 0, currentSpicesQuantity = 0, workingDaysCounter = 0;
            int workersConsumption = 26;

            while (startingYield >= 100)
            {
                storagedSpices += startingYield;
                storagedSpices -= workersConsumption;
                startingYield -= 10;
                workingDaysCounter++;
            }

            if (storagedSpices >= workersConsumption)
            {
                storagedSpices -= workersConsumption;
            }

            Console.WriteLine(workingDaysCounter);
            Console.WriteLine(storagedSpices);
        }
    }
}

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int startingPokePower = int.Parse(Console.ReadLine());
            //int distance = int.Parse(Console.ReadLine());
            //int exhaustionFactor = int.Parse(Console.ReadLine());
            //int currentPokePower = startingPokePower;
            //int pokesCounter = 0;

            //while (currentPokePower >= distance)
            //{
            //    if (currentPokePower == startingPokePower / 2 && exhaustionFactor > 0)
            //    {
            //        currentPokePower /= exhaustionFactor;
            //    }

            //    if (currentPokePower >= distance)
            //    {
            //        currentPokePower -= distance;
            //        pokesCounter++;
            //    }
            //    else { break; }
            //}

            //Console.WriteLine(currentPokePower);
            //Console.WriteLine(pokesCounter);

            //Second decision

            int startingPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int currPokePower = startingPokePower;
            int pokesCount = 0;

            while (currPokePower >= distance)
            {
                currPokePower -= distance;
                pokesCount++;

                if (startingPokePower * 0.5 == currPokePower && exhaustionFactor > 0)
                {
                    currPokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(currPokePower);
            Console.WriteLine(pokesCount);
        }
    }
}

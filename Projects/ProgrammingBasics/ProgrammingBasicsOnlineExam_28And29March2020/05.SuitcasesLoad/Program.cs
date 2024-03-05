using System;

namespace _05.SuitcasesLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double luggageVolume = double.Parse(Console.ReadLine());
            double suitcaseVolume = 0;
            int counter = 0;
            bool notEnd = true;
            //double currentVolume = 0;
            string command = Console.ReadLine();

            while (command != "End")
            {
                suitcaseVolume = double.Parse(command);

                if (suitcaseVolume > luggageVolume)
                {
                    break;
                }

                counter++;
                if (counter % 3 == 0)
                {
                    suitcaseVolume = suitcaseVolume * 1.1;
                }

                luggageVolume -= suitcaseVolume;

                command = Console.ReadLine();
            }

            if (command == "End") { notEnd = false; }

            if (!notEnd)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else if (notEnd)
            {
                Console.WriteLine($"No more space!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}

using System;

namespace _06.TheMostPowerfulWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string mostPowerFullWord = "";
            double maxPoints = int.MinValue;

            while (word != "End of words")
            {
                double sumOfPoints = 0;

                // Вътрешният фор цикъл се използва единствено за сумиране сборът от символите на конкретната дума.
                for (int i = 0; i < word.Length; i++)
                {
                    int currentPoints = word[i];
                    sumOfPoints += currentPoints;
                }

                int wordLenght = word.Length;
                string input = word.ToLower();

                if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u' || input[0] == 'y')
                {
                    sumOfPoints *= wordLenght;
                }
                else { sumOfPoints = Math.Floor(sumOfPoints / wordLenght); }

                if (sumOfPoints > maxPoints)
                {
                    maxPoints = sumOfPoints;
                    mostPowerFullWord = word;
                }

                word = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {mostPowerFullWord} - {maxPoints}");
        }
    }
}

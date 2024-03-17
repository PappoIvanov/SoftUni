namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                char firstSymbol = (char)('a' + i);

                for (int j = 0; j < number; j++)
                {
                    char secondSymbol = (char)('a' + j);

                    for (int k = 0; k < number; k++)
                    {
                        char thirdSymbol = (char)('a' + k);
                        Console.WriteLine($"{firstSymbol}{secondSymbol}{thirdSymbol}");
                    }
                }
            }
        }
    }
}

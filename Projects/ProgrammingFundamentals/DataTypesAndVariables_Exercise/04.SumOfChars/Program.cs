namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0, currentSymbol = 0;

            for (int currentLetter = 0; currentLetter < numberOfLines; currentLetter++)
            {
                char letter = char.Parse(Console.ReadLine());
                currentSymbol = (int)letter;
                sum += currentSymbol;
            }
            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}


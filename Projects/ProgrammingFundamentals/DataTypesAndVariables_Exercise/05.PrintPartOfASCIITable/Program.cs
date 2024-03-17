namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startPoint = int.Parse(Console.ReadLine());
            int endPoint = int.Parse(Console.ReadLine());

            for (int currentSymbol = startPoint; currentSymbol <= endPoint; currentSymbol++)
            {
                
                Console.Write((char)currentSymbol + " ");
            }
        }
    }
}

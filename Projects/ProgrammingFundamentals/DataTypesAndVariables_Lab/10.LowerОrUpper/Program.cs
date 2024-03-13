namespace _10.LowerОrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (Char.IsUpper(symbol))
            {
                Console.WriteLine("upper-case");
            }
            else if (Char.IsLower(symbol))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

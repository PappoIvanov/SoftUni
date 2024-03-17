namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int multiplyNumber = int.Parse(Console.ReadLine());

            int result = (firstNumber + secondNumber) / divideNumber * multiplyNumber;
            Console.WriteLine(result);
        }
    }
}
